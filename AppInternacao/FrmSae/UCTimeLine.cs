using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        int[] left = {10, 85, 160, 235, 310, 384 };
        int cont = 0;
        private Control userControl;

        void OpnUC_Sae(int frm = 0)
        {
            if (pFrmSae.Controls.Count > 0)
                pFrmSae.Controls.RemoveAt(0);

            pFrmSae.Controls.Clear();
            if (frm == 0)
                userControl = new UCBarCodeProntuario();
            if (frm == 1)
                userControl = new UCHistoricoEnfermagem();
            if (frm == 2)
                userControl = new UCDiagnosticoEnfermagem();
            if (frm == 3)
                userControl = new UCPrescricaoEnfermagem();
            if (frm == 4)
                userControl = new UCEvolucaoEnfermagem();

            pFrmSae.Controls.Add(userControl);
        }

        private void btnStep_Click(object sender, EventArgs e)
        {
            btnStep.Enabled = false;
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
                }
                else
                {
                    pByStep.BackgroundImage = Properties.Resources.infoflat_105980;
                   
                    OpnUC_Sae(cont);
                    btnStep.Enabled = true;
                }
            }
        }

        private void btnStepVoltar_Click(object sender, EventArgs e)
        {
            btnStepVoltar.Enabled = false;
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
                    btnStepVoltar.Enabled = false;

                pByStep.BackgroundImage = Properties.Resources.infoflat_105980;

                OpnUC_Sae(cont);
                btnStepVoltar.Enabled = true;
            }
        }

        private void UCTimeLine_Load(object sender, EventArgs e)
        {
            OpnUC_Sae();
        }
    }
}
