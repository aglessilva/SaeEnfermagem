using AppInternacao.Model;
using AppInternacao.Presenter;
using AppInternacao.View;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace AppInternacao.FrmSae
{
    public partial class UI004FrmPanelQuarto :UI000FrmTemplate, IQuarto
    {
        public UI004FrmPanelQuarto()
        {
            InitializeComponent();
            dataGridViewQuartos.AutoGenerateColumns = false;
        }

        QuartoPresenter presenterQuarto = null;

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


        private bool Valida()
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

            return ret.ToList().TrueForAll(v => v);
        }
        
        private void UI004PanelQuarto_Load(object sender, EventArgs e)
        {
            try
            {
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

                new ToolTip() { UseAnimation = true, IsBalloon = false, }.SetToolTip(buttonLimpar, "Limpar Pesquisa");
                dataGridViewQuartos.RowEnter -= dataGridViewQuartos_RowEnter;
                comboBoxQtdLeitos.SelectedIndexChanged -= comboBoxQtdLeitos_SelectedIndexChanged;
                comboBoxSetor.SelectedIndexChanged -= comboBoxSetor_SelectedIndexChanged;

                presenterQuarto = new QuartoPresenter(this);
                presenterQuarto.Carregar();
                textBoxNomeQuarto.Focus();

                comboBoxSetor.SelectedIndexChanged += comboBoxSetor_SelectedIndexChanged;
                comboBoxQtdLeitos.SelectedIndexChanged += comboBoxQtdLeitos_SelectedIndexChanged;
                dataGridViewQuartos.RowEnter += dataGridViewQuartos_RowEnter;
               

            }
            catch (Exception exLoad)
            {
                FrmMain.Alert(exception: exLoad);
            }
        }

        private void MySalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Valida())
                {
                    presenterQuarto = new QuartoPresenter(this);

                    if (presenterQuarto.Salvar() == 1)
                        FrmMain.Alert(Enum.Alerts.InsertSuccess);

                    Quarto = new Quarto();
                }
            }
            catch (Exception exSalvar)
            {
                FrmMain.Alert(exception: exSalvar);
            }
        }

        private void MyNovo_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception exNovo)
            {
                FrmMain.Alert(exception: exNovo);
            }
        }

        private void UI004PanelQuarto_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain.mySalvar.Click -= MySalvar_Click;
            FrmMain.myNovo.Click -= MyNovo_Click;
        }

        private void dataGridViewQuartos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                comboBoxSetor.SelectedIndexChanged -= comboBoxSetor_SelectedIndexChanged;
                comboBoxQtdLeitos.SelectedIndexChanged -= comboBoxQtdLeitos_SelectedIndexChanged;
                var sendGrid = (DataGridView)sender;
                Quarto = (Quarto)dataGridViewQuartos.Rows[e.RowIndex].DataBoundItem;

                comboBoxSetor.SelectedIndexChanged += comboBoxSetor_SelectedIndexChanged;
                comboBoxQtdLeitos.SelectedIndexChanged += comboBoxQtdLeitos_SelectedIndexChanged;
                FrmMain.mySalvar.Enabled = true;
                comboBoxQtdLeitos.Enabled = Quarto.IdSetor != 9; ;
            }
            catch (Exception exRowEnter)
            {
                FrmMain.Alert(exception: exRowEnter);
            }
        }
      
        private void dataGridViewQuartos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            MyNovo_Click(null, null);
        }

        private void dataGridViewQuartos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                comboBoxSetor.SelectedIndexChanged -= comboBoxSetor_SelectedIndexChanged;
                var sendGrid = (DataGridView)sender;
                var ob = (Quarto)dataGridViewQuartos.Rows[e.RowIndex].DataBoundItem;

                comboBoxQtdLeitos.Enabled = ob.IdSetor != 9;

                if (sendGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
                {
                    if (e.ColumnIndex == 5)
                    {
                        if (MessageBox.Show($"Deseja excluir o quarto {ob.NomeQuarto} ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            presenterQuarto = new QuartoPresenter(this);

                            if (presenterQuarto.Excluir(ob.Id) == 1)
                                FrmMain.Alert(Enum.Alerts.DeleteSuccess);
                        }
                    }
                }
                comboBoxSetor.SelectedIndexChanged += comboBoxSetor_SelectedIndexChanged;
            }
            catch (SqlException exSqEx)
            {
                if (exSqEx.Number == 547)
                {
                    MessageBox.Show("Existem leitos associados a este quarto\nPara Remover esse quarto, é necessário excluir primeiramente os leitos associado ao quarto " + Quarto.NomeQuarto, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro: " + ex.Message);
            }
        }

        private void comboBoxSetor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Setor item = (Setor)comboBoxSetor.SelectedItem;

                if (item.Id == 9)
                {
                    MessageBox.Show($"Para o tipo de quarto selecionado, é permitido apenas 1 leito por apartamento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboBoxQtdLeitos.Enabled = false;
                    return;
                }
                else
                {
                    FrmMain.mySalvar.Enabled = true;
                    comboBoxQtdLeitos.Enabled = true;
                }
               
            }
            catch (Exception exComboSetor)
            {
                FrmMain.Alert(exception: exComboSetor);
            }
        }

        private void comboBoxQtdLeitos_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  var _total = lstObjLeito.Count(s => s.IdQuarto == Quarto.Id);

            if (0 > Convert.ToInt32(comboBoxQtdLeitos.SelectedItem))
            {
                MessageBox.Show("A quantidade de leitos selecionado é menor que a quantidade de leitos já cadastrado para este quarto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FrmMain.mySalvar.Enabled = false;
            }
            else
                FrmMain.mySalvar.Enabled = true;


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

    }
}
