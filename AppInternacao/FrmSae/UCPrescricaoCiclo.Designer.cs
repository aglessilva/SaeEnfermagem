namespace AppInternacao.FrmSae
{
    partial class UCPrescricaoCiclo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewPrescricoes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CalendarCicloPrescricao = new System.Windows.Forms.MonthCalendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pNamePrescricao = new System.Windows.Forms.Panel();
            this.btnCancelaPrescricao = new System.Windows.Forms.Button();
            this.lblContaCaracter = new System.Windows.Forms.Label();
            this.btnCriarPrescricao = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblRotulo = new System.Windows.Forms.Label();
            this.textBoxNomePrescricao = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCicloPrescricao = new System.Windows.Forms.Label();
            this.btnAddCiclo = new System.Windows.Forms.Button();
            this.gDadosPaciente = new System.Windows.Forms.GroupBox();
            this.lblTotalPrescricao = new System.Windows.Forms.Label();
            this.comboBoxDataPrescricao = new System.Windows.Forms.ComboBox();
            this.lblLeito = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblProntuario = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNewLine = new System.Windows.Forms.Button();
            this.btnRemoveDia = new System.Windows.Forms.Button();
            this.btnAddDia = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrescricoes)).BeginInit();
            this.panel1.SuspendLayout();
            this.pNamePrescricao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gDadosPaciente.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPrescricoes
            // 
            this.dataGridViewPrescricoes.AllowUserToAddRows = false;
            this.dataGridViewPrescricoes.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            this.dataGridViewPrescricoes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewPrescricoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrescricoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPrescricoes.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewPrescricoes.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPrescricoes.Name = "dataGridViewPrescricoes";
            this.dataGridViewPrescricoes.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewPrescricoes.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewPrescricoes.RowTemplate.Height = 40;
            this.dataGridViewPrescricoes.Size = new System.Drawing.Size(773, 350);
            this.dataGridViewPrescricoes.TabIndex = 17;
            this.dataGridViewPrescricoes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPrescricoes_CellContentClick);
            this.dataGridViewPrescricoes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPrescricoes_CellContentDoubleClick);
            this.dataGridViewPrescricoes.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPrescricoes_CellEndEdit);
            this.dataGridViewPrescricoes.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPrescricoes_CellEnter);
            this.dataGridViewPrescricoes.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewPrescricoes_DataError);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Periodo para Pescrição";
            // 
            // CalendarCicloPrescricao
            // 
            this.CalendarCicloPrescricao.BackColor = System.Drawing.SystemColors.Window;
            this.CalendarCicloPrescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalendarCicloPrescricao.Location = new System.Drawing.Point(9, 21);
            this.CalendarCicloPrescricao.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.CalendarCicloPrescricao.MaxSelectionCount = 30;
            this.CalendarCicloPrescricao.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.CalendarCicloPrescricao.Name = "CalendarCicloPrescricao";
            this.CalendarCicloPrescricao.TabIndex = 0;
            this.CalendarCicloPrescricao.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.CalendarCicloPrescricao_DateSelected);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotalPrescricao);
            this.panel1.Controls.Add(this.pNamePrescricao);
            this.panel1.Controls.Add(this.comboBoxDataPrescricao);
            this.panel1.Controls.Add(this.lblCicloPrescricao);
            this.panel1.Controls.Add(this.btnAddCiclo);
            this.panel1.Controls.Add(this.gDadosPaciente);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CalendarCicloPrescricao);
            this.panel1.Controls.Add(this.btnNewLine);
            this.panel1.Controls.Add(this.btnRemoveDia);
            this.panel1.Controls.Add(this.btnAddDia);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 198);
            this.panel1.TabIndex = 23;
            // 
            // pNamePrescricao
            // 
            this.pNamePrescricao.Controls.Add(this.btnCancelaPrescricao);
            this.pNamePrescricao.Controls.Add(this.lblContaCaracter);
            this.pNamePrescricao.Controls.Add(this.btnCriarPrescricao);
            this.pNamePrescricao.Controls.Add(this.panel3);
            this.pNamePrescricao.Controls.Add(this.lblRotulo);
            this.pNamePrescricao.Controls.Add(this.textBoxNomePrescricao);
            this.pNamePrescricao.Controls.Add(this.pictureBox1);
            this.pNamePrescricao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pNamePrescricao.Location = new System.Drawing.Point(0, 0);
            this.pNamePrescricao.Name = "pNamePrescricao";
            this.pNamePrescricao.Size = new System.Drawing.Size(773, 198);
            this.pNamePrescricao.TabIndex = 11;
            this.pNamePrescricao.Visible = false;
            // 
            // btnCancelaPrescricao
            // 
            this.btnCancelaPrescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnCancelaPrescricao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelaPrescricao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelaPrescricao.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnCancelaPrescricao.FlatAppearance.BorderSize = 2;
            this.btnCancelaPrescricao.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelaPrescricao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btnCancelaPrescricao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelaPrescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCancelaPrescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelaPrescricao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelaPrescricao.Location = new System.Drawing.Point(225, 121);
            this.btnCancelaPrescricao.Name = "btnCancelaPrescricao";
            this.btnCancelaPrescricao.Size = new System.Drawing.Size(169, 30);
            this.btnCancelaPrescricao.TabIndex = 27;
            this.btnCancelaPrescricao.TabStop = false;
            this.btnCancelaPrescricao.Text = "Cancelar prescrição";
            this.btnCancelaPrescricao.UseVisualStyleBackColor = false;
            this.btnCancelaPrescricao.Click += new System.EventHandler(this.btnCancelaPrescricao_Click);
            // 
            // lblContaCaracter
            // 
            this.lblContaCaracter.AutoSize = true;
            this.lblContaCaracter.Location = new System.Drawing.Point(228, 97);
            this.lblContaCaracter.Name = "lblContaCaracter";
            this.lblContaCaracter.Size = new System.Drawing.Size(125, 13);
            this.lblContaCaracter.TabIndex = 26;
            this.lblContaCaracter.Text = "Mínimo de 10 caracteres";
            // 
            // btnCriarPrescricao
            // 
            this.btnCriarPrescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnCriarPrescricao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCriarPrescricao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriarPrescricao.Enabled = false;
            this.btnCriarPrescricao.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnCriarPrescricao.FlatAppearance.BorderSize = 2;
            this.btnCriarPrescricao.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCriarPrescricao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btnCriarPrescricao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarPrescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCriarPrescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCriarPrescricao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCriarPrescricao.Location = new System.Drawing.Point(417, 121);
            this.btnCriarPrescricao.Name = "btnCriarPrescricao";
            this.btnCriarPrescricao.Size = new System.Drawing.Size(169, 30);
            this.btnCriarPrescricao.TabIndex = 25;
            this.btnCriarPrescricao.TabStop = false;
            this.btnCriarPrescricao.Text = "Criar nova prescrição";
            this.btnCriarPrescricao.UseVisualStyleBackColor = false;
            this.btnCriarPrescricao.Click += new System.EventHandler(this.btnCriarPrescricao_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(228, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(468, 1);
            this.panel3.TabIndex = 23;
            // 
            // lblRotulo
            // 
            this.lblRotulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRotulo.AutoSize = true;
            this.lblRotulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblRotulo.Location = new System.Drawing.Point(228, 42);
            this.lblRotulo.Name = "lblRotulo";
            this.lblRotulo.Size = new System.Drawing.Size(255, 17);
            this.lblRotulo.TabIndex = 22;
            this.lblRotulo.Text = "Informe um nome para nova prescrição";
            // 
            // textBoxNomePrescricao
            // 
            this.textBoxNomePrescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNomePrescricao.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxNomePrescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNomePrescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNomePrescricao.Location = new System.Drawing.Point(273, 76);
            this.textBoxNomePrescricao.MaxLength = 50;
            this.textBoxNomePrescricao.Name = "textBoxNomePrescricao";
            this.textBoxNomePrescricao.Size = new System.Drawing.Size(468, 13);
            this.textBoxNomePrescricao.TabIndex = 21;
            this.textBoxNomePrescricao.WordWrap = false;
            this.textBoxNomePrescricao.TextChanged += new System.EventHandler(this.textBoxNomePrescricao_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppInternacao.Properties.Resources.Documents;
            this.pictureBox1.Location = new System.Drawing.Point(225, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // lblCicloPrescricao
            // 
            this.lblCicloPrescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCicloPrescricao.AutoSize = true;
            this.lblCicloPrescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCicloPrescricao.ForeColor = System.Drawing.Color.Navy;
            this.lblCicloPrescricao.Location = new System.Drawing.Point(245, 154);
            this.lblCicloPrescricao.Name = "lblCicloPrescricao";
            this.lblCicloPrescricao.Size = new System.Drawing.Size(13, 16);
            this.lblCicloPrescricao.TabIndex = 49;
            this.lblCicloPrescricao.Text = "-";
            this.lblCicloPrescricao.Visible = false;
            // 
            // btnAddCiclo
            // 
            this.btnAddCiclo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnAddCiclo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddCiclo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCiclo.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAddCiclo.FlatAppearance.BorderSize = 0;
            this.btnAddCiclo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddCiclo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btnAddCiclo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCiclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnAddCiclo.ForeColor = System.Drawing.Color.White;
            this.btnAddCiclo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCiclo.Location = new System.Drawing.Point(248, 85);
            this.btnAddCiclo.Name = "btnAddCiclo";
            this.btnAddCiclo.Size = new System.Drawing.Size(146, 42);
            this.btnAddCiclo.TabIndex = 0;
            this.btnAddCiclo.TabStop = false;
            this.btnAddCiclo.Text = "Promover Ciclo";
            this.btnAddCiclo.UseVisualStyleBackColor = false;
            this.btnAddCiclo.Visible = false;
            this.btnAddCiclo.Click += new System.EventHandler(this.btnAddCiclo_Click);
            // 
            // gDadosPaciente
            // 
            this.gDadosPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gDadosPaciente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gDadosPaciente.Controls.Add(this.lblLeito);
            this.gDadosPaciente.Controls.Add(this.lblIdade);
            this.gDadosPaciente.Controls.Add(this.lblProntuario);
            this.gDadosPaciente.Controls.Add(this.lblNome);
            this.gDadosPaciente.Controls.Add(this.label6);
            this.gDadosPaciente.Controls.Add(this.label2);
            this.gDadosPaciente.Controls.Add(this.label5);
            this.gDadosPaciente.Controls.Add(this.label4);
            this.gDadosPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gDadosPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.gDadosPaciente.Location = new System.Drawing.Point(703, 15);
            this.gDadosPaciente.Name = "gDadosPaciente";
            this.gDadosPaciente.Size = new System.Drawing.Size(58, 112);
            this.gDadosPaciente.TabIndex = 48;
            this.gDadosPaciente.TabStop = false;
            this.gDadosPaciente.Text = "Paciente Prescrito";
            this.gDadosPaciente.Visible = false;
            // 
            // lblTotalPrescricao
            // 
            this.lblTotalPrescricao.AutoSize = true;
            this.lblTotalPrescricao.Location = new System.Drawing.Point(248, 21);
            this.lblTotalPrescricao.Name = "lblTotalPrescricao";
            this.lblTotalPrescricao.Size = new System.Drawing.Size(119, 13);
            this.lblTotalPrescricao.TabIndex = 12;
            this.lblTotalPrescricao.Text = "Prescrição Cadastradas";
            // 
            // comboBoxDataPrescricao
            // 
            this.comboBoxDataPrescricao.DisplayMember = "NomePrescricao";
            this.comboBoxDataPrescricao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDataPrescricao.FormatString = "d";
            this.comboBoxDataPrescricao.FormattingEnabled = true;
            this.comboBoxDataPrescricao.Location = new System.Drawing.Point(248, 42);
            this.comboBoxDataPrescricao.MaxDropDownItems = 11;
            this.comboBoxDataPrescricao.Name = "comboBoxDataPrescricao";
            this.comboBoxDataPrescricao.Size = new System.Drawing.Size(227, 21);
            this.comboBoxDataPrescricao.TabIndex = 11;
            this.comboBoxDataPrescricao.ValueMember = "Id";
            this.comboBoxDataPrescricao.SelectedIndexChanged += new System.EventHandler(this.comboBoxDataPrescricao_SelectedIndexChanged);
            // 
            // lblLeito
            // 
            this.lblLeito.AutoSize = true;
            this.lblLeito.Location = new System.Drawing.Point(75, 47);
            this.lblLeito.Name = "lblLeito";
            this.lblLeito.Size = new System.Drawing.Size(12, 16);
            this.lblLeito.TabIndex = 9;
            this.lblLeito.Text = "-";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(75, 96);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(12, 16);
            this.lblIdade.TabIndex = 3;
            this.lblIdade.Text = "-";
            // 
            // lblProntuario
            // 
            this.lblProntuario.AutoSize = true;
            this.lblProntuario.Location = new System.Drawing.Point(75, 71);
            this.lblProntuario.Name = "lblProntuario";
            this.lblProntuario.Size = new System.Drawing.Size(12, 16);
            this.lblProntuario.TabIndex = 2;
            this.lblProntuario.Text = "-";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(75, 21);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(12, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Leito:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Prontuário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Idade:";
            // 
            // btnNewLine
            // 
            this.btnNewLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewLine.Enabled = false;
            this.btnNewLine.FlatAppearance.BorderSize = 0;
            this.btnNewLine.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnNewLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewLine.Image = global::AppInternacao.Properties.Resources.addItem;
            this.btnNewLine.Location = new System.Drawing.Point(632, 146);
            this.btnNewLine.Name = "btnNewLine";
            this.btnNewLine.Size = new System.Drawing.Size(39, 39);
            this.btnNewLine.TabIndex = 1;
            this.btnNewLine.UseVisualStyleBackColor = true;
            this.btnNewLine.Click += new System.EventHandler(this.btnNewLine_Click);
            // 
            // btnRemoveDia
            // 
            this.btnRemoveDia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveDia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveDia.Enabled = false;
            this.btnRemoveDia.FlatAppearance.BorderSize = 0;
            this.btnRemoveDia.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnRemoveDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveDia.Image = global::AppInternacao.Properties.Resources.Remove_40970;
            this.btnRemoveDia.Location = new System.Drawing.Point(722, 146);
            this.btnRemoveDia.Name = "btnRemoveDia";
            this.btnRemoveDia.Size = new System.Drawing.Size(39, 39);
            this.btnRemoveDia.TabIndex = 3;
            this.btnRemoveDia.UseVisualStyleBackColor = true;
            this.btnRemoveDia.Click += new System.EventHandler(this.btnRemoveDia_Click);
            // 
            // btnAddDia
            // 
            this.btnAddDia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddDia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddDia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDia.Enabled = false;
            this.btnAddDia.FlatAppearance.BorderSize = 0;
            this.btnAddDia.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnAddDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDia.Image = global::AppInternacao.Properties.Resources.Add_40971;
            this.btnAddDia.Location = new System.Drawing.Point(677, 146);
            this.btnAddDia.Name = "btnAddDia";
            this.btnAddDia.Size = new System.Drawing.Size(39, 39);
            this.btnAddDia.TabIndex = 2;
            this.btnAddDia.UseVisualStyleBackColor = true;
            this.btnAddDia.Click += new System.EventHandler(this.btnAddDia_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.dataGridViewPrescricoes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 198);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(773, 350);
            this.panel2.TabIndex = 24;
            // 
            // UCPrescricaoCiclo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCPrescricaoCiclo";
            this.Size = new System.Drawing.Size(773, 548);
            this.Load += new System.EventHandler(this.UCPrescricaoCiclo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrescricoes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pNamePrescricao.ResumeLayout(false);
            this.pNamePrescricao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gDadosPaciente.ResumeLayout(false);
            this.gDadosPaciente.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewLine;
        private System.Windows.Forms.Button btnRemoveDia;
        private System.Windows.Forms.Button btnAddDia;
        private System.Windows.Forms.DataGridView dataGridViewPrescricoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar CalendarCicloPrescricao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddCiclo;
        private System.Windows.Forms.GroupBox gDadosPaciente;
        private System.Windows.Forms.Label lblLeito;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblProntuario;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCicloPrescricao;
        private System.Windows.Forms.Label lblTotalPrescricao;
        private System.Windows.Forms.ComboBox comboBoxDataPrescricao;
        private System.Windows.Forms.Panel pNamePrescricao;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblRotulo;
        private System.Windows.Forms.TextBox textBoxNomePrescricao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCriarPrescricao;
        private System.Windows.Forms.Label lblContaCaracter;
        private System.Windows.Forms.Button btnCancelaPrescricao;
    }
}
