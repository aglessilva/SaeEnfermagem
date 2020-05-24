using AppInternacao.Model;
using AppInternacao.Presenter;
using AppInternacao.View;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AppInternacao
{
    public partial class FrmMain : Form, IMain
    {
        UserControl userControl = null;
        PresenterMain Presenter = null;

        private bool isCollapsed = true;
        public static Button mySalvar;
        public static Button myNovo;

        public Main Main { get => new Main() { Dominio = Environment.UserDomainName };
            set
            {
                Sessao.CodigoCliente = value.IdCliente;
                Sessao.Cliente = value.Cliente;
                Sessao.DataValidade = (DateTime)value.DataValidade;
                Sessao.IsAtivo = (bool)value.IsAtivo;
            }
        }

        public FrmMain()
        {
            InitializeComponent();
            mySalvar = btnSalvar;
            myNovo = btnNovo;

            new ToolTip().SetToolTip(btnSair, "Fechar Formulário / Sair");
        }


        private void OpenUc()
        {
            panelMenu.Controls.OfType<Button>().ToList().ForEach(n => { n.Enabled = false; });
            panelButtons.Controls.OfType<Button>().ToList().ForEach(n => { n.Enabled = false; });
            panelDropDown.Controls.OfType<Button>().ToList().ForEach(n => { n.Enabled = false; });

            splitContainer1.Panel1.Controls.Clear();
            if (!splitContainer1.Panel1.Controls.OfType<Control>().Any(f => f is UserControl))
            {
                splitContainer1.Panel1.Controls.Add(userControl);
            }
        }


        private void btnCMAdulto_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            panelMenu.Controls.OfType<Button>().ToList().ForEach(n => { n.Enabled = true; });
            panelButtons.Controls.OfType<Button>().ToList().ForEach(n => { n.Enabled = true; });
            panelDropDown.Controls.OfType<Button>().ToList().ForEach(n => { n.Enabled = true; });
            if (splitContainer1.Panel1.Controls.Count == 0)
            {
                Application.Exit();
                return;
            }

            Control control = splitContainer1.Panel1.Controls[0];
            control.Dispose();
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            userControl = new FrmSae.UCPaciente();
            OpenUc();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                Presenter = new PresenterMain(this);
                Presenter.Iniciar();
                dataGridViewPaciente.AutoGenerateColumns = false;
            }
            catch (Exception exM)
            {
                Alert(0,exM);
            }
        }

        private void textPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (textPesquisa.Text.Length >= 5)
            {
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textPesquisa.Text = string.Empty;
            dataGridViewPaciente.DataSource = null;
        }

        private void btnGerenciamentoLeito_Click(object sender, EventArgs e)
        {
            userControl = new FrmSae.UCQuartoLeito();
            OpenUc();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl = new FrmSae.UCTimeLine();
            OpenUc();
        }

        public static void Alert(int? tipo, Exception exception = null)
        {
            switch (tipo)
            {
                case 1:
                    {
                        MessageBox.Show("Dados registrado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case 2:
                    {
                        MessageBox.Show("Registro excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                case 3:
                    {
                        MessageBox.Show("Registro não localizado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    }
                case 4:
                    {
                        MessageBox.Show("Informação já cadastrada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        break;
                    }
                default:
                    MessageBox.Show($"ocorreu um erro\n{exception.Message}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            int daysDiff = (Sessao.DataValidade - DateTime.Now.Date).Days;
            if (daysDiff >= 1 && daysDiff <= 15)
            {
                string x, y;
                x = daysDiff == 1 ? "Falta " : "Faltam ";
                y = daysDiff == 1 ? " dia" : " dias";

                string msgAviso = $"**** AVISO IMPORTANTE ****\n\n {x + daysDiff + y} para expirar a licença de uso do Software SAE";
                msgAviso += "\nEntre em contato com a administração da instituição para formalizar a renovação do contrato.";
                MessageBox.Show(msgAviso, "Vencimento de Licença", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (daysDiff == 0)
            {
                string msg = "**** AVISO IMPORTANTE ****\n\nHoje é o último dia para uso do Software SAE, pois não foi identificado\n";
                msg += "a renovação da licença.\nApós a data de hoje todos os acesso serão automaticamente bloqueados.";
                MessageBox.Show(msg, "Vencimento de Licença", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            if (daysDiff <= -1)
            {
                string msg = "**** AVISO IMPORTANTE ****\n\nNão foi identificado a renovação da licença do software SAE\n";
                msg += "O acesso ao sistema será bloqueado até que a licença seja renovada pela administração da instituição";
                MessageBox.Show(msg, "Vencimento de Licença", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                BloquearSistema();
            }
        }

        void BloquearSistema()
        {
           splitContainer1.Enabled = panelCabecalho.Enabled = panelMenu.Enabled = false;
        }

        private void btnAddSae_Click(object sender, EventArgs e)
        {
            timerCollapsed.Start();
        }

        private void timerCollapsed_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelDropDown.Height += 10;

                if (panelDropDown.Size == panelDropDown.MaximumSize)
                {
                    timerCollapsed.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panelDropDown.Height -= 10;

                if (panelDropDown.Size == panelDropDown.MinimumSize)
                {
                    timerCollapsed.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btnClinicaMedica_Click(object sender, EventArgs e)
        {

            userControl = new FrmSae.UCTimeLine();
            OpenUc();
        }
    }
}