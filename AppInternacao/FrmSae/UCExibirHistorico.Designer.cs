namespace AppInternacao.FrmSae
{
    partial class UCExibirHistorico
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
            this.SuspendLayout();
            // 
            // btnExibirHistorico
            // 
            this.btnExibirHistorico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnExibirHistorico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExibirHistorico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExibirHistorico.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExibirHistorico.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnExibirHistorico.FlatAppearance.BorderSize = 0;
            this.btnExibirHistorico.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExibirHistorico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btnExibirHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExibirHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirHistorico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExibirHistorico.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExibirHistorico.Location = new System.Drawing.Point(0, 344);
            this.btnExibirHistorico.Name = "btnExibirHistorico";
            this.btnExibirHistorico.Size = new System.Drawing.Size(278, 37);
            this.btnExibirHistorico.TabIndex = 13;
            this.btnExibirHistorico.TabStop = false;
            this.btnExibirHistorico.Text = "Exibir Historico de Enfermagem";
            this.btnExibirHistorico.UseVisualStyleBackColor = false;
            this.btnExibirHistorico.Click += new System.EventHandler(this.btnExibirHistorico_Click);
            // 
            // UCExibirHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExibirHistorico);
            this.Name = "UCExibirHistorico";
            this.Size = new System.Drawing.Size(278, 381);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExibirHistorico;
    }
}
