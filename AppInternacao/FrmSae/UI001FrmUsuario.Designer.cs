namespace AppInternacao.FrmSae
{
    partial class FrmUsuario
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBoxPwdEncripit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.textBoxIdUsuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rdoInativo = new System.Windows.Forms.RadioButton();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.rdoAtivo = new System.Windows.Forms.RadioButton();
            this.comboBoxPerfil = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnImparPesquisa = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gPesquisausuario = new System.Windows.Forms.GroupBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.textBoxPesquisaUsario = new System.Windows.Forms.TextBox();
            this.gUsuario = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxExt1 = new AppInternacao.Extend.CheckBoxExt();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProviderFields = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.gPesquisausuario.SuspendLayout();
            this.panel9.SuspendLayout();
            this.gUsuario.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFields)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 32);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel6.Location = new System.Drawing.Point(0, -32);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(310, 1);
            this.panel6.TabIndex = 8;
            // 
            // textBoxPwdEncripit
            // 
            this.textBoxPwdEncripit.Enabled = false;
            this.textBoxPwdEncripit.Location = new System.Drawing.Point(665, 109);
            this.textBoxPwdEncripit.Name = "textBoxPwdEncripit";
            this.textBoxPwdEncripit.Size = new System.Drawing.Size(42, 20);
            this.textBoxPwdEncripit.TabIndex = 44;
            this.textBoxPwdEncripit.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(387, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Perfil:";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.DimGray;
            this.panel11.Location = new System.Drawing.Point(665, 45);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(150, 1);
            this.panel11.TabIndex = 42;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DimGray;
            this.panel8.Location = new System.Drawing.Point(430, 45);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(125, 1);
            this.panel8.TabIndex = 41;
            // 
            // textBoxIdUsuario
            // 
            this.textBoxIdUsuario.Enabled = false;
            this.textBoxIdUsuario.Location = new System.Drawing.Point(185, 150);
            this.textBoxIdUsuario.Name = "textBoxIdUsuario";
            this.textBoxIdUsuario.Size = new System.Drawing.Size(42, 20);
            this.textBoxIdUsuario.TabIndex = 40;
            this.textBoxIdUsuario.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Status:";
            // 
            // rdoInativo
            // 
            this.rdoInativo.AutoSize = true;
            this.rdoInativo.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.rdoInativo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rdoInativo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.rdoInativo.Location = new System.Drawing.Point(113, 148);
            this.rdoInativo.Name = "rdoInativo";
            this.rdoInativo.Size = new System.Drawing.Size(57, 17);
            this.rdoInativo.TabIndex = 9;
            this.rdoInativo.TabStop = true;
            this.rdoInativo.Text = "Inativo";
            this.rdoInativo.UseVisualStyleBackColor = true;
            // 
            // Editar
            // 
            this.Editar.Description = "Editar registro";
            this.Editar.HeaderText = "";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.ToolTipText = "Editar Registro!";
            this.Editar.Width = 30;
            // 
            // rdoAtivo
            // 
            this.rdoAtivo.AutoSize = true;
            this.rdoAtivo.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.rdoAtivo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rdoAtivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.rdoAtivo.Location = new System.Drawing.Point(58, 148);
            this.rdoAtivo.Name = "rdoAtivo";
            this.rdoAtivo.Size = new System.Drawing.Size(49, 17);
            this.rdoAtivo.TabIndex = 8;
            this.rdoAtivo.TabStop = true;
            this.rdoAtivo.Text = "Ativo";
            this.rdoAtivo.UseVisualStyleBackColor = true;
            // 
            // comboBoxPerfil
            // 
            this.comboBoxPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPerfil.FormattingEnabled = true;
            this.comboBoxPerfil.Location = new System.Drawing.Point(423, 65);
            this.comboBoxPerfil.Name = "comboBoxPerfil";
            this.comboBoxPerfil.Size = new System.Drawing.Size(215, 24);
            this.comboBoxPerfil.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DimGray;
            this.panel7.Location = new System.Drawing.Point(431, 125);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(215, 1);
            this.panel7.TabIndex = 35;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxSenha.Enabled = false;
            this.textBoxSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSenha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxSenha.Location = new System.Drawing.Point(432, 106);
            this.textBoxSenha.MaxLength = 10;
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.Size = new System.Drawing.Size(214, 19);
            this.textBoxSenha.TabIndex = 7;
            this.textBoxSenha.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(382, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Senha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Login:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "E-mail:";
            // 
            // btnImparPesquisa
            // 
            this.btnImparPesquisa.BackColor = System.Drawing.Color.Transparent;
            this.btnImparPesquisa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImparPesquisa.BackgroundImage")));
            this.btnImparPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImparPesquisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImparPesquisa.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnImparPesquisa.FlatAppearance.BorderSize = 0;
            this.btnImparPesquisa.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnImparPesquisa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnImparPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImparPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImparPesquisa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnImparPesquisa.Location = new System.Drawing.Point(335, 24);
            this.btnImparPesquisa.Name = "btnImparPesquisa";
            this.btnImparPesquisa.Size = new System.Drawing.Size(29, 24);
            this.btnImparPesquisa.TabIndex = 11;
            this.btnImparPesquisa.UseVisualStyleBackColor = false;
            this.btnImparPesquisa.Click += new System.EventHandler(this.btnImparPesquisa_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Location = new System.Drawing.Point(55, 125);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(309, 1);
            this.panel3.TabIndex = 30;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxLogin.Enabled = false;
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxLogin.Location = new System.Drawing.Point(56, 109);
            this.textBoxLogin.MaxLength = 20;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(308, 14);
            this.textBoxLogin.TabIndex = 6;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.Description = "Editar registro";
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.ToolTipText = "Editar Registro!";
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.Description = "Liberar leito";
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.ToolTipText = "Liberar Leito!";
            this.dataGridViewImageColumn2.Width = 30;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel2.Location = new System.Drawing.Point(0, -32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 1);
            this.panel2.TabIndex = 8;
            // 
            // gPesquisausuario
            // 
            this.gPesquisausuario.BackColor = System.Drawing.Color.Transparent;
            this.gPesquisausuario.Controls.Add(this.btnImparPesquisa);
            this.gPesquisausuario.Controls.Add(this.pictureBox1);
            this.gPesquisausuario.Controls.Add(this.panel9);
            this.gPesquisausuario.Controls.Add(this.textBoxPesquisaUsario);
            this.gPesquisausuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.gPesquisausuario.Location = new System.Drawing.Point(0, 185);
            this.gPesquisausuario.Name = "gPesquisausuario";
            this.gPesquisausuario.Size = new System.Drawing.Size(849, 60);
            this.gPesquisausuario.TabIndex = 14;
            this.gPesquisausuario.TabStop = false;
            this.gPesquisausuario.Text = "Pesquisar Usuário por Nome";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DimGray;
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Location = new System.Drawing.Point(19, 50);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(345, 1);
            this.panel9.TabIndex = 21;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel10.Location = new System.Drawing.Point(0, -32);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(310, 1);
            this.panel10.TabIndex = 8;
            // 
            // textBoxPesquisaUsario
            // 
            this.textBoxPesquisaUsario.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxPesquisaUsario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPesquisaUsario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxPesquisaUsario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPesquisaUsario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxPesquisaUsario.Location = new System.Drawing.Point(51, 34);
            this.textBoxPesquisaUsario.MaxLength = 18;
            this.textBoxPesquisaUsario.Name = "textBoxPesquisaUsario";
            this.textBoxPesquisaUsario.Size = new System.Drawing.Size(313, 14);
            this.textBoxPesquisaUsario.TabIndex = 10;
            // 
            // gUsuario
            // 
            this.gUsuario.BackColor = System.Drawing.Color.Transparent;
            this.gUsuario.Controls.Add(this.textBoxPwdEncripit);
            this.gUsuario.Controls.Add(this.label8);
            this.gUsuario.Controls.Add(this.panel11);
            this.gUsuario.Controls.Add(this.panel8);
            this.gUsuario.Controls.Add(this.textBoxIdUsuario);
            this.gUsuario.Controls.Add(this.label7);
            this.gUsuario.Controls.Add(this.rdoInativo);
            this.gUsuario.Controls.Add(this.rdoAtivo);
            this.gUsuario.Controls.Add(this.comboBoxPerfil);
            this.gUsuario.Controls.Add(this.panel7);
            this.gUsuario.Controls.Add(this.textBoxSenha);
            this.gUsuario.Controls.Add(this.label6);
            this.gUsuario.Controls.Add(this.label5);
            this.gUsuario.Controls.Add(this.panel3);
            this.gUsuario.Controls.Add(this.textBoxLogin);
            this.gUsuario.Controls.Add(this.label4);
            this.gUsuario.Controls.Add(this.panel1);
            this.gUsuario.Controls.Add(this.textBoxEmail);
            this.gUsuario.Controls.Add(this.mskTelefone);
            this.gUsuario.Controls.Add(this.label3);
            this.gUsuario.Controls.Add(this.mskCpf);
            this.gUsuario.Controls.Add(this.label2);
            this.gUsuario.Controls.Add(this.label1);
            this.gUsuario.Controls.Add(this.panel4);
            this.gUsuario.Controls.Add(this.textBoxNome);
            this.gUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.gUsuario.Location = new System.Drawing.Point(0, 0);
            this.gUsuario.Name = "gUsuario";
            this.gUsuario.Size = new System.Drawing.Size(849, 185);
            this.gUsuario.TabIndex = 13;
            this.gUsuario.TabStop = false;
            this.gUsuario.Text = "Cadastro de Usuários";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.checkBoxExt1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(54, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 1);
            this.panel1.TabIndex = 27;
            // 
            // checkBoxExt1
            // 
            this.checkBoxExt1.AutoSize = true;
            this.checkBoxExt1.Location = new System.Drawing.Point(0, 0);
            this.checkBoxExt1.Name = "checkBoxExt1";
            this.checkBoxExt1.Size = new System.Drawing.Size(95, 17);
            this.checkBoxExt1.TabIndex = 9;
            this.checkBoxExt1.Text = "checkBoxExt1";
            this.checkBoxExt1.UseVisualStyleBackColor = true;
            this.checkBoxExt1.Value = "";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxEmail.Location = new System.Drawing.Point(55, 69);
            this.textBoxEmail.MaxLength = 40;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(308, 14);
            this.textBoxEmail.TabIndex = 4;
            // 
            // mskTelefone
            // 
            this.mskTelefone.BackColor = System.Drawing.SystemColors.Control;
            this.mskTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mskTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefone.Location = new System.Drawing.Point(661, 29);
            this.mskTelefone.Mask = "(99) 99999-9999";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(151, 14);
            this.mskTelefone.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(603, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Telefone:";
            // 
            // mskCpf
            // 
            this.mskCpf.BackColor = System.Drawing.SystemColors.Control;
            this.mskCpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mskCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCpf.Location = new System.Drawing.Point(432, 29);
            this.mskCpf.Mask = "999.999.999-99";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(136, 14);
            this.mskCpf.TabIndex = 2;
            this.mskCpf.Leave += new System.EventHandler(this.mskCpf_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nome:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(55, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(309, 1);
            this.panel4.TabIndex = 18;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel5.Location = new System.Drawing.Point(0, -32);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(310, 1);
            this.panel5.TabIndex = 8;
            // 
            // textBoxNome
            // 
            this.textBoxNome.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxNome.Location = new System.Drawing.Point(56, 30);
            this.textBoxNome.MaxLength = 50;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(308, 14);
            this.textBoxNome.TabIndex = 1;
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.AllowUserToAddRows = false;
            this.dataGridViewUsuarios.AllowUserToDeleteRows = false;
            this.dataGridViewUsuarios.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dataGridViewUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUsuarios.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Cpf,
            this.Telefone,
            this.TipoPerfil,
            this.Editar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUsuarios.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(0, 245);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.ReadOnly = true;
            this.dataGridViewUsuarios.RowHeadersVisible = false;
            this.dataGridViewUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(849, 310);
            this.dataGridViewUsuarios.TabIndex = 15;
            this.dataGridViewUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsuarios_CellContentClick);
            this.dataGridViewUsuarios.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsuarios_RowEnter);
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 5;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Cpf
            // 
            this.Cpf.DataPropertyName = "Cpf";
            this.Cpf.HeaderText = "Cpf";
            this.Cpf.Name = "Cpf";
            this.Cpf.ReadOnly = true;
            this.Cpf.Width = 150;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "Telefone";
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.Width = 150;
            // 
            // TipoPerfil
            // 
            this.TipoPerfil.DataPropertyName = "Perfil";
            this.TipoPerfil.HeaderText = "Perfil";
            this.TipoPerfil.Name = "TipoPerfil";
            this.TipoPerfil.ReadOnly = true;
            this.TipoPerfil.Width = 150;
            // 
            // errorProviderFields
            // 
            this.errorProviderFields.ContainerControl = this;
            // 
            // FrmUsuario001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(849, 555);
            this.Controls.Add(this.dataGridViewUsuarios);
            this.Controls.Add(this.gPesquisausuario);
            this.Controls.Add(this.gUsuario);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FrmUsuario001";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmUsuario001_FormClosing);
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.gPesquisausuario.ResumeLayout(false);
            this.gPesquisausuario.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.gUsuario.ResumeLayout(false);
            this.gUsuario.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFields)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBoxPwdEncripit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox textBoxIdUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdoInativo;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.RadioButton rdoAtivo;
        private System.Windows.Forms.ComboBox comboBoxPerfil;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnImparPesquisa;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gPesquisausuario;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox textBoxPesquisaUsario;
        private System.Windows.Forms.GroupBox gUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPerfil;
        private System.Windows.Forms.ErrorProvider errorProviderFields;
        private Extend.CheckBoxExt checkBoxExt1;
    }
}
