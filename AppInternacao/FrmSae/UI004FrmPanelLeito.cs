using AppInternacao.Model;
using AppInternacao.Presenter;
using AppInternacao.View;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AppInternacao.FrmSae
{
    public partial class UI004FrmPanelLeito : UI000FrmTemplate, ILeito
    {
        public UI004FrmPanelLeito()
        {
            InitializeComponent();
            dataGridViewLeito.AutoGenerateColumns = false;
        }
        LeitoPresenter presenterLeito = null;

        public Leito Leito
        {
            get => new Leito()
            {
                Id = string.IsNullOrWhiteSpace(textBoxIdLeito.Text) ? 0 : Convert.ToInt32(textBoxIdLeito.Text),
                IdQuarto = comboBoxQuarto.SelectedItem == null ? 0 : Convert.ToInt32(comboBoxQuarto.SelectedValue),
                NomeLeito = textBoxNomeLeito.Text,
                IsManutencao = chkLeitoManutencao.Checked,
                IsDisponibilidade = textBoxIdLeito.Text.Equals("0")
            };
            set
            {
                textBoxIdLeito.Text = value.Id.ToString();
                textBoxNomeLeito.Text = value.NomeLeito;
                chkLeitoManutencao.Checked = value.IsManutencao;
                comboBoxQuarto.SelectedValue = value.IdQuarto;
                chkLeitoManutencao.Enabled = value.IsDisponibilidade;
            }
        }
        public List<Leito> Leitos { set  { dataGridViewLeito.DataSource = value; } }
        public List<Quarto> Quartos
        {
            set
            {
              
                comboBoxQuarto.DataSource = null;
                List<Quarto> lstQuartoCombo = value;
                lstQuartoCombo.Insert(0, new Quarto() { Id = 0, IdSetor = 0, NomeQuarto = "Todos" });
                comboBoxQuarto.DataSource = lstQuartoCombo;
            }
        }

        private void UI004PanelLeito_Load(object sender, EventArgs e)
        {
            comboBoxQuarto.SelectedIndexChanged -= comboBoxQuarto_SelectedIndexChanged;
            dataGridViewLeito.RowEnter -= dataGridViewLeito_RowEnter;

            FrmMain.listButtons.ForEach(b =>
            {
                if (b.Name.Equals("btnNovo"))
                {
                    b.Visible = b.Enabled = true;
                    b.IconChar = IconChar.FileAlt;
                    b.IconColor = System.Drawing.Color.Yellow;
                    b.Click += MyNovo_Click;
                    b.Width = 73;
                    b.Text = "Novo".Trim();
                }

                if (b.Name.Equals("btnSalvar"))
                {
                    b.Visible = b.Enabled = true;
                    b.IconChar = IconChar.Save;
                    b.Click += MySalvar_Click;
                    b.Width = 80;
                    b.Text = "Salvar".Trim();
                }
            });

            presenterLeito = new LeitoPresenter(this);
            presenterLeito.GetQuartos();
            presenterLeito.Carregar();

            dataGridViewLeito.RowEnter += dataGridViewLeito_RowEnter;
            comboBoxQuarto.SelectedIndexChanged += comboBoxQuarto_SelectedIndexChanged;
        }

        private void UI004FrmPanelLeito_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain.mySalvar.Click -= MySalvar_Click;
            FrmMain.myNovo.Click -= MyNovo_Click;
        }

        private void MyNovo_Click(object sender, EventArgs e)
        {
            if (sender != null)
            {
                errorProvider1.SetError(comboBoxQuarto, null);
                errorProvider1.SetError(textBoxNomeLeito, null);
                dataGridViewLeito.ClearSelection();
                Leito = new Leito();
                textBoxNomeLeito.Focus();
            }
            else
            {
                Leito = new Leito();
                dataGridViewLeito.ClearSelection();
            }
        }

        private void MySalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Valida())
                {
                    Quarto quarto = (Quarto)comboBoxQuarto.SelectedItem;
                    int _total = CountGrid(quarto.Id);

                    if (_total >= quarto.TotalLeito)
                    {
                        MessageBox.Show($"A quantidade de leitos disponiveis para o quarto {quarto.NomeQuarto}, já foram cadastrados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    presenterLeito = new LeitoPresenter(this);
                    MyNovo_Click(sender, e);

                    if (presenterLeito.Salvar() == 1)
                        FrmMain.Alert(Enum.Alerts.InsertSuccess);
                }
            }
            catch (Exception exSalvar)
            {
                FrmMain.Alert(exception: exSalvar);
            }
        }

        private bool Valida()
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

            return ret.ToList().TrueForAll(v => v);
        }

        private int CountGrid(int id)
        {
            int countItem = 0;
            Leito _leito = null;
            foreach (DataGridViewRow item in dataGridViewLeito.Rows)
            {
                _leito = (Leito)item.DataBoundItem;
                countItem += Convert.ToInt32(_leito.IdQuarto == id);  
            } 
            return countItem;
        }

        private void comboBoxQuarto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               // chkLeitoManutencao.Checked = false;
                dataGridViewLeito.RowEnter -= dataGridViewLeito_RowEnter;

                if (comboBoxQuarto.SelectedItem == null || comboBoxQuarto.SelectedIndex == 0)
                    lblTotalLeitos.Visible = false;
                else
                {
                    Quarto item = (Quarto)comboBoxQuarto.SelectedItem;
                   
                    lblTotalLeitos.Text = dataGridViewLeito.RowCount == 0 ? $"Quarto com {item.TotalLeito} vaga(s) para cadastro de leito(s)" : $"Quarto com {item.TotalLeito} leito(s) e {(item.TotalLeito - CountGrid(item.Id))} {(item.TotalLeito - CountGrid(item.Id) > 1 ? "vagas disponiveis" : "vaga disponivel")} para cadastro";
                    lblTotalLeitos.Visible = (item.TotalLeito - dataGridViewLeito.RowCount) != 0;
                }

                dataGridViewLeito.RowEnter += dataGridViewLeito_RowEnter;
            }
            catch (Exception exComboQuarto)
            {
                FrmMain.Alert(exception: exComboQuarto);
            }
        }

        private void dataGridViewLeito_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

               var sendGrid = (DataGridView)sender;
               Leito = (Leito)sendGrid.Rows[e.RowIndex].DataBoundItem;

            }
            catch (Exception exRowEnter)
            {
                FrmMain.Alert(exception: exRowEnter);
            }

        }

        private void dataGridViewLeito_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            MyNovo_Click(null, null);

        }

        private void dataGridViewLeito_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {

                var senderGrid = (DataGridView)sender;
                foreach (DataGridViewRow row in senderGrid.Rows)
                {
                    if (row.Index < e.RowIndex)
                        continue;
                    var obj = (Leito)row.DataBoundItem;

                    if ((bool)obj.IsDisponibilidade)
                    {
                        row.Cells[2].Value = Properties.Resources.sinalizadorVer;
                        row.Cells[2].ToolTipText = "Leito DISPONIVEL";
                    }
                    else
                    {
                        row.Cells[2].Value = Properties.Resources.sinalizadorV1;
                        row.Cells[2].ToolTipText = "Leito INDISPONIVEL";
                        row.Cells[4].Value = Properties.Resources.liberar;
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

        private void dataGridViewLeito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 4)
                {
                    var sendGrid = (DataGridView)sender;
                    if (sendGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
                    {
                        var obj = (Leito)dataGridViewLeito.Rows[e.RowIndex].DataBoundItem;

                        if (!obj.IsDisponibilidade)
                            return;

                        if (MessageBox.Show($"Deseja excluir o Leito {obj.NomeLeito} ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Leito = obj;
                            presenterLeito = new LeitoPresenter(this);
                            Leito = new Leito();
                            if (presenterLeito.Excluir() == 1)
                                FrmMain.Alert(Enum.Alerts.DeleteSuccess);
                        }
                    }
                }
            }
            catch (Exception exG)
            {
                throw new Exception("Erro ao tentar listar os Leitos:\n" + exG.Message);
            }
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
    }
}
