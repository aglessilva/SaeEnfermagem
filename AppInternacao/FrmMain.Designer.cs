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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblTitleForm = new System.Windows.Forms.Label();
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.btnAddGeneric = new FontAwesome.Sharp.IconButton();
            this.btnSalvar = new FontAwesome.Sharp.IconButton();
            this.btnNovo = new FontAwesome.Sharp.IconButton();
            this.btnImprimir = new FontAwesome.Sharp.IconButton();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelScreen = new System.Windows.Forms.Panel();
            this.timerCollapsed = new System.Windows.Forms.Timer(this.components);
            this.timerCollapsedTemplate = new System.Windows.Forms.Timer(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnNanda = new FontAwesome.Sharp.IconButton();
            this.btnPaciente = new FontAwesome.Sharp.IconButton();
            this.btnPrescricao = new FontAwesome.Sharp.IconButton();
            this.panelDropDownTemplate = new System.Windows.Forms.Panel();
            this.btnListarModelo = new FontAwesome.Sharp.IconButton();
            this.btnCriarTemplate = new FontAwesome.Sharp.IconButton();
            this.pLogoff = new System.Windows.Forms.Panel();
            this.btnAlterarSenha = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnTempalte = new FontAwesome.Sharp.IconButton();
            this.btnGerenciamentoLeito = new FontAwesome.Sharp.IconButton();
            this.panelDropDown = new System.Windows.Forms.Panel();
            this.iconBtnUrgenciaEmergencia = new FontAwesome.Sharp.IconButton();
            this.iconBtnClinicaObstetrica = new FontAwesome.Sharp.IconButton();
            this.iconBtnClinicaCirurgica = new FontAwesome.Sharp.IconButton();
            this.iconBtnClinicaPediatrica = new FontAwesome.Sharp.IconButton();
            this.btnClinicaMedica = new FontAwesome.Sharp.IconButton();
            this.btnAddSae = new FontAwesome.Sharp.IconButton();
            this.btnAdmUsuario = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panelCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelScreen.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelDropDownTemplate.SuspendLayout();
            this.pLogoff.SuspendLayout();
            this.panelDropDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.BackColor = System.Drawing.Color.Transparent;
            this.splitContainerMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.IsSplitterFixed = true;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.AutoScroll = true;
            this.splitContainerMain.Panel1.AutoScrollMinSize = new System.Drawing.Size(100, 100);
            this.splitContainerMain.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainerMain.Panel1.BackgroundImage = global::AppInternacao.Properties.Resources.heartbeat_icon_icons_com_56347;
            this.splitContainerMain.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainerMain.Panel2Collapsed = true;
            this.splitContainerMain.Size = new System.Drawing.Size(1075, 531);
            this.splitContainerMain.SplitterDistance = 870;
            this.splitContainerMain.SplitterWidth = 2;
            this.splitContainerMain.TabIndex = 0;
            this.splitContainerMain.TabStop = false;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.panelTitle.Controls.Add(this.lblTitleForm);
            this.panelTitle.Controls.Add(this.panelCabecalho);
            this.panelTitle.Controls.Add(this.iconCurrentChildForm);
            this.panelTitle.Controls.Add(this.panel1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1261, 30);
            this.panelTitle.TabIndex = 1;
            // 
            // lblTitleForm
            // 
            this.lblTitleForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitleForm.AutoEllipsis = true;
            this.lblTitleForm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.lblTitleForm.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTitleForm.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblTitleForm.Location = new System.Drawing.Point(598, 4);
            this.lblTitleForm.Name = "lblTitleForm";
            this.lblTitleForm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitleForm.Size = new System.Drawing.Size(624, 18);
            this.lblTitleForm.TabIndex = 0;
            this.lblTitleForm.Text = "Sistematização da Assistêmcia de Enfermagem";
            this.lblTitleForm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.Transparent;
            this.panelCabecalho.Controls.Add(this.btnAddGeneric);
            this.panelCabecalho.Controls.Add(this.btnSalvar);
            this.panelCabecalho.Controls.Add(this.btnNovo);
            this.panelCabecalho.Controls.Add(this.btnImprimir);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCabecalho.Location = new System.Drawing.Point(186, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(406, 30);
            this.panelCabecalho.TabIndex = 5;
            // 
            // btnAddGeneric
            // 
            this.btnAddGeneric.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddGeneric.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddGeneric.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddGeneric.FlatAppearance.BorderSize = 0;
            this.btnAddGeneric.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddGeneric.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnAddGeneric.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGeneric.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGeneric.ForeColor = System.Drawing.Color.White;
            this.btnAddGeneric.IconChar = FontAwesome.Sharp.IconChar.Clone;
            this.btnAddGeneric.IconColor = System.Drawing.Color.Chartreuse;
            this.btnAddGeneric.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddGeneric.IconSize = 28;
            this.btnAddGeneric.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddGeneric.Location = new System.Drawing.Point(241, 0);
            this.btnAddGeneric.Name = "btnAddGeneric";
            this.btnAddGeneric.Size = new System.Drawing.Size(162, 30);
            this.btnAddGeneric.TabIndex = 106;
            this.btnAddGeneric.TabStop = false;
            this.btnAddGeneric.Text = "button generic event";
            this.btnAddGeneric.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddGeneric.UseVisualStyleBackColor = false;
            this.btnAddGeneric.Visible = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSalvar.IconColor = System.Drawing.Color.Chartreuse;
            this.btnSalvar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalvar.IconSize = 28;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(159, 0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(82, 30);
            this.btnSalvar.TabIndex = 103;
            this.btnSalvar.TabStop = false;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Visible = false;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.Transparent;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.btnNovo.IconColor = System.Drawing.Color.Yellow;
            this.btnNovo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNovo.IconSize = 28;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(88, 0);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(71, 30);
            this.btnNovo.TabIndex = 104;
            this.btnNovo.TabStop = false;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Visible = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnImprimir.IconColor = System.Drawing.Color.Cyan;
            this.btnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimir.IconSize = 28;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(0, 0);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(88, 30);
            this.btnImprimir.TabIndex = 107;
            this.btnImprimir.TabStop = false;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Visible = false;
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.Transparent;
            this.iconCurrentChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconCurrentChildForm.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.Chartreuse;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Heartbeat;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.Chartreuse;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 30;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(1228, 0);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(30, 30);
            this.iconCurrentChildForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconCurrentChildForm.TabIndex = 7;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 30);
            this.panel1.TabIndex = 0;
            // 
            // panelScreen
            // 
            this.panelScreen.Controls.Add(this.splitContainerMain);
            this.panelScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelScreen.Location = new System.Drawing.Point(186, 30);
            this.panelScreen.Name = "panelScreen";
            this.panelScreen.Size = new System.Drawing.Size(1075, 531);
            this.panelScreen.TabIndex = 0;
            // 
            // timerCollapsed
            // 
            this.timerCollapsed.Interval = 15;
            this.timerCollapsed.Tick += new System.EventHandler(this.timerCollapsed_Tick);
            // 
            // timerCollapsedTemplate
            // 
            this.timerCollapsedTemplate.Interval = 15;
            this.timerCollapsedTemplate.Tick += new System.EventHandler(this.timerCollapsedTemplate_Tick);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.panelMenu.BackgroundImage = global::AppInternacao.Properties.Resources.backgroudMenu001;
            this.panelMenu.Controls.Add(this.btnNanda);
            this.panelMenu.Controls.Add(this.btnPaciente);
            this.panelMenu.Controls.Add(this.btnPrescricao);
            this.panelMenu.Controls.Add(this.panelDropDownTemplate);
            this.panelMenu.Controls.Add(this.pLogoff);
            this.panelMenu.Controls.Add(this.btnTempalte);
            this.panelMenu.Controls.Add(this.btnGerenciamentoLeito);
            this.panelMenu.Controls.Add(this.panelDropDown);
            this.panelMenu.Controls.Add(this.btnAddSae);
            this.panelMenu.Controls.Add(this.btnAdmUsuario);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 30);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(186, 531);
            this.panelMenu.TabIndex = 2;
            // 
            // btnNanda
            // 
            this.btnNanda.BackColor = System.Drawing.Color.Transparent;
            this.btnNanda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNanda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNanda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNanda.FlatAppearance.BorderSize = 0;
            this.btnNanda.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNanda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btnNanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNanda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNanda.IconChar = FontAwesome.Sharp.IconChar.BookMedical;
            this.btnNanda.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.btnNanda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNanda.IconSize = 30;
            this.btnNanda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNanda.Location = new System.Drawing.Point(0, 520);
            this.btnNanda.Name = "btnNanda";
            this.btnNanda.Size = new System.Drawing.Size(186, 40);
            this.btnNanda.TabIndex = 105;
            this.btnNanda.TabStop = false;
            this.btnNanda.Text = "Pesquisar Diagnósticos";
            this.btnNanda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNanda.UseVisualStyleBackColor = false;
            this.btnNanda.Click += new System.EventHandler(this.btnNanda_Click);
            // 
            // btnPaciente
            // 
            this.btnPaciente.BackColor = System.Drawing.Color.Transparent;
            this.btnPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPaciente.FlatAppearance.BorderSize = 0;
            this.btnPaciente.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btnPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPaciente.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnPaciente.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.btnPaciente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPaciente.IconSize = 30;
            this.btnPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaciente.Location = new System.Drawing.Point(0, 480);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(186, 40);
            this.btnPaciente.TabIndex = 102;
            this.btnPaciente.TabStop = false;
            this.btnPaciente.Text = "Admissão de Pacientes";
            this.btnPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPaciente.UseVisualStyleBackColor = false;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // btnPrescricao
            // 
            this.btnPrescricao.BackColor = System.Drawing.Color.Transparent;
            this.btnPrescricao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrescricao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrescricao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrescricao.FlatAppearance.BorderSize = 0;
            this.btnPrescricao.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrescricao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btnPrescricao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrescricao.IconChar = FontAwesome.Sharp.IconChar.Edge;
            this.btnPrescricao.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.btnPrescricao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrescricao.IconSize = 30;
            this.btnPrescricao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrescricao.Location = new System.Drawing.Point(0, 440);
            this.btnPrescricao.Name = "btnPrescricao";
            this.btnPrescricao.Size = new System.Drawing.Size(186, 40);
            this.btnPrescricao.TabIndex = 14;
            this.btnPrescricao.TabStop = false;
            this.btnPrescricao.Text = "Itens de Evolução Clinica";
            this.btnPrescricao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrescricao.UseVisualStyleBackColor = false;
            this.btnPrescricao.Click += new System.EventHandler(this.btnPrescricao_Click);
            // 
            // panelDropDownTemplate
            // 
            this.panelDropDownTemplate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.panelDropDownTemplate.Controls.Add(this.btnListarModelo);
            this.panelDropDownTemplate.Controls.Add(this.btnCriarTemplate);
            this.panelDropDownTemplate.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDropDownTemplate.Location = new System.Drawing.Point(0, 360);
            this.panelDropDownTemplate.MaximumSize = new System.Drawing.Size(189, 80);
            this.panelDropDownTemplate.MinimumSize = new System.Drawing.Size(189, 0);
            this.panelDropDownTemplate.Name = "panelDropDownTemplate";
            this.panelDropDownTemplate.Size = new System.Drawing.Size(189, 80);
            this.panelDropDownTemplate.TabIndex = 110;
            // 
            // btnListarModelo
            // 
            this.btnListarModelo.BackColor = System.Drawing.Color.Transparent;
            this.btnListarModelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnListarModelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarModelo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListarModelo.FlatAppearance.BorderSize = 0;
            this.btnListarModelo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnListarModelo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnListarModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnListarModelo.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnListarModelo.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnListarModelo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListarModelo.IconSize = 30;
            this.btnListarModelo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarModelo.Location = new System.Drawing.Point(0, 40);
            this.btnListarModelo.Name = "btnListarModelo";
            this.btnListarModelo.Size = new System.Drawing.Size(189, 40);
            this.btnListarModelo.TabIndex = 109;
            this.btnListarModelo.TabStop = false;
            this.btnListarModelo.Text = "Associar Modelo à Setores";
            this.btnListarModelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListarModelo.UseVisualStyleBackColor = false;
            this.btnListarModelo.Click += new System.EventHandler(this.btnListarModelo_Click);
            // 
            // btnCriarTemplate
            // 
            this.btnCriarTemplate.BackColor = System.Drawing.Color.Transparent;
            this.btnCriarTemplate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCriarTemplate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriarTemplate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCriarTemplate.FlatAppearance.BorderSize = 0;
            this.btnCriarTemplate.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCriarTemplate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnCriarTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarTemplate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCriarTemplate.IconChar = FontAwesome.Sharp.IconChar.Blackberry;
            this.btnCriarTemplate.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnCriarTemplate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCriarTemplate.IconSize = 30;
            this.btnCriarTemplate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCriarTemplate.Location = new System.Drawing.Point(0, 0);
            this.btnCriarTemplate.Name = "btnCriarTemplate";
            this.btnCriarTemplate.Size = new System.Drawing.Size(189, 40);
            this.btnCriarTemplate.TabIndex = 108;
            this.btnCriarTemplate.TabStop = false;
            this.btnCriarTemplate.Text = "Modelo de Exame Físico";
            this.btnCriarTemplate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCriarTemplate.UseVisualStyleBackColor = false;
            this.btnCriarTemplate.Click += new System.EventHandler(this.btnCriarTemplate_Click);
            // 
            // pLogoff
            // 
            this.pLogoff.BackColor = System.Drawing.Color.Transparent;
            this.pLogoff.Controls.Add(this.btnAlterarSenha);
            this.pLogoff.Controls.Add(this.btnLogout);
            this.pLogoff.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pLogoff.Location = new System.Drawing.Point(0, 444);
            this.pLogoff.Name = "pLogoff";
            this.pLogoff.Size = new System.Drawing.Size(186, 87);
            this.pLogoff.TabIndex = 13;
            // 
            // btnAlterarSenha
            // 
            this.btnAlterarSenha.BackColor = System.Drawing.Color.Transparent;
            this.btnAlterarSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAlterarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarSenha.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAlterarSenha.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAlterarSenha.FlatAppearance.BorderSize = 0;
            this.btnAlterarSenha.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAlterarSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btnAlterarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAlterarSenha.Image = global::AppInternacao.Properties.Resources.internet_lock_locked_padlock_password_secure_security_icon_127100;
            this.btnAlterarSenha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarSenha.Location = new System.Drawing.Point(0, 7);
            this.btnAlterarSenha.Name = "btnAlterarSenha";
            this.btnAlterarSenha.Size = new System.Drawing.Size(186, 40);
            this.btnAlterarSenha.TabIndex = 12;
            this.btnAlterarSenha.TabStop = false;
            this.btnAlterarSenha.Text = "Alterar Senha de Acesso";
            this.btnAlterarSenha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterarSenha.UseVisualStyleBackColor = false;
            this.btnAlterarSenha.Click += new System.EventHandler(this.btnAlterarSenha_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLogout.Image = global::AppInternacao.Properties.Resources._1485969916_8_shutdown_78906;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 47);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(186, 40);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.TabStop = false;
            this.btnLogout.Text = "Sair / Fechar";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnTempalte
            // 
            this.btnTempalte.BackColor = System.Drawing.Color.Transparent;
            this.btnTempalte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTempalte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTempalte.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTempalte.FlatAppearance.BorderSize = 0;
            this.btnTempalte.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTempalte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btnTempalte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTempalte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTempalte.IconChar = FontAwesome.Sharp.IconChar.Buffer;
            this.btnTempalte.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.btnTempalte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTempalte.IconSize = 30;
            this.btnTempalte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTempalte.Location = new System.Drawing.Point(0, 320);
            this.btnTempalte.Name = "btnTempalte";
            this.btnTempalte.Size = new System.Drawing.Size(186, 40);
            this.btnTempalte.TabIndex = 50;
            this.btnTempalte.TabStop = false;
            this.btnTempalte.Text = "Administração de Template";
            this.btnTempalte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTempalte.UseVisualStyleBackColor = false;
            this.btnTempalte.Click += new System.EventHandler(this.btnTempalte_Click);
            // 
            // btnGerenciamentoLeito
            // 
            this.btnGerenciamentoLeito.BackColor = System.Drawing.Color.Transparent;
            this.btnGerenciamentoLeito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGerenciamentoLeito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerenciamentoLeito.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGerenciamentoLeito.FlatAppearance.BorderSize = 0;
            this.btnGerenciamentoLeito.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGerenciamentoLeito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btnGerenciamentoLeito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerenciamentoLeito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGerenciamentoLeito.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.btnGerenciamentoLeito.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.btnGerenciamentoLeito.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGerenciamentoLeito.IconSize = 30;
            this.btnGerenciamentoLeito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerenciamentoLeito.Location = new System.Drawing.Point(0, 280);
            this.btnGerenciamentoLeito.Name = "btnGerenciamentoLeito";
            this.btnGerenciamentoLeito.Size = new System.Drawing.Size(186, 40);
            this.btnGerenciamentoLeito.TabIndex = 101;
            this.btnGerenciamentoLeito.TabStop = false;
            this.btnGerenciamentoLeito.Text = "Administração de  Leitos";
            this.btnGerenciamentoLeito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGerenciamentoLeito.UseVisualStyleBackColor = false;
            this.btnGerenciamentoLeito.Click += new System.EventHandler(this.btnGerenciamentoLeito_Click);
            // 
            // panelDropDown
            // 
            this.panelDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.panelDropDown.Controls.Add(this.iconBtnUrgenciaEmergencia);
            this.panelDropDown.Controls.Add(this.iconBtnClinicaObstetrica);
            this.panelDropDown.Controls.Add(this.iconBtnClinicaCirurgica);
            this.panelDropDown.Controls.Add(this.iconBtnClinicaPediatrica);
            this.panelDropDown.Controls.Add(this.btnClinicaMedica);
            this.panelDropDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDropDown.Location = new System.Drawing.Point(0, 80);
            this.panelDropDown.MaximumSize = new System.Drawing.Size(189, 200);
            this.panelDropDown.MinimumSize = new System.Drawing.Size(189, 0);
            this.panelDropDown.Name = "panelDropDown";
            this.panelDropDown.Size = new System.Drawing.Size(189, 200);
            this.panelDropDown.TabIndex = 10;
            // 
            // iconBtnUrgenciaEmergencia
            // 
            this.iconBtnUrgenciaEmergencia.BackColor = System.Drawing.Color.Transparent;
            this.iconBtnUrgenciaEmergencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconBtnUrgenciaEmergencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnUrgenciaEmergencia.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnUrgenciaEmergencia.FlatAppearance.BorderSize = 0;
            this.iconBtnUrgenciaEmergencia.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.iconBtnUrgenciaEmergencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.iconBtnUrgenciaEmergencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnUrgenciaEmergencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iconBtnUrgenciaEmergencia.IconChar = FontAwesome.Sharp.IconChar.Crosshairs;
            this.iconBtnUrgenciaEmergencia.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconBtnUrgenciaEmergencia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnUrgenciaEmergencia.IconSize = 30;
            this.iconBtnUrgenciaEmergencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnUrgenciaEmergencia.Location = new System.Drawing.Point(0, 160);
            this.iconBtnUrgenciaEmergencia.Name = "iconBtnUrgenciaEmergencia";
            this.iconBtnUrgenciaEmergencia.Size = new System.Drawing.Size(189, 40);
            this.iconBtnUrgenciaEmergencia.TabIndex = 109;
            this.iconBtnUrgenciaEmergencia.TabStop = false;
            this.iconBtnUrgenciaEmergencia.Text = "Urgência/Emergência";
            this.iconBtnUrgenciaEmergencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconBtnUrgenciaEmergencia.UseVisualStyleBackColor = false;
            this.iconBtnUrgenciaEmergencia.Click += new System.EventHandler(this.iconBtnUrgenciaEmergencia_Click);
            // 
            // iconBtnClinicaObstetrica
            // 
            this.iconBtnClinicaObstetrica.BackColor = System.Drawing.Color.Transparent;
            this.iconBtnClinicaObstetrica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconBtnClinicaObstetrica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnClinicaObstetrica.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnClinicaObstetrica.FlatAppearance.BorderSize = 0;
            this.iconBtnClinicaObstetrica.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.iconBtnClinicaObstetrica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.iconBtnClinicaObstetrica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnClinicaObstetrica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iconBtnClinicaObstetrica.IconChar = FontAwesome.Sharp.IconChar.BabyCarriage;
            this.iconBtnClinicaObstetrica.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconBtnClinicaObstetrica.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnClinicaObstetrica.IconSize = 30;
            this.iconBtnClinicaObstetrica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnClinicaObstetrica.Location = new System.Drawing.Point(0, 120);
            this.iconBtnClinicaObstetrica.Name = "iconBtnClinicaObstetrica";
            this.iconBtnClinicaObstetrica.Size = new System.Drawing.Size(189, 40);
            this.iconBtnClinicaObstetrica.TabIndex = 108;
            this.iconBtnClinicaObstetrica.TabStop = false;
            this.iconBtnClinicaObstetrica.Text = "Clinica Obstétrica";
            this.iconBtnClinicaObstetrica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconBtnClinicaObstetrica.UseVisualStyleBackColor = false;
            this.iconBtnClinicaObstetrica.Click += new System.EventHandler(this.iconBtnClinicaObstetrica_Click);
            // 
            // iconBtnClinicaCirurgica
            // 
            this.iconBtnClinicaCirurgica.BackColor = System.Drawing.Color.Transparent;
            this.iconBtnClinicaCirurgica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconBtnClinicaCirurgica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnClinicaCirurgica.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnClinicaCirurgica.FlatAppearance.BorderSize = 0;
            this.iconBtnClinicaCirurgica.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.iconBtnClinicaCirurgica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.iconBtnClinicaCirurgica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnClinicaCirurgica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iconBtnClinicaCirurgica.IconChar = FontAwesome.Sharp.IconChar.BriefcaseMedical;
            this.iconBtnClinicaCirurgica.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconBtnClinicaCirurgica.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnClinicaCirurgica.IconSize = 30;
            this.iconBtnClinicaCirurgica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnClinicaCirurgica.Location = new System.Drawing.Point(0, 80);
            this.iconBtnClinicaCirurgica.Name = "iconBtnClinicaCirurgica";
            this.iconBtnClinicaCirurgica.Size = new System.Drawing.Size(189, 40);
            this.iconBtnClinicaCirurgica.TabIndex = 107;
            this.iconBtnClinicaCirurgica.TabStop = false;
            this.iconBtnClinicaCirurgica.Text = "Clinica Cirurgica";
            this.iconBtnClinicaCirurgica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconBtnClinicaCirurgica.UseVisualStyleBackColor = false;
            this.iconBtnClinicaCirurgica.Click += new System.EventHandler(this.iconBtnClinicaCirurgica_Click);
            // 
            // iconBtnClinicaPediatrica
            // 
            this.iconBtnClinicaPediatrica.BackColor = System.Drawing.Color.Transparent;
            this.iconBtnClinicaPediatrica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconBtnClinicaPediatrica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconBtnClinicaPediatrica.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnClinicaPediatrica.FlatAppearance.BorderSize = 0;
            this.iconBtnClinicaPediatrica.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.iconBtnClinicaPediatrica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.iconBtnClinicaPediatrica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnClinicaPediatrica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iconBtnClinicaPediatrica.IconChar = FontAwesome.Sharp.IconChar.Baby;
            this.iconBtnClinicaPediatrica.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconBtnClinicaPediatrica.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnClinicaPediatrica.IconSize = 30;
            this.iconBtnClinicaPediatrica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnClinicaPediatrica.Location = new System.Drawing.Point(0, 40);
            this.iconBtnClinicaPediatrica.Name = "iconBtnClinicaPediatrica";
            this.iconBtnClinicaPediatrica.Size = new System.Drawing.Size(189, 40);
            this.iconBtnClinicaPediatrica.TabIndex = 106;
            this.iconBtnClinicaPediatrica.TabStop = false;
            this.iconBtnClinicaPediatrica.Text = "Clinica Pediátrica";
            this.iconBtnClinicaPediatrica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconBtnClinicaPediatrica.UseVisualStyleBackColor = false;
            this.iconBtnClinicaPediatrica.Click += new System.EventHandler(this.iconBtnClinicaPediatrica_Click);
            // 
            // btnClinicaMedica
            // 
            this.btnClinicaMedica.BackColor = System.Drawing.Color.Transparent;
            this.btnClinicaMedica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClinicaMedica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClinicaMedica.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClinicaMedica.FlatAppearance.BorderSize = 0;
            this.btnClinicaMedica.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClinicaMedica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnClinicaMedica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClinicaMedica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClinicaMedica.IconChar = FontAwesome.Sharp.IconChar.BookMedical;
            this.btnClinicaMedica.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnClinicaMedica.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClinicaMedica.IconSize = 30;
            this.btnClinicaMedica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClinicaMedica.Location = new System.Drawing.Point(0, 0);
            this.btnClinicaMedica.Name = "btnClinicaMedica";
            this.btnClinicaMedica.Size = new System.Drawing.Size(189, 40);
            this.btnClinicaMedica.TabIndex = 105;
            this.btnClinicaMedica.TabStop = false;
            this.btnClinicaMedica.Text = "Clinica Médica";
            this.btnClinicaMedica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClinicaMedica.UseVisualStyleBackColor = false;
            this.btnClinicaMedica.Click += new System.EventHandler(this.btnClinicaMedica_Click_1);
            // 
            // btnAddSae
            // 
            this.btnAddSae.BackColor = System.Drawing.Color.Transparent;
            this.btnAddSae.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddSae.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSae.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddSae.FlatAppearance.BorderSize = 0;
            this.btnAddSae.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddSae.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btnAddSae.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSae.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddSae.IconChar = FontAwesome.Sharp.IconChar.UserNurse;
            this.btnAddSae.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.btnAddSae.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddSae.IconSize = 30;
            this.btnAddSae.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSae.Location = new System.Drawing.Point(0, 40);
            this.btnAddSae.Name = "btnAddSae";
            this.btnAddSae.Size = new System.Drawing.Size(186, 40);
            this.btnAddSae.TabIndex = 104;
            this.btnAddSae.TabStop = false;
            this.btnAddSae.Text = "Administração da SAE";
            this.btnAddSae.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddSae.UseVisualStyleBackColor = false;
            this.btnAddSae.Click += new System.EventHandler(this.btnAddSae_Click);
            // 
            // btnAdmUsuario
            // 
            this.btnAdmUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnAdmUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdmUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmUsuario.FlatAppearance.BorderSize = 0;
            this.btnAdmUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdmUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btnAdmUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdmUsuario.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.btnAdmUsuario.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.btnAdmUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdmUsuario.IconSize = 30;
            this.btnAdmUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmUsuario.Location = new System.Drawing.Point(0, 0);
            this.btnAdmUsuario.Name = "btnAdmUsuario";
            this.btnAdmUsuario.Size = new System.Drawing.Size(186, 40);
            this.btnAdmUsuario.TabIndex = 103;
            this.btnAdmUsuario.TabStop = false;
            this.btnAdmUsuario.Text = "Adiministração de Usuários";
            this.btnAdmUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdmUsuario.UseVisualStyleBackColor = false;
            this.btnAdmUsuario.Click += new System.EventHandler(this.btnAdmUsuario_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelCabecalho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelScreen.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelDropDownTemplate.ResumeLayout(false);
            this.pLogoff.ResumeLayout(false);
            this.panelDropDown.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelScreen;
        private System.Windows.Forms.Label lblTitleForm;
        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Panel panelDropDown;
        private System.Windows.Forms.Timer timerCollapsed;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAlterarSenha;
        private System.Windows.Forms.Panel pLogoff;
        private FontAwesome.Sharp.IconButton btnPrescricao;
        private FontAwesome.Sharp.IconButton btnTempalte;
        private FontAwesome.Sharp.IconButton btnGerenciamentoLeito;
        private FontAwesome.Sharp.IconButton btnPaciente;
        private FontAwesome.Sharp.IconButton btnAdmUsuario;
        private FontAwesome.Sharp.IconButton btnAddSae;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private FontAwesome.Sharp.IconButton btnClinicaMedica;
        private FontAwesome.Sharp.IconButton iconBtnUrgenciaEmergencia;
        private FontAwesome.Sharp.IconButton iconBtnClinicaObstetrica;
        private FontAwesome.Sharp.IconButton iconBtnClinicaCirurgica;
        private FontAwesome.Sharp.IconButton iconBtnClinicaPediatrica;
        private FontAwesome.Sharp.IconButton btnNanda;
        private FontAwesome.Sharp.IconButton btnSalvar;
        private System.Windows.Forms.Panel panelDropDownTemplate;
        private FontAwesome.Sharp.IconButton btnListarModelo;
        private FontAwesome.Sharp.IconButton btnCriarTemplate;
        private System.Windows.Forms.Timer timerCollapsedTemplate;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnNovo;
        private FontAwesome.Sharp.IconButton btnAddGeneric;
        private FontAwesome.Sharp.IconButton btnImprimir;
    }
}

