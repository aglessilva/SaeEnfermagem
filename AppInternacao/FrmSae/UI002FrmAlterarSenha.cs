using AppInternacao.Presenter;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace AppInternacao.FrmSae
{
    public partial class FrmAlterarSenha: AppInternacao.FrmSae.UI000FrmTemplate
    {
        public FrmAlterarSenha()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            textBoxSenha.Focus();
        }

        private void textBoxSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }

        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxSenha.Text.Length < 5)
                {
                    MessageBox.Show("A nova senha deve conter pelo menos 5 caracteres!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!textBoxSenha.Text.Equals(textBoxConfirmarSenha.Text, StringComparison.CurrentCulture))
                {
                    MessageBox.Show("As senhas informada não coincidem!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                //if ((bool)Sessao.Usuario.AlterarSenha)
                //{
                FrmMain frmMain = (FrmMain)FindForm();
                UsuarioPresenter usuarioPresenter = new UsuarioPresenter();

                Sessao.Usuario.Senha = CriptoGrafaSenha();
                Sessao.Usuario.AlterarSenha = false;

                int ret = (int)usuarioPresenter.Salvar(Sessao.Usuario);
                if (ret == 1)
                {
                    FrmMain.Alert(Enum.Alerts.InsertSuccess);
                    frmMain.BloquearSistema(true);
                    Dispose();
                }
                else
                    FrmMain.Alert();
                //  }
            }

            catch (Exception exalter)
            {
                FrmMain.Alert(exception: exalter);
            }
        }

        private string CriptoGrafaSenha()
        {
            MD5 md5Hasher = MD5.Create();
            byte[] valorCriptografado = md5Hasher.ComputeHash(Encoding.Default.GetBytes(textBoxSenha.Text));

            StringBuilder strBuilder = new StringBuilder();

            for (int i = 0; i < valorCriptografado.Length; i++)
            {
                strBuilder.Append(valorCriptografado[i].ToString("x2"));
            }
            return strBuilder.ToString();
        }

        private void btnSaiFechar_Click(object sender, EventArgs e)
        {
            Sessao.Usuario = null;
            Sessao.Cliente = null;
            Sessao.Paciente = null;
            Sessao.CodigoCliente = 0;

            Dispose(true);
            Application.Exit();
        }

        private void textBoxSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)32))
            {
                e.Handled = true;
            }
        }
    }
}
