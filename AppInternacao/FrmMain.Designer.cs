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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelScreen = new System.Windows.Forms.Panel();
            this.timerCollapsed = new System.Windows.Forms.Timer(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnTempalte = new System.Windows.Forms.Button();
            this.btnPrescricao = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnAdmUsuario = new System.Windows.Forms.Button();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.btnGerenciamentoLeito = new System.Windows.Forms.Button();
            this.pLogoff = new System.Windows.Forms.Panel();
            this.btnAlterarSenha = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelDropDown = new System.Windows.Forms.Panel();
            this.btnUrgenciaEmergencia = new System.Windows.Forms.Button();
            this.btnClinicaObstetrica = new System.Windows.Forms.Button();
            this.btnClinicaCirurgica = new System.Windows.Forms.Button();
            this.btnClinicaPediatrica = new System.Windows.Forms.Button();
            this.btnClinicaMedica = new System.Windows.Forms.Button();
            this.btnAddSae = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelCabecalho.SuspendLayout();
            this.panelScreen.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.pLogoff.SuspendLayout();
            this.panelDropDown.SuspendLayout();
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
            this.splitContainer1.Size = new System.Drawing.Size(1092, 524);
            this.splitContainer1.SplitterDistance = 870;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.panelTitle.Controls.Add(this.pictureBox1);
            this.panelTitle.Controls.Add(this.panelCabecalho);
            this.panelTitle.Controls.Add(this.label2);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1261, 37);
            this.panelTitle.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::AppInternacao.Properties.Resources.loginFrmBlue;
            this.pictureBox1.Location = new System.Drawing.Point(1216, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.Transparent;
            this.panelCabecalho.Controls.Add(this.btnSalvar);
            this.panelCabecalho.Controls.Add(this.btnNovo);
            this.panelCabecalho.Controls.Add(this.btnImprimir);
            this.panelCabecalho.Location = new System.Drawing.Point(1, 1);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(315, 36);
            this.panelCabecalho.TabIndex = 5;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalvar.Image = global::AppInternacao.Properties.Resources.Save_Icon_icon_icons_com_69139;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(170, 0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(85, 36);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.TabStop = false;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.Transparent;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNovo.Image = global::AppInternacao.Properties.Resources.newFile;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(85, 0);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(85, 36);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.TabStop = false;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnImprimir.Image = global::AppInternacao.Properties.Resources.PhotoPrint_6314;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(0, 0);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(85, 36);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.TabStop = false;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(832, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sistematização da Assistêmcia de Enfermagem";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            // timerCollapsed
            // 
            this.timerCollapsed.Interval = 15;
            this.timerCollapsed.Tick += new System.EventHandler(this.timerCollapsed_Tick);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.panelMenu.BackgroundImage = global::AppInternacao.Properties.Resources.backgroudMenu001;
            this.panelMenu.Controls.Add(this.btnTempalte);
            this.panelMenu.Controls.Add(this.btnPrescricao);
            this.panelMenu.Controls.Add(this.panelButtons);
            this.panelMenu.Controls.Add(this.pLogoff);
            this.panelMenu.Controls.Add(this.panelDropDown);
            this.panelMenu.Controls.Add(this.btnAddSae);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 37);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(169, 524);
            this.panelMenu.TabIndex = 2;
            // 
            // btnTempalte
            // 
            this.btnTempalte.BackColor = System.Drawing.Color.Transparent;
            this.btnTempalte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTempalte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTempalte.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTempalte.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnTempalte.FlatAppearance.BorderSize = 0;
            this.btnTempalte.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTempalte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btnTempalte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTempalte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTempalte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTempalte.Image = global::AppInternacao.Properties.Resources.Documents;
            this.btnTempalte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTempalte.Location = new System.Drawing.Point(0, 197);
            this.btnTempalte.Name = "btnTempalte";
            this.btnTempalte.Size = new System.Drawing.Size(169, 40);
            this.btnTempalte.TabIndex = 12;
            this.btnTempalte.TabStop = false;
            this.btnTempalte.Text = "Template de Exame Físico";
            this.btnTempalte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTempalte.UseVisualStyleBackColor = false;
            this.btnTempalte.Click += new System.EventHandler(this.btnTempalte_Click);
            // 
            // btnPrescricao
            // 
            this.btnPrescricao.BackColor = System.Drawing.Color.Transparent;
            this.btnPrescricao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrescricao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrescricao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrescricao.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnPrescricao.FlatAppearance.BorderSize = 0;
            this.btnPrescricao.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrescricao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btnPrescricao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrescricao.Image = global::AppInternacao.Properties.Resources.template01;
            this.btnPrescricao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrescricao.Location = new System.Drawing.Point(0, 157);
            this.btnPrescricao.Name = "btnPrescricao";
            this.btnPrescricao.Size = new System.Drawing.Size(169, 40);
            this.btnPrescricao.TabIndex = 14;
            this.btnPrescricao.TabStop = false;
            this.btnPrescricao.Text = "Ciclos de Prescrições";
            this.btnPrescricao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrescricao.UseVisualStyleBackColor = false;
            this.btnPrescricao.Click += new System.EventHandler(this.btnPrescricao_Click);
            // 
            // panelButtons
            // 
            this.panelButtons.AutoSize = true;
            this.panelButtons.BackColor = System.Drawing.Color.Transparent;
            this.panelButtons.Controls.Add(this.btnAdmUsuario);
            this.panelButtons.Controls.Add(this.btnPaciente);
            this.panelButtons.Controls.Add(this.btnGerenciamentoLeito);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 37);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(169, 120);
            this.panelButtons.TabIndex = 6;
            // 
            // btnAdmUsuario
            // 
            this.btnAdmUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnAdmUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdmUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmUsuario.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAdmUsuario.FlatAppearance.BorderSize = 0;
            this.btnAdmUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdmUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btnAdmUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdmUsuario.Image = global::AppInternacao.Properties.Resources.people_47795;
            this.btnAdmUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmUsuario.Location = new System.Drawing.Point(0, 80);
            this.btnAdmUsuario.Name = "btnAdmUsuario";
            this.btnAdmUsuario.Size = new System.Drawing.Size(169, 40);
            this.btnAdmUsuario.TabIndex = 11;
            this.btnAdmUsuario.TabStop = false;
            this.btnAdmUsuario.Text = "Administrar Usuários";
            this.btnAdmUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdmUsuario.UseVisualStyleBackColor = false;
            this.btnAdmUsuario.Click += new System.EventHandler(this.btnAdmUsuario_Click);
            // 
            // btnPaciente
            // 
            this.btnPaciente.BackColor = System.Drawing.Color.Transparent;
            this.btnPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPaciente.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnPaciente.FlatAppearance.BorderSize = 0;
            this.btnPaciente.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btnPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPaciente.Image = global::AppInternacao.Properties.Resources.ic_account_child_128_28130;
            this.btnPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaciente.Location = new System.Drawing.Point(0, 40);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(169, 40);
            this.btnPaciente.TabIndex = 2;
            this.btnPaciente.TabStop = false;
            this.btnPaciente.Text = "Cadastro de Pacientes";
            this.btnPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPaciente.UseVisualStyleBackColor = false;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // btnGerenciamentoLeito
            // 
            this.btnGerenciamentoLeito.BackColor = System.Drawing.Color.Transparent;
            this.btnGerenciamentoLeito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGerenciamentoLeito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerenciamentoLeito.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGerenciamentoLeito.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnGerenciamentoLeito.FlatAppearance.BorderSize = 0;
            this.btnGerenciamentoLeito.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGerenciamentoLeito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btnGerenciamentoLeito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerenciamentoLeito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciamentoLeito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGerenciamentoLeito.Image = global::AppInternacao.Properties.Resources.summer_vacation_beach_bed_sun_bathing_sunbed_icon_133411;
            this.btnGerenciamentoLeito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerenciamentoLeito.Location = new System.Drawing.Point(0, 0);
            this.btnGerenciamentoLeito.Name = "btnGerenciamentoLeito";
            this.btnGerenciamentoLeito.Size = new System.Drawing.Size(169, 40);
            this.btnGerenciamentoLeito.TabIndex = 5;
            this.btnGerenciamentoLeito.TabStop = false;
            this.btnGerenciamentoLeito.Text = "Administração de  Leito";
            this.btnGerenciamentoLeito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGerenciamentoLeito.UseVisualStyleBackColor = false;
            this.btnGerenciamentoLeito.Click += new System.EventHandler(this.btnGerenciamentoLeito_Click);
            // 
            // pLogoff
            // 
            this.pLogoff.BackColor = System.Drawing.Color.Transparent;
            this.pLogoff.Controls.Add(this.btnAlterarSenha);
            this.pLogoff.Controls.Add(this.btnLogout);
            this.pLogoff.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pLogoff.Location = new System.Drawing.Point(0, 437);
            this.pLogoff.Name = "pLogoff";
            this.pLogoff.Size = new System.Drawing.Size(169, 87);
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
            this.btnAlterarSenha.Size = new System.Drawing.Size(169, 40);
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
            this.btnLogout.Size = new System.Drawing.Size(169, 40);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Sair / Fechar";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
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
            this.panelDropDown.MaximumSize = new System.Drawing.Size(169, 200);
            this.panelDropDown.MinimumSize = new System.Drawing.Size(169, 0);
            this.panelDropDown.Name = "panelDropDown";
            this.panelDropDown.Size = new System.Drawing.Size(169, 0);
            this.panelDropDown.TabIndex = 10;
            // 
            // btnUrgenciaEmergencia
            // 
            this.btnUrgenciaEmergencia.BackColor = System.Drawing.Color.Transparent;
            this.btnUrgenciaEmergencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUrgenciaEmergencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUrgenciaEmergencia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUrgenciaEmergencia.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnUrgenciaEmergencia.FlatAppearance.BorderSize = 0;
            this.btnUrgenciaEmergencia.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUrgenciaEmergencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnUrgenciaEmergencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrgenciaEmergencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrgenciaEmergencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUrgenciaEmergencia.Image = global::AppInternacao.Properties.Resources.hospital_doctor_10739;
            this.btnUrgenciaEmergencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrgenciaEmergencia.Location = new System.Drawing.Point(0, 160);
            this.btnUrgenciaEmergencia.Name = "btnUrgenciaEmergencia";
            this.btnUrgenciaEmergencia.Size = new System.Drawing.Size(169, 40);
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
            this.btnClinicaObstetrica.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClinicaObstetrica.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClinicaObstetrica.FlatAppearance.BorderSize = 0;
            this.btnClinicaObstetrica.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClinicaObstetrica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnClinicaObstetrica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClinicaObstetrica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClinicaObstetrica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClinicaObstetrica.Image = global::AppInternacao.Properties.Resources.toddler;
            this.btnClinicaObstetrica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClinicaObstetrica.Location = new System.Drawing.Point(0, 120);
            this.btnClinicaObstetrica.Name = "btnClinicaObstetrica";
            this.btnClinicaObstetrica.Size = new System.Drawing.Size(169, 40);
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
            this.btnClinicaCirurgica.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClinicaCirurgica.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClinicaCirurgica.FlatAppearance.BorderSize = 0;
            this.btnClinicaCirurgica.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClinicaCirurgica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnClinicaCirurgica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClinicaCirurgica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClinicaCirurgica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClinicaCirurgica.Image = global::AppInternacao.Properties.Resources.ClinicaMedica;
            this.btnClinicaCirurgica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClinicaCirurgica.Location = new System.Drawing.Point(0, 80);
            this.btnClinicaCirurgica.Name = "btnClinicaCirurgica";
            this.btnClinicaCirurgica.Size = new System.Drawing.Size(169, 40);
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
            this.btnClinicaPediatrica.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClinicaPediatrica.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClinicaPediatrica.FlatAppearance.BorderSize = 0;
            this.btnClinicaPediatrica.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClinicaPediatrica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnClinicaPediatrica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClinicaPediatrica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClinicaPediatrica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClinicaPediatrica.Image = global::AppInternacao.Properties.Resources.crianca;
            this.btnClinicaPediatrica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClinicaPediatrica.Location = new System.Drawing.Point(0, 40);
            this.btnClinicaPediatrica.Name = "btnClinicaPediatrica";
            this.btnClinicaPediatrica.Size = new System.Drawing.Size(169, 40);
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
            this.btnClinicaMedica.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClinicaMedica.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClinicaMedica.FlatAppearance.BorderSize = 0;
            this.btnClinicaMedica.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClinicaMedica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnClinicaMedica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClinicaMedica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClinicaMedica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClinicaMedica.Image = global::AppInternacao.Properties.Resources.ic_people_outline_128_28591;
            this.btnClinicaMedica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClinicaMedica.Location = new System.Drawing.Point(0, 0);
            this.btnClinicaMedica.Name = "btnClinicaMedica";
            this.btnClinicaMedica.Size = new System.Drawing.Size(169, 40);
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
            this.btnAddSae.TabStop = false;
            this.btnAddSae.Text = "Adcionar Novo SAE";
            this.btnAddSae.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddSae.UseVisualStyleBackColor = false;
            this.btnAddSae.Click += new System.EventHandler(this.btnAddSae_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelCabecalho.ResumeLayout(false);
            this.panelScreen.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.pLogoff.ResumeLayout(false);
            this.panelDropDown.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelScreen;
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
        private System.Windows.Forms.Button btnAdmUsuario;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAlterarSenha;
        private System.Windows.Forms.Panel pLogoff;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTempalte;
        private System.Windows.Forms.Button btnPrescricao;
    }
}

