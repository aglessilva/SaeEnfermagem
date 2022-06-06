namespace AppInternacao.Frm
{
    partial class FrmJustificarChecagem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel00title = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelItemData = new System.Windows.Forms.Panel();
            this.textBoxItem = new System.Windows.Forms.TextBox();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dataGridViewJustificativa = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnotacaoItemPrescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Justificativa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObervacaoDevolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxJustificativa = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblCaracteres = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel00title.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelItemData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJustificativa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel00title
            // 
            this.panel00title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.panel00title.Controls.Add(this.iconPictureBox1);
            this.panel00title.Controls.Add(this.lblTitle);
            this.panel00title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel00title.Location = new System.Drawing.Point(0, 0);
            this.panel00title.Name = "panel00title";
            this.panel00title.Size = new System.Drawing.Size(463, 32);
            this.panel00title.TabIndex = 2;
            this.panel00title.TabStop = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(3, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(310, 20);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Justificativa de checagem de prescrição";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panelItemData);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.dataGridViewJustificativa);
            this.panel1.Controls.Add(this.textBoxJustificativa);
            this.panel1.Controls.Add(this.btnConfirmar);
            this.panel1.Controls.Add(this.lblCaracteres);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 516);
            this.panel1.TabIndex = 3;
            // 
            // panelItemData
            // 
            this.panelItemData.Controls.Add(this.textBoxItem);
            this.panelItemData.Controls.Add(this.textBoxData);
            this.panelItemData.Controls.Add(this.lblData);
            this.panelItemData.Controls.Add(this.label1);
            this.panelItemData.Controls.Add(this.panel3);
            this.panelItemData.Controls.Add(this.panel2);
            this.panelItemData.Location = new System.Drawing.Point(162, 72);
            this.panelItemData.Name = "panelItemData";
            this.panelItemData.Size = new System.Drawing.Size(153, 25);
            this.panelItemData.TabIndex = 67;
            this.panelItemData.Visible = false;
            // 
            // textBoxItem
            // 
            this.textBoxItem.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.textBoxItem.Location = new System.Drawing.Point(30, 8);
            this.textBoxItem.MaxLength = 2;
            this.textBoxItem.Name = "textBoxItem";
            this.textBoxItem.ReadOnly = true;
            this.textBoxItem.Size = new System.Drawing.Size(35, 11);
            this.textBoxItem.TabIndex = 61;
            this.textBoxItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxData
            // 
            this.textBoxData.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxData.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.textBoxData.Location = new System.Drawing.Point(94, 8);
            this.textBoxData.MaxLength = 2;
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.ReadOnly = true;
            this.textBoxData.Size = new System.Drawing.Size(59, 11);
            this.textBoxData.TabIndex = 64;
            this.textBoxData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.lblData.Location = new System.Drawing.Point(66, 9);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 65;
            this.lblData.Text = "Data:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Item:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(30, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(35, 1);
            this.panel3.TabIndex = 63;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(96, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(55, 1);
            this.panel2.TabIndex = 66;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(14, 110);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(115, 30);
            this.btnLimpar.TabIndex = 60;
            this.btnLimpar.TabStop = false;
            this.btnLimpar.Text = "Nova mensagem";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dataGridViewJustificativa
            // 
            this.dataGridViewJustificativa.AllowUserToAddRows = false;
            this.dataGridViewJustificativa.AllowUserToDeleteRows = false;
            this.dataGridViewJustificativa.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dataGridViewJustificativa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewJustificativa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewJustificativa.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewJustificativa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewJustificativa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewJustificativa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJustificativa.ColumnHeadersVisible = false;
            this.dataGridViewJustificativa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ItemData,
            this.Nome,
            this.AnotacaoItemPrescricao,
            this.Justificativa,
            this.ObervacaoDevolucao});
            this.dataGridViewJustificativa.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewJustificativa.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewJustificativa.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewJustificativa.Location = new System.Drawing.Point(14, 150);
            this.dataGridViewJustificativa.Name = "dataGridViewJustificativa";
            this.dataGridViewJustificativa.ReadOnly = true;
            this.dataGridViewJustificativa.RowHeadersVisible = false;
            this.dataGridViewJustificativa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewJustificativa.Size = new System.Drawing.Size(436, 353);
            this.dataGridViewJustificativa.TabIndex = 59;
            this.dataGridViewJustificativa.TabStop = false;
            this.dataGridViewJustificativa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewJustificativa_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.Visible = false;
            // 
            // ItemData
            // 
            this.ItemData.DataPropertyName = "ItemData";
            this.ItemData.HeaderText = "ItemData";
            this.ItemData.Name = "ItemData";
            this.ItemData.ReadOnly = true;
            this.ItemData.Visible = false;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // AnotacaoItemPrescricao
            // 
            this.AnotacaoItemPrescricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AnotacaoItemPrescricao.DataPropertyName = "AnotacaoItemPrescricao";
            this.AnotacaoItemPrescricao.HeaderText = "AnotacaoItemPrescricao";
            this.AnotacaoItemPrescricao.Name = "AnotacaoItemPrescricao";
            this.AnotacaoItemPrescricao.ReadOnly = true;
            this.AnotacaoItemPrescricao.Visible = false;
            // 
            // Justificativa
            // 
            this.Justificativa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Justificativa.DataPropertyName = "Justificativa";
            this.Justificativa.HeaderText = "Justificativa";
            this.Justificativa.Name = "Justificativa";
            this.Justificativa.ReadOnly = true;
            this.Justificativa.Visible = false;
            // 
            // ObervacaoDevolucao
            // 
            this.ObervacaoDevolucao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ObervacaoDevolucao.DataPropertyName = "ObervacaoDevolucao";
            this.ObervacaoDevolucao.HeaderText = "ObervacaoDevolucao";
            this.ObervacaoDevolucao.Name = "ObervacaoDevolucao";
            this.ObervacaoDevolucao.ReadOnly = true;
            this.ObervacaoDevolucao.Visible = false;
            // 
            // textBoxJustificativa
            // 
            this.textBoxJustificativa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxJustificativa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxJustificativa.Location = new System.Drawing.Point(14, 7);
            this.textBoxJustificativa.Multiline = true;
            this.textBoxJustificativa.Name = "textBoxJustificativa";
            this.textBoxJustificativa.ReadOnly = true;
            this.textBoxJustificativa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxJustificativa.Size = new System.Drawing.Size(436, 65);
            this.textBoxJustificativa.TabIndex = 58;
            this.textBoxJustificativa.Text = "Clique no botão \'Nova mensagem\', para notificar a alteração desta precrição";
            this.textBoxJustificativa.TextChanged += new System.EventHandler(this.textBoxJustificativa_TextChanged);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(335, 110);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(115, 30);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.TabStop = false;
            this.btnConfirmar.Text = "Reenviar Prescrição";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblCaracteres
            // 
            this.lblCaracteres.AutoSize = true;
            this.lblCaracteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.lblCaracteres.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCaracteres.Location = new System.Drawing.Point(11, 79);
            this.lblCaracteres.Name = "lblCaracteres";
            this.lblCaracteres.Size = new System.Drawing.Size(121, 13);
            this.lblCaracteres.TabIndex = 57;
            this.lblCaracteres.Text = "Minimo de 50 caracteres";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(178, 110);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 30);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "Voltar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Chartreuse;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Chartreuse;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 28;
            this.iconPictureBox1.Location = new System.Drawing.Point(430, 2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(28, 28);
            this.iconPictureBox1.TabIndex = 5;
            this.iconPictureBox1.TabStop = false;
            // 
            // FrmJustificarChecagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(463, 548);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel00title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmJustificarChecagem";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmJustificarChecagem";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmJustificarChecagem_Load);
            this.panel00title.ResumeLayout(false);
            this.panel00title.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelItemData.ResumeLayout(false);
            this.panelItemData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJustificativa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel00title;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblCaracteres;
        private System.Windows.Forms.TextBox textBoxJustificativa;
        private System.Windows.Forms.DataGridView dataGridViewJustificativa;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.TextBox textBoxItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnotacaoItemPrescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Justificativa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObervacaoDevolucao;
        private System.Windows.Forms.Panel panelItemData;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}