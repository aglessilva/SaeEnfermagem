using AppInternacao.Enum;
using AppInternacao.Extend;
using AppInternacao.Model;
using AppInternacao.Presenter;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AppInternacao.FrmSae
{
    public partial class UI014FrmSaeExameFisico : UI000FrmTemplate
    {
        public UI014FrmSaeExameFisico()
        {
            InitializeComponent();
        }
        PresenterGeneric presenterGeneric = null;
        List<TemplateNameExameFisico> lstTemplateNamesExamesFisicos = null;
        List<TemplateExameFisico> lstTemplatesExames = null;
        List<AreaCategoriaItem> areaCategoriaItems = null;
        List<Control> lstControles = new List<Control>();

        private int somaTotalGlasgow;
        RadioButtonExt radioButtonItem = null;

        List<object> pressaoArterial = new List<object>()
         {
            new {Codigo = 0, Titulo = "Selecione", Valor = "0"},
            new {Codigo = 1, Titulo = "Ótima", Valor = "< 120 X < 80"},
            new {Codigo = 2, Titulo = "Normal", Valor = "120 a 129 X 80 a 84" },
            new {Codigo = 3, Titulo = "Normal Alto",Valor = "130 a 139 X 85 a 89" },
            new {Codigo = 4, Titulo = "Estágio 1", Valor = "140 a 159 X 90 a 99" },
            new {Codigo = 5, Titulo = "Estágio 2", Valor = "160 a 179 X 100 a 109" },
            new {Codigo = 6, Titulo = "Estágio 3", Valor = ">= 180 X >= 110" }
        };

        private void UI014FrmExameFisico_Load(object sender, EventArgs e)
        {
            try
            {
                UI011FrmTimeLine.iconButtonAvanca.Click += btnButtonStep_Click;
                UI011FrmTimeLine.IconButtonVolta.Click += btnButtonStep_Click;

                presenterGeneric = new PresenterGeneric();
                
                lstTemplateNamesExamesFisicos = presenterGeneric.GetLista(new TemplateNameExameFisico(), Procedure.SP_GET_NAME_EXAME_FISICO);
                lstTemplateNamesExamesFisicos.Insert(0, new TemplateNameExameFisico { Id = 0, NomeTemplate = "Selecione um modelo de exame físico..." });
                comboBoxTemplateExameFisico.DataSource = lstTemplateNamesExamesFisicos;
                comboBoxPressaoArterial.DataSource = pressaoArterial;

                areaCategoriaItems = presenterGeneric.GetLista(new AreaCategoriaItem(), Procedure.SP_GET_CATEGORIAS_AREA_ITEMS);
            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
        }

        private void btnButtonStep_Click(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;
            if (btn.Tag.Equals("1"))
            {
                if (Valida())
                {
                    GetExameFisico();
                    Avancar();
                }
            }
        }

        private void Avancar()
        {
            try
            {
                FrmMain.RemoveClickEvent(UI011FrmTimeLine.iconButtonAvanca);
                FrmMain.RemoveClickEvent(UI011FrmTimeLine.IconButtonVolta);

                UI011FrmTimeLine.ctrl.Controls.RemoveAt(0);
                
                Form frm = new UI010FrmNanda(true) { TopLevel = false };
                UI011FrmTimeLine.ctrl.Controls.Add(frm);
                UI011FrmTimeLine.lblRotuloSae.Text = "Diagnóstico de Enfermagem";
                frm.Show();
            }
            catch (Exception Ex)
            {
                FrmMain.Alert(exception: Ex);
            }
        }


        void GetExameFisico()
        {
            try
            {
                var lstRadios = panelBody.Controls.OfType<GroupBox>().Where(s => s.Visible).Select(f => f.Controls.OfType<FlowLayoutPanel>()).ToList();
                var radioButtonExtsChecked = lstRadios.SelectMany(x => x.Select(f => f.Controls.OfType<RadioButtonExt>().Where(w => w.Checked))).Select(g => g.ToList());
                Sessao.Paciente.Sae.ExameFisico.ExameItens = radioButtonExtsChecked.SelectMany(f => f.Select(s => (AreaCategoriaItem)s.Tag)).ToList();

                if(gGlasgow.Visible)
                {
                    var areaCategoriaItems = gGlasgow.Controls.OfType<GroupBox>().Where(w => w.Visible).Select(s => (AreaCategoriaItem)s.Tag).ToList();
                    Sessao.Paciente.Sae.ExameFisico.ExameItens.AddRange(areaCategoriaItems);
                }

                Sessao.Paciente.Sae.ExameFisico.AnotacoesAdicionais = txtAnotacaoAdicionais.Text;

                if (gEscalaPressao.Visible)
                {
                    Sessao.Paciente.Sae.ExameFisico.AnotacaoPressaoArterial = textBoxAnotacaoPressaoArterial.Text;
                    Sessao.Paciente.Sae.ExameFisico.CodigoPressaoArterial = Convert.ToInt32(comboBoxPressaoArterial.SelectedValue);
                }

            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
        }

        private void comboBoxTemplateExameFisico_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                TemplateNameExameFisico template = (TemplateNameExameFisico)comboBoxTemplateExameFisico.SelectedItem;

               if (template.Id > 0)
                {
                    lstTemplatesExames = presenterGeneric.GetLista(new TemplateExameFisico { IdTemplate = template.Id }, Procedure.SP_GET_TEMPLATE_EXAME_FISICO);
                    Populatemplate();
                    OrdenarGroup();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private bool Valida()
        {
            try
            {
                foreach (Control item in lstControles)
                {
                    if (!item.Controls.OfType<RadioButtonExt>().Any(r => r.Checked) && !item.Name.Equals("flpPressaoArterial"))
                    {
                        item.BackColor = System.Drawing.Color.LightGray;
                        errorProviderExameFisico.SetError(item, "preencha ou selecione um item desta categoria!");
                        errorProviderExameFisico.SetIconPadding(item, -18);
                        item.Focus();
                        return false;
                    }
                    else
                    {
                        errorProviderExameFisico.SetError(item, null);
                        item.BackColor = System.Drawing.Color.Transparent;
                    }


                    if (item.Name.Equals("flpPressaoArterial"))
                    {
                        var cb = item.Controls.OfType<Panel>().Where(p => p.Controls.Count > 0).Select(s => s.Controls.OfType<ComboBox>()).FirstOrDefault().FirstOrDefault();
                        if(cb != null)
                        {
                            if (Convert.ToInt32(cb.SelectedValue) == 0)
                            {
                                item.BackColor = System.Drawing.Color.SlateGray;
                                errorProviderExameFisico.SetError(item, "preencha ou selecione um item desta categoria!");
                                errorProviderExameFisico.SetIconPadding(item, -18);
                                return false;
                            }
                            else
                            {
                                errorProviderExameFisico.SetError(item, null);
                                item.BackColor = System.Drawing.Color.Transparent;
                            }
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                FrmMain.Alert(exception: Ex);
            }

            return true;
        }

        void Populatemplate()
        {
            List<int> lstIdItem = new List<int>();
            List<RadioButtonExt> radioButtonExts = new List<RadioButtonExt>();
            try
            {
                foreach (TemplateExameFisico item in lstTemplatesExames)
                {
                    lstIdItem.Clear();
                    radioButtonExts.Clear();

                    item.IdItem.Split(',').ToList().ForEach(i => { lstIdItem.Add(Convert.ToInt32(i)); });
                    
                    var lstItemsArea = areaCategoriaItems.Where(s => lstIdItem.Contains(s.Id)).ToList();

                    lstItemsArea.ForEach(m => {
                        radioButtonItem = new RadioButtonExt() { Value = m.Id.ToString(), Text = m.Descricao, AutoSize = true, Tag = m };
                        radioButtonExts.Add(radioButtonItem);
                    });

                    switch (item.IdArea)
                    {
                        case Area.SistemaNeurologico:
                            {
                                if (!gSistemaNeurologico.Visible)
                                    gSistemaNeurologico.Visible = true;

                                flpSistemaNerologico.Controls.AddRange(radioButtonExts.ToArray());
                                lstControles.Add(flpSistemaNerologico);
                                break;
                            }
                        case Area.Pupilas:
                            {
                                if (!gPupilas.Visible)
                                    gPupilas.Visible = true;

                                flpPupilas.Controls.AddRange(radioButtonExts.ToArray());
                                lstControles.Add(flpPupilas);
                                break;
                            }
                        case Area.RegulacaoTermica:
                            {
                                if (!gRegulacaoTermica.Visible)
                                    gRegulacaoTermica.Visible = true;

                                flpRegulacaotermica.Controls.AddRange(radioButtonExts.ToArray());
                                lstControles.Add(flpRegulacaotermica);
                                break;
                            }
                        case Area.Oxigenacao:
                            {
                                if (!gSistemaOxigenacao.Visible)
                                    gSistemaOxigenacao.Visible = true;

                                flpOxigenacao.Controls.AddRange(radioButtonExts.ToArray());
                                lstControles.Add(flpOxigenacao);
                                break;
                            }
                        case Area.Pele:
                            {
                                if (!gPele.Visible)
                                    gPele.Visible = true;

                                flpPele.Controls.AddRange(radioButtonExts.ToArray());
                                lstControles.Add(flpPele);
                                break;
                            }
                        case Area.SistemaGastrointestinal:
                            {
                                if (!gSistemaGastroIntestinal.Visible)
                                    gSistemaGastroIntestinal.Visible = true;

                                flpSistemaGastroIntestinal.Controls.AddRange(radioButtonExts.ToArray());
                                lstControles.Add(flpSistemaGastroIntestinal);
                                break;
                            }
                        case Area.SistemaVascular:
                            {
                                if (!gSistemaVascular.Visible)
                                    gSistemaVascular.Visible = true;

                                flpSistemaVascular.Controls.AddRange(radioButtonExts.ToArray());
                                lstControles.Add(flpSistemaVascular);
                                break;
                            }
                        case Area.SistemaAbdominal:
                            {
                                if (!gSistemaAbdominal.Visible)
                                    gSistemaAbdominal.Visible = true;

                                flpSistemaAbdominal.Controls.AddRange(radioButtonExts.ToArray());
                                lstControles.Add(flpSistemaAbdominal);
                                break;
                            }
                        case Area.SistemaUrinario:
                            {
                                if (!gSistemaUrinario.Visible)
                                    gSistemaUrinario.Visible = true;

                                flpsistemaUrinario.Controls.AddRange(radioButtonExts.ToArray());
                                lstControles.Add(flpsistemaUrinario);
                                break;
                            }
                        case Area.LesaoCompressao:
                            {
                                if (!gLesaoCompressao.Visible)
                                    gLesaoCompressao.Visible = true;

                                flpLesao.Controls.AddRange(radioButtonExts.ToArray());
                                lstControles.Add(flpLesao);
                                break;
                            }
                        case Area.GloboPinard:
                            {
                                if (!gPinard.Visible)
                                    gPinard.Visible = true;

                                flpPinard.Controls.AddRange(radioButtonExts.ToArray());
                                lstControles.Add(flpPinard);
                                break;
                            }
                        case Area.ComaGlasgow:
                            {
                                if (!gGlasgow.Visible)
                                    pFormGlasgow.Visible = gGlasgow.Visible = true;

                                radioButtonExts.ForEach(f => {

                                    AreaCategoriaItem areaCategoriaItem = (AreaCategoriaItem)f.Tag;
                                    if (areaCategoriaItem.Id == 86)
                                    {
                                        gRespostaMotora.Visible = true;
                                        gRespostaMotora.Tag = areaCategoriaItem;
                                        lstControles.Add(gRespostaMotora);
                                    }
                                    if (areaCategoriaItem.Id == 85)
                                    {
                                        gRespostaVerbal.Visible = true;
                                        gRespostaVerbal.Tag = areaCategoriaItem;
                                        lstControles.Add(gRespostaVerbal);
                                    }
                                    if (areaCategoriaItem.Id == 84)
                                    {
                                        gAberturaOcular.Visible = true;
                                        gAberturaOcular.Tag = areaCategoriaItem;
                                        lstControles.Add(gAberturaOcular);
                                    }
                                });

                                break;
                            }
                        case Area.ControleCateteres:
                            {
                                if (!gCateterSonda.Visible)
                                    gCateterSonda.Visible = true;

                                flpCateteres.Controls.AddRange(radioButtonExts.ToArray());
                                lstControles.Add(flpCateteres);
                                break;
                            }
                        case Area.PressaoArterial:
                            {
                                if (!gEscalaPressao.Visible)
                                    gEscalaPressao.Visible = true;

                                lstControles.Add(flpPressaoArterial);
                                break;
                            }
                        default:
                            break;
                    }
                }
            }
            catch (Exception Ex)
            {
                FrmMain.Alert(exception: Ex);
            }
        }

        void OrdenarGroup()
        {
            if (gSistemaNeurologico.Visible)
                gSistemaNeurologico.SendToBack();

            if (gPupilas.Visible)
                gPupilas.BringToFront();

            if (gRegulacaoTermica.Visible)
                gRegulacaoTermica.BringToFront();

            if (gSistemaOxigenacao.Visible)
                gSistemaOxigenacao.BringToFront();

            if (gPele.Visible)
                gPele.BringToFront();

            if (gSistemaGastroIntestinal.Visible)
                gSistemaGastroIntestinal.BringToFront();

            if (gSistemaVascular.Visible)
                gSistemaVascular.BringToFront();

            if (gSistemaAbdominal.Visible)
                gSistemaAbdominal.BringToFront();

            if (gSistemaUrinario.Visible)
                gSistemaUrinario.BringToFront();

            if (gLesaoCompressao.Visible)
                gLesaoCompressao.BringToFront();

            if (gPinard.Visible)
                gPinard.BringToFront();

            if (gGlasgow.Visible)
                gGlasgow.BringToFront();

            if (gCateterSonda.Visible)
                gCateterSonda.BringToFront();

            if (gEscalaPressao.Visible)
                gEscalaPressao.BringToFront();

        }

        private void comboBoxPressaoArterial_SelectionChangeCommitted(object sender, EventArgs e)
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
    }
}
