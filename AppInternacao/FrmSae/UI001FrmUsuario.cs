using AppInternacao.Enum;
using AppInternacao.Model;
using AppInternacao.Presenter;
using AppInternacao.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AppInternacao.FrmSae
{
    public partial class FrmUsuario001 : AppInternacao.FrmSae.UI000FrmTemplate, IUsuario
    {
        public FrmUsuario001()
        {
            InitializeComponent();
            dataGridViewUsuarios.AutoGenerateColumns = false;
        }


        private UsuarioPresenter usuarioPresenter = null;
        public Usuario usuario
        {

            get =>
                new Usuario()
                {
                    Id = string.IsNullOrWhiteSpace(textBoxIdUsuario.Text) ? 0 : Convert.ToInt32(textBoxIdUsuario.Text),
                    Nome = textBoxNome.Text.Trim(),
                    Cpf = Regex.Replace(mskCpf.Text.Trim(), @"[^0-9$]", string.Empty).Trim(),
                    Telefone = Regex.Replace(mskTelefone.Text.Trim(), @"[^0-9$]", string.Empty).Trim(),
                    Email = textBoxEmail.Text.Trim(),
                    Login = textBoxLogin.Text.Trim(),
                    Senha = string.IsNullOrWhiteSpace(textBoxPwdEncripit.Text) ? Funcoes.CriptoGrafaSenha(textBoxSenha.Text.Trim()).Trim() : textBoxPwdEncripit.Text,
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
                textBoxPwdEncripit.Text = value.Senha;
                //textBoxEmail.Enabled = false;
                if (value.Ativo == null)
                {
                    rdoAtivo.Checked = false;
                    rdoInativo.Checked = false;
                }
                else
                {
                    rdoAtivo.Checked = (bool)value.Ativo;
                    rdoInativo.Checked = !rdoAtivo.Checked;
                }
                comboBoxPerfil.SelectedItem = (Perfil)value.Perfil;
            }

        }

        void Carregar()
        {
            usuarioPresenter = new UsuarioPresenter();
            var lista = usuarioPresenter.Carregar();
            dataGridViewUsuarios.DataSource = lista;
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            dataGridViewUsuarios.RowEnter -= dataGridViewUsuarios_RowEnter;
            new ToolTip().SetToolTip(btnImparPesquisa, "Limpar Pesquisa");

            FrmMain.myNovo.Visible = FrmMain.mySalvar.Visible = true;
            FrmMain.mySalvar.Click += new EventHandler(Salvar);
            FrmMain.myNovo.Click += MyNovo_Click;
            textBoxNome.Focus();
            try
            {
                Carregar();
                List<Perfil> list = new List<Perfil>() { Perfil.Nenhum, Perfil.Tecnico, Perfil.Administrador, Perfil.Enfermeiro_Assistemcial, Perfil.EnfermeiroAdmin, Perfil.Medico };
                comboBoxPerfil.DataSource = list;
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu erro ao tentar inicializar o formiulário.\nErro: {ex.Message}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridViewUsuarios.RowEnter += dataGridViewUsuarios_RowEnter;

        }

        private void MyNovo_Click(object sender, EventArgs e)
        {
            var lista = gUsuario.Controls.OfType<TextBox>().Where(t => t is TextBox).ToList();

            lista.RemoveAll(t => !t.Enabled);

            foreach (TextBox item in lista)
                errorProviderFields.SetError(item, null);

            errorProviderFields.SetError(mskCpf, null);
            errorProviderFields.SetError(mskTelefone, null);
            errorProviderFields.SetError(rdoInativo, null);

            usuario = new Usuario();
            textBoxSenha.Text = string.Empty;
            textBoxPwdEncripit.Text = string.Empty;
            comboBoxPerfil.SelectedIndex = 0;
            rdoInativo.Checked = rdoAtivo.Checked = false;
        }

        private void Salvar(object sender, EventArgs e)
        {
            try
            {
                if (!ValidaCampos())
                    return;
                bool ret = Funcoes.ValidaCpf(Regex.Replace(mskCpf.Text, @"[^0-9$]", string.Empty));
                if (!ret)
                {
                    errorProviderFields.SetError(mskCpf, "CPF inválido");
                    errorProviderFields.SetIconPadding(mskCpf, 3);
                    return;
                }
                else
                    errorProviderFields.SetError(mskCpf, null);

                usuarioPresenter = new UsuarioPresenter(this);
                int retorno = (int)usuarioPresenter.Salvar();

                if (retorno > 0)
                {
                    if (usuario.Id == 0)
                    {
                        Usuario objUsuario = usuario;
                        objUsuario.Senha = textBoxSenha.Text.Trim();
                        retorno = Funcoes.EnviarEmail(objUsuario, true);

                        if (retorno == 0)
                            MessageBox.Show($"Usuário cadastrado com sucesso!\nEnviamos para o email {usuario.Email} as informações de acesso ao sistema SAE", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (retorno == 1)
                            MessageBox.Show($"Envio de email cancelado!\nO serviço de email não consegui enviar as informas para o email {usuario.Email}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        if (retorno == 2)
                            MessageBox.Show($"Ocorreu um Erro!\nOcorreu um erro na tentativa de enviar o e-mail para {usuario.Email}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        objUsuario = null;
                    }
                    else
                        FrmMain.Alert(retorno);

                    Carregar();
                    MyNovo_Click(null, null);
                }

            }
            catch (Exception exSalvar)
            {
                MessageBox.Show(exSalvar.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mskCpf_Leave(object sender, EventArgs e)
        {
            string[] arrayNome = textBoxNome.Text.Split(' ').Where(n => !string.IsNullOrWhiteSpace(n)).ToArray();

            if (string.IsNullOrWhiteSpace(textBoxNome.Text))
            {
                MessageBox.Show("Informe o nome do usuário", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (arrayNome.Count() < 2)
            {
                MessageBox.Show("Informe o sobrenome do usuário", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            string _doc = Regex.Replace(mskCpf.Text, @"[^0-9$]", string.Empty);
            if (_doc.Length == 11)
            {
                // Verifica se ja existe usuario cadastrado com o CPF
                if (usuario.Id == 0)
                {
                    int ret = usuarioPresenter.VerificarCPF(_doc);

                    if (ret > 0)
                    {
                        MessageBox.Show("CPF já cadastrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                textBoxLogin.Text = $"xb{_doc.Substring(0, 3)}{arrayNome[0].Substring(0, 1)}{arrayNome[1].Substring(0, 1)}";
                textBoxSenha.Text = $"xb{_doc.Substring(8)}";
            }
        }

        private bool ValidaCampos()
        {
            RadioButton radioButton = null;
            try
            {
                var lista = gUsuario.Controls.OfType<TextBox>().Where(t => t is TextBox).ToList();

                lista.RemoveAll(t => !t.Enabled);

                foreach (TextBox item in lista)
                {
                    if (string.IsNullOrEmpty(item.Text) || item.Text.Equals("0"))
                    {
                        errorProviderFields.SetError(item, "preencha este campo");
                        errorProviderFields.SetIconPadding(item, 3);
                    }
                    else
                        errorProviderFields.SetError(item, null);
                }

                var listaMsk = gUsuario.Controls.OfType<MaskedTextBox>().Where(t => t is MaskedTextBox).ToList();

                foreach (MaskedTextBox item in listaMsk)
                {
                    if (item.Name == "mskCpf")
                    {
                        //999.999.999-99
                        if (!Regex.IsMatch(item.Text.Trim(), @"(^\d{3}.\d{3}.\d{3}-\d{2}$)"))
                        {
                            errorProviderFields.SetError(item, "preencha este campo");
                            errorProviderFields.SetIconPadding(item, 3);
                        }
                        else

                            errorProviderFields.SetError(item, null);
                    }
                    else
                    {
                        if (!Regex.IsMatch(item.Text.Trim(), @"^\(\d{2}\)\s\d{4,5}-\d{3,4}$"))
                        {
                            errorProviderFields.SetError(item, "preencha este campo");
                            errorProviderFields.SetIconPadding(item, 3);
                        }
                        else
                            errorProviderFields.SetError(item, null);
                    }
                }


                if (gUsuario.Controls.OfType<RadioButton>().Where(t => t is RadioButton).ToList().Count(c => c.Checked) == 0)
                {
                    radioButton = gUsuario.Controls.OfType<RadioButton>().FirstOrDefault(t => t is RadioButton);
                    errorProviderFields.SetError(radioButton, "preencha este campo");
                    errorProviderFields.SetIconPadding(radioButton, 3);
                    return false;
                }
                else
                {
                    radioButton = gUsuario.Controls.OfType<RadioButton>().FirstOrDefault(t => t is RadioButton);
                    errorProviderFields.SetError(radioButton, null);
                }

                bool retorno = (lista.TrueForAll(x => !string.IsNullOrWhiteSpace(x.Text) && !x.Text.Equals("0"))
                                && listaMsk.TrueForAll(x => !string.IsNullOrWhiteSpace(x.Text) && !x.Text.Equals("0")));

                return retorno;
            }
            catch (Exception exValidacamp)
            {

                MessageBox.Show("Ocorreu um erro na validação de campo\n" + exValidacamp.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void dataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var sendGrid = (DataGridView)sender;
            if (e.ColumnIndex == 5)
            {
                if (sendGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
                {
                    usuario = (Usuario)sendGrid.Rows[e.RowIndex].DataBoundItem;
                }
            }
        }
        private void dataGridViewUsuarios_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var sendGrid = (DataGridView)sender;
            usuario = (Usuario)sendGrid.Rows[e.RowIndex].DataBoundItem;
        }

        private void btnImparPesquisa_Click(object sender, EventArgs e)
        {
            textBoxPesquisaUsario.Text = string.Empty;
        }

        private void FrmUsuario001_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain.mySalvar.Click -= Salvar;
            FrmMain.myNovo.Click -= MyNovo_Click;
        }
    }
}


