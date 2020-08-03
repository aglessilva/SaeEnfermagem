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
            FrmMain.myImprimir.Click -= new EventHandler(MyImprimir_Click);
            FrmMain.myNovo.Click -= new EventHandler(MyNovo_Click);
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPaciente));
            this.textBoxIdPaciente = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridViewPaciente = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeLeito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prontuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.textBoxPesquisaPaciente = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.printDocumentCracha = new System.Drawing.Printing.PrintDocument();
            this.textBoxPaciente = new System.Windows.Forms.TextBox();
            this.textBoxIdade = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.lblRotulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textProntuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBoxQuarto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBoxSetor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxLeito = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAddPicture = new System.Windows.Forms.Button();
            this.panelCracha = new System.Windows.Forms.Panel();
            this.pbBarcodeCracha = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxImgCracha = new System.Windows.Forms.PictureBox();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.textBoxLeitoCracha = new System.Windows.Forms.TextBox();
            this.textBoxIdadeCracha = new System.Windows.Forms.TextBox();
            this.textBoxDataCracha = new System.Windows.Forms.TextBox();
            this.textBoxNomeCrachar = new System.Windows.Forms.TextBox();
            this.textBoxProntuarioCracha = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxEstruturaFisica = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaciente)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelCracha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarcodeCracha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImgCracha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxIdPaciente
            // 
            this.textBoxIdPaciente.Location = new System.Drawing.Point(579, 26);
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
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dataGridViewPaciente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewPaciente.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewPaciente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPaciente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPaciente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Idade,
            this.NomeLeito,
            this.Sexo,
            this.Prontuario,
            this.Editar});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPaciente.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewPaciente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPaciente.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewPaciente.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPaciente.Name = "dataGridViewPaciente";
            this.dataGridViewPaciente.ReadOnly = true;
            this.dataGridViewPaciente.RowHeadersVisible = false;
            this.dataGridViewPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPaciente.Size = new System.Drawing.Size(924, 259);
            this.dataGridViewPaciente.TabIndex = 16;
            this.dataGridViewPaciente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPaciente_CellContentClick);
            this.dataGridViewPaciente.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewPaciente_RowsAdded);
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
            // Idade
            // 
            this.Idade.DataPropertyName = "Idade";
            this.Idade.HeaderText = "Idade";
            this.Idade.Name = "Idade";
            this.Idade.ReadOnly = true;
            this.Idade.Visible = false;
            this.Idade.Width = 10;
            // 
            // NomeLeito
            // 
            this.NomeLeito.DataPropertyName = "NomeLeito";
            this.NomeLeito.HeaderText = "Leito";
            this.NomeLeito.Name = "NomeLeito";
            this.NomeLeito.ReadOnly = true;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            this.Sexo.Width = 35;
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
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.ToolTipText = "Editar Registro!";
            this.Editar.Width = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.textBoxIdPaciente);
            this.groupBox2.Controls.Add(this.buttonLimpar);
            this.groupBox2.Controls.Add(this.textBoxPesquisaPaciente);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 324);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(924, 56);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisa por Nome do paciente";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.panel5.Location = new System.Drawing.Point(9, 40);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(432, 1);
            this.panel5.TabIndex = 20;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.Color.Transparent;
            this.buttonLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLimpar.BackgroundImage")));
            this.buttonLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonLimpar.FlatAppearance.BorderSize = 0;
            this.buttonLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.buttonLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLimpar.Location = new System.Drawing.Point(415, 19);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(26, 20);
            this.buttonLimpar.TabIndex = 1;
            this.buttonLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // textBoxPesquisaPaciente
            // 
            this.textBoxPesquisaPaciente.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxPesquisaPaciente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPesquisaPaciente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxPesquisaPaciente.Location = new System.Drawing.Point(36, 26);
            this.textBoxPesquisaPaciente.Name = "textBoxPesquisaPaciente";
            this.textBoxPesquisaPaciente.Size = new System.Drawing.Size(373, 13);
            this.textBoxPesquisaPaciente.TabIndex = 2;
            this.textBoxPesquisaPaciente.TextChanged += new System.EventHandler(this.textBoxPesquisaPaciente_TextChanged);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.dataGridViewPaciente);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 380);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(924, 259);
            this.panel2.TabIndex = 18;
            // 
            // printDocumentCracha
            // 
            this.printDocumentCracha.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentCracha_PrintPage);
            // 
            // textBoxPaciente
            // 
            this.textBoxPaciente.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxPaciente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPaciente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxPaciente.Location = new System.Drawing.Point(40, 50);
            this.textBoxPaciente.Name = "textBoxPaciente";
            this.textBoxPaciente.Size = new System.Drawing.Size(395, 13);
            this.textBoxPaciente.TabIndex = 0;
            this.textBoxPaciente.TextChanged += new System.EventHandler(this.textBoxPaciente_TextChanged);
            // 
            // textBoxIdade
            // 
            this.textBoxIdade.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxIdade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIdade.Location = new System.Drawing.Point(9, 92);
            this.textBoxIdade.MaxLength = 2;
            this.textBoxIdade.Name = "textBoxIdade";
            this.textBoxIdade.Size = new System.Drawing.Size(51, 13);
            this.textBoxIdade.TabIndex = 1;
            this.textBoxIdade.TextChanged += new System.EventHandler(this.textBoxIdade_TextChanged);
            this.textBoxIdade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdade_KeyPress);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 148);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Masculino";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 118);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Fermino";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // lblRotulo
            // 
            this.lblRotulo.AutoSize = true;
            this.lblRotulo.Location = new System.Drawing.Point(6, 23);
            this.lblRotulo.Name = "lblRotulo";
            this.lblRotulo.Size = new System.Drawing.Size(35, 13);
            this.lblRotulo.TabIndex = 6;
            this.lblRotulo.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Idade";
            // 
            // textProntuario
            // 
            this.textProntuario.BackColor = System.Drawing.SystemColors.Control;
            this.textProntuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textProntuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textProntuario.Enabled = false;
            this.textProntuario.Location = new System.Drawing.Point(36, 209);
            this.textProntuario.Name = "textProntuario";
            this.textProntuario.Size = new System.Drawing.Size(182, 13);
            this.textProntuario.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "NÚMERO DE PRONTUÁRIO DO PACIENTE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(9, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 1);
            this.panel1.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(9, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(55, 1);
            this.panel3.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.comboBoxEstruturaFisica);
            this.groupBox1.Controls.Add(this.panel8);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Controls.Add(this.textBoxQuarto);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.textBoxSetor);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.textBoxLeito);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btnAddPicture);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.panelCracha);
            this.groupBox1.Controls.Add(this.textProntuario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblRotulo);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.textBoxIdade);
            this.groupBox1.Controls.Add(this.textBoxPaciente);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(924, 324);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro resumido de paciente";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DimGray;
            this.panel8.Location = new System.Drawing.Point(193, 107);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(99, 1);
            this.panel8.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(190, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Quarto";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DimGray;
            this.panel7.Location = new System.Drawing.Point(303, 107);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(138, 1);
            this.panel7.TabIndex = 24;
            // 
            // textBoxQuarto
            // 
            this.textBoxQuarto.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxQuarto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxQuarto.Location = new System.Drawing.Point(193, 92);
            this.textBoxQuarto.MaxLength = 2;
            this.textBoxQuarto.Name = "textBoxQuarto";
            this.textBoxQuarto.Size = new System.Drawing.Size(95, 13);
            this.textBoxQuarto.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(302, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Unidade Funcional";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DimGray;
            this.panel6.Location = new System.Drawing.Point(81, 107);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(99, 1);
            this.panel6.TabIndex = 21;
            // 
            // textBoxSetor
            // 
            this.textBoxSetor.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxSetor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSetor.Location = new System.Drawing.Point(305, 92);
            this.textBoxSetor.MaxLength = 2;
            this.textBoxSetor.Name = "textBoxSetor";
            this.textBoxSetor.Size = new System.Drawing.Size(134, 13);
            this.textBoxSetor.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(78, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Leito";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AppInternacao.Properties.Resources.Barcode_27025;
            this.pictureBox2.Location = new System.Drawing.Point(3, 198);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // textBoxLeito
            // 
            this.textBoxLeito.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxLeito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLeito.Location = new System.Drawing.Point(81, 92);
            this.textBoxLeito.MaxLength = 2;
            this.textBoxLeito.Name = "textBoxLeito";
            this.textBoxLeito.Size = new System.Drawing.Size(95, 13);
            this.textBoxLeito.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Location = new System.Drawing.Point(9, 223);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 1);
            this.panel4.TabIndex = 19;
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.FlatAppearance.BorderSize = 0;
            this.btnAddPicture.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnAddPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPicture.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPicture.Image")));
            this.btnAddPicture.Location = new System.Drawing.Point(7, 232);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(107, 87);
            this.btnAddPicture.TabIndex = 9;
            this.btnAddPicture.Text = "Adicionar/Remover";
            this.btnAddPicture.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddPicture.UseVisualStyleBackColor = true;
            this.btnAddPicture.Click += new System.EventHandler(this.btnAddPicture_Click);
            // 
            // panelCracha
            // 
            this.panelCracha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCracha.BackColor = System.Drawing.Color.Transparent;
            this.panelCracha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelCracha.BackgroundImage")));
            this.panelCracha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelCracha.Controls.Add(this.pbBarcodeCracha);
            this.panelCracha.Controls.Add(this.label8);
            this.panelCracha.Controls.Add(this.label7);
            this.panelCracha.Controls.Add(this.label6);
            this.panelCracha.Controls.Add(this.label5);
            this.panelCracha.Controls.Add(this.label2);
            this.panelCracha.Controls.Add(this.pictureBoxImgCracha);
            this.panelCracha.Controls.Add(this.textBoxCliente);
            this.panelCracha.Controls.Add(this.textBoxLeitoCracha);
            this.panelCracha.Controls.Add(this.textBoxIdadeCracha);
            this.panelCracha.Controls.Add(this.textBoxDataCracha);
            this.panelCracha.Controls.Add(this.textBoxNomeCrachar);
            this.panelCracha.Controls.Add(this.textBoxProntuarioCracha);
            this.panelCracha.Location = new System.Drawing.Point(496, 23);
            this.panelCracha.Name = "panelCracha";
            this.panelCracha.Size = new System.Drawing.Size(413, 273);
            this.panelCracha.TabIndex = 15;
            // 
            // pbBarcodeCracha
            // 
            this.pbBarcodeCracha.Image = ((System.Drawing.Image)(resources.GetObject("pbBarcodeCracha.Image")));
            this.pbBarcodeCracha.Location = new System.Drawing.Point(139, 168);
            this.pbBarcodeCracha.Name = "pbBarcodeCracha";
            this.pbBarcodeCracha.Size = new System.Drawing.Size(233, 98);
            this.pbBarcodeCracha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBarcodeCracha.TabIndex = 22;
            this.pbBarcodeCracha.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Prontuario:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(249, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Data:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Leito:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Idade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nome:";
            // 
            // pictureBoxImgCracha
            // 
            this.pictureBoxImgCracha.BackColor = System.Drawing.Color.White;
            this.pictureBoxImgCracha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImgCracha.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxImgCracha.Image")));
            this.pictureBoxImgCracha.Location = new System.Drawing.Point(14, 16);
            this.pictureBoxImgCracha.Name = "pictureBoxImgCracha";
            this.pictureBoxImgCracha.Size = new System.Drawing.Size(119, 129);
            this.pictureBoxImgCracha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImgCracha.TabIndex = 31;
            this.pictureBoxImgCracha.TabStop = false;
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.BackColor = System.Drawing.Color.White;
            this.textBoxCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCliente.ForeColor = System.Drawing.Color.Black;
            this.textBoxCliente.Location = new System.Drawing.Point(134, 57);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.ReadOnly = true;
            this.textBoxCliente.Size = new System.Drawing.Size(272, 11);
            this.textBoxCliente.TabIndex = 30;
            this.textBoxCliente.TabStop = false;
            this.textBoxCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCliente.WordWrap = false;
            // 
            // textBoxLeitoCracha
            // 
            this.textBoxLeitoCracha.BackColor = System.Drawing.Color.White;
            this.textBoxLeitoCracha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLeitoCracha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxLeitoCracha.Location = new System.Drawing.Point(9, 231);
            this.textBoxLeitoCracha.Name = "textBoxLeitoCracha";
            this.textBoxLeitoCracha.ReadOnly = true;
            this.textBoxLeitoCracha.Size = new System.Drawing.Size(130, 13);
            this.textBoxLeitoCracha.TabIndex = 26;
            this.textBoxLeitoCracha.TabStop = false;
            // 
            // textBoxIdadeCracha
            // 
            this.textBoxIdadeCracha.BackColor = System.Drawing.Color.White;
            this.textBoxIdadeCracha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIdadeCracha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxIdadeCracha.Location = new System.Drawing.Point(177, 130);
            this.textBoxIdadeCracha.Name = "textBoxIdadeCracha";
            this.textBoxIdadeCracha.ReadOnly = true;
            this.textBoxIdadeCracha.Size = new System.Drawing.Size(48, 13);
            this.textBoxIdadeCracha.TabIndex = 25;
            this.textBoxIdadeCracha.TabStop = false;
            // 
            // textBoxDataCracha
            // 
            this.textBoxDataCracha.BackColor = System.Drawing.Color.White;
            this.textBoxDataCracha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDataCracha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxDataCracha.Location = new System.Drawing.Point(288, 130);
            this.textBoxDataCracha.Name = "textBoxDataCracha";
            this.textBoxDataCracha.ReadOnly = true;
            this.textBoxDataCracha.Size = new System.Drawing.Size(84, 13);
            this.textBoxDataCracha.TabIndex = 27;
            this.textBoxDataCracha.TabStop = false;
            // 
            // textBoxNomeCrachar
            // 
            this.textBoxNomeCrachar.BackColor = System.Drawing.Color.White;
            this.textBoxNomeCrachar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNomeCrachar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNomeCrachar.Location = new System.Drawing.Point(182, 98);
            this.textBoxNomeCrachar.Name = "textBoxNomeCrachar";
            this.textBoxNomeCrachar.ReadOnly = true;
            this.textBoxNomeCrachar.Size = new System.Drawing.Size(217, 13);
            this.textBoxNomeCrachar.TabIndex = 24;
            this.textBoxNomeCrachar.TabStop = false;
            // 
            // textBoxProntuarioCracha
            // 
            this.textBoxProntuarioCracha.BackColor = System.Drawing.Color.White;
            this.textBoxProntuarioCracha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProntuarioCracha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxProntuarioCracha.Location = new System.Drawing.Point(9, 193);
            this.textBoxProntuarioCracha.Name = "textBoxProntuarioCracha";
            this.textBoxProntuarioCracha.ReadOnly = true;
            this.textBoxProntuarioCracha.Size = new System.Drawing.Size(127, 13);
            this.textBoxProntuarioCracha.TabIndex = 28;
            this.textBoxProntuarioCracha.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(190, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Estrutura Física";
            // 
            // comboBoxEstruturaFisica
            // 
            this.comboBoxEstruturaFisica.DisplayMember = "Nome";
            this.comboBoxEstruturaFisica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstruturaFisica.FormattingEnabled = true;
            this.comboBoxEstruturaFisica.Location = new System.Drawing.Point(193, 138);
            this.comboBoxEstruturaFisica.Name = "comboBoxEstruturaFisica";
            this.comboBoxEstruturaFisica.Size = new System.Drawing.Size(242, 21);
            this.comboBoxEstruturaFisica.TabIndex = 7;
            this.comboBoxEstruturaFisica.ValueMember = "Id";
            // 
            // UCPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "UCPaciente";
            this.Size = new System.Drawing.Size(924, 639);
            this.Load += new System.EventHandler(this.UCPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaciente)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelCracha.ResumeLayout(false);
            this.panelCracha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarcodeCracha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImgCracha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewPaciente;
        private System.Windows.Forms.TextBox textBoxIdPaciente;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxPesquisaPaciente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idade;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeLeito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prontuario;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Drawing.Printing.PrintDocument printDocumentCracha;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddPicture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelCracha;
        private System.Windows.Forms.PictureBox pbBarcodeCracha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxImgCracha;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.TextBox textBoxLeitoCracha;
        private System.Windows.Forms.TextBox textBoxIdadeCracha;
        private System.Windows.Forms.TextBox textBoxDataCracha;
        private System.Windows.Forms.TextBox textBoxNomeCrachar;
        private System.Windows.Forms.TextBox textBoxProntuarioCracha;
        private System.Windows.Forms.TextBox textProntuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRotulo;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBoxIdade;
        private System.Windows.Forms.TextBox textBoxPaciente;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBoxSetor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxLeito;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxQuarto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxEstruturaFisica;
    }
}
