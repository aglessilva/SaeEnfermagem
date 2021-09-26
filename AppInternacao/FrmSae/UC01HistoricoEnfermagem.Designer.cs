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

            //UCTimeLine.ButtonSaeAvanca.Click -= new EventHandler(ButtonSaeAvanca_Click);
        }

      

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
    private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.richTextBoxExHistoricoEnfermagem = new RichTextBoxEx.RichTextBoxEx();
            this.spelling1 = new NetSpell.SpellChecker.Spelling(this.components);
            this.wordDictionary1 = new NetSpell.SpellChecker.Dictionary.WordDictionary(this.components);
            this.btnTemplate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxExHistoricoEnfermagem
            // 
            this.richTextBoxExHistoricoEnfermagem.AllowBullets = false;
            this.richTextBoxExHistoricoEnfermagem.AllowDefaultInsertText = false;
            this.richTextBoxExHistoricoEnfermagem.AllowDefaultSmartText = true;
            this.richTextBoxExHistoricoEnfermagem.AllowHyphenation = false;
            this.richTextBoxExHistoricoEnfermagem.AllowPictures = false;
            this.richTextBoxExHistoricoEnfermagem.AllowSpellCheck = false;
            this.richTextBoxExHistoricoEnfermagem.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.richTextBoxExHistoricoEnfermagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxExHistoricoEnfermagem.FilePath = "";
            this.richTextBoxExHistoricoEnfermagem.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxExHistoricoEnfermagem.Name = "richTextBoxExHistoricoEnfermagem";
            this.richTextBoxExHistoricoEnfermagem.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\nouicompat\\deflang1046{\\fonttbl{\\f0\\fnil\\fcharset0 " +
    "Arial;}}\r\n{\\*\\generator Riched20 10.0.19041}\\viewkind4\\uc1 \r\n\\pard\\fs20\\par\r\n}\r\n" +
    "";
            this.richTextBoxExHistoricoEnfermagem.SetColorWithFont = true;
            this.richTextBoxExHistoricoEnfermagem.ShowToolStrip = true;
            this.richTextBoxExHistoricoEnfermagem.Size = new System.Drawing.Size(813, 474);
            this.richTextBoxExHistoricoEnfermagem.TabIndex = 0;
            this.richTextBoxExHistoricoEnfermagem.Load += new System.EventHandler(this.richTextBoxExHistoricoEnfermagem_Load);
            // 
            // spelling1
            // 
            this.spelling1.Dictionary = this.wordDictionary1;
            // 
            // wordDictionary1
            // 
            this.wordDictionary1.DictionaryFile = "pt-BR.dic";
            // 
            // btnTemplate
            // 
            this.btnTemplate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnTemplate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTemplate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemplate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTemplate.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnTemplate.FlatAppearance.BorderSize = 0;
            this.btnTemplate.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTemplate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btnTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemplate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTemplate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTemplate.Location = new System.Drawing.Point(0, 435);
            this.btnTemplate.Name = "btnTemplate";
            this.btnTemplate.Size = new System.Drawing.Size(813, 39);
            this.btnTemplate.TabIndex = 12;
            this.btnTemplate.TabStop = false;
            this.btnTemplate.Text = "Recuperar Template Original!";
            this.btnTemplate.UseVisualStyleBackColor = false;
            this.btnTemplate.Click += new System.EventHandler(this.btnTemplate_Click);
            // 
            // UC01HistoricoEnfermagem
            // 
            this.Controls.Add(this.btnTemplate);
            this.Controls.Add(this.richTextBoxExHistoricoEnfermagem);
            this.Name = "UC01HistoricoEnfermagem";
            this.Size = new System.Drawing.Size(813, 474);
            this.Load += new System.EventHandler(this.UCHistoricoEnfermagem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public RichTextBoxEx.RichTextBoxEx richTextBoxExHistoricoEnfermagem;
        private NetSpell.SpellChecker.Spelling spelling1;
        private NetSpell.SpellChecker.Dictionary.WordDictionary wordDictionary1;
        private System.Windows.Forms.Button btnTemplate;
    }
}
