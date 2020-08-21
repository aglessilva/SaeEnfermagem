using AppInternacao.Model;
using AppInternacao.Presenter;
using AppInternacao.View;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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
        public static Button myImprimir;

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
            myImprimir = btnImprimir;
        }


        private void OpenUc()
        {
            if (!isCollapsed)
                timerCollapsed.Start();

            var tt = splitContainer1.Panel1.Controls.OfType<UserControl>().ToList();

            if (!tt.Any(cnt => cnt.Name.Equals(userControl.Name)))
            {
                if (tt.Count > 0)
                    tt[0].Dispose();
               
                splitContainer1.Panel1.Controls.Clear();
                if (!splitContainer1.Panel1.Controls.OfType<Control>().Any(f => f is UserControl))
                {
                    splitContainer1.Panel1.Controls.Add(userControl);
                    btnAddSae.Enabled = true;
                }
            }
        }

        private void OpenUCLateral()
        {
            var tt = splitContainer1.Panel2.Controls.OfType<UserControl>().ToList();

            if (!tt.Any(cnt => cnt.Name.Equals(userControl.Name)))
            {
                if (tt.Count > 0)
                    tt[0].Dispose();

                splitContainer1.Panel2.Controls.Clear();
                if (!splitContainer1.Panel2.Controls.OfType<Control>().Any(f => f is UserControl))
                {
                    splitContainer1.Panel2.Controls.Add(userControl);
                    splitContainer1.Panel2.Controls[0].Hide();
                }
            }

        }


        private void btnCMAdulto_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel1.Controls.Count == 0)
            {
                Application.Exit();
                return;
            }

            Control control = splitContainer1.Panel1.Controls[0];
            control.Dispose();

            if (splitContainer1.Panel2.Controls.Count > 0)
            {
                control = splitContainer1.Panel2.Controls[0];
                control.Dispose();
            }
            else
                btnAddSae.Enabled = false;
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            CloseUC();
            userControl = new FrmSae.UCPaciente();
            OpenUc();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                Presenter = new PresenterMain(this);
                Presenter.Iniciar();

            //TODO: DESCOMENTAR ESSE BLOCO PARA PARA REALIZAR LOGIN E PRENCHER A SESSÃO DO USUARIO LOGADO
                if ((bool)Sessao.Usuario.AlterarSenha)
                {
                    CloseUC();
                    userControl = new FrmSae.UCAlterarSenha();
                    panelCabecalho.Enabled = panelMenu.Enabled = false;
                    OpenUc();
                }
            }
            catch (Exception exM)
            {
                Alert(0,exM);
            }
        }
       

        private void btnGerenciamentoLeito_Click(object sender, EventArgs e)
        {
            CloseUC();
            userControl = new FrmSae.UCQuartoLeito();
            OpenUc();
            userControl = new FrmSae.UCListaPaciente();
            OpenUCLateral();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CloseUC();
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
                case 5:
                    {
                        MessageBox.Show("Senha Alterada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case 200:
                    {
                        MessageBox.Show("Não é possível excluir esse registro!!!\nPois o mesmo está associado a outra informação em uso no momento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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

        public void BloquearSistema(bool isAlterSenha = false)
        {
            splitContainer1.Enabled = panelCabecalho.Enabled = panelMenu.Enabled = isAlterSenha;
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
            if (!isCollapsed)
                timerCollapsed.Start();

            CloseUC();
            userControl = new FrmSae.UCTimeLine();
            OpenUc();
        }

        private void btnAdmUsuario_Click(object sender, EventArgs e)
        {
            if (!isCollapsed)
                timerCollapsed.Start();

            CloseUC();
            userControl = new FrmSae.UCUsuario();
            OpenUc();
        }

        private void CloseUC()
        {
            List<UserControl> lstcontrols = splitContainer1.Panel1.Controls.OfType<UserControl>().ToList();

            foreach (UserControl item in lstcontrols)
            {
                item.Dispose();
            };

            lstcontrols = splitContainer1.Panel2.Controls.OfType<UserControl>().ToList();

            foreach (UserControl item in lstcontrols)
            {
                item.Dispose();
            };
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            CloseUC();
            userControl = new FrmSae.UCAlterarSenha();
            OpenUc();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel1.Controls.OfType<UserControl>().ToList().Count > 0)
                CloseUC();
            else
            {
                Sessao.Usuario = null;
                Sessao.Cliente = null;
                Sessao.Paciente = null;
                Sessao.CodigoCliente = 0;
                Close();
                Dispose(true);
                Application.Exit();
            }
        }

        private void btnTempalte_Click(object sender, EventArgs e)
        {
            CloseUC();
            userControl = new FrmSae.UCNomeTemplate();
            OpenUc();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/03546000/json/");
                request.ServerCertificateValidationCallback = delegate { return true; };
                request.AllowAutoRedirect = false;

                HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();

                if (ChecaServidor.StatusCode != HttpStatusCode.OK)
                {
                    MessageBox.Show("Servidor indisponível");
                    return; // Sai da rotina
                }

                using (Stream webStream = ChecaServidor.GetResponseStream())
                {
                    if (webStream != null)
                    {
                        using (StreamReader responseReader = new StreamReader(webStream))
                        {
                            string response = responseReader.ReadToEnd();
                            Endereco constants = JsonConvert.DeserializeObject<Endereco>(response);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}