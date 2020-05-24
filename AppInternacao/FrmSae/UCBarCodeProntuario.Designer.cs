namespace AppInternacao.FrmSae
{
    partial class UCBarCodeProntuario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxProntuario = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gDadosPaciente = new System.Windows.Forms.GroupBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblProntuario = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pbOk = new System.Windows.Forms.PictureBox();
            this.lblNaoLocaizado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLeito = new System.Windows.Forms.Label();
            this.lblObs = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gDadosPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOk)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.panel1.Controls.Add(this.lblNaoLocaizado);
            this.panel1.Controls.Add(this.pbOk);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBoxProntuario);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(242, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 181);
            this.panel1.TabIndex = 0;
            // 
            // textBoxProntuario
            // 
            this.textBoxProntuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.textBoxProntuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProntuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProntuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxProntuario.Location = new System.Drawing.Point(79, 87);
            this.textBoxProntuario.MaxLength = 18;
            this.textBoxProntuario.Name = "textBoxProntuario";
            this.textBoxProntuario.Size = new System.Drawing.Size(248, 25);
            this.textBoxProntuario.TabIndex = 0;
            this.textBoxProntuario.TextChanged += new System.EventHandler(this.textBoxProntuario_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 40);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.panel3.Controls.Add(this.btnLimpar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(372, 39);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel4.Location = new System.Drawing.Point(40, 115);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(310, 1);
            this.panel4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(64, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe o código de barras do prontuário do paciente";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppInternacao.Properties.Resources.vector_scan_barcode_4_transparent;
            this.pictureBox1.Location = new System.Drawing.Point(16, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLimpar.Image = global::AppInternacao.Properties.Resources.Delete_80_icon_icons_com_57340;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(131, 5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(127, 29);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar campo";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::AppInternacao.Properties.Resources.tag_user_card_16777;
            this.pictureBox2.Location = new System.Drawing.Point(3, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // gDadosPaciente
            // 
            this.gDadosPaciente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gDadosPaciente.Controls.Add(this.lblLeito);
            this.gDadosPaciente.Controls.Add(this.lblIdade);
            this.gDadosPaciente.Controls.Add(this.lblProntuario);
            this.gDadosPaciente.Controls.Add(this.lblNome);
            this.gDadosPaciente.Controls.Add(this.label6);
            this.gDadosPaciente.Controls.Add(this.label2);
            this.gDadosPaciente.Controls.Add(this.label5);
            this.gDadosPaciente.Controls.Add(this.label4);
            this.gDadosPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gDadosPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gDadosPaciente.Location = new System.Drawing.Point(245, 371);
            this.gDadosPaciente.Name = "gDadosPaciente";
            this.gDadosPaciente.Size = new System.Drawing.Size(369, 129);
            this.gDadosPaciente.TabIndex = 1;
            this.gDadosPaciente.TabStop = false;
            this.gDadosPaciente.Text = "Paciente Localizado";
            this.gDadosPaciente.Visible = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(85, 26);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(13, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "-";
            // 
            // lblProntuario
            // 
            this.lblProntuario.AutoSize = true;
            this.lblProntuario.Location = new System.Drawing.Point(85, 76);
            this.lblProntuario.Name = "lblProntuario";
            this.lblProntuario.Size = new System.Drawing.Size(13, 16);
            this.lblProntuario.TabIndex = 2;
            this.lblProntuario.Text = "-";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(85, 101);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(13, 16);
            this.lblIdade.TabIndex = 3;
            this.lblIdade.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Idade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Prontuário:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nome:";
            // 
            // pbOk
            // 
            this.pbOk.Image = global::AppInternacao.Properties.Resources.ok_accept_15562;
            this.pbOk.Location = new System.Drawing.Point(330, 84);
            this.pbOk.Name = "pbOk";
            this.pbOk.Size = new System.Drawing.Size(28, 28);
            this.pbOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOk.TabIndex = 5;
            this.pbOk.TabStop = false;
            this.pbOk.Visible = false;
            // 
            // lblNaoLocaizado
            // 
            this.lblNaoLocaizado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNaoLocaizado.AutoSize = true;
            this.lblNaoLocaizado.BackColor = System.Drawing.Color.Gainsboro;
            this.lblNaoLocaizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaoLocaizado.ForeColor = System.Drawing.Color.Red;
            this.lblNaoLocaizado.Location = new System.Drawing.Point(37, 122);
            this.lblNaoLocaizado.Name = "lblNaoLocaizado";
            this.lblNaoLocaizado.Size = new System.Drawing.Size(12, 15);
            this.lblNaoLocaizado.TabIndex = 2;
            this.lblNaoLocaizado.Text = "-";
            this.lblNaoLocaizado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNaoLocaizado.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Leito:";
            // 
            // lblLeito
            // 
            this.lblLeito.AutoSize = true;
            this.lblLeito.Location = new System.Drawing.Point(85, 52);
            this.lblLeito.Name = "lblLeito";
            this.lblLeito.Size = new System.Drawing.Size(13, 16);
            this.lblLeito.TabIndex = 9;
            this.lblLeito.Text = "-";
            // 
            // lblObs
            // 
            this.lblObs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblObs.AutoSize = true;
            this.lblObs.ForeColor = System.Drawing.Color.Red;
            this.lblObs.Location = new System.Drawing.Point(242, 154);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(10, 13);
            this.lblObs.TabIndex = 2;
            this.lblObs.Text = "-";
            this.lblObs.Visible = false;
            // 
            // UCBarCodeProntuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.gDadosPaciente);
            this.Controls.Add(this.panel1);
            this.Name = "UCBarCodeProntuario";
            this.Size = new System.Drawing.Size(798, 553);
            this.Load += new System.EventHandler(this.UCBarCodeProntuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gDadosPaciente.ResumeLayout(false);
            this.gDadosPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxProntuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox gDadosPaciente;
        private System.Windows.Forms.Label lblProntuario;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.PictureBox pbOk;
        private System.Windows.Forms.Label lblNaoLocaizado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLeito;
        private System.Windows.Forms.Label lblObs;
    }
}
