using AppInternacao.Enum;
using AppInternacao.Extend;
using AppInternacao.Model;
using AppInternacao.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AppInternacao.FrmSae
{
    public partial class UCExameFisico : UserControl
    {
        private PresenterGeneric presenterGeneric = null;
        List<EstruturaFisica> lstEstrutura = new List<EstruturaFisica>();
        List<TemplateName> lstTemplates = new List<TemplateName>();
        List<Area_Itens> lstAreaItem = new List<Area_Itens>();
        int somaTotalGlasgow = 0;
        TextBox TextBox = null;
        RadioButtonExt radioButtonItem = null;

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


        EstruturaFisica estruturaFisica = null;
        public UCExameFisico()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        void Populatemplate()
        {
            try
            {
                foreach (Area_Itens item in lstAreaItem)
                {
                    radioButtonItem = new RadioButtonExt() { Value = item.IdItemArea.ToString(), Text = item.Nome, AutoSize = true };
                    switch (item.IdArea)
                    {
                        case Area.SistemaNeurologico:
                            {
                                if (!gSistemaNeurologico.Visible)
                                    gSistemaNeurologico.Visible = true;

                                flpSistemaNerologico.Controls.Add(radioButtonItem);
                                break;
                            }
                        case Area.Pupilas:
                            {
                                if (!gPupilas.Visible)
                                    gPupilas.Visible = true;

                                flpPupilas.Controls.Add(radioButtonItem);
                                break;
                            }
                        case Area.RegulacaoTermica:
                            {
                                if (!gRegulacaoTermica.Visible)
                                    gRegulacaoTermica.Visible = true;

                                if (new int[] { 18, 19 }.Any(s => item.IdItemArea.Equals(s)))
                                {
                                    flpRegulacaotermica.Controls.Add(radioButtonItem);
                                    if (TextBox == null)
                                        TextBox = new TextBox() { Text = "ºC", Width = 40, TextAlign = HorizontalAlignment.Right };
                                }
                                else
                                    flpRegulacaotermica.Controls.Add(radioButtonItem);

                                break;
                            }
                        case Area.Oxigenacao:
                            {
                                if (!gSistemaOxigenacao.Visible)
                                    gSistemaOxigenacao.Visible = true;

                                flpOxigenacao.Controls.Add(radioButtonItem);
                                break;
                            }
                        case Area.Pele:
                            {
                                if (!gPele.Visible)
                                    gPele.Visible = true;

                                flpPele.Controls.Add(radioButtonItem);
                                break;
                            }
                        case Area.SistemaGastrointestinal:
                            {
                                if (!gSistemaGastroIntestinal.Visible)
                                    gSistemaGastroIntestinal.Visible = true;

                                if (new int[] { 40, 41, 42 }.Any(s => item.IdItemArea.Equals(s)))
                                {
                                    pGavagem.Visible = item.IdItemArea == 40 ? true : false;
                                    pEvacuacoes.Visible = item.IdItemArea == 41 ? true : false;
                                    pFlatos.Visible = item.IdItemArea == 42 ? true : false;
                                }
                                else
                                    flpSistemaGastroIntestinal.Controls.Add(radioButtonItem);
                                break;
                            }
                        case Area.SistemaVascular:
                            {
                                if (!gSistemaVascular.Visible)
                                    gSistemaVascular.Visible = true;

                                flpSistemaVascular.Controls.Add(radioButtonItem);
                                break;
                            }
                        case Area.SistemaAbdominal:
                            {
                                if (!gSistemaAbdominal.Visible)
                                    gSistemaAbdominal.Visible = true;

                                flpSistemaAbdominal.Controls.Add(radioButtonItem);
                                break;
                            }
                        case Area.SistemaUrinario:
                            {
                                if (!gSistemaUrinario.Visible)
                                    gSistemaUrinario.Visible = true;

                                flpsistemaUrinario.Controls.Add(radioButtonItem);
                                break;
                            }
                        case Area.LesaoCompressao:
                            {
                                if (!gLesaoCompressao.Visible)
                                    gLesaoCompressao.Visible = true;

                                flpLesao.Controls.Add(radioButtonItem);
                                break;
                            }
                        case Area.GloboPinard:
                            {
                                if (!gPinard.Visible)
                                     gPinard.Visible = true;

                                flpPinard.Controls.Add(radioButtonItem);
                                break;
                            }
                        case Area.ComaGlasgow:
                            {
                                if (!gGlasgow.Visible)
                                    pFormGlasgow.Visible = gGlasgow.Visible = true;
                                break;
                            }
                        case Area.ControleCateteres:
                            {
                                if (!gCateterSonda.Visible)
                                    gCateterSonda.Visible = true;

                                flpCateteres.Controls.Add(radioButtonItem);
                                break;
                            }
                        case Area.PressaoArterial:
                            {
                                if (!gEscalaPressao.Visible)
                                    gEscalaPressao.Visible = true;

                                pPA.Visible = item.IdItemArea == 87 ? true : false; 
                                break;
                            }
                        default:
                            break;
                    }
                }

                if (TextBox != null)
                    flpRegulacaotermica.Controls.Add(TextBox);
            }
            catch (Exception)
            {

                throw;
            }
        }

        void LimparFolowTable()
        {
            somaTotalGlasgow = 0;
            lblSomaGlasgow.Text = "Total de:";
            gSistemaNeurologico.Visible 
            = pGavagem.Visible
            = pFlatos.Visible
            = pEvacuacoes.Visible
            = gPupilas.Visible 
            = gSistemaAbdominal.Visible 
            = gSistemaOxigenacao.Visible 
            = gPele.Visible 
            = gPinard.Visible
            = gLesaoCompressao.Visible
            = gSistemaUrinario.Visible
            = gSistemaVascular.Visible
            = gCateterSonda.Visible
            = gEscalaPressao.Visible 
            = pFormGlasgow.Visible
            = gGlasgow.Visible 
            = gRegulacaoTermica.Visible = false;
            gSistemaGastroIntestinal.Visible = false;

            flpRegulacaotermica.Controls.Clear();
            flpPupilas.Controls.Clear();
            flpSistemaNerologico.Controls.Clear();
            flpOxigenacao.Controls.Clear();
            flpPele.Controls.Clear();
            flpPinard.Controls.Clear();
            flpCateteres.Controls.Clear();
            flpLesao.Controls.Clear();
            flpsistemaUrinario.Controls.Clear();
            flpSistemaAbdominal.Controls.Clear();
            flpSistemaVascular.Controls.Clear();

            List<RadioButtonExt> lstRemove = flpSistemaGastroIntestinal.Controls.OfType<RadioButtonExt>().ToList();

            foreach (RadioButtonExt item in lstRemove)
            {
                flpSistemaGastroIntestinal.Controls.Remove(item);
            }

            gRespostaMotora.Controls.OfType<RadioButtonExt>().ToList().ForEach(rm => { rm.Checked = false; });
            gAberturaOcular.Controls.OfType<RadioButtonExt>().ToList().ForEach(rm => { rm.Checked = false; }); 
            gRespostaVerbal.Controls.OfType<RadioButtonExt>().ToList().ForEach(rm => { rm.Checked = false; });
            pEvacuacoes.Controls.OfType<RadioButtonExt>().ToList().ForEach(rm => { rm.Checked = false; });
            pGavagem.Controls.OfType<RadioButtonExt>().ToList().ForEach(rm => { rm.Checked = false; });
            pFlatos.Controls.OfType<RadioButtonExt>().ToList().ForEach(rm => { rm.Checked = false; });

            comboBoxPressaoArterial.SelectedIndex = 0;
        }

        private void RadioBtn_Click(object sender, EventArgs e)
        {
            radioButtonItem = gAberturaOcular.Controls.OfType<RadioButtonExt>().FirstOrDefault(r => r.Checked);
            somaTotalGlasgow = radioButtonItem == null ? 0 + somaTotalGlasgow : somaTotalGlasgow + Convert.ToInt32(radioButtonItem.Value);

            radioButtonItem = gRespostaVerbal.Controls.OfType<RadioButtonExt>().FirstOrDefault(r => r.Checked);
            somaTotalGlasgow = radioButtonItem == null ? 0 + somaTotalGlasgow : somaTotalGlasgow + Convert.ToInt32(radioButtonItem.Value);

            radioButtonItem = gRespostaMotora.Controls.OfType<RadioButtonExt>().FirstOrDefault(r => r.Checked);
            somaTotalGlasgow = radioButtonItem == null ? 0 + somaTotalGlasgow : somaTotalGlasgow + Convert.ToInt32(radioButtonItem.Value);

            lblSomaGlasgow.Text = $"Total de: {somaTotalGlasgow}";
            somaTotalGlasgow = 0;
            radioButtonItem = null;
        }

        private void UCExameFisico_Load(object sender, EventArgs e)
        {
            presenterGeneric = new PresenterGeneric();
            lstEstrutura = presenterGeneric.GetLista(new EstruturaFisica(), Procedure.SP_GET_ESTRUTURA_FISICA);
            lstEstrutura.Insert(0, new EstruturaFisica() { Id = 0, Nome = "Selecione..." });
            comboBoxEstruturaFisica.SelectedIndexChanged -= comboBoxEstruturaFisica_SelectedIndexChanged;
            comboBoxEstruturaFisica.DataSource = lstEstrutura;
            comboBoxEstruturaFisica.SelectedIndexChanged += comboBoxEstruturaFisica_SelectedIndexChanged;

            comboBoxPressaoArterial.ValueMember = "Codigo";
            comboBoxPressaoArterial.DisplayMember = "Titulo";
            comboBoxPressaoArterial.DataSource = pressaoArterial;
        }

        private void comboBoxEstruturaFisica_SelectedIndexChanged(object sender, EventArgs e)
        {
            estruturaFisica = (EstruturaFisica)comboBoxEstruturaFisica.SelectedItem;   
            try
            {
                LimparFolowTable();

                if (estruturaFisica.Id == 0)
                {
                    comboBoxTemplateExameFisico.DataSource = new List<TemplateName>();
                    return;
                }

                comboBoxTemplateExameFisico.SelectedIndexChanged -= comboBoxTemplateExameFisico_SelectedIndexChanged;

                lstTemplates = presenterGeneric.GetLista(new TemplateName() { IdEstruturaFisica = estruturaFisica.Id, Ativo = true }, Procedure.SP_GET_TEMPLATE_NAME);
                if (lstTemplates.Count > 0)
                    lstTemplates.Insert(0, new TemplateName() { Id = 0, Nome = "Selecione..." });
                comboBoxTemplateExameFisico.DataSource = lstTemplates;

                comboBoxTemplateExameFisico.SelectedIndexChanged += comboBoxTemplateExameFisico_SelectedIndexChanged;
                
            }
            catch (Exception ex)
            {
                FrmMain.Alert(100, ex);
            }
        }

        private void comboBoxTemplateExameFisico_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LimparFolowTable();
                TemplateName templateName = (TemplateName)comboBoxTemplateExameFisico.SelectedItem;

                if (templateName.Id == 0)
                    return;

                lstAreaItem = presenterGeneric.GetLista(new Area_Itens() { IdTemplate  = templateName.Id }, Procedure.SP_GET_ITENS_TEMPLATE);
                Populatemplate();
            }
            catch (Exception ex)
            {
                FrmMain.Alert(100, ex);
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
