namespace AppInternacao.FrmSae
{
    partial class UCPrescricaoCiclo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewPrescricoes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CalendarCicloPrescricao = new System.Windows.Forms.MonthCalendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCicloPrescricao = new System.Windows.Forms.Label();
            this.gDadosPaciente = new System.Windows.Forms.GroupBox();
            this.lblLeito = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblProntuario = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddCiclo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddDia = new System.Windows.Forms.Button();
            this.btnNewLine = new System.Windows.Forms.Button();
            this.btnRemoveDia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrescricoes)).BeginInit();
            this.panel1.SuspendLayout();
            this.gDadosPaciente.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPrescricoes
            // 
            this.dataGridViewPrescricoes.AllowUserToAddRows = false;
            this.dataGridViewPrescricoes.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(232)))), ((int)(((byte)(239)))));
            this.dataGridViewPrescricoes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPrescricoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrescricoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPrescricoes.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewPrescricoes.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPrescricoes.Name = "dataGridViewPrescricoes";
            this.dataGridViewPrescricoes.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewPrescricoes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewPrescricoes.RowTemplate.Height = 40;
            this.dataGridViewPrescricoes.Size = new System.Drawing.Size(773, 350);
            this.dataGridViewPrescricoes.TabIndex = 17;
            this.dataGridViewPrescricoes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPrescricoes_CellContentClick);
            this.dataGridViewPrescricoes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPrescricoes_CellContentDoubleClick);
            this.dataGridViewPrescricoes.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPrescricoes_CellEndEdit);
            this.dataGridViewPrescricoes.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewPrescricoes_DataError);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Periodo para Pescrição";
            // 
            // CalendarCicloPrescricao
            // 
            this.CalendarCicloPrescricao.BackColor = System.Drawing.SystemColors.Window;
            this.CalendarCicloPrescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalendarCicloPrescricao.Location = new System.Drawing.Point(9, 21);
            this.CalendarCicloPrescricao.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.CalendarCicloPrescricao.MaxSelectionCount = 30;
            this.CalendarCicloPrescricao.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.CalendarCicloPrescricao.Name = "CalendarCicloPrescricao";
            this.CalendarCicloPrescricao.TabIndex = 14;
            this.CalendarCicloPrescricao.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.CalendarCicloPrescricao_DateSelected);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCicloPrescricao);
            this.panel1.Controls.Add(this.gDadosPaciente);
            this.panel1.Controls.Add(this.btnAddCiclo);
            this.panel1.Controls.Add(this.btnAddDia);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CalendarCicloPrescricao);
            this.panel1.Controls.Add(this.btnNewLine);
            this.panel1.Controls.Add(this.btnRemoveDia);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 198);
            this.panel1.TabIndex = 23;
            // 
            // lblCicloPrescricao
            // 
            this.lblCicloPrescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCicloPrescricao.AutoSize = true;
            this.lblCicloPrescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCicloPrescricao.ForeColor = System.Drawing.Color.Navy;
            this.lblCicloPrescricao.Location = new System.Drawing.Point(407, 160);
            this.lblCicloPrescricao.Name = "lblCicloPrescricao";
            this.lblCicloPrescricao.Size = new System.Drawing.Size(13, 16);
            this.lblCicloPrescricao.TabIndex = 49;
            this.lblCicloPrescricao.Text = "-";
            this.lblCicloPrescricao.Visible = false;
            // 
            // gDadosPaciente
            // 
            this.gDadosPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gDadosPaciente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gDadosPaciente.Controls.Add(this.lblLeito);
            this.gDadosPaciente.Controls.Add(this.lblIdade);
            this.gDadosPaciente.Controls.Add(this.lblProntuario);
            this.gDadosPaciente.Controls.Add(this.lblNome);
            this.gDadosPaciente.Controls.Add(this.label6);
            this.gDadosPaciente.Controls.Add(this.label2);
            this.gDadosPaciente.Controls.Add(this.label5);
            this.gDadosPaciente.Controls.Add(this.label4);
            this.gDadosPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gDadosPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.gDadosPaciente.Location = new System.Drawing.Point(248, 15);
            this.gDadosPaciente.Name = "gDadosPaciente";
            this.gDadosPaciente.Size = new System.Drawing.Size(513, 125);
            this.gDadosPaciente.TabIndex = 48;
            this.gDadosPaciente.TabStop = false;
            this.gDadosPaciente.Text = "Paciente Prescrito";
            // 
            // lblLeito
            // 
            this.lblLeito.AutoSize = true;
            this.lblLeito.Location = new System.Drawing.Point(75, 47);
            this.lblLeito.Name = "lblLeito";
            this.lblLeito.Size = new System.Drawing.Size(12, 16);
            this.lblLeito.TabIndex = 9;
            this.lblLeito.Text = "-";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(75, 96);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(12, 16);
            this.lblIdade.TabIndex = 3;
            this.lblIdade.Text = "-";
            // 
            // lblProntuario
            // 
            this.lblProntuario.AutoSize = true;
            this.lblProntuario.Location = new System.Drawing.Point(75, 71);
            this.lblProntuario.Name = "lblProntuario";
            this.lblProntuario.Size = new System.Drawing.Size(12, 16);
            this.lblProntuario.TabIndex = 2;
            this.lblProntuario.Text = "-";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(75, 21);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(12, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Leito:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Prontuário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Idade:";
            // 
            // btnAddCiclo
            // 
            this.btnAddCiclo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnAddCiclo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddCiclo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCiclo.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAddCiclo.FlatAppearance.BorderSize = 0;
            this.btnAddCiclo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddCiclo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.btnAddCiclo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCiclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnAddCiclo.ForeColor = System.Drawing.Color.White;
            this.btnAddCiclo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCiclo.Location = new System.Drawing.Point(248, 151);
            this.btnAddCiclo.Name = "btnAddCiclo";
            this.btnAddCiclo.Size = new System.Drawing.Size(146, 30);
            this.btnAddCiclo.TabIndex = 46;
            this.btnAddCiclo.TabStop = false;
            this.btnAddCiclo.Text = "Promover Ciclo";
            this.btnAddCiclo.UseVisualStyleBackColor = false;
            this.btnAddCiclo.Visible = false;
            this.btnAddCiclo.Click += new System.EventHandler(this.btnAddCiclo_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.dataGridViewPrescricoes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 198);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(773, 350);
            this.panel2.TabIndex = 24;
            // 
            // btnAddDia
            // 
            this.btnAddDia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddDia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddDia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDia.Enabled = false;
            this.btnAddDia.FlatAppearance.BorderSize = 0;
            this.btnAddDia.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnAddDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDia.Image = global::AppInternacao.Properties.Resources.Add_40971;
            this.btnAddDia.Location = new System.Drawing.Point(677, 146);
            this.btnAddDia.Name = "btnAddDia";
            this.btnAddDia.Size = new System.Drawing.Size(39, 39);
            this.btnAddDia.TabIndex = 19;
            this.btnAddDia.UseVisualStyleBackColor = true;
            this.btnAddDia.Click += new System.EventHandler(this.btnAddDia_Click);
            // 
            // btnNewLine
            // 
            this.btnNewLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewLine.Enabled = false;
            this.btnNewLine.FlatAppearance.BorderSize = 0;
            this.btnNewLine.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnNewLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewLine.Image = global::AppInternacao.Properties.Resources.addItem;
            this.btnNewLine.Location = new System.Drawing.Point(632, 146);
            this.btnNewLine.Name = "btnNewLine";
            this.btnNewLine.Size = new System.Drawing.Size(39, 39);
            this.btnNewLine.TabIndex = 22;
            this.btnNewLine.UseVisualStyleBackColor = true;
            this.btnNewLine.Click += new System.EventHandler(this.btnNewLine_Click);
            // 
            // btnRemoveDia
            // 
            this.btnRemoveDia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveDia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveDia.Enabled = false;
            this.btnRemoveDia.FlatAppearance.BorderSize = 0;
            this.btnRemoveDia.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnRemoveDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveDia.Image = global::AppInternacao.Properties.Resources.Remove_40970;
            this.btnRemoveDia.Location = new System.Drawing.Point(722, 146);
            this.btnRemoveDia.Name = "btnRemoveDia";
            this.btnRemoveDia.Size = new System.Drawing.Size(39, 39);
            this.btnRemoveDia.TabIndex = 20;
            this.btnRemoveDia.UseVisualStyleBackColor = true;
            this.btnRemoveDia.Click += new System.EventHandler(this.btnRemoveDia_Click);
            // 
            // UCPrescricaoCiclo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCPrescricaoCiclo";
            this.Size = new System.Drawing.Size(773, 548);
            this.Load += new System.EventHandler(this.UCPrescricaoCiclo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrescricoes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gDadosPaciente.ResumeLayout(false);
            this.gDadosPaciente.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewLine;
        private System.Windows.Forms.Button btnRemoveDia;
        private System.Windows.Forms.Button btnAddDia;
        private System.Windows.Forms.DataGridView dataGridViewPrescricoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar CalendarCicloPrescricao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddCiclo;
        private System.Windows.Forms.GroupBox gDadosPaciente;
        private System.Windows.Forms.Label lblLeito;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblProntuario;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCicloPrescricao;
    }
}
