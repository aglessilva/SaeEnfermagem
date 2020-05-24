using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppInternacao.Model;
using AppInternacao.Presenter;
using AppInternacao.View;

namespace AppInternacao.FrmSae
{
    public partial class UCBarCodeProntuario : UserControl
    {
        public UCBarCodeProntuario()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
           
        }

        PacientePresenter PacientePresenter = null;

        private void UCBarCodeProntuario_Load(object sender, EventArgs e)
        {
            textBoxProntuario.Focus();
            UCTimeLine.ButtonSaeAvanca.Enabled = false;
        }

        private void textBoxProntuario_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxProntuario.Text.Length == 18)
                {
                    PacientePresenter = new PacientePresenter();
                    PacientePresenter.SessaoPaciente(Convert.ToInt64(textBoxProntuario.Text));

                    pbOk.Visible = true;

                    if(Sessao.Paciente.IsBaixado.HasValue)
                        if((bool)Sessao.Paciente.IsBaixado)
                        {
                            gDadosPaciente.Visible = lblNaoLocaizado.Visible = pbOk.Visible = lblObs.Visible = false;
                            MessageBox.Show($"Foi dado baixa no paciente: {Sessao.Paciente.Nome} o mesmo já não ocupa nenhum Leito e não está disponível para a SAE.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }

                    
                    if(string.IsNullOrWhiteSpace(Sessao.Paciente.NomeLeito))
                    {
                        lblObs.Visible = true;
                        lblObs.Text = "PARA CONTINUAR É NECESSÁRIO ASSOCIAR O PACIENTE À UM LEITO";
                        UCTimeLine.ButtonSaeAvanca.Enabled = false;
                    }

                    if (Sessao.Paciente.Id > 0)
                    {
                        lblObs.Visible = string.IsNullOrWhiteSpace(Sessao.Paciente.NomeLeito);
                        UCTimeLine.ButtonSaeAvanca.Enabled = !lblObs.Visible;
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
                        lblObs.Visible = UCTimeLine.ButtonSaeAvanca.Enabled = !string.IsNullOrWhiteSpace(Sessao.Paciente.NomeLeito);
                        gDadosPaciente.Visible = false;
                        lblNaoLocaizado.Visible = true;
                        pbOk.Image = Properties.Resources.Childish_Cross_24996;
                        lblNaoLocaizado.Text = "Prontuário do paciente não localizado!";
                    }
                }
            }
            catch (Exception exL)
            {
                throw exL;
            }
           
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBoxProntuario.Text = string.Empty;
            gDadosPaciente.Visible = lblNaoLocaizado.Visible = pbOk.Visible = lblObs.Visible = false;
        }
    }
}
