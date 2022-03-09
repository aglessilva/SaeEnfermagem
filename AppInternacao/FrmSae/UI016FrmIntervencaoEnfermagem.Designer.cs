
namespace AppInternacao.FrmSae
{
    partial class UI016FrmIntervencaoEnfermagem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewClassificacao = new System.Windows.Forms.DataGridView();
            this.btnLimparCampo = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxClassificacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxIndicadores = new System.Windows.Forms.GroupBox();
            this.btnLimparIndicadores = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxIndicadores = new System.Windows.Forms.TextBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblDefinicao = new System.Windows.Forms.Label();
            this.comboBoxDiagnostico = new System.Windows.Forms.ComboBox();
            this.textBoxDescricaoIndicadores = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Checked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Classificacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewIndicadores = new System.Windows.Forms.DataGridView();
            this.CodigoIndicador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Indicador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClassificacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.groupBoxIndicadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIndicadores)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.dataGridViewClassificacao);
            this.groupBox1.Controls.Add(this.btnLimparCampo);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.textBoxClassificacao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.iconPictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 418);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dataGridViewClassificacao
            // 
            this.dataGridViewClassificacao.AllowUserToAddRows = false;
            this.dataGridViewClassificacao.AllowUserToDeleteRows = false;
            this.dataGridViewClassificacao.AllowUserToResizeColumns = false;
            this.dataGridViewClassificacao.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dataGridViewClassificacao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewClassificacao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewClassificacao.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewClassificacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewClassificacao.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewClassificacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClassificacao.ColumnHeadersVisible = false;
            this.dataGridViewClassificacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Checked,
            this.Classificacao});
            this.dataGridViewClassificacao.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridViewClassificacao.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewClassificacao.Location = new System.Drawing.Point(8, 76);
            this.dataGridViewClassificacao.MultiSelect = false;
            this.dataGridViewClassificacao.Name = "dataGridViewClassificacao";
            this.dataGridViewClassificacao.RowHeadersVisible = false;
            this.dataGridViewClassificacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClassificacao.Size = new System.Drawing.Size(472, 336);
            this.dataGridViewClassificacao.TabIndex = 58;
            this.dataGridViewClassificacao.TabStop = false;
            this.dataGridViewClassificacao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClassificacao_CellContentClick);
            // 
            // btnLimparCampo
            // 
            this.btnLimparCampo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimparCampo.BackColor = System.Drawing.Color.Transparent;
            this.btnLimparCampo.BackgroundImage = global::AppInternacao.Properties.Resources.Childish_Cross_24996;
            this.btnLimparCampo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimparCampo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparCampo.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnLimparCampo.FlatAppearance.BorderSize = 0;
            this.btnLimparCampo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimparCampo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnLimparCampo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparCampo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLimparCampo.Location = new System.Drawing.Point(448, 33);
            this.btnLimparCampo.Name = "btnLimparCampo";
            this.btnLimparCampo.Size = new System.Drawing.Size(29, 24);
            this.btnLimparCampo.TabIndex = 32;
            this.btnLimparCampo.UseVisualStyleBackColor = false;
            this.btnLimparCampo.Click += new System.EventHandler(this.btnLimparCampo_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Location = new System.Drawing.Point(8, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(470, 1);
            this.panel4.TabIndex = 30;
            // 
            // textBoxClassificacao
            // 
            this.textBoxClassificacao.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxClassificacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxClassificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxClassificacao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxClassificacao.Location = new System.Drawing.Point(37, 38);
            this.textBoxClassificacao.MaxLength = 50;
            this.textBoxClassificacao.Name = "textBoxClassificacao";
            this.textBoxClassificacao.Size = new System.Drawing.Size(407, 16);
            this.textBoxClassificacao.TabIndex = 29;
            this.textBoxClassificacao.WordWrap = false;
            this.textBoxClassificacao.TextChanged += new System.EventHandler(this.textBoxClassificacao_TextChanged);
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
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 27;
            this.iconPictureBox1.Location = new System.Drawing.Point(8, 33);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(27, 27);
            this.iconPictureBox1.TabIndex = 34;
            this.iconPictureBox1.TabStop = false;
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
            // groupBoxIndicadores
            // 
            this.groupBoxIndicadores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxIndicadores.Controls.Add(this.dataGridViewIndicadores);
            this.groupBoxIndicadores.Controls.Add(this.btnLimparIndicadores);
            this.groupBoxIndicadores.Controls.Add(this.panel1);
            this.groupBoxIndicadores.Controls.Add(this.textBoxIndicadores);
            this.groupBoxIndicadores.Controls.Add(this.iconPictureBox2);
            this.groupBoxIndicadores.Controls.Add(this.label1);
            this.groupBoxIndicadores.Location = new System.Drawing.Point(563, 86);
            this.groupBoxIndicadores.Name = "groupBoxIndicadores";
            this.groupBoxIndicadores.Size = new System.Drawing.Size(486, 418);
            this.groupBoxIndicadores.TabIndex = 29;
            this.groupBoxIndicadores.TabStop = false;
            // 
            // btnLimparIndicadores
            // 
            this.btnLimparIndicadores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimparIndicadores.BackColor = System.Drawing.Color.Transparent;
            this.btnLimparIndicadores.BackgroundImage = global::AppInternacao.Properties.Resources.Childish_Cross_24996;
            this.btnLimparIndicadores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimparIndicadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparIndicadores.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnLimparIndicadores.FlatAppearance.BorderSize = 0;
            this.btnLimparIndicadores.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimparIndicadores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnLimparIndicadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparIndicadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparIndicadores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLimparIndicadores.Location = new System.Drawing.Point(448, 33);
            this.btnLimparIndicadores.Name = "btnLimparIndicadores";
            this.btnLimparIndicadores.Size = new System.Drawing.Size(29, 24);
            this.btnLimparIndicadores.TabIndex = 37;
            this.btnLimparIndicadores.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(7, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 1);
            this.panel1.TabIndex = 36;
            // 
            // textBoxIndicadores
            // 
            this.textBoxIndicadores.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxIndicadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIndicadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxIndicadores.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxIndicadores.Location = new System.Drawing.Point(36, 38);
            this.textBoxIndicadores.MaxLength = 50;
            this.textBoxIndicadores.Name = "textBoxIndicadores";
            this.textBoxIndicadores.Size = new System.Drawing.Size(407, 16);
            this.textBoxIndicadores.TabIndex = 35;
            this.textBoxIndicadores.WordWrap = false;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox2.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 27;
            this.iconPictureBox2.Location = new System.Drawing.Point(7, 33);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(27, 27);
            this.iconPictureBox2.TabIndex = 38;
            this.iconPictureBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lblDefinicao);
            this.groupBox3.Controls.Add(this.comboBoxDiagnostico);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1037, 68);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Diagnósticos";
            // 
            // lblDefinicao
            // 
            this.lblDefinicao.AutoSize = true;
            this.lblDefinicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.lblDefinicao.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblDefinicao.Location = new System.Drawing.Point(5, 47);
            this.lblDefinicao.Name = "lblDefinicao";
            this.lblDefinicao.Size = new System.Drawing.Size(59, 15);
            this.lblDefinicao.TabIndex = 35;
            this.lblDefinicao.Text = "Definicao";
            this.lblDefinicao.Visible = false;
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
            // textBoxDescricaoIndicadores
            // 
            this.textBoxDescricaoIndicadores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescricaoIndicadores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDescricaoIndicadores.Location = new System.Drawing.Point(12, 531);
            this.textBoxDescricaoIndicadores.Multiline = true;
            this.textBoxDescricaoIndicadores.Name = "textBoxDescricaoIndicadores";
            this.textBoxDescricaoIndicadores.ReadOnly = true;
            this.textBoxDescricaoIndicadores.ShortcutsEnabled = false;
            this.textBoxDescricaoIndicadores.Size = new System.Drawing.Size(1037, 59);
            this.textBoxDescricaoIndicadores.TabIndex = 31;
            this.textBoxDescricaoIndicadores.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.label3.Location = new System.Drawing.Point(441, 508);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "Descrição dos Indicadores";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "";
            this.Codigo.Name = "Codigo";
            this.Codigo.Visible = false;
            // 
            // Checked
            // 
            this.Checked.DataPropertyName = "Checked";
            this.Checked.HeaderText = "";
            this.Checked.Name = "Checked";
            this.Checked.Width = 30;
            // 
            // Classificacao
            // 
            this.Classificacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Classificacao.DataPropertyName = "Classificacao";
            this.Classificacao.HeaderText = "";
            this.Classificacao.Name = "Classificacao";
            // 
            // dataGridViewIndicadores
            // 
            this.dataGridViewIndicadores.AllowUserToAddRows = false;
            this.dataGridViewIndicadores.AllowUserToDeleteRows = false;
            this.dataGridViewIndicadores.AllowUserToResizeColumns = false;
            this.dataGridViewIndicadores.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dataGridViewIndicadores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewIndicadores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewIndicadores.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewIndicadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewIndicadores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewIndicadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIndicadores.ColumnHeadersVisible = false;
            this.dataGridViewIndicadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoIndicador,
            this.dataGridViewCheckBoxColumn1,
            this.Indicador});
            this.dataGridViewIndicadores.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridViewIndicadores.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewIndicadores.Location = new System.Drawing.Point(8, 76);
            this.dataGridViewIndicadores.MultiSelect = false;
            this.dataGridViewIndicadores.Name = "dataGridViewIndicadores";
            this.dataGridViewIndicadores.RowHeadersVisible = false;
            this.dataGridViewIndicadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewIndicadores.Size = new System.Drawing.Size(472, 336);
            this.dataGridViewIndicadores.TabIndex = 59;
            this.dataGridViewIndicadores.TabStop = false;
            // 
            // CodigoIndicador
            // 
            this.CodigoIndicador.DataPropertyName = "Codigo";
            this.CodigoIndicador.HeaderText = "";
            this.CodigoIndicador.Name = "CodigoIndicador";
            this.CodigoIndicador.Visible = false;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Checked";
            this.dataGridViewCheckBoxColumn1.HeaderText = "";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 30;
            // 
            // Indicador
            // 
            this.Indicador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Indicador.DataPropertyName = "Indicador";
            this.Indicador.HeaderText = "";
            this.Indicador.Name = "Indicador";
            // 
            // UI016FrmIntervencaoEnfermagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1061, 593);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDescricaoIndicadores);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxIndicadores);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "UI016FrmIntervencaoEnfermagem";
            this.Tag = "4";
            this.Load += new System.EventHandler(this.UI016FrmIntervencaoEnfermagem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClassificacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.groupBoxIndicadores.ResumeLayout(false);
            this.groupBoxIndicadores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIndicadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxIndicadores;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxDiagnostico;
        private System.Windows.Forms.Button btnLimparCampo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxClassificacao;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Button btnLimparIndicadores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxIndicadores;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.TextBox textBoxDescricaoIndicadores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDefinicao;
        private System.Windows.Forms.DataGridView dataGridViewClassificacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Checked;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classificacao;
        private System.Windows.Forms.DataGridView dataGridViewIndicadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoIndicador;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indicador;
    }
}
