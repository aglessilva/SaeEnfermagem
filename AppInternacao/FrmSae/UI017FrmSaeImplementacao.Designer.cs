
namespace AppInternacao.FrmSae
{
    partial class UI017FrmSaeImplementacao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxDiagnostico = new System.Windows.Forms.ComboBox();
            this.groupBoxIndicadores = new System.Windows.Forms.GroupBox();
            this.dataGridViewIndicadores = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoIndicador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Indicador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusImgIndic = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxClassificacao = new System.Windows.Forms.GroupBox();
            this.dataGridViewClassificacao = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classificacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusImgClass = new System.Windows.Forms.DataGridViewImageColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxDescricaoIndicadores = new System.Windows.Forms.GroupBox();
            this.textBoxDescricaoIndicadores = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBoxIndicadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIndicadores)).BeginInit();
            this.groupBoxClassificacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClassificacao)).BeginInit();
            this.groupBoxDescricaoIndicadores.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.comboBoxDiagnostico);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1037, 55);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Diagnósticos";
            // 
            // comboBoxDiagnostico
            // 
            this.comboBoxDiagnostico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxDiagnostico.DisplayMember = "Diagnostico";
            this.comboBoxDiagnostico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDiagnostico.FormattingEnabled = true;
            this.comboBoxDiagnostico.Location = new System.Drawing.Point(6, 18);
            this.comboBoxDiagnostico.Name = "comboBoxDiagnostico";
            this.comboBoxDiagnostico.Size = new System.Drawing.Size(1025, 21);
            this.comboBoxDiagnostico.TabIndex = 0;
            this.comboBoxDiagnostico.ValueMember = "Codigo";
            this.comboBoxDiagnostico.SelectionChangeCommitted += new System.EventHandler(this.comboBoxDiagnostico_SelectionChangeCommitted);
            // 
            // groupBoxIndicadores
            // 
            this.groupBoxIndicadores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxIndicadores.Controls.Add(this.dataGridViewIndicadores);
            this.groupBoxIndicadores.Controls.Add(this.label1);
            this.groupBoxIndicadores.Location = new System.Drawing.Point(563, 86);
            this.groupBoxIndicadores.Name = "groupBoxIndicadores";
            this.groupBoxIndicadores.Size = new System.Drawing.Size(486, 410);
            this.groupBoxIndicadores.TabIndex = 32;
            this.groupBoxIndicadores.TabStop = false;
            this.groupBoxIndicadores.Visible = false;
            // 
            // dataGridViewIndicadores
            // 
            this.dataGridViewIndicadores.AllowUserToAddRows = false;
            this.dataGridViewIndicadores.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            this.dataGridViewIndicadores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewIndicadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewIndicadores.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewIndicadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewIndicadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIndicadores.ColumnHeadersVisible = false;
            this.dataGridViewIndicadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CodigoIndicador,
            this.Indicador,
            this.StatusImgIndic});
            this.dataGridViewIndicadores.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewIndicadores.Location = new System.Drawing.Point(8, 41);
            this.dataGridViewIndicadores.Name = "dataGridViewIndicadores";
            this.dataGridViewIndicadores.ReadOnly = true;
            this.dataGridViewIndicadores.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewIndicadores.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewIndicadores.RowTemplate.Height = 40;
            this.dataGridViewIndicadores.Size = new System.Drawing.Size(472, 363);
            this.dataGridViewIndicadores.TabIndex = 30;
            this.dataGridViewIndicadores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewIndicadores_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.Visible = false;
            // 
            // CodigoIndicador
            // 
            this.CodigoIndicador.DataPropertyName = "CodigoIndicador";
            this.CodigoIndicador.HeaderText = "";
            this.CodigoIndicador.Name = "CodigoIndicador";
            this.CodigoIndicador.ReadOnly = true;
            this.CodigoIndicador.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CodigoIndicador.Visible = false;
            // 
            // Indicador
            // 
            this.Indicador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Indicador.DataPropertyName = "Indicador";
            this.Indicador.HeaderText = "";
            this.Indicador.Name = "Indicador";
            this.Indicador.ReadOnly = true;
            // 
            // StatusImgIndic
            // 
            this.StatusImgIndic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.StatusImgIndic.DataPropertyName = "StatusImgIndic";
            this.StatusImgIndic.HeaderText = "";
            this.StatusImgIndic.Name = "StatusImgIndic";
            this.StatusImgIndic.ReadOnly = true;
            this.StatusImgIndic.Width = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.label1.Location = new System.Drawing.Point(184, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Indicadores";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBoxClassificacao
            // 
            this.groupBoxClassificacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxClassificacao.Controls.Add(this.dataGridViewClassificacao);
            this.groupBoxClassificacao.Controls.Add(this.label2);
            this.groupBoxClassificacao.Location = new System.Drawing.Point(12, 86);
            this.groupBoxClassificacao.Name = "groupBoxClassificacao";
            this.groupBoxClassificacao.Size = new System.Drawing.Size(486, 410);
            this.groupBoxClassificacao.TabIndex = 31;
            this.groupBoxClassificacao.TabStop = false;
            this.groupBoxClassificacao.Visible = false;
            // 
            // dataGridViewClassificacao
            // 
            this.dataGridViewClassificacao.AllowUserToAddRows = false;
            this.dataGridViewClassificacao.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            this.dataGridViewClassificacao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewClassificacao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewClassificacao.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewClassificacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewClassificacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClassificacao.ColumnHeadersVisible = false;
            this.dataGridViewClassificacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Classificacao,
            this.statusImgClass});
            this.dataGridViewClassificacao.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewClassificacao.Location = new System.Drawing.Point(7, 41);
            this.dataGridViewClassificacao.Name = "dataGridViewClassificacao";
            this.dataGridViewClassificacao.ReadOnly = true;
            this.dataGridViewClassificacao.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewClassificacao.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewClassificacao.RowTemplate.Height = 40;
            this.dataGridViewClassificacao.Size = new System.Drawing.Size(472, 363);
            this.dataGridViewClassificacao.TabIndex = 29;
            this.dataGridViewClassificacao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClassificacao_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            // 
            // Classificacao
            // 
            this.Classificacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Classificacao.DataPropertyName = "Classificacao";
            this.Classificacao.HeaderText = "";
            this.Classificacao.Name = "Classificacao";
            this.Classificacao.ReadOnly = true;
            // 
            // statusImgClass
            // 
            this.statusImgClass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.statusImgClass.DataPropertyName = "statusImgClass";
            this.statusImgClass.HeaderText = "";
            this.statusImgClass.Name = "statusImgClass";
            this.statusImgClass.ReadOnly = true;
            this.statusImgClass.Width = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.label2.Location = new System.Drawing.Point(190, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "Classificação";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBoxDescricaoIndicadores
            // 
            this.groupBoxDescricaoIndicadores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDescricaoIndicadores.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxDescricaoIndicadores.Controls.Add(this.textBoxDescricaoIndicadores);
            this.groupBoxDescricaoIndicadores.Location = new System.Drawing.Point(12, 507);
            this.groupBoxDescricaoIndicadores.Name = "groupBoxDescricaoIndicadores";
            this.groupBoxDescricaoIndicadores.Size = new System.Drawing.Size(1037, 79);
            this.groupBoxDescricaoIndicadores.TabIndex = 34;
            this.groupBoxDescricaoIndicadores.TabStop = false;
            this.groupBoxDescricaoIndicadores.Text = "Observação para implementação de indicadores";
            this.groupBoxDescricaoIndicadores.Visible = false;
            // 
            // textBoxDescricaoIndicadores
            // 
            this.textBoxDescricaoIndicadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescricaoIndicadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescricaoIndicadores.Location = new System.Drawing.Point(7, 19);
            this.textBoxDescricaoIndicadores.Multiline = true;
            this.textBoxDescricaoIndicadores.Name = "textBoxDescricaoIndicadores";
            this.textBoxDescricaoIndicadores.Size = new System.Drawing.Size(1024, 48);
            this.textBoxDescricaoIndicadores.TabIndex = 0;
            // 
            // UI017FrmSaeImplementacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1061, 593);
            this.Controls.Add(this.groupBoxDescricaoIndicadores);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxIndicadores);
            this.Controls.Add(this.groupBoxClassificacao);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "UI017FrmSaeImplementacao";
            this.Load += new System.EventHandler(this.UI017FrmSaeImplementacao_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBoxIndicadores.ResumeLayout(false);
            this.groupBoxIndicadores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIndicadores)).EndInit();
            this.groupBoxClassificacao.ResumeLayout(false);
            this.groupBoxClassificacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClassificacao)).EndInit();
            this.groupBoxDescricaoIndicadores.ResumeLayout(false);
            this.groupBoxDescricaoIndicadores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxDiagnostico;
        private System.Windows.Forms.GroupBox groupBoxIndicadores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxClassificacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewClassificacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classificacao;
        private System.Windows.Forms.DataGridViewImageColumn statusImgClass;
        private System.Windows.Forms.DataGridView dataGridViewIndicadores;
        private System.Windows.Forms.GroupBox groupBoxDescricaoIndicadores;
        private System.Windows.Forms.TextBox textBoxDescricaoIndicadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoIndicador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indicador;
        private System.Windows.Forms.DataGridViewImageColumn StatusImgIndic;
    }
}
