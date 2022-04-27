using AppInternacao.Enum;
using AppInternacao.Model;
using AppInternacao.Presenter;
using AppInternacao.View;
using FontAwesome.Sharp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Windows.Forms;

namespace AppInternacao
{
    public partial class FrmMain : Form, IMain
    {
        Form userControl = null;
        PresenterMain Presenter = null;
        private IconButton currentBtn;

        private bool[] isCollapsed = { true, true };
        public static IconButton mySalvar;
        public static IconButton myNovo;
        public static IconButton myImprimir;
        public static List<IconButton> listButtons = null;
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
            listButtons = new List<IconButton>() { myImprimir, mySalvar, myNovo, btnAddGeneric };
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.TextAlign = ContentAlignment.MiddleRight;
                currentBtn.IconColor = Color.FromArgb(65, 165, 245); 
                currentBtn.TextImageRelation = TextImageRelation.Overlay;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                currentBtn.BackColor = Color.Transparent;
            }
        }

        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                //Button
                DisableButton();
                currentBtn = (IconButton)senderBtn;

                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromArgb(173, 255, 47);
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                currentBtn.BackColor = Color.FromArgb(10, 30, 50);

                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                lblTitleForm.Text = $"Sistematização da Assistêmcia de Enfermagem - {currentBtn.Text}";
            }
        }

        public void OpenUc()
        {
            if (!isCollapsed[0])
                timerCollapsed.Start();

            var tt = splitContainerMain.Panel1.Controls.OfType<Form>().ToList();

            if (!tt.Any(cnt => cnt.Name.Equals(userControl.Name)))
            {
                if (tt.Count > 0)
                    tt[0].Dispose();

                listButtons.ForEach(b => RemoveClickEvent(b));

                splitContainerMain.Panel1.Controls.Clear();
                if (!splitContainerMain.Panel1.Controls.OfType<Control>().Any(f => f is Form))
                {
                    btnAddSae.Enabled = true;
                    userControl.TopLevel = false;
                    splitContainerMain.Panel1.Tag = userControl;
                    splitContainerMain.Panel1.Controls.Add(userControl);
                    userControl.Show();
                }
            }
        }

        /// <summary>
        /// remove os evento Click dos botões
        /// </summary>
        public static void RemoveClickEvent(Button _button)
        {
            FieldInfo f1 = typeof(Control).GetField("EventClick",BindingFlags.Static | BindingFlags.NonPublic);

            object obj = f1.GetValue(_button);
            PropertyInfo pi = _button.GetType().GetProperty("Events", BindingFlags.NonPublic | BindingFlags.Instance);

            EventHandlerList list = (EventHandlerList)pi.GetValue(_button, null);
            list.RemoveHandler(obj, list[obj]);
        }

        public void CloseUC()
        {
            try
            {
              //  splitContainerMain.Panel2Collapsed = true;
                if ((splitContainerMain.Panel1.Controls.OfType<Form>().ToList().Count == 0) && (splitContainerMain.Panel2.Controls.OfType<Form>().ToList().Count == 0))
                    return;

                List<Form> lstcontrols = splitContainerMain.Panel1.Controls.OfType<Form>().ToList();

                foreach (var item in lstcontrols)
                {
                    item.Close();
                    item.Dispose();
                };

                listButtons.ForEach(b => b.Visible = false);
                
                if (splitContainerMain.Panel2.Controls.OfType<Form>().ToList().Count == 0)
                    return;

                lstcontrols = splitContainerMain.Panel2.Controls.OfType<Form>().ToList();

                foreach (Form item in lstcontrols)
                {
                    item.Close();
                    item.Dispose();
                };

                splitContainerMain.Panel2Collapsed = true;
            }
            catch (Exception ex)
            {
                Alert(exception: ex);
            }
        }

        private void OpenUCLateral()
        {
            var tt = splitContainerMain.Panel2.Controls.OfType<Form>().ToList();

            if (!tt.Any(cnt => cnt.Name.Equals(userControl.Name)))
            {
                if (tt.Count > 0)
                    tt[0].Dispose();

                splitContainerMain.Panel2.Controls.Clear();
                if (!splitContainerMain.Panel2.Controls.OfType<Form>().Any(f => f is Form))
                {
                    splitContainerMain.Panel2.Controls.Add(userControl);
                    userControl.TopLevel = false;
                    userControl.Show();
                   splitContainerMain.Panel2.Controls[0].Hide();
                }
            }

        }

        private void CarregaPerfil()
        {
            btnAddSae.Visible = Sessao.Usuario.Perfil.HasFlag(Perfil.Enfermeiro_Assistemcial);
            btnAdmUsuario.Visible = Sessao.Usuario.Perfil.HasFlag(Perfil.EnfermeiroAdmin);
            btnGerenciamentoLeito.Visible = Sessao.Usuario.Perfil.HasFlag(Perfil.Enfermeiro_Assistemcial);
            btnPaciente.Visible = Sessao.Usuario.Perfil.HasFlag(Perfil.Enfermeiro_Assistemcial);
            btnTempalte.Visible = Sessao.Usuario.Perfil.HasFlag(Perfil.EnfermeiroAdmin);
          //  btnSalvar.Visible = Sessao.Usuario.Perfil.HasFlag(Perfil.Enfermeiro_Assistemcial);
            btnPrescricao.Visible = Sessao.Usuario.Perfil.HasFlag(Perfil.Enfermeiro_Assistemcial) || Sessao.Usuario.Perfil.HasFlag(Perfil.EnfermeiroAdmin) || Sessao.Usuario.Perfil.HasFlag(Perfil.Medico) || Sessao.Usuario.Perfil.HasFlag(Perfil.Tecnico);
           // btnNovo.Visible = Sessao.Usuario.Perfil.HasFlag(Perfil.Enfermeiro_Assistemcial) || Sessao.Usuario.Perfil.HasFlag(Perfil.Medico);
        }

        private void btnCMAdulto_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (splitContainerMain.Panel1.Controls.Count == 0)
            {
                Application.Exit();
                return;
            }

            Control control = splitContainerMain.Panel1.Controls[0];
            control.Dispose();

            if (splitContainerMain.Panel2.Controls.Count > 0)
            {
                control = splitContainerMain.Panel2.Controls[0];
                control.Dispose();
            }
            else
                btnAddSae.Enabled = false;
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            if (!isCollapsed[0])
                timerCollapsed.Start();

            if (!isCollapsed[1])
                timerCollapsedTemplate.Start();

            CloseUC();
            userControl = new FrmSae.FrmPaciente();
            OpenUc();
            ActivateButton(sender);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                panelDropDown.Height = panelDropDownTemplate.Height = 0;
               
                Presenter = new PresenterMain(this);
                Presenter.Iniciar();

                if ((bool)Sessao.Usuario.AlterarSenha)
                {
                    CloseUC();
                    panelCabecalho.Enabled = panelMenu.Enabled = false;
                    OpenUc();
                }

                CarregaPerfil();
            }
            catch (Exception exM)
            {
                Alert(0,exM);
            }
        }
       
        private void btnGerenciamentoLeito_Click(object sender, EventArgs e)
        {
            if (!isCollapsed[0])
                timerCollapsed.Start();

            if (!isCollapsed[1])
                timerCollapsedTemplate.Start();

            CloseUC();
            userControl = new FrmSae.UI004FrmPanel();
            ActivateButton(sender);
            splitContainerMain.Panel2Collapsed = false;
            OpenUc();
            userControl = new FrmSae.UI005ListaPaciente();
            OpenUCLateral();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CloseUC();
            //userControl = new FrmSae.UCTimeLine();
            OpenUc();
        }

        public static void Alert(Alerts tipo = Alerts.ErrorException, Exception exception = null)
        {
            switch (tipo)
            {
                case Alerts.InsertSuccess:
                    {
                        MessageBox.Show("Dados registrado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case Alerts.DeleteSuccess:
                    {
                        MessageBox.Show("Registro excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case Alerts.NotFind:
                    {
                        MessageBox.Show("Registro não localizado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    }
                case Alerts.ExistRegistry:
                    {
                        MessageBox.Show("Informação já cadastrada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        break;
                    }
                case Alerts.DeleteForeignKeyERRO:
                    {
                        MessageBox.Show("Não é possível excluir esse registro!!!\nPois o mesmo está associado a outra informação em uso no momento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        break;
                    }
                default:
                    MessageBox.Show($"ocorreu um erro e não foi possível completar a operação:\n{(exception == null ? "O Erro não foi Tratado, por favor contatar o administrado do sistema" : exception.Message)}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            splitContainerMain.Enabled = panelCabecalho.Enabled = panelMenu.Enabled = isAlterSenha;
        }

        private void btnAddSae_Click(object sender, EventArgs e)
        {
            if (!isCollapsed[1])
                timerCollapsedTemplate.Start();

            ActivateButton(sender);
            timerCollapsed.Start();
        }

        private void timerCollapsed_Tick(object sender, EventArgs e)
        {

            if (isCollapsed[0])
            {
                panelDropDown.Height += 20;

                if (panelDropDown.Size == panelDropDown.MaximumSize)
                {
                    timerCollapsed.Stop();
                    isCollapsed[0] = false;
                }
            }
            else
            {
                panelDropDown.Height -= 30;

                if (panelDropDown.Size == panelDropDown.MinimumSize)
                {
                    timerCollapsed.Stop();
                    isCollapsed[0] = true;
                }
            }
        }

        private void timerCollapsedTemplate_Tick(object sender, EventArgs e)
        {
            if (isCollapsed[1])
            {
                panelDropDownTemplate.Height += 20;

                if (panelDropDownTemplate.Size == panelDropDownTemplate.MaximumSize)
                {
                    timerCollapsedTemplate.Stop();
                    isCollapsed[1] = false;
                }
            }
            else
            {
                panelDropDownTemplate.Height -= 30;

                if (panelDropDownTemplate.Size == panelDropDownTemplate.MinimumSize)
                {
                    timerCollapsedTemplate.Stop();
                    isCollapsed[1] = true;
                }
            }
        }

        private void btnClinicaMedica_Click(object sender, EventArgs e)
        {
            if (!isCollapsed[0])
                timerCollapsed.Start();

            CloseUC();
           // userControl = new FrmSae.UCTimeLine();
            OpenUc();
        }

        private void btnAdmUsuario_Click(object sender, EventArgs e)
        {
            if (!isCollapsed[0])
                timerCollapsed.Start();

            if (!isCollapsed[1])
                timerCollapsedTemplate.Start();

            ActivateButton(sender);
            CloseUC();
            userControl = new FrmSae.FrmUsuario();
            OpenUc();
        }

        private void btnNanda_Click(object sender, EventArgs e)
        {
            if (!isCollapsed[0])
                timerCollapsed.Start();

            if (!isCollapsed[1])
                timerCollapsedTemplate.Start();

            ActivateButton(sender);
            CloseUC();
            userControl = new FrmSae.UI010FrmNanda();
            OpenUc();
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            if (!isCollapsed[0])
                timerCollapsed.Start();

            if (!isCollapsed[1])
                timerCollapsedTemplate.Start();

            CloseUC();
            userControl = new FrmSae.FrmAlterarSenha();
            OpenUc();
        }

        public void btnLogout_Click(object sender, EventArgs e)
        {
            if (!isCollapsed[0])
                timerCollapsed.Start();

            if (!isCollapsed[1])
                timerCollapsedTemplate.Start();

            if (splitContainerMain.Panel1.Controls.OfType<Form>().ToList().Count > 0)
            {
                CloseUC();
                DisableButton();
                lblTitleForm.Text = "Sistematização da Assistêmcia de Enfermagem";
                iconCurrentChildForm.IconChar = IconChar.Heartbeat;
            }
            else
            {
                Sessao.Usuario = null;
                Sessao.Cliente = null;
                Sessao.Paciente = null;
                Sessao.CodigoCliente = 0;
                Sessao.Dinamico = null;
                Sessao.DataValidade = DateTime.Now;
                Sessao.IsAtivo = false;

                Close();
                Dispose(true);
                Application.Exit();
            }
        }

        private void btnTempalte_Click(object sender, EventArgs e)
        {
            if (!isCollapsed[0])
                timerCollapsed.Start();

            ActivateButton(sender);
            timerCollapsedTemplate.Start();

            //CloseUC();
            //ActivateButton(sender);
            //userControl = new FrmSae.UI015FrmArea();
            //OpenUc();
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

        private void btnPrescricao_Click(object sender, EventArgs e)
        {
            if (!isCollapsed[0])
                timerCollapsed.Start();

            if (!isCollapsed[1])
                timerCollapsedTemplate.Start();

            ActivateButton(sender);
            CloseUC();
            userControl = new FrmSae.UI006FrmBarCodeProntuario(new FrmSae.UI007FrmMenuDireito());
            OpenUc();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }


        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            if (!isCollapsed[0])
                timerCollapsed.Start();

            if (!isCollapsed[1])
                timerCollapsedTemplate.Start();

            ActivateButton(sender);
            CloseUC();
            userControl = new FrmSae.UI013FrmSaeViewDiagnostico();
            OpenUc();
        }

        private void btnCriarTemplate_Click(object sender, EventArgs e)
        {
            if (!isCollapsed[1])
                timerCollapsedTemplate.Start();
            
            CloseUC();
            userControl = new FrmSae.UI020FrmSaeTemplateArea();
            OpenUc();
        }

        private void btnListarModelo_Click(object sender, EventArgs e)
        {
            if (!isCollapsed[1])
                timerCollapsedTemplate.Start();

            CloseUC();
            userControl = new FrmSae.UI21FrmSaeTemplateList();
            OpenUc();
        }

        private void iconBtnClinicaCirurgica_Click(object sender, EventArgs e)
        {
            if (!isCollapsed[0])
                timerCollapsed.Start();

            CloseUC();
            userControl = new FrmSae.UI006FrmBarCodeProntuario(new FrmSae.UI011FrmTimeLine() { Tag = SetorSae.ClinicaCirurgica });
            OpenUc();
        }

        private void btnClinicaMedica_Click_1(object sender, EventArgs e)
        {
            if (!isCollapsed[0])
                timerCollapsed.Start();

            CloseUC();
            userControl = new FrmSae.UI006FrmBarCodeProntuario(new FrmSae.UI011FrmTimeLine() { Tag = SetorSae.ClininaMedica });
            OpenUc();
        }

        private void iconBtnClinicaPediatrica_Click(object sender, EventArgs e)
        {
            if (!isCollapsed[0])
                timerCollapsed.Start();

            CloseUC();
            userControl = new FrmSae.UI006FrmBarCodeProntuario(new FrmSae.UI011FrmTimeLine() { Tag = SetorSae.ClinicaPediatrica });
            OpenUc();
        }

        private void iconBtnClinicaObstetrica_Click(object sender, EventArgs e)
        {
            if (!isCollapsed[0])
                timerCollapsed.Start();

            CloseUC();
            userControl = new FrmSae.UI006FrmBarCodeProntuario(new FrmSae.UI011FrmTimeLine() {Tag = SetorSae.ClinicaObstetrica });
            OpenUc();
        }

        private void iconBtnUrgenciaEmergencia_Click(object sender, EventArgs e)
        {
            if (!isCollapsed[0])
                timerCollapsed.Start();

            CloseUC();
            userControl = new FrmSae.UI006FrmBarCodeProntuario(new FrmSae.UI011FrmTimeLine() { Tag = SetorSae.UrgenciaEmergencia });
            OpenUc();
        }

        
    }
}