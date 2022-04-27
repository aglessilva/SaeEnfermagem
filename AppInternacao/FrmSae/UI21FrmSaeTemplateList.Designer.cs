
namespace AppInternacao.FrmSae
{
    partial class UI21FrmSaeTemplateList
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxCheckBox = new System.Windows.Forms.GroupBox();
            this.comboBoxTemplateExameFisico = new System.Windows.Forms.ComboBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.checkBoxExt1 = new AppInternacao.Extend.CheckBoxExt();
            this.checkBoxExt2 = new AppInternacao.Extend.CheckBoxExt();
            this.checkBoxExt3 = new AppInternacao.Extend.CheckBoxExt();
            this.checkBoxExt4 = new AppInternacao.Extend.CheckBoxExt();
            this.checkBoxExt5 = new AppInternacao.Extend.CheckBoxExt();
            this.groupBox1.SuspendLayout();
            this.groupBoxCheckBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblDescricao);
            this.groupBox1.Controls.Add(this.comboBoxTemplateExameFisico);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(825, 85);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Template de Exames fisicos ";
            // 
            // groupBoxCheckBox
            // 
            this.groupBoxCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCheckBox.Controls.Add(this.checkBoxExt5);
            this.groupBoxCheckBox.Controls.Add(this.checkBoxExt4);
            this.groupBoxCheckBox.Controls.Add(this.checkBoxExt3);
            this.groupBoxCheckBox.Controls.Add(this.checkBoxExt2);
            this.groupBoxCheckBox.Controls.Add(this.checkBoxExt1);
            this.groupBoxCheckBox.Location = new System.Drawing.Point(12, 115);
            this.groupBoxCheckBox.Name = "groupBoxCheckBox";
            this.groupBoxCheckBox.Size = new System.Drawing.Size(825, 74);
            this.groupBoxCheckBox.TabIndex = 2;
            this.groupBoxCheckBox.TabStop = false;
            this.groupBoxCheckBox.Text = "Setores  no qual o template selecionado está associados";
            // 
            // comboBoxTemplateExameFisico
            // 
            this.comboBoxTemplateExameFisico.DisplayMember = "NomeTemplate";
            this.comboBoxTemplateExameFisico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTemplateExameFisico.FormattingEnabled = true;
            this.comboBoxTemplateExameFisico.Location = new System.Drawing.Point(19, 23);
            this.comboBoxTemplateExameFisico.Name = "comboBoxTemplateExameFisico";
            this.comboBoxTemplateExameFisico.Size = new System.Drawing.Size(770, 21);
            this.comboBoxTemplateExameFisico.TabIndex = 0;
            this.comboBoxTemplateExameFisico.ValueMember = "Id";
            this.comboBoxTemplateExameFisico.SelectionChangeCommitted += new System.EventHandler(this.comboBoxTemplateExameFisico_SelectionChangeCommitted);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(16, 56);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(35, 13);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "label1";
            this.lblDescricao.Visible = false;
            // 
            // checkBoxExt1
            // 
            this.checkBoxExt1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxExt1.AutoSize = true;
            this.checkBoxExt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxExt1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.checkBoxExt1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkBoxExt1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.checkBoxExt1.Location = new System.Drawing.Point(19, 37);
            this.checkBoxExt1.Name = "checkBoxExt1";
            this.checkBoxExt1.Size = new System.Drawing.Size(95, 17);
            this.checkBoxExt1.TabIndex = 0;
            this.checkBoxExt1.Text = "Clinica Médica";
            this.checkBoxExt1.UseVisualStyleBackColor = true;
            this.checkBoxExt1.Value = "1";
            // 
            // checkBoxExt2
            // 
            this.checkBoxExt2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxExt2.AutoSize = true;
            this.checkBoxExt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxExt2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.checkBoxExt2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkBoxExt2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.checkBoxExt2.Location = new System.Drawing.Point(484, 37);
            this.checkBoxExt2.Name = "checkBoxExt2";
            this.checkBoxExt2.Size = new System.Drawing.Size(108, 17);
            this.checkBoxExt2.TabIndex = 1;
            this.checkBoxExt2.Text = "Clinica Obstétrica";
            this.checkBoxExt2.UseVisualStyleBackColor = true;
            this.checkBoxExt2.Value = "4";
            // 
            // checkBoxExt3
            // 
            this.checkBoxExt3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxExt3.AutoSize = true;
            this.checkBoxExt3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxExt3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.checkBoxExt3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkBoxExt3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.checkBoxExt3.Location = new System.Drawing.Point(328, 37);
            this.checkBoxExt3.Name = "checkBoxExt3";
            this.checkBoxExt3.Size = new System.Drawing.Size(101, 17);
            this.checkBoxExt3.TabIndex = 2;
            this.checkBoxExt3.Text = "Clinica Cirurgica";
            this.checkBoxExt3.UseVisualStyleBackColor = true;
            this.checkBoxExt3.Value = "3";
            // 
            // checkBoxExt4
            // 
            this.checkBoxExt4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxExt4.AutoSize = true;
            this.checkBoxExt4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxExt4.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.checkBoxExt4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkBoxExt4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.checkBoxExt4.Location = new System.Drawing.Point(659, 37);
            this.checkBoxExt4.Name = "checkBoxExt4";
            this.checkBoxExt4.Size = new System.Drawing.Size(130, 17);
            this.checkBoxExt4.TabIndex = 3;
            this.checkBoxExt4.Text = "Urgência/Emergencia";
            this.checkBoxExt4.UseVisualStyleBackColor = true;
            this.checkBoxExt4.Value = "5";
            // 
            // checkBoxExt5
            // 
            this.checkBoxExt5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxExt5.AutoSize = true;
            this.checkBoxExt5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxExt5.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.checkBoxExt5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkBoxExt5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.checkBoxExt5.Location = new System.Drawing.Point(167, 37);
            this.checkBoxExt5.Name = "checkBoxExt5";
            this.checkBoxExt5.Size = new System.Drawing.Size(107, 17);
            this.checkBoxExt5.TabIndex = 4;
            this.checkBoxExt5.Text = "Clinica Pediátrica";
            this.checkBoxExt5.UseVisualStyleBackColor = true;
            this.checkBoxExt5.Value = "2";
            // 
            // UI21FrmSaeTemplateList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(849, 555);
            this.Controls.Add(this.groupBoxCheckBox);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "UI21FrmSaeTemplateList";
            this.Load += new System.EventHandler(this.UI21FrmSaeTemplateList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxCheckBox.ResumeLayout(false);
            this.groupBoxCheckBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.ComboBox comboBoxTemplateExameFisico;
        private System.Windows.Forms.GroupBox groupBoxCheckBox;
        private Extend.CheckBoxExt checkBoxExt5;
        private Extend.CheckBoxExt checkBoxExt4;
        private Extend.CheckBoxExt checkBoxExt3;
        private Extend.CheckBoxExt checkBoxExt2;
        private Extend.CheckBoxExt checkBoxExt1;
    }
}
