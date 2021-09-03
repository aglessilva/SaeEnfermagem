using AppInternacao.Enum;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AppInternacao.FrmSae
{
    public partial class UCMenuEsquerdo : UserControl
    {
        public UCMenuEsquerdo()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private SplitContainer ctrl;
        private void btnExibirHistorico_Click(object sender, EventArgs e)
        {
            if (Sessao.Usuario.Perfil.HasFlag(Perfil.Medico))
            {
                CloseUC();
                ctrl.Controls[0].Controls.Add(new UCViewHistoricoEnfermagem());
            }
            else
            {
                new FrmExibirHistorico().ShowDialog();
            }
        }

        private void btnPrecricaoMedica_Click(object sender, EventArgs e)
        {
            CloseUC();
            ctrl.Controls[0].Controls.Add(new  UCPrescricaoCiclo());
        }

        private void CloseUC()
        {
            if (ctrl.Panel1.Controls.Count > 0)
            {
                UserControl uc = (UserControl)ctrl.Panel1.Controls[0];
                uc.Dispose();
            }
        }

        private void UCMenuEsquerdo_Load(object sender, EventArgs e)
        {
            ctrl = (SplitContainer)ParentForm.Controls[0].Controls[0];
            lblQuarto.Text = Sessao.Paciente.NomeQuarto;
            lblLeito.Text = Sessao.Paciente.NomeLeito;
            lblUnidadeFuncional.Text = Sessao.Paciente.NomeSetor;
            lblPaciente.Text = Sessao.Paciente.Nome;
            lblIdade.Text = Sessao.Paciente.Idade.ToString();

            MemoryStream ms = new MemoryStream(Sessao.Paciente.Foto);
            pictureBoxExtFoto.Image = Image.FromStream(ms);
        }
    }
}
