using System;

namespace AppInternacao.FrmSae
{
    partial class UCTemplateItemExameFisico
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
            FrmMain.mySalvar.Click -= new EventHandler(Salvar);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ColumnHeader columnHeader9;
            System.Windows.Forms.ColumnHeader columnHeader10;
            System.Windows.Forms.ColumnHeader columnHeader5;
            System.Windows.Forms.ColumnHeader columnHeader6;
            System.Windows.Forms.ColumnHeader columnHeader1;
            System.Windows.Forms.ColumnHeader columnHeader2;
            System.Windows.Forms.ColumnHeader columnHeader13;
            System.Windows.Forms.ColumnHeader columnHeader14;
            System.Windows.Forms.ColumnHeader columnHeader17;
            System.Windows.Forms.ColumnHeader columnHeader18;
            System.Windows.Forms.ColumnHeader columnHeader21;
            System.Windows.Forms.ColumnHeader columnHeader22;
            System.Windows.Forms.ColumnHeader columnHeader25;
            System.Windows.Forms.ColumnHeader columnHeader26;
            System.Windows.Forms.ColumnHeader columnHeader29;
            System.Windows.Forms.ColumnHeader columnHeader30;
            System.Windows.Forms.ColumnHeader columnHeader33;
            System.Windows.Forms.ColumnHeader columnHeader34;
            System.Windows.Forms.ColumnHeader columnHeader37;
            System.Windows.Forms.ColumnHeader columnHeader38;
            System.Windows.Forms.ColumnHeader columnHeader41;
            System.Windows.Forms.ColumnHeader columnHeader42;
            System.Windows.Forms.ColumnHeader columnHeader45;
            System.Windows.Forms.ColumnHeader columnHeader46;
            System.Windows.Forms.ColumnHeader columnHeader49;
            System.Windows.Forms.ColumnHeader columnHeader50;
            System.Windows.Forms.ColumnHeader columnHeader53;
            System.Windows.Forms.ColumnHeader columnHeader54;
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVisualizarTemplate = new System.Windows.Forms.Button();
            this.btnStepVoltar = new System.Windows.Forms.Button();
            this.lbltituloExame = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.pPressaoArterial = new System.Windows.Forms.Panel();
            this.listViewPressaoArterialOutros = new System.Windows.Forms.ListView();
            this.listViewTemplatePressaoArterialOutros = new System.Windows.Forms.ListView();
            this.columnHeader55 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader56 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel28 = new System.Windows.Forms.Panel();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pControleCateteres = new System.Windows.Forms.Panel();
            this.listViewCatetres = new System.Windows.Forms.ListView();
            this.listViewTemplateCatetres = new System.Windows.Forms.ListView();
            this.columnHeader51 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader52 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel26 = new System.Windows.Forms.Panel();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pComaGlasgow = new System.Windows.Forms.Panel();
            this.listViewGlasgow = new System.Windows.Forms.ListView();
            this.listViewTemplateGlasgow = new System.Windows.Forms.ListView();
            this.columnHeader47 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader48 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel24 = new System.Windows.Forms.Panel();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pGloboPinard = new System.Windows.Forms.Panel();
            this.listViewPinard = new System.Windows.Forms.ListView();
            this.listViewTemplatePinard = new System.Windows.Forms.ListView();
            this.columnHeader43 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader44 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel22 = new System.Windows.Forms.Panel();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pLesaoCompressao = new System.Windows.Forms.Panel();
            this.listViewLesaoCompressao = new System.Windows.Forms.ListView();
            this.listViewTemplateLesaoCompressao = new System.Windows.Forms.ListView();
            this.columnHeader39 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader40 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel20 = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pSistemaUrinario = new System.Windows.Forms.Panel();
            this.listViewSistemaUrinario = new System.Windows.Forms.ListView();
            this.listViewTemplateSistemaUrinario = new System.Windows.Forms.ListView();
            this.columnHeader35 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader36 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel18 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pSistemaAbdominal = new System.Windows.Forms.Panel();
            this.listViewSistemaAbdominal = new System.Windows.Forms.ListView();
            this.listViewTemplateSistemaAbdominal = new System.Windows.Forms.ListView();
            this.columnHeader31 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader32 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel16 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pSistemaVascular = new System.Windows.Forms.Panel();
            this.listViewSistemaVascular = new System.Windows.Forms.ListView();
            this.listViewTemplateSistemaVascular = new System.Windows.Forms.ListView();
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader28 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel14 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pSistemaGastrointestinal = new System.Windows.Forms.Panel();
            this.listViewSistemaGastrointestinal = new System.Windows.Forms.ListView();
            this.listViewTemplateSistemaGastrointestinal = new System.Windows.Forms.ListView();
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel12 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pPele = new System.Windows.Forms.Panel();
            this.listViewPele = new System.Windows.Forms.ListView();
            this.listViewTemplatePele = new System.Windows.Forms.ListView();
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel10 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pOxigenacao = new System.Windows.Forms.Panel();
            this.listViewOxigenacao = new System.Windows.Forms.ListView();
            this.listViewTemplateOxigenacao = new System.Windows.Forms.ListView();
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel8 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pRegulacaoTermica = new System.Windows.Forms.Panel();
            this.listViewRegulacaoTermica = new System.Windows.Forms.ListView();
            this.listViewTemplateRegulacaoTermica = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pPupilas = new System.Windows.Forms.Panel();
            this.listViewPuplias = new System.Windows.Forms.ListView();
            this.listViewTemplatePuplias = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pSistemaNeurologico = new System.Windows.Forms.Panel();
            this.listViewItemSistemaNeurologico = new System.Windows.Forms.ListView();
            this.listViewTemplateSistemaNeurologico = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panetitulo1 = new System.Windows.Forms.Panel();
            this.imgAccordion = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timerAccordion = new System.Windows.Forms.Timer(this.components);
            this.lblTotalNeurologico = new System.Windows.Forms.Label();
            this.lblTotalPupila = new System.Windows.Forms.Label();
            this.lblTotalTermina = new System.Windows.Forms.Label();
            this.lblTotalOxigenacao = new System.Windows.Forms.Label();
            this.lblTotalPele = new System.Windows.Forms.Label();
            this.lblTotalGastro = new System.Windows.Forms.Label();
            this.lblTotalVascular = new System.Windows.Forms.Label();
            this.lblTotalAbdominal = new System.Windows.Forms.Label();
            this.lblTotalUrinario = new System.Windows.Forms.Label();
            this.lblTotalCompressao = new System.Windows.Forms.Label();
            this.lblTotalPinard = new System.Windows.Forms.Label();
            this.lblTotalGlasgow = new System.Windows.Forms.Label();
            this.lblTotalCatetere = new System.Windows.Forms.Label();
            this.lblTotalOutros = new System.Windows.Forms.Label();
            columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader29 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader30 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader33 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader34 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader37 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader38 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader41 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader42 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader45 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader46 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader49 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader50 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader53 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader54 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.pPressaoArterial.SuspendLayout();
            this.panel28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.pControleCateteres.SuspendLayout();
            this.panel26.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.pComaGlasgow.SuspendLayout();
            this.panel24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.pGloboPinard.SuspendLayout();
            this.panel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.pLesaoCompressao.SuspendLayout();
            this.panel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.pSistemaUrinario.SuspendLayout();
            this.panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.pSistemaAbdominal.SuspendLayout();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.pSistemaVascular.SuspendLayout();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.pSistemaGastrointestinal.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.pPele.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pOxigenacao.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pRegulacaoTermica.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pPupilas.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pSistemaNeurologico.SuspendLayout();
            this.panetitulo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAccordion)).BeginInit();
            this.SuspendLayout();
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Codigo";
            columnHeader9.Width = 75;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Item Disponíveis";
            columnHeader10.Width = 257;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Codigo";
            columnHeader5.Width = 75;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Item Disponíveis";
            columnHeader6.Width = 257;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Codigo";
            columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Item Disponíveis";
            columnHeader2.Width = 257;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Codigo";
            columnHeader13.Width = 75;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Item Disponíveis";
            columnHeader14.Width = 257;
            // 
            // columnHeader17
            // 
            columnHeader17.Text = "Codigo";
            columnHeader17.Width = 75;
            // 
            // columnHeader18
            // 
            columnHeader18.Text = "Item Disponíveis";
            columnHeader18.Width = 257;
            // 
            // columnHeader21
            // 
            columnHeader21.Text = "Codigo";
            columnHeader21.Width = 75;
            // 
            // columnHeader22
            // 
            columnHeader22.Text = "Item Disponíveis";
            columnHeader22.Width = 257;
            // 
            // columnHeader25
            // 
            columnHeader25.Text = "Codigo";
            columnHeader25.Width = 75;
            // 
            // columnHeader26
            // 
            columnHeader26.Text = "Item Disponíveis";
            columnHeader26.Width = 257;
            // 
            // columnHeader29
            // 
            columnHeader29.Text = "Codigo";
            columnHeader29.Width = 75;
            // 
            // columnHeader30
            // 
            columnHeader30.Text = "Item Disponíveis";
            columnHeader30.Width = 257;
            // 
            // columnHeader33
            // 
            columnHeader33.Text = "Codigo";
            columnHeader33.Width = 75;
            // 
            // columnHeader34
            // 
            columnHeader34.Text = "Item Disponíveis";
            columnHeader34.Width = 257;
            // 
            // columnHeader37
            // 
            columnHeader37.Text = "Codigo";
            columnHeader37.Width = 75;
            // 
            // columnHeader38
            // 
            columnHeader38.Text = "Item Disponíveis";
            columnHeader38.Width = 257;
            // 
            // columnHeader41
            // 
            columnHeader41.Text = "Codigo";
            columnHeader41.Width = 75;
            // 
            // columnHeader42
            // 
            columnHeader42.Text = "Item Disponíveis";
            columnHeader42.Width = 257;
            // 
            // columnHeader45
            // 
            columnHeader45.Text = "Codigo";
            columnHeader45.Width = 75;
            // 
            // columnHeader46
            // 
            columnHeader46.Text = "Item Disponíveis";
            columnHeader46.Width = 257;
            // 
            // columnHeader49
            // 
            columnHeader49.Text = "Codigo";
            columnHeader49.Width = 75;
            // 
            // columnHeader50
            // 
            columnHeader50.Text = "Item Disponíveis";
            columnHeader50.Width = 257;
            // 
            // columnHeader53
            // 
            columnHeader53.Text = "Codigo";
            columnHeader53.Width = 75;
            // 
            // columnHeader54
            // 
            columnHeader54.Text = "Item Disponíveis";
            columnHeader54.Width = 257;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btnVisualizarTemplate);
            this.panel1.Controls.Add(this.btnStepVoltar);
            this.panel1.Controls.Add(this.lbltituloExame);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 45);
            this.panel1.TabIndex = 0;
            // 
            // btnVisualizarTemplate
            // 
            this.btnVisualizarTemplate.BackColor = System.Drawing.Color.Transparent;
            this.btnVisualizarTemplate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVisualizarTemplate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisualizarTemplate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnVisualizarTemplate.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnVisualizarTemplate.FlatAppearance.BorderSize = 0;
            this.btnVisualizarTemplate.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVisualizarTemplate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnVisualizarTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnVisualizarTemplate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btnVisualizarTemplate.Image = global::AppInternacao.Properties.Resources.security_view1;
            this.btnVisualizarTemplate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisualizarTemplate.Location = new System.Drawing.Point(544, 0);
            this.btnVisualizarTemplate.Name = "btnVisualizarTemplate";
            this.btnVisualizarTemplate.Size = new System.Drawing.Size(207, 45);
            this.btnVisualizarTemplate.TabIndex = 10;
            this.btnVisualizarTemplate.TabStop = false;
            this.btnVisualizarTemplate.Text = "Visualizar Template";
            this.btnVisualizarTemplate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVisualizarTemplate.UseVisualStyleBackColor = false;
            this.btnVisualizarTemplate.Visible = false;
            this.btnVisualizarTemplate.Click += new System.EventHandler(this.VisualizarTemplate);
            // 
            // btnStepVoltar
            // 
            this.btnStepVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnStepVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStepVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStepVoltar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnStepVoltar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnStepVoltar.FlatAppearance.BorderSize = 0;
            this.btnStepVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStepVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnStepVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStepVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStepVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btnStepVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStepVoltar.Location = new System.Drawing.Point(751, 0);
            this.btnStepVoltar.Margin = new System.Windows.Forms.Padding(0);
            this.btnStepVoltar.Name = "btnStepVoltar";
            this.btnStepVoltar.Size = new System.Drawing.Size(85, 45);
            this.btnStepVoltar.TabIndex = 8;
            this.btnStepVoltar.Text = "Voltar";
            this.btnStepVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStepVoltar.UseVisualStyleBackColor = false;
            this.btnStepVoltar.Click += new System.EventHandler(this.btnStepVoltar_Click);
            // 
            // lbltituloExame
            // 
            this.lbltituloExame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbltituloExame.AutoSize = true;
            this.lbltituloExame.BackColor = System.Drawing.Color.Transparent;
            this.lbltituloExame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbltituloExame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltituloExame.ForeColor = System.Drawing.Color.Black;
            this.lbltituloExame.Location = new System.Drawing.Point(6, 9);
            this.lbltituloExame.Name = "lbltituloExame";
            this.lbltituloExame.Size = new System.Drawing.Size(13, 16);
            this.lbltituloExame.TabIndex = 9;
            this.lbltituloExame.Text = "-";
            // 
            // panelBody
            // 
            this.panelBody.AutoScroll = true;
            this.panelBody.Controls.Add(this.pPressaoArterial);
            this.panelBody.Controls.Add(this.panel28);
            this.panelBody.Controls.Add(this.pControleCateteres);
            this.panelBody.Controls.Add(this.panel26);
            this.panelBody.Controls.Add(this.pComaGlasgow);
            this.panelBody.Controls.Add(this.panel24);
            this.panelBody.Controls.Add(this.pGloboPinard);
            this.panelBody.Controls.Add(this.panel22);
            this.panelBody.Controls.Add(this.pLesaoCompressao);
            this.panelBody.Controls.Add(this.panel20);
            this.panelBody.Controls.Add(this.pSistemaUrinario);
            this.panelBody.Controls.Add(this.panel18);
            this.panelBody.Controls.Add(this.pSistemaAbdominal);
            this.panelBody.Controls.Add(this.panel16);
            this.panelBody.Controls.Add(this.pSistemaVascular);
            this.panelBody.Controls.Add(this.panel14);
            this.panelBody.Controls.Add(this.pSistemaGastrointestinal);
            this.panelBody.Controls.Add(this.panel12);
            this.panelBody.Controls.Add(this.pPele);
            this.panelBody.Controls.Add(this.panel10);
            this.panelBody.Controls.Add(this.pOxigenacao);
            this.panelBody.Controls.Add(this.panel8);
            this.panelBody.Controls.Add(this.pRegulacaoTermica);
            this.panelBody.Controls.Add(this.panel7);
            this.panelBody.Controls.Add(this.pPupilas);
            this.panelBody.Controls.Add(this.panel5);
            this.panelBody.Controls.Add(this.pSistemaNeurologico);
            this.panelBody.Controls.Add(this.panetitulo1);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 45);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(836, 466);
            this.panelBody.TabIndex = 1;
            // 
            // pPressaoArterial
            // 
            this.pPressaoArterial.Controls.Add(this.listViewPressaoArterialOutros);
            this.pPressaoArterial.Controls.Add(this.listViewTemplatePressaoArterialOutros);
            this.pPressaoArterial.Dock = System.Windows.Forms.DockStyle.Top;
            this.pPressaoArterial.Location = new System.Drawing.Point(0, 462);
            this.pPressaoArterial.Name = "pPressaoArterial";
            this.pPressaoArterial.Padding = new System.Windows.Forms.Padding(10);
            this.pPressaoArterial.Size = new System.Drawing.Size(836, 0);
            this.pPressaoArterial.TabIndex = 37;
            this.pPressaoArterial.Tag = "0";
            // 
            // listViewPressaoArterialOutros
            // 
            this.listViewPressaoArterialOutros.AllowDrop = true;
            this.listViewPressaoArterialOutros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewPressaoArterialOutros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader53,
            columnHeader54});
            this.listViewPressaoArterialOutros.Dock = System.Windows.Forms.DockStyle.Left;
            this.listViewPressaoArterialOutros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewPressaoArterialOutros.FullRowSelect = true;
            this.listViewPressaoArterialOutros.HideSelection = false;
            this.listViewPressaoArterialOutros.Location = new System.Drawing.Point(10, 10);
            this.listViewPressaoArterialOutros.MultiSelect = false;
            this.listViewPressaoArterialOutros.Name = "listViewPressaoArterialOutros";
            this.listViewPressaoArterialOutros.Size = new System.Drawing.Size(332, 0);
            this.listViewPressaoArterialOutros.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewPressaoArterialOutros.TabIndex = 1;
            this.listViewPressaoArterialOutros.UseCompatibleStateImageBehavior = false;
            this.listViewPressaoArterialOutros.View = System.Windows.Forms.View.Details;
            this.listViewPressaoArterialOutros.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewPressaoArterialOutros_ItemDrag);
            this.listViewPressaoArterialOutros.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewPressaoArterialOutros_DragDrop);
            this.listViewPressaoArterialOutros.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewPressaoArterialOutros_DragEnter);
            // 
            // listViewTemplatePressaoArterialOutros
            // 
            this.listViewTemplatePressaoArterialOutros.AllowDrop = true;
            this.listViewTemplatePressaoArterialOutros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewTemplatePressaoArterialOutros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader55,
            this.columnHeader56});
            this.listViewTemplatePressaoArterialOutros.Dock = System.Windows.Forms.DockStyle.Right;
            this.listViewTemplatePressaoArterialOutros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTemplatePressaoArterialOutros.FullRowSelect = true;
            this.listViewTemplatePressaoArterialOutros.HideSelection = false;
            this.listViewTemplatePressaoArterialOutros.Location = new System.Drawing.Point(494, 10);
            this.listViewTemplatePressaoArterialOutros.MultiSelect = false;
            this.listViewTemplatePressaoArterialOutros.Name = "listViewTemplatePressaoArterialOutros";
            this.listViewTemplatePressaoArterialOutros.Size = new System.Drawing.Size(332, 0);
            this.listViewTemplatePressaoArterialOutros.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewTemplatePressaoArterialOutros.TabIndex = 2;
            this.listViewTemplatePressaoArterialOutros.UseCompatibleStateImageBehavior = false;
            this.listViewTemplatePressaoArterialOutros.View = System.Windows.Forms.View.Details;
            this.listViewTemplatePressaoArterialOutros.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewTemplatePressaoArterialOutros_ItemDrag);
            this.listViewTemplatePressaoArterialOutros.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewTemplatePressaoArterialOutros_DragDrop);
            this.listViewTemplatePressaoArterialOutros.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewTemplatePressaoArterialOutros_DragEnter);
            // 
            // columnHeader55
            // 
            this.columnHeader55.Text = "Codigo";
            this.columnHeader55.Width = 75;
            // 
            // columnHeader56
            // 
            this.columnHeader56.Text = "Itens no Template";
            this.columnHeader56.Width = 256;
            // 
            // panel28
            // 
            this.panel28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.panel28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel28.Controls.Add(this.lblTotalOutros);
            this.panel28.Controls.Add(this.pictureBox13);
            this.panel28.Controls.Add(this.label14);
            this.panel28.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel28.Location = new System.Drawing.Point(0, 429);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(836, 33);
            this.panel28.TabIndex = 36;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox13.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox13.Image = global::AppInternacao.Properties.Resources.left;
            this.pictureBox13.Location = new System.Drawing.Point(801, 0);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.pictureBox13.Size = new System.Drawing.Size(35, 33);
            this.pictureBox13.TabIndex = 6;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Tag = "PressaoArterial";
            this.pictureBox13.Click += new System.EventHandler(this.imgAccordion_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(3, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(275, 20);
            this.label14.TabIndex = 3;
            this.label14.Text = "Escola de Pressão Arterial / Outros";
            // 
            // pControleCateteres
            // 
            this.pControleCateteres.Controls.Add(this.listViewCatetres);
            this.pControleCateteres.Controls.Add(this.listViewTemplateCatetres);
            this.pControleCateteres.Dock = System.Windows.Forms.DockStyle.Top;
            this.pControleCateteres.Location = new System.Drawing.Point(0, 429);
            this.pControleCateteres.Name = "pControleCateteres";
            this.pControleCateteres.Padding = new System.Windows.Forms.Padding(10);
            this.pControleCateteres.Size = new System.Drawing.Size(836, 0);
            this.pControleCateteres.TabIndex = 35;
            this.pControleCateteres.Tag = "0";
            // 
            // listViewCatetres
            // 
            this.listViewCatetres.AllowDrop = true;
            this.listViewCatetres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewCatetres.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader49,
            columnHeader50});
            this.listViewCatetres.Dock = System.Windows.Forms.DockStyle.Left;
            this.listViewCatetres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewCatetres.FullRowSelect = true;
            this.listViewCatetres.HideSelection = false;
            this.listViewCatetres.Location = new System.Drawing.Point(10, 10);
            this.listViewCatetres.MultiSelect = false;
            this.listViewCatetres.Name = "listViewCatetres";
            this.listViewCatetres.Size = new System.Drawing.Size(332, 0);
            this.listViewCatetres.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewCatetres.TabIndex = 1;
            this.listViewCatetres.UseCompatibleStateImageBehavior = false;
            this.listViewCatetres.View = System.Windows.Forms.View.Details;
            this.listViewCatetres.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewCatetres_ItemDrag);
            this.listViewCatetres.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewCatetres_DragDrop);
            this.listViewCatetres.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewCatetres_DragEnter);
            // 
            // listViewTemplateCatetres
            // 
            this.listViewTemplateCatetres.AllowDrop = true;
            this.listViewTemplateCatetres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewTemplateCatetres.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader51,
            this.columnHeader52});
            this.listViewTemplateCatetres.Dock = System.Windows.Forms.DockStyle.Right;
            this.listViewTemplateCatetres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTemplateCatetres.FullRowSelect = true;
            this.listViewTemplateCatetres.HideSelection = false;
            this.listViewTemplateCatetres.Location = new System.Drawing.Point(494, 10);
            this.listViewTemplateCatetres.MultiSelect = false;
            this.listViewTemplateCatetres.Name = "listViewTemplateCatetres";
            this.listViewTemplateCatetres.Size = new System.Drawing.Size(332, 0);
            this.listViewTemplateCatetres.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewTemplateCatetres.TabIndex = 2;
            this.listViewTemplateCatetres.UseCompatibleStateImageBehavior = false;
            this.listViewTemplateCatetres.View = System.Windows.Forms.View.Details;
            this.listViewTemplateCatetres.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewTemplateCatetres_ItemDrag);
            this.listViewTemplateCatetres.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewTemplateCatetres_DragDrop);
            this.listViewTemplateCatetres.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewTemplateCatetres_DragEnter);
            // 
            // columnHeader51
            // 
            this.columnHeader51.Text = "Codigo";
            this.columnHeader51.Width = 75;
            // 
            // columnHeader52
            // 
            this.columnHeader52.Text = "Itens no Template";
            this.columnHeader52.Width = 256;
            // 
            // panel26
            // 
            this.panel26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.panel26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel26.Controls.Add(this.lblTotalCatetere);
            this.panel26.Controls.Add(this.pictureBox12);
            this.panel26.Controls.Add(this.label13);
            this.panel26.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel26.Location = new System.Drawing.Point(0, 396);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(836, 33);
            this.panel26.TabIndex = 34;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox12.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox12.Image = global::AppInternacao.Properties.Resources.left;
            this.pictureBox12.Location = new System.Drawing.Point(801, 0);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.pictureBox12.Size = new System.Drawing.Size(35, 33);
            this.pictureBox12.TabIndex = 6;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "ControleCateteres";
            this.pictureBox12.Click += new System.EventHandler(this.imgAccordion_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(3, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(234, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "Controle de Cateres e Sondas";
            // 
            // pComaGlasgow
            // 
            this.pComaGlasgow.Controls.Add(this.listViewGlasgow);
            this.pComaGlasgow.Controls.Add(this.listViewTemplateGlasgow);
            this.pComaGlasgow.Dock = System.Windows.Forms.DockStyle.Top;
            this.pComaGlasgow.Location = new System.Drawing.Point(0, 396);
            this.pComaGlasgow.Name = "pComaGlasgow";
            this.pComaGlasgow.Padding = new System.Windows.Forms.Padding(10);
            this.pComaGlasgow.Size = new System.Drawing.Size(836, 0);
            this.pComaGlasgow.TabIndex = 33;
            this.pComaGlasgow.Tag = "0";
            // 
            // listViewGlasgow
            // 
            this.listViewGlasgow.AllowDrop = true;
            this.listViewGlasgow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewGlasgow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader45,
            columnHeader46});
            this.listViewGlasgow.Dock = System.Windows.Forms.DockStyle.Left;
            this.listViewGlasgow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewGlasgow.FullRowSelect = true;
            this.listViewGlasgow.HideSelection = false;
            this.listViewGlasgow.Location = new System.Drawing.Point(10, 10);
            this.listViewGlasgow.MultiSelect = false;
            this.listViewGlasgow.Name = "listViewGlasgow";
            this.listViewGlasgow.Size = new System.Drawing.Size(332, 0);
            this.listViewGlasgow.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewGlasgow.TabIndex = 1;
            this.listViewGlasgow.UseCompatibleStateImageBehavior = false;
            this.listViewGlasgow.View = System.Windows.Forms.View.Details;
            this.listViewGlasgow.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewGlasgow_ItemDrag);
            this.listViewGlasgow.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewGlasgow_DragDrop);
            this.listViewGlasgow.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewGlasgow_DragEnter);
            // 
            // listViewTemplateGlasgow
            // 
            this.listViewTemplateGlasgow.AllowDrop = true;
            this.listViewTemplateGlasgow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewTemplateGlasgow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader47,
            this.columnHeader48});
            this.listViewTemplateGlasgow.Dock = System.Windows.Forms.DockStyle.Right;
            this.listViewTemplateGlasgow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTemplateGlasgow.FullRowSelect = true;
            this.listViewTemplateGlasgow.HideSelection = false;
            this.listViewTemplateGlasgow.Location = new System.Drawing.Point(494, 10);
            this.listViewTemplateGlasgow.MultiSelect = false;
            this.listViewTemplateGlasgow.Name = "listViewTemplateGlasgow";
            this.listViewTemplateGlasgow.Size = new System.Drawing.Size(332, 0);
            this.listViewTemplateGlasgow.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewTemplateGlasgow.TabIndex = 2;
            this.listViewTemplateGlasgow.UseCompatibleStateImageBehavior = false;
            this.listViewTemplateGlasgow.View = System.Windows.Forms.View.Details;
            this.listViewTemplateGlasgow.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewTemplateGlasgow_ItemDrag);
            this.listViewTemplateGlasgow.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewTemplateGlasgow_DragDrop);
            this.listViewTemplateGlasgow.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewTemplateGlasgow_DragEnter);
            // 
            // columnHeader47
            // 
            this.columnHeader47.Text = "Codigo";
            this.columnHeader47.Width = 75;
            // 
            // columnHeader48
            // 
            this.columnHeader48.Text = "Itens no Template";
            this.columnHeader48.Width = 256;
            // 
            // panel24
            // 
            this.panel24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.panel24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel24.Controls.Add(this.lblTotalGlasgow);
            this.panel24.Controls.Add(this.pictureBox11);
            this.panel24.Controls.Add(this.label12);
            this.panel24.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel24.Location = new System.Drawing.Point(0, 363);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(836, 33);
            this.panel24.TabIndex = 32;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox11.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox11.Image = global::AppInternacao.Properties.Resources.left;
            this.pictureBox11.Location = new System.Drawing.Point(801, 0);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.pictureBox11.Size = new System.Drawing.Size(35, 33);
            this.pictureBox11.TabIndex = 6;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "ComaGlasgow";
            this.pictureBox11.Click += new System.EventHandler(this.imgAccordion_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(3, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(225, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "Escala de Coma de Glasgow";
            // 
            // pGloboPinard
            // 
            this.pGloboPinard.Controls.Add(this.listViewPinard);
            this.pGloboPinard.Controls.Add(this.listViewTemplatePinard);
            this.pGloboPinard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pGloboPinard.Location = new System.Drawing.Point(0, 363);
            this.pGloboPinard.Name = "pGloboPinard";
            this.pGloboPinard.Padding = new System.Windows.Forms.Padding(10);
            this.pGloboPinard.Size = new System.Drawing.Size(836, 0);
            this.pGloboPinard.TabIndex = 31;
            this.pGloboPinard.Tag = "0";
            // 
            // listViewPinard
            // 
            this.listViewPinard.AllowDrop = true;
            this.listViewPinard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewPinard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader41,
            columnHeader42});
            this.listViewPinard.Dock = System.Windows.Forms.DockStyle.Left;
            this.listViewPinard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewPinard.FullRowSelect = true;
            this.listViewPinard.HideSelection = false;
            this.listViewPinard.Location = new System.Drawing.Point(10, 10);
            this.listViewPinard.MultiSelect = false;
            this.listViewPinard.Name = "listViewPinard";
            this.listViewPinard.Size = new System.Drawing.Size(332, 0);
            this.listViewPinard.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewPinard.TabIndex = 1;
            this.listViewPinard.UseCompatibleStateImageBehavior = false;
            this.listViewPinard.View = System.Windows.Forms.View.Details;
            this.listViewPinard.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewPinard_ItemDrag);
            this.listViewPinard.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewPinard_DragDrop);
            this.listViewPinard.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewPinard_DragEnter);
            // 
            // listViewTemplatePinard
            // 
            this.listViewTemplatePinard.AllowDrop = true;
            this.listViewTemplatePinard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewTemplatePinard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader43,
            this.columnHeader44});
            this.listViewTemplatePinard.Dock = System.Windows.Forms.DockStyle.Right;
            this.listViewTemplatePinard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTemplatePinard.FullRowSelect = true;
            this.listViewTemplatePinard.HideSelection = false;
            this.listViewTemplatePinard.Location = new System.Drawing.Point(494, 10);
            this.listViewTemplatePinard.MultiSelect = false;
            this.listViewTemplatePinard.Name = "listViewTemplatePinard";
            this.listViewTemplatePinard.Size = new System.Drawing.Size(332, 0);
            this.listViewTemplatePinard.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewTemplatePinard.TabIndex = 2;
            this.listViewTemplatePinard.UseCompatibleStateImageBehavior = false;
            this.listViewTemplatePinard.View = System.Windows.Forms.View.Details;
            this.listViewTemplatePinard.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewTemplatePinard_ItemDrag);
            this.listViewTemplatePinard.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewTemplatePinard_DragDrop);
            this.listViewTemplatePinard.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewTemplatePinard_DragEnter);
            // 
            // columnHeader43
            // 
            this.columnHeader43.Text = "Codigo";
            this.columnHeader43.Width = 75;
            // 
            // columnHeader44
            // 
            this.columnHeader44.Text = "Itens no Template";
            this.columnHeader44.Width = 256;
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.panel22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel22.Controls.Add(this.lblTotalPinard);
            this.panel22.Controls.Add(this.pictureBox10);
            this.panel22.Controls.Add(this.label11);
            this.panel22.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel22.Location = new System.Drawing.Point(0, 330);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(836, 33);
            this.panel22.TabIndex = 30;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox10.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox10.Image = global::AppInternacao.Properties.Resources.left;
            this.pictureBox10.Location = new System.Drawing.Point(801, 0);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.pictureBox10.Size = new System.Drawing.Size(35, 33);
            this.pictureBox10.TabIndex = 6;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "GloboPinard";
            this.pictureBox10.Click += new System.EventHandler(this.imgAccordion_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(3, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(242, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Globo de Segurança de Pinard ";
            // 
            // pLesaoCompressao
            // 
            this.pLesaoCompressao.Controls.Add(this.listViewLesaoCompressao);
            this.pLesaoCompressao.Controls.Add(this.listViewTemplateLesaoCompressao);
            this.pLesaoCompressao.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLesaoCompressao.Location = new System.Drawing.Point(0, 330);
            this.pLesaoCompressao.Name = "pLesaoCompressao";
            this.pLesaoCompressao.Padding = new System.Windows.Forms.Padding(10);
            this.pLesaoCompressao.Size = new System.Drawing.Size(836, 0);
            this.pLesaoCompressao.TabIndex = 29;
            this.pLesaoCompressao.Tag = "0";
            // 
            // listViewLesaoCompressao
            // 
            this.listViewLesaoCompressao.AllowDrop = true;
            this.listViewLesaoCompressao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewLesaoCompressao.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader37,
            columnHeader38});
            this.listViewLesaoCompressao.Dock = System.Windows.Forms.DockStyle.Left;
            this.listViewLesaoCompressao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewLesaoCompressao.FullRowSelect = true;
            this.listViewLesaoCompressao.HideSelection = false;
            this.listViewLesaoCompressao.Location = new System.Drawing.Point(10, 10);
            this.listViewLesaoCompressao.MultiSelect = false;
            this.listViewLesaoCompressao.Name = "listViewLesaoCompressao";
            this.listViewLesaoCompressao.Size = new System.Drawing.Size(332, 0);
            this.listViewLesaoCompressao.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewLesaoCompressao.TabIndex = 1;
            this.listViewLesaoCompressao.UseCompatibleStateImageBehavior = false;
            this.listViewLesaoCompressao.View = System.Windows.Forms.View.Details;
            this.listViewLesaoCompressao.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewLesaoCompressao_ItemDrag);
            this.listViewLesaoCompressao.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewLesaoCompressao_DragDrop);
            this.listViewLesaoCompressao.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewLesaoCompressao_DragEnter);
            // 
            // listViewTemplateLesaoCompressao
            // 
            this.listViewTemplateLesaoCompressao.AllowDrop = true;
            this.listViewTemplateLesaoCompressao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewTemplateLesaoCompressao.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader39,
            this.columnHeader40});
            this.listViewTemplateLesaoCompressao.Dock = System.Windows.Forms.DockStyle.Right;
            this.listViewTemplateLesaoCompressao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTemplateLesaoCompressao.FullRowSelect = true;
            this.listViewTemplateLesaoCompressao.HideSelection = false;
            this.listViewTemplateLesaoCompressao.Location = new System.Drawing.Point(494, 10);
            this.listViewTemplateLesaoCompressao.MultiSelect = false;
            this.listViewTemplateLesaoCompressao.Name = "listViewTemplateLesaoCompressao";
            this.listViewTemplateLesaoCompressao.Size = new System.Drawing.Size(332, 0);
            this.listViewTemplateLesaoCompressao.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewTemplateLesaoCompressao.TabIndex = 2;
            this.listViewTemplateLesaoCompressao.UseCompatibleStateImageBehavior = false;
            this.listViewTemplateLesaoCompressao.View = System.Windows.Forms.View.Details;
            this.listViewTemplateLesaoCompressao.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewTemplateLesaoCompressao_ItemDrag);
            this.listViewTemplateLesaoCompressao.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewTemplateLesaoCompressao_DragDrop);
            this.listViewTemplateLesaoCompressao.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewTemplateLesaoCompressao_DragEnter);
            // 
            // columnHeader39
            // 
            this.columnHeader39.Text = "Codigo";
            this.columnHeader39.Width = 75;
            // 
            // columnHeader40
            // 
            this.columnHeader40.Text = "Itens no Template";
            this.columnHeader40.Width = 256;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.panel20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel20.Controls.Add(this.lblTotalCompressao);
            this.panel20.Controls.Add(this.pictureBox9);
            this.panel20.Controls.Add(this.label10);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel20.Location = new System.Drawing.Point(0, 297);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(836, 33);
            this.panel20.TabIndex = 28;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox9.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox9.Image = global::AppInternacao.Properties.Resources.left;
            this.pictureBox9.Location = new System.Drawing.Point(801, 0);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.pictureBox9.Size = new System.Drawing.Size(35, 33);
            this.pictureBox9.TabIndex = 6;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "LesaoCompressao";
            this.pictureBox9.Click += new System.EventHandler(this.imgAccordion_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Lesão por Compressão";
            // 
            // pSistemaUrinario
            // 
            this.pSistemaUrinario.Controls.Add(this.listViewSistemaUrinario);
            this.pSistemaUrinario.Controls.Add(this.listViewTemplateSistemaUrinario);
            this.pSistemaUrinario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSistemaUrinario.Location = new System.Drawing.Point(0, 297);
            this.pSistemaUrinario.Name = "pSistemaUrinario";
            this.pSistemaUrinario.Padding = new System.Windows.Forms.Padding(10);
            this.pSistemaUrinario.Size = new System.Drawing.Size(836, 0);
            this.pSistemaUrinario.TabIndex = 27;
            this.pSistemaUrinario.Tag = "0";
            // 
            // listViewSistemaUrinario
            // 
            this.listViewSistemaUrinario.AllowDrop = true;
            this.listViewSistemaUrinario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewSistemaUrinario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader33,
            columnHeader34});
            this.listViewSistemaUrinario.Dock = System.Windows.Forms.DockStyle.Left;
            this.listViewSistemaUrinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewSistemaUrinario.FullRowSelect = true;
            this.listViewSistemaUrinario.HideSelection = false;
            this.listViewSistemaUrinario.Location = new System.Drawing.Point(10, 10);
            this.listViewSistemaUrinario.MultiSelect = false;
            this.listViewSistemaUrinario.Name = "listViewSistemaUrinario";
            this.listViewSistemaUrinario.Size = new System.Drawing.Size(332, 0);
            this.listViewSistemaUrinario.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewSistemaUrinario.TabIndex = 1;
            this.listViewSistemaUrinario.UseCompatibleStateImageBehavior = false;
            this.listViewSistemaUrinario.View = System.Windows.Forms.View.Details;
            this.listViewSistemaUrinario.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewSistemaUrinario_ItemDrag);
            this.listViewSistemaUrinario.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewSistemaUrinario_DragDrop);
            this.listViewSistemaUrinario.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewSistemaUrinario_DragEnter);
            // 
            // listViewTemplateSistemaUrinario
            // 
            this.listViewTemplateSistemaUrinario.AllowDrop = true;
            this.listViewTemplateSistemaUrinario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewTemplateSistemaUrinario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader35,
            this.columnHeader36});
            this.listViewTemplateSistemaUrinario.Dock = System.Windows.Forms.DockStyle.Right;
            this.listViewTemplateSistemaUrinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTemplateSistemaUrinario.FullRowSelect = true;
            this.listViewTemplateSistemaUrinario.HideSelection = false;
            this.listViewTemplateSistemaUrinario.Location = new System.Drawing.Point(494, 10);
            this.listViewTemplateSistemaUrinario.MultiSelect = false;
            this.listViewTemplateSistemaUrinario.Name = "listViewTemplateSistemaUrinario";
            this.listViewTemplateSistemaUrinario.Size = new System.Drawing.Size(332, 0);
            this.listViewTemplateSistemaUrinario.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewTemplateSistemaUrinario.TabIndex = 2;
            this.listViewTemplateSistemaUrinario.UseCompatibleStateImageBehavior = false;
            this.listViewTemplateSistemaUrinario.View = System.Windows.Forms.View.Details;
            this.listViewTemplateSistemaUrinario.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewTemplateSistemaUrinario_ItemDrag);
            this.listViewTemplateSistemaUrinario.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewTemplateSistemaUrinario_DragDrop);
            this.listViewTemplateSistemaUrinario.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewTemplateSistemaUrinario_DragEnter);
            // 
            // columnHeader35
            // 
            this.columnHeader35.Text = "Codigo";
            this.columnHeader35.Width = 75;
            // 
            // columnHeader36
            // 
            this.columnHeader36.Text = "Itens no Template";
            this.columnHeader36.Width = 256;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.panel18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel18.Controls.Add(this.lblTotalUrinario);
            this.panel18.Controls.Add(this.pictureBox8);
            this.panel18.Controls.Add(this.label9);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel18.Location = new System.Drawing.Point(0, 264);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(836, 33);
            this.panel18.TabIndex = 26;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox8.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox8.Image = global::AppInternacao.Properties.Resources.left;
            this.pictureBox8.Location = new System.Drawing.Point(801, 0);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.pictureBox8.Size = new System.Drawing.Size(35, 33);
            this.pictureBox8.TabIndex = 6;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "SistemaUrinario";
            this.pictureBox8.Click += new System.EventHandler(this.imgAccordion_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(251, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Diagnostico de Sistema Urinário";
            // 
            // pSistemaAbdominal
            // 
            this.pSistemaAbdominal.Controls.Add(this.listViewSistemaAbdominal);
            this.pSistemaAbdominal.Controls.Add(this.listViewTemplateSistemaAbdominal);
            this.pSistemaAbdominal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSistemaAbdominal.Location = new System.Drawing.Point(0, 264);
            this.pSistemaAbdominal.Name = "pSistemaAbdominal";
            this.pSistemaAbdominal.Padding = new System.Windows.Forms.Padding(10);
            this.pSistemaAbdominal.Size = new System.Drawing.Size(836, 0);
            this.pSistemaAbdominal.TabIndex = 25;
            this.pSistemaAbdominal.Tag = "0";
            // 
            // listViewSistemaAbdominal
            // 
            this.listViewSistemaAbdominal.AllowDrop = true;
            this.listViewSistemaAbdominal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewSistemaAbdominal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader29,
            columnHeader30});
            this.listViewSistemaAbdominal.Dock = System.Windows.Forms.DockStyle.Left;
            this.listViewSistemaAbdominal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewSistemaAbdominal.FullRowSelect = true;
            this.listViewSistemaAbdominal.HideSelection = false;
            this.listViewSistemaAbdominal.Location = new System.Drawing.Point(10, 10);
            this.listViewSistemaAbdominal.MultiSelect = false;
            this.listViewSistemaAbdominal.Name = "listViewSistemaAbdominal";
            this.listViewSistemaAbdominal.Size = new System.Drawing.Size(332, 0);
            this.listViewSistemaAbdominal.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewSistemaAbdominal.TabIndex = 1;
            this.listViewSistemaAbdominal.UseCompatibleStateImageBehavior = false;
            this.listViewSistemaAbdominal.View = System.Windows.Forms.View.Details;
            this.listViewSistemaAbdominal.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewSistemaAbdominal_ItemDrag);
            this.listViewSistemaAbdominal.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewSistemaAbdominal_DragDrop);
            this.listViewSistemaAbdominal.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewSistemaAbdominal_DragEnter);
            // 
            // listViewTemplateSistemaAbdominal
            // 
            this.listViewTemplateSistemaAbdominal.AllowDrop = true;
            this.listViewTemplateSistemaAbdominal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewTemplateSistemaAbdominal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader31,
            this.columnHeader32});
            this.listViewTemplateSistemaAbdominal.Dock = System.Windows.Forms.DockStyle.Right;
            this.listViewTemplateSistemaAbdominal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTemplateSistemaAbdominal.FullRowSelect = true;
            this.listViewTemplateSistemaAbdominal.HideSelection = false;
            this.listViewTemplateSistemaAbdominal.Location = new System.Drawing.Point(494, 10);
            this.listViewTemplateSistemaAbdominal.MultiSelect = false;
            this.listViewTemplateSistemaAbdominal.Name = "listViewTemplateSistemaAbdominal";
            this.listViewTemplateSistemaAbdominal.Size = new System.Drawing.Size(332, 0);
            this.listViewTemplateSistemaAbdominal.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewTemplateSistemaAbdominal.TabIndex = 2;
            this.listViewTemplateSistemaAbdominal.UseCompatibleStateImageBehavior = false;
            this.listViewTemplateSistemaAbdominal.View = System.Windows.Forms.View.Details;
            this.listViewTemplateSistemaAbdominal.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewTemplateSistemaAbdominal_ItemDrag);
            this.listViewTemplateSistemaAbdominal.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewTemplateSistemaAbdominal_DragDrop);
            this.listViewTemplateSistemaAbdominal.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewTemplateSistemaAbdominal_DragEnter);
            // 
            // columnHeader31
            // 
            this.columnHeader31.Text = "Codigo";
            this.columnHeader31.Width = 75;
            // 
            // columnHeader32
            // 
            this.columnHeader32.Text = "Itens no Template";
            this.columnHeader32.Width = 256;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.panel16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel16.Controls.Add(this.lblTotalAbdominal);
            this.panel16.Controls.Add(this.pictureBox7);
            this.panel16.Controls.Add(this.label8);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel16.Location = new System.Drawing.Point(0, 231);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(836, 33);
            this.panel16.TabIndex = 24;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox7.Image = global::AppInternacao.Properties.Resources.left;
            this.pictureBox7.Location = new System.Drawing.Point(801, 0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.pictureBox7.Size = new System.Drawing.Size(35, 33);
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "SistemaAbdominal";
            this.pictureBox7.Click += new System.EventHandler(this.imgAccordion_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(270, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Diagnostico de Sistema Abdominal";
            // 
            // pSistemaVascular
            // 
            this.pSistemaVascular.Controls.Add(this.listViewSistemaVascular);
            this.pSistemaVascular.Controls.Add(this.listViewTemplateSistemaVascular);
            this.pSistemaVascular.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSistemaVascular.Location = new System.Drawing.Point(0, 231);
            this.pSistemaVascular.Name = "pSistemaVascular";
            this.pSistemaVascular.Padding = new System.Windows.Forms.Padding(10);
            this.pSistemaVascular.Size = new System.Drawing.Size(836, 0);
            this.pSistemaVascular.TabIndex = 23;
            this.pSistemaVascular.Tag = "0";
            // 
            // listViewSistemaVascular
            // 
            this.listViewSistemaVascular.AllowDrop = true;
            this.listViewSistemaVascular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewSistemaVascular.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader25,
            columnHeader26});
            this.listViewSistemaVascular.Dock = System.Windows.Forms.DockStyle.Left;
            this.listViewSistemaVascular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewSistemaVascular.FullRowSelect = true;
            this.listViewSistemaVascular.HideSelection = false;
            this.listViewSistemaVascular.Location = new System.Drawing.Point(10, 10);
            this.listViewSistemaVascular.MultiSelect = false;
            this.listViewSistemaVascular.Name = "listViewSistemaVascular";
            this.listViewSistemaVascular.Size = new System.Drawing.Size(332, 0);
            this.listViewSistemaVascular.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewSistemaVascular.TabIndex = 1;
            this.listViewSistemaVascular.UseCompatibleStateImageBehavior = false;
            this.listViewSistemaVascular.View = System.Windows.Forms.View.Details;
            this.listViewSistemaVascular.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewSistemaVascular_ItemDrag);
            this.listViewSistemaVascular.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewSistemaVascular_DragDrop);
            this.listViewSistemaVascular.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewSistemaVascular_DragEnter);
            // 
            // listViewTemplateSistemaVascular
            // 
            this.listViewTemplateSistemaVascular.AllowDrop = true;
            this.listViewTemplateSistemaVascular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewTemplateSistemaVascular.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader27,
            this.columnHeader28});
            this.listViewTemplateSistemaVascular.Dock = System.Windows.Forms.DockStyle.Right;
            this.listViewTemplateSistemaVascular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTemplateSistemaVascular.FullRowSelect = true;
            this.listViewTemplateSistemaVascular.HideSelection = false;
            this.listViewTemplateSistemaVascular.Location = new System.Drawing.Point(494, 10);
            this.listViewTemplateSistemaVascular.MultiSelect = false;
            this.listViewTemplateSistemaVascular.Name = "listViewTemplateSistemaVascular";
            this.listViewTemplateSistemaVascular.Size = new System.Drawing.Size(332, 0);
            this.listViewTemplateSistemaVascular.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewTemplateSistemaVascular.TabIndex = 2;
            this.listViewTemplateSistemaVascular.UseCompatibleStateImageBehavior = false;
            this.listViewTemplateSistemaVascular.View = System.Windows.Forms.View.Details;
            this.listViewTemplateSistemaVascular.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewTemplateSistemaVascular_ItemDrag);
            this.listViewTemplateSistemaVascular.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewTemplateSistemaVascular_DragDrop);
            this.listViewTemplateSistemaVascular.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewTemplateSistemaVascular_DragEnter);
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "Codigo";
            this.columnHeader27.Width = 75;
            // 
            // columnHeader28
            // 
            this.columnHeader28.Text = "Itens no Template";
            this.columnHeader28.Width = 256;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.panel14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel14.Controls.Add(this.lblTotalVascular);
            this.panel14.Controls.Add(this.pictureBox6);
            this.panel14.Controls.Add(this.label7);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 198);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(836, 33);
            this.panel14.TabIndex = 22;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox6.Image = global::AppInternacao.Properties.Resources.left;
            this.pictureBox6.Location = new System.Drawing.Point(801, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.pictureBox6.Size = new System.Drawing.Size(35, 33);
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "SistemaVascular";
            this.pictureBox6.Click += new System.EventHandler(this.imgAccordion_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(258, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Diagnostico de Sistema Vascular";
            // 
            // pSistemaGastrointestinal
            // 
            this.pSistemaGastrointestinal.Controls.Add(this.listViewSistemaGastrointestinal);
            this.pSistemaGastrointestinal.Controls.Add(this.listViewTemplateSistemaGastrointestinal);
            this.pSistemaGastrointestinal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSistemaGastrointestinal.Location = new System.Drawing.Point(0, 198);
            this.pSistemaGastrointestinal.Name = "pSistemaGastrointestinal";
            this.pSistemaGastrointestinal.Padding = new System.Windows.Forms.Padding(10);
            this.pSistemaGastrointestinal.Size = new System.Drawing.Size(836, 0);
            this.pSistemaGastrointestinal.TabIndex = 21;
            this.pSistemaGastrointestinal.Tag = "0";
            // 
            // listViewSistemaGastrointestinal
            // 
            this.listViewSistemaGastrointestinal.AllowDrop = true;
            this.listViewSistemaGastrointestinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewSistemaGastrointestinal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader21,
            columnHeader22});
            this.listViewSistemaGastrointestinal.Dock = System.Windows.Forms.DockStyle.Left;
            this.listViewSistemaGastrointestinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewSistemaGastrointestinal.FullRowSelect = true;
            this.listViewSistemaGastrointestinal.HideSelection = false;
            this.listViewSistemaGastrointestinal.Location = new System.Drawing.Point(10, 10);
            this.listViewSistemaGastrointestinal.MultiSelect = false;
            this.listViewSistemaGastrointestinal.Name = "listViewSistemaGastrointestinal";
            this.listViewSistemaGastrointestinal.Size = new System.Drawing.Size(332, 0);
            this.listViewSistemaGastrointestinal.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewSistemaGastrointestinal.TabIndex = 1;
            this.listViewSistemaGastrointestinal.UseCompatibleStateImageBehavior = false;
            this.listViewSistemaGastrointestinal.View = System.Windows.Forms.View.Details;
            this.listViewSistemaGastrointestinal.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewSistemaGastrointestinal_ItemDrag);
            this.listViewSistemaGastrointestinal.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewSistemaGastrointestinal_DragDrop);
            this.listViewSistemaGastrointestinal.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewSistemaGastrointestinal_DragEnter);
            // 
            // listViewTemplateSistemaGastrointestinal
            // 
            this.listViewTemplateSistemaGastrointestinal.AllowDrop = true;
            this.listViewTemplateSistemaGastrointestinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewTemplateSistemaGastrointestinal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader23,
            this.columnHeader24});
            this.listViewTemplateSistemaGastrointestinal.Dock = System.Windows.Forms.DockStyle.Right;
            this.listViewTemplateSistemaGastrointestinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTemplateSistemaGastrointestinal.FullRowSelect = true;
            this.listViewTemplateSistemaGastrointestinal.HideSelection = false;
            this.listViewTemplateSistemaGastrointestinal.Location = new System.Drawing.Point(494, 10);
            this.listViewTemplateSistemaGastrointestinal.MultiSelect = false;
            this.listViewTemplateSistemaGastrointestinal.Name = "listViewTemplateSistemaGastrointestinal";
            this.listViewTemplateSistemaGastrointestinal.Size = new System.Drawing.Size(332, 0);
            this.listViewTemplateSistemaGastrointestinal.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewTemplateSistemaGastrointestinal.TabIndex = 2;
            this.listViewTemplateSistemaGastrointestinal.UseCompatibleStateImageBehavior = false;
            this.listViewTemplateSistemaGastrointestinal.View = System.Windows.Forms.View.Details;
            this.listViewTemplateSistemaGastrointestinal.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewTemplateSistemaGastrointestinal_ItemDrag);
            this.listViewTemplateSistemaGastrointestinal.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewTemplateSistemaGastrointestinal_DragDrop);
            this.listViewTemplateSistemaGastrointestinal.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewTemplateSistemaGastrointestinal_DragEnter);
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Codigo";
            this.columnHeader23.Width = 75;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "Itens no Template";
            this.columnHeader24.Width = 256;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel12.Controls.Add(this.lblTotalGastro);
            this.panel12.Controls.Add(this.pictureBox5);
            this.panel12.Controls.Add(this.label6);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 165);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(836, 33);
            this.panel12.TabIndex = 20;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox5.Image = global::AppInternacao.Properties.Resources.left;
            this.pictureBox5.Location = new System.Drawing.Point(801, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.pictureBox5.Size = new System.Drawing.Size(35, 33);
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "SistemaGastrointestinal";
            this.pictureBox5.Click += new System.EventHandler(this.imgAccordion_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(310, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Diagnostico de Sistema Gastrointestinal";
            // 
            // pPele
            // 
            this.pPele.Controls.Add(this.listViewPele);
            this.pPele.Controls.Add(this.listViewTemplatePele);
            this.pPele.Dock = System.Windows.Forms.DockStyle.Top;
            this.pPele.Location = new System.Drawing.Point(0, 165);
            this.pPele.Name = "pPele";
            this.pPele.Padding = new System.Windows.Forms.Padding(10);
            this.pPele.Size = new System.Drawing.Size(836, 0);
            this.pPele.TabIndex = 19;
            this.pPele.Tag = "0";
            // 
            // listViewPele
            // 
            this.listViewPele.AllowDrop = true;
            this.listViewPele.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewPele.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader17,
            columnHeader18});
            this.listViewPele.Dock = System.Windows.Forms.DockStyle.Left;
            this.listViewPele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewPele.FullRowSelect = true;
            this.listViewPele.HideSelection = false;
            this.listViewPele.Location = new System.Drawing.Point(10, 10);
            this.listViewPele.MultiSelect = false;
            this.listViewPele.Name = "listViewPele";
            this.listViewPele.Size = new System.Drawing.Size(332, 0);
            this.listViewPele.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewPele.TabIndex = 1;
            this.listViewPele.UseCompatibleStateImageBehavior = false;
            this.listViewPele.View = System.Windows.Forms.View.Details;
            this.listViewPele.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewPele_ItemDrag);
            this.listViewPele.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewPele_DragDrop);
            this.listViewPele.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewPele_DragEnter);
            // 
            // listViewTemplatePele
            // 
            this.listViewTemplatePele.AllowDrop = true;
            this.listViewTemplatePele.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewTemplatePele.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader19,
            this.columnHeader20});
            this.listViewTemplatePele.Dock = System.Windows.Forms.DockStyle.Right;
            this.listViewTemplatePele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTemplatePele.FullRowSelect = true;
            this.listViewTemplatePele.HideSelection = false;
            this.listViewTemplatePele.Location = new System.Drawing.Point(494, 10);
            this.listViewTemplatePele.MultiSelect = false;
            this.listViewTemplatePele.Name = "listViewTemplatePele";
            this.listViewTemplatePele.Size = new System.Drawing.Size(332, 0);
            this.listViewTemplatePele.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewTemplatePele.TabIndex = 2;
            this.listViewTemplatePele.UseCompatibleStateImageBehavior = false;
            this.listViewTemplatePele.View = System.Windows.Forms.View.Details;
            this.listViewTemplatePele.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewTemplatePele_ItemDrag);
            this.listViewTemplatePele.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewTemplatePele_DragDrop);
            this.listViewTemplatePele.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewTemplatePele_DragEnter);
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Codigo";
            this.columnHeader19.Width = 75;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Itens no Template";
            this.columnHeader20.Width = 256;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel10.Controls.Add(this.lblTotalPele);
            this.panel10.Controls.Add(this.pictureBox4);
            this.panel10.Controls.Add(this.label5);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 132);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(836, 33);
            this.panel10.TabIndex = 18;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox4.Image = global::AppInternacao.Properties.Resources.left;
            this.pictureBox4.Location = new System.Drawing.Point(801, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.pictureBox4.Size = new System.Drawing.Size(35, 33);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "Pele";
            this.pictureBox4.Click += new System.EventHandler(this.imgAccordion_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Diagnostico de Pele";
            // 
            // pOxigenacao
            // 
            this.pOxigenacao.Controls.Add(this.listViewOxigenacao);
            this.pOxigenacao.Controls.Add(this.listViewTemplateOxigenacao);
            this.pOxigenacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.pOxigenacao.Location = new System.Drawing.Point(0, 132);
            this.pOxigenacao.Name = "pOxigenacao";
            this.pOxigenacao.Padding = new System.Windows.Forms.Padding(10);
            this.pOxigenacao.Size = new System.Drawing.Size(836, 0);
            this.pOxigenacao.TabIndex = 17;
            this.pOxigenacao.Tag = "0";
            // 
            // listViewOxigenacao
            // 
            this.listViewOxigenacao.AllowDrop = true;
            this.listViewOxigenacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewOxigenacao.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader13,
            columnHeader14});
            this.listViewOxigenacao.Dock = System.Windows.Forms.DockStyle.Left;
            this.listViewOxigenacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewOxigenacao.FullRowSelect = true;
            this.listViewOxigenacao.HideSelection = false;
            this.listViewOxigenacao.Location = new System.Drawing.Point(10, 10);
            this.listViewOxigenacao.MultiSelect = false;
            this.listViewOxigenacao.Name = "listViewOxigenacao";
            this.listViewOxigenacao.Size = new System.Drawing.Size(332, 0);
            this.listViewOxigenacao.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewOxigenacao.TabIndex = 1;
            this.listViewOxigenacao.UseCompatibleStateImageBehavior = false;
            this.listViewOxigenacao.View = System.Windows.Forms.View.Details;
            this.listViewOxigenacao.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewOxigenacao_ItemDrag);
            this.listViewOxigenacao.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewOxigenacao_DragDrop);
            this.listViewOxigenacao.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewOxigenacao_DragEnter);
            // 
            // listViewTemplateOxigenacao
            // 
            this.listViewTemplateOxigenacao.AllowDrop = true;
            this.listViewTemplateOxigenacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewTemplateOxigenacao.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader15,
            this.columnHeader16});
            this.listViewTemplateOxigenacao.Dock = System.Windows.Forms.DockStyle.Right;
            this.listViewTemplateOxigenacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTemplateOxigenacao.FullRowSelect = true;
            this.listViewTemplateOxigenacao.HideSelection = false;
            this.listViewTemplateOxigenacao.Location = new System.Drawing.Point(494, 10);
            this.listViewTemplateOxigenacao.MultiSelect = false;
            this.listViewTemplateOxigenacao.Name = "listViewTemplateOxigenacao";
            this.listViewTemplateOxigenacao.Size = new System.Drawing.Size(332, 0);
            this.listViewTemplateOxigenacao.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewTemplateOxigenacao.TabIndex = 2;
            this.listViewTemplateOxigenacao.UseCompatibleStateImageBehavior = false;
            this.listViewTemplateOxigenacao.View = System.Windows.Forms.View.Details;
            this.listViewTemplateOxigenacao.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewTemplateOxigenacao_ItemDrag);
            this.listViewTemplateOxigenacao.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewTemplateOxigenacao_DragDrop);
            this.listViewTemplateOxigenacao.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewTemplateOxigenacao_DragEnter);
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Codigo";
            this.columnHeader15.Width = 75;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Itens no Template";
            this.columnHeader16.Width = 256;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel8.Controls.Add(this.lblTotalOxigenacao);
            this.panel8.Controls.Add(this.pictureBox3);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 99);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(836, 33);
            this.panel8.TabIndex = 16;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox3.Image = global::AppInternacao.Properties.Resources.left;
            this.pictureBox3.Location = new System.Drawing.Point(801, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.pictureBox3.Size = new System.Drawing.Size(35, 33);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "Oxigenacao";
            this.pictureBox3.Click += new System.EventHandler(this.imgAccordion_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Diagnostico do Sistema de Oxigenação";
            // 
            // pRegulacaoTermica
            // 
            this.pRegulacaoTermica.Controls.Add(this.listViewRegulacaoTermica);
            this.pRegulacaoTermica.Controls.Add(this.listViewTemplateRegulacaoTermica);
            this.pRegulacaoTermica.Dock = System.Windows.Forms.DockStyle.Top;
            this.pRegulacaoTermica.Location = new System.Drawing.Point(0, 99);
            this.pRegulacaoTermica.Name = "pRegulacaoTermica";
            this.pRegulacaoTermica.Padding = new System.Windows.Forms.Padding(10);
            this.pRegulacaoTermica.Size = new System.Drawing.Size(836, 0);
            this.pRegulacaoTermica.TabIndex = 15;
            this.pRegulacaoTermica.Tag = "0";
            // 
            // listViewRegulacaoTermica
            // 
            this.listViewRegulacaoTermica.AllowDrop = true;
            this.listViewRegulacaoTermica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewRegulacaoTermica.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader9,
            columnHeader10});
            this.listViewRegulacaoTermica.Dock = System.Windows.Forms.DockStyle.Left;
            this.listViewRegulacaoTermica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewRegulacaoTermica.FullRowSelect = true;
            this.listViewRegulacaoTermica.HideSelection = false;
            this.listViewRegulacaoTermica.Location = new System.Drawing.Point(10, 10);
            this.listViewRegulacaoTermica.MultiSelect = false;
            this.listViewRegulacaoTermica.Name = "listViewRegulacaoTermica";
            this.listViewRegulacaoTermica.Size = new System.Drawing.Size(332, 0);
            this.listViewRegulacaoTermica.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewRegulacaoTermica.TabIndex = 1;
            this.listViewRegulacaoTermica.UseCompatibleStateImageBehavior = false;
            this.listViewRegulacaoTermica.View = System.Windows.Forms.View.Details;
            this.listViewRegulacaoTermica.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewRegulacaoTermica_ItemDrag);
            this.listViewRegulacaoTermica.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewRegulacaoTermica_DragDrop);
            this.listViewRegulacaoTermica.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewRegulacaoTermica_DragEnter);
            // 
            // listViewTemplateRegulacaoTermica
            // 
            this.listViewTemplateRegulacaoTermica.AllowDrop = true;
            this.listViewTemplateRegulacaoTermica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewTemplateRegulacaoTermica.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12});
            this.listViewTemplateRegulacaoTermica.Dock = System.Windows.Forms.DockStyle.Right;
            this.listViewTemplateRegulacaoTermica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTemplateRegulacaoTermica.FullRowSelect = true;
            this.listViewTemplateRegulacaoTermica.HideSelection = false;
            this.listViewTemplateRegulacaoTermica.Location = new System.Drawing.Point(494, 10);
            this.listViewTemplateRegulacaoTermica.MultiSelect = false;
            this.listViewTemplateRegulacaoTermica.Name = "listViewTemplateRegulacaoTermica";
            this.listViewTemplateRegulacaoTermica.Size = new System.Drawing.Size(332, 0);
            this.listViewTemplateRegulacaoTermica.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewTemplateRegulacaoTermica.TabIndex = 2;
            this.listViewTemplateRegulacaoTermica.UseCompatibleStateImageBehavior = false;
            this.listViewTemplateRegulacaoTermica.View = System.Windows.Forms.View.Details;
            this.listViewTemplateRegulacaoTermica.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewTemplateRegulacaoTermica_ItemDrag);
            this.listViewTemplateRegulacaoTermica.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewTemplateRegulacaoTermica_DragDrop);
            this.listViewTemplateRegulacaoTermica.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewTemplateRegulacaoTermica_DragEnter);
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Codigo";
            this.columnHeader11.Width = 75;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Itens no Template";
            this.columnHeader12.Width = 256;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel7.Controls.Add(this.lblTotalTermina);
            this.panel7.Controls.Add(this.pictureBox2);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 66);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(836, 33);
            this.panel7.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = global::AppInternacao.Properties.Resources.left;
            this.pictureBox2.Location = new System.Drawing.Point(801, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.pictureBox2.Size = new System.Drawing.Size(35, 33);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "RegulacaoTermica";
            this.pictureBox2.Click += new System.EventHandler(this.imgAccordion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Diagnostico de Regulação Térmica";
            // 
            // pPupilas
            // 
            this.pPupilas.Controls.Add(this.listViewPuplias);
            this.pPupilas.Controls.Add(this.listViewTemplatePuplias);
            this.pPupilas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pPupilas.Location = new System.Drawing.Point(0, 66);
            this.pPupilas.Name = "pPupilas";
            this.pPupilas.Padding = new System.Windows.Forms.Padding(10);
            this.pPupilas.Size = new System.Drawing.Size(836, 0);
            this.pPupilas.TabIndex = 13;
            this.pPupilas.Tag = "0";
            // 
            // listViewPuplias
            // 
            this.listViewPuplias.AllowDrop = true;
            this.listViewPuplias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewPuplias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader5,
            columnHeader6});
            this.listViewPuplias.Dock = System.Windows.Forms.DockStyle.Left;
            this.listViewPuplias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewPuplias.FullRowSelect = true;
            this.listViewPuplias.HideSelection = false;
            this.listViewPuplias.Location = new System.Drawing.Point(10, 10);
            this.listViewPuplias.MultiSelect = false;
            this.listViewPuplias.Name = "listViewPuplias";
            this.listViewPuplias.Size = new System.Drawing.Size(332, 0);
            this.listViewPuplias.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewPuplias.TabIndex = 1;
            this.listViewPuplias.UseCompatibleStateImageBehavior = false;
            this.listViewPuplias.View = System.Windows.Forms.View.Details;
            this.listViewPuplias.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewPuplias_ItemDrag);
            this.listViewPuplias.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewPuplias_DragDrop);
            this.listViewPuplias.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewPuplias_DragEnter);
            // 
            // listViewTemplatePuplias
            // 
            this.listViewTemplatePuplias.AllowDrop = true;
            this.listViewTemplatePuplias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewTemplatePuplias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.listViewTemplatePuplias.Dock = System.Windows.Forms.DockStyle.Right;
            this.listViewTemplatePuplias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTemplatePuplias.FullRowSelect = true;
            this.listViewTemplatePuplias.HideSelection = false;
            this.listViewTemplatePuplias.Location = new System.Drawing.Point(494, 10);
            this.listViewTemplatePuplias.MultiSelect = false;
            this.listViewTemplatePuplias.Name = "listViewTemplatePuplias";
            this.listViewTemplatePuplias.Size = new System.Drawing.Size(332, 0);
            this.listViewTemplatePuplias.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewTemplatePuplias.TabIndex = 2;
            this.listViewTemplatePuplias.UseCompatibleStateImageBehavior = false;
            this.listViewTemplatePuplias.View = System.Windows.Forms.View.Details;
            this.listViewTemplatePuplias.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewTemplatePuplias_ItemDrag);
            this.listViewTemplatePuplias.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewTemplatePuplias_DragDrop);
            this.listViewTemplatePuplias.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewTemplatePuplias_DragEnter);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Codigo";
            this.columnHeader7.Width = 75;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Itens no Template";
            this.columnHeader8.Width = 256;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel5.Controls.Add(this.lblTotalPupila);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(0, 33);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(836, 33);
            this.panel5.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::AppInternacao.Properties.Resources.left;
            this.pictureBox1.Location = new System.Drawing.Point(801, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.pictureBox1.Size = new System.Drawing.Size(35, 33);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Pupilas";
            this.pictureBox1.Click += new System.EventHandler(this.imgAccordion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Diagnostico de Pupilas";
            // 
            // pSistemaNeurologico
            // 
            this.pSistemaNeurologico.Controls.Add(this.listViewItemSistemaNeurologico);
            this.pSistemaNeurologico.Controls.Add(this.listViewTemplateSistemaNeurologico);
            this.pSistemaNeurologico.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSistemaNeurologico.Location = new System.Drawing.Point(0, 33);
            this.pSistemaNeurologico.Name = "pSistemaNeurologico";
            this.pSistemaNeurologico.Padding = new System.Windows.Forms.Padding(10);
            this.pSistemaNeurologico.Size = new System.Drawing.Size(836, 0);
            this.pSistemaNeurologico.TabIndex = 11;
            this.pSistemaNeurologico.Tag = "0";
            // 
            // listViewItemSistemaNeurologico
            // 
            this.listViewItemSistemaNeurologico.AllowDrop = true;
            this.listViewItemSistemaNeurologico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewItemSistemaNeurologico.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            columnHeader2});
            this.listViewItemSistemaNeurologico.Dock = System.Windows.Forms.DockStyle.Left;
            this.listViewItemSistemaNeurologico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewItemSistemaNeurologico.FullRowSelect = true;
            this.listViewItemSistemaNeurologico.HideSelection = false;
            this.listViewItemSistemaNeurologico.Location = new System.Drawing.Point(10, 10);
            this.listViewItemSistemaNeurologico.MultiSelect = false;
            this.listViewItemSistemaNeurologico.Name = "listViewItemSistemaNeurologico";
            this.listViewItemSistemaNeurologico.Size = new System.Drawing.Size(332, 0);
            this.listViewItemSistemaNeurologico.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewItemSistemaNeurologico.TabIndex = 1;
            this.listViewItemSistemaNeurologico.Tag = "0";
            this.listViewItemSistemaNeurologico.UseCompatibleStateImageBehavior = false;
            this.listViewItemSistemaNeurologico.View = System.Windows.Forms.View.Details;
            this.listViewItemSistemaNeurologico.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewItemSistemaNeurologico_ItemDrag);
            this.listViewItemSistemaNeurologico.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewItemSistemaNeurologico_DragDrop);
            this.listViewItemSistemaNeurologico.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewItemSistemaNeurologico_DragEnter);
            // 
            // listViewTemplateSistemaNeurologico
            // 
            this.listViewTemplateSistemaNeurologico.AllowDrop = true;
            this.listViewTemplateSistemaNeurologico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewTemplateSistemaNeurologico.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listViewTemplateSistemaNeurologico.Dock = System.Windows.Forms.DockStyle.Right;
            this.listViewTemplateSistemaNeurologico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTemplateSistemaNeurologico.FullRowSelect = true;
            this.listViewTemplateSistemaNeurologico.HideSelection = false;
            this.listViewTemplateSistemaNeurologico.Location = new System.Drawing.Point(494, 10);
            this.listViewTemplateSistemaNeurologico.MultiSelect = false;
            this.listViewTemplateSistemaNeurologico.Name = "listViewTemplateSistemaNeurologico";
            this.listViewTemplateSistemaNeurologico.Size = new System.Drawing.Size(332, 0);
            this.listViewTemplateSistemaNeurologico.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewTemplateSistemaNeurologico.TabIndex = 2;
            this.listViewTemplateSistemaNeurologico.Tag = "0";
            this.listViewTemplateSistemaNeurologico.UseCompatibleStateImageBehavior = false;
            this.listViewTemplateSistemaNeurologico.View = System.Windows.Forms.View.Details;
            this.listViewTemplateSistemaNeurologico.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewTemplateSistemaNeurologico_ItemDrag);
            this.listViewTemplateSistemaNeurologico.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewTemplateSistemaNeurologico_DragDrop);
            this.listViewTemplateSistemaNeurologico.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewTemplateSistemaNeurologico_DragEnter);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Codigo";
            this.columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Itens no Template";
            this.columnHeader4.Width = 256;
            // 
            // panetitulo1
            // 
            this.panetitulo1.AutoScroll = true;
            this.panetitulo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.panetitulo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panetitulo1.Controls.Add(this.lblTotalNeurologico);
            this.panetitulo1.Controls.Add(this.imgAccordion);
            this.panetitulo1.Controls.Add(this.label1);
            this.panetitulo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panetitulo1.ForeColor = System.Drawing.Color.White;
            this.panetitulo1.Location = new System.Drawing.Point(0, 0);
            this.panetitulo1.Name = "panetitulo1";
            this.panetitulo1.Size = new System.Drawing.Size(836, 33);
            this.panetitulo1.TabIndex = 10;
            // 
            // imgAccordion
            // 
            this.imgAccordion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgAccordion.Dock = System.Windows.Forms.DockStyle.Right;
            this.imgAccordion.Image = global::AppInternacao.Properties.Resources.left;
            this.imgAccordion.Location = new System.Drawing.Point(801, 0);
            this.imgAccordion.Name = "imgAccordion";
            this.imgAccordion.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.imgAccordion.Size = new System.Drawing.Size(35, 33);
            this.imgAccordion.TabIndex = 4;
            this.imgAccordion.TabStop = false;
            this.imgAccordion.Tag = "SistemaNeurologico";
            this.imgAccordion.Click += new System.EventHandler(this.imgAccordion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Diagnosticos do Sistema Neurológico";
            // 
            // timerAccordion
            // 
            this.timerAccordion.Interval = 30;
            this.timerAccordion.Tick += new System.EventHandler(this.timerAccordion_Tick);
            // 
            // lblTotalNeurologico
            // 
            this.lblTotalNeurologico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalNeurologico.AutoSize = true;
            this.lblTotalNeurologico.Location = new System.Drawing.Point(720, 10);
            this.lblTotalNeurologico.Name = "lblTotalNeurologico";
            this.lblTotalNeurologico.Size = new System.Drawing.Size(13, 13);
            this.lblTotalNeurologico.TabIndex = 5;
            this.lblTotalNeurologico.Text = "0";
            this.lblTotalNeurologico.Visible = false;
            // 
            // lblTotalPupila
            // 
            this.lblTotalPupila.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPupila.AutoSize = true;
            this.lblTotalPupila.Location = new System.Drawing.Point(720, 10);
            this.lblTotalPupila.Name = "lblTotalPupila";
            this.lblTotalPupila.Size = new System.Drawing.Size(13, 13);
            this.lblTotalPupila.TabIndex = 6;
            this.lblTotalPupila.Text = "0";
            this.lblTotalPupila.Visible = false;
            // 
            // lblTotalTermina
            // 
            this.lblTotalTermina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalTermina.AutoSize = true;
            this.lblTotalTermina.ForeColor = System.Drawing.Color.White;
            this.lblTotalTermina.Location = new System.Drawing.Point(720, 10);
            this.lblTotalTermina.Name = "lblTotalTermina";
            this.lblTotalTermina.Size = new System.Drawing.Size(13, 13);
            this.lblTotalTermina.TabIndex = 7;
            this.lblTotalTermina.Text = "0";
            this.lblTotalTermina.Visible = false;
            // 
            // lblTotalOxigenacao
            // 
            this.lblTotalOxigenacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalOxigenacao.AutoSize = true;
            this.lblTotalOxigenacao.ForeColor = System.Drawing.Color.White;
            this.lblTotalOxigenacao.Location = new System.Drawing.Point(720, 10);
            this.lblTotalOxigenacao.Name = "lblTotalOxigenacao";
            this.lblTotalOxigenacao.Size = new System.Drawing.Size(13, 13);
            this.lblTotalOxigenacao.TabIndex = 7;
            this.lblTotalOxigenacao.Text = "0";
            this.lblTotalOxigenacao.Visible = false;
            // 
            // lblTotalPele
            // 
            this.lblTotalPele.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPele.AutoSize = true;
            this.lblTotalPele.ForeColor = System.Drawing.Color.White;
            this.lblTotalPele.Location = new System.Drawing.Point(720, 10);
            this.lblTotalPele.Name = "lblTotalPele";
            this.lblTotalPele.Size = new System.Drawing.Size(13, 13);
            this.lblTotalPele.TabIndex = 7;
            this.lblTotalPele.Text = "0";
            this.lblTotalPele.Visible = false;
            // 
            // lblTotalGastro
            // 
            this.lblTotalGastro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalGastro.AutoSize = true;
            this.lblTotalGastro.ForeColor = System.Drawing.Color.White;
            this.lblTotalGastro.Location = new System.Drawing.Point(720, 10);
            this.lblTotalGastro.Name = "lblTotalGastro";
            this.lblTotalGastro.Size = new System.Drawing.Size(13, 13);
            this.lblTotalGastro.TabIndex = 7;
            this.lblTotalGastro.Text = "0";
            this.lblTotalGastro.Visible = false;
            // 
            // lblTotalVascular
            // 
            this.lblTotalVascular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalVascular.AutoSize = true;
            this.lblTotalVascular.ForeColor = System.Drawing.Color.White;
            this.lblTotalVascular.Location = new System.Drawing.Point(720, 10);
            this.lblTotalVascular.Name = "lblTotalVascular";
            this.lblTotalVascular.Size = new System.Drawing.Size(13, 13);
            this.lblTotalVascular.TabIndex = 7;
            this.lblTotalVascular.Text = "0";
            this.lblTotalVascular.Visible = false;
            // 
            // lblTotalAbdominal
            // 
            this.lblTotalAbdominal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalAbdominal.AutoSize = true;
            this.lblTotalAbdominal.ForeColor = System.Drawing.Color.White;
            this.lblTotalAbdominal.Location = new System.Drawing.Point(720, 10);
            this.lblTotalAbdominal.Name = "lblTotalAbdominal";
            this.lblTotalAbdominal.Size = new System.Drawing.Size(13, 13);
            this.lblTotalAbdominal.TabIndex = 7;
            this.lblTotalAbdominal.Text = "0";
            this.lblTotalAbdominal.Visible = false;
            // 
            // lblTotalUrinario
            // 
            this.lblTotalUrinario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalUrinario.AutoSize = true;
            this.lblTotalUrinario.ForeColor = System.Drawing.Color.White;
            this.lblTotalUrinario.Location = new System.Drawing.Point(720, 10);
            this.lblTotalUrinario.Name = "lblTotalUrinario";
            this.lblTotalUrinario.Size = new System.Drawing.Size(13, 13);
            this.lblTotalUrinario.TabIndex = 7;
            this.lblTotalUrinario.Text = "0";
            this.lblTotalUrinario.Visible = false;
            // 
            // lblTotalCompressao
            // 
            this.lblTotalCompressao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalCompressao.AutoSize = true;
            this.lblTotalCompressao.ForeColor = System.Drawing.Color.White;
            this.lblTotalCompressao.Location = new System.Drawing.Point(720, 10);
            this.lblTotalCompressao.Name = "lblTotalCompressao";
            this.lblTotalCompressao.Size = new System.Drawing.Size(13, 13);
            this.lblTotalCompressao.TabIndex = 7;
            this.lblTotalCompressao.Text = "0";
            this.lblTotalCompressao.Visible = false;
            // 
            // lblTotalPinard
            // 
            this.lblTotalPinard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPinard.AutoSize = true;
            this.lblTotalPinard.ForeColor = System.Drawing.Color.White;
            this.lblTotalPinard.Location = new System.Drawing.Point(720, 10);
            this.lblTotalPinard.Name = "lblTotalPinard";
            this.lblTotalPinard.Size = new System.Drawing.Size(13, 13);
            this.lblTotalPinard.TabIndex = 7;
            this.lblTotalPinard.Text = "0";
            this.lblTotalPinard.Visible = false;
            // 
            // lblTotalGlasgow
            // 
            this.lblTotalGlasgow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalGlasgow.AutoSize = true;
            this.lblTotalGlasgow.ForeColor = System.Drawing.Color.White;
            this.lblTotalGlasgow.Location = new System.Drawing.Point(720, 10);
            this.lblTotalGlasgow.Name = "lblTotalGlasgow";
            this.lblTotalGlasgow.Size = new System.Drawing.Size(13, 13);
            this.lblTotalGlasgow.TabIndex = 7;
            this.lblTotalGlasgow.Text = "0";
            this.lblTotalGlasgow.Visible = false;
            // 
            // lblTotalCatetere
            // 
            this.lblTotalCatetere.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalCatetere.AutoSize = true;
            this.lblTotalCatetere.ForeColor = System.Drawing.Color.White;
            this.lblTotalCatetere.Location = new System.Drawing.Point(720, 10);
            this.lblTotalCatetere.Name = "lblTotalCatetere";
            this.lblTotalCatetere.Size = new System.Drawing.Size(13, 13);
            this.lblTotalCatetere.TabIndex = 7;
            this.lblTotalCatetere.Text = "0";
            this.lblTotalCatetere.Visible = false;
            // 
            // lblTotalOutros
            // 
            this.lblTotalOutros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalOutros.AutoSize = true;
            this.lblTotalOutros.ForeColor = System.Drawing.Color.White;
            this.lblTotalOutros.Location = new System.Drawing.Point(720, 10);
            this.lblTotalOutros.Name = "lblTotalOutros";
            this.lblTotalOutros.Size = new System.Drawing.Size(13, 13);
            this.lblTotalOutros.TabIndex = 7;
            this.lblTotalOutros.Text = "0";
            this.lblTotalOutros.Visible = false;
            // 
            // UCTemplateItemExameFisico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panel1);
            this.Name = "UCTemplateItemExameFisico";
            this.Size = new System.Drawing.Size(836, 511);
            this.Load += new System.EventHandler(this.UCTemplateExameFisico_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelBody.ResumeLayout(false);
            this.pPressaoArterial.ResumeLayout(false);
            this.panel28.ResumeLayout(false);
            this.panel28.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.pControleCateteres.ResumeLayout(false);
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.pComaGlasgow.ResumeLayout(false);
            this.panel24.ResumeLayout(false);
            this.panel24.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.pGloboPinard.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.pLesaoCompressao.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.pSistemaUrinario.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.pSistemaAbdominal.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.pSistemaVascular.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.pSistemaGastrointestinal.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.pPele.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pOxigenacao.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pRegulacaoTermica.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pPupilas.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pSistemaNeurologico.ResumeLayout(false);
            this.panetitulo1.ResumeLayout(false);
            this.panetitulo1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAccordion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStepVoltar;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel pRegulacaoTermica;
        private System.Windows.Forms.ListView listViewRegulacaoTermica;
        private System.Windows.Forms.ListView listViewTemplateRegulacaoTermica;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pPupilas;
        private System.Windows.Forms.ListView listViewPuplias;
        private System.Windows.Forms.ListView listViewTemplatePuplias;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pSistemaNeurologico;
        private System.Windows.Forms.ListView listViewItemSistemaNeurologico;
        private System.Windows.Forms.ListView listViewTemplateSistemaNeurologico;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panetitulo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pOxigenacao;
        private System.Windows.Forms.ListView listViewOxigenacao;
        private System.Windows.Forms.ListView listViewTemplateOxigenacao;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pPele;
        private System.Windows.Forms.ListView listViewPele;
        private System.Windows.Forms.ListView listViewTemplatePele;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pSistemaGastrointestinal;
        private System.Windows.Forms.ListView listViewSistemaGastrointestinal;
        private System.Windows.Forms.ListView listViewTemplateSistemaGastrointestinal;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pSistemaVascular;
        private System.Windows.Forms.ListView listViewSistemaVascular;
        private System.Windows.Forms.ListView listViewTemplateSistemaVascular;
        private System.Windows.Forms.ColumnHeader columnHeader27;
        private System.Windows.Forms.ColumnHeader columnHeader28;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pSistemaAbdominal;
        private System.Windows.Forms.ListView listViewSistemaAbdominal;
        private System.Windows.Forms.ListView listViewTemplateSistemaAbdominal;
        private System.Windows.Forms.ColumnHeader columnHeader31;
        private System.Windows.Forms.ColumnHeader columnHeader32;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pSistemaUrinario;
        private System.Windows.Forms.ListView listViewSistemaUrinario;
        private System.Windows.Forms.ListView listViewTemplateSistemaUrinario;
        private System.Windows.Forms.ColumnHeader columnHeader35;
        private System.Windows.Forms.ColumnHeader columnHeader36;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pLesaoCompressao;
        private System.Windows.Forms.ListView listViewLesaoCompressao;
        private System.Windows.Forms.ListView listViewTemplateLesaoCompressao;
        private System.Windows.Forms.ColumnHeader columnHeader39;
        private System.Windows.Forms.ColumnHeader columnHeader40;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pGloboPinard;
        private System.Windows.Forms.ListView listViewPinard;
        private System.Windows.Forms.ListView listViewTemplatePinard;
        private System.Windows.Forms.ColumnHeader columnHeader43;
        private System.Windows.Forms.ColumnHeader columnHeader44;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pComaGlasgow;
        private System.Windows.Forms.ListView listViewGlasgow;
        private System.Windows.Forms.ListView listViewTemplateGlasgow;
        private System.Windows.Forms.ColumnHeader columnHeader47;
        private System.Windows.Forms.ColumnHeader columnHeader48;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbltituloExame;
        private System.Windows.Forms.Panel pPressaoArterial;
        private System.Windows.Forms.ListView listViewPressaoArterialOutros;
        private System.Windows.Forms.ListView listViewTemplatePressaoArterialOutros;
        private System.Windows.Forms.ColumnHeader columnHeader55;
        private System.Windows.Forms.ColumnHeader columnHeader56;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel pControleCateteres;
        private System.Windows.Forms.ListView listViewCatetres;
        private System.Windows.Forms.ListView listViewTemplateCatetres;
        private System.Windows.Forms.ColumnHeader columnHeader51;
        private System.Windows.Forms.ColumnHeader columnHeader52;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Button btnVisualizarTemplate;
        private System.Windows.Forms.PictureBox imgAccordion;
        private System.Windows.Forms.Timer timerAccordion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTotalNeurologico;
        private System.Windows.Forms.Label lblTotalOutros;
        private System.Windows.Forms.Label lblTotalCatetere;
        private System.Windows.Forms.Label lblTotalGlasgow;
        private System.Windows.Forms.Label lblTotalPinard;
        private System.Windows.Forms.Label lblTotalCompressao;
        private System.Windows.Forms.Label lblTotalUrinario;
        private System.Windows.Forms.Label lblTotalAbdominal;
        private System.Windows.Forms.Label lblTotalVascular;
        private System.Windows.Forms.Label lblTotalGastro;
        private System.Windows.Forms.Label lblTotalPele;
        private System.Windows.Forms.Label lblTotalOxigenacao;
        private System.Windows.Forms.Label lblTotalTermina;
        private System.Windows.Forms.Label lblTotalPupila;
    }
}
