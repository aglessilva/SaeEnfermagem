
namespace AppInternacao.FrmSae
{
    partial class UI011FrmTimeLine
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
            this.pTopButtons = new System.Windows.Forms.Panel();
            this.panelTitleFromSAE = new System.Windows.Forms.Panel();
            this.lblNameStepSae = new System.Windows.Forms.Label();
            this.BtnAvancar = new FontAwesome.Sharp.IconButton();
            this.btnVoltar = new FontAwesome.Sharp.IconButton();
            this.pFrmBody = new System.Windows.Forms.Panel();
            this.pTopButtons.SuspendLayout();
            this.panelTitleFromSAE.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTopButtons
            // 
            this.pTopButtons.BackColor = System.Drawing.Color.Silver;
            this.pTopButtons.Controls.Add(this.panelTitleFromSAE);
            this.pTopButtons.Controls.Add(this.BtnAvancar);
            this.pTopButtons.Controls.Add(this.btnVoltar);
            this.pTopButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTopButtons.Location = new System.Drawing.Point(0, 0);
            this.pTopButtons.Name = "pTopButtons";
            this.pTopButtons.Size = new System.Drawing.Size(849, 60);
            this.pTopButtons.TabIndex = 0;
            // 
            // panelTitleFromSAE
            // 
            this.panelTitleFromSAE.BackColor = System.Drawing.Color.Silver;
            this.panelTitleFromSAE.Controls.Add(this.lblNameStepSae);
            this.panelTitleFromSAE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitleFromSAE.Location = new System.Drawing.Point(140, 0);
            this.panelTitleFromSAE.Name = "panelTitleFromSAE";
            this.panelTitleFromSAE.Size = new System.Drawing.Size(569, 60);
            this.panelTitleFromSAE.TabIndex = 2;
            // 
            // lblNameStepSae
            // 
            this.lblNameStepSae.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNameStepSae.BackColor = System.Drawing.Color.Silver;
            this.lblNameStepSae.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblNameStepSae.ForeColor = System.Drawing.Color.Navy;
            this.lblNameStepSae.Location = new System.Drawing.Point(6, 16);
            this.lblNameStepSae.Name = "lblNameStepSae";
            this.lblNameStepSae.Size = new System.Drawing.Size(557, 24);
            this.lblNameStepSae.TabIndex = 1;
            this.lblNameStepSae.Text = "Nome de cada passo do SAE";
            this.lblNameStepSae.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnAvancar
            // 
            this.BtnAvancar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAvancar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnAvancar.FlatAppearance.BorderSize = 0;
            this.BtnAvancar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.BtnAvancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAvancar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAvancar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.BtnAvancar.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            this.BtnAvancar.IconColor = System.Drawing.Color.SteelBlue;
            this.BtnAvancar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAvancar.IconSize = 40;
            this.BtnAvancar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAvancar.Location = new System.Drawing.Point(709, 0);
            this.BtnAvancar.Name = "BtnAvancar";
            this.BtnAvancar.Size = new System.Drawing.Size(140, 60);
            this.BtnAvancar.TabIndex = 1;
            this.BtnAvancar.Tag = "1";
            this.BtnAvancar.Text = "AVANÇAR";
            this.BtnAvancar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAvancar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnVoltar.Enabled = false;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btnVoltar.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            this.btnVoltar.IconColor = System.Drawing.Color.SteelBlue;
            this.btnVoltar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVoltar.IconSize = 40;
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(0, 0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(140, 60);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Tag = "0";
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // pFrmBody
            // 
            this.pFrmBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pFrmBody.Location = new System.Drawing.Point(0, 60);
            this.pFrmBody.Name = "pFrmBody";
            this.pFrmBody.Size = new System.Drawing.Size(849, 495);
            this.pFrmBody.TabIndex = 1;
            // 
            // UI011FrmTimeLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(849, 555);
            this.Controls.Add(this.pFrmBody);
            this.Controls.Add(this.pTopButtons);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "UI011FrmTimeLine";
            this.Load += new System.EventHandler(this.UI011FrmTimeLine_Load);
            this.pTopButtons.ResumeLayout(false);
            this.panelTitleFromSAE.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pTopButtons;
        private FontAwesome.Sharp.IconButton BtnAvancar;
        private FontAwesome.Sharp.IconButton btnVoltar;
        private System.Windows.Forms.Label lblNameStepSae;
        private System.Windows.Forms.Panel pFrmBody;
        private System.Windows.Forms.Panel panelTitleFromSAE;
    }
}
