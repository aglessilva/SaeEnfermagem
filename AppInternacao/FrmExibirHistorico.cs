using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppInternacao
{
    public partial class FrmExibirHistorico : Form
    {
        public FrmExibirHistorico()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBoxExExibirHistorico.Rtf = Sessao.Paciente.HistoricoEnfermagem;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
    }
}
