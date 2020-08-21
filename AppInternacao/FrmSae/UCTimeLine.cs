using System;
using System.Linq;
using System.Windows.Forms;

namespace AppInternacao.FrmSae
{
    public partial class UCTimeLine : UserControl
    {
        public static Button ButtonSaeAvanca;
        public UCTimeLine()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            ButtonSaeAvanca = btnStep;
        }

        int[] left = {9, 83, 158, 233, 308, 382, 456 };
        int cont = 0;
        private Control userControl;
        private SplitContainer ctrl;

        void OpnUC_Sae(int frm = 0)
        {
            //ctrl.Controls[1].Controls.RemoveAt(0);

            if (pFrmSae.Controls.Count > 0)
                pFrmSae.Controls.RemoveAt(0);

            if (frm != 0)
                lblTitulo.Visible = true;
            else
                lblTitulo.Visible = false;

            pFrmSae.Controls.Clear();
            if (frm == 0)
                userControl = new UC00BarCodeProntuario();

            if (frm == 1)
            {
                ctrl = (SplitContainer)ParentForm.Controls[0].Controls[0];
                ctrl.Controls[1].Controls.Add(new UCMenuEsquerdo());

                if (!Sessao.Usuario.Perfil.HasFlag(Enum.Perfil.Enfermeiros))
                {
                    ctrl.Panel1.Controls.Clear();
                    return;
                }

                if (Sessao.Paciente.HistoricoEnfermagem != null)
                {
                    lblTitulo.Text = "Exame Físico";
                    userControl = new UCExameFisico();

                }
                else
                {
                    lblTitulo.Text = "Histórico de Enfermagem";
                    userControl = new UC01HistoricoEnfermagem();
                }
            }

            if (frm == 2)
            {
                lblTitulo.Text = "Diagnostico de Enfermagem";
                userControl = new UC02DiagnosticoEnfermagem();
            }

            if (frm == 3)
            {
                lblTitulo.Text = "Planejamento de Enfermagem";
                userControl = new UC03PrescricaoEnfermagem();
            }

            if (frm == 4)
            {
                lblTitulo.Text = "Prescrição de Enfermagem";
                userControl = new UC04EvolucaoEnfermagem();
            }

            if (frm == 5)
            {
                lblTitulo.Text = "Avaliação de Enfermagem";
                userControl = new UC05AvaliacaoEnfermagem();
            }

            pFrmSae.Controls.Add(userControl);
        }

        private void btnStep_Click(object sender, EventArgs e)
        {
            ctrl = (SplitContainer)ParentForm.Controls[0].Controls[0];
            ctrl.Controls[1].Controls.Clear();
            btnStep.Enabled = false;
            lblTitulo.Visible = false;
            cont++;
            pByStep.BackgroundImage = Properties.Resources.TimiLineStep;
            timerStepSae.Start();
        }

        private void timerStepSae_Tick(object sender, EventArgs e)
        {
            pByStep.Left += 3;

            if (pByStep.Left >= left[cont])
            {
                pByStep.Left = left[cont];
                timerStepSae.Stop();

                if (cont > 0)
                    btnStepVoltar.Enabled = true;

                if (pByStep.Left >= 384)
                {
                    btnStep.Enabled = false;
                    pByStep.BackgroundImage = Properties.Resources.ok_accept_15562;
                    lblTitulo.Visible = false;
                }
                else
                {
                    pByStep.BackgroundImage = Properties.Resources.infoflat_105980;
                    btnStep.Enabled = true;
                    lblTitulo.Visible = true;
                    OpnUC_Sae(cont);
                }
            }
        }

        private void btnStepVoltar_Click(object sender, EventArgs e)
        {
            btnStepVoltar.Enabled = false;
            lblTitulo.Visible = false;

            if (cont <= 5)
                pByStep.BackgroundImage = Properties.Resources.TimiLineStep;

            cont--;
            timerStepBack.Start();
        }

        private void timerStepBack_Tick(object sender, EventArgs e)
        {
            pByStep.Left -= 3;

            if (pByStep.Left <= left[cont])
            {
                pByStep.Left = left[cont];
                timerStepBack.Stop();

                if (cont < 5)
                    btnStep.Enabled = true;

                if (pByStep.Left <= 10)
                {
                    btnStepVoltar.Enabled = false;
                    lblTitulo.Visible = false;
                }
                else
                    btnStepVoltar.Enabled = true;

                pByStep.BackgroundImage = Properties.Resources.infoflat_105980;
                OpnUC_Sae(cont);
            }
        }

        private void UCTimeLine_Load(object sender, EventArgs e)
        {
            OpnUC_Sae();
        }
    }
}
