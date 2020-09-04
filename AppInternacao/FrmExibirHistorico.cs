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
            Dock = DockStyle.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string msg = "Ainda não existe hitórico de enfermagem registrado para este paciente!";
            if (Sessao.Paciente.HistoricoEnfermagem == null)
                richTextBoxExExibirHistorico.Text = msg;
            else
                richTextBoxExExibirHistorico.Rtf = Sessao.Paciente.HistoricoEnfermagem;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }
    }
}
