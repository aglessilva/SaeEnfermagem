using System;

namespace AppInternacao.FrmSae
{
    partial class UCNomeTemplate
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

            FrmMain.mySalvar.Click -= new EventHandler(Salvar);
            FrmMain.myNovo.Click -= new EventHandler(Novo);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCNomeTemplate));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAviso = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxEstruturaFisica = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRotulo = new System.Windows.Forms.Label();
            this.textBoxNomeTemplate = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewNomeTemplate = new System.Windows.Forms.DataGridView();
            this.errorProviderNameTemplate = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstruturaFisica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.AddItem = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNomeTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNameTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAviso);
            this.groupBox1.Controls.Add(this.textBoxId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxEstruturaFisica);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.lblRotulo);
            this.groupBox1.Controls.Add(this.textBoxNomeTemplate);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 101);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criação de Templates de modelos para Exames Físico";
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(329, 77);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(472, 13);
            this.lblAviso.TabIndex = 29;
            this.lblAviso.Text = "Não é posivel alterar o tipo da estrutura, pois já exite EXAMES FISICOS associado" +
    " a esta estrutura.";
            this.lblAviso.Visible = false;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(317, 31);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(44, 20);
            this.textBoxId.TabIndex = 28;
            this.textBoxId.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Estrutura Física";
            // 
            // comboBoxEstruturaFisica
            // 
            this.comboBoxEstruturaFisica.DisplayMember = "Nome";
            this.comboBoxEstruturaFisica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstruturaFisica.FormattingEnabled = true;
            this.comboBoxEstruturaFisica.Location = new System.Drawing.Point(408, 50);
            this.comboBoxEstruturaFisica.Name = "comboBoxEstruturaFisica";
            this.comboBoxEstruturaFisica.Size = new System.Drawing.Size(211, 21);
            this.comboBoxEstruturaFisica.TabIndex = 26;
            this.comboBoxEstruturaFisica.ValueMember = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ex: Sae Adulto,  Sae Idoso, Sae Criança...etc";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(15, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 1);
            this.panel1.TabIndex = 23;
            // 
            // lblRotulo
            // 
            this.lblRotulo.AutoSize = true;
            this.lblRotulo.Location = new System.Drawing.Point(12, 23);
            this.lblRotulo.Name = "lblRotulo";
            this.lblRotulo.Size = new System.Drawing.Size(97, 13);
            this.lblRotulo.TabIndex = 22;
            this.lblRotulo.Text = "Nome do Template";
            // 
            // textBoxNomeTemplate
            // 
            this.textBoxNomeTemplate.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxNomeTemplate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNomeTemplate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNomeTemplate.Location = new System.Drawing.Point(46, 50);
            this.textBoxNomeTemplate.MaxLength = 50;
            this.textBoxNomeTemplate.Name = "textBoxNomeTemplate";
            this.textBoxNomeTemplate.Size = new System.Drawing.Size(246, 13);
            this.textBoxNomeTemplate.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppInternacao.Properties.Resources.tipotemplate;
            this.pictureBox1.Location = new System.Drawing.Point(12, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewNomeTemplate
            // 
            this.dataGridViewNomeTemplate.AllowUserToAddRows = false;
            this.dataGridViewNomeTemplate.AllowUserToDeleteRows = false;
            this.dataGridViewNomeTemplate.AllowUserToOrderColumns = true;
            this.dataGridViewNomeTemplate.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dataGridViewNomeTemplate.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewNomeTemplate.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewNomeTemplate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNomeTemplate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewNomeTemplate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNomeTemplate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.EstruturaFisica,
            this.Editar,
            this.AddItem});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewNomeTemplate.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewNomeTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNomeTemplate.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewNomeTemplate.Location = new System.Drawing.Point(0, 101);
            this.dataGridViewNomeTemplate.Name = "dataGridViewNomeTemplate";
            this.dataGridViewNomeTemplate.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNomeTemplate.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewNomeTemplate.RowHeadersVisible = false;
            this.dataGridViewNomeTemplate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNomeTemplate.Size = new System.Drawing.Size(757, 420);
            this.dataGridViewNomeTemplate.TabIndex = 9;
            this.dataGridViewNomeTemplate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNomeTemplate_CellContentClick);
            // 
            // errorProviderNameTemplate
            // 
            this.errorProviderNameTemplate.ContainerControl = this;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.ToolTipText = "Editar informações";
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::AppInternacao.Properties.Resources.add;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.ToolTipText = "Adicionar Itens de exame físico ao template";
            this.dataGridViewImageColumn2.Width = 30;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome do Template";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // EstruturaFisica
            // 
            this.EstruturaFisica.DataPropertyName = "EstruturaFisica";
            this.EstruturaFisica.HeaderText = "Estrutura Fisica";
            this.EstruturaFisica.Name = "EstruturaFisica";
            this.EstruturaFisica.ReadOnly = true;
            this.EstruturaFisica.Width = 250;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Editar.ToolTipText = "Editar informações";
            this.Editar.Width = 30;
            // 
            // AddItem
            // 
            this.AddItem.HeaderText = "";
            this.AddItem.Image = global::AppInternacao.Properties.Resources.addPlus;
            this.AddItem.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.AddItem.Name = "AddItem";
            this.AddItem.ReadOnly = true;
            this.AddItem.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AddItem.ToolTipText = "Adicionar Itens de exame físico ao template";
            this.AddItem.Width = 30;
            // 
            // UCNomeTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.dataGridViewNomeTemplate);
            this.Controls.Add(this.groupBox1);
            this.Name = "UCNomeTemplate";
            this.Size = new System.Drawing.Size(757, 521);
            this.Load += new System.EventHandler(this.UCNomeTemplate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNomeTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNameTemplate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxEstruturaFisica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRotulo;
        private System.Windows.Forms.TextBox textBoxNomeTemplate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewNomeTemplate;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.ErrorProvider errorProviderNameTemplate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstruturaFisica;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn AddItem;
    }
}
