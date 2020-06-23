using System;

namespace AppInternacao.FrmSae
{
    partial class UC01HistoricoEnfermagem
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

            UCTimeLine.ButtonSaeAvanca.Click -= new EventHandler(ButtonSaeAvanca_Click);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBoxExHistoricoEnfermagem = new RichTextBoxEx.RichTextBoxEx();
            this.SuspendLayout();
            // 
            // richTextBoxExHistoricoEnfermagem
            // 
            this.richTextBoxExHistoricoEnfermagem.AllowBullets = true;
            this.richTextBoxExHistoricoEnfermagem.AllowDefaultInsertText = true;
            this.richTextBoxExHistoricoEnfermagem.AllowDefaultSmartText = true;
            this.richTextBoxExHistoricoEnfermagem.AllowHyphenation = false;
            this.richTextBoxExHistoricoEnfermagem.AllowPictures = false;
            this.richTextBoxExHistoricoEnfermagem.AllowSpellCheck = false;
            this.richTextBoxExHistoricoEnfermagem.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.richTextBoxExHistoricoEnfermagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxExHistoricoEnfermagem.FilePath = "";
            this.richTextBoxExHistoricoEnfermagem.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxExHistoricoEnfermagem.Name = "richTextBoxExHistoricoEnfermagem";
            this.richTextBoxExHistoricoEnfermagem.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1046{\\fonttbl{\\f0\\fnil\\fcharset0 Arial;}}\r\n\\" +
    "viewkind4\\uc1\\pard\\fs20\\par\r\n}\r\n";
            this.richTextBoxExHistoricoEnfermagem.SetColorWithFont = true;
            this.richTextBoxExHistoricoEnfermagem.ShowToolStrip = true;
            this.richTextBoxExHistoricoEnfermagem.Size = new System.Drawing.Size(894, 552);
            this.richTextBoxExHistoricoEnfermagem.TabIndex = 1;
            // 
            // UC01HistoricoEnfermagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBoxExHistoricoEnfermagem);
            this.Name = "UC01HistoricoEnfermagem";
            this.Size = new System.Drawing.Size(894, 552);
            this.Load += new System.EventHandler(this.UCHistoricoEnfermagem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public RichTextBoxEx.RichTextBoxEx richTextBoxExHistoricoEnfermagem;
    }
}
