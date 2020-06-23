namespace AppInternacao.FrmSae
{
    partial class UCUsuario
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gUsuario = new System.Windows.Forms.GroupBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.textBoxIdUsuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rdoInativo = new System.Windows.Forms.RadioButton();
            this.rdoAtivo = new System.Windows.Forms.RadioButton();
            this.comboBoxPerfil = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.gPesquisausuario = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.textBoxPesquisaUsario = new System.Windows.Forms.TextBox();
            this.dataGridViewPaciente = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdLeito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeLeito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prontuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Liberar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.gUsuario.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.gPesquisausuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // gUsuario
            // 
            this.gUsuario.BackColor = System.Drawing.SystemColors.Control;
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
            this.gUsuario.Size = new System.Drawing.Size(849, 217);
            this.gUsuario.TabIndex = 0;
            this.gUsuario.TabStop = false;
            this.gUsuario.Text = "Cadastro de Usuários";
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
            this.textBoxIdUsuario.Location = new System.Drawing.Point(6, 174);
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
            this.comboBoxPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPerfil.FormattingEnabled = true;
            this.comboBoxPerfil.Location = new System.Drawing.Point(423, 64);
            this.comboBoxPerfil.Name = "comboBoxPerfil";
            this.comboBoxPerfil.Size = new System.Drawing.Size(215, 28);
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
            this.textBoxSenha.Location = new System.Drawing.Point(432, 104);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Location = new System.Drawing.Point(55, 125);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(309, 1);
            this.panel3.TabIndex = 30;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel6.Location = new System.Drawing.Point(0, -32);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(310, 1);
            this.panel6.TabIndex = 8;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxLogin.Enabled = false;
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxLogin.Location = new System.Drawing.Point(56, 104);
            this.textBoxLogin.MaxLength = 20;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(308, 19);
            this.textBoxLogin.TabIndex = 6;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(54, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 1);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel2.Location = new System.Drawing.Point(0, -32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 1);
            this.panel2.TabIndex = 8;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxEmail.Location = new System.Drawing.Point(55, 64);
            this.textBoxEmail.MaxLength = 40;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(308, 19);
            this.textBoxEmail.TabIndex = 4;
            // 
            // mskTelefone
            // 
            this.mskTelefone.BackColor = System.Drawing.SystemColors.Control;
            this.mskTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mskTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefone.Location = new System.Drawing.Point(661, 27);
            this.mskTelefone.Mask = "(99) 99999-9999";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(151, 19);
            this.mskTelefone.TabIndex = 2;
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
            this.mskCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCpf.Location = new System.Drawing.Point(432, 27);
            this.mskCpf.Mask = "999.999.999-99";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(136, 19);
            this.mskCpf.TabIndex = 1;
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
            this.textBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxNome.Location = new System.Drawing.Point(56, 24);
            this.textBoxNome.MaxLength = 50;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(308, 19);
            this.textBoxNome.TabIndex = 0;
            // 
            // gPesquisausuario
            // 
            this.gPesquisausuario.Controls.Add(this.btnSalvar);
            this.gPesquisausuario.Controls.Add(this.pictureBox1);
            this.gPesquisausuario.Controls.Add(this.panel9);
            this.gPesquisausuario.Controls.Add(this.textBoxPesquisaUsario);
            this.gPesquisausuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.gPesquisausuario.Location = new System.Drawing.Point(0, 217);
            this.gPesquisausuario.Name = "gPesquisausuario";
            this.gPesquisausuario.Size = new System.Drawing.Size(849, 60);
            this.gPesquisausuario.TabIndex = 1;
            this.gPesquisausuario.TabStop = false;
            this.gPesquisausuario.Text = "Pesquisar Usuário por Nome";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.BackgroundImage = global::AppInternacao.Properties.Resources.Childish_Cross_24996;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalvar.Location = new System.Drawing.Point(562, 24);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(29, 24);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::AppInternacao.Properties.Resources.preview_search_find_locate_1551;
            this.pictureBox1.Location = new System.Drawing.Point(17, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 32);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DimGray;
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Location = new System.Drawing.Point(19, 50);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(572, 1);
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
            this.textBoxPesquisaUsario.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.textBoxPesquisaUsario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPesquisaUsario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxPesquisaUsario.Location = new System.Drawing.Point(51, 24);
            this.textBoxPesquisaUsario.MaxLength = 18;
            this.textBoxPesquisaUsario.Name = "textBoxPesquisaUsario";
            this.textBoxPesquisaUsario.Size = new System.Drawing.Size(501, 25);
            this.textBoxPesquisaUsario.TabIndex = 10;
            // 
            // dataGridViewPaciente
            // 
            this.dataGridViewPaciente.AllowUserToAddRows = false;
            this.dataGridViewPaciente.AllowUserToDeleteRows = false;
            this.dataGridViewPaciente.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dataGridViewPaciente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewPaciente.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewPaciente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPaciente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPaciente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.IdLeito,
            this.Nome,
            this.Idade,
            this.Sexo,
            this.NomeLeito,
            this.Prontuario,
            this.Editar,
            this.Liberar});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPaciente.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewPaciente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPaciente.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewPaciente.Location = new System.Drawing.Point(0, 277);
            this.dataGridViewPaciente.Name = "dataGridViewPaciente";
            this.dataGridViewPaciente.ReadOnly = true;
            this.dataGridViewPaciente.RowHeadersVisible = false;
            this.dataGridViewPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPaciente.Size = new System.Drawing.Size(849, 278);
            this.dataGridViewPaciente.TabIndex = 12;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 5;
            // 
            // IdLeito
            // 
            this.IdLeito.DataPropertyName = "IdLeito";
            this.IdLeito.HeaderText = "IdLeito";
            this.IdLeito.Name = "IdLeito";
            this.IdLeito.ReadOnly = true;
            this.IdLeito.Visible = false;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Idade
            // 
            this.Idade.DataPropertyName = "Idade";
            this.Idade.HeaderText = "Idade";
            this.Idade.Name = "Idade";
            this.Idade.ReadOnly = true;
            this.Idade.Visible = false;
            this.Idade.Width = 10;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            this.Sexo.Width = 35;
            // 
            // NomeLeito
            // 
            this.NomeLeito.DataPropertyName = "NomeLeito";
            this.NomeLeito.HeaderText = "Leito";
            this.NomeLeito.Name = "NomeLeito";
            this.NomeLeito.ReadOnly = true;
            this.NomeLeito.Width = 60;
            // 
            // Prontuario
            // 
            this.Prontuario.DataPropertyName = "Prontuario";
            this.Prontuario.HeaderText = "Prontuário";
            this.Prontuario.Name = "Prontuario";
            this.Prontuario.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.Description = "Editar registro";
            this.Editar.HeaderText = "";
            this.Editar.Image = global::AppInternacao.Properties.Resources.file_edit_114433;
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.ToolTipText = "Editar Registro!";
            this.Editar.Width = 30;
            // 
            // Liberar
            // 
            this.Liberar.Description = "Liberar leito";
            this.Liberar.HeaderText = "";
            this.Liberar.Image = global::AppInternacao.Properties.Resources.liberar;
            this.Liberar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Liberar.Name = "Liberar";
            this.Liberar.ReadOnly = true;
            this.Liberar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Liberar.ToolTipText = "Liberar Leito!";
            this.Liberar.Width = 30;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.Description = "Editar registro";
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::AppInternacao.Properties.Resources.file_edit_114433;
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
            this.dataGridViewImageColumn2.Image = global::AppInternacao.Properties.Resources.liberar;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.ToolTipText = "Liberar Leito!";
            this.dataGridViewImageColumn2.Width = 30;
            // 
            // UCUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.dataGridViewPaciente);
            this.Controls.Add(this.gPesquisausuario);
            this.Controls.Add(this.gUsuario);
            this.Name = "UCUsuario";
            this.Size = new System.Drawing.Size(849, 555);
            this.Load += new System.EventHandler(this.UCUsuario_Load);
            this.gUsuario.ResumeLayout(false);
            this.gUsuario.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.gPesquisausuario.ResumeLayout(false);
            this.gPesquisausuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaciente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gUsuario;
        private System.Windows.Forms.TextBox textBoxIdUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdoInativo;
        private System.Windows.Forms.RadioButton rdoAtivo;
        private System.Windows.Forms.ComboBox comboBoxPerfil;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.GroupBox gPesquisausuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox textBoxPesquisaUsario;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dataGridViewPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLeito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeLeito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prontuario;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Liberar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel8;
    }
}
