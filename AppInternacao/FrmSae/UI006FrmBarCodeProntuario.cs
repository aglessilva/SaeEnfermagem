using AppInternacao.Enum;
using AppInternacao.Presenter;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AppInternacao.FrmSae
{
    public partial class UI006FrmBarCodeProntuario : UI000FrmTemplate
    {
        private Form frm = null;
        public UI006FrmBarCodeProntuario(Form _form)
        {
            InitializeComponent();
            frm = _form;
            Sessao.Paciente = null;
        }

        PacientePresenter PacientePresenter = null;

        private void textBoxProntuario_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxProntuario.Text))
                    return;

                if (!Regex.IsMatch(textBoxProntuario.Text, @"(^\d{1,12}$)"))
                {
                    MessageBox.Show($"Neste campo é permitido somente caracteres numéricos\nDados inconsistentes: {textBoxProntuario.Text}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    textBoxProntuario.Text = string.Empty;
                    textBoxProntuario.Focus();
                    return;
                }

                textBoxProntuario.Text = Regex.Replace(textBoxProntuario.Text.Trim(), @"[^0-9$]", string.Empty);

                if (textBoxProntuario.Text.Length == 12)
                {
                    int setorSae = frm.Tag == null ? 0 : (int)frm.Tag;

                    PacientePresenter = new PacientePresenter();
                    PacientePresenter.SessaoPaciente(Convert.ToInt64(textBoxProntuario.Text), setorSae);

                    pbOk.Visible = Sessao.Paciente.Id > 0;

                    if (Sessao.Paciente.Id > 0)
                    {
                        if ((StatusInternacao.Alta | StatusInternacao.Obito | StatusInternacao.TransferenciaExterna).HasFlag(Sessao.Paciente.Status))
                        {
                            gDadosPaciente.Visible = lblNaoLocaizado.Visible = pbOk.Visible = lblObs.Visible = false;
                            MessageBox.Show($"Foi dado baixa no paciente: {Sessao.Paciente.Nome} o mesmo já não ocupa nenhum Leito e não está disponível para a SAE.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }


                        if (string.IsNullOrWhiteSpace(Sessao.Paciente.NomeLeito))
                        {
                            lblObs.Visible = true;
                            lblObs.Text = "PARA CONTINUAR É NECESSÁRIO ASSOCIAR O PACIENTE À UM LEITO";
                        }

                        lblObs.Visible = string.IsNullOrWhiteSpace(Sessao.Paciente.NomeLeito);
                        btnEnviarCodigoBarra.Enabled = !lblObs.Visible;
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
                        lblObs.Visible = !string.IsNullOrWhiteSpace(Sessao.Paciente.NomeLeito);
                        gDadosPaciente.Visible = false;
                        lblNaoLocaizado.Visible = true;
                        pbOk.Image = Properties.Resources.Childish_Cross_24996;
                        lblNaoLocaizado.Text = "Prontuário do paciente não localizado!";
                    }

                    if (Sessao.Paciente.SaeStatus.HasSae.GetValueOrDefault())
                    {
                        string msg = $"Já existe um SAE em andamento para este paciente, criado na data {DateTime.Now.ToShortDateString()} registrado em outro setor.";      
                        MessageBox.Show(msg, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnEnviarCodigoBarra.Enabled = false;
                        Sessao.Paciente.SaeStatus.HasSae = null;
                    }
                }
                else
                {
                    btnEnviarCodigoBarra.Enabled = textBoxProntuario.Text.Length == 12;
                    btnLimpar_Click(null, null);
                }

            }
            catch (Exception exL)
            {
                MessageBox.Show("Erro na identificação do codigo de barras do paciente\n" + exL.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            gDadosPaciente.Visible = lblNaoLocaizado.Visible = pbOk.Visible = lblObs.Visible = false;
            if (!(sender is null))
                textBoxProntuario.Text = string.Empty;
            btnEnviarCodigoBarra.Enabled = false;
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

            if (frm.Name.Equals("UI007FrmMenuDireito"))
            {
                ctrl.Panel2Collapsed = false;
                Dispose(true);
                ctrl.Controls[1].Controls.Add(frm);
            }
            
            if (frm.Name.Equals("UI011FrmTimeLine"))
            {
                ctrl.Panel2Collapsed = true;
                ctrl.Controls[0].Controls.Add(frm);
            }

            this.Close();
            frm.Show();
        }

        private void UI006FrmBarCodeProntuario_Load(object sender, EventArgs e)
        {
#if DEBUG
            textBoxProntuario.Text = "562021443327";
#endif
            textBoxProntuario.Focus();
        }
    }
}
