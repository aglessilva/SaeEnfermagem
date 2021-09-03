
namespace AppInternacao.FrmSae
{
    partial class UI004FrmPanelOcupacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI004FrmPanelOcupacoes));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxPesquisaQuarto = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanelImgLeito = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.comboBoxPesquisaQuarto);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(849, 52);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pesquisa de Leitos por Quarto";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(811, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 20);
            this.button1.TabIndex = 13;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // comboBoxPesquisaQuarto
            // 
            this.comboBoxPesquisaQuarto.AutoCompleteCustomSource.AddRange(new string[] {
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
            this.comboBoxPesquisaQuarto.DisplayMember = "NomeQuarto";
            this.comboBoxPesquisaQuarto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPesquisaQuarto.FormattingEnabled = true;
            this.comboBoxPesquisaQuarto.Location = new System.Drawing.Point(6, 20);
            this.comboBoxPesquisaQuarto.MaxDropDownItems = 10;
            this.comboBoxPesquisaQuarto.Name = "comboBoxPesquisaQuarto";
            this.comboBoxPesquisaQuarto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxPesquisaQuarto.Size = new System.Drawing.Size(289, 21);
            this.comboBoxPesquisaQuarto.TabIndex = 12;
            this.comboBoxPesquisaQuarto.ValueMember = "Id";
            // 
            // flowLayoutPanelImgLeito
            // 
            this.flowLayoutPanelImgLeito.AutoScroll = true;
            this.flowLayoutPanelImgLeito.AutoSize = true;
            this.flowLayoutPanelImgLeito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanelImgLeito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelImgLeito.Location = new System.Drawing.Point(0, 52);
            this.flowLayoutPanelImgLeito.Name = "flowLayoutPanelImgLeito";
            this.flowLayoutPanelImgLeito.Size = new System.Drawing.Size(849, 503);
            this.flowLayoutPanelImgLeito.TabIndex = 16;
            // 
            // UI004FrmPanelOcupacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(849, 555);
            this.Controls.Add(this.flowLayoutPanelImgLeito);
            this.Controls.Add(this.groupBox4);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "UI004FrmPanelOcupacoes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UI004FrmPanelOcupacoes_FormClosing);
            this.Load += new System.EventHandler(this.UI004FrmPanelOcupacoes_Load);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBoxPesquisaQuarto;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelImgLeito;
        private System.Windows.Forms.Button button1;
    }
}
