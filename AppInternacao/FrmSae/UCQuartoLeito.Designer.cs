using System;
using System.Windows.Forms;

namespace AppInternacao.FrmSae
{
    partial class UCQuartoLeito
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
            FrmMain.mySalvar.Click -= new EventHandler(MySalvar_Click);
            dataGridViewLeito.RowsAdded -= new DataGridViewRowsAddedEventHandler(dataGridViewLeito_RowsAdded);
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCQuartoLeito));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlQuartoLeito = new System.Windows.Forms.TabControl();
            this.tabPageQuartos = new System.Windows.Forms.TabPage();
            this.dataGridViewQuartos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDSETOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeQuarto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalLeito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.textBoxPesquisaQuarto = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.comboBoxSetor = new System.Windows.Forms.ComboBox();
            this.textBoxNomeQuarto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxQtdLeitos = new System.Windows.Forms.ComboBox();
            this.tabPageLeito = new System.Windows.Forms.TabPage();
            this.dataGridViewLeito = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDisponivel = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPesquisaLeito = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gLeito = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxIdLeitoQuarto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxQuarto = new System.Windows.Forms.ComboBox();
            this.textBoxIdLeito = new System.Windows.Forms.TextBox();
            this.textBoxTotalLeitos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNomeLeito = new System.Windows.Forms.TextBox();
            this.textBoxlLeitoQtd = new System.Windows.Forms.TextBox();
            this.tabPageInernacao = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanelImgLeito = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBoxPesquisaQuarto = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabControlQuartoLeito.SuspendLayout();
            this.tabPageQuartos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuartos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPageLeito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeito)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gLeito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageInernacao.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlQuartoLeito
            // 
            this.tabControlQuartoLeito.Controls.Add(this.tabPageQuartos);
            this.tabControlQuartoLeito.Controls.Add(this.tabPageLeito);
            this.tabControlQuartoLeito.Controls.Add(this.tabPageInernacao);
            this.tabControlQuartoLeito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlQuartoLeito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlQuartoLeito.Location = new System.Drawing.Point(0, 0);
            this.tabControlQuartoLeito.Multiline = true;
            this.tabControlQuartoLeito.Name = "tabControlQuartoLeito";
            this.tabControlQuartoLeito.SelectedIndex = 0;
            this.tabControlQuartoLeito.Size = new System.Drawing.Size(777, 546);
            this.tabControlQuartoLeito.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlQuartoLeito.TabIndex = 0;
            this.tabControlQuartoLeito.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControlQuartoLeito_Selecting);
            // 
            // tabPageQuartos
            // 
            this.tabPageQuartos.BackColor = System.Drawing.Color.Transparent;
            this.tabPageQuartos.Controls.Add(this.dataGridViewQuartos);
            this.tabPageQuartos.Controls.Add(this.groupBox2);
            this.tabPageQuartos.Controls.Add(this.groupBox1);
            this.tabPageQuartos.Location = new System.Drawing.Point(4, 22);
            this.tabPageQuartos.Name = "tabPageQuartos";
            this.tabPageQuartos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQuartos.Size = new System.Drawing.Size(769, 520);
            this.tabPageQuartos.TabIndex = 0;
            this.tabPageQuartos.Text = "Quartos";
            this.tabPageQuartos.ToolTipText = "Gerenciamento de Quartos";
            // 
            // dataGridViewQuartos
            // 
            this.dataGridViewQuartos.AllowUserToAddRows = false;
            this.dataGridViewQuartos.AllowUserToDeleteRows = false;
            this.dataGridViewQuartos.AllowUserToOrderColumns = true;
            this.dataGridViewQuartos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dataGridViewQuartos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewQuartos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewQuartos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewQuartos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewQuartos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuartos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.IDSETOR,
            this.NomeQuarto,
            this.TotalLeito,
            this.Editar,
            this.Excluir});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewQuartos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewQuartos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewQuartos.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewQuartos.Location = new System.Drawing.Point(3, 128);
            this.dataGridViewQuartos.Name = "dataGridViewQuartos";
            this.dataGridViewQuartos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewQuartos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewQuartos.RowHeadersVisible = false;
            this.dataGridViewQuartos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewQuartos.Size = new System.Drawing.Size(763, 389);
            this.dataGridViewQuartos.TabIndex = 8;
            this.dataGridViewQuartos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewQuartos_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // IDSETOR
            // 
            this.IDSETOR.HeaderText = "Setor";
            this.IDSETOR.Name = "IDSETOR";
            this.IDSETOR.ReadOnly = true;
            this.IDSETOR.Visible = false;
            // 
            // NomeQuarto
            // 
            this.NomeQuarto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeQuarto.DataPropertyName = "NomeQuarto";
            this.NomeQuarto.HeaderText = "Quarto";
            this.NomeQuarto.Name = "NomeQuarto";
            this.NomeQuarto.ReadOnly = true;
            // 
            // TotalLeito
            // 
            this.TotalLeito.DataPropertyName = "TotalLeito";
            this.TotalLeito.HeaderText = "Qtd";
            this.TotalLeito.Name = "TotalLeito";
            this.TotalLeito.ReadOnly = true;
            this.TotalLeito.ToolTipText = "Toal de Leitos por quarto";
            this.TotalLeito.Width = 30;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.ToolTipText = "Editar informações";
            this.Editar.Width = 30;
            // 
            // Excluir
            // 
            this.Excluir.HeaderText = "";
            this.Excluir.Image = global::AppInternacao.Properties.Resources.Delete_80_icon_icons_com_57340;
            this.Excluir.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            this.Excluir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Excluir.ToolTipText = "Remover quarto";
            this.Excluir.Width = 30;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel8);
            this.groupBox2.Controls.Add(this.buttonLimpar);
            this.groupBox2.Controls.Add(this.textBoxPesquisaQuarto);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(763, 55);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisa de Quartos";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DimGray;
            this.panel8.Location = new System.Drawing.Point(8, 40);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(283, 1);
            this.panel8.TabIndex = 20;
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
            this.buttonLimpar.Location = new System.Drawing.Point(262, 21);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(26, 20);
            this.buttonLimpar.TabIndex = 9;
            this.buttonLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // textBoxPesquisaQuarto
            // 
            this.textBoxPesquisaQuarto.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxPesquisaQuarto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPesquisaQuarto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxPesquisaQuarto.Location = new System.Drawing.Point(39, 25);
            this.textBoxPesquisaQuarto.Name = "textBoxPesquisaQuarto";
            this.textBoxPesquisaQuarto.Size = new System.Drawing.Size(217, 13);
            this.textBoxPesquisaQuarto.TabIndex = 3;
            this.textBoxPesquisaQuarto.TextChanged += new System.EventHandler(this.textBoxPesquisaQuarto_TextChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(6, 16);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Controls.Add(this.textBoxId);
            this.groupBox1.Controls.Add(this.comboBoxSetor);
            this.groupBox1.Controls.Add(this.textBoxNomeQuarto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbltitulo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxQtdLeitos);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 70);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Quartos";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AppInternacao.Properties.Resources.home_01;
            this.pictureBox3.Location = new System.Drawing.Point(5, 35);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DimGray;
            this.panel7.Location = new System.Drawing.Point(8, 60);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(283, 1);
            this.panel7.TabIndex = 19;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(729, 13);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(28, 20);
            this.textBoxId.TabIndex = 18;
            this.textBoxId.Visible = false;
            // 
            // comboBoxSetor
            // 
            this.comboBoxSetor.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxSetor.DisplayMember = "NomeSetor";
            this.comboBoxSetor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSetor.FormattingEnabled = true;
            this.comboBoxSetor.Location = new System.Drawing.Point(531, 39);
            this.comboBoxSetor.MaxDropDownItems = 10;
            this.comboBoxSetor.Name = "comboBoxSetor";
            this.comboBoxSetor.Size = new System.Drawing.Size(226, 21);
            this.comboBoxSetor.TabIndex = 2;
            this.comboBoxSetor.ValueMember = "Id";
            // 
            // textBoxNomeQuarto
            // 
            this.textBoxNomeQuarto.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxNomeQuarto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNomeQuarto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNomeQuarto.Location = new System.Drawing.Point(39, 46);
            this.textBoxNomeQuarto.MaxLength = 20;
            this.textBoxNomeQuarto.Name = "textBoxNomeQuarto";
            this.textBoxNomeQuarto.Size = new System.Drawing.Size(249, 13);
            this.textBoxNomeQuarto.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Setor";
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Location = new System.Drawing.Point(6, 19);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(85, 13);
            this.lbltitulo.TabIndex = 13;
            this.lbltitulo.Text = "Nome do Quarto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Quantidade de Leitos";
            // 
            // comboBoxQtdLeitos
            // 
            this.comboBoxQtdLeitos.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxQtdLeitos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQtdLeitos.FormattingEnabled = true;
            this.comboBoxQtdLeitos.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxQtdLeitos.Location = new System.Drawing.Point(313, 40);
            this.comboBoxQtdLeitos.MaxDropDownItems = 10;
            this.comboBoxQtdLeitos.Name = "comboBoxQtdLeitos";
            this.comboBoxQtdLeitos.Size = new System.Drawing.Size(128, 21);
            this.comboBoxQtdLeitos.TabIndex = 1;
            // 
            // tabPageLeito
            // 
            this.tabPageLeito.BackColor = System.Drawing.Color.Transparent;
            this.tabPageLeito.Controls.Add(this.dataGridViewLeito);
            this.tabPageLeito.Controls.Add(this.groupBox3);
            this.tabPageLeito.Controls.Add(this.gLeito);
            this.tabPageLeito.Location = new System.Drawing.Point(4, 22);
            this.tabPageLeito.Name = "tabPageLeito";
            this.tabPageLeito.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLeito.Size = new System.Drawing.Size(769, 520);
            this.tabPageLeito.TabIndex = 1;
            this.tabPageLeito.Text = "Leitos";
            // 
            // dataGridViewLeito
            // 
            this.dataGridViewLeito.AllowUserToAddRows = false;
            this.dataGridViewLeito.AllowUserToDeleteRows = false;
            this.dataGridViewLeito.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dataGridViewLeito.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewLeito.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewLeito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLeito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewLeito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLeito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.isDisponivel,
            this.dataGridViewImageColumn3,
            this.dataGridViewImageColumn4});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLeito.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewLeito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLeito.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewLeito.Location = new System.Drawing.Point(3, 128);
            this.dataGridViewLeito.Name = "dataGridViewLeito";
            this.dataGridViewLeito.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLeito.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewLeito.RowHeadersVisible = false;
            this.dataGridViewLeito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLeito.Size = new System.Drawing.Size(763, 389);
            this.dataGridViewLeito.TabIndex = 8;
            this.dataGridViewLeito.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLeito_CellContentClick);
            this.dataGridViewLeito.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewLeito_RowsAdded);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NomeLeito";
            this.dataGridViewTextBoxColumn3.HeaderText = "Leito";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // isDisponivel
            // 
            this.isDisponivel.Description = "Disponibilidade de Leitos";
            this.isDisponivel.HeaderText = "Disp";
            this.isDisponivel.Name = "isDisponivel";
            this.isDisponivel.ReadOnly = true;
            this.isDisponivel.ToolTipText = "Disponibilidade de Leitos";
            this.isDisponivel.Width = 30;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn3.Image")));
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn3.ToolTipText = "Editar Informações";
            this.dataGridViewImageColumn3.Width = 30;
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.HeaderText = "";
            this.dataGridViewImageColumn4.Image = global::AppInternacao.Properties.Resources.Delete_80_icon_icons_com_57340;
            this.dataGridViewImageColumn4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.ReadOnly = true;
            this.dataGridViewImageColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn4.ToolTipText = "Remover Item";
            this.dataGridViewImageColumn4.Width = 30;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel6);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.textBoxPesquisaLeito);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(763, 55);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pesquisa";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DimGray;
            this.panel6.Location = new System.Drawing.Point(8, 40);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(283, 1);
            this.panel6.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(262, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 20);
            this.button1.TabIndex = 10;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPesquisaLeito
            // 
            this.textBoxPesquisaLeito.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxPesquisaLeito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPesquisaLeito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxPesquisaLeito.Location = new System.Drawing.Point(39, 25);
            this.textBoxPesquisaLeito.Name = "textBoxPesquisaLeito";
            this.textBoxPesquisaLeito.Size = new System.Drawing.Size(217, 13);
            this.textBoxPesquisaLeito.TabIndex = 2;
            this.textBoxPesquisaLeito.TextChanged += new System.EventHandler(this.textBoxPesquisaLeito_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // gLeito
            // 
            this.gLeito.Controls.Add(this.label3);
            this.gLeito.Controls.Add(this.panel5);
            this.gLeito.Controls.Add(this.panel2);
            this.gLeito.Controls.Add(this.pictureBox1);
            this.gLeito.Controls.Add(this.panel1);
            this.gLeito.Controls.Add(this.textBoxIdLeitoQuarto);
            this.gLeito.Controls.Add(this.label5);
            this.gLeito.Controls.Add(this.comboBoxQuarto);
            this.gLeito.Controls.Add(this.textBoxIdLeito);
            this.gLeito.Controls.Add(this.textBoxTotalLeitos);
            this.gLeito.Controls.Add(this.label7);
            this.gLeito.Controls.Add(this.label4);
            this.gLeito.Controls.Add(this.textBoxNomeLeito);
            this.gLeito.Controls.Add(this.textBoxlLeitoQtd);
            this.gLeito.Dock = System.Windows.Forms.DockStyle.Top;
            this.gLeito.Location = new System.Drawing.Point(3, 3);
            this.gLeito.Name = "gLeito";
            this.gLeito.Size = new System.Drawing.Size(763, 70);
            this.gLeito.TabIndex = 0;
            this.gLeito.TabStop = false;
            this.gLeito.Text = "Cadastro de Leitos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome do Leito";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.panel5.Location = new System.Drawing.Point(635, 60);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(22, 1);
            this.panel5.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(536, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(22, 1);
            this.panel2.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppInternacao.Properties.Resources._48_113667;
            this.pictureBox1.Location = new System.Drawing.Point(5, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(8, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 1);
            this.panel1.TabIndex = 13;
            // 
            // textBoxIdLeitoQuarto
            // 
            this.textBoxIdLeitoQuarto.Location = new System.Drawing.Point(717, 43);
            this.textBoxIdLeitoQuarto.Name = "textBoxIdLeitoQuarto";
            this.textBoxIdLeitoQuarto.Size = new System.Drawing.Size(29, 20);
            this.textBoxIdLeitoQuarto.TabIndex = 12;
            this.textBoxIdLeitoQuarto.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(566, 45);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total Leitos";
            // 
            // comboBoxQuarto
            // 
            this.comboBoxQuarto.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxQuarto.DisplayMember = "NomeQuarto";
            this.comboBoxQuarto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQuarto.FormattingEnabled = true;
            this.comboBoxQuarto.Location = new System.Drawing.Point(313, 40);
            this.comboBoxQuarto.MaxDropDownItems = 10;
            this.comboBoxQuarto.Name = "comboBoxQuarto";
            this.comboBoxQuarto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxQuarto.Size = new System.Drawing.Size(205, 21);
            this.comboBoxQuarto.TabIndex = 1;
            this.comboBoxQuarto.ValueMember = "Id";
            this.comboBoxQuarto.SelectedIndexChanged += new System.EventHandler(this.comboBoxQuarto_SelectedIndexChanged);
            // 
            // textBoxIdLeito
            // 
            this.textBoxIdLeito.Location = new System.Drawing.Point(717, 16);
            this.textBoxIdLeito.Name = "textBoxIdLeito";
            this.textBoxIdLeito.Size = new System.Drawing.Size(29, 20);
            this.textBoxIdLeito.TabIndex = 0;
            this.textBoxIdLeito.Visible = false;
            // 
            // textBoxTotalLeitos
            // 
            this.textBoxTotalLeitos.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTotalLeitos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotalLeitos.Enabled = false;
            this.textBoxTotalLeitos.Location = new System.Drawing.Point(536, 46);
            this.textBoxTotalLeitos.Name = "textBoxTotalLeitos";
            this.textBoxTotalLeitos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxTotalLeitos.Size = new System.Drawing.Size(22, 13);
            this.textBoxTotalLeitos.TabIndex = 9;
            this.textBoxTotalLeitos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(310, 19);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Quarto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(662, 45);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Disponivel";
            // 
            // textBoxNomeLeito
            // 
            this.textBoxNomeLeito.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxNomeLeito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNomeLeito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNomeLeito.Location = new System.Drawing.Point(39, 46);
            this.textBoxNomeLeito.MaxLength = 20;
            this.textBoxNomeLeito.Name = "textBoxNomeLeito";
            this.textBoxNomeLeito.Size = new System.Drawing.Size(249, 13);
            this.textBoxNomeLeito.TabIndex = 0;
            // 
            // textBoxlLeitoQtd
            // 
            this.textBoxlLeitoQtd.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxlLeitoQtd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxlLeitoQtd.Enabled = false;
            this.textBoxlLeitoQtd.Location = new System.Drawing.Point(634, 46);
            this.textBoxlLeitoQtd.Name = "textBoxlLeitoQtd";
            this.textBoxlLeitoQtd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxlLeitoQtd.Size = new System.Drawing.Size(22, 13);
            this.textBoxlLeitoQtd.TabIndex = 7;
            this.textBoxlLeitoQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPageInernacao
            // 
            this.tabPageInernacao.BackColor = System.Drawing.Color.Transparent;
            this.tabPageInernacao.Controls.Add(this.panel4);
            this.tabPageInernacao.Controls.Add(this.panel3);
            this.tabPageInernacao.Location = new System.Drawing.Point(4, 22);
            this.tabPageInernacao.Name = "tabPageInernacao";
            this.tabPageInernacao.Size = new System.Drawing.Size(769, 520);
            this.tabPageInernacao.TabIndex = 2;
            this.tabPageInernacao.Text = "Ocupações";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.flowLayoutPanelImgLeito);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 58);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(769, 462);
            this.panel4.TabIndex = 12;
            // 
            // flowLayoutPanelImgLeito
            // 
            this.flowLayoutPanelImgLeito.AutoScroll = true;
            this.flowLayoutPanelImgLeito.AutoSize = true;
            this.flowLayoutPanelImgLeito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanelImgLeito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelImgLeito.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelImgLeito.Name = "flowLayoutPanelImgLeito";
            this.flowLayoutPanelImgLeito.Size = new System.Drawing.Size(769, 462);
            this.flowLayoutPanelImgLeito.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(769, 58);
            this.panel3.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBoxPesquisaQuarto);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(769, 52);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pesquisa de Leitos por Quarto";
            // 
            // comboBoxPesquisaQuarto
            // 
            this.comboBoxPesquisaQuarto.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxPesquisaQuarto.DisplayMember = "NomeQuarto";
            this.comboBoxPesquisaQuarto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPesquisaQuarto.FormattingEnabled = true;
            this.comboBoxPesquisaQuarto.Location = new System.Drawing.Point(6, 20);
            this.comboBoxPesquisaQuarto.MaxDropDownItems = 10;
            this.comboBoxPesquisaQuarto.Name = "comboBoxPesquisaQuarto";
            this.comboBoxPesquisaQuarto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxPesquisaQuarto.Size = new System.Drawing.Size(289, 21);
            this.comboBoxPesquisaQuarto.TabIndex = 12;
            this.comboBoxPesquisaQuarto.ValueMember = "Id";
            this.comboBoxPesquisaQuarto.SelectedIndexChanged += new System.EventHandler(this.comboBoxPesquisaQuarto_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.Width = 30;
            // 
            // dataGridViewImageColumn5
            // 
            this.dataGridViewImageColumn5.HeaderText = "";
            this.dataGridViewImageColumn5.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn5.Image")));
            this.dataGridViewImageColumn5.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn5.Name = "dataGridViewImageColumn5";
            this.dataGridViewImageColumn5.ReadOnly = true;
            this.dataGridViewImageColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn5.Width = 30;
            // 
            // UCQuartoLeito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.tabControlQuartoLeito);
            this.Name = "UCQuartoLeito";
            this.Size = new System.Drawing.Size(777, 546);
            this.Load += new System.EventHandler(this.UCQuartoLeito_Load);
            this.tabControlQuartoLeito.ResumeLayout(false);
            this.tabPageQuartos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuartos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabPageLeito.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeito)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gLeito.ResumeLayout(false);
            this.gLeito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageInernacao.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlQuartoLeito;
        private System.Windows.Forms.TabPage tabPageQuartos;
        private System.Windows.Forms.TabPage tabPageLeito;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.GroupBox gLeito;
        private System.Windows.Forms.TextBox textBoxNomeLeito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxIdLeito;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxQuarto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewLeito;
        private System.Windows.Forms.TextBox textBoxPesquisaLeito;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn5;
        private System.Windows.Forms.Button button1;
        private TextBox textBoxlLeitoQtd;
        private Label label4;
        private Label label5;
        private TextBox textBoxTotalLeitos;
        private TextBox textBoxIdLeitoQuarto;
        private TabPage tabPageInernacao;
        private FlowLayoutPanel flowLayoutPanelImgLeito;
        private Panel panel4;
        private Panel panel3;
        private ComboBox comboBoxPesquisaQuarto;
        private GroupBox groupBox4;
        private GroupBox groupBox2;
        private Button buttonLimpar;
        private TextBox textBoxPesquisaQuarto;
        private DataGridView dataGridViewQuartos;
        private TextBox textBoxId;
        private ComboBox comboBoxSetor;
        private TextBox textBoxNomeQuarto;
        private Label label2;
        private Label lbltitulo;
        private Label label1;
        private ComboBox comboBoxQtdLeitos;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel5;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Panel panel6;
        private PictureBox pictureBox4;
        private Panel panel8;
        private PictureBox pictureBox3;
        private Panel panel7;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn IDSETOR;
        private DataGridViewTextBoxColumn NomeQuarto;
        private DataGridViewTextBoxColumn TotalLeito;
        private DataGridViewImageColumn Editar;
        private DataGridViewImageColumn Excluir;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewImageColumn isDisponivel;
        private DataGridViewImageColumn dataGridViewImageColumn3;
        private DataGridViewImageColumn dataGridViewImageColumn4;
    }
}
