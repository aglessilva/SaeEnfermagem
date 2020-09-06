using AppInternacao.Enum;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AppInternacao
{
    public partial class FrmViewTemplate : Form
    {
        DataTable dataTable;
        int somaTotalGlasgow = 0;
        RadioButton radioBtn = null, radioButtonEvent = null;
        TextBox TextBox = null;

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

        public FrmViewTemplate(DataTable _dataTable)
        {
            InitializeComponent();
            DataView dv = _dataTable.DefaultView;
            dv.Sort = "IdItemArea asc";
            dataTable = dv.ToTable();
            radioButtonEvent = new RadioButton();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            Dispose(true);
        }


        private void FrmViewTemplate_Load(object sender, EventArgs e)
        {
            Area area;
            RadioButton radioButton = null;

            comboBoxPressaoArterial.ValueMember = "Codigo";
            comboBoxPressaoArterial.DisplayMember = "Titulo";
            comboBoxPressaoArterial.DataSource = pressaoArterial;

            foreach (DataRow item in dataTable.Rows)
            {
                area = (Area)item[4];
                radioButton = new RadioButton() { Text = item[6].ToString(), Tag = item[5].ToString(), AutoSize = true, Checked = false };

                switch (area)
                {
                    case Area.SistemaNeurologico:
                        {
                            if (!pSistemaNeurologico.Visible)
                                pSistemaNeurologico.Visible = true;

                            flpSistemaNerologico.Controls.Add(radioButton);
                            break;
                        }
                    case Area.Pupilas:
                        {
                            if (!pPuplias.Visible)
                                pPuplias.Visible = true;

                            flpPupilas.Controls.Add(radioButton);
                            break;
                        }
                    case Area.RegulacaoTermica:
                        {
                            if (!pRegulacaoTermica.Visible)
                                pRegulacaoTermica.Visible = true;

                            if (new int[] { 18, 19 }.Any(s => s.Equals(Convert.ToInt32(item.ItemArray[4]))))
                            {
                                flpRegulacaotermica.Controls.Add(radioButton);
                                if(TextBox == null)
                                    TextBox = new TextBox() { Text = "ºC", Width = 40, TextAlign = HorizontalAlignment.Right };
                            }
                            else
                                flpRegulacaotermica.Controls.Add(radioButton);

                            break;
                        }
                    case Area.Oxigenacao:
                        {
                            if (!pOxigenacao.Visible)
                                pOxigenacao.Visible = true;

                            flpOxigenacao.Controls.Add(radioButton);
                            break;
                        }
                    case Area.Pele:
                        {
                            if (!pPele.Visible)
                                pPele.Visible = true;

                            flpPele.Controls.Add(radioButton);
                            break;
                        }
                    case Area.SistemaGastrointestinal:
                        {
                            if (!pSistemaGastrointestinal.Visible)
                                pSistemaGastrointestinal.Visible = true;

                            if (new int[] { 40, 41, 42 }.Any(s => s.Equals(Convert.ToInt32(item.ItemArray[4]))))
                            {
                                if (Convert.ToInt32(item.ItemArray[4]) == 40)
                                    pGavagem.Visible = true;

                                if (Convert.ToInt32(item.ItemArray[4]) == 41)
                                    pEvacuacoes.Visible = true;

                                if (Convert.ToInt32(item.ItemArray[4]) == 42)
                                    pFlatos.Visible = true;
                            }
                            else
                                flpSistemaGastroIntestinal.Controls.Add(radioButton);
                            break;
                        }
                    case Area.SistemaVascular:
                        {
                            if (!pSistemaVascular.Visible)
                                pSistemaVascular.Visible = true;

                            flpSistemaVascular.Controls.Add(radioButton);
                            break;
                        }
                    case Area.SistemaAbdominal:
                        {
                            if (!pSistemaAbdominal.Visible)
                                pSistemaAbdominal.Visible = true;

                            flpSistemaAbdominal.Controls.Add(radioButton);
                            break;
                        }
                    case Area.SistemaUrinario:
                        {
                            if (!pSistemaUrinario.Visible)
                                pSistemaUrinario.Visible = true;

                            flpsistemaUrinario.Controls.Add(radioButton);
                            break;
                        }
                    case Area.LesaoCompressao:
                        {
                            if (!pLesaoCompressao.Visible)
                                pLesaoCompressao.Visible = true;

                            flpLesao.Controls.Add(radioButton);
                            break;
                        }
                    case Area.GloboPinard:
                        {
                            if (!pPinard.Visible)
                                pPinard.Visible = true;

                            flpPinard.Controls.Add(radioButton);
                            break;
                        }
                    case Area.ComaGlasgow:
                        {
                            if (!pglasgow.Visible)
                                pFormGlasgow.Visible = pglasgow.Visible = true;
                            break;
                        }
                    case Area.ControleCateteres:
                        {
                            if (!pCateteres.Visible)
                                pCateteres.Visible = true;

                            flpCateteres.Controls.Add(radioButton);
                            break;
                        }
                    case Area.PressaoArterial:
                        {
                            if (!pPressao.Visible)
                                pPressao.Visible = true;

                            if (Convert.ToInt32(item.ItemArray[4]) == 88)
                                richTextBox1.Visible = true;
                            else if (Convert.ToInt32(item.ItemArray[4]) == 87)
                                pPA.Visible = true;
                            else
                                flpPressao.Controls.Add(radioButton);
                            break;
                        }
                    default:
                        break;
                }
            }

           if(TextBox != null )
                flpRegulacaotermica.Controls.Add(TextBox);
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

        private void RadioBtn_Click(object sender, EventArgs e)
        {
            radioBtn = gAberturaOcular.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            somaTotalGlasgow = radioBtn == null ? 0 + somaTotalGlasgow : somaTotalGlasgow + Convert.ToInt32(radioBtn.Tag);

            radioBtn = gRespostaVerbal.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            somaTotalGlasgow = radioBtn == null ? 0 + somaTotalGlasgow : somaTotalGlasgow  + Convert.ToInt32(radioBtn.Tag);

            radioBtn = gRespostaMotora.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            somaTotalGlasgow = radioBtn == null ? 0 + somaTotalGlasgow : somaTotalGlasgow  + Convert.ToInt32(radioBtn.Tag);

            lblSomaGlasgow.Text = $"Total de: {somaTotalGlasgow}";
            somaTotalGlasgow = 0;
            radioBtn = null;
        }
    }
}
