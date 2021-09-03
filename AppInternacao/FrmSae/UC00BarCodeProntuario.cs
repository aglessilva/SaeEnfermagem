using AppInternacao.Enum;
using AppInternacao.Presenter;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AppInternacao.FrmSae
{
    public partial class UC00BarCodeProntuario : UserControl
    {
        bool isMedico = false;
        public UC00BarCodeProntuario(bool _isMedico = false)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            isMedico = _isMedico;
        }

        PacientePresenter PacientePresenter = null;

        private void UCBarCodeProntuario_Load(object sender, EventArgs e)
        {
            textBoxProntuario.Focus();
            if (!isMedico)
                UCTimeLine.ButtonSaeAvanca.Enabled = false;
        }

        private void textBoxProntuario_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxProntuario.Text))
                    return;

                if(!Regex.IsMatch(textBoxProntuario.Text, @"(^\d{1,18}$)"))
                {
                    MessageBox.Show($"Neste campo é permitido somente caracteres numéricos\nDados inconsistentes: {textBoxProntuario.Text}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    textBoxProntuario.Text = string.Empty;
                    textBoxProntuario.Focus();
                    return;
                }

                textBoxProntuario.Text = Regex.Replace(textBoxProntuario.Text.Trim(), @"[^0-9$]", string.Empty);

                if (textBoxProntuario.Text.Length == 18)
                {
                    PacientePresenter = new PacientePresenter();
                    PacientePresenter.SessaoPaciente(Convert.ToInt64(textBoxProntuario.Text));

                    pbOk.Visible = true;

                    if (!(StatusInternacao.Alta | StatusInternacao.Obito).HasFlag(Sessao.Paciente.Status))
                    {
                        gDadosPaciente.Visible = lblNaoLocaizado.Visible = pbOk.Visible = lblObs.Visible = false;
                        MessageBox.Show($"Foi dado baixa no paciente: {Sessao.Paciente.Nome} o mesmo já não ocupa nenhum Leito e não está disponível para a SAE.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }


                    if (string.IsNullOrWhiteSpace(Sessao.Paciente.NomeLeito))
                    {
                        lblObs.Visible = true;
                        lblObs.Text = "PARA CONTINUAR É NECESSÁRIO ASSOCIAR O PACIENTE À UM LEITO";
                        if (!isMedico)
                            UCTimeLine.ButtonSaeAvanca.Enabled = false;
                    }

                    if (Sessao.Paciente.Id > 0)
                    {
                        lblObs.Visible = string.IsNullOrWhiteSpace(Sessao.Paciente.NomeLeito);
                        if (!isMedico)
                            UCTimeLine.ButtonSaeAvanca.Enabled = !lblObs.Visible;
                        btnEnviarCodigoBarra.Visible = (isMedico && !lblObs.Visible);
                        gDadosPaciente.Visible = true;
                        lblNaoLocaizado.Visible = false;
                        pbOk.Image = Properties.Resources.ok_accept_15562;
                        lblNome.Text = Sessao.Paciente.Nome;
                        lblLeito.Text = string.IsNullOrWhiteSpace(Sessao.Paciente.NomeLeito) ? "PACIENTE SEM LEITO" : Sessao.Paciente.NomeLeito;
                        lblProntuario.Text = Sessao.Paciente.Prontuario.ToString();
                        lblIdade.Text = Sessao.Paciente.Idade.ToString();

                    }
                    else
                    {
                        if (!isMedico)
                            lblObs.Visible = UCTimeLine.ButtonSaeAvanca.Enabled = !string.IsNullOrWhiteSpace(Sessao.Paciente.NomeLeito);
                        gDadosPaciente.Visible = false;
                        lblNaoLocaizado.Visible = true;
                        pbOk.Image = Properties.Resources.Childish_Cross_24996;
                        lblNaoLocaizado.Text = "Prontuário do paciente não localizado!";
                    }
                }
                else
                   btnEnviarCodigoBarra.Visible = textBoxProntuario.Text.Length == 18; 

            }
            catch (Exception exL)
            {
                MessageBox.Show("Erro na identificação do codigo de barras do paciente\n" + exL.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            gDadosPaciente.Visible = lblNaoLocaizado.Visible = pbOk.Visible = lblObs.Visible = false;
            textBoxProntuario.Text = string.Empty;
            textBoxProntuario.Focus();
        }

        private void textBoxProntuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                e.Handled = true;
        }

        private void btnEnviarCodigoBarra_Click(object sender, EventArgs e)
        {
            SplitContainer ctrl = (SplitContainer)Parent.Parent;
            Dispose(true);
            ctrl.Controls[1].Controls.Add(new UCMenuEsquerdo());
        }
    }
}
