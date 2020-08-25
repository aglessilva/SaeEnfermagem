using AppInternacao.Enum;
using AppInternacao.Model;
using AppInternacao.Presenter;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AppInternacao.FrmSae
{
    public partial class UCPrescricaoCiclo : UserControl
    {
        PrescricaoMedica prescricaoMedica = null;
        private PresenterGeneric presenterGeneric;
        private List<ChavePrescricao> lstChavePrescricoes = null;
        public UCPrescricaoCiclo()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            prescricaoMedica = new PrescricaoMedica();
            new ToolTip() { UseAnimation = true, IsBalloon = true }.SetToolTip(btnNewLine, "Adicionar nova linha no cliclo da Prescrição");
            new ToolTip() { UseAnimation = true, IsBalloon = true }.SetToolTip(btnAddDia, "Adicionar 1 dia no ciclo da prescrição");
            new ToolTip() { UseAnimation = true, IsBalloon = true }.SetToolTip(btnRemoveDia, "Remove o último dia do ciclo da prescrição");
            presenterGeneric = new PresenterGeneric();
        }

        DataTable table;
        List<DateTime> lst = null;

        List<string> lstIgnore = new List<string>() { "Id", "Horário", "IdCliente", "IdPaciente", "Prescrição", "IsOk", "Checado", "IdChavePrescricao"  };

        void ConfigGrid()
        {
            dataGridViewPrescricoes.Columns["Id"].Visible = false;
            dataGridViewPrescricoes.Columns["IsOk"].Visible = false;
            dataGridViewPrescricoes.Columns["IdChavePrescricao"].Visible = false;
            dataGridViewPrescricoes.Columns["IdCliente"].Visible = false;
            dataGridViewPrescricoes.Columns["IdPaciente"].Visible = false;
            dataGridViewPrescricoes.Columns["Prescrição"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewPrescricoes.Columns["Prescrição"].MinimumWidth = 300;
            //dataGridViewPrescricoes.Columns["Justificativa"].Visible = false;

            foreach (DataGridViewColumn item in dataGridViewPrescricoes.Columns)
            {
                if (!lstIgnore.Any(c => c.Contains(item.DataPropertyName)))
                    item.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            }
        }

        private void AddNewRows()
        {
            try
            {
                List<CicloPrescricao> lstCiclo = presenterGeneric.GetLista(new CicloPrescricao()
                {
                    IdChavePrescricao = prescricaoMedica.IdChavePrescricao,
                    IdPaciente = Sessao.Paciente.Id
                }
                , Procedure.SP_GET_CLICLO);

                DataColumn dataColumn = null;
                DataRow row = table.NewRow();

                row["Id"] = prescricaoMedica.Id;
                row["IsOk"] = false;
                row["IdCliente"] = Sessao.CodigoCliente;
                row["IdChavePrescricao"] = prescricaoMedica.IdChavePrescricao;
                row["IdPaciente"] = Sessao.Paciente.Id;
                row["Horário"] = "00:00";
                row["Checado"] = "00:00";
                row["Prescrição"] = string.Empty;
                row["Justificativa"] = string.Empty;


                foreach (DataColumn item in table.Columns)
                {
                    if (item.DataType == typeof(Image))
                    {
                        if (item.ColumnName.Equals("Act"))
                            continue;

                        if (Convert.ToDateTime(item.Caption) >= DateTime.Now.Date)
                            row[item.ColumnName] = Properties.Resources.Wait;
                        else
                            row[item.ColumnName] = Properties.Resources.integative;

                        if (table.Rows.Count == 0)
                            item.ExtendedProperties.Add("Id", lstCiclo.Find(c => c.DataCiclo.Equals(Convert.ToDateTime(item.Caption))).Id);
                    }
                }


                if (table.Columns.Contains("Act"))
                {
                    dataColumn = table.Columns[((dataGridViewPrescricoes.ColumnCount - 1))];
                    table.Columns.RemoveAt((dataGridViewPrescricoes.ColumnCount - 1));
                    table.Columns.Add(dataColumn);
                }
                else
                {
                    table.Columns.Add(new DataColumn("Act", typeof(Image)));
                }

                if (table.Rows.Count > 0)
                {
                    foreach (DataRow item in table.Rows)
                    {
                        item["Act"] = Properties.Resources.rubbishbin_102620;
                    }
                }

                row["Act"] = Properties.Resources.rubbishbin_102620;
                table.Rows.Add(row);
                ConfigGrid();

                btnNewLine.Enabled = table != null;
                btnAddDia.Visible = btnRemoveDia.Visible = table.Rows.Count > 0;
            }
            catch (Exception exNewLn)
            {
                FrmMain.Alert(100, exNewLn);
            }
        }

        private void UCPrescricaoCiclo_Load(object sender, EventArgs e)
        {
            FrmMain.myNovo.Click += MyNovo_Click;

            lblNome.Text = Sessao.Paciente.Nome;
            lblIdade.Text = Sessao.Paciente.Idade.ToString();
            lblLeito.Text = Sessao.Paciente.NomeLeito;
            lblProntuario.Text = Sessao.Paciente.Prontuario.ToString();

            GetDatas();

            // TODO: CARREGAR PRESCRIÇÃO CADASTRADA
            //List<PrescricaoMedica> lstPrescricao = presenterGeneric.GetLista(prescricaoMedica, Procedure.SP_GET_PRESCRICAO);

        }

        void GetDatas()
        {
            lstChavePrescricoes = presenterGeneric.GetLista(new ChavePrescricao() { idPaciente = Sessao.Paciente.Id }, Procedure.SP_GET_CHAVE_PRESCRICAO);
            comboBoxDataPrescricao.DataSource = lstChavePrescricoes;
        }

        private void MyNovo_Click(object sender, EventArgs e)
        {
            btnAddCiclo.Visible = CalendarCicloPrescricao.Enabled  = true;
            dataGridViewPrescricoes.DataSource = null;
            lblCicloPrescricao.Visible = false;
        }

        private void CalendarCicloPrescricao_DateSelected(object sender, DateRangeEventArgs e)
        {
            int intervalor = (int)(e.End - e.Start).TotalDays + 1;
            lblCicloPrescricao.Visible = intervalor > 0;
            lblCicloPrescricao.Text = $"Prescrição com o ciclo de {intervalor + (intervalor > 1 ? " dias" : " dia") }";
        }

        private void btnAddCiclo_Click(object sender, EventArgs e)
        {

            if (CalendarCicloPrescricao.SelectionStart < DateTime.Now.Date)
            {
                MessageBox.Show("Selecione uma data ou intervalo de datas maior que a data atual", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                prescricaoMedica.IdChavePrescricao = presenterGeneric.Salvar(new ChavePrescricao() { idPaciente = Sessao.Paciente.Id }, Procedure.SP_ADD_CHAVE_PRESCRICAO);

                CalendarCicloPrescricao.SelectionRange = new SelectionRange(CalendarCicloPrescricao.SelectionStart, CalendarCicloPrescricao.SelectionEnd);
                lst = new List<DateTime>();
                DateTime dateTime = CalendarCicloPrescricao.SelectionStart;
                table = new DataTable();

                table.Columns.Add(new DataColumn("Id", typeof(int)));
                table.Columns.Add(new DataColumn("IsOk", typeof(bool)));
                table.Columns.Add(new DataColumn("IdChavePrescricao", typeof(int)));
                table.Columns.Add(new DataColumn("IdCliente", typeof(int)));
                table.Columns.Add(new DataColumn("IdPaciente", typeof(int)));
                table.Columns.Add(new DataColumn("Prescrição", typeof(string)));
                table.Columns.Add(new DataColumn("Justificativa", typeof(string)) { ReadOnly = true });
                table.Columns.Add(new DataColumn("Horário", typeof(TimeSpan)));
                table.Columns.Add(new DataColumn("Checado", typeof(TimeSpan)));

                table.Columns["Checado"].ReadOnly = true;

                prescricaoMedica.IdPaciente = Sessao.Paciente.Id;
                prescricaoMedica.Prescricao = null;
                prescricaoMedica.Horario = null;

                prescricaoMedica.Id = presenterGeneric.InsertPrescricao(prescricaoMedica);

                while (dateTime <= CalendarCicloPrescricao.SelectionEnd)
                {
                    table.Columns.Add(new DataColumn(dateTime.ToString("dd/MM"), typeof(Image)));
                    lst.Add(dateTime);
                    dateTime = dateTime.AddDays(1);
                }

                DateTime[] det = lst.ToArray();
                lst.Clear();

                dataGridViewPrescricoes.DataSource = null;
                dataGridViewPrescricoes.DataSource = table;
                CalendarCicloPrescricao.BoldedDates = det;
                DataTable dataTable = new DataTable();
                DataRow dataRow = null;
                List<DataColumn> dataColumns = table.Columns.OfType<DataColumn>().Where(dc => dc.DataType == typeof(Image)).ToList();

                dataTable.Columns.Add(new DataColumn("Id", typeof(int)));
                dataTable.Columns.Add(new DataColumn("IdCliente", typeof(int)));
                dataTable.Columns.Add(new DataColumn("IdChavePrescricao", typeof(int)));
                dataTable.Columns.Add(new DataColumn("IdPaciente", typeof(int)));
                dataTable.Columns.Add(new DataColumn("IdPrescricao", typeof(string)));
                dataTable.Columns.Add(new DataColumn("Checado", typeof(DateTime)));
                dataTable.Columns.Add(new DataColumn("DataCiclo", typeof(DateTime)));
                dataTable.Columns.Add(new DataColumn("StatusCiclo", typeof(bool)));
                dataTable.Columns.Add(new DataColumn("Justificativa", typeof(string)));

                foreach (DataColumn item in dataColumns)
                {
                    if (item.Caption.Equals("Act"))
                        continue;
                    dataRow = dataTable.NewRow();
                    dataRow["Id"] = 0;
                    dataRow["IdCliente"] = Sessao.CodigoCliente;
                    dataRow["IdChavePrescricao"] = prescricaoMedica.IdChavePrescricao;
                    dataRow["IdPaciente"] = Sessao.Paciente.Id;
                    dataRow["IdPrescricao"] = string.Empty;
                    dataRow["Checado"] = DBNull.Value;
                    dataRow["DataCiclo"] = Convert.ToDateTime(item.Caption).Date;
                    dataRow["StatusCiclo"] = false;
                    dataRow["Justificativa"] = null;

                    dataTable.Rows.Add(dataRow);
                }

                presenterGeneric.InsertCiclo(dataTable);

                GetDatas();

                AddNewRows();

                btnNewLine.Enabled = table != null;
                btnAddDia.Enabled = btnRemoveDia.Enabled = dataTable.Rows.Count > 0;
                btnAddCiclo.Visible = false;

            }
            catch (Exception exCiclo)
            {
                FrmMain.Alert(100, exCiclo);
            }
        }

        private void btnNewLine_Click(object sender, EventArgs e)
        {
            try
            {
                prescricaoMedica.IdPaciente = Sessao.Paciente.Id;
                prescricaoMedica.Id = 0;
                prescricaoMedica.IdChavePrescricao = Convert.ToInt32(comboBoxDataPrescricao.SelectedValue);
                prescricaoMedica.Prescricao = null;
                prescricaoMedica.Horario = null;

                prescricaoMedica.Id = presenterGeneric.InsertPrescricao(prescricaoMedica);

                AddNewRows();
            }
            catch (Exception exNewLinhe)
            {
                FrmMain.Alert(100, exNewLinhe);
            }
        }



        private void dataGridViewPrescricoes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string _justificativa = string.Empty;
                DataGridView sendGrid = (DataGridView)sender;
                DataRow dataRow = table.Rows[e.RowIndex];

                if (sendGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn)
                {
                    if (e.ColumnIndex >= 2 && dataGridViewPrescricoes.Columns[e.RowIndex].Name != "Act")
                    {
                        DateTime dateTime = Convert.ToDateTime(dataGridViewPrescricoes.Columns[e.ColumnIndex].HeaderText);
                        if (dateTime.Equals(DateTime.Now.Date))
                        {
                            if (Sessao.Usuario.Perfil.HasFlag(Perfil.Enfermeiro_Assistemcial))
                            {
                                TimeSpan time = (TimeSpan)dataGridViewPrescricoes["Horário", e.RowIndex].Value;
                                if (DateTime.Now.TimeOfDay - time > new TimeSpan(1, 0, 59) || DateTime.Now.TimeOfDay - time < new TimeSpan(-1, 0, 59))
                                {
                                    string msgBox = "Essa linha de prescrição, tem mais de 1:00 atrasada ou adiantada do horario previsto.";
                                    msgBox += "\nDeseja realizar a checagem e justificar no motivo.";

                                    if (MessageBox.Show(msgBox, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        table.Columns["Justificativa"].ReadOnly = false;

                                        DialogResult dialog = new Frm.FrmJustificarChecagem(dataRow).ShowDialog();
                                        table.Columns["Justificativa"].ReadOnly = true;
                                        if (dialog != DialogResult.OK)
                                            return;
                                        else
                                        {
                                            sendGrid.Rows[e.RowIndex].Cells["Justificativa"].ReadOnly = false;
                                            _justificativa = sendGrid.Rows[e.RowIndex].Cells["Justificativa"].Value.ToString();
                                            sendGrid.Rows[e.RowIndex].Cells["Justificativa"].ReadOnly = true;
                                        }

                                    }
                                    else
                                        return;
                                }
                            }
                            else
                                return;

                            bool isChecado = false;

                            if (dataGridViewPrescricoes.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag == null || (int)dataGridViewPrescricoes.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag == 0)
                            {
                                dataGridViewPrescricoes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.IsOk;
                                dataGridViewPrescricoes.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag = 1;
                                dataGridViewPrescricoes.Rows[e.RowIndex].Cells["IsOk"].Value = true;
                                table.Columns["Checado"].ReadOnly = false;
                                dataGridViewPrescricoes.Rows[e.RowIndex].Cells["Checado"].Value = DateTime.Now.ToShortTimeString();
                                table.Columns["Checado"].ReadOnly = true;
                                isChecado = true;
                            }
                            else
                            {
                                dataGridViewPrescricoes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.Wait;
                                dataGridViewPrescricoes.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag = 0;
                                dataGridViewPrescricoes.Rows[e.RowIndex].Cells["IsOk"].Value = false;
                            }

                            presenterGeneric.Salvar(new CicloPrescricao()
                            {
                                Id = Convert.ToInt32(table.Columns[e.ColumnIndex].ExtendedProperties["Id"]),
                                StatusCiclo = isChecado,
                                IdPaciente = Sessao.Paciente.Id,
                                IdPrescricao = dataGridViewPrescricoes.Rows[e.RowIndex].Cells[0].Value.ToString(),
                                IdChavePrescricao = Convert.ToInt32(table.Rows[e.RowIndex]["IdChavePrescricao"]),
                                Checado = DateTime.Now,
                                Justificativa = _justificativa
                            }, Procedure.SP_ADD_DATE, Acao.Atualizar);

                        }
                        else
                            MessageBox.Show("Não é permitido realizar checagem de cuidados prescritos em datas passadas ou futuras", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                if (sendGrid.Columns[e.ColumnIndex].Name.Equals("Justificativa"))
                {
                    new Frm.FrmJustificarChecagem(dataRow, false).ShowDialog();
                }
                

            }
            catch (Exception exChekPrescricao)
            {
                FrmMain.Alert(100, exChekPrescricao);
            }
        }

        private void dataGridViewPrescricoes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               

                if (dataGridViewPrescricoes.Columns[e.ColumnIndex].DataPropertyName.Equals("Horário"))
                {
                    bool item = DateTime.TryParse(dataGridViewPrescricoes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out DateTime time);
                    if (!item)
                    {
                        MessageBox.Show($"Horario invalido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                prescricaoMedica.Id = Convert.ToInt32(dataGridViewPrescricoes.Rows[e.RowIndex].Cells["Id"].Value);
                prescricaoMedica.IdPaciente = Sessao.Paciente.Id;
                prescricaoMedica.Prescricao = dataGridViewPrescricoes.Rows[e.RowIndex].Cells["Prescrição"].Value.ToString();
                prescricaoMedica.Horario = TimeSpan.Parse(dataGridViewPrescricoes.Rows[e.RowIndex].Cells["Horário"].Value.ToString());

                presenterGeneric.InsertPrescricao(prescricaoMedica);
            }
            catch (Exception exEditRow)
            {
                FrmMain.Alert(100, exEditRow);
            }
        }

        private void dataGridViewPrescricoes_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void dataGridViewPrescricoes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPrescricoes.Columns[e.ColumnIndex].DataPropertyName.Equals("Act"))
            {
                try
                {
                    int _id = Convert.ToInt32(table.Rows[e.RowIndex][0]);
                    _id = presenterGeneric.Salvar(new PrescricaoMedica() { Id = _id }, Procedure.SP_DEL_PRESCRICAO, Acao.Excluir);

                    if (_id > 0)
                    {
                        _id = Convert.ToInt32(table.Rows[e.RowIndex]["IdChavePrescricao"]);
                        table.Rows.RemoveAt(e.RowIndex);

                        if (table.Rows.Count == 0)
                        {
                            _id = presenterGeneric.Salvar(new PrescricaoMedica() { Id = _id }, Procedure.SP_DEL_CHAVE_PRESCRICAO, Acao.Excluir);
                            table = null;
                            dataGridViewPrescricoes.DataSource = null;
                            lblCicloPrescricao.Visible = false;
                            btnAddDia.Enabled = btnNewLine.Enabled = btnRemoveDia.Enabled =  false;
                            GetDatas();
                        }
                    }
                }
                catch (Exception exRemoveItem)
                {
                    FrmMain.Alert(100, exRemoveItem);
                }
            }
        }

        private void btnAddDia_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime newDate = CalendarCicloPrescricao.SelectionStart;
                string headerValue = dataGridViewPrescricoes.Columns[dataGridViewPrescricoes.ColumnCount - 2].HeaderText;

                if (!lstIgnore.Any(i => i.Equals(headerValue)))
                {
                    newDate = Convert.ToDateTime(dataGridViewPrescricoes.Columns[dataGridViewPrescricoes.ColumnCount - 2].HeaderText);
                    newDate = newDate.AddDays(1);
                }

                int idDateCiclo = presenterGeneric.Salvar(new CicloPrescricao()
                {
                    DataCiclo = newDate,
                    IdChavePrescricao = Convert.ToInt32(comboBoxDataPrescricao.SelectedValue),
                    IdPaciente = Sessao.Paciente.Id
                },
                    Procedure.SP_ADD_DATE);

                DataColumn dataColumn = table.Columns[((dataGridViewPrescricoes.ColumnCount - 1))];
                table.Columns.RemoveAt((dataGridViewPrescricoes.ColumnCount - 1));

                DataColumn dataColumnNewDate = new DataColumn(newDate.ToString("dd/MM"), typeof(Image));
                dataColumnNewDate.ExtendedProperties.Add("Id", idDateCiclo);

                table.Columns.Add(dataColumnNewDate);
                table.Columns.Add(dataColumn);

                foreach (DataRow item in table.Rows)
                {
                    item["Act"] = Properties.Resources.rubbishbin_102620;
                    item[newDate.ToString("dd/MM")] = Properties.Resources.Wait;
                }

                ConfigGrid();

            }
            catch (Exception exEAddDia)
            {
                FrmMain.Alert(100, exEAddDia);
            }
        }

        private void btnRemoveDia_Click(object sender, EventArgs e)
        {
            try
            {
                DataColumn ob = table.Columns.OfType<DataColumn>().LastOrDefault(d => Convert.ToInt32(d.ExtendedProperties["Id"]) > 0);
                if (ob == null)
                    return;

               int ret = presenterGeneric.Salvar(new CicloPrescricao()
                {
                    Id = Convert.ToInt32(ob.ExtendedProperties["Id"]),
                    IdPaciente = Sessao.Paciente.Id
                }, Procedure.SP_DEL_DATE_PRESCRICAO, Acao.Excluir);

              
                    table.Columns.Remove(ob);
            }
            catch (Exception exRemovDia)
            {
                FrmMain.Alert(100, exRemovDia);
            }
        }

        private void dataGridViewPrescricoes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView sendGrid = (DataGridView)sender;
            sendGrid.Rows[e.RowIndex].Cells["Justificativa"].ReadOnly = true;
        }
    }
}
