using AppInternacao.Enum;
using AppInternacao.Model;
using AppInternacao.Presenter;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace AppInternacao.FrmSae
{
    public partial class UCPrescricaoCiclo : UserControl
    {
        PrescricaoMedica prescricaoMedica = null;
        private PresenterGeneric presenterGeneric;
        List<PrescricaoMedica> lstPrescricao = null;
        List<CicloPrescricao> lstCiclo = null;
        private List<ChavePrescricao> lstChavePrescricoes = null;
        DataTable table;
        List<DateTime> lst = null;
        List<string> lstIgnore = new List<string>() { "Id", "Horário", "IdCliente", "IdPaciente", "Prescrição",  "IdChavePrescricao"  };

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

        private void UCPrescricaoCiclo_Load(object sender, EventArgs e)
        {
            FrmMain.myNovo.Click += MyNovo_Click;

            btnCriarPrescricao.Enabled = Sessao.Usuario.Perfil.HasFlag(Perfil.Enfermeiro_Assistemcial);
            btnNewLine.Enabled = Sessao.Usuario.Perfil.HasFlag(Perfil.Medicos);
            btnRemoveDia.Enabled = Sessao.Usuario.Perfil.HasFlag(Perfil.Medicos);
            btnAddCiclo.Enabled = Sessao.Usuario.Perfil.HasFlag(Perfil.Medicos);
            btnAddDia.Enabled = CalendarCicloPrescricao.Enabled =  Sessao.Usuario.Perfil.HasFlag(Perfil.Medicos);

            CriaDataTable();
            GetDatas();
        }

        private void CalendarCicloPrescricao_DateSelected(object sender, DateRangeEventArgs e)
        {
            int intervalor = (int)(e.End - e.Start).TotalDays + 1;
            lblCicloPrescricao.Visible = intervalor > 0;
            lblCicloPrescricao.Text = $"Prescrição com o ciclo de {intervalor + (intervalor > 1 ? " dias" : " dia ")} {(!btnAddCiclo.Visible ? "\nNova prescrição, clique no botão 'Novo'" : "")}";
        }

        private void MyNovo_Click(object sender, EventArgs e)
        {
            if (Sessao.Usuario.Perfil.HasFlag(Perfil.Medicos))
            {
                pNamePrescricao.BringToFront();
                pNamePrescricao.Visible = true;
                dataGridViewPrescricoes.DataSource = null;
                table = null;
                comboBoxDataPrescricao.SelectedIndex = 0;
            }
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
                btnAddDia.Enabled = btnNewLine.Enabled = btnRemoveDia.Enabled = true;

                prescricaoMedica.IdChavePrescricao = presenterGeneric.Salvar(new ChavePrescricao() { idPaciente = Sessao.Paciente.Id, NomePrescricao = textBoxNomePrescricao.Text }, Procedure.SP_ADD_CHAVE_PRESCRICAO);
                textBoxNomePrescricao.Text = string.Empty;

                CalendarCicloPrescricao.SelectionRange = new SelectionRange(CalendarCicloPrescricao.SelectionStart, CalendarCicloPrescricao.SelectionEnd);
                lst = new List<DateTime>();
                DateTime dateTime = CalendarCicloPrescricao.SelectionStart;

                CriaDataTable();

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

                DataTable dataTable = TableInsert();

                GetDatas();
                presenterGeneric.InsertCiclo(dataTable);

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

                if (prescricaoMedica.IdChavePrescricao == 0)
                    return;

                prescricaoMedica.Id = presenterGeneric.InsertPrescricao(prescricaoMedica);

                AddNewRows();
            }
            catch (Exception exNewLinhe)
            {
                FrmMain.Alert(100, exNewLinhe);
            }
        }

        private void btnAddDia_Click(object sender, EventArgs e)
        {
            try
            {
                if (prescricaoMedica.IdChavePrescricao == 0)
                    return;

                DataColumn dataColumns = table.Columns.OfType<DataColumn>().LastOrDefault(dc => dc.DataType == typeof(Image) && dc.ColumnName != "Act");

                DateTime newDate = Convert.ToDateTime(dataColumns.ColumnName);
                newDate = newDate.AddDays(1);

                int idDateCiclo = presenterGeneric.Salvar(new CicloPrescricao()
                {
                    DataCiclo = newDate,
                    IdChavePrescricao = Convert.ToInt32(comboBoxDataPrescricao.SelectedValue),
                    IdPaciente = Sessao.Paciente.Id
                },
                    Procedure.SP_ADD_DATE);

                DataColumn dataColumn = table.Columns["Act"];
                table.Columns.Remove(dataColumn);
                
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
                if (prescricaoMedica.IdChavePrescricao == 0)
                    return;

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

        private void btnCriarPrescricao_Click(object sender, EventArgs e)
        {
            pNamePrescricao.Visible = false;
            btnAddCiclo.Visible = true;
            dataGridViewPrescricoes.DataSource = null;
            table = null;
            lblCicloPrescricao.Visible = false;
            btnAddDia.Enabled = btnNewLine.Enabled = btnRemoveDia.Enabled = false;
        }

        private void btnCancelaPrescricao_Click(object sender, EventArgs e)
        {
            pNamePrescricao.Visible = false;
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
                    if (e.ColumnIndex >= 2 && dataGridViewPrescricoes.Columns[e.ColumnIndex].Name != "Act")
                    {
                        DateTime dateTime = Convert.ToDateTime(dataGridViewPrescricoes.Columns[e.ColumnIndex].HeaderText);
                        if (dateTime.Equals(DateTime.Now.Date))
                        {
                            if (Sessao.Usuario.Perfil.HasFlag(Perfil.Enfermeiro_Assistemcial) || Sessao.Usuario.Perfil.HasFlag(Perfil.Tecnico))
                            {
                                TimeSpan time = (TimeSpan)dataGridViewPrescricoes["Horário", e.RowIndex].Value;
                                if (DateTime.Now.TimeOfDay - time > new TimeSpan(1, 0, 59) || DateTime.Now.TimeOfDay - time < new TimeSpan(-1, 0, 59))
                                {
                                    string msgBox = "Essa linha de prescrição, tem mais de 1:00 atrasada ou adiantada do horario previsto.";
                                    msgBox += "\nDeseja realizar a checagem e justificar o motivo.";

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

                                            presenterGeneric.Salvar(new PrescricaoMedica()
                                            {
                                                Id = Convert.ToInt32(table.Rows[e.RowIndex]["Id"]),
                                                IdPaciente = Sessao.Paciente.Id,
                                                IdChavePrescricao = Convert.ToInt32(table.Rows[e.RowIndex]["IdChavePrescricao"]),
                                                Justificativa = _justificativa
                                            }, Procedure.SP_UPDT_JUSTIFICATIVA, Acao.Atualizar);
                                        }

                                    }
                                    else
                                        return;
                                }
                            }
                            else
                                return;


                            if (dataGridViewPrescricoes.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag == null || (int)dataGridViewPrescricoes.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag == 0)
                            {
                                dataGridViewPrescricoes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.IsOk;
                                dataGridViewPrescricoes.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag = 1;
                            }
                            else
                            {
                                dataGridViewPrescricoes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.Wait;
                                dataGridViewPrescricoes.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag = 0;
                            }

                            presenterGeneric.Salvar(new CicloPrescricao()
                            {
                                Id = Convert.ToInt32(table.Columns[e.ColumnIndex].ExtendedProperties["Id"]),
                                IdPaciente = Sessao.Paciente.Id,
                                IdPrescricao = dataGridViewPrescricoes.Rows[e.RowIndex].Cells[0].Value.ToString(),
                                IdChavePrescricao = Convert.ToInt32(table.Rows[e.RowIndex]["IdChavePrescricao"]),
                                Checado = DateTime.Now,
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
                if (Sessao.Usuario.Perfil.HasFlag(Perfil.Medicos))
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
                                btnAddDia.Enabled = btnNewLine.Enabled = btnRemoveDia.Enabled = false;
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
        }

        private void dataGridViewPrescricoes_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView sendGrid = (DataGridView)sender;
            sendGrid.Rows[e.RowIndex].Cells["Justificativa"].ReadOnly = true;
        }

        private void textBoxNomePrescricao_TextChanged(object sender, EventArgs e)
        {
            lblContaCaracter.Text = $"Mínimo de {10 - textBoxNomePrescricao.Text.Trim().Length } caracteres";
            btnCriarPrescricao.Enabled = textBoxNomePrescricao.Text.Trim().Length >= 10;
            lblContaCaracter.Visible = textBoxNomePrescricao.Text.Trim().Length <= 10;
        }

        private void comboBoxDataPrescricao_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCicloPrescricao.Visible = false;
            if (comboBoxDataPrescricao.SelectedIndex == 0)
            {
                btnValidarPrescricao.Visible = false;
                return;
            }

            table = null;
            CriaDataTable();
            dataGridViewPrescricoes.DataSource = null;
            ChavePrescricao chave = (ChavePrescricao)comboBoxDataPrescricao.SelectedItem;

            if (Sessao.Usuario.Perfil.HasFlag(Perfil.Enfermeiro_Assistemcial))
                btnValidarPrescricao.Visible = (bool)!chave.IsValidado; 

            lstCiclo = presenterGeneric.GetLista(new CicloPrescricao()
            {
                IdChavePrescricao = chave.Id,
                IdPaciente = chave.idPaciente
            }
                , Procedure.SP_GET_CICLO);

            lstPrescricao = presenterGeneric.GetLista(new PrescricaoMedica() { Id = 0,  IdPaciente = Sessao.Paciente.Id,  IdChavePrescricao = chave.Id,  }, Procedure.SP_GET_PRESCRICAO);

            LoadDataTable();

            if ((bool)chave.IsValidado)
                FrizenGrid(chave);
        }

        private void btnValidarPrescricao_Click(object sender, EventArgs e)
        {
            try
            {
                int idPrescricao = Convert.ToInt32(comboBoxDataPrescricao.SelectedValue);
                FrmMain.Alert(presenterGeneric.Salvar(new ChavePrescricao() { idPaciente = Sessao.Paciente.Id, Id = idPrescricao }, Procedure.SP_ADD_CHAVE_PRESCRICAO));
                GetDatas();
            }
            catch (Exception ex)
            {
                FrmMain.Alert(100, ex);
                throw;
            }
        }

        void ConfigGrid()
        {
            dataGridViewPrescricoes.Columns["Id"].Visible = false;
            dataGridViewPrescricoes.Columns["IdChavePrescricao"].Visible = false;
            dataGridViewPrescricoes.Columns["IdCliente"].Visible = false;
            dataGridViewPrescricoes.Columns["IdPaciente"].Visible = false;
            dataGridViewPrescricoes.Columns["Prescrição"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewPrescricoes.Columns["Prescrição"].MinimumWidth = 300;
            dataGridViewPrescricoes.Columns["Prescrição"].DefaultCellStyle.WrapMode =  DataGridViewTriState.True;

            foreach (DataGridViewColumn item in dataGridViewPrescricoes.Columns)
            {
                if (!lstIgnore.Any(c => c.Contains(item.DataPropertyName)))
                    item.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            }

            dataGridViewPrescricoes.ReadOnly = !Sessao.Usuario.Perfil.HasFlag(Perfil.Medicos);
        }

        private void AddNewRows()
        {
            try
            {
                List<CicloPrescricao> lstCicloItem = presenterGeneric.GetLista(new CicloPrescricao()
                {
                    IdChavePrescricao = prescricaoMedica.IdChavePrescricao,
                    IdPaciente = Sessao.Paciente.Id
                }
                , Procedure.SP_GET_CICLO);

                DataRow row = table.NewRow();

                if (!table.Columns.Contains("Act"))
                {
                    table.Columns.Add(new DataColumn("Act", typeof(Image)));
                }

                row["Id"] = prescricaoMedica.Id;
                row["IdCliente"] = Sessao.CodigoCliente;
                row["IdChavePrescricao"] = prescricaoMedica.IdChavePrescricao;
                row["IdPaciente"] = Sessao.Paciente.Id;
                row["Horário"] = TimeSpan.Parse(DateTime.Now.ToShortTimeString());
                row["Prescrição"] = string.Empty;
                row["Justificativa"] = string.Empty;
                row["Act"] = Properties.Resources.rubbishbin_102620;

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
                            item.ExtendedProperties.Add("Id", lstCicloItem.Find(c => c.DataCiclo.Equals(Convert.ToDateTime(item.Caption))).Id);
                    }
                }

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

        void GetDatas()
        {
            bool? _isvalidado = null;

            if (!Sessao.Usuario.Perfil.HasFlag(Perfil.Enfermeiro_Assistemcial) && !Sessao.Usuario.Perfil.HasFlag(Perfil.Medicos))
                _isvalidado = true;

            string msgValidarPrescricao = string.Empty;
            lstChavePrescricoes = presenterGeneric.GetLista(new ChavePrescricao()
            {
                idPaciente = Sessao.Paciente.Id,
                NomePrescricao = textBoxNomePrescricao.Text,
                IsValidado = _isvalidado
            }, Procedure.SP_GET_CHAVE_PRESCRICAO);
            lstChavePrescricoes.Insert(0,new ChavePrescricao() { Id = 0, NomePrescricao = "Selecione...", IsValidado = true });
            int countPrescricao = lstChavePrescricoes.Count(c => c.IsValidado == false);

            if (Sessao.Usuario.Perfil.HasFlag(Perfil.Enfermeiro_Assistemcial))
            {
                lblValidaPrescricao.Visible = countPrescricao > 0;
                lblValidaPrescricao.Text = countPrescricao > 1 ? $"Identificado {countPrescricao} novas prescrições para serem validadas." : $"Identificado 1 nova prescrição para validar.";
            }

            comboBoxDataPrescricao.DataSource = lstChavePrescricoes;
            comboBoxDataPrescricao.SelectedIndexChanged -= comboBoxDataPrescricao_SelectedIndexChanged;
            comboBoxDataPrescricao.SelectedValue = prescricaoMedica.IdChavePrescricao;
            comboBoxDataPrescricao.SelectedIndexChanged += comboBoxDataPrescricao_SelectedIndexChanged;

            lblTotalPrescricao.Text = $"{lstChavePrescricoes.Count(p => p.Id > 0)} Prescrição cadastradas";
        }

        private void CriaDataTable()
        {
            table = null;
            table = new DataTable();

            table.Columns.Add(new DataColumn("Id", typeof(int)));
            table.Columns.Add(new DataColumn("IdChavePrescricao", typeof(int)));
            table.Columns.Add(new DataColumn("IdCliente", typeof(int)));
            table.Columns.Add(new DataColumn("IdPaciente", typeof(int)));
            table.Columns.Add(new DataColumn("Prescrição", typeof(string)));
            table.Columns.Add(new DataColumn("Horário", typeof(TimeSpan)));
            table.Columns.Add(new DataColumn("Justificativa", typeof(string)) { ReadOnly = true });

        }

        private DataTable TableInsert()
        {
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

                dataTable.Rows.Add(dataRow);
            }

            return dataTable;
        }

        private void LoadDataTable()
        {
            try
            {
                CicloPrescricao cicloPrescricao = null;

                List<DataColumn> dataColumns = new List<DataColumn>();
                DataColumn dataColumn = null;
                lstCiclo.ForEach(c => {
                    dataColumn = new DataColumn(c.DataCiclo?.ToString("dd/MM"), typeof(Image));
                    dataColumn.ExtendedProperties.Add("Id", c.Id);
                    dataColumns.Add(dataColumn);
                    table.Columns.Add(dataColumn);
                });

                
                lstPrescricao.ForEach(presc =>
                {
                    DataRow row = table.NewRow();

                    row["Id"] = presc.Id;
                    row["IdChavePrescricao"] = presc.IdChavePrescricao;
                    row["IdCliente"] = Sessao.CodigoCliente;
                    row["IdPaciente"] = presc.IdPaciente;
                    row["Prescrição"] = presc.Prescricao;
                    row["Horário"] = presc.Horario == null ? "00:00" : presc.Horario?.ToString(@"hh\:mm");
                    row["Justificativa"] = presc.Justificativa;

                    foreach (DataColumn item in dataColumns)
                    {
                        cicloPrescricao = lstCiclo.FirstOrDefault(dt => dt.DataCiclo.Value.ToString("dd/MM") == item.ColumnName);

                        if (cicloPrescricao.DataCiclo >= DateTime.Now.Date)
                        {
                            if (cicloPrescricao.Checado != null)
                            {
                                if (cicloPrescricao.IdPrescricao.Split(',').Any(p => presc.Id.ToString().Equals(p)))
                                {
                                    row[item.ColumnName] = Properties.Resources.IsOk;
                                }
                                else
                                    row[item.ColumnName] = Properties.Resources.Wait;
                            }
                            else
                                row[item.ColumnName] = Properties.Resources.Wait;
                        }
                        else
                        {
                            if (cicloPrescricao.Checado != null)
                                if (cicloPrescricao.IdPrescricao.Split(',').Any(p => presc.Id.ToString().Equals(p)))
                                    row[item.ColumnName] = Properties.Resources.IsOk;
                                else
                                    row[item.ColumnName] = Properties.Resources.integative;
                            else
                                row[item.ColumnName] = Properties.Resources.NotOk;
                        }
                    }

                    if (!table.Columns.Contains("Act"))
                    {
                        table.Columns.Add(new DataColumn("Act", typeof(Image)));
                    }
                    row["Act"] = Properties.Resources.rubbishbin_102620;

                    table.Rows.Add(row);
                });

                dataGridViewPrescricoes.DataSource = null;
                dataGridViewPrescricoes.DataSource = table;
                ConfigGrid();

                if (Sessao.Usuario.Perfil.HasFlag(Perfil.Medicos))
                {
                    btnNewLine.Enabled = table != null;
                    btnAddDia.Enabled = btnRemoveDia.Enabled = table.Rows.Count > 0;
                }
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void FrizenGrid(ChavePrescricao chavePrescricao)
        {
            dataGridViewPrescricoes.Columns["Prescrição"].ReadOnly = true;
            dataGridViewPrescricoes.Columns["Horário"].ReadOnly = true;
            dataGridViewPrescricoes.Columns["Act"].Visible = false;
            btnAddDia.Enabled = false;
            btnNewLine.Enabled = false;
            btnRemoveDia.Enabled = false;
        }
    }
}
