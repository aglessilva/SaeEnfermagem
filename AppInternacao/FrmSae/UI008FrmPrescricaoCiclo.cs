using AppInternacao.Enum;
using AppInternacao.Model;
using AppInternacao.Presenter;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace AppInternacao.FrmSae
{
    public partial class UI008FrmPrescricaoCiclo : UI000FrmTemplate
    {
        PrescricaoMedica prescricaoMedica = null;
        private PresenterGeneric presenterGeneric;
        List<PrescricaoMedica> lstPrescricao = null;
        List<CicloPrescricao> lstCiclo = null;
        private List<ChavePrescricao> lstChavePrescricoes = null;
        DataTable table;
        List<DateTime> lst = null;
        List<string> lstIgnore = new List<string>() { "Id", "Horario", "Intervalo", "IdCliente", "IdPaciente", "Prescricao", "IdChavePrescricao" };


        public UI008FrmPrescricaoCiclo()
        {
            InitializeComponent();
            prescricaoMedica = new PrescricaoMedica();
            new ToolTip() { UseAnimation = true, IsBalloon = true }.SetToolTip(btnNewLine, "Adicionar nova linha no cliclo da Prescrição");
            new ToolTip() { UseAnimation = true, IsBalloon = true }.SetToolTip(btnAddDia, "Adicionar 1 dia no ciclo da prescrição");
            new ToolTip() { UseAnimation = true, IsBalloon = true }.SetToolTip(btnRemoveDia, "Remove o último dia do ciclo da prescrição");
            presenterGeneric = new PresenterGeneric();
        }

        private void CalendarCicloPrescricao_DateSelected(object sender, DateRangeEventArgs e)
        {
            int intervalor = (int)(e.End - e.Start).TotalDays + 1;
            lblCicloPrescricao.Visible = btnAddCiclo.Enabled = intervalor > 0;
            lblCicloPrescricao.Text = $"Prescrição com o ciclo de {intervalor + (intervalor > 1 ? " dias" : " dia ")} {(!btnAddCiclo.Visible ? "\nNova prescrição, clique no botão 'Novo'" : "")}";

        }

        private void UI008FrmPrescricaoCiclo_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridViewPrescricoes.ColumnHeadersVisible = false;
                FrmMain.myNovo.Visible = Sessao.Usuario.Perfil.HasFlag(Perfil.Medico);
                FrmMain.mySalvar.Visible = false;
                FrmMain.myNovo.Click += MyNovo_Click;

                CriaDataTable();
                GetDatas();

                btnCriarPrescricao.Visible = Sessao.Usuario.Perfil.HasFlag(Perfil.Medico);
                btnNewLine.Enabled = Sessao.Usuario.Perfil.HasFlag(Perfil.Medico);
                btnRemoveDia.Enabled = Sessao.Usuario.Perfil.HasFlag(Perfil.Medico);
                btnAddCiclo.Enabled = Sessao.Usuario.Perfil.HasFlag(Perfil.Medico);
                btnAddDia.Enabled = CalendarCicloPrescricao.Enabled = Sessao.Usuario.Perfil.HasFlag(Perfil.Medico);

                lblCicloPrescricao.Visible = comboBoxDataPrescricao.Items.Count == 1;
                CalendarCicloPrescricao.Visible = !(comboBoxDataPrescricao.Items.Count == 1);
                comboBoxDataPrescricao.Visible = !(comboBoxDataPrescricao.Items.Count == 1);
                btnAddDia.Visible = !(comboBoxDataPrescricao.Items.Count == 1);
                btnNewLine.Visible = !(comboBoxDataPrescricao.Items.Count == 1);
                btnRemoveDia.Visible = !(comboBoxDataPrescricao.Items.Count == 1);
                lblTotalPrescricao.Visible = !(comboBoxDataPrescricao.Items.Count == 1);
                lblCicloPrescricao.Text = !Sessao.Usuario.Perfil.HasFlag(Perfil.Medico) ? $"O Paciente {Sessao.Paciente.Nome }\nNão tem prescrição inserida no momento.{Environment.NewLine}Por favor, contate o enfermeiro(a) do plantão. " : "Para inserir uma nova prescrição, clique no botão 'Novo' no canto superior esquerdo!";

            }
            catch (Exception exLoad)
            {
                FrmMain.Alert(exception: exLoad);
            }
        }
      
        private void MyNovo_Click(object sender, EventArgs e)
        {
            if (Sessao.Usuario.Perfil.HasFlag(Perfil.Medico))
            {
                pNamePrescricao.BringToFront();
                pNamePrescricao.Visible = true;
                dataGridViewPrescricoes.DataSource = null;
                table = null;
                comboBoxDataPrescricao.SelectedIndex = 0;
                textBoxNomePrescricao.Text = $"{Sessao.Paciente.Nome}-{(lstChavePrescricoes.Count(s => s.Id > 0) + 1 ).ToString().PadLeft(5,'0')}";
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
                btnAddDia.Enabled = btnNewLine.Enabled = btnRemoveDia.Enabled = comboBoxDataPrescricao.Enabled = true;

                prescricaoMedica.IdChavePrescricao = presenterGeneric.Salvar(new ChavePrescricao() { IdPaciente = Sessao.Paciente.Id, NomePrescricao = textBoxNomePrescricao.Text, StatusPrescricao = 1 }, Procedure.SP_ADD_CHAVE_PRESCRICAO);
                textBoxNomePrescricao.Text = string.Empty;

                CalendarCicloPrescricao.SelectionRange = new SelectionRange(CalendarCicloPrescricao.SelectionStart, CalendarCicloPrescricao.SelectionEnd);
                lst = new List<DateTime>();
                DateTime dateTime = CalendarCicloPrescricao.SelectionStart;

                CriaDataTable();

                prescricaoMedica.IdPaciente = Sessao.Paciente.Id;
                prescricaoMedica.Prescricao = null;
                prescricaoMedica.Horario = null;
                prescricaoMedica.Intervalo = null;

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
                FrizenGrid(new ChavePrescricao() { StatusPrescricao = 1 });

                btnNewLine.Enabled = table != null;
                btnAddDia.Enabled = btnRemoveDia.Enabled = dataTable.Rows.Count > 0;
                btnAddCiclo.Visible = false;

            }
            catch (Exception exCiclo)
            {
                FrmMain.Alert(exception: exCiclo);
            }
        }

        private void btnNewLine_Click(object sender, EventArgs e)
        {
            try
            {
                ChavePrescricao chave = (ChavePrescricao)comboBoxDataPrescricao.SelectedItem;
                if ((int)chave.StatusPrescricao == 3)
                {
                    MessageBox.Show("Não é possivel alterar a prescrição, pois a mesma já foi validada pelo enfemeiro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                prescricaoMedica.IdPaciente = Sessao.Paciente.Id;
                prescricaoMedica.Id = 0;
                prescricaoMedica.IdChavePrescricao = chave.Id;
                prescricaoMedica.Prescricao = null;
                prescricaoMedica.Horario = null;

                if (prescricaoMedica.IdChavePrescricao == 0)
                    return;

                prescricaoMedica.Id = presenterGeneric.InsertPrescricao(prescricaoMedica);

                AddNewRows();
            }
            catch (Exception exNewLinhe)
            {
                FrmMain.Alert(exception: exNewLinhe);
            }
        }

        private void btnAddDia_Click(object sender, EventArgs e)
        {
            try
            {
                ChavePrescricao chave = (ChavePrescricao)comboBoxDataPrescricao.SelectedItem;
                if (chave.Id == 0)
                    return;

                if ((int)chave.StatusPrescricao == 3)
                {
                    MessageBox.Show("Não é possivel alterar a prescrição, pois a mesma já foi validada pelo enfemeiro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                DataColumn dataColumns = table.Columns.OfType<DataColumn>()
                    .LastOrDefault(dc => dc.DataType == typeof(Image) && !new[]{ "Act", "Note"}.Contains(dc.ColumnName));

                DateTime newDate = Convert.ToDateTime(dataColumns.ColumnName).Date;

                if (newDate < DateTime.Now.Date)
                    newDate = DateTime.Now.Date;

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
                FrmMain.Alert(exception: exEAddDia);
            }
        }

        private void btnRemoveDia_Click(object sender, EventArgs e)
        {
            try
            {
                ChavePrescricao chave = (ChavePrescricao)comboBoxDataPrescricao.SelectedItem;
                if (chave.Id == 0)
                    return;

                if ((int)chave.StatusPrescricao == 3)
                {
                    MessageBox.Show("Não é possivel alterar a prescrição, pois a mesma já foi validada pelo enfemeiro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

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
                FrmMain.Alert(exception: exRemovDia);
            }
        }

        private void btnCriarPrescricao_Click(object sender, EventArgs e)
        {
            pNamePrescricao.Visible  = false;
            btnAddCiclo.Visible = true;
            dataGridViewPrescricoes.DataSource = null;
            table = null;
            btnAddDia.Visible = btnNewLine.Visible = btnRemoveDia.Visible = CalendarCicloPrescricao.Visible = comboBoxDataPrescricao.Visible = lblTotalPrescricao.Visible = btnAddCiclo.Visible = true;
            btnAddDia.Enabled = btnNewLine.Enabled = btnRemoveDia.Enabled = comboBoxDataPrescricao.Enabled = btnAddCiclo.Enabled =  false;
            lblCicloPrescricao.Text = "Selecione o intervalo entre datas que ocorrerá o ciclo da prescrição!";
            lblCicloPrescricao.Visible = true;
        }

        private void btnCancelaPrescricao_Click(object sender, EventArgs e)
        {
            textBoxNomePrescricao.Text = string.Empty;
            pNamePrescricao.Visible = false;
        }

        private void dataGridViewPrescricoes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView sendGrid = (DataGridView)sender;
                DataRow dataRow = table.Rows[e.RowIndex];

                CicloPrescricao cicloPrescricao = lstCiclo.FirstOrDefault(i => i.DataCiclo == DateTime.Today);

              

                if (sendGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn)
                {
                    if (sendGrid.Columns[e.ColumnIndex].Name != "Act" && sendGrid.Columns[e.ColumnIndex].Name != "Note")
                    {
                        if (Sessao.Usuario.Perfil.HasFlag(Perfil.Medico))
                            return;

                        ChavePrescricao chave = (ChavePrescricao)comboBoxDataPrescricao.SelectedItem;
                        if ((int)chave.StatusPrescricao != 3)
                            return;

                        DateTime dateTime = Convert.ToDateTime(sendGrid.Columns[e.ColumnIndex].HeaderText);

                        if (dateTime.Equals(DateTime.Now.Date))
                        {
                            if (cicloPrescricao.Checado.HasValue)
                            {
                                MessageBox.Show($"O item de prescição para a data {DateTime.Today.ToShortDateString()}, ja foi checado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }

                            if ((Perfil.Enfermeiro_Assistemcial | Perfil.Tecnico).HasFlag(Sessao.Usuario.Perfil))
                            {
                                TimeSpan time = (TimeSpan)sendGrid["Horario", e.RowIndex].Value;
                                if (DateTime.Now.TimeOfDay - time > new TimeSpan(2, 0, 59) || DateTime.Now.TimeOfDay - time < new TimeSpan(-2, 0, 59))
                                {
                                    string msgBox = "Esse item de prescrição, tem mais de 2:00 atrasada ou adiantada do horario previsto.";
                                    msgBox += "\nDeseja realizar a checagem e justificar o motivo.";

                                    if (MessageBox.Show(msgBox, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        int itemPrescricao = Convert.ToInt32(sendGrid[0, e.RowIndex].Value);
                                        using (Form f = new Frm.FrmJustificarChecagem(chave,itemPrescricao, 2))
                                        {
                                            f.DialogResult = f.ShowDialog();
                                            if (f.DialogResult == DialogResult.Cancel)
                                                return;
                                        }
                                    }
                                    else
                                        return;
                                }
                            }
                            else
                                return;

                            bool mod = true;
                            if (!string.IsNullOrWhiteSpace(cicloPrescricao.IdPrescricao))
                                mod = cicloPrescricao.IdPrescricao.Split(',').Count(s => s.Equals(dataRow["Id"].ToString())) % 2 == 0;

                            if (mod)
                            {
                                sendGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.IsOk;
                                sendGrid.Rows[e.RowIndex].Cells["Horario"].ReadOnly = false;
                                TimeSpan.TryParse(sendGrid.Rows[e.RowIndex].Cells["Intervalo"].Value.ToString(), out TimeSpan _timerInvervalor);
                                string proximo = DateTime.Now.AddHours(_timerInvervalor.Hours).ToShortTimeString();
                                sendGrid.Rows[e.RowIndex].Cells["Horario"].Value = proximo;
                                sendGrid.Rows[e.RowIndex].Cells["Horario"].ReadOnly = false;
                                dataGridViewPrescricoes_CellEndEdit(sender, e);
                                cicloPrescricao.IdPrescricao += $"{Convert.ToInt32(dataRow["Id"])},";
                            }
                            else
                            {
                                sendGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.Wait;
                                cicloPrescricao.IdPrescricao = string.Join(",", cicloPrescricao.IdPrescricao.Replace(dataRow["Id"].ToString(), string.Empty).Split(',').Where(s => !string.IsNullOrWhiteSpace(s)).ToArray()) + ",";
                            }

                            if (cicloPrescricao.IdPrescricao.Split(',').Count(x => !string.IsNullOrWhiteSpace(x)) == 0)
                                cicloPrescricao.IdPrescricao = null;

                            presenterGeneric.Salvar(new CicloPrescricao()
                            {
                                Id = Convert.ToInt32(table.Columns[e.ColumnIndex].ExtendedProperties["Id"]),
                                IdPaciente = Sessao.Paciente.Id,
                                IdPrescricao = cicloPrescricao.IdPrescricao,
                                IdChavePrescricao = Convert.ToInt32(table.Rows[e.RowIndex]["IdChavePrescricao"]),
                                Checado = !string.IsNullOrWhiteSpace(cicloPrescricao.IdPrescricao) ? DateTime.Now : (DateTime?)null
                            }, Procedure.SP_ADD_DATE, Acao.Atualizar);

                            comboBoxDataPrescricao_SelectedIndexChanged(comboBoxDataPrescricao, null);
                        }
                        else
                            MessageBox.Show("Não é permitido realizar checagem de cuidados prescritos em datas passadas ou futuras", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception exChekPrescricao)
            {
                FrmMain.Alert(exception: exChekPrescricao);
            }
        }

        private void dataGridViewPrescricoes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView sendGrid = dataGridViewPrescricoes;
                if (sendGrid.Columns[e.ColumnIndex].DataPropertyName.Equals("Horario") || sendGrid.Columns[e.ColumnIndex].DataPropertyName.Equals("Intervalo"))
                {

                    var newTime =
                        (sendGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Split('.').Count() == 2)
                        ? new TimeSpan(TimeSpan.Parse(sendGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()).Days, TimeSpan.Parse(sendGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()).Minutes, 0)
                        : TimeSpan.Parse(sendGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());

                    bool item =  TimeSpan.TryParse(newTime.ToString(), out TimeSpan time);
                    if (!item)
                    {
                        MessageBox.Show($"Horario invalido" + time, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    sendGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = newTime;
                }

                prescricaoMedica.Id = Convert.ToInt32(sendGrid.Rows[e.RowIndex].Cells["Id"].Value);
                prescricaoMedica.IdPaciente = Sessao.Paciente.Id;
                prescricaoMedica.Prescricao = sendGrid.Rows[e.RowIndex].Cells["Prescricao"].Value.ToString();
                prescricaoMedica.Horario = TimeSpan.Parse(sendGrid.Rows[e.RowIndex].Cells["Horario"].Value.ToString());
                prescricaoMedica.Intervalo = TimeSpan.Parse(sendGrid.Rows[e.RowIndex].Cells["Intervalo"].Value.ToString()) ;

                presenterGeneric.InsertPrescricao(prescricaoMedica);
            }
            catch (Exception exEditRow)
            {
                FrmMain.Alert(exception: exEditRow);
            }
        }

        private void dataGridViewPrescricoes_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void dataGridViewPrescricoes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView grideSender = dataGridViewPrescricoes;

            if (grideSender.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                var coluna = grideSender.Columns[e.ColumnIndex];
                if (coluna.DataPropertyName.Equals("Act"))
                {
                    if (Sessao.Usuario.Perfil.HasFlag(Perfil.Medico))
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
                            FrmMain.Alert(exception: exRemoveItem);
                        }
                    }
                }

                if (coluna.DataPropertyName.Equals("Note"))
                {
                    ChavePrescricao chave = (ChavePrescricao)comboBoxDataPrescricao.SelectedItem;
                    CicloPrescricao cicloPrescricao  = lstCiclo.LastOrDefault();
                    int _id = Convert.ToInt32(table.Rows[e.RowIndex][0]);
                    new Frm.FrmJustificarChecagem(chave, _id,_cicloPrescricao:cicloPrescricao).ShowDialog();
                }
            }
        }

        private void textBoxNomePrescricao_TextChanged(object sender, EventArgs e)
        {
            lblContaCaracter.Text = $"Mínimo de {10 - textBoxNomePrescricao.Text.Trim().Length } caracteres";
            btnCriarPrescricao.Enabled = textBoxNomePrescricao.Text.Trim().Length >= 10;
            lblContaCaracter.Visible = textBoxNomePrescricao.Text.Trim().Length <= 10;
        }

        private void btnValidarPrescricao_Click(object sender, EventArgs e)
        {
            try
            {
                string aviso = "Após o 'Aceite' não será possível realizar alterações de Horários para esta prescrição.\n" +
                    "Os horários serão adicionados automaticamente durante cada checagem com base no intervalo.\n" +
                    "As definições desta prescrição estão corretas?";
                DialogResult dialogResult = MessageBox.Show(aviso, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    //int cont = table.AsEnumerable().Count(c => c.Field<TimeSpan>("Horario").Duration() == TimeSpan.Parse("00:00:00"));
                    int idPrescricao = Convert.ToInt32(comboBoxDataPrescricao.SelectedValue);
                    FrmMain.Alert((Alerts)presenterGeneric.Salvar(new ChavePrescricao() { IdPaciente = Sessao.Paciente.Id, Id = idPrescricao, StatusPrescricao = 3 }, Procedure.SP_ADD_CHAVE_PRESCRICAO));
                    GetDatas();
                    btnValidarPrescricao.Visible = btnDevolverPrescricao.Visible = false;
                    comboBoxDataPrescricao.SelectedValue = idPrescricao;
                }
            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
                throw;
            }
        }

        private void comboBoxDataPrescricao_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lblCicloPrescricao.Visible = false;
                if (Sessao.Usuario.Perfil.HasFlag(Perfil.Medico))
                {
                    btnAddDia.Enabled = btnRemoveDia.Enabled = btnNewLine.Enabled = !(comboBoxDataPrescricao.SelectedIndex == 0);
                }

                if (comboBoxDataPrescricao.SelectedIndex == 0)
                {
                    btnValidarPrescricao.Visible =  btnDevolverPrescricao.Visible = false;
                    table = null;
                    dataGridViewPrescricoes.DataSource = null;
                    
                    return;
                }

                table = null;
                CriaDataTable();
                dataGridViewPrescricoes.DataSource = null;
                ChavePrescricao chave = (ChavePrescricao)comboBoxDataPrescricao.SelectedItem;

                if (Sessao.Usuario.Perfil.HasFlag(Perfil.Enfermeiro_Assistemcial))
                    btnValidarPrescricao.Visible = btnDevolverPrescricao.Visible = (int)chave.StatusPrescricao != 3;

                if (Sessao.Usuario.Perfil.HasFlag(Perfil.Medico))
                {
                    btnDevolverPrescricao.Visible = chave.StatusPrescricao == 2;
                    btnDevolverPrescricao.Text = "Vizualizar e reenviar";
                    btnDevolverPrescricao.IconChar = FontAwesome.Sharp.IconChar.Eye;
                    btnDevolverPrescricao.IconColor = Color.White;
                }

                lstCiclo = presenterGeneric.GetLista(new CicloPrescricao()
                {
                    IdChavePrescricao = chave.Id,
                    IdPaciente = chave.IdPaciente
                }
                 , Procedure.SP_GET_CICLO);

                lstPrescricao = presenterGeneric.GetLista(new PrescricaoMedica() { Id = 0, IdPaciente = Sessao.Paciente.Id, IdChavePrescricao = chave.Id, }, Procedure.SP_GET_PRESCRICAO);

                LoadDataTable();

                FrizenGrid(chave);
            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
        }

        void ConfigGrid()
        {

            dataGridViewPrescricoes.ColumnHeadersVisible = dataGridViewPrescricoes.Rows.Count > 0;
            dataGridViewPrescricoes.Columns["Id"].Width = 50 ;
            dataGridViewPrescricoes.Columns["Id"].HeaderText = "Item" ;
            dataGridViewPrescricoes.Columns["IdChavePrescricao"].Visible = false;
            dataGridViewPrescricoes.Columns["IdCliente"].Visible = false;
            dataGridViewPrescricoes.Columns["IdPaciente"].Visible = false;
            dataGridViewPrescricoes.Columns["Prescricao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewPrescricoes.Columns["Prescricao"].MinimumWidth = 300;
            dataGridViewPrescricoes.Columns["Prescricao"].HeaderText = "Prescrição";
            dataGridViewPrescricoes.Columns["Horario"].HeaderText = "Horário";
            dataGridViewPrescricoes.Columns["Prescricao"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            foreach (DataGridViewColumn item in dataGridViewPrescricoes.Columns)
            {
                if (!lstIgnore.Any(c => c.Contains(item.DataPropertyName)))
                    item.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            }

           // dataGridViewPrescricoes.ReadOnly = !Sessao.Usuario.Perfil.HasFlag(Perfil.Medico) && (bool)chave.IsValidado;
        }

        private void AddNewRows()
        {
            try
            {
                lstCiclo = presenterGeneric.GetLista(new CicloPrescricao()
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

                if (!table.Columns.Contains("Note"))
                {
                    table.Columns.Add(new DataColumn("Note", typeof(Image)));
                }

                row["Id"] = prescricaoMedica.Id;
                row["IdCliente"] = Sessao.CodigoCliente;
                row["IdChavePrescricao"] = prescricaoMedica.IdChavePrescricao;
                row["IdPaciente"] = Sessao.Paciente.Id;
                row["Intervalo"] = TimeSpan.Parse("00:00");
                row["Horario"] = TimeSpan.Parse("00:00");
                row["Prescricao"] = string.Empty;
                row["Act"] = Properties.Resources.rubbishbin_102620;
                row["Note"] = Properties.Resources.Documents;

                foreach (DataColumn item in table.Columns)
                {
                    if (item.DataType == typeof(Image))
                    {
                        if (item.ColumnName.Equals("Act") || item.ColumnName.Equals("Note"))
                            continue;

                        if (Convert.ToDateTime(item.Caption) >= DateTime.Now.Date)
                            row[item.ColumnName] = Properties.Resources.Wait;
                        else
                            row[item.ColumnName] = Properties.Resources.integative;

                        if (table.Rows.Count == 0)
                            item.ExtendedProperties.Add("Id", lstCiclo.Find(c => c.DataCiclo.Equals(Convert.ToDateTime(item.Caption))).Id);
                    }
                }

                table.Rows.Add(row);
                ConfigGrid();

                btnNewLine.Enabled = table != null;
                btnAddDia.Visible = btnRemoveDia.Visible = table.Rows.Count > 0;
            }
            catch (Exception exNewLn)
            {
                FrmMain.Alert(exception: exNewLn);
            }
        }

        void GetDatas()
        {
            int? StatusPrescricao = null;

            if (!Sessao.Usuario.Perfil.HasFlag(Perfil.Enfermeiro_Assistemcial) && !Sessao.Usuario.Perfil.HasFlag(Perfil.Medico))
                StatusPrescricao = 3;

            lstChavePrescricoes = presenterGeneric.GetLista(new ChavePrescricao()
            {
                IdPaciente = Sessao.Paciente.Id,
                StatusPrescricao = StatusPrescricao
            }, Procedure.SP_GET_CHAVE_PRESCRICAO);

            lstChavePrescricoes.Insert(0, new ChavePrescricao() { Id = 0, NomePrescricao = "Selecione..." });

            // se nao form o perfil de medico, então remove as prescrições que foram devolvidas
            if (!Sessao.Usuario.Perfil.HasFlag(Perfil.Medico))
                lstChavePrescricoes.RemoveAll(s => s.StatusPrescricao == 2);

            int countPrescricao = 0;
            ChavePrescricao chave = (ChavePrescricao)comboBoxDataPrescricao.SelectedItem;
            if (Sessao.Usuario.Perfil.HasFlag(Perfil.Enfermeiro_Assistemcial & Perfil.EnfermeiroAdmin))
            {
                countPrescricao = lstChavePrescricoes.Count(c => c.StatusPrescricao == 1);
                lblValidaPrescricao.Visible = countPrescricao > 0; //&& !(Perfil.Tecnico | Perfil.Medico).HasFlag(Sessao.Usuario.Perfil);
                lblValidaPrescricao.Text = countPrescricao > 1 ? $"Identificado {countPrescricao} novas prescrições para serem validadas." : $"Identificado 1 nova prescrição para validar.";
            }

            if (Sessao.Usuario.Perfil.HasFlag(Perfil.Medico))
            {
                countPrescricao = lstChavePrescricoes.Count(c => c.StatusPrescricao == 2);
                lblValidaPrescricao.Visible = countPrescricao > 0;
                lblValidaPrescricao.Text = countPrescricao > 1 ? $"Identificado {countPrescricao} prescrições para revisão." : $"Identificado 1 prescrição para revisão.";
            }

            comboBoxDataPrescricao.SelectedIndexChanged -= comboBoxDataPrescricao_SelectedIndexChanged;
            comboBoxDataPrescricao.DataSource = lstChavePrescricoes;
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
            table.Columns.Add(new DataColumn("Prescricao", typeof(string)));
            table.Columns.Add(new DataColumn("Intervalo", typeof(TimeSpan)));
            table.Columns.Add(new DataColumn("Horario", typeof(TimeSpan)));
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
                if (item.Caption.Equals("Act") || item.Caption.Equals("Note"))
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
                    row["Prescricao"] = presc.Prescricao;
                    row["Intervalo"] = presc.Intervalo == null ? "00:00" : presc.Intervalo?.ToString(@"hh\:mm");
                    row["Horario"] = presc.Horario == null ? "00:00" : presc.Horario?.ToString(@"hh\:mm"); 

                    foreach (DataColumn item in dataColumns)
                    {
                        cicloPrescricao = lstCiclo.FirstOrDefault(dt => dt.DataCiclo.Value.ToString("dd/MM") == item.ColumnName);

                        if (cicloPrescricao.DataCiclo >= DateTime.Now.Date)
                        {
                            if (cicloPrescricao.Checado != null)
                            {
                                if (cicloPrescricao.IdPrescricao.Split(',').Any(p => presc.Id.ToString().Equals(p)))
                                    row[item.ColumnName] = Properties.Resources.IsOk;
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

                    if (!table.Columns.Contains("Note"))
                    {
                        table.Columns.Add(new DataColumn("Note", typeof(Image)));
                    }

                    row["Note"] = Properties.Resources.Documents;

                    table.Rows.Add(row);
                });

                dataGridViewPrescricoes.DataSource = null;
                dataGridViewPrescricoes.DataSource = table;
                ConfigGrid();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void FrizenGrid(ChavePrescricao chavePrescricao)
        {
            dataGridViewPrescricoes.Columns["Prescricao"].ReadOnly = (!Sessao.Usuario.Perfil.HasFlag(Perfil.Medico) || (int)chavePrescricao?.StatusPrescricao == 3);
            dataGridViewPrescricoes.Columns["Horario"].ReadOnly = (!Sessao.Usuario.Perfil.HasFlag(Perfil.EnfermeiroAdmin & Perfil.Enfermeiro_Assistemcial)||(int)chavePrescricao?.StatusPrescricao == 3);
            dataGridViewPrescricoes.Columns["Horario"].Visible = (Sessao.Usuario.Perfil.HasFlag(Perfil.EnfermeiroAdmin & Perfil.Enfermeiro_Assistemcial) || (int)chavePrescricao?.StatusPrescricao == 3);
            dataGridViewPrescricoes.Columns["Intervalo"].ReadOnly = !Sessao.Usuario.Perfil.HasFlag(Perfil.Medico);
            dataGridViewPrescricoes.Columns["Act"].Visible = (Sessao.Usuario.Perfil.HasFlag(Perfil.Medico) && (int)chavePrescricao?.StatusPrescricao != 3);
            dataGridViewPrescricoes.Columns["Act"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewPrescricoes.Columns["Note"].Visible = (Sessao.Usuario.Perfil.HasFlag(Perfil.Tecnico) && (int)chavePrescricao?.StatusPrescricao == 3);
            btnAddDia.Visible = Sessao.Usuario.Perfil.HasFlag(Perfil.Medico);
            btnNewLine.Visible = Sessao.Usuario.Perfil.HasFlag(Perfil.Medico);
            btnRemoveDia.Visible = Sessao.Usuario.Perfil.HasFlag(Perfil.Medico);
        }

        private void btnDevolverPrescricao_Click(object sender, EventArgs e)
        {
            ChavePrescricao chave = (ChavePrescricao)comboBoxDataPrescricao.SelectedItem;

            DialogResult dialogResult = new Frm.FrmJustificarChecagem(chave,_tipo: 1).ShowDialog();

            if (Sessao.Usuario.Perfil.HasFlag(Perfil.Medico))
            {
                if (dialogResult == DialogResult.OK)
                {
                    int ret = presenterGeneric.Salvar(new ChavePrescricao()
                    {
                        Id = chave.Id,
                        IdPaciente = Sessao.Paciente.Id,
                        StatusPrescricao = 1,
                    }, Procedure.SP_ADD_CHAVE_PRESCRICAO);

                    if (ret > 0)
                        FrmMain.Alert(Alerts.InsertSuccess);

                    lstChavePrescricoes.Where(w => w.Id == chave.Id).ToList().ForEach(s => { s.StatusPrescricao = 1; });

                    btnDevolverPrescricao.Visible = lblValidaPrescricao.Visible = false;
                    return;
                }
            }
            else
            {
               
                if (dialogResult == DialogResult.OK)
                {
                    int ret = presenterGeneric.Salvar(new ChavePrescricao()
                    {
                        Id = chave.Id,
                        IdPaciente = Sessao.Paciente.Id,
                        StatusPrescricao = 2
                    }, Procedure.SP_ADD_CHAVE_PRESCRICAO);


                    btnValidarPrescricao.Visible = btnDevolverPrescricao.Visible = lblValidaPrescricao.Visible = false;
                    dataGridViewPrescricoes.DataSource = null;
                    CriaDataTable();
                    GetDatas();
                }
            }
        }

        private void dataGridViewPrescricoes_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;

            foreach (DataGridViewRow row in senderGrid.Rows)
            {
                if (row.Index < e.RowIndex)
                    continue;
               var lst =  row.Cells.OfType<DataGridViewImageCell>().ToList();

                lst.ForEach(c => {

                    var coluna = senderGrid.Columns[c.ColumnIndex];
                    var cicloPrescricao =  lstCiclo.FirstOrDefault(dt => dt.DataCiclo.Value.ToString("dd/MM") == coluna.Name);

                    if (cicloPrescricao != null)
                    {
                        if (cicloPrescricao.DataCiclo >= DateTime.Now.Date)
                        {
                            if (cicloPrescricao.Checado != null)
                            {
                                if (cicloPrescricao.IdPrescricao.Split(',').Any(p => row.Cells["Id"].Value.ToString().Equals(p)))
                                    c.ToolTipText = "Item de prescrição checado!";
                                else
                                    c.ToolTipText = "Aguardando checagem!";
                            }
                            else
                                c.ToolTipText = "Aguardando checagem!";
                        }
                        else
                        {
                            if (cicloPrescricao.Checado != null)
                                if (cicloPrescricao.IdPrescricao.Split(',').Any(p => row.Cells["Id"].Value.ToString().Equals(p)))
                                    c.ToolTipText = "Item de prescrição checado!"; 
                                else
                                    c.ToolTipText = "Item de prescrição NÃO checado!";
                            else
                                c.ToolTipText = "Nenhum item de precrição foi checado nesta data!";
                        }
                    }
                });

            }
        }
    }
}
