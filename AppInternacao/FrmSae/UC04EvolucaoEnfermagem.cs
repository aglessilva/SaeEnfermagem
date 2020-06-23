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
    public partial class UC04EvolucaoEnfermagem : UserControl
    {
        public UC04EvolucaoEnfermagem()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void UCPrescricao_Load(object sender, EventArgs e)
        {
            UCTimeLine.ButtonSaeAvanca.Click += new EventHandler(ButtonSaeAvanca_Click);
        }

        private void ButtonSaeAvanca_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }
    }
}
