using AppInternacao.Model;
using AppInternacao.Presenter;
using AppInternacao.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace AppInternacao.FrmSae
{
    public partial class UC01HistoricoEnfermagem : UserControl, IHistoricoEnfermagem
    {
        HistoricoEnfermagemPresenter historicoEnfermagemPresenter = null;
        bool isNewHistoricoEnfermagem = false;
        int totalLength = 0;

        public HistoricoEnfermagem historicoEnfermagem
        {
            get => new HistoricoEnfermagem()
            {
                Historico = richTextBoxExHistoricoEnfermagem.Rtf,
                IdPaciente = Sessao.Paciente.Id
            };
          
        }

        public List<HistoricoEnfermagem> historicoEnfermagems
        {
            set
            {
                if (value.Count == 0)
                {
                    OpenTemplateHistoricoEnfermagem();
                }
                else
                {
                    if (value.Count > 1)
                        richTextBoxExHistoricoEnfermagem.Rtf = value[value.Count - 1].Historico;
                    else
                        richTextBoxExHistoricoEnfermagem.Rtf = value[0].Historico;
                }

                totalLength = richTextBoxExHistoricoEnfermagem.Text.Length;
            }
        }

        // public static Button ButtonSalvarEnfermagem;
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
                    richTextBoxExHistoricoEnfermagem.Rtf = reader.ReadToEnd();
                }

            }
            catch (Exception exRTF)
            {
                MessageBox.Show($"Erro ao tentar Abrir o template de Historico de enfermagem\n{exRTF.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UCHistoricoEnfermagem_Load(object sender, EventArgs e)
        {
            UCTimeLine.ButtonSaeAvanca.Click += new EventHandler(ButtonSaeAvanca_Click);
            Iniciar();
        }

        private void ButtonSaeAvanca_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isNewHistoricoEnfermagem)
                {
                    if(string.IsNullOrWhiteSpace(richTextBoxExHistoricoEnfermagem.Tag.ToString()))
                        if (richTextBoxExHistoricoEnfermagem.Text.Length != totalLength)
                        {
                            string msg = "Foi identificado alterações neste registro\nDeseja salvar como um novo Histórico de Enfermagem e manter as informações anteriores?";
                            if (MessageBox.Show(msg, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                historicoEnfermagemPresenter = new HistoricoEnfermagemPresenter(this);
                                historicoEnfermagemPresenter.Salvar();
                            }
                        }
                }
                else
                {
                    historicoEnfermagemPresenter = new HistoricoEnfermagemPresenter(this);
                    historicoEnfermagemPresenter.Salvar();
                }
            }
            catch (Exception exHistorico)
            {
                new Exception("Erro ao inserir historico de Enfermagem\n" + exHistorico.Message);
            }
            Dispose(true);
        }

        void Iniciar()
        {
            try
            {
                historicoEnfermagemPresenter = new HistoricoEnfermagemPresenter(this);
                historicoEnfermagemPresenter.GetHistoricoEnfermagem();
            }
            catch (Exception exIniciar)
            {
                new Exception("Erro ao iniciar Historico de enfermagem\n" + exIniciar.Message);
            }
        }
    }
}
