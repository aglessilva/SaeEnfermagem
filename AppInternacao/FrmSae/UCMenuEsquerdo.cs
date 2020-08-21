using System;
using System.Collections.Generic;
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
            new FrmExibirHistorico().ShowDialog();
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
        }
    }
}
