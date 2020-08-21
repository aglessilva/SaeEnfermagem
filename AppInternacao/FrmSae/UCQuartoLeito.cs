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
    public partial class UCQuartoLeito : UserControl, IQuarto, ILeito
    {
        RadioButton pictureBoxLeito = null;
        ToolTip toolTip = null;
        QuartoPresenter presenterQuarto = null;
        LeitoPresenter presenterLeito = null;
        Leito obj = null;

        private List<Leito> lstObjLeito;
        private List<Quarto> lstObjetoQuarto;
        private Quarto[] lstPesquisaQuarto;

        public Quarto QuartoLeito
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
        public List<Quarto> QuartoLeitos
        {
            set
            {
                lstObjetoQuarto = value;
                lstPesquisaQuarto = new Quarto[lstObjetoQuarto.Count + 1];
                lstObjetoQuarto.Insert(0, new Quarto() { Id = 0, NomeQuarto = "Todos", TotalLeito = 0 });
                lstObjetoQuarto.CopyTo(lstPesquisaQuarto);

                dataGridViewQuartos.DataSource = null;
                dataGridViewQuartos.DataSource = lstObjetoQuarto.Where(q => q.Id > 0).ToList();
                comboBoxQuarto.DataSource = lstObjetoQuarto;
                comboBoxPesquisaQuarto.DataSource = lstPesquisaQuarto.Where(w => w.Id >= 0).ToList();
            }
        }
        public List<Setor> Setores
        {
            set
            {
                comboBoxSetor.DataSource = value;
            }
        }

        public Leito Leito
        {
            get => new Leito()
            {
                Id = string.IsNullOrWhiteSpace(textBoxIdLeito.Text) ? 0 : Convert.ToInt32(textBoxIdLeito.Text),
                IdQuarto = comboBoxQuarto.SelectedItem == null ? 0 : Convert.ToInt32(comboBoxQuarto.SelectedValue),
                NomeLeito = textBoxNomeLeito.Text,
                IsManutencao = chkLeitoManutencao.Checked
            };
            set
            {
                textBoxIdLeito.Text = value.Id.ToString();
                textBoxNomeLeito.Text = value.NomeLeito;
                textBoxIdLeitoQuarto.Text = value.IdQuarto == 0 ? string.Empty : value.IdQuarto.ToString();
                comboBoxQuarto.SelectedValue = value.IdQuarto;
                chkLeitoManutencao.Checked = value.IsManutencao;

                chkLeitoManutencao.Enabled = value.IsDisponibilidade == null ? false : !(bool)value.IsDisponibilidade ? false : true;
            }
        }
        public List<Leito> leitos { set { dataGridViewLeito.DataSource = value; lstObjLeito = value; } }
        public List<Quarto> Quartos {
            set
            {
                List<Quarto> lstQuarto = value;
                lstQuarto.Insert(0, new Quarto() { Id = 0, NomeQuarto = "Todos", TotalLeito = 0 });
                comboBoxQuarto.DataSource = lstQuarto;
            }
        }

        public UCQuartoLeito()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            dataGridViewQuartos.AutoGenerateColumns = false;
            dataGridViewLeito.AutoGenerateColumns = false;
        }

        bool Valida(int x)
        {
            bool y = false;

            if (x == 0)
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

                y = ret.ToList().TrueForAll(v => v);
            }

            if (x == 1)
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


                if (comboBoxQuarto.SelectedItem == null)
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


        private void UCQuartoLeito_Load(object sender, EventArgs e)
        {
            new ToolTip() { UseAnimation = true, IsBalloon = false, }.SetToolTip(buttonLimpar, "Limpar Pesquisa");
            new ToolTip() { UseAnimation = true, IsBalloon = false, }.SetToolTip(button1, "Limpar Pesquisa");
            

            comboBoxQuarto.SelectedIndexChanged -= comboBoxQuarto_SelectedIndexChanged;
            comboBoxPesquisaQuarto.SelectedIndexChanged -= comboBoxPesquisaQuarto_SelectedIndexChanged;
            FrmMain.mySalvar.Click += MySalvar_Click;
            FrmMain.myNovo.Click += MyNovo_Click;
            presenterQuarto = new QuartoPresenter(this);
            presenterQuarto.Carregar();

            presenterLeito = new LeitoPresenter(this);
            presenterLeito.Carregar();
            comboBoxQuarto.SelectedIndexChanged += comboBoxQuarto_SelectedIndexChanged;
            comboBoxPesquisaQuarto.SelectedIndexChanged += comboBoxPesquisaQuarto_SelectedIndexChanged;
            PopulaOcupacoes();
            textBoxNomeQuarto.Focus();
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
                    pictureBoxLeito.Image = Properties.Resources.LeitoDisable;
                    pictureBoxLeito.Tag = l;
                    pictureBoxLeito.Text = l.NomeLeito;
                    pictureBoxLeito.Click += DesassociarLeitoPaciente;
                    toolTip.SetToolTip(pictureBoxLeito, $"{l.NomeLeito} - Leito Inidiponivel\nPaciente: {l.Nome}");
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
            obj = lstObjLeito.FirstOrDefault(p => p.Prontuario == obj.Prontuario);

            string msg = $"Tem certeza que deseja liberar o Leito {obj.NomeLeito}\nocupado pelo paciente {obj.Nome} ?";
            if (MessageBox.Show(msg, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Sessao.Dinamico = obj;
                Frm.FrmJustificativaLeito frm = new Frm.FrmJustificativaLeito();
                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    AlteracaoLeitoPaciente alteracaoLeitoPaciente = (AlteracaoLeitoPaciente)Sessao.Dinamico;
                    if (alteracaoLeitoPaciente.IdStatusAlteracao < 3) // baixa de paciente Obito | Alta
                        new PacientePresenter().BaixarPaciente(new BaixarPaciente() { Prontuario = obj.Prontuario, IdLeito = obj.Id });

                    if (alteracaoLeitoPaciente.IdStatusAlteracao == 4) // manutenção de leito
                        obj.IsManutencao = true;

                    dataGridViewLeito.DataSource = null;
                    obj.Nome = string.Empty;
                    obj.IsDisponibilidade = true;
                    obj.Prontuario = 0;
                    obj.Act = 'X';


                    presenterLeito.Salvar(obj);

                    AtualizaUserControls();
                    obj = null;
                    FindForm().BringToFront();
                }
            }
        }

        private void AtualizaUserControls()
        {
            SplitterPanel split = Parent.Parent.Controls.OfType<SplitterPanel>().LastOrDefault();
            UCListaPaciente uC = (UCListaPaciente)split.Controls[0];
            uC.Carregar();
            PopulaOcupacoes();
        }

        private void MyNovo_Click(object sender, EventArgs e)
        {
            if (tabControlQuartoLeito.SelectedTab == tabPageLeito)
            {
                Leito = new Leito();
                comboBoxQuarto.SelectedIndex = 0;
                textBoxlLeitoQtd.Text = string.Empty;
            }

            if (tabControlQuartoLeito.SelectedTab == tabPageQuartos)
            {
                QuartoLeito = new Quarto();
                comboBoxSetor.SelectedIndex = 0;
            }
        }

        private void MySalvar_Click(object sender, EventArgs e)
        {
            TabPage tab = tabControlQuartoLeito.SelectedTab;

            if (tab.Name.Equals("tabPageQuartos"))
            {
                if (Valida(0))
                {
                    presenterQuarto = new QuartoPresenter(this);
                    FrmMain.Alert(presenterQuarto.Salvar());
                    QuartoLeito = new Quarto();
                }
            }

            if (tab.Name.Equals("tabPageLeito"))
            {
                if (Valida(1))
                {
                    presenterLeito = new LeitoPresenter(this);
                    Leito = new Leito();
                    textBoxlLeitoQtd.Text = string.Empty;
                    FrmMain.Alert(presenterLeito.Salvar());
                    PopulaOcupacoes();
                }
            }

            if (tab.Name.Equals("tabPageInernacao"))
            {
                Paciente paciente = Sessao.Paciente;
                if (paciente != null)
                {
                    RadioButton radioButton = flowLayoutPanelImgLeito.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked == true);

                    if (radioButton ==  null)
                    {
                        MessageBox.Show("Selecione um Leito disponivel", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }

                    obj = (Leito)radioButton.Tag;

                    if ( obj.IsManutencao)
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

                if (e.ColumnIndex == 4)
                {
                    var sendGrid = (DataGridView)sender;
                    if (sendGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
                    {
                        Quarto obj = (Quarto)dataGridViewQuartos.Rows[e.RowIndex].DataBoundItem;
                        QuartoLeito = obj;
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
            }
            catch (SqlException exSqEx)
            {
                if (exSqEx.Number == 547)
                {
                    MessageBox.Show("Existem leitos associados para este registro\nExclua os leitos deste quarto antes de remover o quarto " + QuartoLeito.NomeQuarto, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        row.Cells[2].Value = Properties.Resources.sinalizador;
                        row.Cells[2].ToolTipText = "Leito DISPONIVEL";
                    }
                    else
                    {
                        row.Cells[2].Value = Properties.Resources.sinalizadorV1;
                        row.Cells[2].ToolTipText = "Leito INDISPONIVEL";
                    }

                    if(obj.IsManutencao)
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


        private void dataGridViewLeito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
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
            if (comboBoxQuarto.SelectedItem == null)
                return;
            Quarto item = (Quarto)comboBoxQuarto.SelectedItem;
            textBoxlLeitoQtd.Text = (item.TotalLeito - lstObjLeito?.Count(c => c.IdQuarto.Equals(item.Id))).ToString();
            textBoxTotalLeitos.Text = item.TotalLeito.ToString();
        }

        private void comboBoxPesquisaQuarto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Quarto item = (Quarto)comboBoxPesquisaQuarto.SelectedItem;
            PopulaOcupacoes(item.Id);
        }

        private void tabControlQuartoLeito_Selecting(object sender, TabControlCancelEventArgs e)
        {
            SplitterPanel split = Parent.Parent.Controls.OfType<SplitterPanel>().LastOrDefault();

            if (e.TabPageIndex != 2)
                split.Controls[0].Hide();
            else
                split.Controls[0].Show();

            if (e.TabPageIndex == 0)
                textBoxNomeQuarto.Focus();
            if (e.TabPageIndex == 1)
                textBoxNomeLeito.Focus();

        }
    }
}
