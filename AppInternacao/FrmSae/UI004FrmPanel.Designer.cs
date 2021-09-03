
namespace AppInternacao.FrmSae
{
    partial class UI004FrmPanel
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
            this.flowLayoutPanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnInternacao = new FontAwesome.Sharp.IconButton();
            this.btnLeitos = new FontAwesome.Sharp.IconButton();
            this.btnQuartos = new FontAwesome.Sharp.IconButton();
            this.panelForms = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.flowLayoutPanelMenu.SuspendLayout();
            this.panelForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelMenu
            // 
            this.flowLayoutPanelMenu.Controls.Add(this.btnInternacao);
            this.flowLayoutPanelMenu.Controls.Add(this.btnLeitos);
            this.flowLayoutPanelMenu.Controls.Add(this.btnQuartos);
            this.flowLayoutPanelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelMenu.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelMenu.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelMenu.Name = "flowLayoutPanelMenu";
            this.flowLayoutPanelMenu.Size = new System.Drawing.Size(849, 39);
            this.flowLayoutPanelMenu.TabIndex = 1;
            // 
            // btnInternacao
            // 
            this.btnInternacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInternacao.FlatAppearance.BorderSize = 0;
            this.btnInternacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInternacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInternacao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInternacao.IconChar = FontAwesome.Sharp.IconChar.Bed;
            this.btnInternacao.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.btnInternacao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInternacao.IconSize = 32;
            this.btnInternacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInternacao.Location = new System.Drawing.Point(722, 3);
            this.btnInternacao.Name = "btnInternacao";
            this.btnInternacao.Size = new System.Drawing.Size(124, 34);
            this.btnInternacao.TabIndex = 2;
            this.btnInternacao.TabStop = false;
            this.btnInternacao.Text = "Internações";
            this.btnInternacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInternacao.UseVisualStyleBackColor = true;
            this.btnInternacao.Click += new System.EventHandler(this.btnInternacao_Click);
            // 
            // btnLeitos
            // 
            this.btnLeitos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeitos.FlatAppearance.BorderSize = 0;
            this.btnLeitos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeitos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeitos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLeitos.IconChar = FontAwesome.Sharp.IconChar.Inbox;
            this.btnLeitos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.btnLeitos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLeitos.IconSize = 32;
            this.btnLeitos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLeitos.Location = new System.Drawing.Point(614, 3);
            this.btnLeitos.Name = "btnLeitos";
            this.btnLeitos.Size = new System.Drawing.Size(102, 34);
            this.btnLeitos.TabIndex = 1;
            this.btnLeitos.TabStop = false;
            this.btnLeitos.Text = "Leitos";
            this.btnLeitos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLeitos.UseVisualStyleBackColor = true;
            this.btnLeitos.Click += new System.EventHandler(this.btnLeitos_Click);
            // 
            // btnQuartos
            // 
            this.btnQuartos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuartos.FlatAppearance.BorderSize = 0;
            this.btnQuartos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuartos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuartos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnQuartos.IconChar = FontAwesome.Sharp.IconChar.ClinicMedical;
            this.btnQuartos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.btnQuartos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQuartos.IconSize = 32;
            this.btnQuartos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuartos.Location = new System.Drawing.Point(495, 3);
            this.btnQuartos.Name = "btnQuartos";
            this.btnQuartos.Size = new System.Drawing.Size(113, 34);
            this.btnQuartos.TabIndex = 0;
            this.btnQuartos.TabStop = false;
            this.btnQuartos.Text = "Quartos";
            this.btnQuartos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuartos.UseVisualStyleBackColor = true;
            this.btnQuartos.Click += new System.EventHandler(this.btnQuartos_Click);
            // 
            // panelForms
            // 
            this.panelForms.CausesValidation = false;
            this.panelForms.Controls.Add(this.iconPictureBox1);
            this.panelForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForms.Location = new System.Drawing.Point(0, 39);
            this.panelForms.Name = "panelForms";
            this.panelForms.Size = new System.Drawing.Size(849, 516);
            this.panelForms.TabIndex = 2;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CreativeCommonsSamplingPlus;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.InactiveCaption;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 405;
            this.iconPictureBox1.Location = new System.Drawing.Point(116, 40);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(600, 405);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // UI004FrmPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(849, 555);
            this.Controls.Add(this.panelForms);
            this.Controls.Add(this.flowLayoutPanelMenu);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "UI004FrmPanel";
            this.Load += new System.EventHandler(this.UI004FrmPanel_Load);
            this.flowLayoutPanelMenu.ResumeLayout(false);
            this.panelForms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnQuartos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenu;
        private FontAwesome.Sharp.IconButton btnLeitos;
        private FontAwesome.Sharp.IconButton btnInternacao;
        private System.Windows.Forms.Panel panelForms;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}
