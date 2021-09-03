
namespace AppInternacao.FrmSae
{
    partial class UI004FrmPanelQuarto
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI004FrmPanelQuarto));
            this.dataGridViewQuartos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDSETOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeQuarto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalLeito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.textBoxPesquisaQuarto = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.comboBoxSetor = new System.Windows.Forms.ComboBox();
            this.textBoxNomeQuarto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxQtdLeitos = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuartos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewQuartos
            // 
            this.dataGridViewQuartos.AllowUserToAddRows = false;
            this.dataGridViewQuartos.AllowUserToDeleteRows = false;
            this.dataGridViewQuartos.AllowUserToOrderColumns = true;
            this.dataGridViewQuartos.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dataGridViewQuartos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewQuartos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewQuartos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewQuartos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewQuartos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuartos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.IDSETOR,
            this.NomeQuarto,
            this.TotalLeito,
            this.Editar,
            this.Excluir});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewQuartos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewQuartos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewQuartos.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewQuartos.Location = new System.Drawing.Point(0, 125);
            this.dataGridViewQuartos.Name = "dataGridViewQuartos";
            this.dataGridViewQuartos.ReadOnly = true;
            this.dataGridViewQuartos.RowHeadersVisible = false;
            this.dataGridViewQuartos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewQuartos.Size = new System.Drawing.Size(849, 430);
            this.dataGridViewQuartos.TabIndex = 15;
            this.dataGridViewQuartos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewQuartos_CellContentClick);
            this.dataGridViewQuartos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewQuartos_DataBindingComplete);
            this.dataGridViewQuartos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewQuartos_RowEnter);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // IDSETOR
            // 
            this.IDSETOR.HeaderText = "Setor";
            this.IDSETOR.Name = "IDSETOR";
            this.IDSETOR.ReadOnly = true;
            this.IDSETOR.Visible = false;
            // 
            // NomeQuarto
            // 
            this.NomeQuarto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeQuarto.DataPropertyName = "NomeQuarto";
            this.NomeQuarto.HeaderText = "Quarto";
            this.NomeQuarto.Name = "NomeQuarto";
            this.NomeQuarto.ReadOnly = true;
            // 
            // TotalLeito
            // 
            this.TotalLeito.DataPropertyName = "TotalLeito";
            this.TotalLeito.HeaderText = "Qtd";
            this.TotalLeito.Name = "TotalLeito";
            this.TotalLeito.ReadOnly = true;
            this.TotalLeito.ToolTipText = "Toal de Leitos por quarto";
            this.TotalLeito.Width = 30;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.ToolTipText = "Editar informações";
            this.Editar.Width = 30;
            // 
            // Excluir
            // 
            this.Excluir.HeaderText = "";
            this.Excluir.Image = global::AppInternacao.Properties.Resources.Delete_80_icon_icons_com_57340;
            this.Excluir.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            this.Excluir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Excluir.ToolTipText = "Remover quarto";
            this.Excluir.Width = 30;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel8);
            this.groupBox2.Controls.Add(this.buttonLimpar);
            this.groupBox2.Controls.Add(this.textBoxPesquisaQuarto);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(849, 55);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisa de Quartos";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DimGray;
            this.panel8.Location = new System.Drawing.Point(8, 40);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(283, 1);
            this.panel8.TabIndex = 20;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.BackColor = System.Drawing.Color.Transparent;
            this.buttonLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLimpar.BackgroundImage")));
            this.buttonLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonLimpar.FlatAppearance.BorderSize = 0;
            this.buttonLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.buttonLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLimpar.Location = new System.Drawing.Point(262, 21);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(26, 20);
            this.buttonLimpar.TabIndex = 9;
            this.buttonLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLimpar.UseVisualStyleBackColor = false;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // textBoxPesquisaQuarto
            // 
            this.textBoxPesquisaQuarto.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxPesquisaQuarto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPesquisaQuarto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxPesquisaQuarto.Location = new System.Drawing.Point(39, 25);
            this.textBoxPesquisaQuarto.Name = "textBoxPesquisaQuarto";
            this.textBoxPesquisaQuarto.Size = new System.Drawing.Size(217, 13);
            this.textBoxPesquisaQuarto.TabIndex = 3;
            this.textBoxPesquisaQuarto.TextChanged += new System.EventHandler(this.textBoxPesquisaQuarto_TextChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(6, 16);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Controls.Add(this.textBoxId);
            this.groupBox1.Controls.Add(this.comboBoxSetor);
            this.groupBox1.Controls.Add(this.textBoxNomeQuarto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbltitulo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxQtdLeitos);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(849, 70);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Quartos";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DimGray;
            this.panel7.Location = new System.Drawing.Point(8, 60);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(283, 1);
            this.panel7.TabIndex = 19;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(729, 13);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(28, 20);
            this.textBoxId.TabIndex = 18;
            this.textBoxId.Visible = false;
            // 
            // comboBoxSetor
            // 
            this.comboBoxSetor.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxSetor.DisplayMember = "NomeSetor";
            this.comboBoxSetor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSetor.FormattingEnabled = true;
            this.comboBoxSetor.Location = new System.Drawing.Point(531, 39);
            this.comboBoxSetor.MaxDropDownItems = 10;
            this.comboBoxSetor.Name = "comboBoxSetor";
            this.comboBoxSetor.Size = new System.Drawing.Size(226, 21);
            this.comboBoxSetor.TabIndex = 2;
            this.comboBoxSetor.ValueMember = "Id";
            this.comboBoxSetor.SelectedIndexChanged += new System.EventHandler(this.comboBoxSetor_SelectedIndexChanged);
            // 
            // textBoxNomeQuarto
            // 
            this.textBoxNomeQuarto.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxNomeQuarto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNomeQuarto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNomeQuarto.Location = new System.Drawing.Point(39, 46);
            this.textBoxNomeQuarto.MaxLength = 20;
            this.textBoxNomeQuarto.Name = "textBoxNomeQuarto";
            this.textBoxNomeQuarto.Size = new System.Drawing.Size(249, 13);
            this.textBoxNomeQuarto.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tipo do quarto";
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Location = new System.Drawing.Point(6, 19);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(85, 13);
            this.lbltitulo.TabIndex = 13;
            this.lbltitulo.Text = "Nome do Quarto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Quantidade de Leitos";
            // 
            // comboBoxQtdLeitos
            // 
            this.comboBoxQtdLeitos.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxQtdLeitos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQtdLeitos.FormattingEnabled = true;
            this.comboBoxQtdLeitos.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxQtdLeitos.Location = new System.Drawing.Point(313, 40);
            this.comboBoxQtdLeitos.MaxDropDownItems = 10;
            this.comboBoxQtdLeitos.Name = "comboBoxQtdLeitos";
            this.comboBoxQtdLeitos.Size = new System.Drawing.Size(128, 21);
            this.comboBoxQtdLeitos.TabIndex = 1;
            this.comboBoxQtdLeitos.SelectedIndexChanged += new System.EventHandler(this.comboBoxQtdLeitos_SelectedIndexChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AppInternacao.Properties.Resources.home_01;
            this.pictureBox3.Location = new System.Drawing.Point(5, 38);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UI004PanelQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(849, 555);
            this.Controls.Add(this.dataGridViewQuartos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "UI004PanelQuarto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UI004PanelQuarto_FormClosing);
            this.Load += new System.EventHandler(this.UI004PanelQuarto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuartos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewQuartos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSETOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeQuarto;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalLeito;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Excluir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.TextBox textBoxPesquisaQuarto;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.ComboBox comboBoxSetor;
        private System.Windows.Forms.TextBox textBoxNomeQuarto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxQtdLeitos;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
