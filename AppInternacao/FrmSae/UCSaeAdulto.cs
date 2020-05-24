using AppInternacao.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace AppInternacao.FrmSae
{

    public partial class UCSaeAdulto : UserControl
    {
        

        public UCSaeAdulto()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public UCSaeAdulto(long _prountuario)
        {
            InitializeComponent();
            textProntuario.Text = _prountuario.ToString();
            Dock = DockStyle.Fill;
        }

       

        public void Button1_Click(object sender, EventArgs e)
        {
            SaeClinicaMedicaAdulto saePaciente = new SaeClinicaMedicaAdulto();

            try
            {
                // *** GRUPO PACIENTE ****
                Salvar(this);

            }
            catch (Exception)
            {

                throw;
            }

        }
        private SaeClinicaMedicaAdulto Salvar(Control control)
        {
            string valuesRadio = string.Empty;
            string[] msg = { " Controle de Cateteres e Sonda ", " Sistema Neurológico ", " Pupilas ", " Status Térmico ", " Oxigenação "," Pele ", " GASTROINTESTINAL ", " Regulação Abdominal ", " Regulação Vascular ", " Úcera por Compressão ", " DIAGNOSTICO DE ENFERMAGEM " };
            bool[] validar = { false, false, false, false, false, false, false, false, false, false, false, false};

            SaeClinicaMedicaAdulto saePaciente = new SaeClinicaMedicaAdulto();
            try
            {
                saePaciente.Cliente.Prontuario = Convert.ToInt64(textProntuario.Text);
                saePaciente.PA = mskPA.Text;
                saePaciente.DataSae = DateTime.Now;
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
                                saePaciente.SituacaoTermica.Status = radio.Tag.ToString();
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

                        if (itemControl.Name.Equals("gDiagnosticoEnfermagem"))
                        {
                            List<string> lst = new List<string>();
                            itemControl.Controls.OfType<CheckBox>().Where(r => r.Checked).ToList().ForEach(de => { lst.Add(de.Tag.ToString());});

                            saePaciente.Diagnostico = string.Join(" ", lst.AsQueryable());
                            validar[10] = lst.Count > 0;
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

            try
            {
            
            }
            catch (Exception exl)
            {
                throw new Exception(exl.Message);
            }
        }

       
    }
}
