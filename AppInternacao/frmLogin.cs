using AppInternacao.Model;
using AppInternacao.Presenter;
using AppInternacao.View;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AppInternacao
{
    public partial class frmLogin : Form, ILogin
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );

        public Login login => new Login()
        {
             UserName = textBoxUserName.Text.Trim(),
             PassWordUser = Funcoes.CriptoGrafaSenha(textBoxPassWord.Text.Trim())
        };

        public frmLogin()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            #if DEBUG
                textBoxUserName.Text = "xb225ha";
                 textBoxPassWord.Text = "hbt123";
            #endif

            textBoxUserName.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!pEsqueciMinhaSenha.Visible)
                {
                    if (string.IsNullOrWhiteSpace(textBoxPassWord.Text) || string.IsNullOrWhiteSpace(textBoxUserName.Text))
                        MessageBox.Show("Preencha os campos usuário e senha", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    else
                    {
                        LoginPresenter loginPresenter = new LoginPresenter(this);
                        Sessao.Usuario = loginPresenter.AutenticarUsuario();

                        if (Sessao.Usuario.Id > 0)
                        {
                            if (!(bool)Sessao.Usuario.Ativo)
                            {
                                MessageBox.Show($"Usuario {Sessao.Usuario.Nome} foi inativado pelo administrador do sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            Hide();
                            FrmMain frmMain = new FrmMain();
                            frmMain.Show();
                        }
                        else
                        {
                            MessageBox.Show($"Usuario {textBoxUserName.Text} ou senha incorreta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            textBoxUserName.Focus();
                        }
                    }
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(textBoxLoginEsqueciSenha.Text.Trim()) || string.IsNullOrWhiteSpace(textBoxCpf.Text.Trim()))
                    {
                        MessageBox.Show("Preencha os campos usuário e CPF corretamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }

                    LoginPresenter loginPresenter = new LoginPresenter(this);
                    Usuario obj = loginPresenter.AutenticarUsuario(new Usuario() { Login = textBoxLoginEsqueciSenha.Text.Trim(), Cpf = textBoxCpf.Text.Trim()});
                    UsuarioPresenter usuarioPresenter = new UsuarioPresenter();

                    TopMost = false;
                    
                    if (obj.Id > 0)
                    {
                        string novaSenha = "xb" + DateTime.Now.Day + obj.Nome.Substring(0, 2) + obj.Cpf.Substring(8, 2);
                        obj.AlterarSenha = true;
                        Enabled = false;
                        obj.Senha = Funcoes.CriptoGrafaSenha(novaSenha);
                        int ret = (int)usuarioPresenter.Salvar(obj);
                        Enabled = true;

                        if (ret == 1)
                        {
                            obj.Senha = novaSenha;
                            ret = Funcoes.EnviarEmail(obj);
                            if (ret == 0)
                                MessageBox.Show($"Email enviado com sucesso!\nEnviamos para o email {obj.Email} as informações de acesso ao sistema SAE", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (ret == 1)
                                MessageBox.Show($"Envio de email cancelado!\nO serviço de email não consegui enviar as informas para o email {obj.Email}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            if (ret == 2)
                                MessageBox.Show($"Ocorreu um Erro!\nOcorreu um erro na tentativa de enviar o e-mail para {obj.Email}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        obj = null;
                        lblVoltar_Click(null, null);
                    }
                    else
                        MessageBox.Show($"Usuário {textBoxLoginEsqueciSenha.Text} não foi localizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    TopMost = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ocorreu um erro ao tentar iniciar o sistema\n contate o administrador para verificar o problema\n\n"+ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblEsqueciMinhaSenha_Click(object sender, EventArgs e)
        {
            pEsqueciMinhaSenha.Visible = !pEsqueciMinhaSenha.Visible;
            textBoxPassWord.Text = textBoxUserName.Text = string.Empty;
            textBoxLoginEsqueciSenha.Focus();
        }

        private void lblVoltar_Click(object sender, EventArgs e)
        {
            pEsqueciMinhaSenha.Visible = !pEsqueciMinhaSenha.Visible;
            textBoxCpf.Text = textBoxLoginEsqueciSenha.Text = string.Empty;
            textBoxUserName.Focus();
        }
    }
}
