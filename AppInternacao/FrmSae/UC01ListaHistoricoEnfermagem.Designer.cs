namespace AppInternacao.FrmSae
{
    partial class UC01ListaHistoricoEnfermagem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewHistoricoEnfermagem = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataHistorico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VisualizarHistorico = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistoricoEnfermagem)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHistoricoEnfermagem
            // 
            this.dataGridViewHistoricoEnfermagem.AllowUserToAddRows = false;
            this.dataGridViewHistoricoEnfermagem.AllowUserToDeleteRows = false;
            this.dataGridViewHistoricoEnfermagem.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dataGridViewHistoricoEnfermagem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewHistoricoEnfermagem.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewHistoricoEnfermagem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewHistoricoEnfermagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistoricoEnfermagem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DataHistorico,
            this.VisualizarHistorico});
            this.dataGridViewHistoricoEnfermagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewHistoricoEnfermagem.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewHistoricoEnfermagem.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewHistoricoEnfermagem.Name = "dataGridViewHistoricoEnfermagem";
            this.dataGridViewHistoricoEnfermagem.ReadOnly = true;
            this.dataGridViewHistoricoEnfermagem.RowHeadersVisible = false;
            this.dataGridViewHistoricoEnfermagem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHistoricoEnfermagem.Size = new System.Drawing.Size(284, 524);
            this.dataGridViewHistoricoEnfermagem.TabIndex = 0;
            this.dataGridViewHistoricoEnfermagem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHistoricoEnfermagem_CellContentClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::AppInternacao.Properties.Resources.file_search_114412;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.ToolTipText = "Visualizar";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // DataHistorico
            // 
            this.DataHistorico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataHistorico.DataPropertyName = "DataHistorico";
            this.DataHistorico.HeaderText = "Data Histórico";
            this.DataHistorico.Name = "DataHistorico";
            this.DataHistorico.ReadOnly = true;
            // 
            // VisualizarHistorico
            // 
            this.VisualizarHistorico.HeaderText = "";
            this.VisualizarHistorico.Image = global::AppInternacao.Properties.Resources.file_search_114412;
            this.VisualizarHistorico.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.VisualizarHistorico.Name = "VisualizarHistorico";
            this.VisualizarHistorico.ReadOnly = true;
            this.VisualizarHistorico.ToolTipText = "Visualizar";
            this.VisualizarHistorico.Width = 30;
            // 
            // UC01ListaHistoricoEnfermagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewHistoricoEnfermagem);
            this.Name = "UC01ListaHistoricoEnfermagem";
            this.Size = new System.Drawing.Size(284, 524);
            this.Load += new System.EventHandler(this.UC01ListaHistoricoEnfermagem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistoricoEnfermagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHistoricoEnfermagem;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataHistorico;
        private System.Windows.Forms.DataGridViewImageColumn VisualizarHistorico;
    }
}
