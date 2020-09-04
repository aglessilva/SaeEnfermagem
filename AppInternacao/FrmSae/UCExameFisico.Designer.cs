namespace AppInternacao.FrmSae
{
    partial class UCExameFisico
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
            this.comboBoxEstruturaFisica = new System.Windows.Forms.ComboBox();
            this.gTipoEstruturaFisica = new System.Windows.Forms.GroupBox();
            this.pBody = new System.Windows.Forms.Panel();
            this.gSistemaGastroIntestinal = new System.Windows.Forms.GroupBox();
            this.gSistemaOxigenacao = new System.Windows.Forms.GroupBox();
            this.gRegulacaoTermica = new System.Windows.Forms.GroupBox();
            this.gSistemaNeurologico = new System.Windows.Forms.GroupBox();
            this.gPupilas = new System.Windows.Forms.GroupBox();
            this.gSistemaVascular = new System.Windows.Forms.GroupBox();
            this.gPele = new System.Windows.Forms.GroupBox();
            this.gSistemaAbdominal = new System.Windows.Forms.GroupBox();
            this.gSistemaUrinario = new System.Windows.Forms.GroupBox();
            this.gLesaoCompressao = new System.Windows.Forms.GroupBox();
            this.gPinard = new System.Windows.Forms.GroupBox();
            this.gGlasgow = new System.Windows.Forms.GroupBox();
            this.gCateterSonda = new System.Windows.Forms.GroupBox();
            this.gEscalaPressao = new System.Windows.Forms.GroupBox();
            this.gTipoEstruturaFisica.SuspendLayout();
            this.pBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxEstruturaFisica
            // 
            this.comboBoxEstruturaFisica.DisplayMember = "Nome";
            this.comboBoxEstruturaFisica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstruturaFisica.FormattingEnabled = true;
            this.comboBoxEstruturaFisica.Location = new System.Drawing.Point(7, 23);
            this.comboBoxEstruturaFisica.Name = "comboBoxEstruturaFisica";
            this.comboBoxEstruturaFisica.Size = new System.Drawing.Size(212, 21);
            this.comboBoxEstruturaFisica.TabIndex = 2;
            this.comboBoxEstruturaFisica.ValueMember = "Id";
            // 
            // gTipoEstruturaFisica
            // 
            this.gTipoEstruturaFisica.Controls.Add(this.comboBoxEstruturaFisica);
            this.gTipoEstruturaFisica.Dock = System.Windows.Forms.DockStyle.Top;
            this.gTipoEstruturaFisica.Location = new System.Drawing.Point(0, 0);
            this.gTipoEstruturaFisica.Name = "gTipoEstruturaFisica";
            this.gTipoEstruturaFisica.Size = new System.Drawing.Size(804, 53);
            this.gTipoEstruturaFisica.TabIndex = 0;
            this.gTipoEstruturaFisica.TabStop = false;
            this.gTipoEstruturaFisica.Text = "Selecione uma Estrutura Física do Paciente.";
            // 
            // pBody
            // 
            this.pBody.AutoScroll = true;
            this.pBody.Controls.Add(this.gEscalaPressao);
            this.pBody.Controls.Add(this.gCateterSonda);
            this.pBody.Controls.Add(this.gGlasgow);
            this.pBody.Controls.Add(this.gPinard);
            this.pBody.Controls.Add(this.gLesaoCompressao);
            this.pBody.Controls.Add(this.gSistemaUrinario);
            this.pBody.Controls.Add(this.gSistemaAbdominal);
            this.pBody.Controls.Add(this.gSistemaVascular);
            this.pBody.Controls.Add(this.gSistemaGastroIntestinal);
            this.pBody.Controls.Add(this.gSistemaOxigenacao);
            this.pBody.Controls.Add(this.gRegulacaoTermica);
            this.pBody.Controls.Add(this.gSistemaNeurologico);
            this.pBody.Controls.Add(this.gPupilas);
            this.pBody.Controls.Add(this.gPele);
            this.pBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBody.Location = new System.Drawing.Point(0, 53);
            this.pBody.Name = "pBody";
            this.pBody.Size = new System.Drawing.Size(804, 497);
            this.pBody.TabIndex = 1;
            // 
            // gSistemaGastroIntestinal
            // 
            this.gSistemaGastroIntestinal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gSistemaGastroIntestinal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gSistemaGastroIntestinal.Location = new System.Drawing.Point(3, 452);
            this.gSistemaGastroIntestinal.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.gSistemaGastroIntestinal.Name = "gSistemaGastroIntestinal";
            this.gSistemaGastroIntestinal.Size = new System.Drawing.Size(781, 79);
            this.gSistemaGastroIntestinal.TabIndex = 14;
            this.gSistemaGastroIntestinal.TabStop = false;
            this.gSistemaGastroIntestinal.Text = "Diagnostico de Sistema Gastrointestinal";
            // 
            // gSistemaOxigenacao
            // 
            this.gSistemaOxigenacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gSistemaOxigenacao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gSistemaOxigenacao.Location = new System.Drawing.Point(3, 273);
            this.gSistemaOxigenacao.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.gSistemaOxigenacao.Name = "gSistemaOxigenacao";
            this.gSistemaOxigenacao.Size = new System.Drawing.Size(781, 79);
            this.gSistemaOxigenacao.TabIndex = 12;
            this.gSistemaOxigenacao.TabStop = false;
            this.gSistemaOxigenacao.Text = "Diagnostico do Sistema de Oxigenação";
            // 
            // gRegulacaoTermica
            // 
            this.gRegulacaoTermica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gRegulacaoTermica.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gRegulacaoTermica.Location = new System.Drawing.Point(3, 184);
            this.gRegulacaoTermica.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.gRegulacaoTermica.Name = "gRegulacaoTermica";
            this.gRegulacaoTermica.Size = new System.Drawing.Size(781, 79);
            this.gRegulacaoTermica.TabIndex = 11;
            this.gRegulacaoTermica.TabStop = false;
            this.gRegulacaoTermica.Text = "Diagnostico de Regulação Térmica";
            // 
            // gSistemaNeurologico
            // 
            this.gSistemaNeurologico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gSistemaNeurologico.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gSistemaNeurologico.Location = new System.Drawing.Point(3, 5);
            this.gSistemaNeurologico.Name = "gSistemaNeurologico";
            this.gSistemaNeurologico.Size = new System.Drawing.Size(781, 79);
            this.gSistemaNeurologico.TabIndex = 10;
            this.gSistemaNeurologico.TabStop = false;
            this.gSistemaNeurologico.Text = "Diagnosticos do Sistema Neurológico";
            // 
            // gPupilas
            // 
            this.gPupilas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gPupilas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gPupilas.Location = new System.Drawing.Point(3, 95);
            this.gPupilas.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.gPupilas.Name = "gPupilas";
            this.gPupilas.Size = new System.Drawing.Size(781, 79);
            this.gPupilas.TabIndex = 9;
            this.gPupilas.TabStop = false;
            this.gPupilas.Text = "Diagnostico de Pupilas";
            // 
            // gSistemaVascular
            // 
            this.gSistemaVascular.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gSistemaVascular.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gSistemaVascular.Location = new System.Drawing.Point(3, 541);
            this.gSistemaVascular.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.gSistemaVascular.Name = "gSistemaVascular";
            this.gSistemaVascular.Size = new System.Drawing.Size(781, 79);
            this.gSistemaVascular.TabIndex = 9;
            this.gSistemaVascular.TabStop = false;
            this.gSistemaVascular.Text = "Diagnostico de Sistema Vascular";
            // 
            // gPele
            // 
            this.gPele.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gPele.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gPele.Location = new System.Drawing.Point(3, 362);
            this.gPele.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.gPele.Name = "gPele";
            this.gPele.Size = new System.Drawing.Size(781, 79);
            this.gPele.TabIndex = 13;
            this.gPele.TabStop = false;
            this.gPele.Text = "Diagnostico de Pele";
            // 
            // gSistemaAbdominal
            // 
            this.gSistemaAbdominal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gSistemaAbdominal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gSistemaAbdominal.Location = new System.Drawing.Point(3, 631);
            this.gSistemaAbdominal.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.gSistemaAbdominal.Name = "gSistemaAbdominal";
            this.gSistemaAbdominal.Size = new System.Drawing.Size(781, 79);
            this.gSistemaAbdominal.TabIndex = 15;
            this.gSistemaAbdominal.TabStop = false;
            this.gSistemaAbdominal.Text = "Diagnostico de Sistema Abdominal";
            // 
            // gSistemaUrinario
            // 
            this.gSistemaUrinario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gSistemaUrinario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gSistemaUrinario.Location = new System.Drawing.Point(3, 721);
            this.gSistemaUrinario.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.gSistemaUrinario.Name = "gSistemaUrinario";
            this.gSistemaUrinario.Size = new System.Drawing.Size(781, 79);
            this.gSistemaUrinario.TabIndex = 16;
            this.gSistemaUrinario.TabStop = false;
            this.gSistemaUrinario.Text = "Diagnostico de Sistema Urinário";
            // 
            // gLesaoCompressao
            // 
            this.gLesaoCompressao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gLesaoCompressao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gLesaoCompressao.Location = new System.Drawing.Point(3, 811);
            this.gLesaoCompressao.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.gLesaoCompressao.Name = "gLesaoCompressao";
            this.gLesaoCompressao.Size = new System.Drawing.Size(781, 79);
            this.gLesaoCompressao.TabIndex = 17;
            this.gLesaoCompressao.TabStop = false;
            this.gLesaoCompressao.Text = "Lesão por Compressão";
            // 
            // gPinard
            // 
            this.gPinard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gPinard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gPinard.Location = new System.Drawing.Point(3, 901);
            this.gPinard.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.gPinard.Name = "gPinard";
            this.gPinard.Size = new System.Drawing.Size(781, 79);
            this.gPinard.TabIndex = 18;
            this.gPinard.TabStop = false;
            this.gPinard.Text = "Globo de Segurança de Pinard ";
            // 
            // gGlasgow
            // 
            this.gGlasgow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gGlasgow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gGlasgow.Location = new System.Drawing.Point(3, 991);
            this.gGlasgow.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.gGlasgow.Name = "gGlasgow";
            this.gGlasgow.Size = new System.Drawing.Size(781, 79);
            this.gGlasgow.TabIndex = 19;
            this.gGlasgow.TabStop = false;
            this.gGlasgow.Text = "Escala de Coma de Glasgow";
            // 
            // gCateterSonda
            // 
            this.gCateterSonda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gCateterSonda.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gCateterSonda.Location = new System.Drawing.Point(3, 1081);
            this.gCateterSonda.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.gCateterSonda.Name = "gCateterSonda";
            this.gCateterSonda.Size = new System.Drawing.Size(781, 79);
            this.gCateterSonda.TabIndex = 20;
            this.gCateterSonda.TabStop = false;
            this.gCateterSonda.Text = "Controle de Cateres e Sondas";
            // 
            // gEscalaPressao
            // 
            this.gEscalaPressao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gEscalaPressao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gEscalaPressao.Location = new System.Drawing.Point(3, 1161);
            this.gEscalaPressao.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.gEscalaPressao.Name = "gEscalaPressao";
            this.gEscalaPressao.Size = new System.Drawing.Size(781, 79);
            this.gEscalaPressao.TabIndex = 21;
            this.gEscalaPressao.TabStop = false;
            this.gEscalaPressao.Text = "Escala de Pressão Arterial / Outros";
            // 
            // UCExameFisico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.Controls.Add(this.pBody);
            this.Controls.Add(this.gTipoEstruturaFisica);
            this.Name = "UCExameFisico";
            this.Size = new System.Drawing.Size(804, 550);
            this.Load += new System.EventHandler(this.UCExameFisico_Load);
            this.gTipoEstruturaFisica.ResumeLayout(false);
            this.pBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEstruturaFisica;
        private System.Windows.Forms.GroupBox gTipoEstruturaFisica;
        private System.Windows.Forms.Panel pBody;
        private System.Windows.Forms.GroupBox gSistemaGastroIntestinal;
        private System.Windows.Forms.GroupBox gSistemaOxigenacao;
        private System.Windows.Forms.GroupBox gRegulacaoTermica;
        private System.Windows.Forms.GroupBox gSistemaNeurologico;
        private System.Windows.Forms.GroupBox gPupilas;
        private System.Windows.Forms.GroupBox gPele;
        private System.Windows.Forms.GroupBox gSistemaVascular;
        private System.Windows.Forms.GroupBox gSistemaAbdominal;
        private System.Windows.Forms.GroupBox gSistemaUrinario;
        private System.Windows.Forms.GroupBox gLesaoCompressao;
        private System.Windows.Forms.GroupBox gPinard;
        private System.Windows.Forms.GroupBox gGlasgow;
        private System.Windows.Forms.GroupBox gCateterSonda;
        private System.Windows.Forms.GroupBox gEscalaPressao;
    }
}
