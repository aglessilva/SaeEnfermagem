
namespace AppInternacao.FrmSae
{
    partial class UI018FrmSaeAvaliacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI018FrmSaeAvaliacao));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.treeViewNoc = new System.Windows.Forms.TreeView();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBoxPesquisaNoc = new System.Windows.Forms.TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.comboBoxNicClassificacao = new System.Windows.Forms.ComboBox();
            this.lblItemIndicador = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDefinicao = new System.Windows.Forms.Label();
            this.npdOutros = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.npdEstimativaAlvo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewAvaliacao = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.principal = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.T2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.T3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.T4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.T5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxClassificacao = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdOutros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdEstimativaAlvo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvaliacao)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxNicClassificacao);
            this.splitContainer1.Panel2.Controls.Add(this.lblItemIndicador);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.lblDefinicao);
            this.splitContainer1.Panel2.Controls.Add(this.npdOutros);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.npdEstimativaAlvo);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewAvaliacao);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxClassificacao);
            this.splitContainer1.Size = new System.Drawing.Size(1201, 555);
            this.splitContainer1.SplitterDistance = 369;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.treeViewNoc);
            this.groupBox2.Controls.Add(this.buttonLimpar);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.textBoxPesquisaNoc);
            this.groupBox2.Controls.Add(this.iconPictureBox1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 555);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "NOC - Classificação";
            // 
            // treeViewNoc
            // 
            this.treeViewNoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewNoc.BackColor = System.Drawing.SystemColors.Control;
            this.treeViewNoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewNoc.CheckBoxes = true;
            this.treeViewNoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeViewNoc.HideSelection = false;
            this.treeViewNoc.Indent = 22;
            this.treeViewNoc.ItemHeight = 18;
            this.treeViewNoc.LineColor = System.Drawing.Color.Maroon;
            this.treeViewNoc.Location = new System.Drawing.Point(6, 52);
            this.treeViewNoc.Name = "treeViewNoc";
            this.treeViewNoc.ShowNodeToolTips = true;
            this.treeViewNoc.Size = new System.Drawing.Size(346, 495);
            this.treeViewNoc.TabIndex = 30;
            this.treeViewNoc.TabStop = false;
            this.treeViewNoc.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeViewNoc_AfterCheck);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.buttonLimpar.Location = new System.Drawing.Point(324, 24);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(26, 20);
            this.buttonLimpar.TabIndex = 28;
            this.buttonLimpar.TabStop = false;
            this.buttonLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.AutoSize = true;
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.panel5.Location = new System.Drawing.Point(6, 45);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(346, 1);
            this.panel5.TabIndex = 29;
            // 
            // textBoxPesquisaNoc
            // 
            this.textBoxPesquisaNoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPesquisaNoc.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxPesquisaNoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPesquisaNoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxPesquisaNoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBoxPesquisaNoc.ForeColor = System.Drawing.Color.Black;
            this.textBoxPesquisaNoc.Location = new System.Drawing.Point(35, 29);
            this.textBoxPesquisaNoc.Name = "textBoxPesquisaNoc";
            this.textBoxPesquisaNoc.Size = new System.Drawing.Size(285, 15);
            this.textBoxPesquisaNoc.TabIndex = 27;
            this.textBoxPesquisaNoc.TextChanged += new System.EventHandler(this.textBoxPesquisaNoc_TextChanged);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 27;
            this.iconPictureBox1.Location = new System.Drawing.Point(8, 19);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(27, 27);
            this.iconPictureBox1.TabIndex = 29;
            this.iconPictureBox1.TabStop = false;
            // 
            // comboBoxNicClassificacao
            // 
            this.comboBoxNicClassificacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxNicClassificacao.DisplayMember = "Classificacao";
            this.comboBoxNicClassificacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNicClassificacao.FormattingEnabled = true;
            this.comboBoxNicClassificacao.Items.AddRange(new object[] {
            "Selecione uma classificação de resultados..."});
            this.comboBoxNicClassificacao.Location = new System.Drawing.Point(7, 11);
            this.comboBoxNicClassificacao.Name = "comboBoxNicClassificacao";
            this.comboBoxNicClassificacao.Size = new System.Drawing.Size(823, 21);
            this.comboBoxNicClassificacao.TabIndex = 44;
            this.comboBoxNicClassificacao.ValueMember = "Codigo";
            // 
            // lblItemIndicador
            // 
            this.lblItemIndicador.AutoSize = true;
            this.lblItemIndicador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblItemIndicador.ForeColor = System.Drawing.Color.Blue;
            this.lblItemIndicador.Location = new System.Drawing.Point(319, 98);
            this.lblItemIndicador.Name = "lblItemIndicador";
            this.lblItemIndicador.Size = new System.Drawing.Size(12, 15);
            this.lblItemIndicador.TabIndex = 43;
            this.lblItemIndicador.Text = "-";
            this.lblItemIndicador.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(7, 151);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(823, 1);
            this.panel3.TabIndex = 42;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(7, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(823, 1);
            this.panel2.TabIndex = 41;
            // 
            // lblDefinicao
            // 
            this.lblDefinicao.AutoSize = true;
            this.lblDefinicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.lblDefinicao.ForeColor = System.Drawing.Color.Crimson;
            this.lblDefinicao.Location = new System.Drawing.Point(7, 68);
            this.lblDefinicao.Name = "lblDefinicao";
            this.lblDefinicao.Size = new System.Drawing.Size(62, 15);
            this.lblDefinicao.TabIndex = 38;
            this.lblDefinicao.Text = "Definição:";
            // 
            // npdOutros
            // 
            this.npdOutros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.npdOutros.Enabled = false;
            this.npdOutros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npdOutros.Location = new System.Drawing.Point(266, 127);
            this.npdOutros.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.npdOutros.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.npdOutros.Name = "npdOutros";
            this.npdOutros.Size = new System.Drawing.Size(47, 20);
            this.npdOutros.TabIndex = 37;
            this.npdOutros.TabStop = false;
            this.npdOutros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.npdOutros.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.npdOutros.ValueChanged += new System.EventHandler(this.npdOutros_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(8, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "Alterar score dos demais indicadores:";
            // 
            // npdEstimativaAlvo
            // 
            this.npdEstimativaAlvo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.npdEstimativaAlvo.Enabled = false;
            this.npdEstimativaAlvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npdEstimativaAlvo.Location = new System.Drawing.Point(266, 96);
            this.npdEstimativaAlvo.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.npdEstimativaAlvo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.npdEstimativaAlvo.Name = "npdEstimativaAlvo";
            this.npdEstimativaAlvo.Size = new System.Drawing.Size(47, 20);
            this.npdEstimativaAlvo.TabIndex = 33;
            this.npdEstimativaAlvo.TabStop = false;
            this.npdEstimativaAlvo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.npdEstimativaAlvo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.npdEstimativaAlvo.ValueChanged += new System.EventHandler(this.npdEstimativaAlvo_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Estimativa do alvo-indicador princicpal:";
            // 
            // dataGridViewAvaliacao
            // 
            this.dataGridViewAvaliacao.AllowUserToAddRows = false;
            this.dataGridViewAvaliacao.AllowUserToDeleteRows = false;
            this.dataGridViewAvaliacao.AllowUserToResizeColumns = false;
            this.dataGridViewAvaliacao.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewAvaliacao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewAvaliacao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAvaliacao.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewAvaliacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAvaliacao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewAvaliacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvaliacao.ColumnHeadersVisible = false;
            this.dataGridViewAvaliacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.principal,
            this.Nome,
            this.T1,
            this.T2,
            this.T3,
            this.T4,
            this.T5});
            this.dataGridViewAvaliacao.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAvaliacao.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewAvaliacao.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewAvaliacao.Location = new System.Drawing.Point(7, 158);
            this.dataGridViewAvaliacao.MultiSelect = false;
            this.dataGridViewAvaliacao.Name = "dataGridViewAvaliacao";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAvaliacao.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewAvaliacao.RowHeadersVisible = false;
            this.dataGridViewAvaliacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAvaliacao.Size = new System.Drawing.Size(823, 386);
            this.dataGridViewAvaliacao.TabIndex = 31;
            this.dataGridViewAvaliacao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAvaliacao_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 5;
            // 
            // principal
            // 
            this.principal.HeaderText = "";
            this.principal.Name = "principal";
            this.principal.Width = 25;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nome.DataPropertyName = "Nome";
            this.Nome.FillWeight = 300F;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nome.Width = 350;
            // 
            // T1
            // 
            this.T1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.T1.DataPropertyName = "V1";
            this.T1.DisplayStyleForCurrentCellOnly = true;
            this.T1.DropDownWidth = 5;
            this.T1.HeaderText = "T1";
            this.T1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.T1.MaxDropDownItems = 5;
            this.T1.Name = "T1";
            // 
            // T2
            // 
            this.T2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.T2.DataPropertyName = "V2";
            this.T2.DisplayStyleForCurrentCellOnly = true;
            this.T2.DropDownWidth = 5;
            this.T2.HeaderText = "T2";
            this.T2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.T2.MaxDropDownItems = 5;
            this.T2.Name = "T2";
            this.T2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // T3
            // 
            this.T3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.T3.DataPropertyName = "V3";
            this.T3.DisplayStyleForCurrentCellOnly = true;
            this.T3.DropDownWidth = 5;
            this.T3.HeaderText = "T3";
            this.T3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.T3.MaxDropDownItems = 5;
            this.T3.Name = "T3";
            this.T3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // T4
            // 
            this.T4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.T4.DataPropertyName = "V4";
            this.T4.DisplayStyleForCurrentCellOnly = true;
            this.T4.DropDownWidth = 5;
            this.T4.HeaderText = "T4";
            this.T4.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.T4.MaxDropDownItems = 5;
            this.T4.Name = "T4";
            this.T4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // T5
            // 
            this.T5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.T5.DataPropertyName = "V5";
            this.T5.DisplayStyleForCurrentCellOnly = true;
            this.T5.DropDownWidth = 5;
            this.T5.HeaderText = "T5";
            this.T5.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.T5.MaxDropDownItems = 5;
            this.T5.Name = "T5";
            this.T5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(7, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 1);
            this.panel1.TabIndex = 30;
            // 
            // comboBoxClassificacao
            // 
            this.comboBoxClassificacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxClassificacao.DisplayMember = "Nome";
            this.comboBoxClassificacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClassificacao.FormattingEnabled = true;
            this.comboBoxClassificacao.Items.AddRange(new object[] {
            "Selecione uma classificação de resultados..."});
            this.comboBoxClassificacao.Location = new System.Drawing.Point(7, 42);
            this.comboBoxClassificacao.Name = "comboBoxClassificacao";
            this.comboBoxClassificacao.Size = new System.Drawing.Size(823, 21);
            this.comboBoxClassificacao.TabIndex = 0;
            this.comboBoxClassificacao.ValueMember = "Codigo";
            this.comboBoxClassificacao.SelectionChangeCommitted += new System.EventHandler(this.comboBoxClassificacao_SelectionChangeCommitted);
            // 
            // UI018FrmSaeAvaliacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1201, 555);
            this.Controls.Add(this.splitContainer1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "UI018FrmSaeAvaliacao";
            this.Load += new System.EventHandler(this.UI018FrmSaeAvaliacao_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdOutros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npdEstimativaAlvo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvaliacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TreeView treeViewNoc;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBoxPesquisaNoc;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.ComboBox comboBoxClassificacao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewAvaliacao;
        private System.Windows.Forms.NumericUpDown npdEstimativaAlvo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDefinicao;
        private System.Windows.Forms.NumericUpDown npdOutros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblItemIndicador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn principal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewComboBoxColumn T1;
        private System.Windows.Forms.DataGridViewComboBoxColumn T2;
        private System.Windows.Forms.DataGridViewComboBoxColumn T3;
        private System.Windows.Forms.DataGridViewComboBoxColumn T4;
        private System.Windows.Forms.DataGridViewComboBoxColumn T5;
        private System.Windows.Forms.ComboBox comboBoxNicClassificacao;
    }
}
