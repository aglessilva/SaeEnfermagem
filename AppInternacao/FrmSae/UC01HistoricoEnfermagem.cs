using AppInternacao.Model;
using AppInternacao.Presenter;
using System;
using System.IO;
using System.Windows.Forms;

namespace AppInternacao.FrmSae
{
    public partial class UC01HistoricoEnfermagem : UserControl
    {
        PacientePresenter pacientePresenter = null;
        public UC01HistoricoEnfermagem()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }
        void OpenTemplateHistoricoEnfermagem()
        {
            try
            {
                string originalfilename = $@"{Directory.GetCurrentDirectory()}\Template\TEMPLATE_HISTORICO_DE_ENFERMAGEM01.txt";

                using (StreamReader reader = new StreamReader(originalfilename))
                {
                    richTextBoxExHistoricoEnfermagem.Rtf = reader.ReadToEnd().Replace("#", Sessao.Paciente.Nome);
                }

            }
            catch (Exception exRTF)
            {
                MessageBox.Show($"Erro ao tentar Abrir o template de Historico de enfermagem\n{exRTF.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UCHistoricoEnfermagem_Load(object sender, EventArgs e)
        {
           // UCTimeLine.ButtonSaeAvanca.Click += new EventHandler(ButtonSaeAvanca_Click);

            if (Sessao.Paciente.HistoricoEnfermagem != null)
            {
                richTextBoxExHistoricoEnfermagem.Rtf = Sessao.Paciente.HistoricoEnfermagem;
                richTextBoxExHistoricoEnfermagem.Enabled = richTextBoxExHistoricoEnfermagem.Text.Length < 1000;
            }
            else
                OpenTemplateHistoricoEnfermagem();

           // Sessao.Paciente.HistoricoEnfermagem = null;
        }

        private void ButtonSaeAvanca_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(Sessao.Paciente.HistoricoEnfermagem))
                {
                    Sessao.Paciente.HistoricoEnfermagem = richTextBoxExHistoricoEnfermagem.Rtf;

                    if (richTextBoxExHistoricoEnfermagem.Text.Length < 500)
                    {
                        MessageBox.Show("Favor informar mais detalhes sobre o hitórico do paciente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     //   UCTimeLine.ButtonSaeAvanca.Enabled = false;
                    }
                    else
                    {
                        pacientePresenter = new PacientePresenter();
                        Paciente paciente = Sessao.Paciente;

                        paciente.NomeLeito = null;
                        paciente.NomeQuarto = null;
                        paciente.NomeSetor = null;

                        int ret = pacientePresenter.Salvar(paciente);
                    }
                }
               
            }
            catch (Exception exHistorico)
            {
                MessageBox.Show("Erro ao inserir historico de Enfermagem\n" + exHistorico.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Dispose(true);
        }

        private void btnTemplate_Click(object sender, EventArgs e)
        {
            string msg = "Essa operação irá substituir o conteúdo da caixa de texto por um template pré formatado!\nDeseja seguir com essa operação?";
            if (MessageBox.Show(msg, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                OpenTemplateHistoricoEnfermagem();
        }

        private void richTextBoxExHistoricoEnfermagem_Load(object sender, EventArgs e)
        {

        }
    }
}
