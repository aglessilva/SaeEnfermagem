namespace AppInternacao
{
    partial class FrmExibirHistorico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBoxExExibirHistorico = new RichTextBoxEx.RichTextBoxEx();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.richTextBoxExExibirHistorico.Size = new System.Drawing.Size(802, 527);
            this.richTextBoxExExibirHistorico.TabIndex = 0;
            this.richTextBoxExExibirHistorico.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.panel3.Controls.Add(this.button3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(802, 40);
            this.panel3.TabIndex = 27;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::AppInternacao.Properties.Resources.Delete_80_icon_icons_com_57340;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(763, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 37);
            this.button3.TabIndex = 3;
            this.button3.TabStop = false;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBoxExExibirHistorico);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 527);
            this.panel1.TabIndex = 28;
            // 
            // FrmExibirHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(802, 567);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmExibirHistorico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBoxEx.RichTextBoxEx richTextBoxExExibirHistorico;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
    }
}