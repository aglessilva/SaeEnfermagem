namespace AppInternacao.FrmSae
{
    partial class UCMenuEsquerdo
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
            this.btnExibirHistorico = new System.Windows.Forms.Button();
            this.btnPrecricaoMedica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExibirHistorico
            // 
            this.btnExibirHistorico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnExibirHistorico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExibirHistorico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExibirHistorico.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExibirHistorico.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnExibirHistorico.FlatAppearance.BorderSize = 2;
            this.btnExibirHistorico.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExibirHistorico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btnExibirHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExibirHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnExibirHistorico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExibirHistorico.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExibirHistorico.Location = new System.Drawing.Point(0, 0);
            this.btnExibirHistorico.Name = "btnExibirHistorico";
            this.btnExibirHistorico.Size = new System.Drawing.Size(278, 30);
            this.btnExibirHistorico.TabIndex = 13;
            this.btnExibirHistorico.TabStop = false;
            this.btnExibirHistorico.Text = "Exibir Historico de Enfermagem";
            this.btnExibirHistorico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExibirHistorico.UseVisualStyleBackColor = false;
            this.btnExibirHistorico.Click += new System.EventHandler(this.btnExibirHistorico_Click);
            // 
            // btnPrecricaoMedica
            // 
            this.btnPrecricaoMedica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnPrecricaoMedica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrecricaoMedica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrecricaoMedica.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrecricaoMedica.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnPrecricaoMedica.FlatAppearance.BorderSize = 2;
            this.btnPrecricaoMedica.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrecricaoMedica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btnPrecricaoMedica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrecricaoMedica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnPrecricaoMedica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrecricaoMedica.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrecricaoMedica.Location = new System.Drawing.Point(0, 30);
            this.btnPrecricaoMedica.Name = "btnPrecricaoMedica";
            this.btnPrecricaoMedica.Size = new System.Drawing.Size(278, 30);
            this.btnPrecricaoMedica.TabIndex = 14;
            this.btnPrecricaoMedica.TabStop = false;
            this.btnPrecricaoMedica.Text = "Ciclo de Prescrição Médica";
            this.btnPrecricaoMedica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrecricaoMedica.UseVisualStyleBackColor = false;
            this.btnPrecricaoMedica.Click += new System.EventHandler(this.btnPrecricaoMedica_Click);
            // 
            // UCMenuEsquerdo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.btnPrecricaoMedica);
            this.Controls.Add(this.btnExibirHistorico);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCMenuEsquerdo";
            this.Size = new System.Drawing.Size(278, 381);
            this.Load += new System.EventHandler(this.UCMenuEsquerdo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExibirHistorico;
        private System.Windows.Forms.Button btnPrecricaoMedica;
    }
}
