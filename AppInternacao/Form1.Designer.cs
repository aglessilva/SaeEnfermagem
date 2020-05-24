namespace AppInternacao
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDropDown = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxProntuario = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUrgenciaEmergencia = new System.Windows.Forms.Button();
            this.btnClinicaObstetrica = new System.Windows.Forms.Button();
            this.btnClinicaCirurgica = new System.Windows.Forms.Button();
            this.btnClinicaPediatrica = new System.Windows.Forms.Button();
            this.btnClinicaMedica = new System.Windows.Forms.Button();
            this.pStep = new System.Windows.Forms.Panel();
            this.pByStep = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelDropDown.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pStep.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel16.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(643, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 72);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panelDropDown);
            this.panel1.Controls.Add(this.pStep);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(82, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 54);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // panelDropDown
            // 
            this.panelDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.panelDropDown.Controls.Add(this.btnUrgenciaEmergencia);
            this.panelDropDown.Controls.Add(this.btnClinicaObstetrica);
            this.panelDropDown.Controls.Add(this.btnClinicaCirurgica);
            this.panelDropDown.Controls.Add(this.btnClinicaPediatrica);
            this.panelDropDown.Controls.Add(this.btnClinicaMedica);
            this.panelDropDown.Location = new System.Drawing.Point(328, 119);
            this.panelDropDown.MaximumSize = new System.Drawing.Size(163, 190);
            this.panelDropDown.MinimumSize = new System.Drawing.Size(163, 0);
            this.panelDropDown.Name = "panelDropDown";
            this.panelDropDown.Size = new System.Drawing.Size(163, 0);
            this.panelDropDown.TabIndex = 8;
            this.panelDropDown.MouseLeave += new System.EventHandler(this.panelDropDown_MouseLeave);
            // 
            // timer2
            // 
            this.timer2.Interval = 15;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(24, 236);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(311, 40);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Enviar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(25, 119);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(310, 1);
            this.panel4.TabIndex = 7;
            // 
            // textBoxProntuario
            // 
            this.textBoxProntuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.textBoxProntuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProntuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProntuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxProntuario.Location = new System.Drawing.Point(67, 92);
            this.textBoxProntuario.MaxLength = 18;
            this.textBoxProntuario.Name = "textBoxProntuario";
            this.textBoxProntuario.Size = new System.Drawing.Size(257, 25);
            this.textBoxProntuario.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel2.Location = new System.Drawing.Point(24, 174);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 1);
            this.panel2.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.Location = new System.Drawing.Point(67, 147);
            this.textBox1.MaxLength = 18;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '?';
            this.textBox1.Size = new System.Drawing.Size(268, 25);
            this.textBox1.TabIndex = 9;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(354, 44);
            this.panel3.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(226, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 44);
            this.label1.TabIndex = 13;
            this.label1.Text = "LOGIN ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AppInternacao.Properties.Resources.key_password_lock_800;
            this.pictureBox2.Location = new System.Drawing.Point(27, 142);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppInternacao.Properties.Resources.user_accounts_15362;
            this.pictureBox1.Location = new System.Drawing.Point(27, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnUrgenciaEmergencia
            // 
            this.btnUrgenciaEmergencia.BackColor = System.Drawing.Color.Transparent;
            this.btnUrgenciaEmergencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUrgenciaEmergencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUrgenciaEmergencia.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnUrgenciaEmergencia.FlatAppearance.BorderSize = 0;
            this.btnUrgenciaEmergencia.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUrgenciaEmergencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnUrgenciaEmergencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrgenciaEmergencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrgenciaEmergencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUrgenciaEmergencia.Image = global::AppInternacao.Properties.Resources.hospital_doctor_10739;
            this.btnUrgenciaEmergencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrgenciaEmergencia.Location = new System.Drawing.Point(3, 143);
            this.btnUrgenciaEmergencia.Name = "btnUrgenciaEmergencia";
            this.btnUrgenciaEmergencia.Size = new System.Drawing.Size(157, 29);
            this.btnUrgenciaEmergencia.TabIndex = 12;
            this.btnUrgenciaEmergencia.Text = "Urgência/Emergência";
            this.btnUrgenciaEmergencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUrgenciaEmergencia.UseVisualStyleBackColor = false;
            // 
            // btnClinicaObstetrica
            // 
            this.btnClinicaObstetrica.BackColor = System.Drawing.Color.Transparent;
            this.btnClinicaObstetrica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClinicaObstetrica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClinicaObstetrica.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClinicaObstetrica.FlatAppearance.BorderSize = 0;
            this.btnClinicaObstetrica.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClinicaObstetrica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnClinicaObstetrica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClinicaObstetrica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClinicaObstetrica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClinicaObstetrica.Image = global::AppInternacao.Properties.Resources.toddler;
            this.btnClinicaObstetrica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClinicaObstetrica.Location = new System.Drawing.Point(3, 108);
            this.btnClinicaObstetrica.Name = "btnClinicaObstetrica";
            this.btnClinicaObstetrica.Size = new System.Drawing.Size(157, 29);
            this.btnClinicaObstetrica.TabIndex = 11;
            this.btnClinicaObstetrica.Text = "Clinica Obstétrica";
            this.btnClinicaObstetrica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClinicaObstetrica.UseVisualStyleBackColor = false;
            // 
            // btnClinicaCirurgica
            // 
            this.btnClinicaCirurgica.BackColor = System.Drawing.Color.Transparent;
            this.btnClinicaCirurgica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClinicaCirurgica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClinicaCirurgica.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClinicaCirurgica.FlatAppearance.BorderSize = 0;
            this.btnClinicaCirurgica.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClinicaCirurgica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnClinicaCirurgica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClinicaCirurgica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClinicaCirurgica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClinicaCirurgica.Image = global::AppInternacao.Properties.Resources.ClinicaMedica;
            this.btnClinicaCirurgica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClinicaCirurgica.Location = new System.Drawing.Point(3, 73);
            this.btnClinicaCirurgica.Name = "btnClinicaCirurgica";
            this.btnClinicaCirurgica.Size = new System.Drawing.Size(157, 29);
            this.btnClinicaCirurgica.TabIndex = 10;
            this.btnClinicaCirurgica.Text = "Clinica Cirurgica";
            this.btnClinicaCirurgica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClinicaCirurgica.UseVisualStyleBackColor = false;
            // 
            // btnClinicaPediatrica
            // 
            this.btnClinicaPediatrica.BackColor = System.Drawing.Color.Transparent;
            this.btnClinicaPediatrica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClinicaPediatrica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClinicaPediatrica.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClinicaPediatrica.FlatAppearance.BorderSize = 0;
            this.btnClinicaPediatrica.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClinicaPediatrica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnClinicaPediatrica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClinicaPediatrica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClinicaPediatrica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClinicaPediatrica.Image = global::AppInternacao.Properties.Resources.crianca;
            this.btnClinicaPediatrica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClinicaPediatrica.Location = new System.Drawing.Point(3, 38);
            this.btnClinicaPediatrica.Name = "btnClinicaPediatrica";
            this.btnClinicaPediatrica.Size = new System.Drawing.Size(157, 29);
            this.btnClinicaPediatrica.TabIndex = 9;
            this.btnClinicaPediatrica.Text = "Clinica Pediátrica";
            this.btnClinicaPediatrica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClinicaPediatrica.UseVisualStyleBackColor = false;
            // 
            // btnClinicaMedica
            // 
            this.btnClinicaMedica.BackColor = System.Drawing.Color.Transparent;
            this.btnClinicaMedica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClinicaMedica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClinicaMedica.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClinicaMedica.FlatAppearance.BorderSize = 0;
            this.btnClinicaMedica.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClinicaMedica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.btnClinicaMedica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClinicaMedica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClinicaMedica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClinicaMedica.Image = global::AppInternacao.Properties.Resources.ic_people_outline_128_28591;
            this.btnClinicaMedica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClinicaMedica.Location = new System.Drawing.Point(3, 3);
            this.btnClinicaMedica.Name = "btnClinicaMedica";
            this.btnClinicaMedica.Size = new System.Drawing.Size(157, 29);
            this.btnClinicaMedica.TabIndex = 8;
            this.btnClinicaMedica.Text = "Clinica Médica";
            this.btnClinicaMedica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClinicaMedica.UseVisualStyleBackColor = false;
            // 
            // pStep
            // 
            this.pStep.BackColor = System.Drawing.Color.Transparent;
            this.pStep.BackgroundImage = global::AppInternacao.Properties.Resources.Cabecalho011;
            this.pStep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pStep.Controls.Add(this.pByStep);
            this.pStep.Location = new System.Drawing.Point(140, 14);
            this.pStep.Name = "pStep";
            this.pStep.Size = new System.Drawing.Size(466, 62);
            this.pStep.TabIndex = 5;
            // 
            // pByStep
            // 
            this.pByStep.BackColor = System.Drawing.Color.Transparent;
            this.pByStep.BackgroundImage = global::AppInternacao.Properties.Resources.TimiLineStep;
            this.pByStep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pByStep.Location = new System.Drawing.Point(37, 20);
            this.pByStep.Name = "pByStep";
            this.pByStep.Size = new System.Drawing.Size(22, 22);
            this.pByStep.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Image = global::AppInternacao.Properties.Resources.nurse_person_woman_people_1697;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(315, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Adcionar Novo SAE";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel5.Location = new System.Drawing.Point(0, -32);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(310, 1);
            this.panel5.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(25, 85);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(310, 1);
            this.panel6.TabIndex = 9;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel7.Location = new System.Drawing.Point(0, -32);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(310, 1);
            this.panel7.TabIndex = 8;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Location = new System.Drawing.Point(24, 85);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1, 35);
            this.panel8.TabIndex = 10;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel9.Location = new System.Drawing.Point(0, -32);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(310, 1);
            this.panel9.TabIndex = 8;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Location = new System.Drawing.Point(334, 85);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1, 35);
            this.panel10.TabIndex = 11;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel11.Location = new System.Drawing.Point(0, -32);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(310, 1);
            this.panel11.TabIndex = 8;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel12.Controls.Add(this.panel13);
            this.panel12.Location = new System.Drawing.Point(333, 140);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1, 35);
            this.panel12.TabIndex = 13;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel13.Location = new System.Drawing.Point(0, -32);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(310, 1);
            this.panel13.TabIndex = 8;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel14.Controls.Add(this.panel15);
            this.panel14.Location = new System.Drawing.Point(24, 140);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(310, 1);
            this.panel14.TabIndex = 12;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel15.Location = new System.Drawing.Point(0, -32);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(310, 1);
            this.panel15.TabIndex = 8;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel16.Controls.Add(this.panel17);
            this.panel16.Location = new System.Drawing.Point(24, 140);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(1, 35);
            this.panel16.TabIndex = 11;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel17.Location = new System.Drawing.Point(0, -32);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(310, 1);
            this.panel17.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::AppInternacao.Properties.Resources.Delete_80_icon_icons_com_57340;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(313, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 49);
            this.button3.TabIndex = 14;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(354, 290);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.textBoxProntuario);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panelDropDown.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pStep.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pStep;
        private System.Windows.Forms.Panel pByStep;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelDropDown;
        private System.Windows.Forms.Button btnClinicaObstetrica;
        private System.Windows.Forms.Button btnClinicaCirurgica;
        private System.Windows.Forms.Button btnClinicaPediatrica;
        private System.Windows.Forms.Button btnClinicaMedica;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnUrgenciaEmergencia;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxProntuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Button button3;
    }
}