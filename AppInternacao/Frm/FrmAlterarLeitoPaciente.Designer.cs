
namespace AppInternacao.Frm
{
    partial class FrmAlterarLeitoPaciente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel00title = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAssociarNovoLeito = new FontAwesome.Sharp.IconButton();
            this.btnCancelarFechar = new FontAwesome.Sharp.IconButton();
            this.dataGridViewLeito = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeLeito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimparCampo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel00title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeito)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel00title
            // 
            this.panel00title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.panel00title.Controls.Add(this.iconPictureBox1);
            this.panel00title.Controls.Add(this.label1);
            this.panel00title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel00title.Location = new System.Drawing.Point(0, 0);
            this.panel00title.Name = "panel00title";
            this.panel00title.Size = new System.Drawing.Size(344, 32);
            this.panel00title.TabIndex = 2;
            this.panel00title.TabStop = true;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Bed;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(312, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 6;
            this.iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Transferir paciente para outro leito";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.flowLayoutPanel1.Controls.Add(this.btnAssociarNovoLeito);
            this.flowLayoutPanel1.Controls.Add(this.btnCancelarFechar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 494);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(344, 39);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // btnAssociarNovoLeito
            // 
            this.btnAssociarNovoLeito.BackColor = System.Drawing.Color.Transparent;
            this.btnAssociarNovoLeito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAssociarNovoLeito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssociarNovoLeito.Enabled = false;
            this.btnAssociarNovoLeito.FlatAppearance.BorderSize = 0;
            this.btnAssociarNovoLeito.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAssociarNovoLeito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btnAssociarNovoLeito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssociarNovoLeito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAssociarNovoLeito.IconChar = FontAwesome.Sharp.IconChar.ExchangeAlt;
            this.btnAssociarNovoLeito.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.btnAssociarNovoLeito.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAssociarNovoLeito.IconSize = 32;
            this.btnAssociarNovoLeito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssociarNovoLeito.Location = new System.Drawing.Point(3, 3);
            this.btnAssociarNovoLeito.Name = "btnAssociarNovoLeito";
            this.btnAssociarNovoLeito.Size = new System.Drawing.Size(165, 33);
            this.btnAssociarNovoLeito.TabIndex = 102;
            this.btnAssociarNovoLeito.Text = "Associar para novo Leito";
            this.btnAssociarNovoLeito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAssociarNovoLeito.UseVisualStyleBackColor = false;
            this.btnAssociarNovoLeito.Click += new System.EventHandler(this.btnAssociarNovoLeito_Click);
            // 
            // btnCancelarFechar
            // 
            this.btnCancelarFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelarFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelarFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarFechar.FlatAppearance.BorderSize = 0;
            this.btnCancelarFechar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelarFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btnCancelarFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarFechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelarFechar.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.btnCancelarFechar.IconColor = System.Drawing.Color.Salmon;
            this.btnCancelarFechar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelarFechar.IconSize = 32;
            this.btnCancelarFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarFechar.Location = new System.Drawing.Point(174, 3);
            this.btnCancelarFechar.Name = "btnCancelarFechar";
            this.btnCancelarFechar.Size = new System.Drawing.Size(165, 33);
            this.btnCancelarFechar.TabIndex = 103;
            this.btnCancelarFechar.Text = "Cancelar Transferência ";
            this.btnCancelarFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarFechar.UseVisualStyleBackColor = false;
            this.btnCancelarFechar.Click += new System.EventHandler(this.btnCancelarFechar_Click);
            // 
            // dataGridViewLeito
            // 
            this.dataGridViewLeito.AllowUserToAddRows = false;
            this.dataGridViewLeito.AllowUserToDeleteRows = false;
            this.dataGridViewLeito.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dataGridViewLeito.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewLeito.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLeito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewLeito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLeito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NomeLeito});
            this.dataGridViewLeito.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLeito.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewLeito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLeito.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewLeito.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewLeito.Name = "dataGridViewLeito";
            this.dataGridViewLeito.ReadOnly = true;
            this.dataGridViewLeito.RowHeadersVisible = false;
            this.dataGridViewLeito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLeito.Size = new System.Drawing.Size(344, 411);
            this.dataGridViewLeito.TabIndex = 21;
            this.dataGridViewLeito.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLeito_CellClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 5;
            // 
            // NomeLeito
            // 
            this.NomeLeito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeLeito.DataPropertyName = "NomeLeito";
            this.NomeLeito.HeaderText = "Leitos disponiveis";
            this.NomeLeito.Name = "NomeLeito";
            this.NomeLeito.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnLimparCampo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.textBoxNome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 51);
            this.panel1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Pesquisa";
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
            this.btnLimparCampo.Location = new System.Drawing.Point(279, 18);
            this.btnLimparCampo.Name = "btnLimparCampo";
            this.btnLimparCampo.Size = new System.Drawing.Size(29, 24);
            this.btnLimparCampo.TabIndex = 23;
            this.btnLimparCampo.UseVisualStyleBackColor = false;
            this.btnLimparCampo.Click += new System.EventHandler(this.btnLimparCampo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Leito:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Location = new System.Drawing.Point(39, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(270, 1);
            this.panel4.TabIndex = 21;
            // 
            // textBoxNome
            // 
            this.textBoxNome.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxNome.Location = new System.Drawing.Point(41, 23);
            this.textBoxNome.MaxLength = 50;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(244, 19);
            this.textBoxNome.TabIndex = 20;
            this.textBoxNome.WordWrap = false;
            this.textBoxNome.TextChanged += new System.EventHandler(this.textBoxNome_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewLeito);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 411);
            this.panel2.TabIndex = 23;
            // 
            // FrmAlterarLeitoPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 533);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel00title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAlterarLeitoPaciente";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAlterarLeitoPaciente";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmAlterarLeitoPaciente_Load);
            this.panel00title.ResumeLayout(false);
            this.panel00title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeito)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel00title;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconButton btnAssociarNovoLeito;
        private FontAwesome.Sharp.IconButton btnCancelarFechar;
        private System.Windows.Forms.DataGridView dataGridViewLeito;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimparCampo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeLeito;
    }
}