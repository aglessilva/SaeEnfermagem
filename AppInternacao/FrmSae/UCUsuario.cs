using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppInternacao.Enum;
using AppInternacao.View;
using AppInternacao.Model;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using AppInternacao.Presenter;

namespace AppInternacao.FrmSae
{
    public partial class UCUsuario : UserControl, IUsuario
    {
        private UsuarioPresenter usuarioPresenter = null;
        public Usuario usuario
        {

            get =>
                new Usuario()
                {
                    Id = string.IsNullOrWhiteSpace(textBoxIdUsuario.Text) ? 0 : Convert.ToInt32(textBoxIdUsuario.Text),
                    Nome = textBoxNome.Text.Trim(),
                    Cpf = Regex.Replace(mskCpf.Text, @"[^0-9$]", string.Empty).Trim(),
                    Telefone = Regex.Replace(mskTelefone.Text, @"[^0-9$]", string.Empty).Trim(),
                    Email = textBoxEmail.Text,
                    Login = textBoxLogin.Text,
                    Senha = CriptoGrafaSenha(),
                    Ativo = rdoAtivo.Checked ? true : false,
                    Perfil = (Perfil)comboBoxPerfil.SelectedItem
                };
            set
            {
                textBoxIdUsuario.Text = value.Id.ToString();
                textBoxNome.Text = value.Nome;
                textBoxLogin.Text = value.Login;
                mskCpf.Text = value.Cpf;
                mskTelefone.Text = value.Telefone;
                textBoxEmail.Text = value.Email;
                textBoxEmail.Enabled = false;
                rdoAtivo.Checked = value.Ativo;
                rdoInativo.Checked = !rdoAtivo.Checked;
                comboBoxPerfil.SelectedItem = (Perfil)value.Perfil;
            }

        }

        public UCUsuario()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void UCUsuario_Load(object sender, EventArgs e)
        {
            FrmMain.mySalvar.Click += new EventHandler(Salvar);
            FrmMain.myNovo.Click += MyNovo_Click;
            textBoxNome.Focus();

            Perfil perfil = Perfil.Admin;

            List<Perfil> list = new List<Perfil>() { Perfil.Admin, Perfil.Enfermeiros, Perfil.Medicos };
            if (perfil.HasFlag(Perfil.Enfermeiros))
                comboBoxPerfil.DataSource = list;
        }

        private void MyNovo_Click(object sender, EventArgs e)
        {
            usuario = new Usuario();
            textBoxSenha.Text = string.Empty;
            comboBoxPerfil.SelectedIndex = 0;
            rdoInativo.Checked = rdoAtivo.Checked = false;
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

        private void Salvar(object sender, EventArgs e)
        {
            try
            {
                usuarioPresenter = new UsuarioPresenter(this);
                FrmMain.Alert(usuarioPresenter.Salvar());
                MyNovo_Click(null, null);
            }
            catch (Exception exSalvar)
            {
                MessageBox.Show(exSalvar.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void mskCpf_Leave(object sender, EventArgs e)
        {
            string[] arrayNome = textBoxNome.Text.Split(' ');
            string _doc = Regex.Replace(mskCpf.Text, @"[^0-9$]", string.Empty);
            if(_doc.Length == 11)
            {
                textBoxLogin.Text = $"xb{_doc.Substring(0, 3)}{arrayNome[0].Substring(0,1)}{arrayNome[1].Substring(0, 1)}";
                textBoxSenha.Text = $"xb{_doc.Substring(8)}";
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            textBoxPesquisaUsario.Text = string.Empty;
        }
    }
}
