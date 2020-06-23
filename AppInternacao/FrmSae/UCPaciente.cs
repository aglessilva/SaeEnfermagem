using AppInternacao.Model;
using AppInternacao.Presenter;
using AppInternacao.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AppInternacao.FrmSae
{
    public partial class UCPaciente : UserControl, IPaciente
    {
        PacientePresenter PacientePresenter = null;
        private Paciente objPeciente = null;

        public UCPaciente()
        {
            InitializeComponent();
           
        }

        public Paciente paciente {
            get => new Paciente()
                    {
                        Id = string.IsNullOrWhiteSpace(textBoxIdPaciente.Text) ? 0 : Convert.ToInt32(textBoxIdPaciente.Text),
                        Idade = string.IsNullOrWhiteSpace(textBoxIdade.Text) ? 0 : Convert.ToInt32(textBoxIdade.Text), 
                        Prontuario = string.IsNullOrWhiteSpace(textBoxProntuario.Text) ? 0 : Convert.ToInt64(textBoxProntuario.Text),
                        Sexo = radioButton1.Checked ? 'M' : 'F',
                        IdLeito = comboBoxLeito.SelectedItem == null ? Convert.ToInt32(textBoxIdLeito.Text) : Convert.ToInt32(comboBoxLeito.SelectedValue),
                        Nome =  textBoxPaciente.Text
                    };
            set
            {
                textBoxIdPaciente.Text = value.Id.ToString();
                textBoxPaciente.Text = value.Nome;
                textBoxIdade.Text = value.Idade.ToString();
                comboBoxLeito.SelectedValue = value.IdLeito;
                textBoxIdLeito.Text = value.IdLeito.ToString();
                textBoxLeitoCracha.Text = value.NomeLeito;
                textBoxProntuarioCracha.Text = textBoxProntuario.Text = value.Prontuario.ToString();

                if (Convert.ToChar(value.Sexo).Equals('M'))
                    radioButton1.Checked = true;
                else
                    radioButton2.Checked = true;
            }
        }

        public List<Paciente> pacientes { set => dataGridViewPaciente.DataSource = value; }
        public List<Leito> leitos { set => comboBoxLeito.DataSource = value; }

        private bool validaCampos()
        {
            RadioButton radioButton = null;
            try
            {
                var lista = groupBox1.Controls.OfType<TextBox>().Where(t => t is TextBox).ToList();

                foreach (TextBox item in lista)
                {
                    if (string.IsNullOrEmpty(item.Text))
                    {
                        errorProvider1.SetError(item, "preencha este campo");
                        errorProvider1.SetIconPadding(item, 3);
                    }
                    else
                        errorProvider1.SetError(item, null);
                }

                if (groupBox1.Controls.OfType<RadioButton>().Where(t => t is RadioButton).ToList().Count(c => c.Checked) == 0)
                {
                    radioButton = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(t => t is RadioButton);
                    errorProvider1.SetError(radioButton, "preencha este campo");
                    errorProvider1.SetIconPadding(radioButton,3);
                    return false;
                }
                else
                {
                    radioButton = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(t => t is RadioButton);
                    errorProvider1.SetError(radioButton, null);
                }

                return lista.TrueForAll(x => !string.IsNullOrWhiteSpace(x.Text));
            }
            catch (Exception)
            {

                throw;
            }
        }

        void GeraProntuario()
        {
            string barcode = $"{DateTime.Now.Second}{Regex.Replace(Guid.NewGuid().ToString() + DateTime.Now.ToString(), @"[^0-9$]", "")}";
            textBoxProntuario.Text = barcode.PadLeft(18, '0').Substring(0, 18);
            Zen.Barcode.Code128BarcodeDraw code128Barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pbBarcodeCracha.Image = code128Barcode.Draw(textBoxProntuario.Text, 18);
            textBoxProntuarioCracha.Text = textBoxProntuario.Text;
        }

        public void Salvar(object sender, EventArgs e)
        {
            try
            {
                if (validaCampos())
                {
                    if (paciente.Id == 0)
                        GeraProntuario();
                    //textBoxLeitoCracha.Text = comboBoxLeito.Text;
                    PacientePresenter = new PacientePresenter(this);
                    FrmMain.Alert(PacientePresenter.Salvar());
                    MyNovo_Click(null, null);
                }

            }
            catch (Exception exsalvar)
            {
                throw new Exception(exsalvar.Message);
            }

        }

        private void UCPaciente_Load(object sender, EventArgs e)
        {
            FrmMain.mySalvar.Click += new EventHandler(Salvar);
            FrmMain.myNovo.Click += MyNovo_Click;
            textBoxDataCracha.Text = DateTime.Now.ToShortDateString();
            textBoxCliente.Text = Sessao.Cliente;

            Dock = DockStyle.Fill;
            dataGridViewPaciente.AutoGenerateColumns = false;

            PacientePresenter = new PacientePresenter(this);
            PacientePresenter.Carregar();
        }

        private void MyNovo_Click(object sender, EventArgs e)
        {
            paciente = new Paciente();
            pbBarcodeCracha.Image = Properties.Resources.barcode;
        }

        private void textBoxIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), "[0-9]") && !e.KeyChar.ToString().Equals("\b"))
                e.Handled = true;
        }

        private void textBoxPaciente_TextChanged(object sender, EventArgs e)
        {
            textBoxNomeCrachar.Text = textBoxPaciente.Text;
        }

        private void textBoxIdade_TextChanged(object sender, EventArgs e)
        {
            textBoxIdadeCracha.Text = textBoxIdade.Text;
        }


        private void dataGridViewPaciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                var sendGrid = (DataGridView)sender;
                if (sendGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
                {
                    objPeciente = (Paciente)dataGridViewPaciente.Rows[e.RowIndex].DataBoundItem;

                    if ((bool)objPeciente.IsBaixado)
                        return;

                    paciente = (Paciente)dataGridViewPaciente.Rows[e.RowIndex].DataBoundItem;
                }
            }

            if (e.ColumnIndex == 8)
            {
                var sendGrid = (DataGridView)sender;
                if (sendGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
                {
                    objPeciente = (Paciente)dataGridViewPaciente.Rows[e.RowIndex].DataBoundItem;

                    if ((bool)objPeciente.IsBaixado)
                        return;

                    if (!string.IsNullOrWhiteSpace(objPeciente.NomeLeito))
                        if (MessageBox.Show($"Tem certeza que deseja dar BAIXA do leito {objPeciente.NomeLeito}\nocupado pelo paciente {objPeciente.Nome} ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            FrmMain.Alert(PacientePresenter.BaixarPaciente(objPeciente));
                }
            }

        }

        private void dataGridViewPaciente_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                var senderGrid = (DataGridView)sender;
                foreach (DataGridViewRow row in senderGrid.Rows)
                {
                    if (row.Index < e.RowIndex)
                        continue;
                    objPeciente = (Paciente)row.DataBoundItem;

                    if (string.IsNullOrWhiteSpace(objPeciente.NomeLeito))
                    {
                        if ((bool)objPeciente.IsBaixado)
                        {
                            row.Cells[8].Value = Properties.Resources.userExit;
                            row.Cells[8].ToolTipText = "Paciente liberado\ncom Baixa de Leito";
                        }
                        else
                        {
                            row.Cells[8].Value = Properties.Resources.Error_80_icon_icons_com_57326;
                            row.Cells[8].ToolTipText = "Aguardando liberação de leito";
                        }
                    }
                    else
                        row.Cells[8].ToolTipText = "Liberar Leito";
                }
            }
            catch (Exception exG)
            {
                throw new Exception("Erro ao tentar Listar pacientes: " + exG.Message);
            }
        }

        private void textBoxPesquisaPaciente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxPesquisaPaciente.Text.Length > 3)
                {
                    PacientePresenter = new PacientePresenter(this);
                    PacientePresenter.Pesquisar(new Paciente() { Nome = textBoxPesquisaPaciente.Text.Trim() });
                }
                else if (textBoxPesquisaPaciente.Text.Length == 0)
                {
                    PacientePresenter = new PacientePresenter(this);
                    PacientePresenter.Pesquisar(new Paciente());
                }
                else
                    return;
            }
            catch (Exception exPes)
            {
                throw new Exception("Ocorreu um erro na pesquisa\n" + exPes.Message);
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxPesquisaPaciente.Text = string.Empty;
        }
    }
}
