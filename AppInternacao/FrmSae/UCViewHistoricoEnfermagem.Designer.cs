namespace AppInternacao.FrmSae
{
    partial class UCViewHistoricoEnfermagem
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
            this.richTextBoxExExibirHistorico = new RichTextBoxEx.RichTextBoxEx();
            this.SuspendLayout();
            // 
            // richTextBoxExExibirHistorico
            // 
            this.richTextBoxExExibirHistorico.AllowBullets = false;
            this.richTextBoxExExibirHistorico.AllowDefaultInsertText = false;
            this.richTextBoxExExibirHistorico.AllowDefaultSmartText = false;
            this.richTextBoxExExibirHistorico.AllowHyphenation = false;
            this.richTextBoxExExibirHistorico.AllowPictures = false;
            this.richTextBoxExExibirHistorico.AllowSpellCheck = false;
            this.richTextBoxExExibirHistorico.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.richTextBoxExExibirHistorico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxExExibirHistorico.FilePath = "";
            this.richTextBoxExExibirHistorico.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxExExibirHistorico.Name = "richTextBoxExExibirHistorico";
            this.richTextBoxExExibirHistorico.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1046{\\fonttbl{\\f0\\fnil\\fcharset0 Arial;}}\r\n\\" +
    "viewkind4\\uc1\\pard\\fs20\\par\r\n}\r\n";
            this.richTextBoxExExibirHistorico.SetColorWithFont = false;
            this.richTextBoxExExibirHistorico.ShowToolStrip = false;
            this.richTextBoxExExibirHistorico.Size = new System.Drawing.Size(845, 559);
            this.richTextBoxExExibirHistorico.TabIndex = 1;
            this.richTextBoxExExibirHistorico.TabStop = false;
            this.richTextBoxExExibirHistorico.Load += new System.EventHandler(this.richTextBoxExExibirHistorico_Load);
            // 
            // UCViewHistoricoEnfermagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBoxExExibirHistorico);
            this.Name = "UCViewHistoricoEnfermagem";
            this.Size = new System.Drawing.Size(845, 559);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBoxEx.RichTextBoxEx richTextBoxExExibirHistorico;
    }
}
