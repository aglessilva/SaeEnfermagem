using AppInternacao.Model;
using AppInternacao.Presenter;
using AppInternacao.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AppInternacao.FrmSae
{
    public partial class _004FrmQuartoLeito : UI000FrmTemplate, IQuarto, ILeito
    {
        public _004FrmQuartoLeito()
        {
            InitializeComponent();
            dataGridViewQuartos.AutoGenerateColumns = false;
            dataGridViewLeito.AutoGenerateColumns = false;
        }

        RadioButton pictureBoxLeito = null;
        ToolTip toolTip = null;
        QuartoPresenter presenterQuarto = null;
        LeitoPresenter presenterLeito = null;
        Leito obj = null;
        private List<Leito> lstObjLeito;

        public Quarto Quarto
        {
            get => new Quarto()
            {
                Id = string.IsNullOrWhiteSpace(textBoxId.Text) ? 0 : Convert.ToInt32(textBoxId.Text),
                NomeQuarto = textBoxNomeQuarto.Text,
                IdSetor = comboBoxSetor.SelectedItem == null ? 0 : Convert.ToInt32(comboBoxSetor.SelectedValue),
                TotalLeito = comboBoxQtdLeitos.SelectedItem == null ? 0 : Convert.ToInt32(comboBoxQtdLeitos.SelectedItem)
            };
            set
            {
                textBoxId.Text = value?.Id.ToString();
                textBoxNomeQuarto.Text = value.NomeQuarto;
                comboBoxSetor.SelectedValue = value.IdSetor == 0 ? 0 : value.IdSetor;
                comboBoxQtdLeitos.SelectedItem = value.TotalLeito > 0 ? value.TotalLeito.ToString() : "1";
            }
        }
        public List<Quarto> Quartos
        {
            set
            {
                dataGridViewQuartos.DataSource = null;
                dataGridViewQuartos.DataSource = value;

                Quarto[] lstQuartoPesquisa = new Quarto[value.Count+1];
                Quarto[] lstQuartoCombo = new Quarto[value.Count + 1];
                value.CopyTo(lstQuartoCombo, 1);
                value.CopyTo(lstQuartoPesquisa,1);
                lstQuartoPesquisa[0]= new Quarto() { Id = 0, IdSetor = 0, NomeQuarto = "Todos" };
                lstQuartoCombo[0]= new Quarto() { Id = 0, IdSetor = 0, NomeQuarto = "Todos" };

                comboBoxQuarto.DataSource = lstQuartoPesquisa;
                comboBoxPesquisaQuarto.DataSource = lstQuartoCombo;
            }
        }
        public List<Setor> Setores
        {
            set
            {
                var objlst = value;
                objlst.Insert(0, new Setor { Id = 0, NomeSetor = "Todos" });
                comboBoxSetor.DataSource = objlst;
            }
        }

        public Leito Leito
        {
            get => new Leito()
            {
                Id = string.IsNullOrWhiteSpace(textBoxIdLeito.Text) ? 0 : Convert.ToInt32(textBoxIdLeito.Text),
                IdQuarto = comboBoxQuarto.SelectedItem == null ? 0 : Convert.ToInt32(comboBoxQuarto.SelectedValue),
                NomeLeito = textBoxNomeLeito.Text,
                IsManutencao = chkLeitoManutencao.Checked,
            };
            set
            {
                textBoxIdLeito.Text = value.Id.ToString();
                textBoxNomeLeito.Text = value.NomeLeito;
                textBoxIdLeitoQuarto.Text = value.IdQuarto == 0 ? string.Empty : value.IdQuarto.ToString();
                chkLeitoManutencao.Checked = value.IsManutencao;
                comboBoxQuarto.SelectedValue = value.IdQuarto;
                chkLeitoManutencao.Enabled = value.IsDisponibilidade;
            }
        }
        public List<Leito> Leitos { set { dataGridViewLeito.DataSource = value; lstObjLeito = value; } }

        bool Valida(TabPage x)
        {
            bool y = false;

            if (x == tabPageQuartos)
            {
                bool[] ret = { true, true };

                if (string.IsNullOrWhiteSpace(textBoxNomeQuarto.Text))
                {
                    errorProvider1.SetError(textBoxNomeQuarto, "Preencha este campo");
                    errorProvider1.SetIconPadding(textBoxNomeQuarto, 3);
                    ret[0] = false;
                }
                else
                {
                    errorProvider1.SetError(textBoxNomeQuarto, null);
                }

                if (comboBoxQtdLeitos.SelectedItem == null)
                {
                    errorProvider1.SetError(comboBoxQtdLeitos, "Preencha este campo");
                    errorProvider1.SetIconPadding(comboBoxQtdLeitos, 3);
                    ret[1] = false;
                }
                else
                {
                    errorProvider1.SetError(comboBoxQtdLeitos, null);
                }

                if (comboBoxSetor.SelectedIndex == 0)
                {
                    errorProvider1.SetError(comboBoxSetor, "Preencha este campo");
                    errorProvider1.SetIconPadding(comboBoxSetor, 3);
                    ret[1] = false;
                }
                else
                {
                    errorProvider1.SetError(comboBoxSetor, null);
                }

                y = ret.ToList().TrueForAll(v => v);
            }

            if (x == tabPageLeito)
            {
                bool[] ret = { true, true, true };

                if (string.IsNullOrWhiteSpace(textBoxNomeLeito.Text))
                {
                    errorProvider1.SetError(textBoxNomeLeito, "Preencha este campo");
                    errorProvider1.SetIconPadding(textBoxNomeLeito, 3);
                    ret[0] = false;
                }
                else
                {
                    errorProvider1.SetError(textBoxNomeLeito, null);
                }


                if (comboBoxQuarto.SelectedIndex == 0)
                {
                    errorProvider1.SetError(comboBoxQuarto, "Preencha este campo");
                    errorProvider1.SetIconPadding(comboBoxQuarto, 3);
                    ret[1] = false;
                }
                else
                {
                    errorProvider1.SetError(comboBoxQuarto, null);
                }

                y = ret.ToList().TrueForAll(v => v);
            }

            return y;
        }

        private void _004FrmQuartoLeito_Load(object sender, EventArgs e)
        {
            new ToolTip() { UseAnimation = true, IsBalloon = false, }.SetToolTip(buttonLimpar, "Limpar Pesquisa");
            new ToolTip() { UseAnimation = true, IsBalloon = false, }.SetToolTip(button1, "Limpar Pesquisa");

            dataGridViewQuartos.RowEnter -= dataGridViewQuartos_RowEnter;
            dataGridViewLeito.RowEnter -= dataGridViewLeito_RowEnter;
            comboBoxQtdLeitos.SelectedIndexChanged -= comboBoxQtdLeitos_SelectedIndexChanged;
            comboBoxSetor.SelectedIndexChanged -= comboBoxSetor_SelectedIndexChanged;
            comboBoxQuarto.SelectedIndexChanged -= comboBoxQuarto_SelectedIndexChanged;
            comboBoxPesquisaQuarto.SelectedIndexChanged -= comboBoxPesquisaQuarto_SelectedIndexChanged;
            FrmMain.mySalvar.Click += MySalvar_Click;
            FrmMain.myNovo.Click += MyNovo_Click;
            presenterQuarto = new QuartoPresenter(this);
            presenterQuarto.Carregar();

            presenterLeito = new LeitoPresenter(this);
            presenterLeito.Carregar();
            PopulaOcupacoes();
            textBoxNomeQuarto.Focus();

            comboBoxQuarto.SelectedIndexChanged += comboBoxQuarto_SelectedIndexChanged;
            comboBoxPesquisaQuarto.SelectedIndexChanged += comboBoxPesquisaQuarto_SelectedIndexChanged;
            comboBoxSetor.SelectedIndexChanged += comboBoxSetor_SelectedIndexChanged;
            comboBoxQtdLeitos.SelectedIndexChanged += comboBoxQtdLeitos_SelectedIndexChanged;
            dataGridViewQuartos.RowEnter += dataGridViewQuartos_RowEnter;
            dataGridViewLeito.RowEnter += dataGridViewLeito_RowEnter;
        }

        void PopulaOcupacoes(int _id = 0)
        {
            flowLayoutPanelImgLeito.Controls.Clear();
            List<Leito> lst = _id == 0 ? lstObjLeito : lstObjLeito.Where(l => l.IdQuarto == _id).ToList();

            lst.ForEach(l =>
            {

                pictureBoxLeito = new RadioButton();
                pictureBoxLeito.TextAlign = ContentAlignment.TopLeft;
                pictureBoxLeito.ForeColor = Color.DarkSlateGray;
                toolTip = new ToolTip() { IsBalloon = true, UseAnimation = true };
                pictureBoxLeito.Appearance = Appearance.Button;
                pictureBoxLeito.FlatStyle = button1.FlatStyle;
                pictureBoxLeito.FlatAppearance.MouseOverBackColor = button1.FlatAppearance.MouseOverBackColor;
                pictureBoxLeito.FlatAppearance.BorderSize = button1.FlatAppearance.BorderSize;
                pictureBoxLeito.FlatAppearance.CheckedBackColor = button1.FlatAppearance.MouseOverBackColor;
                pictureBoxLeito.Size = new Size(165, 134);
                pictureBoxLeito.Margin = new Padding(20);
                pictureBoxLeito.Cursor = Cursors.Hand;


                if ((bool)l.IsDisponibilidade)
                {
                    pictureBoxLeito.Image = Properties.Resources.LeitoEnable;
                    pictureBoxLeito.Tag = l;
                    pictureBoxLeito.Text = l.NomeLeito;
                    toolTip.SetToolTip(pictureBoxLeito, $"{l.NomeLeito} - Leito Disponivel");
                }
                else
                {
                    pictureBoxLeito.Image = Properties.Resources.LeitoOcupado;
                    pictureBoxLeito.Tag = l;
                    pictureBoxLeito.Text = l.NomeLeito;
                    pictureBoxLeito.Click += DesassociarLeitoPaciente;
                    toolTip.SetToolTip(pictureBoxLeito, $"{l.NomeLeito} - Leito ocupado\nPaciente: {l.Nome}");
                }

                if (l.IsManutencao)
                {
                    pictureBoxLeito.Image = Properties.Resources.LeitoManutencao;
                    pictureBoxLeito.Tag = l;
                    pictureBoxLeito.Text = l.NomeLeito;
                    toolTip.SetToolTip(pictureBoxLeito, $"{l.NomeLeito} - Leito em Manutenção");
                }

                flowLayoutPanelImgLeito.Controls.Add(pictureBoxLeito);
            });

        }

        private void DesassociarLeitoPaciente(object sender, EventArgs e)
        {
            var senderRadio = (RadioButton)sender;
            obj = (Leito)senderRadio.Tag;
            if (obj.IsManutencao)
                return;

            obj = lstObjLeito.FirstOrDefault(p => p.Prontuario == obj.Prontuario);

            string msg = $"Tem certeza que deseja liberar o Leito {obj.NomeLeito}\nocupado pelo paciente {obj.Nome} ?";
            if (MessageBox.Show(msg, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Sessao.Dinamico = obj;
                Frm.FrmJustificativaLeito frm = new Frm.FrmJustificativaLeito(lstObjLeito);
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    AlteracaoLeitoPaciente alteracaoLeitoPaciente = (AlteracaoLeitoPaciente)Sessao.Dinamico;
                    
                    if(alteracaoLeitoPaciente.IdLeitoTransferencia == null)
                            new PacientePresenter().statuInternacao(new StatusInernacaoPaciente() { Prontuario = obj.Prontuario, IdLeito = obj.Id, Status = alteracaoLeitoPaciente.IdStatusAlteracao });
                    //obj.IsManutencao = alteracaoLeitoPaciente.IdStatusAlteracao == Enum.StatusInternacao.ManutencaoLeito;

                    //dataGridViewLeito.DataSource = null;
                    //obj.Nome = string.Empty;
                    //obj.IsDisponibilidade = true;
                    //obj.Prontuario = 0;
                    //obj.Act = 'X';


                    //presenterLeito.Salvar(obj);

                    presenterLeito.Carregar();
                    AtualizaUserControls();
                    obj = null;
                    FindForm().BringToFront();
                }
            }
        }

        private void AtualizaUserControls()
        {
            SplitterPanel split = Parent.Parent.Controls.OfType<SplitterPanel>().LastOrDefault();
            UI005ListaPaciente uC = (UI005ListaPaciente)split.Controls[0];
            uC.Carregar();
            PopulaOcupacoes();
        }

        private void MyNovo_Click(object sender, EventArgs e)
        {
            if (tabControlQuartoLeito.SelectedTab == tabPageLeito)
            {
                errorProvider1.SetError(comboBoxQuarto, null);
                errorProvider1.SetError(textBoxNomeLeito, null);
                chkLeitoManutencao.Checked = false;
                dataGridViewLeito.ClearSelection();
                Leito = new Leito();
                comboBoxQuarto.SelectedIndex = 0;
                textBoxNomeLeito.Focus();

            }

            if (tabControlQuartoLeito.SelectedTab == tabPageQuartos)
            {
                errorProvider1.SetError(comboBoxSetor, null);
                errorProvider1.SetError(comboBoxQtdLeitos, null);
                errorProvider1.SetError(textBoxNomeQuarto, null);

                Quarto = new Quarto();
                if (comboBoxSetor.Items.Count > 0)
                    comboBoxSetor.SelectedIndex = 0;
                comboBoxQtdLeitos.SelectedIndex = 0;
                dataGridViewQuartos.ClearSelection();
                textBoxNomeQuarto.Focus();
            }
        }

        public void MySalvar_Click(object sender, EventArgs e)
        {
            TabPage tab = tabControlQuartoLeito.SelectedTab;

            if (tab == tabPageQuartos)
            {
                if (Valida(tabPageQuartos))
                {
                    presenterQuarto = new QuartoPresenter(this);
                    FrmMain.Alert(presenterQuarto.Salvar());
                    Quarto = new Quarto();
                }
            }

            if (tab == tabPageLeito)
            {
                if (Valida(tabPageLeito))
                {
                    Quarto quarto = (Quarto)comboBoxQuarto.SelectedItem;
                    int _total = lstObjLeito.Count(s => s.IdQuarto == quarto.Id);

                    if(_total >= quarto.TotalLeito)
                    {
                        MessageBox.Show($"A quantidade de leitos disponiveis para o quarto {quarto.NomeQuarto}, já foram cadastrados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    presenterLeito = new LeitoPresenter(this);
                    Leito = new Leito();
                    FrmMain.Alert(presenterLeito.Salvar());
                    PopulaOcupacoes();
                }
            }

            if (tab == tabPageInernacao)
            {
                Paciente paciente = Sessao.Paciente;
                if (paciente != null)
                {
                    RadioButton radioButton = flowLayoutPanelImgLeito.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked == true);

                    if (radioButton == null)
                    {
                        MessageBox.Show("Selecione um Leito disponivel", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                    obj = (Leito)radioButton.Tag;

                    if (obj.IsManutencao)
                    {
                        MessageBox.Show("Leito em MANUTENÇÃO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    string msg = $"Tem certeza que deseja associar o paciente {paciente.Nome} ao  leito {obj.NomeLeito} ?";

                    if (MessageBox.Show(msg, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        obj.IsDisponibilidade = false;
                        obj.Prontuario = paciente.Prontuario;
                        obj.Nome = string.Empty;
                        obj.Act = 'X';
                        presenterLeito.Salvar(obj);

                        // Atualiza Statuso de parciente para Internado
                        paciente.Status = Enum.StatusInternacao.Internado;
                        new PacientePresenter().Salvar(paciente);
                        AtualizaUserControls();
                    }
                }
                else
                    MessageBox.Show("Selecione um paciente na lista ao lado, e tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                Sessao.Paciente = null;
                paciente = null;
            }
            
        }

        private void dataGridViewQuartos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                comboBoxSetor.SelectedIndexChanged -= comboBoxSetor_SelectedIndexChanged;
                if (e.ColumnIndex == 4)
                {
                    var sendGrid = (DataGridView)sender;
                    if (sendGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
                    {
                        Quarto = (Quarto)dataGridViewQuartos.Rows[e.RowIndex].DataBoundItem;
                    }
                }

                if (e.ColumnIndex == 5)
                {
                    var ob = (Quarto)dataGridViewQuartos.Rows[e.RowIndex].DataBoundItem;
                    if (MessageBox.Show($"Deseja excluir o quarto {ob.NomeQuarto} ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        presenterQuarto = new QuartoPresenter(this);
                        FrmMain.Alert(presenterQuarto.Excluir(ob.Id));
                    }
                }
                comboBoxSetor.SelectedIndexChanged += comboBoxSetor_SelectedIndexChanged;
            }
            catch (SqlException exSqEx)
            {
                if (exSqEx.Number == 547)
                {
                    MessageBox.Show("Existem leitos associados para este registro\nExclua os leitos deste quarto antes de remover o quarto " + Quarto.NomeQuarto, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro: " + ex.Message);
            }
        }

        private void dataGridViewLeito_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (tabControlQuartoLeito.SelectedTab != tabPageLeito && tabControlQuartoLeito.SelectedTab != tabPageInernacao)
                return;
            try
            {
                var senderGrid = (DataGridView)sender;
                foreach (DataGridViewRow row in senderGrid.Rows)
                {
                    if (row.Index < e.RowIndex)
                        continue;
                    obj = (Leito)row.DataBoundItem;

                    if ((bool)obj.IsDisponibilidade)
                    {
                        row.Cells[2].Value = Properties.Resources.sinalizadorVer;
                        row.Cells[2].ToolTipText = "Leito DISPONIVEL";
                    }
                    else
                    {
                        row.Cells[2].Value = Properties.Resources.sinalizadorV1;
                        row.Cells[2].ToolTipText = "Leito INDISPONIVEL";
                    }

                    if (obj.IsManutencao)
                    {
                        row.Cells[2].Value = Properties.Resources.sinalizadorManutencao;
                        row.Cells[2].ToolTipText = "Leito em MANUTENÇÃO";
                    }
                }
            }
            catch (Exception exGrid)
            {
                throw new Exception("Ocorreu um Erro ao tentar Listar os Leitos\nERRO:" + exGrid.Message);
            }
        }

        private void dataGridViewQuartos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxSetor.SelectedIndexChanged -= comboBoxSetor_SelectedIndexChanged;
            comboBoxQtdLeitos.SelectedIndexChanged -= comboBoxQtdLeitos_SelectedIndexChanged;
            var sendGrid = (DataGridView)sender;
            Quarto = (Quarto)dataGridViewQuartos.Rows[e.RowIndex].DataBoundItem;

            comboBoxSetor.SelectedIndexChanged += comboBoxSetor_SelectedIndexChanged;
            comboBoxQtdLeitos.SelectedIndexChanged += comboBoxQtdLeitos_SelectedIndexChanged;
            FrmMain.mySalvar.Enabled = true;
            comboBoxQtdLeitos.Enabled = true;
        }

        private void dataGridViewLeito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                comboBoxQuarto.SelectedIndexChanged -= comboBoxQuarto_SelectedIndexChanged;
                if (e.ColumnIndex == 3)
                {
                    var sendGrid = (DataGridView)sender;
                    if (sendGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
                    {
                        Leito = (Leito)dataGridViewLeito.Rows[e.RowIndex].DataBoundItem;
                    }
                }

                if (e.ColumnIndex == 4)
                {
                    var sendGrid = (DataGridView)sender;
                    if (sendGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
                    {
                        obj = (Leito)dataGridViewLeito.Rows[e.RowIndex].DataBoundItem;

                        if (MessageBox.Show($"Deseja excluir o Leito {obj.NomeLeito} ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Leito = obj;
                            presenterLeito = new LeitoPresenter(this);
                            Leito = new Leito();
                            FrmMain.Alert(presenterLeito.Excluir());
                        }
                    }
                }
                comboBoxQuarto.SelectedIndexChanged += comboBoxQuarto_SelectedIndexChanged;
            }
            catch (Exception exG)
            {
                throw new Exception("Erro ao tentar listar os Leitos:\n" + exG.Message);
            }
        }

        private void textBoxPesquisaQuarto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxPesquisaQuarto.Text.Length >= 3)
                {
                    presenterQuarto = new QuartoPresenter(this);
                    presenterQuarto.Carregar(new Quarto { NomeQuarto = textBoxPesquisaQuarto.Text.Trim() });
                }

                if (textBoxPesquisaQuarto.Text.Length == 0)
                {
                    presenterQuarto = new QuartoPresenter(this);
                    presenterQuarto.Carregar();
                }
            }
            catch (Exception exC)
            {
                throw new Exception("Erro ao tentar pesquisar quarto: " + exC.Message);
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxPesquisaQuarto.Text = string.Empty;
        }

        private void textBoxPesquisaLeito_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxPesquisaLeito.Text.Length >= 3)
                {
                    presenterLeito = new LeitoPresenter(this);
                    presenterLeito.Carregar(new Leito { NomeLeito = textBoxPesquisaLeito.Text.Trim() });
                }

                if (textBoxPesquisaLeito.Text.Length == 0)
                {
                    presenterLeito = new LeitoPresenter(this);
                    presenterLeito.Carregar();
                }
            }
            catch (Exception exC)
            {
                throw new Exception("Erro ao tentar pesquisar quarto: " + exC.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxPesquisaLeito.Text = string.Empty;
        }

        private void comboBoxQuarto_SelectedIndexChanged(object sender, EventArgs e)
        {
            chkLeitoManutencao.Checked = false;
            dataGridViewLeito.RowEnter -= dataGridViewLeito_RowEnter;

            if (comboBoxQuarto.SelectedItem == null || comboBoxQuarto.SelectedIndex == 0)
            {
                dataGridViewLeito.DataSource = lstObjLeito.ToList();
                lblTotalLeitos.Visible = false;
            }
            else
            {
                Quarto item = (Quarto)comboBoxQuarto.SelectedItem;
                dataGridViewLeito.DataSource = lstObjLeito.Where(n => n.IdQuarto.Equals(item.Id)).ToList();
                lblTotalLeitos.Text = dataGridViewLeito.RowCount == 0 ? $"Quarto com {item.TotalLeito} vaga(s) para cadastro de leito(s)" : $"Quarto com {item.TotalLeito} leito(s) e {(item.TotalLeito - dataGridViewLeito.RowCount)} {(item.TotalLeito - dataGridViewLeito.RowCount > 1 ? "vagas disponiveis" : "vaga disponivel")} para cadastro";
                lblTotalLeitos.Visible = (item.TotalLeito - dataGridViewLeito.RowCount) != 0;
            }

            dataGridViewLeito.RowEnter += dataGridViewLeito_RowEnter;
        }
        
        private void comboBoxPesquisaQuarto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Quarto item = (Quarto)comboBoxPesquisaQuarto.SelectedItem;
            PopulaOcupacoes(item.Id);
        }

        private void tabControlQuartoLeito_Selecting(object sender, TabControlCancelEventArgs e)
        {
            SplitterPanel split = Parent.Parent.Controls.OfType<SplitterPanel>().LastOrDefault();

            if (e.TabPage.Name.Equals("tabPageInernacao"))
                split.Controls[0].Show();
            else
                split.Controls[0].Hide();

            if (e.TabPageIndex == 0)
                textBoxNomeQuarto.Focus();
            if (e.TabPageIndex == 1)
                textBoxNomeLeito.Focus();

        }

        private void comboBoxSetor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Setor item = (Setor)comboBoxSetor.SelectedItem;
            var _total = lstObjLeito.Count(s => s.IdQuarto == Quarto.Id);

            if (_total > 1 && item.Id == 9)
            {
                MessageBox.Show($"Para o tipo de quarto selecionado, é permitido apenas 1 leito por apartamento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FrmMain.mySalvar.Enabled = false;
                comboBoxQtdLeitos.Enabled = false;
                return;
            }
            else
            {
                FrmMain.mySalvar.Enabled = true;
                comboBoxQtdLeitos.Enabled = true;
            }
            //  dataGridViewQuartos.DataSource = (item.Id > 0 && lstObjetoQuarto != null) ? lstObjetoQuarto.Where(n => n.IdSetor == item.Id).ToList() : lstObjetoQuarto;

            if (item.Id == 9)
            {
                comboBoxQtdLeitos.SelectedIndex = 0;
                comboBoxQtdLeitos.Enabled = false;
            }
        }

        private void _004FrmQuartoLeito_FormClosing(object sender, FormClosingEventArgs e)
        {
         //   FrmMain.mySalvar.Click -= MySalvar_Click;
          //  FrmMain.myNovo.Click -= MyNovo_Click;
        }

        private void dataGridViewLeito_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxQuarto.SelectedIndexChanged -= comboBoxQuarto_SelectedIndexChanged;
           
            var sendGrid = (DataGridView)sender;
            Leito = (Leito)sendGrid.Rows[e.RowIndex].DataBoundItem;

            comboBoxQuarto.SelectedIndexChanged += comboBoxQuarto_SelectedIndexChanged;

        }

        private void comboBoxQtdLeitos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _total = lstObjLeito.Count(s => s.IdQuarto == Quarto.Id );

            if (_total > Convert.ToInt32(comboBoxQtdLeitos.SelectedItem))
            {
                MessageBox.Show("A quantidade de leitos selecionado é menor que a quantidade de leitos já cadastrado para este quarto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FrmMain.mySalvar.Enabled = false;
            }
            else
                FrmMain.mySalvar.Enabled = true;


        }
    }
}
