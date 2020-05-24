using System;

namespace AppInternacao.FrmSae
{
    partial class UCPaciente
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

            FrmMain.mySalvar.Click -= new EventHandler(Salvar);
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxProntuario = new System.Windows.Forms.TextBox();
            this.comboBoxLeito = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRotulo = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBoxIdade = new System.Windows.Forms.TextBox();
            this.textBoxPaciente = new System.Windows.Forms.TextBox();
            this.textBoxIdPaciente = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridViewPaciente = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.pbBarcodeCracha = new System.Windows.Forms.PictureBox();
            this.textBoxLeitoCracha = new System.Windows.Forms.TextBox();
            this.textBoxIdadeCracha = new System.Windows.Forms.TextBox();
            this.textBoxProntuarioCracha = new System.Windows.Forms.TextBox();
            this.textBoxDataCracha = new System.Windows.Forms.TextBox();
            this.textBoxNomeCrachar = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdLeito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeLeito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prontuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Liberar = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaciente)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarcodeCracha)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxProntuario);
            this.groupBox1.Controls.Add(this.comboBoxLeito);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblRotulo);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.textBoxIdade);
            this.groupBox1.Controls.Add(this.textBoxPaciente);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(924, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro resumido de paciente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(577, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "NÚMERO DE PRONTUÁRIO DO PACIENTE";
            // 
            // textBoxProntuario
            // 
            this.textBoxProntuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxProntuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxProntuario.Enabled = false;
            this.textBoxProntuario.Location = new System.Drawing.Point(580, 32);
            this.textBoxProntuario.Name = "textBoxProntuario";
            this.textBoxProntuario.Size = new System.Drawing.Size(220, 20);
            this.textBoxProntuario.TabIndex = 10;
            // 
            // comboBoxLeito
            // 
            this.comboBoxLeito.DisplayMember = "NomeLeito";
            this.comboBoxLeito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLeito.FormattingEnabled = true;
            this.comboBoxLeito.Location = new System.Drawing.Point(425, 31);
            this.comboBoxLeito.Name = "comboBoxLeito";
            this.comboBoxLeito.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLeito.TabIndex = 9;
            this.comboBoxLeito.ValueMember = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Leito";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Idade";
            // 
            // lblRotulo
            // 
            this.lblRotulo.AutoSize = true;
            this.lblRotulo.Location = new System.Drawing.Point(3, 16);
            this.lblRotulo.Name = "lblRotulo";
            this.lblRotulo.Size = new System.Drawing.Size(35, 13);
            this.lblRotulo.TabIndex = 6;
            this.lblRotulo.Text = "Nome";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 58);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Fermino";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(74, 58);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Masculino";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBoxIdade
            // 
            this.textBoxIdade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxIdade.Location = new System.Drawing.Point(340, 32);
            this.textBoxIdade.MaxLength = 2;
            this.textBoxIdade.Name = "textBoxIdade";
            this.textBoxIdade.Size = new System.Drawing.Size(51, 20);
            this.textBoxIdade.TabIndex = 1;
            this.textBoxIdade.TextChanged += new System.EventHandler(this.textBoxIdade_TextChanged);
            this.textBoxIdade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdade_KeyPress);
            // 
            // textBoxPaciente
            // 
            this.textBoxPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPaciente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxPaciente.Location = new System.Drawing.Point(6, 32);
            this.textBoxPaciente.Name = "textBoxPaciente";
            this.textBoxPaciente.Size = new System.Drawing.Size(298, 20);
            this.textBoxPaciente.TabIndex = 0;
            this.textBoxPaciente.TextChanged += new System.EventHandler(this.textBoxPaciente_TextChanged);
            // 
            // textBoxIdPaciente
            // 
            this.textBoxIdPaciente.Location = new System.Drawing.Point(6, 95);
            this.textBoxIdPaciente.Name = "textBoxIdPaciente";
            this.textBoxIdPaciente.Size = new System.Drawing.Size(23, 20);
            this.textBoxIdPaciente.TabIndex = 13;
            this.textBoxIdPaciente.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridViewPaciente
            // 
            this.dataGridViewPaciente.AllowUserToAddRows = false;
            this.dataGridViewPaciente.AllowUserToDeleteRows = false;
            this.dataGridViewPaciente.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dataGridViewPaciente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewPaciente.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewPaciente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPaciente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPaciente.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPaciente.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewPaciente.Location = new System.Drawing.Point(8, 121);
            this.dataGridViewPaciente.Name = "dataGridViewPaciente";
            this.dataGridViewPaciente.ReadOnly = true;
            this.dataGridViewPaciente.RowHeadersVisible = false;
            this.dataGridViewPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPaciente.Size = new System.Drawing.Size(405, 490);
            this.dataGridViewPaciente.TabIndex = 16;
            this.dataGridViewPaciente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPaciente_CellContentClick);
            this.dataGridViewPaciente.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewPaciente_RowsAdded);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 13;
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::AppInternacao.Properties.Resources.CrachaLayOut;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBoxCliente);
            this.panel1.Controls.Add(this.pbBarcodeCracha);
            this.panel1.Controls.Add(this.textBoxLeitoCracha);
            this.panel1.Controls.Add(this.textBoxIdadeCracha);
            this.panel1.Controls.Add(this.textBoxProntuarioCracha);
            this.panel1.Controls.Add(this.textBoxDataCracha);
            this.panel1.Controls.Add(this.textBoxNomeCrachar);
            this.panel1.Location = new System.Drawing.Point(445, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 328);
            this.panel1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::AppInternacao.Properties.Resources.user0;
            this.pictureBox1.Location = new System.Drawing.Point(45, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(180)))), ((int)(((byte)(231)))));
            this.textBoxCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCliente.ForeColor = System.Drawing.Color.White;
            this.textBoxCliente.Location = new System.Drawing.Point(180, 93);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.ReadOnly = true;
            this.textBoxCliente.Size = new System.Drawing.Size(260, 11);
            this.textBoxCliente.TabIndex = 30;
            // 
            // pbBarcodeCracha
            // 
            this.pbBarcodeCracha.Image = global::AppInternacao.Properties.Resources.barcode;
            this.pbBarcodeCracha.Location = new System.Drawing.Point(273, 235);
            this.pbBarcodeCracha.Name = "pbBarcodeCracha";
            this.pbBarcodeCracha.Size = new System.Drawing.Size(183, 75);
            this.pbBarcodeCracha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBarcodeCracha.TabIndex = 22;
            this.pbBarcodeCracha.TabStop = false;
            // 
            // textBoxLeitoCracha
            // 
            this.textBoxLeitoCracha.BackColor = System.Drawing.Color.White;
            this.textBoxLeitoCracha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLeitoCracha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxLeitoCracha.Location = new System.Drawing.Point(150, 242);
            this.textBoxLeitoCracha.Name = "textBoxLeitoCracha";
            this.textBoxLeitoCracha.ReadOnly = true;
            this.textBoxLeitoCracha.Size = new System.Drawing.Size(108, 13);
            this.textBoxLeitoCracha.TabIndex = 26;
            // 
            // textBoxIdadeCracha
            // 
            this.textBoxIdadeCracha.BackColor = System.Drawing.Color.White;
            this.textBoxIdadeCracha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIdadeCracha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxIdadeCracha.Location = new System.Drawing.Point(40, 242);
            this.textBoxIdadeCracha.Name = "textBoxIdadeCracha";
            this.textBoxIdadeCracha.ReadOnly = true;
            this.textBoxIdadeCracha.Size = new System.Drawing.Size(48, 13);
            this.textBoxIdadeCracha.TabIndex = 25;
            // 
            // textBoxProntuarioCracha
            // 
            this.textBoxProntuarioCracha.BackColor = System.Drawing.Color.White;
            this.textBoxProntuarioCracha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProntuarioCracha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxProntuarioCracha.Location = new System.Drawing.Point(150, 292);
            this.textBoxProntuarioCracha.Name = "textBoxProntuarioCracha";
            this.textBoxProntuarioCracha.ReadOnly = true;
            this.textBoxProntuarioCracha.Size = new System.Drawing.Size(110, 13);
            this.textBoxProntuarioCracha.TabIndex = 28;
            // 
            // textBoxDataCracha
            // 
            this.textBoxDataCracha.BackColor = System.Drawing.Color.White;
            this.textBoxDataCracha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDataCracha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxDataCracha.Location = new System.Drawing.Point(40, 292);
            this.textBoxDataCracha.Name = "textBoxDataCracha";
            this.textBoxDataCracha.ReadOnly = true;
            this.textBoxDataCracha.Size = new System.Drawing.Size(62, 13);
            this.textBoxDataCracha.TabIndex = 27;
            // 
            // textBoxNomeCrachar
            // 
            this.textBoxNomeCrachar.BackColor = System.Drawing.Color.White;
            this.textBoxNomeCrachar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNomeCrachar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNomeCrachar.Location = new System.Drawing.Point(184, 167);
            this.textBoxNomeCrachar.Name = "textBoxNomeCrachar";
            this.textBoxNomeCrachar.ReadOnly = true;
            this.textBoxNomeCrachar.Size = new System.Drawing.Size(271, 13);
            this.textBoxNomeCrachar.TabIndex = 24;
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
            // UCPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.textBoxIdPaciente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewPaciente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "UCPaciente";
            this.Size = new System.Drawing.Size(924, 611);
            this.Load += new System.EventHandler(this.UCPaciente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaciente)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarcodeCracha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRotulo;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBoxIdade;
        private System.Windows.Forms.TextBox textBoxPaciente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxProntuarioCracha;
        private System.Windows.Forms.TextBox textBoxDataCracha;
        private System.Windows.Forms.TextBox textBoxLeitoCracha;
        private System.Windows.Forms.TextBox textBoxIdadeCracha;
        private System.Windows.Forms.TextBox textBoxNomeCrachar;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbBarcodeCracha;
        private System.Windows.Forms.TextBox textBoxProntuario;
        private System.Windows.Forms.ComboBox comboBoxLeito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewPaciente;
        private System.Windows.Forms.TextBox textBoxIdPaciente;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLeito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeLeito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prontuario;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Liberar;
    }
}
