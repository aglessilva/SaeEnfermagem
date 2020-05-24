namespace AppInternacao
{
    partial class FrmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewPaciente = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prontuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelScreen = new System.Windows.Forms.Panel();
            this.panelDropDown = new System.Windows.Forms.Panel();
            this.timerCollapsed = new System.Windows.Forms.Timer(this.components);
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.btnGerenciamentoLeito = new System.Windows.Forms.Button();
            this.btnCMAdulto = new System.Windows.Forms.Button();
            this.btnUrgenciaEmergencia = new System.Windows.Forms.Button();
            this.btnClinicaObstetrica = new System.Windows.Forms.Button();
            this.btnClinicaCirurgica = new System.Windows.Forms.Button();
            this.btnClinicaPediatrica = new System.Windows.Forms.Button();
            this.btnClinicaMedica = new System.Windows.Forms.Button();
            this.btnAddSae = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaciente)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panelCabecalho.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelScreen.SuspendLayout();
            this.panelDropDown.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.AutoScrollMinSize = new System.Drawing.Size(100, 100);
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel1.BackgroundImage = global::AppInternacao.Properties.Resources.heartbeat_icon_icons_com_56347;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewPaciente);
            this.splitContainer1.Panel2.Controls.Add(this.buttonLimpar);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1092, 524);
            this.splitContainer1.SplitterDistance = 811;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridViewPaciente
            // 
            this.dataGridViewPaciente.AllowUserToAddRows = false;
            this.dataGridViewPaciente.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dataGridViewPaciente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPaciente.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewPaciente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPaciente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPaciente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Prontuario});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPaciente.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPaciente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPaciente.Location = new System.Drawing.Point(0, 69);
            this.dataGridViewPaciente.MultiSelect = false;
            this.dataGridViewPaciente.Name = "dataGridViewPaciente";
            this.dataGridViewPaciente.ReadOnly = true;
            this.dataGridViewPaciente.RowHeadersVisible = false;
            this.dataGridViewPaciente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPaciente.Size = new System.Drawing.Size(277, 453);
            this.dataGridViewPaciente.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Prontuario
            // 
            this.Prontuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prontuario.DataPropertyName = "Prontuario";
            this.Prontuario.HeaderText = "Prontuario";
            this.Prontuario.Name = "Prontuario";
            this.Prontuario.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textPesquisa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 43);
            this.panel1.TabIndex = 2;
            // 
            // textPesquisa
            // 
            this.textPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textPesquisa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPesquisa.Location = new System.Drawing.Point(0, 23);
            this.textPesquisa.MaxLength = 30;
            this.textPesquisa.Name = "textPesquisa";
            this.textPesquisa.Size = new System.Drawing.Size(277, 20);
            this.textPesquisa.TabIndex = 0;
            this.textPesquisa.WordWrap = false;
            this.textPesquisa.TextChanged += new System.EventHandler(this.textPesquisa_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisa: Prontuário ou  Nome ";
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.panelTitle.Controls.Add(this.panelCabecalho);
            this.panelTitle.Controls.Add(this.label2);
            this.panelTitle.Controls.Add(this.btnSair);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1261, 37);
            this.panelTitle.TabIndex = 1;
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.Controls.Add(this.btnSalvar);
            this.panelCabecalho.Controls.Add(this.btnNovo);
            this.panelCabecalho.Controls.Add(this.btnImprimir);
            this.panelCabecalho.Location = new System.Drawing.Point(1, 1);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(310, 36);
            this.panelCabecalho.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(836, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sistematização da Assistêmcia de Enfermagem";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.panelMenu.Controls.Add(this.panelButtons);
            this.panelMenu.Controls.Add(this.panelDropDown);
            this.panelMenu.Controls.Add(this.btnAddSae);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 37);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(169, 524);
            this.panelMenu.TabIndex = 2;
            // 
            // panelScreen
            // 
            this.panelScreen.Controls.Add(this.splitContainer1);
            this.panelScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelScreen.Location = new System.Drawing.Point(169, 37);
            this.panelScreen.Name = "panelScreen";
            this.panelScreen.Size = new System.Drawing.Size(1092, 524);
            this.panelScreen.TabIndex = 0;
            // 
            // panelDropDown
            // 
            this.panelDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.panelDropDown.Controls.Add(this.btnUrgenciaEmergencia);
            this.panelDropDown.Controls.Add(this.btnClinicaObstetrica);
            this.panelDropDown.Controls.Add(this.btnClinicaCirurgica);
            this.panelDropDown.Controls.Add(this.btnClinicaPediatrica);
            this.panelDropDown.Controls.Add(this.btnClinicaMedica);
            this.panelDropDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDropDown.Location = new System.Drawing.Point(0, 37);
            this.panelDropDown.MaximumSize = new System.Drawing.Size(169, 181);
            this.panelDropDown.MinimumSize = new System.Drawing.Size(169, 0);
            this.panelDropDown.Name = "panelDropDown";
            this.panelDropDown.Size = new System.Drawing.Size(169, 0);
            this.panelDropDown.TabIndex = 10;
            // 
            // timerCollapsed
            // 
            this.timerCollapsed.Interval = 15;
            this.timerCollapsed.Tick += new System.EventHandler(this.timerCollapsed_Tick);
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnPaciente);
            this.panelButtons.Controls.Add(this.btnGerenciamentoLeito);
            this.panelButtons.Controls.Add(this.btnCMAdulto);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 37);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(169, 140);
            this.panelButtons.TabIndex = 6;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.Color.Transparent;
            this.buttonLimpar.BackgroundImage = global::AppInternacao.Properties.Resources.Childish_Cross_24996;
            this.buttonLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLimpar.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonLimpar.FlatAppearance.BorderSize = 0;
            this.buttonLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.buttonLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLimpar.Location = new System.Drawing.Point(0, 43);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(277, 26);
            this.buttonLimpar.TabIndex = 2;
            this.buttonLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // btnPaciente
            // 
            this.btnPaciente.BackColor = System.Drawing.Color.Transparent;
            this.btnPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaciente.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnPaciente.FlatAppearance.BorderSize = 0;
            this.btnPaciente.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btnPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPaciente.Image = global::AppInternacao.Properties.Resources.Saeico01;
            this.btnPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaciente.Location = new System.Drawing.Point(0, 49);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(169, 29);
            this.btnPaciente.TabIndex = 2;
            this.btnPaciente.Text = "Cadastrar Paciente";
            this.btnPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPaciente.UseVisualStyleBackColor = false;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // btnGerenciamentoLeito
            // 
            this.btnGerenciamentoLeito.BackColor = System.Drawing.Color.Transparent;
            this.btnGerenciamentoLeito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGerenciamentoLeito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerenciamentoLeito.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnGerenciamentoLeito.FlatAppearance.BorderSize = 0;
            this.btnGerenciamentoLeito.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGerenciamentoLeito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btnGerenciamentoLeito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerenciamentoLeito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciamentoLeito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGerenciamentoLeito.Image = global::AppInternacao.Properties.Resources.summer_vacation_beach_bed_sun_bathing_sunbed_icon_133411;
            this.btnGerenciamentoLeito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerenciamentoLeito.Location = new System.Drawing.Point(0, 8);
            this.btnGerenciamentoLeito.Name = "btnGerenciamentoLeito";
            this.btnGerenciamentoLeito.Size = new System.Drawing.Size(169, 29);
            this.btnGerenciamentoLeito.TabIndex = 5;
            this.btnGerenciamentoLeito.Text = "Administração de  Leito";
            this.btnGerenciamentoLeito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGerenciamentoLeito.UseVisualStyleBackColor = false;
            this.btnGerenciamentoLeito.Click += new System.EventHandler(this.btnGerenciamentoLeito_Click);
            // 
            // btnCMAdulto
            // 
            this.btnCMAdulto.BackColor = System.Drawing.Color.Transparent;
            this.btnCMAdulto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCMAdulto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCMAdulto.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCMAdulto.FlatAppearance.BorderSize = 0;
            this.btnCMAdulto.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCMAdulto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btnCMAdulto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCMAdulto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCMAdulto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCMAdulto.Image = global::AppInternacao.Properties.Resources.people_virus_spreading_corona_covid_icon_141669;
            this.btnCMAdulto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCMAdulto.Location = new System.Drawing.Point(0, 88);
            this.btnCMAdulto.Name = "btnCMAdulto";
            this.btnCMAdulto.Size = new System.Drawing.Size(169, 29);
            this.btnCMAdulto.TabIndex = 4;
            this.btnCMAdulto.Text = "Clinica Médica Adulto";
            this.btnCMAdulto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCMAdulto.UseVisualStyleBackColor = false;
            this.btnCMAdulto.Click += new System.EventHandler(this.btnCMAdulto_Click);
            // 
            // btnUrgenciaEmergencia
            // 
            this.btnUrgenciaEmergencia.BackColor = System.Drawing.Color.Transparent;
            this.btnUrgenciaEmergencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUrgenciaEmergencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUrgenciaEmergencia.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnUrgenciaEmergencia.FlatAppearance.BorderSize = 0;
            this.btnUrgenciaEmergencia.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUrgenciaEmergencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnUrgenciaEmergencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrgenciaEmergencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrgenciaEmergencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUrgenciaEmergencia.Image = global::AppInternacao.Properties.Resources.hospital_doctor_10739;
            this.btnUrgenciaEmergencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrgenciaEmergencia.Location = new System.Drawing.Point(0, 146);
            this.btnUrgenciaEmergencia.Name = "btnUrgenciaEmergencia";
            this.btnUrgenciaEmergencia.Size = new System.Drawing.Size(169, 29);
            this.btnUrgenciaEmergencia.TabIndex = 12;
            this.btnUrgenciaEmergencia.Text = "Urgência/Emergência";
            this.btnUrgenciaEmergencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUrgenciaEmergencia.UseVisualStyleBackColor = false;
            // 
            // btnClinicaObstetrica
            // 
            this.btnClinicaObstetrica.BackColor = System.Drawing.Color.Transparent;
            this.btnClinicaObstetrica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClinicaObstetrica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClinicaObstetrica.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClinicaObstetrica.FlatAppearance.BorderSize = 0;
            this.btnClinicaObstetrica.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClinicaObstetrica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnClinicaObstetrica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClinicaObstetrica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClinicaObstetrica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClinicaObstetrica.Image = global::AppInternacao.Properties.Resources.toddler;
            this.btnClinicaObstetrica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClinicaObstetrica.Location = new System.Drawing.Point(0, 111);
            this.btnClinicaObstetrica.Name = "btnClinicaObstetrica";
            this.btnClinicaObstetrica.Size = new System.Drawing.Size(169, 29);
            this.btnClinicaObstetrica.TabIndex = 11;
            this.btnClinicaObstetrica.Text = "Clinica Obstétrica";
            this.btnClinicaObstetrica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClinicaObstetrica.UseVisualStyleBackColor = false;
            // 
            // btnClinicaCirurgica
            // 
            this.btnClinicaCirurgica.BackColor = System.Drawing.Color.Transparent;
            this.btnClinicaCirurgica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClinicaCirurgica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClinicaCirurgica.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClinicaCirurgica.FlatAppearance.BorderSize = 0;
            this.btnClinicaCirurgica.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClinicaCirurgica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnClinicaCirurgica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClinicaCirurgica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClinicaCirurgica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClinicaCirurgica.Image = global::AppInternacao.Properties.Resources.ClinicaMedica;
            this.btnClinicaCirurgica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClinicaCirurgica.Location = new System.Drawing.Point(0, 76);
            this.btnClinicaCirurgica.Name = "btnClinicaCirurgica";
            this.btnClinicaCirurgica.Size = new System.Drawing.Size(169, 29);
            this.btnClinicaCirurgica.TabIndex = 10;
            this.btnClinicaCirurgica.Text = "Clinica Cirurgica";
            this.btnClinicaCirurgica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClinicaCirurgica.UseVisualStyleBackColor = false;
            // 
            // btnClinicaPediatrica
            // 
            this.btnClinicaPediatrica.BackColor = System.Drawing.Color.Transparent;
            this.btnClinicaPediatrica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClinicaPediatrica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClinicaPediatrica.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClinicaPediatrica.FlatAppearance.BorderSize = 0;
            this.btnClinicaPediatrica.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClinicaPediatrica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnClinicaPediatrica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClinicaPediatrica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClinicaPediatrica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClinicaPediatrica.Image = global::AppInternacao.Properties.Resources.crianca;
            this.btnClinicaPediatrica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClinicaPediatrica.Location = new System.Drawing.Point(0, 41);
            this.btnClinicaPediatrica.Name = "btnClinicaPediatrica";
            this.btnClinicaPediatrica.Size = new System.Drawing.Size(169, 29);
            this.btnClinicaPediatrica.TabIndex = 9;
            this.btnClinicaPediatrica.Text = "Clinica Pediátrica";
            this.btnClinicaPediatrica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClinicaPediatrica.UseVisualStyleBackColor = false;
            // 
            // btnClinicaMedica
            // 
            this.btnClinicaMedica.BackColor = System.Drawing.Color.Transparent;
            this.btnClinicaMedica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClinicaMedica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClinicaMedica.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClinicaMedica.FlatAppearance.BorderSize = 0;
            this.btnClinicaMedica.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClinicaMedica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnClinicaMedica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClinicaMedica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClinicaMedica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClinicaMedica.Image = global::AppInternacao.Properties.Resources.ic_people_outline_128_28591;
            this.btnClinicaMedica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClinicaMedica.Location = new System.Drawing.Point(0, 6);
            this.btnClinicaMedica.Name = "btnClinicaMedica";
            this.btnClinicaMedica.Size = new System.Drawing.Size(169, 29);
            this.btnClinicaMedica.TabIndex = 8;
            this.btnClinicaMedica.Text = "Clinica Médica";
            this.btnClinicaMedica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClinicaMedica.UseVisualStyleBackColor = false;
            this.btnClinicaMedica.Click += new System.EventHandler(this.btnClinicaMedica_Click);
            // 
            // btnAddSae
            // 
            this.btnAddSae.BackColor = System.Drawing.Color.Transparent;
            this.btnAddSae.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddSae.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSae.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddSae.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAddSae.FlatAppearance.BorderSize = 0;
            this.btnAddSae.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddSae.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btnAddSae.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSae.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSae.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddSae.Image = global::AppInternacao.Properties.Resources.nurse_person_woman_people_1697;
            this.btnAddSae.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSae.Location = new System.Drawing.Point(0, 0);
            this.btnAddSae.Name = "btnAddSae";
            this.btnAddSae.Size = new System.Drawing.Size(169, 37);
            this.btnAddSae.TabIndex = 9;
            this.btnAddSae.Text = "Adcionar Novo SAE";
            this.btnAddSae.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddSae.UseVisualStyleBackColor = false;
            this.btnAddSae.Click += new System.EventHandler(this.btnAddSae_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalvar.Image = global::AppInternacao.Properties.Resources.Save_Icon_icon_icons_com_69139;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(187, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(85, 29);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.Transparent;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNovo.Image = global::AppInternacao.Properties.Resources.newFile;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(96, 4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(85, 29);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnImprimir.Image = global::AppInternacao.Properties.Resources.PhotoPrint_6314;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(4, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(85, 29);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSair.Image = global::AppInternacao.Properties.Resources.closeTela;
            this.btnSair.Location = new System.Drawing.Point(1226, 6);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(32, 25);
            this.btnSair.TabIndex = 3;
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1261, 561);
            this.Controls.Add(this.panelScreen);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaciente)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelCabecalho.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelScreen.ResumeLayout(false);
            this.panelDropDown.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPesquisa;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.DataGridView dataGridViewPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prontuario;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelScreen;
        private System.Windows.Forms.Button btnCMAdulto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGerenciamentoLeito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Panel panelDropDown;
        private System.Windows.Forms.Button btnUrgenciaEmergencia;
        private System.Windows.Forms.Button btnClinicaObstetrica;
        private System.Windows.Forms.Button btnClinicaCirurgica;
        private System.Windows.Forms.Button btnClinicaPediatrica;
        private System.Windows.Forms.Button btnClinicaMedica;
        private System.Windows.Forms.Button btnAddSae;
        private System.Windows.Forms.Timer timerCollapsed;
        private System.Windows.Forms.Panel panelButtons;
    }
}

