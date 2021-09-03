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
    public partial class UCViewHistoricoEnfermagem : UserControl
    {
      //  UserControl userControl = null;
        public UCViewHistoricoEnfermagem()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
          
        }

        private void richTextBoxExExibirHistorico_Load(object sender, EventArgs e)
        {
            richTextBoxExExibirHistorico.Rtf = Sessao.Paciente.HistoricoEnfermagem;
        }
    }
}
