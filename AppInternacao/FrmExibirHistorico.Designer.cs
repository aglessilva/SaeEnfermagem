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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
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
            this.richTextBoxExExibirHistorico.Size = new System.Drawing.Size(802, 531);
            this.richTextBoxExExibirHistorico.TabIndex = 0;
            this.richTextBoxExExibirHistorico.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 567);
            this.panel1.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::AppInternacao.Properties.Resources.backgroudMenu001;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 36);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::AppInternacao.Properties.Resources.Delete_80_icon_icons_com_57340;
            this.pictureBox1.Location = new System.Drawing.Point(768, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 36);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.richTextBoxExExibirHistorico);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(802, 531);
            this.panel3.TabIndex = 2;
            // 
            // FrmExibirHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(802, 567);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmExibirHistorico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBoxEx.RichTextBoxEx richTextBoxExExibirHistorico;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
    }
}