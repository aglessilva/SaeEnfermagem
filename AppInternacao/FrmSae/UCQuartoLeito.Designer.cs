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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlQuartoLeito = new System.Windows.Forms.TabControl();
            this.tabPageQuartos = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelGridPesquisaQuarto = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.dataGridViewQuartos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDSETOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeQuarto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalLeito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.textBoxPesquisaQuarto = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.comboBoxSetor = new System.Windows.Forms.ComboBox();
            this.textBoxNomeQuarto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxQtdLeitos = new System.Windows.Forms.ComboBox();
            this.tabPageLeito = new System.Windows.Forms.TabPage();
            this.gLeito = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewLeito = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDisponivel = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.textBoxPesquisaLeito = new System.Windows.Forms.TextBox();
            this.panelLeito = new System.Windows.Forms.Panel();
            this.textBoxNomeLeito = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxIdLeito = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxQuarto = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.textBoxlLeitoQtd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControlQuartoLeito.SuspendLayout();
            this.tabPageQuartos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelGridPesquisaQuarto.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuartos)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPageLeito.SuspendLayout();
            this.gLeito.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeito)).BeginInit();
            this.panelLeito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlQuartoLeito
            // 
            this.tabControlQuartoLeito.Controls.Add(this.tabPageQuartos);
            this.tabControlQuartoLeito.Controls.Add(this.tabPageLeito);
            this.tabControlQuartoLeito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlQuartoLeito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlQuartoLeito.Location = new System.Drawing.Point(0, 0);
            this.tabControlQuartoLeito.Multiline = true;
            this.tabControlQuartoLeito.Name = "tabControlQuartoLeito";
            this.tabControlQuartoLeito.SelectedIndex = 0;
            this.tabControlQuartoLeito.Size = new System.Drawing.Size(716, 537);
            this.tabControlQuartoLeito.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlQuartoLeito.TabIndex = 0;
            // 
            // tabPageQuartos
            // 
            this.tabPageQuartos.BackColor = System.Drawing.Color.Transparent;
            this.tabPageQuartos.Controls.Add(this.groupBox1);
            this.tabPageQuartos.Location = new System.Drawing.Point(4, 22);
            this.tabPageQuartos.Name = "tabPageQuartos";
            this.tabPageQuartos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQuartos.Size = new System.Drawing.Size(708, 511);
            this.tabPageQuartos.TabIndex = 0;
            this.tabPageQuartos.Text = "Quartos";
            this.tabPageQuartos.ToolTipText = "Gerenciamento de Quartos";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.groupBox1.Controls.Add(this.panelGridPesquisaQuarto);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 505);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Quartos";
            // 
            // panelGridPesquisaQuarto
            // 
            this.panelGridPesquisaQuarto.Controls.Add(this.groupBox2);
            this.panelGridPesquisaQuarto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGridPesquisaQuarto.Location = new System.Drawing.Point(3, 74);
            this.panelGridPesquisaQuarto.Name = "panelGridPesquisaQuarto";
            this.panelGridPesquisaQuarto.Size = new System.Drawing.Size(696, 428);
            this.panelGridPesquisaQuarto.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonLimpar);
            this.groupBox2.Controls.Add(this.dataGridViewQuartos);
            this.groupBox2.Controls.Add(this.textBoxPesquisaQuarto);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(696, 428);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisa de Quartos";
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.Color.Transparent;
            this.buttonLimpar.BackgroundImage = global::AppInternacao.Properties.Resources.Childish_Cross_24996;
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
            this.buttonLimpar.Location = new System.Drawing.Point(217, 24);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(26, 20);
            this.buttonLimpar.TabIndex = 9;
            this.buttonLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // dataGridViewQuartos
            // 
            this.dataGridViewQuartos.AllowUserToAddRows = false;
            this.dataGridViewQuartos.AllowUserToDeleteRows = false;
            this.dataGridViewQuartos.AllowUserToResizeRows = false;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dataGridViewQuartos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle36;
            this.dataGridViewQuartos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewQuartos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewQuartos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewQuartos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.dataGridViewQuartos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuartos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.IDSETOR,
            this.NomeQuarto,
            this.TotalLeito,
            this.Editar,
            this.Excluir});
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewQuartos.DefaultCellStyle = dataGridViewCellStyle38;
            this.dataGridViewQuartos.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewQuartos.Location = new System.Drawing.Point(6, 55);
            this.dataGridViewQuartos.Name = "dataGridViewQuartos";
            this.dataGridViewQuartos.ReadOnly = true;
            this.dataGridViewQuartos.RowHeadersVisible = false;
            this.dataGridViewQuartos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewQuartos.Size = new System.Drawing.Size(386, 370);
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
            this.TotalLeito.Width = 30;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Image = global::AppInternacao.Properties.Resources.file_edit_114433;
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            this.Excluir.Width = 30;
            // 
            // textBoxPesquisaQuarto
            // 
            this.textBoxPesquisaQuarto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPesquisaQuarto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxPesquisaQuarto.Location = new System.Drawing.Point(6, 24);
            this.textBoxPesquisaQuarto.Name = "textBoxPesquisaQuarto";
            this.textBoxPesquisaQuarto.Size = new System.Drawing.Size(207, 20);
            this.textBoxPesquisaQuarto.TabIndex = 7;
            this.textBoxPesquisaQuarto.TextChanged += new System.EventHandler(this.textBoxPesquisaQuarto_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxId);
            this.panel1.Controls.Add(this.comboBoxSetor);
            this.panel1.Controls.Add(this.textBoxNomeQuarto);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbltitulo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxQtdLeitos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 58);
            this.panel1.TabIndex = 11;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(217, 23);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(28, 20);
            this.textBoxId.TabIndex = 11;
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
            this.comboBoxSetor.Location = new System.Drawing.Point(431, 24);
            this.comboBoxSetor.MaxDropDownItems = 10;
            this.comboBoxSetor.Name = "comboBoxSetor";
            this.comboBoxSetor.Size = new System.Drawing.Size(226, 21);
            this.comboBoxSetor.TabIndex = 10;
            this.comboBoxSetor.ValueMember = "Id";
            // 
            // textBoxNomeQuarto
            // 
            this.textBoxNomeQuarto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNomeQuarto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNomeQuarto.Location = new System.Drawing.Point(6, 24);
            this.textBoxNomeQuarto.MaxLength = 20;
            this.textBoxNomeQuarto.Name = "textBoxNomeQuarto";
            this.textBoxNomeQuarto.Size = new System.Drawing.Size(207, 20);
            this.textBoxNomeQuarto.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Setor";
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Location = new System.Drawing.Point(5, 7);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(85, 13);
            this.lbltitulo.TabIndex = 4;
            this.lbltitulo.Text = "Nome do Quarto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 5;
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
            this.comboBoxQtdLeitos.Location = new System.Drawing.Point(254, 23);
            this.comboBoxQtdLeitos.MaxDropDownItems = 10;
            this.comboBoxQtdLeitos.Name = "comboBoxQtdLeitos";
            this.comboBoxQtdLeitos.Size = new System.Drawing.Size(128, 21);
            this.comboBoxQtdLeitos.TabIndex = 6;
            // 
            // tabPageLeito
            // 
            this.tabPageLeito.BackColor = System.Drawing.Color.Transparent;
            this.tabPageLeito.Controls.Add(this.gLeito);
            this.tabPageLeito.Location = new System.Drawing.Point(4, 22);
            this.tabPageLeito.Name = "tabPageLeito";
            this.tabPageLeito.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLeito.Size = new System.Drawing.Size(708, 511);
            this.tabPageLeito.TabIndex = 1;
            this.tabPageLeito.Text = "Leitos";
            // 
            // gLeito
            // 
            this.gLeito.Controls.Add(this.groupBox3);
            this.gLeito.Controls.Add(this.panelLeito);
            this.gLeito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gLeito.Location = new System.Drawing.Point(3, 3);
            this.gLeito.Name = "gLeito";
            this.gLeito.Size = new System.Drawing.Size(702, 505);
            this.gLeito.TabIndex = 0;
            this.gLeito.TabStop = false;
            this.gLeito.Text = "Cadastro de Leitos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.dataGridViewLeito);
            this.groupBox3.Controls.Add(this.textBoxPesquisaLeito);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(696, 428);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pesquisa de Leitos";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::AppInternacao.Properties.Resources.Childish_Cross_24996;
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
            this.button1.Location = new System.Drawing.Point(217, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 20);
            this.button1.TabIndex = 10;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewLeito
            // 
            this.dataGridViewLeito.AllowUserToAddRows = false;
            this.dataGridViewLeito.AllowUserToDeleteRows = false;
            this.dataGridViewLeito.AllowUserToResizeRows = false;
            dataGridViewCellStyle39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dataGridViewLeito.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle39;
            this.dataGridViewLeito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewLeito.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewLeito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle40.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle40.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLeito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle40;
            this.dataGridViewLeito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLeito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.isDisponivel,
            this.dataGridViewImageColumn3,
            this.dataGridViewImageColumn4});
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle41.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle41.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle41.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle41.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLeito.DefaultCellStyle = dataGridViewCellStyle41;
            this.dataGridViewLeito.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewLeito.Location = new System.Drawing.Point(6, 55);
            this.dataGridViewLeito.Name = "dataGridViewLeito";
            this.dataGridViewLeito.ReadOnly = true;
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle42.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLeito.RowHeadersDefaultCellStyle = dataGridViewCellStyle42;
            this.dataGridViewLeito.RowHeadersVisible = false;
            this.dataGridViewLeito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLeito.Size = new System.Drawing.Size(386, 370);
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
            this.isDisponivel.HeaderText = "Disp";
            this.isDisponivel.Name = "isDisponivel";
            this.isDisponivel.ReadOnly = true;
            this.isDisponivel.Width = 30;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::AppInternacao.Properties.Resources.file_edit_114433;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            this.dataGridViewImageColumn4.Width = 30;
            // 
            // textBoxPesquisaLeito
            // 
            this.textBoxPesquisaLeito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPesquisaLeito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxPesquisaLeito.Location = new System.Drawing.Point(6, 24);
            this.textBoxPesquisaLeito.Name = "textBoxPesquisaLeito";
            this.textBoxPesquisaLeito.Size = new System.Drawing.Size(207, 20);
            this.textBoxPesquisaLeito.TabIndex = 7;
            this.textBoxPesquisaLeito.TextChanged += new System.EventHandler(this.textBoxPesquisaLeito_TextChanged);
            // 
            // panelLeito
            // 
            this.panelLeito.Controls.Add(this.label4);
            this.panelLeito.Controls.Add(this.textBoxlLeitoQtd);
            this.panelLeito.Controls.Add(this.textBoxNomeLeito);
            this.panelLeito.Controls.Add(this.label3);
            this.panelLeito.Controls.Add(this.textBoxIdLeito);
            this.panelLeito.Controls.Add(this.label7);
            this.panelLeito.Controls.Add(this.comboBoxQuarto);
            this.panelLeito.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLeito.Location = new System.Drawing.Point(3, 16);
            this.panelLeito.Name = "panelLeito";
            this.panelLeito.Size = new System.Drawing.Size(696, 58);
            this.panelLeito.TabIndex = 12;
            // 
            // textBoxNomeLeito
            // 
            this.textBoxNomeLeito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNomeLeito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNomeLeito.Location = new System.Drawing.Point(6, 24);
            this.textBoxNomeLeito.MaxLength = 20;
            this.textBoxNomeLeito.Name = "textBoxNomeLeito";
            this.textBoxNomeLeito.Size = new System.Drawing.Size(207, 20);
            this.textBoxNomeLeito.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome do Leito";
            // 
            // textBoxIdLeito
            // 
            this.textBoxIdLeito.Location = new System.Drawing.Point(216, 23);
            this.textBoxIdLeito.Name = "textBoxIdLeito";
            this.textBoxIdLeito.Size = new System.Drawing.Size(29, 20);
            this.textBoxIdLeito.TabIndex = 0;
            this.textBoxIdLeito.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(251, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Quarto";
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
            this.comboBoxQuarto.Location = new System.Drawing.Point(254, 23);
            this.comboBoxQuarto.MaxDropDownItems = 10;
            this.comboBoxQuarto.Name = "comboBoxQuarto";
            this.comboBoxQuarto.Size = new System.Drawing.Size(205, 21);
            this.comboBoxQuarto.TabIndex = 6;
            this.comboBoxQuarto.ValueMember = "Id";
            this.comboBoxQuarto.SelectedIndexChanged += new System.EventHandler(this.comboBoxQuarto_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::AppInternacao.Properties.Resources.file_edit_114433;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::AppInternacao.Properties.Resources.Childish_Cross_24996;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.Width = 30;
            // 
            // dataGridViewImageColumn5
            // 
            this.dataGridViewImageColumn5.HeaderText = "";
            this.dataGridViewImageColumn5.Image = global::AppInternacao.Properties.Resources.Childish_Cross_24996;
            this.dataGridViewImageColumn5.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn5.Name = "dataGridViewImageColumn5";
            this.dataGridViewImageColumn5.ReadOnly = true;
            this.dataGridViewImageColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn5.Width = 30;
            // 
            // textBoxlLeitoQtd
            // 
            this.textBoxlLeitoQtd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxlLeitoQtd.Enabled = false;
            this.textBoxlLeitoQtd.Location = new System.Drawing.Point(477, 24);
            this.textBoxlLeitoQtd.Name = "textBoxlLeitoQtd";
            this.textBoxlLeitoQtd.Size = new System.Drawing.Size(22, 20);
            this.textBoxlLeitoQtd.TabIndex = 7;
            this.textBoxlLeitoQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(505, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Leitos restantes";
            // 
            // UCQuartoLeito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.tabControlQuartoLeito);
            this.Name = "UCQuartoLeito";
            this.Size = new System.Drawing.Size(716, 537);
            this.Load += new System.EventHandler(this.UCQuartoLeito_Load);
            this.tabControlQuartoLeito.ResumeLayout(false);
            this.tabPageQuartos.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panelGridPesquisaQuarto.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuartos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPageLeito.ResumeLayout(false);
            this.gLeito.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeito)).EndInit();
            this.panelLeito.ResumeLayout(false);
            this.panelLeito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlQuartoLeito;
        private System.Windows.Forms.TabPage tabPageQuartos;
        private System.Windows.Forms.TabPage tabPageLeito;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxQtdLeitos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.TextBox textBoxNomeQuarto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewQuartos;
        private System.Windows.Forms.TextBox textBoxPesquisaQuarto;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox comboBoxSetor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelGridPesquisaQuarto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.GroupBox gLeito;
        private System.Windows.Forms.Panel panelLeito;
        private System.Windows.Forms.TextBox textBoxNomeLeito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxIdLeito;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxQuarto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewLeito;
        private System.Windows.Forms.TextBox textBoxPesquisaLeito;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn5;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewImageColumn isDisponivel;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSETOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeQuarto;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalLeito;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Excluir;
        private System.Windows.Forms.Button button1;
        private TextBox textBoxlLeitoQtd;
        private Label label4;
    }
}
