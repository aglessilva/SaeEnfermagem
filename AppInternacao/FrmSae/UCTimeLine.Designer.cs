namespace AppInternacao.FrmSae
{
    partial class UCTimeLine
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
            this.components = new System.ComponentModel.Container();
            this.timerStepSae = new System.Windows.Forms.Timer(this.components);
            this.pBaseTimeline = new System.Windows.Forms.Panel();
            this.timerStepBack = new System.Windows.Forms.Timer(this.components);
            this.pFrmSae = new System.Windows.Forms.Panel();
            this.btnStepVoltar = new System.Windows.Forms.Button();
            this.btnStep = new System.Windows.Forms.Button();
            this.pStep = new System.Windows.Forms.Panel();
            this.pByStep = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pBaseTimeline.SuspendLayout();
            this.pStep.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerStepSae
            // 
            this.timerStepSae.Interval = 20;
            this.timerStepSae.Tick += new System.EventHandler(this.timerStepSae_Tick);
            // 
            // pBaseTimeline
            // 
            this.pBaseTimeline.BackColor = System.Drawing.Color.Silver;
            this.pBaseTimeline.Controls.Add(this.btnStepVoltar);
            this.pBaseTimeline.Controls.Add(this.btnStep);
            this.pBaseTimeline.Controls.Add(this.pStep);
            this.pBaseTimeline.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBaseTimeline.Location = new System.Drawing.Point(0, 0);
            this.pBaseTimeline.Name = "pBaseTimeline";
            this.pBaseTimeline.Size = new System.Drawing.Size(891, 72);
            this.pBaseTimeline.TabIndex = 6;
            // 
            // timerStepBack
            // 
            this.timerStepBack.Interval = 20;
            this.timerStepBack.Tick += new System.EventHandler(this.timerStepBack_Tick);
            // 
            // pFrmSae
            // 
            this.pFrmSae.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pFrmSae.Location = new System.Drawing.Point(0, 72);
            this.pFrmSae.Name = "pFrmSae";
            this.pFrmSae.Size = new System.Drawing.Size(891, 438);
            this.pFrmSae.TabIndex = 7;
            // 
            // btnStepVoltar
            // 
            this.btnStepVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnStepVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStepVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStepVoltar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStepVoltar.Enabled = false;
            this.btnStepVoltar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnStepVoltar.FlatAppearance.BorderSize = 0;
            this.btnStepVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStepVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnStepVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStepVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStepVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btnStepVoltar.Image = global::AppInternacao.Properties.Resources.back4_89388;
            this.btnStepVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStepVoltar.Location = new System.Drawing.Point(0, 0);
            this.btnStepVoltar.Name = "btnStepVoltar";
            this.btnStepVoltar.Size = new System.Drawing.Size(107, 72);
            this.btnStepVoltar.TabIndex = 7;
            this.btnStepVoltar.Text = "VOLTAR";
            this.btnStepVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStepVoltar.UseVisualStyleBackColor = false;
            this.btnStepVoltar.Click += new System.EventHandler(this.btnStepVoltar_Click);
            // 
            // btnStep
            // 
            this.btnStep.BackColor = System.Drawing.Color.Transparent;
            this.btnStep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStep.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnStep.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnStep.FlatAppearance.BorderSize = 0;
            this.btnStep.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btnStep.Image = global::AppInternacao.Properties.Resources.next6_89384;
            this.btnStep.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStep.Location = new System.Drawing.Point(777, 0);
            this.btnStep.Name = "btnStep";
            this.btnStep.Size = new System.Drawing.Size(114, 72);
            this.btnStep.TabIndex = 6;
            this.btnStep.Text = "AVANÇAR";
            this.btnStep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStep.UseVisualStyleBackColor = false;
            this.btnStep.Click += new System.EventHandler(this.btnStep_Click);
            // 
            // pStep
            // 
            this.pStep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pStep.BackColor = System.Drawing.Color.Transparent;
            this.pStep.BackgroundImage = global::AppInternacao.Properties.Resources.Cabecalho02;
            this.pStep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pStep.Controls.Add(this.lblTitulo);
            this.pStep.Controls.Add(this.pByStep);
            this.pStep.Location = new System.Drawing.Point(219, 5);
            this.pStep.Name = "pStep";
            this.pStep.Size = new System.Drawing.Size(485, 63);
            this.pStep.TabIndex = 5;
            // 
            // pByStep
            // 
            this.pByStep.BackColor = System.Drawing.Color.Transparent;
            this.pByStep.BackgroundImage = global::AppInternacao.Properties.Resources.infoflat_105980;
            this.pByStep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pByStep.Location = new System.Drawing.Point(9, 20);
            this.pByStep.Name = "pByStep";
            this.pByStep.Size = new System.Drawing.Size(22, 22);
            this.pByStep.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(179, 48);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(11, 13);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "-";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Visible = false;
            // 
            // UCTimeLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.pFrmSae);
            this.Controls.Add(this.pBaseTimeline);
            this.Name = "UCTimeLine";
            this.Size = new System.Drawing.Size(891, 510);
            this.Load += new System.EventHandler(this.UCTimeLine_Load);
            this.pBaseTimeline.ResumeLayout(false);
            this.pStep.ResumeLayout(false);
            this.pStep.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pStep;
        private System.Windows.Forms.Panel pByStep;
        private System.Windows.Forms.Button btnStep;
        private System.Windows.Forms.Timer timerStepSae;
        private System.Windows.Forms.Panel pBaseTimeline;
        private System.Windows.Forms.Button btnStepVoltar;
        private System.Windows.Forms.Timer timerStepBack;
        public  System.Windows.Forms.Panel pFrmSae;
        private System.Windows.Forms.Label lblTitulo;
    }
}
