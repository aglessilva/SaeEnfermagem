﻿
namespace AppInternacao.FrmSae
{
    partial class UI008FrmPrescricaoCiclo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblContaCaracter = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxDataPrescricao = new System.Windows.Forms.ComboBox();
            this.lblCicloPrescricao = new System.Windows.Forms.Label();
            this.lblRotulo = new System.Windows.Forms.Label();
            this.textBoxNomePrescricao = new System.Windows.Forms.TextBox();
            this.lblTotalPrescricao = new System.Windows.Forms.Label();
            this.lblValidaPrescricao = new System.Windows.Forms.Label();
            this.pnlCabecalho = new System.Windows.Forms.Panel();
            this.pNamePrescricao = new System.Windows.Forms.Panel();
            this.btnCancelaPrescricao = new FontAwesome.Sharp.IconButton();
            this.btnCriarPrescricao = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlControle = new System.Windows.Forms.Panel();
            this.btnDevolverPrescricao = new FontAwesome.Sharp.IconButton();
            this.btnAddCiclo = new FontAwesome.Sharp.IconButton();
            this.btnValidarPrescricao = new FontAwesome.Sharp.IconButton();
            this.btnNewLine = new System.Windows.Forms.Button();
            this.btnRemoveDia = new System.Windows.Forms.Button();
            this.btnAddDia = new System.Windows.Forms.Button();
            this.pnlCalendario = new System.Windows.Forms.Panel();
            this.CalendarCicloPrescricao = new System.Windows.Forms.MonthCalendar();
            this.dataGridViewPrescricoes = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Intervalo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCabecalho.SuspendLayout();
            this.pNamePrescricao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlControle.SuspendLayout();
            this.pnlCalendario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrescricoes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblContaCaracter
            // 
            this.lblContaCaracter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblContaCaracter.AutoSize = true;
            this.lblContaCaracter.Location = new System.Drawing.Point(-45, 83);
            this.lblContaCaracter.Name = "lblContaCaracter";
            this.lblContaCaracter.Size = new System.Drawing.Size(125, 13);
            this.lblContaCaracter.TabIndex = 26;
            this.lblContaCaracter.Text = "Mínimo de 10 caracteres";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(-45, 76);
            this.panel3.MaximumSize = new System.Drawing.Size(395, 1);
            this.panel3.MinimumSize = new System.Drawing.Size(395, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(395, 1);
            this.panel3.TabIndex = 23;
            // 
            // comboBoxDataPrescricao
            // 
            this.comboBoxDataPrescricao.DisplayMember = "NomePrescricao";
            this.comboBoxDataPrescricao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDataPrescricao.FormattingEnabled = true;
            this.comboBoxDataPrescricao.Location = new System.Drawing.Point(13, 35);
            this.comboBoxDataPrescricao.MaxDropDownItems = 11;
            this.comboBoxDataPrescricao.Name = "comboBoxDataPrescricao";
            this.comboBoxDataPrescricao.Size = new System.Drawing.Size(349, 21);
            this.comboBoxDataPrescricao.TabIndex = 11;
            this.comboBoxDataPrescricao.ValueMember = "Id";
            this.comboBoxDataPrescricao.SelectionChangeCommitted += new System.EventHandler(this.comboBoxDataPrescricao_SelectionChangeCommitted);
            // 
            // lblCicloPrescricao
            // 
            this.lblCicloPrescricao.AutoSize = true;
            this.lblCicloPrescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCicloPrescricao.ForeColor = System.Drawing.Color.Navy;
            this.lblCicloPrescricao.Location = new System.Drawing.Point(163, 74);
            this.lblCicloPrescricao.Name = "lblCicloPrescricao";
            this.lblCicloPrescricao.Size = new System.Drawing.Size(14, 18);
            this.lblCicloPrescricao.TabIndex = 49;
            this.lblCicloPrescricao.Text = "-";
            this.lblCicloPrescricao.Visible = false;
            // 
            // lblRotulo
            // 
            this.lblRotulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRotulo.AutoSize = true;
            this.lblRotulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblRotulo.Location = new System.Drawing.Point(-45, 27);
            this.lblRotulo.Name = "lblRotulo";
            this.lblRotulo.Size = new System.Drawing.Size(267, 17);
            this.lblRotulo.TabIndex = 22;
            this.lblRotulo.Text = "Informe um nome para a nova prescrição";
            // 
            // textBoxNomePrescricao
            // 
            this.textBoxNomePrescricao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxNomePrescricao.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxNomePrescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNomePrescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNomePrescricao.Location = new System.Drawing.Point(13, 61);
            this.textBoxNomePrescricao.MaxLength = 50;
            this.textBoxNomePrescricao.Name = "textBoxNomePrescricao";
            this.textBoxNomePrescricao.Size = new System.Drawing.Size(337, 13);
            this.textBoxNomePrescricao.TabIndex = 21;
            this.textBoxNomePrescricao.WordWrap = false;
            this.textBoxNomePrescricao.TextChanged += new System.EventHandler(this.textBoxNomePrescricao_TextChanged);
            // 
            // lblTotalPrescricao
            // 
            this.lblTotalPrescricao.AutoSize = true;
            this.lblTotalPrescricao.Location = new System.Drawing.Point(12, 14);
            this.lblTotalPrescricao.Name = "lblTotalPrescricao";
            this.lblTotalPrescricao.Size = new System.Drawing.Size(119, 13);
            this.lblTotalPrescricao.TabIndex = 12;
            this.lblTotalPrescricao.Text = "Prescrição Cadastradas";
            // 
            // lblValidaPrescricao
            // 
            this.lblValidaPrescricao.AutoSize = true;
            this.lblValidaPrescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblValidaPrescricao.ForeColor = System.Drawing.Color.Red;
            this.lblValidaPrescricao.Location = new System.Drawing.Point(13, 59);
            this.lblValidaPrescricao.Name = "lblValidaPrescricao";
            this.lblValidaPrescricao.Size = new System.Drawing.Size(104, 15);
            this.lblValidaPrescricao.TabIndex = 51;
            this.lblValidaPrescricao.Text = "validar Prescrição";
            this.lblValidaPrescricao.Visible = false;
            // 
            // pnlCabecalho
            // 
            this.pnlCabecalho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCabecalho.Controls.Add(this.pNamePrescricao);
            this.pnlCabecalho.Controls.Add(this.pnlControle);
            this.pnlCabecalho.Controls.Add(this.pnlCalendario);
            this.pnlCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecalho.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecalho.Name = "pnlCabecalho";
            this.pnlCabecalho.Size = new System.Drawing.Size(849, 174);
            this.pnlCabecalho.TabIndex = 25;
            // 
            // pNamePrescricao
            // 
            this.pNamePrescricao.Controls.Add(this.panel3);
            this.pNamePrescricao.Controls.Add(this.btnCancelaPrescricao);
            this.pNamePrescricao.Controls.Add(this.btnCriarPrescricao);
            this.pNamePrescricao.Controls.Add(this.lblContaCaracter);
            this.pNamePrescricao.Controls.Add(this.lblRotulo);
            this.pNamePrescricao.Controls.Add(this.textBoxNomePrescricao);
            this.pNamePrescricao.Controls.Add(this.pictureBox1);
            this.pNamePrescricao.Location = new System.Drawing.Point(579, 6);
            this.pNamePrescricao.Name = "pNamePrescricao";
            this.pNamePrescricao.Size = new System.Drawing.Size(257, 155);
            this.pNamePrescricao.TabIndex = 11;
            this.pNamePrescricao.Visible = false;
            // 
            // btnCancelaPrescricao
            // 
            this.btnCancelaPrescricao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelaPrescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnCancelaPrescricao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelaPrescricao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelaPrescricao.FlatAppearance.BorderSize = 0;
            this.btnCancelaPrescricao.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelaPrescricao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btnCancelaPrescricao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelaPrescricao.ForeColor = System.Drawing.Color.White;
            this.btnCancelaPrescricao.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnCancelaPrescricao.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelaPrescricao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelaPrescricao.IconSize = 30;
            this.btnCancelaPrescricao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelaPrescricao.Location = new System.Drawing.Point(-48, 114);
            this.btnCancelaPrescricao.Name = "btnCancelaPrescricao";
            this.btnCancelaPrescricao.Size = new System.Drawing.Size(157, 36);
            this.btnCancelaPrescricao.TabIndex = 104;
            this.btnCancelaPrescricao.TabStop = false;
            this.btnCancelaPrescricao.Text = "Cancelar prescrição";
            this.btnCancelaPrescricao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelaPrescricao.UseVisualStyleBackColor = false;
            this.btnCancelaPrescricao.Click += new System.EventHandler(this.btnCancelaPrescricao_Click);
            // 
            // btnCriarPrescricao
            // 
            this.btnCriarPrescricao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCriarPrescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnCriarPrescricao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCriarPrescricao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriarPrescricao.Enabled = false;
            this.btnCriarPrescricao.FlatAppearance.BorderSize = 0;
            this.btnCriarPrescricao.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCriarPrescricao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btnCriarPrescricao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarPrescricao.ForeColor = System.Drawing.Color.White;
            this.btnCriarPrescricao.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btnCriarPrescricao.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCriarPrescricao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCriarPrescricao.IconSize = 30;
            this.btnCriarPrescricao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCriarPrescricao.Location = new System.Drawing.Point(200, 114);
            this.btnCriarPrescricao.Name = "btnCriarPrescricao";
            this.btnCriarPrescricao.Size = new System.Drawing.Size(162, 36);
            this.btnCriarPrescricao.TabIndex = 103;
            this.btnCriarPrescricao.TabStop = false;
            this.btnCriarPrescricao.Text = "Criar nova prescrição";
            this.btnCriarPrescricao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCriarPrescricao.UseVisualStyleBackColor = false;
            this.btnCriarPrescricao.Click += new System.EventHandler(this.btnCriarPrescricao_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::AppInternacao.Properties.Resources.Documents;
            this.pictureBox1.Location = new System.Drawing.Point(-47, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // pnlControle
            // 
            this.pnlControle.BackColor = System.Drawing.SystemColors.Control;
            this.pnlControle.Controls.Add(this.lblCicloPrescricao);
            this.pnlControle.Controls.Add(this.btnDevolverPrescricao);
            this.pnlControle.Controls.Add(this.btnAddCiclo);
            this.pnlControle.Controls.Add(this.btnValidarPrescricao);
            this.pnlControle.Controls.Add(this.btnNewLine);
            this.pnlControle.Controls.Add(this.lblValidaPrescricao);
            this.pnlControle.Controls.Add(this.lblTotalPrescricao);
            this.pnlControle.Controls.Add(this.comboBoxDataPrescricao);
            this.pnlControle.Controls.Add(this.btnRemoveDia);
            this.pnlControle.Controls.Add(this.btnAddDia);
            this.pnlControle.Location = new System.Drawing.Point(243, 6);
            this.pnlControle.Name = "pnlControle";
            this.pnlControle.Size = new System.Drawing.Size(335, 160);
            this.pnlControle.TabIndex = 50;
            // 
            // btnDevolverPrescricao
            // 
            this.btnDevolverPrescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDevolverPrescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnDevolverPrescricao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDevolverPrescricao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevolverPrescricao.FlatAppearance.BorderSize = 0;
            this.btnDevolverPrescricao.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDevolverPrescricao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btnDevolverPrescricao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolverPrescricao.ForeColor = System.Drawing.Color.White;
            this.btnDevolverPrescricao.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            this.btnDevolverPrescricao.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDevolverPrescricao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDevolverPrescricao.IconSize = 30;
            this.btnDevolverPrescricao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevolverPrescricao.Location = new System.Drawing.Point(189, 29);
            this.btnDevolverPrescricao.Name = "btnDevolverPrescricao";
            this.btnDevolverPrescricao.Size = new System.Drawing.Size(141, 35);
            this.btnDevolverPrescricao.TabIndex = 107;
            this.btnDevolverPrescricao.TabStop = false;
            this.btnDevolverPrescricao.Text = "Devolver Prescrição";
            this.btnDevolverPrescricao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDevolverPrescricao.UseVisualStyleBackColor = false;
            this.btnDevolverPrescricao.Visible = false;
            this.btnDevolverPrescricao.Click += new System.EventHandler(this.btnDevolverPrescricao_Click);
            // 
            // btnAddCiclo
            // 
            this.btnAddCiclo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddCiclo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnAddCiclo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddCiclo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCiclo.FlatAppearance.BorderSize = 0;
            this.btnAddCiclo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddCiclo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btnAddCiclo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCiclo.ForeColor = System.Drawing.Color.White;
            this.btnAddCiclo.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            this.btnAddCiclo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddCiclo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddCiclo.IconSize = 30;
            this.btnAddCiclo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCiclo.Location = new System.Drawing.Point(13, 118);
            this.btnAddCiclo.Name = "btnAddCiclo";
            this.btnAddCiclo.Size = new System.Drawing.Size(158, 35);
            this.btnAddCiclo.TabIndex = 105;
            this.btnAddCiclo.TabStop = false;
            this.btnAddCiclo.Text = "Promover e Iniciar Ciclo";
            this.btnAddCiclo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCiclo.UseVisualStyleBackColor = false;
            this.btnAddCiclo.Visible = false;
            this.btnAddCiclo.Click += new System.EventHandler(this.btnAddCiclo_Click);
            // 
            // btnValidarPrescricao
            // 
            this.btnValidarPrescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValidarPrescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnValidarPrescricao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnValidarPrescricao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValidarPrescricao.FlatAppearance.BorderSize = 0;
            this.btnValidarPrescricao.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnValidarPrescricao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btnValidarPrescricao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidarPrescricao.ForeColor = System.Drawing.Color.White;
            this.btnValidarPrescricao.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            this.btnValidarPrescricao.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.btnValidarPrescricao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnValidarPrescricao.IconSize = 30;
            this.btnValidarPrescricao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValidarPrescricao.Location = new System.Drawing.Point(189, 69);
            this.btnValidarPrescricao.Name = "btnValidarPrescricao";
            this.btnValidarPrescricao.Size = new System.Drawing.Size(141, 35);
            this.btnValidarPrescricao.TabIndex = 106;
            this.btnValidarPrescricao.TabStop = false;
            this.btnValidarPrescricao.Text = "Aceitar Prescrição";
            this.btnValidarPrescricao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnValidarPrescricao.UseVisualStyleBackColor = false;
            this.btnValidarPrescricao.Visible = false;
            this.btnValidarPrescricao.Click += new System.EventHandler(this.btnValidarPrescricao_Click);
            // 
            // btnNewLine
            // 
            this.btnNewLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewLine.Enabled = false;
            this.btnNewLine.FlatAppearance.BorderSize = 0;
            this.btnNewLine.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnNewLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewLine.Image = global::AppInternacao.Properties.Resources.addItem;
            this.btnNewLine.Location = new System.Drawing.Point(201, 116);
            this.btnNewLine.Name = "btnNewLine";
            this.btnNewLine.Size = new System.Drawing.Size(39, 39);
            this.btnNewLine.TabIndex = 1;
            this.btnNewLine.UseVisualStyleBackColor = true;
            this.btnNewLine.Click += new System.EventHandler(this.btnNewLine_Click);
            // 
            // btnRemoveDia
            // 
            this.btnRemoveDia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveDia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveDia.Enabled = false;
            this.btnRemoveDia.FlatAppearance.BorderSize = 0;
            this.btnRemoveDia.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnRemoveDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveDia.Image = global::AppInternacao.Properties.Resources.Remove_40970;
            this.btnRemoveDia.Location = new System.Drawing.Point(291, 116);
            this.btnRemoveDia.Name = "btnRemoveDia";
            this.btnRemoveDia.Size = new System.Drawing.Size(39, 39);
            this.btnRemoveDia.TabIndex = 3;
            this.btnRemoveDia.UseVisualStyleBackColor = true;
            this.btnRemoveDia.Click += new System.EventHandler(this.btnRemoveDia_Click);
            // 
            // btnAddDia
            // 
            this.btnAddDia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddDia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddDia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDia.Enabled = false;
            this.btnAddDia.FlatAppearance.BorderSize = 0;
            this.btnAddDia.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnAddDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDia.Image = global::AppInternacao.Properties.Resources.Add_40971;
            this.btnAddDia.Location = new System.Drawing.Point(246, 116);
            this.btnAddDia.Name = "btnAddDia";
            this.btnAddDia.Size = new System.Drawing.Size(39, 39);
            this.btnAddDia.TabIndex = 2;
            this.btnAddDia.UseVisualStyleBackColor = true;
            this.btnAddDia.Click += new System.EventHandler(this.btnAddDia_Click);
            // 
            // pnlCalendario
            // 
            this.pnlCalendario.Controls.Add(this.CalendarCicloPrescricao);
            this.pnlCalendario.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCalendario.Location = new System.Drawing.Point(0, 0);
            this.pnlCalendario.Name = "pnlCalendario";
            this.pnlCalendario.Size = new System.Drawing.Size(237, 172);
            this.pnlCalendario.TabIndex = 0;
            this.pnlCalendario.Visible = false;
            // 
            // CalendarCicloPrescricao
            // 
            this.CalendarCicloPrescricao.BackColor = System.Drawing.SystemColors.Window;
            this.CalendarCicloPrescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalendarCicloPrescricao.Location = new System.Drawing.Point(4, 4);
            this.CalendarCicloPrescricao.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.CalendarCicloPrescricao.MaxSelectionCount = 30;
            this.CalendarCicloPrescricao.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.CalendarCicloPrescricao.Name = "CalendarCicloPrescricao";
            this.CalendarCicloPrescricao.TabIndex = 0;
            this.CalendarCicloPrescricao.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.CalendarCicloPrescricao_DateSelected);
            // 
            // dataGridViewPrescricoes
            // 
            this.dataGridViewPrescricoes.AllowUserToAddRows = false;
            this.dataGridViewPrescricoes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            this.dataGridViewPrescricoes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPrescricoes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewPrescricoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPrescricoes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPrescricoes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPrescricoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrescricoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Prescricao,
            this.Intervalo,
            this.Horario});
            this.dataGridViewPrescricoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPrescricoes.EnableHeadersVisualStyles = false;
            this.dataGridViewPrescricoes.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewPrescricoes.Location = new System.Drawing.Point(0, 174);
            this.dataGridViewPrescricoes.Name = "dataGridViewPrescricoes";
            this.dataGridViewPrescricoes.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewPrescricoes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewPrescricoes.RowTemplate.Height = 40;
            this.dataGridViewPrescricoes.Size = new System.Drawing.Size(849, 407);
            this.dataGridViewPrescricoes.TabIndex = 26;
            this.dataGridViewPrescricoes.Visible = false;
            this.dataGridViewPrescricoes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPrescricoes_CellContentClick);
            this.dataGridViewPrescricoes.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPrescricoes_CellEndEdit);
            this.dataGridViewPrescricoes.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewPrescricoes_DataError);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Id.DataPropertyName = "Id";
            this.Id.Frozen = true;
            this.Id.HeaderText = "Item";
            this.Id.Name = "Id";
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.ToolTipText = "identifica o item da linha";
            this.Id.Width = 30;
            // 
            // Prescricao
            // 
            this.Prescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prescricao.DataPropertyName = "Prescricao";
            this.Prescricao.HeaderText = "Prescrição";
            this.Prescricao.Name = "Prescricao";
            this.Prescricao.ToolTipText = "Identifica a prescrição mádica";
            // 
            // Intervalo
            // 
            this.Intervalo.DataPropertyName = "Intervalo";
            dataGridViewCellStyle3.Format = "t";
            dataGridViewCellStyle3.NullValue = null;
            this.Intervalo.DefaultCellStyle = dataGridViewCellStyle3;
            this.Intervalo.HeaderText = "Intervalo";
            this.Intervalo.Name = "Intervalo";
            this.Intervalo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Intervalo.ToolTipText = "Intervalo de horas para o medicamento/cuidados";
            this.Intervalo.Width = 60;
            // 
            // Horario
            // 
            this.Horario.DataPropertyName = "Horario";
            dataGridViewCellStyle4.Format = "t";
            this.Horario.DefaultCellStyle = dataGridViewCellStyle4;
            this.Horario.HeaderText = "Horário";
            this.Horario.Name = "Horario";
            this.Horario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Horario.ToolTipText = "Indica o horário que iniciará o procedimento";
            this.Horario.Width = 60;
            // 
            // UI008FrmPrescricaoCiclo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(849, 581);
            this.Controls.Add(this.dataGridViewPrescricoes);
            this.Controls.Add(this.pnlCabecalho);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "UI008FrmPrescricaoCiclo";
            this.Load += new System.EventHandler(this.UI008FrmPrescricaoCiclo_Load);
            this.pnlCabecalho.ResumeLayout(false);
            this.pNamePrescricao.ResumeLayout(false);
            this.pNamePrescricao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlControle.ResumeLayout(false);
            this.pnlControle.PerformLayout();
            this.pnlCalendario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrescricoes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNewLine;
        private System.Windows.Forms.Button btnRemoveDia;
        private System.Windows.Forms.Button btnAddDia;
        private System.Windows.Forms.Label lblContaCaracter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBoxDataPrescricao;
        private System.Windows.Forms.Label lblCicloPrescricao;
        private System.Windows.Forms.Label lblRotulo;
        private System.Windows.Forms.TextBox textBoxNomePrescricao;
        private System.Windows.Forms.Label lblTotalPrescricao;
        private System.Windows.Forms.Label lblValidaPrescricao;
        private System.Windows.Forms.Panel pnlCabecalho;
        private System.Windows.Forms.Panel pNamePrescricao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MonthCalendar CalendarCicloPrescricao;
        private FontAwesome.Sharp.IconButton btnCriarPrescricao;
        private FontAwesome.Sharp.IconButton btnCancelaPrescricao;
        private FontAwesome.Sharp.IconButton btnValidarPrescricao;
        private FontAwesome.Sharp.IconButton btnAddCiclo;
        private FontAwesome.Sharp.IconButton btnDevolverPrescricao;
        private System.Windows.Forms.Panel pnlCalendario;
        private System.Windows.Forms.DataGridView dataGridViewPrescricoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Intervalo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario;
        private System.Windows.Forms.Panel pnlControle;
    }
}
