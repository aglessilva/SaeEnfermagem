using AppInternacao.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace AppInternacao.FrmSae
{

    public partial class UCExameFisico : UserControl
    {
        ExameFisico saePaciente = null;


        List<object> pressaoArterial = new List<object>()
            {
             new {Codigo = 0, Titulo = "Selecione", Valor = "0"},
            new {Codigo = 1, Titulo = "Ótima", Valor = "< 120 X < 80"},
            new {Codigo = 2, Titulo ="Normal", Valor = "120 a 129 X 80 a 84" },
            new {Codigo = 3, Titulo = "Normal Alto",Valor = "130 a 139 X 85 a 89" },
            new {Codigo = 4, Titulo = "Estágio 1", Valor = "140 a 159 X 90 a 99" },
            new {Codigo = 5, Titulo = "Estágio 2", Valor = "160 a 179 X 100 a 109" },
            new {Codigo = 6, Titulo = "Estágio 3", Valor = ">= 180 X >= 110" }
        };

        public UCExameFisico()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public UCExameFisico(long _prountuario)
        {
            InitializeComponent();
            textProntuario.Text = _prountuario.ToString();
            Dock = DockStyle.Fill;
        }

       

        public void Button1_Click(object sender, EventArgs e)
        {
           saePaciente = new ExameFisico();

            try
            {
                // *** GRUPO PACIENTE ****
                ExameFisico exeme = Salvar(this);

            }
            catch (Exception)
            {

                throw;
            }

        }
        private ExameFisico Salvar(Control control)
        {
            string valuesRadio = string.Empty;
            string[] msg = { " Controle de Cateteres e Sonda ", " Sistema Neurológico ", " Pupilas ", " Status Térmico ", " Oxigenação "," Pele ", " GASTROINTESTINAL ", " Regulação Abdominal ", " Regulação Vascular ", " Úcera por Compressão " };
            bool[] validar = { false, false, false, false, false, false, false, false, false, false};

            ExameFisico saePaciente = new ExameFisico();
            try
            {
                saePaciente.Cliente.Prontuario = Convert.ToInt64(textProntuario.Text);
               // saePaciente.PA = mskPA.Text;
                saePaciente.DataExameFisico = DateTime.Now;
                saePaciente.Alergia = textAglergias.Text;
                RadioButton radio = null;

                foreach (Control itemControl in control.Controls)
                {
                    if (itemControl is GroupBox)
                    {
                        if (itemControl.Name.Equals("gCateteres"))
                        {
                            bool[] ret = { false, false };
                            radio = itemControl.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                            if (radio != null)
                            {
                                saePaciente.Sonda.CateterCentral = radio.Tag.ToString();
                                ret[0] = true;
                            }

                            radio = panel1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                            if (radio != null)
                            {
                                saePaciente.Sonda.CateterPeriferico = radio.Tag.ToString();
                                ret[1] = true;
                            }

                            validar[0] = ret.ToList().TrueForAll(i => i);
                        }
                        if (itemControl.Name.Equals("gSistemaNeurologico"))
                        {
                            radio = itemControl.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                            if (radio != null)
                            {
                                saePaciente.SistemaNeurologico = radio.Tag.ToString();
                                validar[1] = true;
                            }
                        }
                        if (itemControl.Name.Equals("gPupilas"))
                        {
                            radio = itemControl.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                            if (radio != null)
                            {
                                saePaciente.Pupilas = radio.Tag.ToString();
                                validar[2] = true;
                            }
                        }
                        if (itemControl.Name.Equals("gStatusTermico"))
                        {
                            radio = itemControl.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                            if(radio != null)
                            {
                                saePaciente.SituacaoTermica = radio.Tag.ToString();
                                validar[3] = true;
                            }
                          //  saePaciente.SituacaoTermica.Temperatura = string.IsNullOrWhiteSpace(Regex.Replace(mskStatusTermico1.Text, @"[^0-9$]", "")) ? Regex.Replace(mskStatusTermico2.Text, @"[^0-9$]", "") : Regex.Replace(mskStatusTermico1.Text, @"[^0-9$]", "");
                           
                        }
                        if (itemControl.Name.Equals("gOxigenacao"))
                        {
                            radio = itemControl.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                            if (radio != null)
                            {
                                saePaciente.Oxigenacao = radio.Tag.ToString();
                                validar[4] = true;
                            }
                        }
                        if (itemControl.Name.Equals("gPele"))
                        {
                            radio = itemControl.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                            if (radio != null)
                            {
                                saePaciente.Pele = radio.Tag.ToString();
                                validar[5] = true;
                            }
                        }

                        if (itemControl.Name.Equals("gGastroIntestinal"))
                        {
                            bool[] ret = { false, false, false, false };
                            radio = itemControl.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                            if(radio != null)
                            {
                                saePaciente.GastroIntestinal.Sistema = radio.Tag.ToString();
                                ret[0] = true;
                            }

                            radio = gGavagem.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                            if(radio != null)
                            {
                                saePaciente.GastroIntestinal.Gavagem = radio.Tag.ToString();
                                ret[1] = true;
                            }

                            radio = gEvacuacao.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                            if (radio != null)
                            {
                                saePaciente.GastroIntestinal.Evacuacao = radio.Tag.ToString();
                                ret[2] = true;
                            }

                            radio = gUrina.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                            if(radio != null)
                            {
                                saePaciente.GastroIntestinal.Urina = radio.Tag.ToString();
                                ret[3] = true;
                            }

                            validar[6] = ret.ToList().TrueForAll(gg => gg);
                        }

                        if (itemControl.Name.Equals("gAbdominal"))
                        {
                            bool[] ret = { false, false, false };
                            radio = itemControl.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                            if(radio != null)
                            {
                                saePaciente.Abdominal.RegulacaoAbdominal = radio.Tag.ToString();
                                ret[0] = true;
                            }

                            radio = gRHA.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                            if(radio != null)
                            {
                                saePaciente.Abdominal.RHA = radio.Tag.ToString();
                                ret[1] = true;
                            }

                            radio = gViceromegalia.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                            if(radio != null)
                            {
                                saePaciente.Abdominal.Viceromegalias = radio.Tag.ToString();
                                ret[2] = true;
                            }

                            validar[7] = ret.ToList().TrueForAll(gg => gg);
                        }

                        if (itemControl.Name.Equals("gVascular"))
                        {
                            radio = itemControl.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                            if (radio != null)
                            {
                                saePaciente.Vascular = radio.Tag.ToString();
                                validar[8] = true;
                            }
                        }

                        if (itemControl.Name.Equals("gUcera"))
                        {
                            radio = itemControl.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                            if (radio != null)
                            {
                                saePaciente.Ucera = radio.Tag.ToString();
                                validar[9] = true;
                            }
                        }
                    }
                }


                if(!validar.ToList().TrueForAll(k => k))
                {
                    int indice = validar.ToList().FindIndex(m => !m);
                    MessageBox.Show($"Verifique a área do formulário ({msg[indice]})", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return null;
                }
                return saePaciente;
            }
            catch (Exception exErro)
            {
                throw new Exception("Erro ao tentar salva: " + exErro.Message);
            }
        }

        private void UCSaeAdulto_Load(object sender, EventArgs e)
        {
            FrmMain.mySalvar.Click += new EventHandler(Button1_Click);
            textData.Text = DateTime.Now.ToShortDateString();
            new ToolTip() { IsBalloon = true, UseAnimation = true, UseFading = true }.SetToolTip(textBoxPas, "Pressão Arterial Astólica");
            new ToolTip() { IsBalloon = true, UseAnimation = true, UseFading = true }.SetToolTip(textBoxPad, "Pressão Arterial Diastólica");
            comboBoxPressaoArterial.ValueMember = "Codigo";
            comboBoxPressaoArterial.DisplayMember = "Titulo";
            comboBoxPressaoArterial.DataSource = pressaoArterial;
            try
            {
                textPaciente.Text = Sessao.Paciente.Nome;
                textProntuario.Text = Sessao.Paciente.Prontuario.ToString();
                textLeito.Text = Sessao.Paciente.NomeLeito;
                textIdade.Text = Sessao.Paciente.Idade.ToString();
                textBoxSetor.Text = Sessao.Paciente.NomeSetor;
                textBoxQuarto.Text = Sessao.Paciente.NomeQuarto;
                rdoMasculino.Checked = Sessao.Paciente.Sexo == 'M';
                rdoFerminino.Checked = Sessao.Paciente.Sexo == 'F';
                textBoxEnfermeira.Text = Sessao.Usuario == null ? string.Empty : Sessao.Usuario.Nome;
               
            }
            catch (Exception exl)
            {
                throw new Exception(exl.Message);
            }
        }

        private void comboBoxPressaoArterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            dynamic item = comboBoxPressaoArterial.SelectedItem;
            string param = item.Valor;
            if (!param.Equals("0"))
            {
                textBoxPas.Text = param.Split('X')[0];
                textBoxPad.Text = param.Split('X')[1];
            }
            else
            {
                textBoxPas.Text = string.Empty;
                textBoxPad.Text = string.Empty;
            }
        }
    }
}
