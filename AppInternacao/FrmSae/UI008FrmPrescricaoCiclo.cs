using AppInternacao.Enum;
using AppInternacao.Model;
using AppInternacao.Presenter;
using FontAwesome.Sharp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace AppInternacao.FrmSae
{
    public partial class UI008FrmPrescricaoCiclo : UI000FrmTemplate
    {
        PrescricaoMedica prescricaoMedica = null;
        private PresenterGeneric presenterGeneric;
        List<PrescricaoMedica> lstPrescricao = null;
        ChavePrescricao chave = null;
        private List<ChavePrescricao> lstChavePrescricoes = new List<ChavePrescricao>();
        List<PrescricaoMedica> lstFullItensPrescricao = new List<PrescricaoMedica>();
        private List<ChavePrescricao> lstFullChaves = new List<ChavePrescricao>();

        public UI008FrmPrescricaoCiclo()
        {
            InitializeComponent();
            new ToolTip() { UseAnimation = true, IsBalloon = true }.SetToolTip(btnNewLine, "Adicionar nova linha no cliclo da Prescrição");
            new ToolTip() { UseAnimation = true, IsBalloon = true }.SetToolTip(btnAddDia, "Adicionar 1 dia no ciclo da prescrição");
            new ToolTip() { UseAnimation = true, IsBalloon = true }.SetToolTip(btnRemoveDia, "Remove o último dia do ciclo da prescrição");
            presenterGeneric = new PresenterGeneric();
        }

        private void CalendarCicloPrescricao_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (e.Start < DateTime.Now.Date)
            {
                MessageBox.Show($"Não é permitido selecionar intervalos de datas inferiores a data {DateTime.Now.ToShortDateString()}", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            int intervalor = (int)(e.End - e.Start).TotalDays + 1;
            lblCicloPrescricao.Visible = btnAddCiclo.Enabled = intervalor > 0;
            lblCicloPrescricao.Text = $"Prescrição com o ciclo de {intervalor + (intervalor > 1 ? " dias" : " dia ")} {(!btnAddCiclo.Visible ? "\nNova prescrição, clique no botão 'Novo'" : "")}";

        }

        private void UI008FrmPrescricaoCiclo_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridViewPrescricoes.Visible = dataGridViewPrescricoes.Rows.Count > 0;
                dataGridViewPrescricoes.AutoGenerateColumns = false;

                lstPrescricao = new List<PrescricaoMedica>();

                FrmMain.listButtons.ForEach(b =>
                {
                    if (b.Name.Equals("btnNovo"))
                    {
                        b.Visible = b.Enabled = Sessao.Usuario.Perfil.HasFlag(Perfil.Medico);
                        b.IconChar = IconChar.FileAlt;
                        b.IconColor = System.Drawing.Color.Yellow;
                        b.Click += MyNovo_Click;
                        b.Width = 73;
                        b.Text = "Novo".Trim();
                    }
                    else
                        b.Visible = b.Enabled = false;
                });

                GetDatas();

                pnlControle.Dock = DockStyle.Fill;
                btnCriarPrescricao.Visible = Sessao.Usuario.Perfil.HasFlag(Perfil.Medico);
                //btnNewLine.Enabled = Sessao.Usuario.Perfil.HasFlag(Perfil.Medico);
                //btnRemoveDia.Enabled = Sessao.Usuario.Perfil.HasFlag(Perfil.Medico);
                //btnAddCiclo.Enabled = Sessao.Usuario.Perfil.HasFlag(Perfil.Medico);
                //btnAddDia.Enabled = Sessao.Usuario.Perfil.HasFlag(Perfil.Medico);

                lblCicloPrescricao.Visible = comboBoxDataPrescricao.Items.Count == 1;

                comboBoxDataPrescricao.Visible = !(comboBoxDataPrescricao.Items.Count == 1);
                //btnAddDia.Visible = !(comboBoxDataPrescricao.Items.Count == 1);
                //btnNewLine.Visible = !(comboBoxDataPrescricao.Items.Count == 1);
                //btnRemoveDia.Visible = !(comboBoxDataPrescricao.Items.Count == 1);
                lblTotalPrescricao.Visible = !(comboBoxDataPrescricao.Items.Count == 1);
                lblCicloPrescricao.Text = !Sessao.Usuario.Perfil.HasFlag(Perfil.Medico) ? $"O paciente {Sessao.Paciente.Nome } Não tem prescrição médica no momento.\nPor favor, contate o enfermeiro(a) do plantão. " : "Para inserir uma nova prescrição, clique no botão 'Novo' no canto superior esquerdo!";

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
                pnlControle.Visible = pnlCalendario.Visible = false;
                pNamePrescricao.Visible = true;
                pNamePrescricao.Dock = DockStyle.Fill;
                pNamePrescricao.BringToFront();

                Resetcontrols(btnAddCiclo);
                Resetcontrols(dataGridViewPrescricoes);

                if (comboBoxDataPrescricao.Items.Count > 0)
                    comboBoxDataPrescricao.SelectedIndex = 0;

                int sequencia = 1;
                if (lstChavePrescricoes != null)
                    sequencia = lstChavePrescricoes.Any(s => s.Id > 0) ? Convert.ToInt32(lstChavePrescricoes.LastOrDefault(s => s.Id > 0).NomePrescricao.Split('-')[1]) + 1 : sequencia;

                textBoxNomePrescricao.Text = $"{Sessao.Paciente.Nome}-{sequencia.ToString().PadLeft(5, '0')}";
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
                dataGridViewPrescricoes.Visible = dataGridViewPrescricoes.Rows.Count > 0;
                btnAddDia.Enabled = btnNewLine.Enabled = btnRemoveDia.Enabled = comboBoxDataPrescricao.Enabled = true;

                chave = new ChavePrescricao();
                chave.Id = presenterGeneric.Salvar(new ChavePrescricao() { Prontuario = Sessao.Paciente.Prontuario, NomePrescricao = textBoxNomePrescricao.Text,  Status =  StatusPrescricao.Edicao }, Procedure.SP_ADD_CHAVE_PRESCRICAO);

                textBoxNomePrescricao.Text = string.Empty;
                CalendarCicloPrescricao.SelectionRange = new SelectionRange(CalendarCicloPrescricao.SelectionStart, CalendarCicloPrescricao.SelectionEnd);
                chave.Prontuario = Sessao.Paciente.Prontuario;
                DateTime dateTime = CalendarCicloPrescricao.SelectionStart;

                prescricaoMedica = new PrescricaoMedica();
                while (dateTime <= CalendarCicloPrescricao.SelectionEnd)
                {
                    prescricaoMedica.Datas.Add(dateTime);
                    dateTime = dateTime.AddDays(1);
                }

                prescricaoMedica.Prontuario = chave.Prontuario;
                prescricaoMedica.CicloData = JsonConvert.SerializeObject(prescricaoMedica.Datas, Formatting.None);
                prescricaoMedica.IdChavePrescricao = chave.Id;
                presenterGeneric.Salvar(prescricaoMedica, Procedure.SP_ADD_PRESCRICAO, Acao.Inserir);
                
                GetDatas(true);
                GetItensPrescricao(true);
                comboBoxDataPrescricao.SelectedValue = chave.Id;
                PopulaPrescricoes();

                Resetcontrols(btnAddCiclo, true);

              //  FrizenGrid(new ChavePrescricao() { StatusPrescricao = 1 });

                lblCicloPrescricao.Visible = pnlCalendario.Visible = false;
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
                chave = (ChavePrescricao)comboBoxDataPrescricao.SelectedItem;
                //if ((int)chave.StatusPrescricao == 3)
                //{
                //    MessageBox.Show("Não é possivel alterar a prescrição, pois a mesma já foi validada pelo enfemeiro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    return;
                //}
                
                var obj = lstPrescricao.FirstOrDefault(n => n.IdChavePrescricao == chave.Id);

                presenterGeneric.Salvar(new PrescricaoMedica { CicloData = obj.CicloData, IdChavePrescricao = obj.IdChavePrescricao, Prontuario = obj.Prontuario  } , Procedure.SP_ADD_PRESCRICAO, Acao.Inserir);

                GetItensPrescricao(true);
                comboBoxDataPrescricao.SelectedValue = chave.Id;
                PopulaPrescricoes();
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
                 chave = (ChavePrescricao)comboBoxDataPrescricao.SelectedItem;
                if (chave.Id == 0)
                    return;

                //if ((int)chave.StatusPrescricao == 3)
                //{
                //    MessageBox.Show("Não é possivel alterar a prescrição, pois a mesma já foi validada pelo enfemeiro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    return;
                //}

                lstPrescricao.Where(n => n.IdChavePrescricao == chave.Id).ToList().ForEach(p => {
                    p.Datas.Add(p.Datas.LastOrDefault().AddDays(1));
                    p.CicloData = JsonConvert.SerializeObject(p.Datas, Formatting.None);
                    presenterGeneric.Salvar(p, Procedure.SP_ADD_PRESCRICAO, Acao.Inserir);
                });

                btnRemoveDia.Enabled = btnRemoveDia.Visible = lstPrescricao.Where(n => n.IdChavePrescricao == chave.Id).All(n => n.Datas.Count > 1);
                GetItensPrescricao(true);
                comboBoxDataPrescricao.SelectedValue = chave.Id;
                PopulaPrescricoes();
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
                chave = (ChavePrescricao)comboBoxDataPrescricao.SelectedItem;
                if (chave.Id == 0)
                    return;

                //if ((int)chave.StatusPrescricao == 3)
                //{
                //    MessageBox.Show("Não é possivel alterar a prescrição, pois a mesma já foi validada pelo enfemeiro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    return;
                //}

                lstPrescricao.Where(n => n.IdChavePrescricao == chave.Id).ToList().ForEach(p => { 
                    p.Datas.Remove(p.Datas.LastOrDefault());
                    p.CicloData = JsonConvert.SerializeObject(p.Datas, Formatting.None);
                    presenterGeneric.Salvar(p, Procedure.SP_ADD_PRESCRICAO, Acao.Inserir);
                });

                btnRemoveDia.Enabled = lstPrescricao.Where(n => n.IdChavePrescricao == chave.Id).All(n => n.Datas.Count > 1);
                GetItensPrescricao(true);
                comboBoxDataPrescricao.SelectedValue = chave.Id;
                PopulaPrescricoes();

            }
            catch (Exception exRemovDia)
            {
                FrmMain.Alert(exception: exRemovDia);
            }
        }

        private void btnCriarPrescricao_Click(object sender, EventArgs e)
        {
            lblCicloPrescricao.Location = new Point(comboBoxDataPrescricao.Location.X, lblCicloPrescricao.Location.Y);
            pNamePrescricao.Visible = false;
            pnlCalendario.Visible = pnlControle.Visible = !pNamePrescricao.Visible;

            CalendarCicloPrescricao.Enabled = true;
            CalendarCicloPrescricao.BoldedDates = null;
            btnAddCiclo.Visible = true;
            dataGridViewPrescricoes.DataSource = null;
            btnAddDia.Visible = btnNewLine.Visible = btnRemoveDia.Visible = comboBoxDataPrescricao.Visible = lblTotalPrescricao.Visible = btnAddCiclo.Visible = true;
            btnAddDia.Enabled = btnNewLine.Enabled = btnRemoveDia.Enabled = comboBoxDataPrescricao.Enabled = btnAddCiclo.Enabled = false;
            lblCicloPrescricao.Text = "Selecione o intervalo entre datas que ocorrerá o ciclo da prescrição!";
            lblCicloPrescricao.Visible = true;
        }

        private void btnCancelaPrescricao_Click(object sender, EventArgs e)
        {
            textBoxNomePrescricao.Text = string.Empty;
            pNamePrescricao.Visible = false;
            pnlControle.Visible = !pNamePrescricao.Visible;
        }

        private void dataGridViewPrescricoes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    DataGridView sendGrid = (DataGridView)sender;
            //    DataRow dataRow = table.Rows[e.RowIndex];

            //    CicloPrescricao cicloPrescricao = lstCiclo.FirstOrDefault(i => i.DataCiclo == DateTime.Today);

            //    if (sendGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            //    {
            //        if (sendGrid.Columns[e.ColumnIndex].Name != "Act" && sendGrid.Columns[e.ColumnIndex].Name != "Note")
            //        {
            //            if (Sessao.Usuario.Perfil.HasFlag(Perfil.Medico))
            //                return;

            //            ChavePrescricao chave = (ChavePrescricao)comboBoxDataPrescricao.SelectedItem;
            //            if ((int)chave.StatusPrescricao != 3)
            //                return;

            //            DateTime dateTime = Convert.ToDateTime(sendGrid.Columns[e.ColumnIndex].HeaderText);

            //            if (dateTime.Equals(DateTime.Now.Date))
            //            {
            //                if (cicloPrescricao.Checado.HasValue)
            //                {
            //                    MessageBox.Show($"O item de prescição para a data {DateTime.Today.ToShortDateString()}, ja foi checado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                    return;
            //                }

            //                if ((Perfil.Enfermeiro_Assistemcial | Perfil.Tecnico).HasFlag(Sessao.Usuario.Perfil))
            //                {
            //                    TimeSpan time = (TimeSpan)sendGrid["Horario", e.RowIndex].Value;
            //                    if (DateTime.Now.TimeOfDay - time > new TimeSpan(2, 0, 59) || DateTime.Now.TimeOfDay - time < new TimeSpan(-2, 0, 59))
            //                    {
            //                        string msgBox = "Esse item de prescrição, tem mais de 2:00 atrasada ou adiantada do horario previsto.";
            //                        msgBox += "\nDeseja realizar a checagem e justificar o motivo.";

            //                        if (MessageBox.Show(msgBox, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //                        {
            //                            int itemPrescricao = Convert.ToInt32(sendGrid[0, e.RowIndex].Value);
            //                            using (Form f = new Frm.FrmJustificarChecagem(chave, itemPrescricao, 2))
            //                            {
            //                                f.DialogResult = f.ShowDialog();
            //                                if (f.DialogResult == DialogResult.Cancel)
            //                                    return;
            //                            }
            //                        }
            //                        else
            //                            return;
            //                    }
            //                }
            //                else
            //                    return;

            //                bool mod = true;
            //                if (!string.IsNullOrWhiteSpace(cicloPrescricao.IdPrescricao))
            //                    mod = cicloPrescricao.IdPrescricao.Split(',').Count(s => s.Equals(dataRow["Id"].ToString())) % 2 == 0;

            //                if (mod)
            //                {
            //                    sendGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.IsOk;
            //                    sendGrid.Rows[e.RowIndex].Cells["Horario"].ReadOnly = false;
            //                    TimeSpan.TryParse(sendGrid.Rows[e.RowIndex].Cells["Intervalo"].Value.ToString(), out TimeSpan _timerInvervalor);
            //                    string proximo = DateTime.Now.AddHours(_timerInvervalor.Hours).ToShortTimeString();
            //                    sendGrid.Rows[e.RowIndex].Cells["Horario"].Value = proximo;
            //                    sendGrid.Rows[e.RowIndex].Cells["Horario"].ReadOnly = false;
            //                    //dataGridViewPrescricoes_CellEndEdit(sender, e);
            //                    cicloPrescricao.IdPrescricao += $"{Convert.ToInt32(dataRow["Id"])},";
            //                }
            //                else
            //                {
            //                    sendGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.Wait;
            //                    cicloPrescricao.IdPrescricao = string.Join(",", cicloPrescricao.IdPrescricao.Replace(dataRow["Id"].ToString(), string.Empty).Split(',').Where(s => !string.IsNullOrWhiteSpace(s)).ToArray()) + ",";
            //                }

            //                if (cicloPrescricao.IdPrescricao.Split(',').Count(x => !string.IsNullOrWhiteSpace(x)) == 0)
            //                    cicloPrescricao.IdPrescricao = null;

            //                presenterGeneric.Salvar(new CicloPrescricao()
            //                {
            //                    Id = Convert.ToInt32(table.Columns[e.ColumnIndex].ExtendedProperties["Id"]),
            //                    IdPaciente = Sessao.Paciente.Id,
            //                    IdPrescricao = cicloPrescricao.IdPrescricao,
            //                    IdChavePrescricao = Convert.ToInt32(table.Rows[e.RowIndex]["IdChavePrescricao"]),
            //                    Checado = !string.IsNullOrWhiteSpace(cicloPrescricao.IdPrescricao) ? DateTime.Now : (DateTime?)null
            //                }, Procedure.SP_ADD_DATE, Acao.Atualizar);

            //                comboBoxDataPrescricao_SelectedIndexChanged(comboBoxDataPrescricao, null);
            //            }
            //            else
            //                MessageBox.Show("Não é permitido realizar checagem de cuidados prescritos em datas passadas ou futuras", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        }
            //    }
            //}
            //catch (Exception exChekPrescricao)
            //{
            //    FrmMain.Alert(exception: exChekPrescricao);
            //}
        }

        private void dataGridViewPrescricoes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView sendGrid = (DataGridView)sender;
                if (new string[] { "Horario", "Intervalo", "Prescricao" }.Contains(sendGrid.Columns[e.ColumnIndex].Name))
                {
                    if (sendGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Split('.').Count() == 2)
                    {
                        MessageBox.Show($"Horario invalido: " + sendGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        sendGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "00:00";
                        return;
                    }

                    var id = Convert.ToInt32(sendGrid.Rows[e.RowIndex].Cells["Id"].Value);

                    if (lstPrescricao.Any(n => n.Id == id))
                    {
                        prescricaoMedica = lstPrescricao.Find(n => n.Id == id);
                    }
                    else
                    {
                        prescricaoMedica.Id = id;
                        prescricaoMedica.Prescricao = sendGrid.Rows[e.RowIndex].Cells["Prescricao"].Value is null ? null : sendGrid.Rows[e.RowIndex].Cells["Prescricao"].Value.ToString();
                        prescricaoMedica.Horario = TimeSpan.Parse(sendGrid.Rows[e.RowIndex].Cells["Horario"].Value == null ? "00:00" : sendGrid.Rows[e.RowIndex].Cells["Horario"].Value.ToString());
                        prescricaoMedica.Intervalo = TimeSpan.Parse(sendGrid.Rows[e.RowIndex].Cells["Intervalo"].Value == null ? "00:00" : sendGrid.Rows[e.RowIndex].Cells["Intervalo"].Value.ToString());
                        prescricaoMedica.CicloData = JsonConvert.SerializeObject(prescricaoMedica.Datas, Formatting.None);
                    }

                    presenterGeneric.Salvar(prescricaoMedica, Procedure.SP_ADD_PRESCRICAO, prescricaoMedica.Id == 0 ? Acao.Inserir : Acao.Atualizar);
                }
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
            if (e.RowIndex < 0)
                return;

            if (dataGridViewPrescricoes.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                var coluna = dataGridViewPrescricoes.Columns[e.ColumnIndex];
                if (coluna.Name.Equals("Act"))
                {
                    if (Sessao.Usuario.Perfil.HasFlag(Perfil.Medico))
                    {
                        try
                        {
                            int _id = Convert.ToInt32(dataGridViewPrescricoes.Rows[e.RowIndex].Cells[0].Value);
                            _id = presenterGeneric.Salvar(new PrescricaoMedica() { Id = _id }, Procedure.SP_DEL_PRESCRICAO, Acao.Excluir);
                            
                            if (_id > 0)
                            {
                                if (dataGridViewPrescricoes.Rows.Count == 1)
                                {
                                    chave = (ChavePrescricao)comboBoxDataPrescricao.SelectedItem;
                                    _id = presenterGeneric.Salvar(new PrescricaoMedica() { Id = chave.Id }, Procedure.SP_DEL_CHAVE_PRESCRICAO, Acao.Excluir);
                                    dataGridViewPrescricoes.DataSource = null;
                                    btnAddDia.Enabled = btnNewLine.Enabled = btnRemoveDia.Enabled =  false;
                                }

                                GetItensPrescricao(true);
                                comboBoxDataPrescricao.SelectedValue = chave.Id;
                                PopulaPrescricoes();

                                if (dataGridViewPrescricoes.Rows.Count == 0)
                                {

                                    GetDatas(true);
                                    Resetcontrols(btnAddCiclo, false);
                                    Resetcontrols(dataGridViewPrescricoes);
                                    btnAddCiclo.Visible = false;

                                    return;
                                }

                            }
                        }
                        catch (Exception exRemoveItem)
                        {
                            FrmMain.Alert(exception: exRemoveItem);
                        }
                    }
                }

                if (coluna.Name.Equals("Note"))
                {
                    chave = (ChavePrescricao)comboBoxDataPrescricao.SelectedItem;
                    int _id = Convert.ToInt32(dataGridViewPrescricoes.Rows[e.RowIndex].Cells[0].Value);
                    new Frm.FrmJustificarChecagem(chave, _id, _cicloPrescricao: null).ShowDialog();
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
                if (lstPrescricao.Any(n => n.Horario is null))
                {
                    MessageBox.Show("Existem itens da prescrição médica que não tem horário definidos para o inicio.\nPor favor defina um horário para os itens.","AVISO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                string aviso = "Ao aceitar, não será possível realizar alterações, apenas para checagem.\n" +
                    "Os horários serão controlados durante cada checagem com base no intervalo definido.\n\n" +
                    "Deseja prosseguir e aceitar esta prescrição?";
                DialogResult dialogResult = MessageBox.Show(aviso, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    int idPrescricao = Convert.ToInt32(comboBoxDataPrescricao.SelectedValue);
                    int ret = presenterGeneric.Salvar(new ChavePrescricao() { Prontuario = Sessao.Paciente.Prontuario, Id = idPrescricao, Status = StatusPrescricao.Aprovado }, Procedure.SP_ADD_CHAVE_PRESCRICAO);

                    GetDatas(true);
                   
                    btnDevolverPrescricao.Visible = lblValidaPrescricao.Visible = btnValidarPrescricao.Visible = lstChavePrescricoes.Any(n => n.Status == StatusPrescricao.Revisao);
                    comboBoxDataPrescricao.SelectedValue = idPrescricao;

                    if (ret > 0)
                        FrmMain.Alert(Alerts.InsertSuccess);

                    
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
                    btnValidarPrescricao.Visible = btnDevolverPrescricao.Visible = false;
                    dataGridViewPrescricoes.DataSource = null;

                    return;
                }

                dataGridViewPrescricoes.DataSource = null;
               chave = (ChavePrescricao)comboBoxDataPrescricao.SelectedItem;

                if (Sessao.Usuario.Perfil.HasFlag(Perfil.Enfermeiro_Assistemcial))
                    btnValidarPrescricao.Visible = btnDevolverPrescricao.Visible = chave.Status != StatusPrescricao.Aprovado ;

                if (Sessao.Usuario.Perfil.HasFlag(Perfil.Medico))
                {
                    btnDevolverPrescricao.Visible = chave.Status ==  StatusPrescricao.Aprovado ;
                    btnDevolverPrescricao.Text = "Visualizar observações";
                    btnDevolverPrescricao.IconChar = IconChar.Eye;
                    btnDevolverPrescricao.IconColor = Color.White;
                }

                lstPrescricao = presenterGeneric.GetLista(new PrescricaoMedica() { Id = 0, Prontuario = Sessao.Paciente.Prontuario, IdChavePrescricao = chave.Id, }, Procedure.SP_GET_PRESCRICAO);

                PopulaPrescricoes();

                FrizenGrid(chave);
            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
        }

        void ConfigGrid()
        {
            dataGridViewPrescricoes.Visible = dataGridViewPrescricoes.Rows.Count > 0;
            dataGridViewPrescricoes.Columns["Prescricao"].MinimumWidth = 300;
            dataGridViewPrescricoes.Columns["Prescricao"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        void GetDatas(bool isLoad = false)
        {
            lstChavePrescricoes.Clear();

            if (isLoad)
                lstFullChaves.Clear();

            if (!lstFullChaves.Any())
            {
                lstFullChaves = presenterGeneric.GetLista(new ChavePrescricao()
                {
                    Prontuario = Sessao.Paciente.Prontuario,
                }, Procedure.SP_GET_CHAVE_PRESCRICAO);
            }

            if (Perfil.Medico == Sessao.Usuario.Perfil)
                lstChavePrescricoes = lstFullChaves.Where (r => (StatusPrescricao.Aprovado | StatusPrescricao.Edicao | StatusPrescricao.Revisao).HasFlag(r.Status)).ToList();

            if ((Perfil.Enfermeiro_Assistemcial | Perfil.EnfermeiroAdmin).HasFlag(Sessao.Usuario.Perfil))
                lstChavePrescricoes = lstFullChaves.Where(r => (StatusPrescricao.Aprovado | StatusPrescricao.Analise).HasFlag(r.Status)).ToList();

            if (Perfil.Tecnico == Sessao.Usuario.Perfil)
                lstChavePrescricoes = lstFullChaves.Where(r => r.Status == StatusPrescricao.Aprovado ).ToList();

            lstChavePrescricoes.Insert(0, new ChavePrescricao() { Id = 0, NomePrescricao = "Selecione..." });
            comboBoxDataPrescricao.DataSource = lstChavePrescricoes;

            int countPrescricao = 0;
            if (Sessao.Usuario.Perfil.HasFlag(Perfil.Enfermeiro_Assistemcial & Perfil.EnfermeiroAdmin))
            {
                countPrescricao = lstChavePrescricoes.Count(c => c.Status ==  StatusPrescricao.Analise);
                lblValidaPrescricao.Visible = countPrescricao > 0; //&& !(Perfil.Tecnico | Perfil.Medico).HasFlag(Sessao.Usuario.Perfil);
                lblValidaPrescricao.Text = countPrescricao > 1 ? $"Identificado {countPrescricao} novas prescrições para serem validadas." : $"Identificado 1 nova prescrição para validar.";
            }

            if (Sessao.Usuario.Perfil.HasFlag(Perfil.Medico))
            {
                countPrescricao = lstChavePrescricoes.Count(c => c.Status ==  StatusPrescricao.Revisao);
                lblValidaPrescricao.Visible = countPrescricao > 0;
                lblValidaPrescricao.Text = countPrescricao > 1 ? $"Identificado {countPrescricao} prescrições para revisão." : $"Identificado 1 prescrição para revisão.";
            }

            lblTotalPrescricao.Text = $"{lstChavePrescricoes.Count(p => p.Id > 0)} Prescrição cadastradas";
        }

        void GetItensPrescricao(bool isLoad = false)
        {
            if (isLoad)
                lstFullItensPrescricao.Clear();

            if (!lstFullItensPrescricao.Any())
                lstFullItensPrescricao = presenterGeneric.GetLista(new PrescricaoMedica() { Id = 0, Prontuario = Sessao.Paciente.Prontuario }, Procedure.SP_GET_PRESCRICAO);

            lstPrescricao = lstFullItensPrescricao.Where(n => n.IdChavePrescricao == chave.Id).ToList();
        }

        private void PopulaPrescricoes()
        {
            try
            {
                if (!lstPrescricao.Any())
                    return;

                Resetcontrols(dataGridViewPrescricoes);

                DataGridViewImageColumn imageColumn = null;

                lstPrescricao.Where(x => x.IdChavePrescricao == chave.Id).ToList().ForEach(p =>
                {
                    if (!string.IsNullOrWhiteSpace(p.CicloData) && !p.Datas.Any())
                        p.Datas = JsonConvert.DeserializeObject<List<DateTime>>(p.CicloData);

                    if(dataGridViewPrescricoes.Columns.Count == 4 )
                        foreach (var item in p.Datas)
                        {
                            imageColumn = new DataGridViewImageColumn
                            {
                                Image = Properties.Resources.Wait,
                                HeaderText = item.Date.ToString("dd/MM"),
                                ToolTipText = item.Date.ToShortDateString(),
                                Width = 35,
                                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight }
                            };
                            dataGridViewPrescricoes.Columns.Add(imageColumn);
                        }
                });

                imageColumn = new DataGridViewImageColumn
                {
                    Image = Properties.Resources.rubbishbin_102620,
                    Name = "Act",
                    HeaderText = "Del",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells,
                    DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
                };
                dataGridViewPrescricoes.Columns.Add(imageColumn);

                imageColumn = new DataGridViewImageColumn
                {
                    Image = Properties.Resources.template01,
                    Name = "Note",
                    HeaderText = "Note",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells,
                    Visible = false,
                    DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
                };
                dataGridViewPrescricoes.Columns.Add(imageColumn);

                dataGridViewPrescricoes.DataSource = lstPrescricao.Where(x => x.IdChavePrescricao == chave.Id).ToList();
                dataGridViewPrescricoes.Visible = true;
               
                //CicloPrescricao cicloPrescricao = null;

                //List<DataColumn> dataColumns = new List<DataColumn>();
                //DataColumn dataColumn = null;
                //lstCiclo.ForEach(c => {
                //    dataColumn = new DataColumn(c.DataCiclo?.ToString("dd/MM"), typeof(Image));
                //    dataColumn.ExtendedProperties.Add("Id", c.Id);
                //    dataColumns.Add(dataColumn);
                //    table.Columns.Add(dataColumn);
                //});


                //lstPrescricao.ForEach(presc =>
                //{
                //    DataRow row = table.NewRow();

                //    row["Id"] = presc.Id;
                //    row["IdChavePrescricao"] = presc.IdChavePrescricao;
                //    row["IdCliente"] = Sessao.CodigoCliente;
                // //   row["IdPaciente"] = presc.IdPaciente;
                //    row["Prescricao"] = presc.Prescricao;
                //  //  row["Intervalo"] = presc.Intervalo == null ? "00:00" : presc.Intervalo?.ToString(@"hh\:mm");
                //  //  row["Horario"] = presc.Horario == null ? "00:00" : presc.Horario?.ToString(@"hh\:mm"); 

                //    foreach (DataColumn item in dataColumns)
                //    {
                //        cicloPrescricao = lstCiclo.FirstOrDefault(dt => dt.DataCiclo.Value.ToString("dd/MM") == item.ColumnName);

                //        if (cicloPrescricao.DataCiclo >= DateTime.Now.Date)
                //        {
                //            if (cicloPrescricao.Checado != null)
                //            {
                //                if (cicloPrescricao.IdPrescricao.Split(',').Any(p => presc.Id.ToString().Equals(p)))
                //                    row[item.ColumnName] = Properties.Resources.IsOk;
                //                else
                //                    row[item.ColumnName] = Properties.Resources.Wait;
                //            }
                //            else
                //                row[item.ColumnName] = Properties.Resources.Wait;
                //        }
                //        else
                //        {
                //            if (cicloPrescricao.Checado != null)
                //                if (cicloPrescricao.IdPrescricao.Split(',').Any(p => presc.Id.ToString().Equals(p)))
                //                    row[item.ColumnName] = Properties.Resources.IsOk;
                //                else
                //                    row[item.ColumnName] = Properties.Resources.integative;
                //            else
                //                row[item.ColumnName] = Properties.Resources.NotOk;
                //        }
                //    }

                //    if (!table.Columns.Contains("Act"))
                //    {
                //        table.Columns.Add(new DataColumn("Act", typeof(Image)));
                //    }

                //    row["Act"] = Properties.Resources.rubbishbin_102620;

                //    if (!table.Columns.Contains("Note"))
                //    {
                //        table.Columns.Add(new DataColumn("Note", typeof(Image)));
                //    }

                //    row["Note"] = Properties.Resources.Documents;

                //    table.Rows.Add(row);
                //});

                //dataGridViewPrescricoes.DataSource = null;
                //dataGridViewPrescricoes.DataSource = table;
                ConfigGrid();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void FrizenGrid(ChavePrescricao chavePrescricao)
        {
            dataGridViewPrescricoes.Columns["Prescricao"].ReadOnly = (!Sessao.Usuario.Perfil.HasFlag(Perfil.Medico) || chavePrescricao.Status ==  StatusPrescricao.Aprovado);
            dataGridViewPrescricoes.Columns["Horario"].ReadOnly = (!Sessao.Usuario.Perfil.HasFlag(Perfil.EnfermeiroAdmin & Perfil.Enfermeiro_Assistemcial) || chavePrescricao.Status == StatusPrescricao.Aprovado);
            dataGridViewPrescricoes.Columns["Horario"].Visible = (Sessao.Usuario.Perfil.HasFlag(Perfil.EnfermeiroAdmin & Perfil.Enfermeiro_Assistemcial) || chavePrescricao.Status == StatusPrescricao.Aprovado);
            dataGridViewPrescricoes.Columns["Intervalo"].ReadOnly = !Sessao.Usuario.Perfil.HasFlag(Perfil.Medico);
            dataGridViewPrescricoes.Columns["Act"].Visible = (Sessao.Usuario.Perfil.HasFlag(Perfil.Medico) && chavePrescricao.Status != StatusPrescricao.Aprovado);
            dataGridViewPrescricoes.Columns["Act"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewPrescricoes.Columns["Note"].Visible = (Sessao.Usuario.Perfil.HasFlag(Perfil.Tecnico) && chavePrescricao.Status == StatusPrescricao.Aprovado);
            btnAddDia.Visible = Sessao.Usuario.Perfil.HasFlag(Perfil.Medico);
            btnNewLine.Visible = Sessao.Usuario.Perfil.HasFlag(Perfil.Medico);
            btnRemoveDia.Visible = Sessao.Usuario.Perfil.HasFlag(Perfil.Medico) && lstPrescricao.Where(n => n.IdChavePrescricao == chave.Id).All(n => n.Datas.Count > 1);
        }

        private void btnDevolverPrescricao_Click(object sender, EventArgs e)
        {
            chave = (ChavePrescricao)comboBoxDataPrescricao.SelectedItem;

            DialogResult dialogResult = new Frm.FrmJustificarChecagem(chave, _tipo: 1).ShowDialog();

            if (Sessao.Usuario.Perfil.HasFlag(Perfil.Medico))
            {
                if (dialogResult == DialogResult.OK)
                {
                    int ret = presenterGeneric.Salvar(new ChavePrescricao()
                    {
                        Id = chave.Id,
                        Prontuario = Sessao.Paciente.Prontuario,
                        Status =  StatusPrescricao.Analise,
                    }, Procedure.SP_ADD_CHAVE_PRESCRICAO);

                    GetDatas(true);
                    Resetcontrols(dataGridViewPrescricoes);
                    btnDevolverPrescricao.Visible = lblValidaPrescricao.Visible = btnValidarPrescricao.Visible = lstChavePrescricoes.Any(n => n.Status == StatusPrescricao.Revisao);

                    if (ret > 0)
                        FrmMain.Alert(Alerts.InsertSuccess);
                }
            }
            else
            {

                if (dialogResult == DialogResult.OK)
                {
                    int ret = presenterGeneric.Salvar(new ChavePrescricao()
                    {
                        Id = chave.Id,
                        Prontuario = Sessao.Paciente.Prontuario,
                        Status =  StatusPrescricao.Revisao
                    }, Procedure.SP_ADD_CHAVE_PRESCRICAO);

                    GetDatas(true);
                    Resetcontrols(dataGridViewPrescricoes);
                    btnDevolverPrescricao.Visible = lblValidaPrescricao.Visible = btnValidarPrescricao.Visible = lstChavePrescricoes.Any(n => n.Status == StatusPrescricao.Analise);
                    if (ret > 0)
                        FrmMain.Alert(Alerts.InsertSuccess);
                }
            }
        }

        private void dataGridViewPrescricoes_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //DataGridView senderGrid = (DataGridView)sender;

            //foreach (DataGridViewRow row in senderGrid.Rows)
            //{
            //    if (row.Index < e.RowIndex)
            //        continue;
            //    var lst = row.Cells.OfType<DataGridViewImageCell>().ToList();

            //    lst.ForEach(c =>
            //    {

            //        var coluna = senderGrid.Columns[c.ColumnIndex];
            //        var cicloPrescricao = DateTime.Now;

            //        if (cicloPrescricao != null)
            //        {
            //            if (cicloPrescricao.DataCiclo >= DateTime.Now.Date)
            //            {
            //                if (cicloPrescricao.Checado != null)
            //                {
            //                    if (cicloPrescricao.IdPrescricao.Split(',').Any(p => row.Cells["Id"].Value.ToString().Equals(p)))
            //                        c.ToolTipText = "Item de prescrição checado!";
            //                    else
            //                        c.ToolTipText = "Aguardando checagem!";
            //                }
            //                else
            //                    c.ToolTipText = "Aguardando checagem!";
            //            }
            //            else
            //            {
            //                if (cicloPrescricao.Checado != null)
            //                    if (cicloPrescricao.IdPrescricao.Split(',').Any(p => row.Cells["Id"].Value.ToString().Equals(p)))
            //                        c.ToolTipText = "Item de prescrição checado!";
            //                    else
            //                        c.ToolTipText = "Item de prescrição NÃO checado!";
            //                else
            //                    c.ToolTipText = "Nenhum item de precrição foi checado nesta data!";
            //            }
            //        }
            //    });

            //}
        }

        private void comboBoxDataPrescricao_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                lblCicloPrescricao.Visible = pnlCalendario.Visible = false;
                 
                if (Sessao.Usuario.Perfil.HasFlag(Perfil.Medico))
                {
                    btnAddDia.Enabled = btnRemoveDia.Enabled = btnNewLine.Enabled = !(comboBoxDataPrescricao.SelectedIndex == 0);
                }

                if (comboBoxDataPrescricao.SelectedIndex == 0)
                {
                    btnValidarPrescricao.Visible = btnDevolverPrescricao.Visible = dataGridViewPrescricoes.Visible = btnAddCiclo.Visible =false;

                    Resetcontrols(dataGridViewPrescricoes);

                    return;
                }

                dataGridViewPrescricoes.DataSource = null;
                chave = (ChavePrescricao)comboBoxDataPrescricao.SelectedItem;


                if (Sessao.Usuario.Perfil.HasFlag(Perfil.Enfermeiro_Assistemcial))
                    btnValidarPrescricao.Visible = btnDevolverPrescricao.Visible = chave.Status != StatusPrescricao.Aprovado;

                if (Sessao.Usuario.Perfil.HasFlag(Perfil.Medico))
                {
                    btnDevolverPrescricao.Visible = chave.Status == StatusPrescricao.Revisao;
                    btnDevolverPrescricao.Text = "Visualizar e reenviar";
                    btnDevolverPrescricao.IconChar = IconChar.Eye;
                    btnDevolverPrescricao.IconColor = Color.White;
                }

                GetItensPrescricao();
                comboBoxDataPrescricao.SelectedValue = chave.Id;
                PopulaPrescricoes();

                if (lstPrescricao.Any())
                    FrizenGrid(chave);

                if ((StatusPrescricao.Edicao | StatusPrescricao.Revisao).HasFlag(chave.Status))
                    Resetcontrols(btnAddCiclo, true);

                btnAddCiclo.Visible = (StatusPrescricao.Edicao == chave.Status);
            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
        }

        private void Resetcontrols(Control typeControl, bool isChange = false)
        {
            if (typeControl is IconButton)
            {
                if (typeControl.Name.Equals("btnAddCiclo"))
                {
                    IconButton button = (IconButton)typeControl;

                    FrmMain.RemoveClickEvent(button);

                    if (isChange)
                    {
                        button.Text = "Entregar Prescrição";
                        button.IconChar = IconChar.ClipboardList;
                        button.Width = 145;
                        button.BackColor = Color.Teal;
                        button.Click += EntregarPrescricao_Click;
                    }
                    else
                    {
                        button.Text = "Promover e Iniciar Ciclo";
                        button.IconChar = IconChar.ClipboardCheck;
                        button.Width = 158;
                        button.Visible = false;
                        button.BackColor = Color.FromArgb(6, 39, 69);
                        button.Click += btnAddCiclo_Click;
                    }
                }
            }

            if (typeControl is DataGridView)
            {
                dataGridViewPrescricoes.DataSource = null;

                if (dataGridViewPrescricoes.Columns.Count > 4)
                    for (int i = dataGridViewPrescricoes.Columns.Count - 1; i >= 4; i--)
                        dataGridViewPrescricoes.Columns.RemoveAt(i);

                dataGridViewPrescricoes.Visible = btnAddDia.Visible = btnNewLine.Visible = btnRemoveDia.Visible = false;
            }
        }

        private void EntregarPrescricao_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = "Você confirma o envio desta prescrição médica para a equipe de enfermagem?";
                DialogResult dialogResult = MessageBox.Show(msg, "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.No)
                    return;

                presenterGeneric.Salvar(new ChavePrescricao() { Id = chave.Id  ,Prontuario = Sessao.Paciente.Prontuario, Status = StatusPrescricao.Analise}, Procedure.SP_ADD_CHAVE_PRESCRICAO);
                GetDatas(true);
                Resetcontrols(dataGridViewPrescricoes);

                btnAddCiclo.Visible = false;
                comboBoxDataPrescricao.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }

        }
    }
}
