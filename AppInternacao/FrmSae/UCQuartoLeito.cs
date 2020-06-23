using AppInternacao.Model;
using AppInternacao.Presenter;
using AppInternacao.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace AppInternacao.FrmSae
{
    public partial class UCQuartoLeito : UserControl, IQuarto, ILeito
    {

        QuartoPresenter presenterQuarto = null;
        LeitoPresenter presenterLeito = null;
        Leito obj = null;
        private List<Leito> lstObjLeito;

        public Quarto QuartoLeito
        {
            get => new Quarto()
            {
                Id = string.IsNullOrWhiteSpace(textBoxId.Text) ?  0 :  Convert.ToInt32(textBoxId.Text),
                NomeQuarto = textBoxNomeQuarto.Text,
                IdSetor = comboBoxSetor.SelectedItem == null ? 0 : Convert.ToInt32(comboBoxSetor.SelectedValue),
                TotalLeito = comboBoxQtdLeitos.SelectedItem == null ? 0 : Convert.ToInt32(comboBoxQtdLeitos.SelectedItem)
            };
            set
            {
                textBoxId.Text = value?.Id.ToString();
                textBoxNomeQuarto.Text = value.NomeQuarto;
                comboBoxSetor.SelectedValue = value.IdSetor == 0 ? 0 : value.IdSetor ;
                comboBoxQtdLeitos.SelectedItem = value.TotalLeito > 0 ? value.TotalLeito.ToString() : "1";
            }
        }
        public List<Quarto> QuartoLeitos { set { dataGridViewQuartos.DataSource = null;  dataGridViewQuartos.DataSource = value; comboBoxQuarto.DataSource = value; } }
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
                NomeLeito = textBoxNomeLeito.Text
            };
            set {
                textBoxIdLeito.Text = value.Id.ToString();
                textBoxNomeLeito.Text = value.NomeLeito;
                comboBoxQuarto.SelectedValue = value.IdQuarto;

            }
        }
        public List<Leito> leitos { set { dataGridViewLeito.DataSource = value; lstObjLeito = value; } }
        public List<Quarto> Quartos { set { comboBoxQuarto.DataSource = value; } }

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

            if(x == 1)
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
            FrmMain.mySalvar.Click += MySalvar_Click;
            FrmMain.myNovo.Click += MyNovo_Click;
            presenterQuarto = new QuartoPresenter(this);
            presenterQuarto.Carregar();

            presenterLeito = new LeitoPresenter(this);
            presenterLeito.Carregar();
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
                }
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
               if(exSqEx.Number == 547)
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
            if (tabControlQuartoLeito.SelectedTab != tabPageLeito)
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
                throw new Exception("Erro ao tentar listar os Leitos:\n" + exG.Message );
            }
        }

        private void textBoxPesquisaQuarto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxPesquisaQuarto.Text.Length >= 3)
                {
                    presenterQuarto = new QuartoPresenter(this);
                    presenterQuarto.Carregar(new Quarto{ NomeQuarto = textBoxPesquisaQuarto.Text.Trim() });
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
    }
} 
