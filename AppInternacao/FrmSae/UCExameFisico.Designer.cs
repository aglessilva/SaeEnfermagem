using System;

namespace AppInternacao.FrmSae
{
    partial class UCExameFisico
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

            FrmMain.mySalvar.Click -= new EventHandler(Button1_Click);
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCExameFisico));
            this.rdoViceromegaliaAusente = new System.Windows.Forms.RadioButton();
            this.gRHA = new System.Windows.Forms.GroupBox();
            this.rdoRHAausente = new System.Windows.Forms.RadioButton();
            this.rdoRHAPresente = new System.Windows.Forms.RadioButton();
            this.rdoSngSog = new System.Windows.Forms.RadioButton();
            this.rdoSneSoe = new System.Windows.Forms.RadioButton();
            this.rdoVo = new System.Windows.Forms.RadioButton();
            this.gGavagem = new System.Windows.Forms.GroupBox();
            this.rdoEmese = new System.Windows.Forms.RadioButton();
            this.rdoAberta = new System.Windows.Forms.RadioButton();
            this.rdoConcavo = new System.Windows.Forms.RadioButton();
            this.rdoNormoTenso = new System.Windows.Forms.RadioButton();
            this.gEvacuacao = new System.Windows.Forms.GroupBox();
            this.rdoAusente = new System.Windows.Forms.RadioButton();
            this.rdoPresente = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.rdoTenso = new System.Windows.Forms.RadioButton();
            this.rdoDistendido = new System.Windows.Forms.RadioButton();
            this.rdoGloboso = new System.Windows.Forms.RadioButton();
            this.gUcera = new System.Windows.Forms.GroupBox();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.rdoGrau1 = new System.Windows.Forms.RadioButton();
            this.rdoGrau2 = new System.Windows.Forms.RadioButton();
            this.rdoGrau4 = new System.Windows.Forms.RadioButton();
            this.rdoGrau3 = new System.Windows.Forms.RadioButton();
            this.rdoViceromegaliaPresente = new System.Windows.Forms.RadioButton();
            this.rdoColunia = new System.Windows.Forms.RadioButton();
            this.rdoNtp = new System.Windows.Forms.RadioButton();
            this.gAbdominal = new System.Windows.Forms.GroupBox();
            this.gViceromegalia = new System.Windows.Forms.GroupBox();
            this.rdoHematuria = new System.Windows.Forms.RadioButton();
            this.rdoPoliuria = new System.Windows.Forms.RadioButton();
            this.rdoOliguria = new System.Windows.Forms.RadioButton();
            this.rdoDisuria = new System.Windows.Forms.RadioButton();
            this.rdoAnuria = new System.Windows.Forms.RadioButton();
            this.rdoUrinaAusente = new System.Windows.Forms.RadioButton();
            this.rdoUrinaPresente = new System.Windows.Forms.RadioButton();
            this.comboBoxDataSae = new System.Windows.Forms.ComboBox();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.gVascular = new System.Windows.Forms.GroupBox();
            this.gGastroIntestinal = new System.Windows.Forms.GroupBox();
            this.gUrina = new System.Windows.Forms.GroupBox();
            this.rdoOrientado = new System.Windows.Forms.RadioButton();
            this.rdoReageEstimulo = new System.Windows.Forms.RadioButton();
            this.rdoComatoso = new System.Windows.Forms.RadioButton();
            this.rdoSedado = new System.Windows.Forms.RadioButton();
            this.rdoNaoReage = new System.Windows.Forms.RadioButton();
            this.rdoAgitado = new System.Windows.Forms.RadioButton();
            this.rdoTorporoso = new System.Windows.Forms.RadioButton();
            this.gSistemaNeurologico = new System.Windows.Forms.GroupBox();
            this.rdoDesorientado = new System.Windows.Forms.RadioButton();
            this.rdoConciente = new System.Windows.Forms.RadioButton();
            this.textAglergias = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonradioButtonPerifEsquerdo = new System.Windows.Forms.RadioButton();
            this.radioButtonPerifDireito = new System.Windows.Forms.RadioButton();
            this.radioButtonCVC = new System.Windows.Forms.RadioButton();
            this.gPaciente = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEnfermeira = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textData = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textProntuario = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBoxQuarto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBoxSetor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textLeito = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textIdade = new System.Windows.Forms.TextBox();
            this.textPaciente = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rdoFerminino = new System.Windows.Forms.RadioButton();
            this.rdoMasculino = new System.Windows.Forms.RadioButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.radioButtonPICC = new System.Windows.Forms.RadioButton();
            this.radioButtonSemImp = new System.Windows.Forms.RadioButton();
            this.radioButtonTotalImp = new System.Windows.Forms.RadioButton();
            this.radioButtonJelco = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.gCateteres = new System.Windows.Forms.GroupBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxPad = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxPas = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxPressaoArterial = new System.Windows.Forms.ComboBox();
            this.rdoHiperTermica = new System.Windows.Forms.RadioButton();
            this.rdoPeleHipotermica = new System.Windows.Forms.RadioButton();
            this.rdoPeleAfebril = new System.Windows.Forms.RadioButton();
            this.rdoAniterica = new System.Windows.Forms.RadioButton();
            this.rdoNormacorada = new System.Windows.Forms.RadioButton();
            this.rdoIcteríca = new System.Windows.Forms.RadioButton();
            this.rdoHipocorada = new System.Windows.Forms.RadioButton();
            this.rdoCinotica = new System.Windows.Forms.RadioButton();
            this.rdoAcinotica = new System.Windows.Forms.RadioButton();
            this.gPele = new System.Windows.Forms.GroupBox();
            this.gPupilas = new System.Windows.Forms.GroupBox();
            this.rdoAnisocorica = new System.Windows.Forms.RadioButton();
            this.rdoMiotica = new System.Windows.Forms.RadioButton();
            this.rdoIsocorica = new System.Windows.Forms.RadioButton();
            this.rdoMidriatica = new System.Windows.Forms.RadioButton();
            this.rdoNaoReagente = new System.Windows.Forms.RadioButton();
            this.rdoFotorreagente = new System.Windows.Forms.RadioButton();
            this.rdoMascaraVenturi = new System.Windows.Forms.RadioButton();
            this.gOxigenacao = new System.Windows.Forms.GroupBox();
            this.rdoIntubacao = new System.Windows.Forms.RadioButton();
            this.rdoArAmbiente = new System.Windows.Forms.RadioButton();
            this.rdoEupneico = new System.Windows.Forms.RadioButton();
            this.rdoOxigenioterapia = new System.Windows.Forms.RadioButton();
            this.rdoBradipneico = new System.Windows.Forms.RadioButton();
            this.rdoDispineico = new System.Windows.Forms.RadioButton();
            this.rdoTraquipineico = new System.Windows.Forms.RadioButton();
            this.gStatusTermico = new System.Windows.Forms.GroupBox();
            this.rdoFebril = new System.Windows.Forms.RadioButton();
            this.rdoSubFebril = new System.Windows.Forms.RadioButton();
            this.rdoAfebril = new System.Windows.Forms.RadioButton();
            this.rdoHipotermico = new System.Windows.Forms.RadioButton();
            this.richTextBoxObservacoa = new System.Windows.Forms.RichTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.gRHA.SuspendLayout();
            this.gGavagem.SuspendLayout();
            this.gEvacuacao.SuspendLayout();
            this.gUcera.SuspendLayout();
            this.gAbdominal.SuspendLayout();
            this.gViceromegalia.SuspendLayout();
            this.gVascular.SuspendLayout();
            this.gGastroIntestinal.SuspendLayout();
            this.gUrina.SuspendLayout();
            this.gSistemaNeurologico.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.gCateteres.SuspendLayout();
            this.gPele.SuspendLayout();
            this.gPupilas.SuspendLayout();
            this.gOxigenacao.SuspendLayout();
            this.gStatusTermico.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdoViceromegaliaAusente
            // 
            this.rdoViceromegaliaAusente.AutoSize = true;
            this.rdoViceromegaliaAusente.Location = new System.Drawing.Point(113, 19);
            this.rdoViceromegaliaAusente.Name = "rdoViceromegaliaAusente";
            this.rdoViceromegaliaAusente.Size = new System.Drawing.Size(64, 17);
            this.rdoViceromegaliaAusente.TabIndex = 88;
            this.rdoViceromegaliaAusente.TabStop = true;
            this.rdoViceromegaliaAusente.Tag = "RA10";
            this.rdoViceromegaliaAusente.Text = "Ausente";
            this.rdoViceromegaliaAusente.UseVisualStyleBackColor = true;
            // 
            // gRHA
            // 
            this.gRHA.Controls.Add(this.rdoRHAausente);
            this.gRHA.Controls.Add(this.rdoRHAPresente);
            this.gRHA.Location = new System.Drawing.Point(20, 53);
            this.gRHA.Name = "gRHA";
            this.gRHA.Size = new System.Drawing.Size(189, 48);
            this.gRHA.TabIndex = 83;
            this.gRHA.TabStop = false;
            this.gRHA.Text = "RHA";
            // 
            // rdoRHAausente
            // 
            this.rdoRHAausente.AutoSize = true;
            this.rdoRHAausente.Location = new System.Drawing.Point(113, 19);
            this.rdoRHAausente.Name = "rdoRHAausente";
            this.rdoRHAausente.Size = new System.Drawing.Size(64, 17);
            this.rdoRHAausente.TabIndex = 85;
            this.rdoRHAausente.TabStop = true;
            this.rdoRHAausente.Tag = "RA08";
            this.rdoRHAausente.Text = "Ausente";
            this.rdoRHAausente.UseVisualStyleBackColor = true;
            // 
            // rdoRHAPresente
            // 
            this.rdoRHAPresente.AutoSize = true;
            this.rdoRHAPresente.Location = new System.Drawing.Point(26, 19);
            this.rdoRHAPresente.Name = "rdoRHAPresente";
            this.rdoRHAPresente.Size = new System.Drawing.Size(67, 17);
            this.rdoRHAPresente.TabIndex = 84;
            this.rdoRHAPresente.TabStop = true;
            this.rdoRHAPresente.Tag = "RA07";
            this.rdoRHAPresente.Text = "Presente";
            this.rdoRHAPresente.UseVisualStyleBackColor = true;
            // 
            // rdoSngSog
            // 
            this.rdoSngSog.AutoSize = true;
            this.rdoSngSog.Location = new System.Drawing.Point(6, 19);
            this.rdoSngSog.Name = "rdoSngSog";
            this.rdoSngSog.Size = new System.Drawing.Size(76, 17);
            this.rdoSngSog.TabIndex = 57;
            this.rdoSngSog.TabStop = true;
            this.rdoSngSog.Tag = "SG01";
            this.rdoSngSog.Text = "SNG/SOG";
            this.rdoSngSog.UseVisualStyleBackColor = true;
            // 
            // rdoSneSoe
            // 
            this.rdoSneSoe.AutoSize = true;
            this.rdoSneSoe.Location = new System.Drawing.Point(101, 19);
            this.rdoSneSoe.Name = "rdoSneSoe";
            this.rdoSneSoe.Size = new System.Drawing.Size(74, 17);
            this.rdoSneSoe.TabIndex = 58;
            this.rdoSneSoe.TabStop = true;
            this.rdoSneSoe.Tag = "SG02";
            this.rdoSneSoe.Text = "SNE/SOE";
            this.rdoSneSoe.UseVisualStyleBackColor = true;
            // 
            // rdoVo
            // 
            this.rdoVo.AutoSize = true;
            this.rdoVo.Location = new System.Drawing.Point(253, 19);
            this.rdoVo.Name = "rdoVo";
            this.rdoVo.Size = new System.Drawing.Size(40, 17);
            this.rdoVo.TabIndex = 60;
            this.rdoVo.TabStop = true;
            this.rdoVo.Tag = "SG04";
            this.rdoVo.Text = "VO";
            this.rdoVo.UseVisualStyleBackColor = true;
            // 
            // gGavagem
            // 
            this.gGavagem.Controls.Add(this.rdoEmese);
            this.gGavagem.Controls.Add(this.rdoAberta);
            this.gGavagem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gGavagem.Location = new System.Drawing.Point(20, 55);
            this.gGavagem.Name = "gGavagem";
            this.gGavagem.Size = new System.Drawing.Size(183, 48);
            this.gGavagem.TabIndex = 61;
            this.gGavagem.TabStop = false;
            this.gGavagem.Text = " Gavagem ";
            // 
            // rdoEmese
            // 
            this.rdoEmese.AutoSize = true;
            this.rdoEmese.Location = new System.Drawing.Point(113, 19);
            this.rdoEmese.Name = "rdoEmese";
            this.rdoEmese.Size = new System.Drawing.Size(57, 17);
            this.rdoEmese.TabIndex = 63;
            this.rdoEmese.TabStop = true;
            this.rdoEmese.Tag = "SG06";
            this.rdoEmese.Text = "Emese";
            this.rdoEmese.UseVisualStyleBackColor = true;
            // 
            // rdoAberta
            // 
            this.rdoAberta.AutoSize = true;
            this.rdoAberta.Location = new System.Drawing.Point(26, 19);
            this.rdoAberta.Name = "rdoAberta";
            this.rdoAberta.Size = new System.Drawing.Size(56, 17);
            this.rdoAberta.TabIndex = 62;
            this.rdoAberta.TabStop = true;
            this.rdoAberta.Tag = "SG05";
            this.rdoAberta.Text = "Aberta";
            this.rdoAberta.UseVisualStyleBackColor = true;
            // 
            // rdoConcavo
            // 
            this.rdoConcavo.AutoSize = true;
            this.rdoConcavo.Location = new System.Drawing.Point(562, 19);
            this.rdoConcavo.Name = "rdoConcavo";
            this.rdoConcavo.Size = new System.Drawing.Size(68, 17);
            this.rdoConcavo.TabIndex = 82;
            this.rdoConcavo.TabStop = true;
            this.rdoConcavo.Tag = "RA06";
            this.rdoConcavo.Text = "Côncavo";
            this.rdoConcavo.UseVisualStyleBackColor = true;
            // 
            // rdoNormoTenso
            // 
            this.rdoNormoTenso.AutoSize = true;
            this.rdoNormoTenso.Location = new System.Drawing.Point(6, 19);
            this.rdoNormoTenso.Name = "rdoNormoTenso";
            this.rdoNormoTenso.Size = new System.Drawing.Size(82, 17);
            this.rdoNormoTenso.TabIndex = 77;
            this.rdoNormoTenso.TabStop = true;
            this.rdoNormoTenso.Tag = "RA01";
            this.rdoNormoTenso.Text = "Normotenso";
            this.rdoNormoTenso.UseVisualStyleBackColor = true;
            // 
            // gEvacuacao
            // 
            this.gEvacuacao.Controls.Add(this.rdoAusente);
            this.gEvacuacao.Controls.Add(this.rdoPresente);
            this.gEvacuacao.Location = new System.Drawing.Point(214, 55);
            this.gEvacuacao.Name = "gEvacuacao";
            this.gEvacuacao.Size = new System.Drawing.Size(189, 48);
            this.gEvacuacao.TabIndex = 64;
            this.gEvacuacao.TabStop = false;
            this.gEvacuacao.Text = " Evacuação ";
            // 
            // rdoAusente
            // 
            this.rdoAusente.AutoSize = true;
            this.rdoAusente.Location = new System.Drawing.Point(113, 19);
            this.rdoAusente.Name = "rdoAusente";
            this.rdoAusente.Size = new System.Drawing.Size(64, 17);
            this.rdoAusente.TabIndex = 66;
            this.rdoAusente.TabStop = true;
            this.rdoAusente.Tag = "SG08";
            this.rdoAusente.Text = "Ausente";
            this.rdoAusente.UseVisualStyleBackColor = true;
            // 
            // rdoPresente
            // 
            this.rdoPresente.AutoSize = true;
            this.rdoPresente.Location = new System.Drawing.Point(26, 19);
            this.rdoPresente.Name = "rdoPresente";
            this.rdoPresente.Size = new System.Drawing.Size(67, 17);
            this.rdoPresente.TabIndex = 65;
            this.rdoPresente.TabStop = true;
            this.rdoPresente.Tag = "SG07";
            this.rdoPresente.Text = "Presente";
            this.rdoPresente.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(454, 19);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(60, 17);
            this.radioButton6.TabIndex = 81;
            this.radioButton6.TabStop = true;
            this.radioButton6.Tag = "RA05";
            this.radioButton6.Text = "Ictérica";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // rdoTenso
            // 
            this.rdoTenso.AutoSize = true;
            this.rdoTenso.Location = new System.Drawing.Point(133, 19);
            this.rdoTenso.Name = "rdoTenso";
            this.rdoTenso.Size = new System.Drawing.Size(55, 17);
            this.rdoTenso.TabIndex = 78;
            this.rdoTenso.TabStop = true;
            this.rdoTenso.Tag = "RA02";
            this.rdoTenso.Text = "Tenso";
            this.rdoTenso.UseVisualStyleBackColor = true;
            // 
            // rdoDistendido
            // 
            this.rdoDistendido.AutoSize = true;
            this.rdoDistendido.Location = new System.Drawing.Point(334, 19);
            this.rdoDistendido.Name = "rdoDistendido";
            this.rdoDistendido.Size = new System.Drawing.Size(75, 17);
            this.rdoDistendido.TabIndex = 80;
            this.rdoDistendido.TabStop = true;
            this.rdoDistendido.Tag = "RA04";
            this.rdoDistendido.Text = "Distendido";
            this.rdoDistendido.UseVisualStyleBackColor = true;
            // 
            // rdoGloboso
            // 
            this.rdoGloboso.AutoSize = true;
            this.rdoGloboso.Location = new System.Drawing.Point(229, 19);
            this.rdoGloboso.Name = "rdoGloboso";
            this.rdoGloboso.Size = new System.Drawing.Size(64, 17);
            this.rdoGloboso.TabIndex = 79;
            this.rdoGloboso.TabStop = true;
            this.rdoGloboso.Tag = "RA03";
            this.rdoGloboso.Text = "Globoso";
            this.rdoGloboso.UseVisualStyleBackColor = true;
            // 
            // gUcera
            // 
            this.gUcera.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gUcera.AutoSize = true;
            this.gUcera.Controls.Add(this.radioButton13);
            this.gUcera.Controls.Add(this.rdoGrau1);
            this.gUcera.Controls.Add(this.rdoGrau2);
            this.gUcera.Controls.Add(this.rdoGrau4);
            this.gUcera.Controls.Add(this.rdoGrau3);
            this.gUcera.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gUcera.Location = new System.Drawing.Point(2, 1199);
            this.gUcera.Name = "gUcera";
            this.gUcera.Size = new System.Drawing.Size(857, 55);
            this.gUcera.TabIndex = 110;
            this.gUcera.TabStop = false;
            this.gUcera.Text = " Lesão por Pressão ";
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Location = new System.Drawing.Point(341, 19);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(73, 17);
            this.radioButton13.TabIndex = 94;
            this.radioButton13.TabStop = true;
            this.radioButton13.Tag = "UC04";
            this.radioButton13.Text = "NENHUM";
            this.radioButton13.UseVisualStyleBackColor = true;
            // 
            // rdoGrau1
            // 
            this.rdoGrau1.AutoSize = true;
            this.rdoGrau1.Location = new System.Drawing.Point(6, 19);
            this.rdoGrau1.Name = "rdoGrau1";
            this.rdoGrau1.Size = new System.Drawing.Size(69, 17);
            this.rdoGrau1.TabIndex = 90;
            this.rdoGrau1.TabStop = true;
            this.rdoGrau1.Tag = "UC01";
            this.rdoGrau1.Text = "Estágio 1";
            this.rdoGrau1.UseVisualStyleBackColor = true;
            // 
            // rdoGrau2
            // 
            this.rdoGrau2.AutoSize = true;
            this.rdoGrau2.Location = new System.Drawing.Point(91, 19);
            this.rdoGrau2.Name = "rdoGrau2";
            this.rdoGrau2.Size = new System.Drawing.Size(69, 17);
            this.rdoGrau2.TabIndex = 91;
            this.rdoGrau2.TabStop = true;
            this.rdoGrau2.Tag = "UC02";
            this.rdoGrau2.Text = "Estágio 2";
            this.rdoGrau2.UseVisualStyleBackColor = true;
            // 
            // rdoGrau4
            // 
            this.rdoGrau4.AutoSize = true;
            this.rdoGrau4.Location = new System.Drawing.Point(258, 19);
            this.rdoGrau4.Name = "rdoGrau4";
            this.rdoGrau4.Size = new System.Drawing.Size(69, 17);
            this.rdoGrau4.TabIndex = 93;
            this.rdoGrau4.TabStop = true;
            this.rdoGrau4.Tag = "UC04";
            this.rdoGrau4.Text = "Estágio 4";
            this.rdoGrau4.UseVisualStyleBackColor = true;
            // 
            // rdoGrau3
            // 
            this.rdoGrau3.AutoSize = true;
            this.rdoGrau3.Location = new System.Drawing.Point(173, 19);
            this.rdoGrau3.Name = "rdoGrau3";
            this.rdoGrau3.Size = new System.Drawing.Size(69, 17);
            this.rdoGrau3.TabIndex = 92;
            this.rdoGrau3.TabStop = true;
            this.rdoGrau3.Tag = "UC03";
            this.rdoGrau3.Text = "Estágio 3";
            this.rdoGrau3.UseVisualStyleBackColor = true;
            // 
            // rdoViceromegaliaPresente
            // 
            this.rdoViceromegaliaPresente.AutoSize = true;
            this.rdoViceromegaliaPresente.Location = new System.Drawing.Point(26, 19);
            this.rdoViceromegaliaPresente.Name = "rdoViceromegaliaPresente";
            this.rdoViceromegaliaPresente.Size = new System.Drawing.Size(67, 17);
            this.rdoViceromegaliaPresente.TabIndex = 87;
            this.rdoViceromegaliaPresente.TabStop = true;
            this.rdoViceromegaliaPresente.Tag = "RA09";
            this.rdoViceromegaliaPresente.Text = "Presente";
            this.rdoViceromegaliaPresente.UseVisualStyleBackColor = true;
            // 
            // rdoColunia
            // 
            this.rdoColunia.AutoSize = true;
            this.rdoColunia.Location = new System.Drawing.Point(487, 19);
            this.rdoColunia.Name = "rdoColunia";
            this.rdoColunia.Size = new System.Drawing.Size(60, 17);
            this.rdoColunia.TabIndex = 75;
            this.rdoColunia.TabStop = true;
            this.rdoColunia.Tag = "SG16";
            this.rdoColunia.Text = "Colúnia";
            this.rdoColunia.UseVisualStyleBackColor = true;
            // 
            // rdoNtp
            // 
            this.rdoNtp.AutoSize = true;
            this.rdoNtp.Location = new System.Drawing.Point(187, 19);
            this.rdoNtp.Name = "rdoNtp";
            this.rdoNtp.Size = new System.Drawing.Size(47, 17);
            this.rdoNtp.TabIndex = 59;
            this.rdoNtp.TabStop = true;
            this.rdoNtp.Tag = "SG03";
            this.rdoNtp.Text = "NTP";
            this.rdoNtp.UseVisualStyleBackColor = true;
            // 
            // gAbdominal
            // 
            this.gAbdominal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gAbdominal.AutoSize = true;
            this.gAbdominal.Controls.Add(this.gViceromegalia);
            this.gAbdominal.Controls.Add(this.gRHA);
            this.gAbdominal.Controls.Add(this.rdoConcavo);
            this.gAbdominal.Controls.Add(this.rdoNormoTenso);
            this.gAbdominal.Controls.Add(this.radioButton6);
            this.gAbdominal.Controls.Add(this.rdoTenso);
            this.gAbdominal.Controls.Add(this.rdoDistendido);
            this.gAbdominal.Controls.Add(this.rdoGloboso);
            this.gAbdominal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gAbdominal.Location = new System.Drawing.Point(2, 952);
            this.gAbdominal.Name = "gAbdominal";
            this.gAbdominal.Size = new System.Drawing.Size(857, 120);
            this.gAbdominal.TabIndex = 109;
            this.gAbdominal.TabStop = false;
            this.gAbdominal.Text = " Regulação Abdominal ";
            // 
            // gViceromegalia
            // 
            this.gViceromegalia.Controls.Add(this.rdoViceromegaliaAusente);
            this.gViceromegalia.Controls.Add(this.rdoViceromegaliaPresente);
            this.gViceromegalia.Location = new System.Drawing.Point(232, 53);
            this.gViceromegalia.Name = "gViceromegalia";
            this.gViceromegalia.Size = new System.Drawing.Size(189, 48);
            this.gViceromegalia.TabIndex = 86;
            this.gViceromegalia.TabStop = false;
            this.gViceromegalia.Text = "Viceromegalias";
            // 
            // rdoHematuria
            // 
            this.rdoHematuria.AutoSize = true;
            this.rdoHematuria.Location = new System.Drawing.Point(408, 19);
            this.rdoHematuria.Name = "rdoHematuria";
            this.rdoHematuria.Size = new System.Drawing.Size(73, 17);
            this.rdoHematuria.TabIndex = 74;
            this.rdoHematuria.TabStop = true;
            this.rdoHematuria.Tag = "SG15";
            this.rdoHematuria.Text = "Hematúria";
            this.rdoHematuria.UseVisualStyleBackColor = true;
            // 
            // rdoPoliuria
            // 
            this.rdoPoliuria.AutoSize = true;
            this.rdoPoliuria.Location = new System.Drawing.Point(214, 19);
            this.rdoPoliuria.Name = "rdoPoliuria";
            this.rdoPoliuria.Size = new System.Drawing.Size(59, 17);
            this.rdoPoliuria.TabIndex = 71;
            this.rdoPoliuria.TabStop = true;
            this.rdoPoliuria.Tag = "SG12";
            this.rdoPoliuria.Text = "Poliúria";
            this.rdoPoliuria.UseVisualStyleBackColor = true;
            // 
            // rdoOliguria
            // 
            this.rdoOliguria.AutoSize = true;
            this.rdoOliguria.Location = new System.Drawing.Point(279, 19);
            this.rdoOliguria.Name = "rdoOliguria";
            this.rdoOliguria.Size = new System.Drawing.Size(60, 17);
            this.rdoOliguria.TabIndex = 72;
            this.rdoOliguria.TabStop = true;
            this.rdoOliguria.Tag = "SG13";
            this.rdoOliguria.Text = "Oligúria";
            this.rdoOliguria.UseVisualStyleBackColor = true;
            // 
            // rdoDisuria
            // 
            this.rdoDisuria.AutoSize = true;
            this.rdoDisuria.Location = new System.Drawing.Point(345, 19);
            this.rdoDisuria.Name = "rdoDisuria";
            this.rdoDisuria.Size = new System.Drawing.Size(57, 17);
            this.rdoDisuria.TabIndex = 73;
            this.rdoDisuria.TabStop = true;
            this.rdoDisuria.Tag = "SG14";
            this.rdoDisuria.Text = "Disúria";
            this.rdoDisuria.UseVisualStyleBackColor = true;
            // 
            // rdoAnuria
            // 
            this.rdoAnuria.AutoSize = true;
            this.rdoAnuria.Location = new System.Drawing.Point(153, 19);
            this.rdoAnuria.Name = "rdoAnuria";
            this.rdoAnuria.Size = new System.Drawing.Size(55, 17);
            this.rdoAnuria.TabIndex = 70;
            this.rdoAnuria.TabStop = true;
            this.rdoAnuria.Tag = "SG11";
            this.rdoAnuria.Text = "Anúria";
            this.rdoAnuria.UseVisualStyleBackColor = true;
            // 
            // rdoUrinaAusente
            // 
            this.rdoUrinaAusente.AutoSize = true;
            this.rdoUrinaAusente.Location = new System.Drawing.Point(83, 19);
            this.rdoUrinaAusente.Name = "rdoUrinaAusente";
            this.rdoUrinaAusente.Size = new System.Drawing.Size(64, 17);
            this.rdoUrinaAusente.TabIndex = 69;
            this.rdoUrinaAusente.TabStop = true;
            this.rdoUrinaAusente.Tag = "SG10";
            this.rdoUrinaAusente.Text = "Ausente";
            this.rdoUrinaAusente.UseVisualStyleBackColor = true;
            // 
            // rdoUrinaPresente
            // 
            this.rdoUrinaPresente.AutoSize = true;
            this.rdoUrinaPresente.Location = new System.Drawing.Point(10, 19);
            this.rdoUrinaPresente.Name = "rdoUrinaPresente";
            this.rdoUrinaPresente.Size = new System.Drawing.Size(67, 17);
            this.rdoUrinaPresente.TabIndex = 68;
            this.rdoUrinaPresente.TabStop = true;
            this.rdoUrinaPresente.Tag = "SG09";
            this.rdoUrinaPresente.Text = "Presente";
            this.rdoUrinaPresente.UseVisualStyleBackColor = true;
            // 
            // comboBoxDataSae
            // 
            this.comboBoxDataSae.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDataSae.FormattingEnabled = true;
            this.comboBoxDataSae.Location = new System.Drawing.Point(575, 36);
            this.comboBoxDataSae.Name = "comboBoxDataSae";
            this.comboBoxDataSae.Size = new System.Drawing.Size(259, 21);
            this.comboBoxDataSae.TabIndex = 1000;
            this.comboBoxDataSae.TabStop = false;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(421, 52);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(73, 17);
            this.radioButton12.TabIndex = 57;
            this.radioButton12.TabStop = true;
            this.radioButton12.Tag = "RV11";
            this.radioButton12.Text = "Hipotenso";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(334, 52);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(76, 17);
            this.radioButton11.TabIndex = 56;
            this.radioButton11.TabStop = true;
            this.radioButton11.Tag = "RV10";
            this.radioButton11.Text = "Hipertenso";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(229, 52);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(82, 17);
            this.radioButton1.TabIndex = 55;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "RV09";
            this.radioButton1.Text = "Normotenso";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 52);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(60, 17);
            this.radioButton2.TabIndex = 53;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "RV07";
            this.radioButton2.Text = "Ritmico";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(119, 52);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(62, 17);
            this.radioButton3.TabIndex = 54;
            this.radioButton3.TabStop = true;
            this.radioButton3.Tag = "RV08";
            this.radioButton3.Text = "Aritmico";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(490, 19);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(63, 17);
            this.radioButton4.TabIndex = 52;
            this.radioButton4.TabStop = true;
            this.radioButton4.Tag = "RV06";
            this.radioButton4.Text = "Filiforme";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 19);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(97, 17);
            this.radioButton5.TabIndex = 47;
            this.radioButton5.TabStop = true;
            this.radioButton5.Tag = "RV01";
            this.radioButton5.Text = "Normocardiaco";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(421, 19);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(52, 17);
            this.radioButton7.TabIndex = 51;
            this.radioButton7.TabStop = true;
            this.radioButton7.Tag = "RV05";
            this.radioButton7.Text = "Cheio";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(119, 19);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(90, 17);
            this.radioButton8.TabIndex = 48;
            this.radioButton8.TabStop = true;
            this.radioButton8.Tag = "RV02";
            this.radioButton8.Text = "Bradicardiaco";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(334, 19);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(51, 17);
            this.radioButton9.TabIndex = 50;
            this.radioButton9.TabStop = true;
            this.radioButton9.Tag = "RV04";
            this.radioButton9.Text = "Pulso";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(227, 19);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(93, 17);
            this.radioButton10.TabIndex = 49;
            this.radioButton10.TabStop = true;
            this.radioButton10.Tag = "RV03";
            this.radioButton10.Text = "Taquicárdiaco";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // gVascular
            // 
            this.gVascular.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gVascular.AutoSize = true;
            this.gVascular.Controls.Add(this.radioButton12);
            this.gVascular.Controls.Add(this.radioButton11);
            this.gVascular.Controls.Add(this.radioButton1);
            this.gVascular.Controls.Add(this.radioButton2);
            this.gVascular.Controls.Add(this.radioButton3);
            this.gVascular.Controls.Add(this.radioButton4);
            this.gVascular.Controls.Add(this.radioButton5);
            this.gVascular.Controls.Add(this.radioButton7);
            this.gVascular.Controls.Add(this.radioButton8);
            this.gVascular.Controls.Add(this.radioButton9);
            this.gVascular.Controls.Add(this.radioButton10);
            this.gVascular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gVascular.Location = new System.Drawing.Point(2, 1091);
            this.gVascular.Name = "gVascular";
            this.gVascular.Size = new System.Drawing.Size(857, 88);
            this.gVascular.TabIndex = 112;
            this.gVascular.TabStop = false;
            this.gVascular.Text = " Regulação Vascular ";
            // 
            // gGastroIntestinal
            // 
            this.gGastroIntestinal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gGastroIntestinal.AutoSize = true;
            this.gGastroIntestinal.Controls.Add(this.gUrina);
            this.gGastroIntestinal.Controls.Add(this.gEvacuacao);
            this.gGastroIntestinal.Controls.Add(this.gGavagem);
            this.gGastroIntestinal.Controls.Add(this.rdoSngSog);
            this.gGastroIntestinal.Controls.Add(this.rdoSneSoe);
            this.gGastroIntestinal.Controls.Add(this.rdoVo);
            this.gGastroIntestinal.Controls.Add(this.rdoNtp);
            this.gGastroIntestinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gGastroIntestinal.Location = new System.Drawing.Point(2, 752);
            this.gGastroIntestinal.Name = "gGastroIntestinal";
            this.gGastroIntestinal.Size = new System.Drawing.Size(857, 179);
            this.gGastroIntestinal.TabIndex = 108;
            this.gGastroIntestinal.TabStop = false;
            this.gGastroIntestinal.Text = " SISTEMA GASTROINTESTINAL ";
            // 
            // gUrina
            // 
            this.gUrina.Controls.Add(this.rdoColunia);
            this.gUrina.Controls.Add(this.rdoHematuria);
            this.gUrina.Controls.Add(this.rdoPoliuria);
            this.gUrina.Controls.Add(this.rdoOliguria);
            this.gUrina.Controls.Add(this.rdoDisuria);
            this.gUrina.Controls.Add(this.rdoAnuria);
            this.gUrina.Controls.Add(this.rdoUrinaAusente);
            this.gUrina.Controls.Add(this.rdoUrinaPresente);
            this.gUrina.Location = new System.Drawing.Point(21, 112);
            this.gUrina.Name = "gUrina";
            this.gUrina.Size = new System.Drawing.Size(565, 48);
            this.gUrina.TabIndex = 67;
            this.gUrina.TabStop = false;
            this.gUrina.Text = "Sistema Urinário";
            // 
            // rdoOrientado
            // 
            this.rdoOrientado.AutoSize = true;
            this.rdoOrientado.Location = new System.Drawing.Point(483, 21);
            this.rdoOrientado.Name = "rdoOrientado";
            this.rdoOrientado.Size = new System.Drawing.Size(71, 17);
            this.rdoOrientado.TabIndex = 19;
            this.rdoOrientado.TabStop = true;
            this.rdoOrientado.Tag = "SN06";
            this.rdoOrientado.Text = "Orientado";
            this.rdoOrientado.UseVisualStyleBackColor = true;
            // 
            // rdoReageEstimulo
            // 
            this.rdoReageEstimulo.AutoSize = true;
            this.rdoReageEstimulo.Location = new System.Drawing.Point(744, 20);
            this.rdoReageEstimulo.Name = "rdoReageEstimulo";
            this.rdoReageEstimulo.Size = new System.Drawing.Size(104, 17);
            this.rdoReageEstimulo.TabIndex = 22;
            this.rdoReageEstimulo.TabStop = true;
            this.rdoReageEstimulo.Tag = "SN09";
            this.rdoReageEstimulo.Text = "Reage Estimulos";
            this.rdoReageEstimulo.UseVisualStyleBackColor = true;
            // 
            // rdoComatoso
            // 
            this.rdoComatoso.AutoSize = true;
            this.rdoComatoso.Location = new System.Drawing.Point(651, 20);
            this.rdoComatoso.Name = "rdoComatoso";
            this.rdoComatoso.Size = new System.Drawing.Size(72, 17);
            this.rdoComatoso.TabIndex = 21;
            this.rdoComatoso.TabStop = true;
            this.rdoComatoso.Tag = "SN08";
            this.rdoComatoso.Text = "Comatoso";
            this.rdoComatoso.UseVisualStyleBackColor = true;
            // 
            // rdoSedado
            // 
            this.rdoSedado.AutoSize = true;
            this.rdoSedado.Location = new System.Drawing.Point(573, 20);
            this.rdoSedado.Name = "rdoSedado";
            this.rdoSedado.Size = new System.Drawing.Size(62, 17);
            this.rdoSedado.TabIndex = 20;
            this.rdoSedado.TabStop = true;
            this.rdoSedado.Tag = "SN07";
            this.rdoSedado.Text = "Sedado";
            this.rdoSedado.UseVisualStyleBackColor = true;
            // 
            // rdoNaoReage
            // 
            this.rdoNaoReage.AutoSize = true;
            this.rdoNaoReage.Location = new System.Drawing.Point(383, 21);
            this.rdoNaoReage.Name = "rdoNaoReage";
            this.rdoNaoReage.Size = new System.Drawing.Size(80, 17);
            this.rdoNaoReage.TabIndex = 18;
            this.rdoNaoReage.TabStop = true;
            this.rdoNaoReage.Tag = "SN05";
            this.rdoNaoReage.Text = "Não Reage";
            this.rdoNaoReage.UseVisualStyleBackColor = true;
            // 
            // rdoAgitado
            // 
            this.rdoAgitado.AutoSize = true;
            this.rdoAgitado.Location = new System.Drawing.Point(302, 21);
            this.rdoAgitado.Name = "rdoAgitado";
            this.rdoAgitado.Size = new System.Drawing.Size(61, 17);
            this.rdoAgitado.TabIndex = 17;
            this.rdoAgitado.TabStop = true;
            this.rdoAgitado.Tag = "SN04";
            this.rdoAgitado.Text = "Agitado";
            this.rdoAgitado.UseVisualStyleBackColor = true;
            // 
            // rdoTorporoso
            // 
            this.rdoTorporoso.AutoSize = true;
            this.rdoTorporoso.Location = new System.Drawing.Point(205, 21);
            this.rdoTorporoso.Name = "rdoTorporoso";
            this.rdoTorporoso.Size = new System.Drawing.Size(73, 17);
            this.rdoTorporoso.TabIndex = 15;
            this.rdoTorporoso.TabStop = true;
            this.rdoTorporoso.Tag = "SN03";
            this.rdoTorporoso.Text = "Torporoso";
            this.rdoTorporoso.UseVisualStyleBackColor = true;
            // 
            // gSistemaNeurologico
            // 
            this.gSistemaNeurologico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gSistemaNeurologico.AutoSize = true;
            this.gSistemaNeurologico.Controls.Add(this.rdoOrientado);
            this.gSistemaNeurologico.Controls.Add(this.rdoReageEstimulo);
            this.gSistemaNeurologico.Controls.Add(this.rdoComatoso);
            this.gSistemaNeurologico.Controls.Add(this.rdoSedado);
            this.gSistemaNeurologico.Controls.Add(this.rdoNaoReage);
            this.gSistemaNeurologico.Controls.Add(this.rdoAgitado);
            this.gSistemaNeurologico.Controls.Add(this.rdoTorporoso);
            this.gSistemaNeurologico.Controls.Add(this.rdoDesorientado);
            this.gSistemaNeurologico.Controls.Add(this.rdoConciente);
            this.gSistemaNeurologico.Location = new System.Drawing.Point(2, 368);
            this.gSistemaNeurologico.Name = "gSistemaNeurologico";
            this.gSistemaNeurologico.Size = new System.Drawing.Size(854, 57);
            this.gSistemaNeurologico.TabIndex = 101;
            this.gSistemaNeurologico.TabStop = false;
            this.gSistemaNeurologico.Text = " Sistema Neurológico ";
            // 
            // rdoDesorientado
            // 
            this.rdoDesorientado.AutoSize = true;
            this.rdoDesorientado.Location = new System.Drawing.Point(92, 20);
            this.rdoDesorientado.Name = "rdoDesorientado";
            this.rdoDesorientado.Size = new System.Drawing.Size(88, 17);
            this.rdoDesorientado.TabIndex = 15;
            this.rdoDesorientado.TabStop = true;
            this.rdoDesorientado.Tag = "SN02";
            this.rdoDesorientado.Text = "Desorientado";
            this.rdoDesorientado.UseVisualStyleBackColor = true;
            // 
            // rdoConciente
            // 
            this.rdoConciente.AutoSize = true;
            this.rdoConciente.Location = new System.Drawing.Point(6, 20);
            this.rdoConciente.Name = "rdoConciente";
            this.rdoConciente.Size = new System.Drawing.Size(73, 17);
            this.rdoConciente.TabIndex = 14;
            this.rdoConciente.TabStop = true;
            this.rdoConciente.Tag = "SN01";
            this.rdoConciente.Text = "Conciente";
            this.rdoConciente.UseVisualStyleBackColor = true;
            // 
            // textAglergias
            // 
            this.textAglergias.Location = new System.Drawing.Point(52, 335);
            this.textAglergias.Name = "textAglergias";
            this.textAglergias.Size = new System.Drawing.Size(789, 20);
            this.textAglergias.TabIndex = 100;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-1, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 98;
            this.label5.Text = "Alergias:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Catetere Periférico:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonradioButtonPerifEsquerdo);
            this.panel1.Controls.Add(this.radioButtonPerifDireito);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 44);
            this.panel1.TabIndex = 9;
            // 
            // radioButtonradioButtonPerifEsquerdo
            // 
            this.radioButtonradioButtonPerifEsquerdo.AutoSize = true;
            this.radioButtonradioButtonPerifEsquerdo.Location = new System.Drawing.Point(250, 15);
            this.radioButtonradioButtonPerifEsquerdo.Name = "radioButtonradioButtonPerifEsquerdo";
            this.radioButtonradioButtonPerifEsquerdo.Size = new System.Drawing.Size(151, 17);
            this.radioButtonradioButtonPerifEsquerdo.TabIndex = 7;
            this.radioButtonradioButtonPerifEsquerdo.TabStop = true;
            this.radioButtonradioButtonPerifEsquerdo.Tag = "CCS07";
            this.radioButtonradioButtonPerifEsquerdo.Text = "Membro superior Esquerdo";
            this.radioButtonradioButtonPerifEsquerdo.UseVisualStyleBackColor = true;
            // 
            // radioButtonPerifDireito
            // 
            this.radioButtonPerifDireito.AutoSize = true;
            this.radioButtonPerifDireito.Location = new System.Drawing.Point(108, 15);
            this.radioButtonPerifDireito.Name = "radioButtonPerifDireito";
            this.radioButtonPerifDireito.Size = new System.Drawing.Size(136, 17);
            this.radioButtonPerifDireito.TabIndex = 6;
            this.radioButtonPerifDireito.TabStop = true;
            this.radioButtonPerifDireito.Tag = "CCS06";
            this.radioButtonPerifDireito.Text = "Membro superior Direito";
            this.radioButtonPerifDireito.UseVisualStyleBackColor = true;
            // 
            // radioButtonCVC
            // 
            this.radioButtonCVC.AutoSize = true;
            this.radioButtonCVC.Location = new System.Drawing.Point(173, 20);
            this.radioButtonCVC.Name = "radioButtonCVC";
            this.radioButtonCVC.Size = new System.Drawing.Size(46, 17);
            this.radioButtonCVC.TabIndex = 2;
            this.radioButtonCVC.TabStop = true;
            this.radioButtonCVC.Tag = "CCS02";
            this.radioButtonCVC.Text = "CVC";
            this.radioButtonCVC.UseVisualStyleBackColor = true;
            // 
            // gPaciente
            // 
            this.gPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gPaciente.Controls.Add(this.label8);
            this.gPaciente.Controls.Add(this.comboBoxDataSae);
            this.gPaciente.Controls.Add(this.panel9);
            this.gPaciente.Controls.Add(this.label1);
            this.gPaciente.Controls.Add(this.textBoxEnfermeira);
            this.gPaciente.Controls.Add(this.pictureBox3);
            this.gPaciente.Controls.Add(this.panel5);
            this.gPaciente.Controls.Add(this.label7);
            this.gPaciente.Controls.Add(this.textData);
            this.gPaciente.Controls.Add(this.pictureBox2);
            this.gPaciente.Controls.Add(this.panel4);
            this.gPaciente.Controls.Add(this.label2);
            this.gPaciente.Controls.Add(this.textProntuario);
            this.gPaciente.Controls.Add(this.panel8);
            this.gPaciente.Controls.Add(this.label11);
            this.gPaciente.Controls.Add(this.panel7);
            this.gPaciente.Controls.Add(this.textBoxQuarto);
            this.gPaciente.Controls.Add(this.label10);
            this.gPaciente.Controls.Add(this.panel6);
            this.gPaciente.Controls.Add(this.textBoxSetor);
            this.gPaciente.Controls.Add(this.label9);
            this.gPaciente.Controls.Add(this.textLeito);
            this.gPaciente.Controls.Add(this.panel3);
            this.gPaciente.Controls.Add(this.panel2);
            this.gPaciente.Controls.Add(this.label6);
            this.gPaciente.Controls.Add(this.textIdade);
            this.gPaciente.Controls.Add(this.textPaciente);
            this.gPaciente.Controls.Add(this.pictureBox1);
            this.gPaciente.Controls.Add(this.rdoFerminino);
            this.gPaciente.Controls.Add(this.rdoMasculino);
            this.gPaciente.Controls.Add(this.pictureBox4);
            this.gPaciente.ForeColor = System.Drawing.Color.Black;
            this.gPaciente.Location = new System.Drawing.Point(2, 4);
            this.gPaciente.Name = "gPaciente";
            this.gPaciente.Size = new System.Drawing.Size(854, 186);
            this.gPaciente.TabIndex = 96;
            this.gPaciente.TabStop = false;
            this.gPaciente.Tag = "a1";
            this.gPaciente.Text = " Paciente ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.label8.Location = new System.Drawing.Point(574, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 1001;
            this.label8.Text = "Data Histórico";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DimGray;
            this.panel9.Location = new System.Drawing.Point(17, 62);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(363, 1);
            this.panel9.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(87)))), ((int)(((byte)(134)))));
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Enfermeiro(a)";
            // 
            // textBoxEnfermeira
            // 
            this.textBoxEnfermeira.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxEnfermeira.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEnfermeira.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxEnfermeira.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnfermeira.Location = new System.Drawing.Point(48, 47);
            this.textBoxEnfermeira.Name = "textBoxEnfermeira";
            this.textBoxEnfermeira.ReadOnly = true;
            this.textBoxEnfermeira.Size = new System.Drawing.Size(326, 13);
            this.textBoxEnfermeira.TabIndex = 48;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AppInternacao.Properties.Resources.nurse_person_woman_people_1697;
            this.pictureBox3.Location = new System.Drawing.Point(15, 36);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 51;
            this.pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.panel5.Location = new System.Drawing.Point(233, 173);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(147, 1);
            this.panel5.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Data";
            // 
            // textData
            // 
            this.textData.BackColor = System.Drawing.SystemColors.Control;
            this.textData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textData.Location = new System.Drawing.Point(267, 158);
            this.textData.MaxLength = 2;
            this.textData.Name = "textData";
            this.textData.ReadOnly = true;
            this.textData.Size = new System.Drawing.Size(97, 13);
            this.textData.TabIndex = 45;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AppInternacao.Properties.Resources.Barcode_27025;
            this.pictureBox2.Location = new System.Drawing.Point(12, 148);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Location = new System.Drawing.Point(18, 173);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(192, 1);
            this.panel4.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "NÚMERO DE PRONTUÁRIO";
            // 
            // textProntuario
            // 
            this.textProntuario.BackColor = System.Drawing.SystemColors.Control;
            this.textProntuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textProntuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textProntuario.Enabled = false;
            this.textProntuario.Location = new System.Drawing.Point(45, 158);
            this.textProntuario.Name = "textProntuario";
            this.textProntuario.ReadOnly = true;
            this.textProntuario.Size = new System.Drawing.Size(154, 13);
            this.textProntuario.TabIndex = 41;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DimGray;
            this.panel8.Location = new System.Drawing.Point(583, 107);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(99, 1);
            this.panel8.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(580, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Quarto";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DimGray;
            this.panel7.Location = new System.Drawing.Point(698, 107);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(138, 1);
            this.panel7.TabIndex = 40;
            // 
            // textBoxQuarto
            // 
            this.textBoxQuarto.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxQuarto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxQuarto.Location = new System.Drawing.Point(583, 92);
            this.textBoxQuarto.MaxLength = 2;
            this.textBoxQuarto.Name = "textBoxQuarto";
            this.textBoxQuarto.ReadOnly = true;
            this.textBoxQuarto.Size = new System.Drawing.Size(95, 13);
            this.textBoxQuarto.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(697, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Unidade Funcional";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DimGray;
            this.panel6.Location = new System.Drawing.Point(471, 107);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(99, 1);
            this.panel6.TabIndex = 34;
            // 
            // textBoxSetor
            // 
            this.textBoxSetor.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxSetor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSetor.Location = new System.Drawing.Point(700, 92);
            this.textBoxSetor.MaxLength = 2;
            this.textBoxSetor.Name = "textBoxSetor";
            this.textBoxSetor.ReadOnly = true;
            this.textBoxSetor.Size = new System.Drawing.Size(134, 13);
            this.textBoxSetor.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(468, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Leito";
            // 
            // textLeito
            // 
            this.textLeito.BackColor = System.Drawing.SystemColors.Control;
            this.textLeito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textLeito.Location = new System.Drawing.Point(471, 92);
            this.textLeito.MaxLength = 2;
            this.textLeito.Name = "textLeito";
            this.textLeito.ReadOnly = true;
            this.textLeito.Size = new System.Drawing.Size(95, 13);
            this.textLeito.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(399, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(55, 1);
            this.panel3.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(19, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(362, 1);
            this.panel2.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Idade";
            // 
            // textIdade
            // 
            this.textIdade.BackColor = System.Drawing.SystemColors.Control;
            this.textIdade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textIdade.Location = new System.Drawing.Point(399, 92);
            this.textIdade.MaxLength = 2;
            this.textIdade.Name = "textIdade";
            this.textIdade.ReadOnly = true;
            this.textIdade.Size = new System.Drawing.Size(51, 13);
            this.textIdade.TabIndex = 26;
            // 
            // textPaciente
            // 
            this.textPaciente.BackColor = System.Drawing.SystemColors.Control;
            this.textPaciente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPaciente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textPaciente.Location = new System.Drawing.Point(50, 92);
            this.textPaciente.Name = "textPaciente";
            this.textPaciente.ReadOnly = true;
            this.textPaciente.Size = new System.Drawing.Size(325, 13);
            this.textPaciente.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // rdoFerminino
            // 
            this.rdoFerminino.AutoSize = true;
            this.rdoFerminino.Enabled = false;
            this.rdoFerminino.Location = new System.Drawing.Point(483, 157);
            this.rdoFerminino.Name = "rdoFerminino";
            this.rdoFerminino.Size = new System.Drawing.Size(70, 17);
            this.rdoFerminino.TabIndex = 2;
            this.rdoFerminino.TabStop = true;
            this.rdoFerminino.Tag = "F";
            this.rdoFerminino.Text = "Ferminino";
            this.rdoFerminino.UseVisualStyleBackColor = true;
            // 
            // rdoMasculino
            // 
            this.rdoMasculino.AutoSize = true;
            this.rdoMasculino.Enabled = false;
            this.rdoMasculino.Location = new System.Drawing.Point(407, 157);
            this.rdoMasculino.Name = "rdoMasculino";
            this.rdoMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdoMasculino.TabIndex = 1;
            this.rdoMasculino.TabStop = true;
            this.rdoMasculino.Tag = "M";
            this.rdoMasculino.Text = "Masculino";
            this.rdoMasculino.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::AppInternacao.Properties.Resources.calendar_40619;
            this.pictureBox4.Location = new System.Drawing.Point(231, 148);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(33, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 52;
            this.pictureBox4.TabStop = false;
            // 
            // radioButtonPICC
            // 
            this.radioButtonPICC.AutoSize = true;
            this.radioButtonPICC.Location = new System.Drawing.Point(229, 20);
            this.radioButtonPICC.Name = "radioButtonPICC";
            this.radioButtonPICC.Size = new System.Drawing.Size(49, 17);
            this.radioButtonPICC.TabIndex = 3;
            this.radioButtonPICC.TabStop = true;
            this.radioButtonPICC.Tag = "CCS03";
            this.radioButtonPICC.Text = "PICC";
            this.radioButtonPICC.UseVisualStyleBackColor = true;
            // 
            // radioButtonSemImp
            // 
            this.radioButtonSemImp.AutoSize = true;
            this.radioButtonSemImp.Location = new System.Drawing.Point(283, 20);
            this.radioButtonSemImp.Name = "radioButtonSemImp";
            this.radioButtonSemImp.Size = new System.Drawing.Size(110, 17);
            this.radioButtonSemImp.TabIndex = 4;
            this.radioButtonSemImp.TabStop = true;
            this.radioButtonSemImp.Tag = "CCS04";
            this.radioButtonSemImp.Text = "Semi-Implantáveis";
            this.radioButtonSemImp.UseVisualStyleBackColor = true;
            // 
            // radioButtonTotalImp
            // 
            this.radioButtonTotalImp.AutoSize = true;
            this.radioButtonTotalImp.Location = new System.Drawing.Point(398, 20);
            this.radioButtonTotalImp.Name = "radioButtonTotalImp";
            this.radioButtonTotalImp.Size = new System.Drawing.Size(140, 17);
            this.radioButtonTotalImp.TabIndex = 5;
            this.radioButtonTotalImp.TabStop = true;
            this.radioButtonTotalImp.Tag = "CCS05";
            this.radioButtonTotalImp.Text = "Totalmente Implantáveis";
            this.radioButtonTotalImp.UseVisualStyleBackColor = true;
            // 
            // radioButtonJelco
            // 
            this.radioButtonJelco.AutoSize = true;
            this.radioButtonJelco.Location = new System.Drawing.Point(109, 20);
            this.radioButtonJelco.Name = "radioButtonJelco";
            this.radioButtonJelco.Size = new System.Drawing.Size(50, 17);
            this.radioButtonJelco.TabIndex = 1;
            this.radioButtonJelco.TabStop = true;
            this.radioButtonJelco.Tag = "CCS01";
            this.radioButtonJelco.Text = "Jelco";
            this.radioButtonJelco.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Catetere Central:";
            // 
            // gCateteres
            // 
            this.gCateteres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gCateteres.AutoSize = true;
            this.gCateteres.Controls.Add(this.panel11);
            this.gCateteres.Controls.Add(this.label14);
            this.gCateteres.Controls.Add(this.textBoxPad);
            this.gCateteres.Controls.Add(this.panel10);
            this.gCateteres.Controls.Add(this.label13);
            this.gCateteres.Controls.Add(this.textBoxPas);
            this.gCateteres.Controls.Add(this.label12);
            this.gCateteres.Controls.Add(this.comboBoxPressaoArterial);
            this.gCateteres.Controls.Add(this.panel1);
            this.gCateteres.Controls.Add(this.radioButtonCVC);
            this.gCateteres.Controls.Add(this.radioButtonPICC);
            this.gCateteres.Controls.Add(this.radioButtonSemImp);
            this.gCateteres.Controls.Add(this.radioButtonTotalImp);
            this.gCateteres.Controls.Add(this.radioButtonJelco);
            this.gCateteres.Controls.Add(this.label3);
            this.gCateteres.Location = new System.Drawing.Point(2, 200);
            this.gCateteres.Name = "gCateteres";
            this.gCateteres.Size = new System.Drawing.Size(854, 122);
            this.gCateteres.TabIndex = 99;
            this.gCateteres.TabStop = false;
            this.gCateteres.Text = " Controle de Cateteres e Sonda ";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.DimGray;
            this.panel11.Location = new System.Drawing.Point(728, 102);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(55, 1);
            this.panel11.TabIndex = 1008;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(725, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 1007;
            this.label14.Text = "PAD";
            // 
            // textBoxPad
            // 
            this.textBoxPad.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxPad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPad.Location = new System.Drawing.Point(728, 87);
            this.textBoxPad.MaxLength = 2;
            this.textBoxPad.Name = "textBoxPad";
            this.textBoxPad.ReadOnly = true;
            this.textBoxPad.Size = new System.Drawing.Size(51, 13);
            this.textBoxPad.TabIndex = 1006;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DimGray;
            this.panel10.Location = new System.Drawing.Point(649, 102);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(55, 1);
            this.panel10.TabIndex = 1005;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(648, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 1004;
            this.label13.Text = "PAS";
            // 
            // textBoxPas
            // 
            this.textBoxPas.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxPas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPas.Location = new System.Drawing.Point(649, 87);
            this.textBoxPas.MaxLength = 2;
            this.textBoxPas.Name = "textBoxPas";
            this.textBoxPas.ReadOnly = true;
            this.textBoxPas.Size = new System.Drawing.Size(51, 13);
            this.textBoxPas.TabIndex = 1003;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(646, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 13);
            this.label12.TabIndex = 1002;
            this.label12.Text = " Escala de Pressão Arterial";
            // 
            // comboBoxPressaoArterial
            // 
            this.comboBoxPressaoArterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPressaoArterial.FormattingEnabled = true;
            this.comboBoxPressaoArterial.Location = new System.Drawing.Point(649, 41);
            this.comboBoxPressaoArterial.Name = "comboBoxPressaoArterial";
            this.comboBoxPressaoArterial.Size = new System.Drawing.Size(130, 21);
            this.comboBoxPressaoArterial.TabIndex = 1001;
            this.comboBoxPressaoArterial.TabStop = false;
            this.comboBoxPressaoArterial.SelectedIndexChanged += new System.EventHandler(this.comboBoxPressaoArterial_SelectedIndexChanged);
            // 
            // rdoHiperTermica
            // 
            this.rdoHiperTermica.AutoSize = true;
            this.rdoHiperTermica.Location = new System.Drawing.Point(649, 19);
            this.rdoHiperTermica.Name = "rdoHiperTermica";
            this.rdoHiperTermica.Size = new System.Drawing.Size(84, 17);
            this.rdoHiperTermica.TabIndex = 55;
            this.rdoHiperTermica.TabStop = true;
            this.rdoHiperTermica.Tag = "P09";
            this.rdoHiperTermica.Text = "Hipertérmica";
            this.rdoHiperTermica.UseVisualStyleBackColor = true;
            // 
            // rdoPeleHipotermica
            // 
            this.rdoPeleHipotermica.AutoSize = true;
            this.rdoPeleHipotermica.Location = new System.Drawing.Point(489, 19);
            this.rdoPeleHipotermica.Name = "rdoPeleHipotermica";
            this.rdoPeleHipotermica.Size = new System.Drawing.Size(81, 17);
            this.rdoPeleHipotermica.TabIndex = 53;
            this.rdoPeleHipotermica.TabStop = true;
            this.rdoPeleHipotermica.Tag = "P07";
            this.rdoPeleHipotermica.Text = "Hipotérmico";
            this.rdoPeleHipotermica.UseVisualStyleBackColor = true;
            // 
            // rdoPeleAfebril
            // 
            this.rdoPeleAfebril.AutoSize = true;
            this.rdoPeleAfebril.Location = new System.Drawing.Point(581, 19);
            this.rdoPeleAfebril.Name = "rdoPeleAfebril";
            this.rdoPeleAfebril.Size = new System.Drawing.Size(54, 17);
            this.rdoPeleAfebril.TabIndex = 54;
            this.rdoPeleAfebril.TabStop = true;
            this.rdoPeleAfebril.Tag = "P08";
            this.rdoPeleAfebril.Text = "Afebril";
            this.rdoPeleAfebril.UseVisualStyleBackColor = true;
            // 
            // rdoAniterica
            // 
            this.rdoAniterica.AutoSize = true;
            this.rdoAniterica.Location = new System.Drawing.Point(411, 19);
            this.rdoAniterica.Name = "rdoAniterica";
            this.rdoAniterica.Size = new System.Drawing.Size(66, 17);
            this.rdoAniterica.TabIndex = 52;
            this.rdoAniterica.TabStop = true;
            this.rdoAniterica.Tag = "P06";
            this.rdoAniterica.Text = "Anitérica";
            this.rdoAniterica.UseVisualStyleBackColor = true;
            // 
            // rdoNormacorada
            // 
            this.rdoNormacorada.AutoSize = true;
            this.rdoNormacorada.Location = new System.Drawing.Point(6, 19);
            this.rdoNormacorada.Name = "rdoNormacorada";
            this.rdoNormacorada.Size = new System.Drawing.Size(89, 17);
            this.rdoNormacorada.TabIndex = 47;
            this.rdoNormacorada.TabStop = true;
            this.rdoNormacorada.Tag = "P01";
            this.rdoNormacorada.Text = "Normacorada";
            this.rdoNormacorada.UseVisualStyleBackColor = true;
            // 
            // rdoIcteríca
            // 
            this.rdoIcteríca.AutoSize = true;
            this.rdoIcteríca.Location = new System.Drawing.Point(338, 19);
            this.rdoIcteríca.Name = "rdoIcteríca";
            this.rdoIcteríca.Size = new System.Drawing.Size(60, 17);
            this.rdoIcteríca.TabIndex = 51;
            this.rdoIcteríca.TabStop = true;
            this.rdoIcteríca.Tag = "P05";
            this.rdoIcteríca.Text = "Ictérica";
            this.rdoIcteríca.UseVisualStyleBackColor = true;
            // 
            // rdoHipocorada
            // 
            this.rdoHipocorada.AutoSize = true;
            this.rdoHipocorada.Location = new System.Drawing.Point(101, 19);
            this.rdoHipocorada.Name = "rdoHipocorada";
            this.rdoHipocorada.Size = new System.Drawing.Size(80, 17);
            this.rdoHipocorada.TabIndex = 48;
            this.rdoHipocorada.TabStop = true;
            this.rdoHipocorada.Tag = "P02";
            this.rdoHipocorada.Text = "Hipocorada";
            this.rdoHipocorada.UseVisualStyleBackColor = true;
            // 
            // rdoCinotica
            // 
            this.rdoCinotica.AutoSize = true;
            this.rdoCinotica.Location = new System.Drawing.Point(262, 19);
            this.rdoCinotica.Name = "rdoCinotica";
            this.rdoCinotica.Size = new System.Drawing.Size(63, 17);
            this.rdoCinotica.TabIndex = 50;
            this.rdoCinotica.TabStop = true;
            this.rdoCinotica.Tag = "P04";
            this.rdoCinotica.Text = "Cinótica";
            this.rdoCinotica.UseVisualStyleBackColor = true;
            // 
            // rdoAcinotica
            // 
            this.rdoAcinotica.AutoSize = true;
            this.rdoAcinotica.Location = new System.Drawing.Point(187, 19);
            this.rdoAcinotica.Name = "rdoAcinotica";
            this.rdoAcinotica.Size = new System.Drawing.Size(69, 17);
            this.rdoAcinotica.TabIndex = 49;
            this.rdoAcinotica.TabStop = true;
            this.rdoAcinotica.Tag = "P03";
            this.rdoAcinotica.Text = "Acinótica";
            this.rdoAcinotica.UseVisualStyleBackColor = true;
            // 
            // gPele
            // 
            this.gPele.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gPele.AutoSize = true;
            this.gPele.Controls.Add(this.rdoHiperTermica);
            this.gPele.Controls.Add(this.rdoPeleHipotermica);
            this.gPele.Controls.Add(this.rdoPeleAfebril);
            this.gPele.Controls.Add(this.rdoAniterica);
            this.gPele.Controls.Add(this.rdoNormacorada);
            this.gPele.Controls.Add(this.rdoIcteríca);
            this.gPele.Controls.Add(this.rdoHipocorada);
            this.gPele.Controls.Add(this.rdoCinotica);
            this.gPele.Controls.Add(this.rdoAcinotica);
            this.gPele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gPele.Location = new System.Drawing.Point(2, 680);
            this.gPele.Name = "gPele";
            this.gPele.Size = new System.Drawing.Size(854, 55);
            this.gPele.TabIndex = 107;
            this.gPele.TabStop = false;
            this.gPele.Text = "Pele";
            // 
            // gPupilas
            // 
            this.gPupilas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gPupilas.AutoSize = true;
            this.gPupilas.Controls.Add(this.rdoAnisocorica);
            this.gPupilas.Controls.Add(this.rdoMiotica);
            this.gPupilas.Controls.Add(this.rdoIsocorica);
            this.gPupilas.Controls.Add(this.rdoMidriatica);
            this.gPupilas.Controls.Add(this.rdoNaoReagente);
            this.gPupilas.Controls.Add(this.rdoFotorreagente);
            this.gPupilas.Location = new System.Drawing.Point(2, 442);
            this.gPupilas.Name = "gPupilas";
            this.gPupilas.Size = new System.Drawing.Size(854, 55);
            this.gPupilas.TabIndex = 102;
            this.gPupilas.TabStop = false;
            this.gPupilas.Text = " Pupilas ";
            // 
            // rdoAnisocorica
            // 
            this.rdoAnisocorica.AutoSize = true;
            this.rdoAnisocorica.Location = new System.Drawing.Point(501, 19);
            this.rdoAnisocorica.Name = "rdoAnisocorica";
            this.rdoAnisocorica.Size = new System.Drawing.Size(85, 17);
            this.rdoAnisocorica.TabIndex = 29;
            this.rdoAnisocorica.TabStop = true;
            this.rdoAnisocorica.Tag = "P06";
            this.rdoAnisocorica.Text = "Anisocóricas";
            this.rdoAnisocorica.UseVisualStyleBackColor = true;
            // 
            // rdoMiotica
            // 
            this.rdoMiotica.AutoSize = true;
            this.rdoMiotica.Location = new System.Drawing.Point(6, 19);
            this.rdoMiotica.Name = "rdoMiotica";
            this.rdoMiotica.Size = new System.Drawing.Size(59, 17);
            this.rdoMiotica.TabIndex = 24;
            this.rdoMiotica.TabStop = true;
            this.rdoMiotica.Tag = "P01";
            this.rdoMiotica.Text = "Miótica";
            this.rdoMiotica.UseVisualStyleBackColor = true;
            // 
            // rdoIsocorica
            // 
            this.rdoIsocorica.AutoSize = true;
            this.rdoIsocorica.Location = new System.Drawing.Point(408, 19);
            this.rdoIsocorica.Name = "rdoIsocorica";
            this.rdoIsocorica.Size = new System.Drawing.Size(73, 17);
            this.rdoIsocorica.TabIndex = 28;
            this.rdoIsocorica.TabStop = true;
            this.rdoIsocorica.Tag = "P05";
            this.rdoIsocorica.Text = "Isocóricas";
            this.rdoIsocorica.UseVisualStyleBackColor = true;
            // 
            // rdoMidriatica
            // 
            this.rdoMidriatica.AutoSize = true;
            this.rdoMidriatica.Location = new System.Drawing.Point(92, 19);
            this.rdoMidriatica.Name = "rdoMidriatica";
            this.rdoMidriatica.Size = new System.Drawing.Size(70, 17);
            this.rdoMidriatica.TabIndex = 25;
            this.rdoMidriatica.TabStop = true;
            this.rdoMidriatica.Tag = "P02";
            this.rdoMidriatica.Text = "Midriática";
            this.rdoMidriatica.UseVisualStyleBackColor = true;
            // 
            // rdoNaoReagente
            // 
            this.rdoNaoReagente.AutoSize = true;
            this.rdoNaoReagente.Location = new System.Drawing.Point(297, 19);
            this.rdoNaoReagente.Name = "rdoNaoReagente";
            this.rdoNaoReagente.Size = new System.Drawing.Size(95, 17);
            this.rdoNaoReagente.TabIndex = 27;
            this.rdoNaoReagente.TabStop = true;
            this.rdoNaoReagente.Tag = "P04";
            this.rdoNaoReagente.Text = "Não Reagente";
            this.rdoNaoReagente.UseVisualStyleBackColor = true;
            // 
            // rdoFotorreagente
            // 
            this.rdoFotorreagente.AutoSize = true;
            this.rdoFotorreagente.Location = new System.Drawing.Point(182, 19);
            this.rdoFotorreagente.Name = "rdoFotorreagente";
            this.rdoFotorreagente.Size = new System.Drawing.Size(96, 17);
            this.rdoFotorreagente.TabIndex = 26;
            this.rdoFotorreagente.TabStop = true;
            this.rdoFotorreagente.Tag = "P03";
            this.rdoFotorreagente.Text = "Fotorreagentes";
            this.rdoFotorreagente.UseVisualStyleBackColor = true;
            // 
            // rdoMascaraVenturi
            // 
            this.rdoMascaraVenturi.AutoSize = true;
            this.rdoMascaraVenturi.Location = new System.Drawing.Point(562, 19);
            this.rdoMascaraVenturi.Name = "rdoMascaraVenturi";
            this.rdoMascaraVenturi.Size = new System.Drawing.Size(102, 17);
            this.rdoMascaraVenturi.TabIndex = 44;
            this.rdoMascaraVenturi.TabStop = true;
            this.rdoMascaraVenturi.Tag = "O07";
            this.rdoMascaraVenturi.Text = "Mascara Venturi";
            this.rdoMascaraVenturi.UseVisualStyleBackColor = true;
            // 
            // gOxigenacao
            // 
            this.gOxigenacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gOxigenacao.AutoSize = true;
            this.gOxigenacao.Controls.Add(this.rdoMascaraVenturi);
            this.gOxigenacao.Controls.Add(this.rdoIntubacao);
            this.gOxigenacao.Controls.Add(this.rdoArAmbiente);
            this.gOxigenacao.Controls.Add(this.rdoEupneico);
            this.gOxigenacao.Controls.Add(this.rdoOxigenioterapia);
            this.gOxigenacao.Controls.Add(this.rdoBradipneico);
            this.gOxigenacao.Controls.Add(this.rdoDispineico);
            this.gOxigenacao.Controls.Add(this.rdoTraquipineico);
            this.gOxigenacao.Location = new System.Drawing.Point(2, 598);
            this.gOxigenacao.Name = "gOxigenacao";
            this.gOxigenacao.Size = new System.Drawing.Size(854, 65);
            this.gOxigenacao.TabIndex = 105;
            this.gOxigenacao.TabStop = false;
            this.gOxigenacao.Text = " Oxigenação ";
            // 
            // rdoIntubacao
            // 
            this.rdoIntubacao.AutoSize = true;
            this.rdoIntubacao.Location = new System.Drawing.Point(675, 19);
            this.rdoIntubacao.Name = "rdoIntubacao";
            this.rdoIntubacao.Size = new System.Drawing.Size(73, 17);
            this.rdoIntubacao.TabIndex = 45;
            this.rdoIntubacao.TabStop = true;
            this.rdoIntubacao.Tag = "O08";
            this.rdoIntubacao.Text = "Intubação";
            this.rdoIntubacao.UseVisualStyleBackColor = true;
            // 
            // rdoArAmbiente
            // 
            this.rdoArAmbiente.AutoSize = true;
            this.rdoArAmbiente.Location = new System.Drawing.Point(472, 19);
            this.rdoArAmbiente.Name = "rdoArAmbiente";
            this.rdoArAmbiente.Size = new System.Drawing.Size(82, 17);
            this.rdoArAmbiente.TabIndex = 43;
            this.rdoArAmbiente.TabStop = true;
            this.rdoArAmbiente.Tag = "O06";
            this.rdoArAmbiente.Text = "Ar Ambiente";
            this.rdoArAmbiente.UseVisualStyleBackColor = true;
            // 
            // rdoEupneico
            // 
            this.rdoEupneico.AutoSize = true;
            this.rdoEupneico.Location = new System.Drawing.Point(6, 19);
            this.rdoEupneico.Name = "rdoEupneico";
            this.rdoEupneico.Size = new System.Drawing.Size(72, 17);
            this.rdoEupneico.TabIndex = 38;
            this.rdoEupneico.TabStop = true;
            this.rdoEupneico.Tag = "O01";
            this.rdoEupneico.Text = "Eupinéico";
            this.rdoEupneico.UseVisualStyleBackColor = true;
            // 
            // rdoOxigenioterapia
            // 
            this.rdoOxigenioterapia.AutoSize = true;
            this.rdoOxigenioterapia.Location = new System.Drawing.Point(365, 19);
            this.rdoOxigenioterapia.Name = "rdoOxigenioterapia";
            this.rdoOxigenioterapia.Size = new System.Drawing.Size(98, 17);
            this.rdoOxigenioterapia.TabIndex = 42;
            this.rdoOxigenioterapia.TabStop = true;
            this.rdoOxigenioterapia.Tag = "O05";
            this.rdoOxigenioterapia.Text = "Oxigenioterapia";
            this.rdoOxigenioterapia.UseVisualStyleBackColor = true;
            // 
            // rdoBradipneico
            // 
            this.rdoBradipneico.AutoSize = true;
            this.rdoBradipneico.Location = new System.Drawing.Point(92, 19);
            this.rdoBradipneico.Name = "rdoBradipneico";
            this.rdoBradipneico.Size = new System.Drawing.Size(81, 17);
            this.rdoBradipneico.TabIndex = 39;
            this.rdoBradipneico.TabStop = true;
            this.rdoBradipneico.Tag = "O02";
            this.rdoBradipneico.Text = "Bradpinéico";
            this.rdoBradipneico.UseVisualStyleBackColor = true;
            // 
            // rdoDispineico
            // 
            this.rdoDispineico.AutoSize = true;
            this.rdoDispineico.Location = new System.Drawing.Point(283, 19);
            this.rdoDispineico.Name = "rdoDispineico";
            this.rdoDispineico.Size = new System.Drawing.Size(74, 17);
            this.rdoDispineico.TabIndex = 41;
            this.rdoDispineico.TabStop = true;
            this.rdoDispineico.Tag = "O04";
            this.rdoDispineico.Text = "Dispinéico";
            this.rdoDispineico.UseVisualStyleBackColor = true;
            // 
            // rdoTraquipineico
            // 
            this.rdoTraquipineico.AutoSize = true;
            this.rdoTraquipineico.Location = new System.Drawing.Point(182, 19);
            this.rdoTraquipineico.Name = "rdoTraquipineico";
            this.rdoTraquipineico.Size = new System.Drawing.Size(89, 17);
            this.rdoTraquipineico.TabIndex = 40;
            this.rdoTraquipineico.TabStop = true;
            this.rdoTraquipineico.Tag = "O03";
            this.rdoTraquipineico.Text = "Traquipinéico";
            this.rdoTraquipineico.UseVisualStyleBackColor = true;
            // 
            // gStatusTermico
            // 
            this.gStatusTermico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gStatusTermico.AutoSize = true;
            this.gStatusTermico.Controls.Add(this.rdoFebril);
            this.gStatusTermico.Controls.Add(this.rdoSubFebril);
            this.gStatusTermico.Controls.Add(this.rdoAfebril);
            this.gStatusTermico.Controls.Add(this.rdoHipotermico);
            this.gStatusTermico.Location = new System.Drawing.Point(2, 515);
            this.gStatusTermico.Name = "gStatusTermico";
            this.gStatusTermico.Size = new System.Drawing.Size(854, 64);
            this.gStatusTermico.TabIndex = 103;
            this.gStatusTermico.TabStop = false;
            this.gStatusTermico.Text = " Status Térmico ";
            // 
            // rdoFebril
            // 
            this.rdoFebril.AutoSize = true;
            this.rdoFebril.Location = new System.Drawing.Point(81, 20);
            this.rdoFebril.Name = "rdoFebril";
            this.rdoFebril.Size = new System.Drawing.Size(50, 17);
            this.rdoFebril.TabIndex = 35;
            this.rdoFebril.TabStop = true;
            this.rdoFebril.Tag = "ST04";
            this.rdoFebril.Text = "Febril";
            this.rdoFebril.UseVisualStyleBackColor = true;
            // 
            // rdoSubFebril
            // 
            this.rdoSubFebril.AutoSize = true;
            this.rdoSubFebril.Location = new System.Drawing.Point(242, 19);
            this.rdoSubFebril.Name = "rdoSubFebril";
            this.rdoSubFebril.Size = new System.Drawing.Size(72, 17);
            this.rdoSubFebril.TabIndex = 32;
            this.rdoSubFebril.TabStop = true;
            this.rdoSubFebril.Tag = "ST02";
            this.rdoSubFebril.Text = "Sub-Febril";
            this.rdoSubFebril.UseVisualStyleBackColor = true;
            // 
            // rdoAfebril
            // 
            this.rdoAfebril.AutoSize = true;
            this.rdoAfebril.Location = new System.Drawing.Point(6, 20);
            this.rdoAfebril.Name = "rdoAfebril";
            this.rdoAfebril.Size = new System.Drawing.Size(54, 17);
            this.rdoAfebril.TabIndex = 34;
            this.rdoAfebril.TabStop = true;
            this.rdoAfebril.Tag = "ST03";
            this.rdoAfebril.Text = "Afebril";
            this.rdoAfebril.UseVisualStyleBackColor = true;
            // 
            // rdoHipotermico
            // 
            this.rdoHipotermico.AutoSize = true;
            this.rdoHipotermico.Location = new System.Drawing.Point(150, 20);
            this.rdoHipotermico.Name = "rdoHipotermico";
            this.rdoHipotermico.Size = new System.Drawing.Size(81, 17);
            this.rdoHipotermico.TabIndex = 31;
            this.rdoHipotermico.TabStop = true;
            this.rdoHipotermico.Tag = "ST01";
            this.rdoHipotermico.Text = "Hipotérmico";
            this.rdoHipotermico.UseVisualStyleBackColor = true;
            // 
            // richTextBoxObservacoa
            // 
            this.richTextBoxObservacoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxObservacoa.Location = new System.Drawing.Point(23, 1282);
            this.richTextBoxObservacoa.Name = "richTextBoxObservacoa";
            this.richTextBoxObservacoa.ShowSelectionMargin = true;
            this.richTextBoxObservacoa.Size = new System.Drawing.Size(813, 76);
            this.richTextBoxObservacoa.TabIndex = 113;
            this.richTextBoxObservacoa.Text = "";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 1266);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(142, 13);
            this.label15.TabIndex = 114;
            this.label15.Text = "Observação de Enfermagem";
            // 
            // UCExameFisico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.label15);
            this.Controls.Add(this.richTextBoxObservacoa);
            this.Controls.Add(this.gPaciente);
            this.Controls.Add(this.gUcera);
            this.Controls.Add(this.gAbdominal);
            this.Controls.Add(this.gVascular);
            this.Controls.Add(this.gGastroIntestinal);
            this.Controls.Add(this.gSistemaNeurologico);
            this.Controls.Add(this.textAglergias);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gCateteres);
            this.Controls.Add(this.gPele);
            this.Controls.Add(this.gPupilas);
            this.Controls.Add(this.gOxigenacao);
            this.Controls.Add(this.gStatusTermico);
            this.Name = "UCExameFisico";
            this.Size = new System.Drawing.Size(863, 1367);
            this.Load += new System.EventHandler(this.UCSaeAdulto_Load);
            this.gRHA.ResumeLayout(false);
            this.gRHA.PerformLayout();
            this.gGavagem.ResumeLayout(false);
            this.gGavagem.PerformLayout();
            this.gEvacuacao.ResumeLayout(false);
            this.gEvacuacao.PerformLayout();
            this.gUcera.ResumeLayout(false);
            this.gUcera.PerformLayout();
            this.gAbdominal.ResumeLayout(false);
            this.gAbdominal.PerformLayout();
            this.gViceromegalia.ResumeLayout(false);
            this.gViceromegalia.PerformLayout();
            this.gVascular.ResumeLayout(false);
            this.gVascular.PerformLayout();
            this.gGastroIntestinal.ResumeLayout(false);
            this.gGastroIntestinal.PerformLayout();
            this.gUrina.ResumeLayout(false);
            this.gUrina.PerformLayout();
            this.gSistemaNeurologico.ResumeLayout(false);
            this.gSistemaNeurologico.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gPaciente.ResumeLayout(false);
            this.gPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.gCateteres.ResumeLayout(false);
            this.gCateteres.PerformLayout();
            this.gPele.ResumeLayout(false);
            this.gPele.PerformLayout();
            this.gPupilas.ResumeLayout(false);
            this.gPupilas.PerformLayout();
            this.gOxigenacao.ResumeLayout(false);
            this.gOxigenacao.PerformLayout();
            this.gStatusTermico.ResumeLayout(false);
            this.gStatusTermico.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoViceromegaliaAusente;
        private System.Windows.Forms.GroupBox gRHA;
        private System.Windows.Forms.RadioButton rdoRHAausente;
        private System.Windows.Forms.RadioButton rdoRHAPresente;
        private System.Windows.Forms.RadioButton rdoSngSog;
        private System.Windows.Forms.RadioButton rdoSneSoe;
        private System.Windows.Forms.RadioButton rdoVo;
        private System.Windows.Forms.GroupBox gGavagem;
        private System.Windows.Forms.RadioButton rdoEmese;
        private System.Windows.Forms.RadioButton rdoAberta;
        private System.Windows.Forms.RadioButton rdoConcavo;
        private System.Windows.Forms.RadioButton rdoNormoTenso;
        private System.Windows.Forms.GroupBox gEvacuacao;
        private System.Windows.Forms.RadioButton rdoAusente;
        private System.Windows.Forms.RadioButton rdoPresente;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton rdoTenso;
        private System.Windows.Forms.RadioButton rdoDistendido;
        private System.Windows.Forms.RadioButton rdoGloboso;
        private System.Windows.Forms.GroupBox gUcera;
        private System.Windows.Forms.RadioButton rdoGrau1;
        private System.Windows.Forms.RadioButton rdoGrau2;
        private System.Windows.Forms.RadioButton rdoGrau4;
        private System.Windows.Forms.RadioButton rdoGrau3;
        private System.Windows.Forms.RadioButton rdoViceromegaliaPresente;
        private System.Windows.Forms.RadioButton rdoColunia;
        private System.Windows.Forms.RadioButton rdoNtp;
        private System.Windows.Forms.GroupBox gAbdominal;
        private System.Windows.Forms.GroupBox gViceromegalia;
        private System.Windows.Forms.RadioButton rdoHematuria;
        private System.Windows.Forms.RadioButton rdoPoliuria;
        private System.Windows.Forms.RadioButton rdoOliguria;
        private System.Windows.Forms.RadioButton rdoDisuria;
        private System.Windows.Forms.RadioButton rdoAnuria;
        private System.Windows.Forms.RadioButton rdoUrinaAusente;
        private System.Windows.Forms.RadioButton rdoUrinaPresente;
        private System.Windows.Forms.ComboBox comboBoxDataSae;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.GroupBox gVascular;
        private System.Windows.Forms.GroupBox gGastroIntestinal;
        private System.Windows.Forms.GroupBox gUrina;
        private System.Windows.Forms.RadioButton rdoOrientado;
        private System.Windows.Forms.RadioButton rdoReageEstimulo;
        private System.Windows.Forms.RadioButton rdoComatoso;
        private System.Windows.Forms.RadioButton rdoSedado;
        private System.Windows.Forms.RadioButton rdoNaoReage;
        private System.Windows.Forms.RadioButton rdoAgitado;
        private System.Windows.Forms.RadioButton rdoTorporoso;
        private System.Windows.Forms.GroupBox gSistemaNeurologico;
        private System.Windows.Forms.RadioButton rdoDesorientado;
        private System.Windows.Forms.RadioButton rdoConciente;
        private System.Windows.Forms.TextBox textAglergias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonradioButtonPerifEsquerdo;
        private System.Windows.Forms.RadioButton radioButtonPerifDireito;
        private System.Windows.Forms.RadioButton radioButtonCVC;
        private System.Windows.Forms.GroupBox gPaciente;
        private System.Windows.Forms.RadioButton rdoFerminino;
        private System.Windows.Forms.RadioButton rdoMasculino;
        private System.Windows.Forms.RadioButton radioButtonPICC;
        private System.Windows.Forms.RadioButton radioButtonSemImp;
        private System.Windows.Forms.RadioButton radioButtonTotalImp;
        private System.Windows.Forms.RadioButton radioButtonJelco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gCateteres;
        private System.Windows.Forms.RadioButton rdoHiperTermica;
        private System.Windows.Forms.RadioButton rdoPeleHipotermica;
        private System.Windows.Forms.RadioButton rdoPeleAfebril;
        private System.Windows.Forms.RadioButton rdoAniterica;
        private System.Windows.Forms.RadioButton rdoNormacorada;
        private System.Windows.Forms.RadioButton rdoIcteríca;
        private System.Windows.Forms.RadioButton rdoHipocorada;
        private System.Windows.Forms.RadioButton rdoCinotica;
        private System.Windows.Forms.RadioButton rdoAcinotica;
        private System.Windows.Forms.GroupBox gPele;
        private System.Windows.Forms.GroupBox gPupilas;
        private System.Windows.Forms.RadioButton rdoAnisocorica;
        private System.Windows.Forms.RadioButton rdoMiotica;
        private System.Windows.Forms.RadioButton rdoIsocorica;
        private System.Windows.Forms.RadioButton rdoMidriatica;
        private System.Windows.Forms.RadioButton rdoNaoReagente;
        private System.Windows.Forms.RadioButton rdoFotorreagente;
        private System.Windows.Forms.RadioButton rdoMascaraVenturi;
        private System.Windows.Forms.GroupBox gOxigenacao;
        private System.Windows.Forms.RadioButton rdoIntubacao;
        private System.Windows.Forms.RadioButton rdoArAmbiente;
        private System.Windows.Forms.RadioButton rdoEupneico;
        private System.Windows.Forms.RadioButton rdoOxigenioterapia;
        private System.Windows.Forms.RadioButton rdoBradipneico;
        private System.Windows.Forms.RadioButton rdoDispineico;
        private System.Windows.Forms.RadioButton rdoTraquipineico;
        private System.Windows.Forms.GroupBox gStatusTermico;
        private System.Windows.Forms.RadioButton rdoFebril;
        private System.Windows.Forms.RadioButton rdoSubFebril;
        private System.Windows.Forms.RadioButton rdoAfebril;
        private System.Windows.Forms.RadioButton rdoHipotermico;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBoxQuarto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBoxSetor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textLeito;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textIdade;
        private System.Windows.Forms.TextBox textPaciente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEnfermeira;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textData;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textProntuario;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxPressaoArterial;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxPad;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxPas;
        private System.Windows.Forms.RichTextBox richTextBoxObservacoa;
        private System.Windows.Forms.Label label15;
    }
}
