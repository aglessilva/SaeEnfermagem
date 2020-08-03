using System;
using System.Windows.Forms;

namespace AppInternacao.FrmSae
{
    public partial class UCExibirHistorico : UserControl
    {
        public UCExibirHistorico()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void btnExibirHistorico_Click(object sender, EventArgs e)
        {
            new FrmExibirHistorico().ShowDialog();
        }
    }
}
