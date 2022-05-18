using AppInternacao.Enum;
using AppInternacao.Extend;
using AppInternacao.Model;
using AppInternacao.Presenter;
using Newtonsoft.Json;
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
        TemplateExameFisico templatesExames = new TemplateExameFisico();
        TemplateNameExameFisico template = null;
        List<FlowLayoutPanel> flowLayoutPanels = new List<FlowLayoutPanel>();
        List<GroupBox> groups = new List<GroupBox>();

        bool isBack = false;
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
                UI011FrmTimeLine.lblRotuloSae.Text = "Investigação (coleta de dados e exame físico)";
                UI011FrmTimeLine.iconButtonAvanca.Click += btnButtonStep_Click;
                flowLayoutPanels.Clear();

                presenterGeneric = new PresenterGeneric();
                
                lstTemplateNamesExamesFisicos = presenterGeneric.GetLista(new TemplateNameExameFisico { SetorAssociado = ((int)Tag).ToString() }, Procedure.SP_GET_NAME_EXAME_FISICO);
               
                UI011FrmTimeLine.IconButtonVolta.Enabled = false;
                UI011FrmTimeLine.iconButtonAvanca.Enabled =  lstTemplateNamesExamesFisicos.Any() ;

                if (!lstTemplateNamesExamesFisicos.Any())
                {
                    this.Enabled = false;
                    MessageBox.Show("Não existe nenhum template de exame físico associado para este setor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                lstTemplateNamesExamesFisicos.Insert(0, new TemplateNameExameFisico { Id = 0, NomeTemplate = "Selecione um template de exame físico..." });
                comboBoxTemplateExameFisico.DataSource = lstTemplateNamesExamesFisicos;
                comboBoxPressaoArterial.DataSource = pressaoArterial;

                if (Sessao.Paciente.Sae.ExameFisico.ExameItens.Any())
                {
                    isBack = true;

                    comboBoxTemplateExameFisico.SelectedItem = lstTemplateNamesExamesFisicos.SingleOrDefault(c => c.Id == Sessao.Paciente.Sae.ExameFisico.IdTemplate);
                    txtAnotacaoAdicionais.Text = Sessao.Paciente.Sae.ExameFisico.AnotacoesAdicionais;
                    Populatemplate();
                    OrdenarGroup();
                }

                comboBoxTemplateExameFisico.Enabled = Sessao.Paciente.SaeStatus.DataSae is null;
                txtAnotacaoAdicionais.Enabled = panelBody.Enabled = Sessao.Paciente.SaeStatus.Status == Sae.Edicao;

            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
        }

        private void btnButtonStep_Click(object sender, EventArgs e)
        {
            if (!comboBoxTemplateExameFisico.SelectedValue.Equals(0))
            {
                if (Valida())
                {
                    GetExameFisico();
                    Avancar();
                }
            }
            else
                MessageBox.Show("Selecione um template para o preenchimento do exame físico", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Avancar()
        {
            try
            {
                FrmMain.RemoveClickEvent(UI011FrmTimeLine.iconButtonAvanca);

                UI011FrmTimeLine.ctrl.Controls.RemoveAt(0);
                
                Form frm = new UI010FrmNanda(true) { TopLevel = false };
                UI011FrmTimeLine.ctrl.Controls.Add(frm);
                UI011FrmTimeLine.IconButtonVolta.Enabled = true;
                frm.Show();
            }
            catch (Exception Ex)
            {
                FrmMain.Alert(exception: Ex);
            }
        }

        void Clear()
        {
            groups.ForEach(g => g.Visible = false);
            groups.Clear();
            flowLayoutPanels.ForEach(flp => {if(!flp.Name.Equals("flpPressaoArterial")) flp.Controls.Clear(); flp.BackColor = System.Drawing.Color.Transparent;  });
            flowLayoutPanels.Clear();
            Sessao.Paciente.Sae.ExameFisico = new ExameFisico();
            errorProviderExameFisico.Clear();
            panelBody.Visible = false;
            templatesExames = new TemplateExameFisico();
        }

        void GetExameFisico()
        {
            try
            {
                Sessao.Paciente.Sae.ExameFisico.ExameItens = flowLayoutPanels
                    .SelectMany(f => f.Controls.OfType<RadioButtonExt>()
                    .Where(w => w.Checked)
                    .Select(s => (AreaCategoriaItem)s.Tag)).ToList();

                Sessao.Paciente.Sae.ExameFisico.AnotacoesAdicionais = txtAnotacaoAdicionais.Text;
                Sessao.Paciente.Sae.ExameFisico.IdTemplate = Convert.ToInt32(comboBoxTemplateExameFisico.SelectedValue);
                Sessao.Paciente.Sae.ExameFisico.Prontuario = Sessao.Paciente.Prontuario;
                Sessao.Paciente.Sae.ExameFisico.IdSetor = (int)Tag;

                if (groups.Any(g => g.Name.Equals(gEscalaPressao.Name)))
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
                template = (TemplateNameExameFisico)comboBoxTemplateExameFisico.SelectedItem;

                if (template.Id > 0)
                {

                    if (templatesExames.IdTemplate == template.Id)
                        return;

                    Clear();

                    templatesExames = presenterGeneric.GetItem(new TemplateExameFisico { IdTemplate = template.Id }, Procedure.SP_GET_TEMPLATE_EXAME_FISICO);

                    if (templatesExames is null)
                        return;

                    Populatemplate();
                    OrdenarGroup();
                }
                else
                    Clear();
                    
            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
        }

        private bool Valida()
        {
            try
            {
                flowLayoutPanels = flowLayoutPanels.OrderBy(o => o.TabIndex).ToList();

                foreach (Control item in flowLayoutPanels)
                {
                    if (item.Controls.OfType<Panel>().Select(s => s.Controls.OfType<ComboBox>()).Any())
                    {
                        ComboBox comboBox = item.Controls.OfType<Panel>().SelectMany(s => s.Controls.OfType<ComboBox>()).FirstOrDefault();

                        if (comboBox.SelectedIndex == 0)
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
                    }
                     else if (!item.Controls.OfType<RadioButtonExt>().Any(r => r.Checked))
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
            try
            {
                if (isBack && templatesExames.JsonTemplate == null)
                    templatesExames = presenterGeneric.GetItem(new TemplateExameFisico { IdTemplate = Convert.ToInt32(comboBoxTemplateExameFisico.SelectedValue) }, Procedure.SP_GET_TEMPLATE_EXAME_FISICO);

                List<AreaCategoriaItem> templateAreaCategoriaItems = JsonConvert.DeserializeObject<List<AreaCategoriaItem>>(templatesExames.JsonTemplate);

                foreach (AreaCategoriaItem item in templateAreaCategoriaItems)
                {
                    radioButtonItem = new RadioButtonExt()
                    {
                         Value = item.ValorItem.ToString()
                        ,Text = item.Descricao
                        ,AutoSize = true
                        ,Tag = item
                        ,Checked = isBack ? Sessao.Paciente.Sae.ExameFisico.ExameItens.Any(n => n.Id == item.Id && n.IdArea == item.IdArea) : isBack
                    };

                    switch ((Area)item.IdArea)
                    {
                        case Area.SistemaNeurologico:
                            {

                                if (!groups.Any(g => g.Name.Equals(gSistemaNeurologico.Name)))
                                {
                                    groups.Add(gSistemaNeurologico);
                                    flowLayoutPanels.Add(flpSistemaNerologico);
                                }

                                flpSistemaNerologico.Controls.Add(radioButtonItem);
                                break;
                            }
                        case Area.Pupilas:
                            {
                                if (!groups.Any(g => g.Name.Equals(gPupilas.Name)))
                                {
                                    groups.Add(gPupilas);
                                    flowLayoutPanels.Add(flpPupilas);
                                }

                                flpPupilas.Controls.Add(radioButtonItem);
                                break;
                            }
                        case Area.RegulacaoTermica:
                            {
                                if (!groups.Any(g => g.Name.Equals(gRegulacaoTermica.Name)))
                                {
                                    groups.Add(gRegulacaoTermica);
                                    flowLayoutPanels.Add(flpRegulacaotermica);
                                }

                                flpRegulacaotermica.Controls.Add(radioButtonItem);
                                break;
                            }
                        case Area.Oxigenacao:
                            {
                                if (!groups.Any(g => g.Name.Equals(gSistemaOxigenacao.Name)))
                                {
                                    groups.Add(gSistemaOxigenacao);
                                    flowLayoutPanels.Add(flpOxigenacao);
                                }

                                flpOxigenacao.Controls.Add(radioButtonItem);
                                break;
                            }
                        case Area.Pele:
                            {
                                if (!groups.Any(g => g.Name.Equals(gPele.Name)))
                                {
                                    groups.Add(gPele);
                                    flowLayoutPanels.Add(flpPele);
                                }

                                flpPele.Controls.Add(radioButtonItem);
                                break;
                            }
                        case Area.SistemaGastrointestinal:
                            {
                                if (!groups.Any(g => g.Name.Equals(gSistemaGastroIntestinal.Name)))
                                {
                                    groups.Add(gSistemaGastroIntestinal);
                                    flowLayoutPanels.Add(flpSistemaGastroIntestinal);
                                }

                                flpSistemaGastroIntestinal.Controls.Add(radioButtonItem);
                                break;
                            }
                        case Area.SistemaVascular:
                            {
                                if (!groups.Any(g => g.Name.Equals(gSistemaVascular.Name)))
                                {
                                    groups.Add(gSistemaVascular);
                                    flowLayoutPanels.Add(flpSistemaVascular);
                                }

                                flpSistemaVascular.Controls.Add(radioButtonItem);
                                break;
                            }
                        case Area.SistemaAbdominal:
                            {
                                if (!groups.Any(g => g.Name.Equals(gSistemaAbdominal.Name)))
                                {
                                    groups.Add(gSistemaAbdominal);
                                    flowLayoutPanels.Add(flpSistemaAbdominal);
                                }

                                flpSistemaAbdominal.Controls.Add(radioButtonItem);
                                break;
                            }
                        case Area.SistemaUrinario:
                            {
                                if (!groups.Any(g => g.Name.Equals(gSistemaUrinario.Name)))
                                {
                                    groups.Add(gSistemaUrinario);
                                    flowLayoutPanels.Add(flpsistemaUrinario);
                                }

                                flpsistemaUrinario.Controls.Add(radioButtonItem);
                                break;
                            }
                        case Area.LesaoCompressao:
                            {
                                if (!groups.Any(g => g.Name.Equals(gLesaoCompressao.Name)))
                                {
                                    groups.Add(gLesaoCompressao);
                                    flowLayoutPanels.Add(flpLesao);
                                }

                                flpLesao.Controls.Add(radioButtonItem);
                                break;
                            }
                        case Area.GloboPinard:
                            {
                                if (!groups.Any(g => g.Name.Equals(gPinard.Name)))
                                {
                                    groups.Add(gPinard);
                                    flowLayoutPanels.Add(flpPinard);
                                }

                                flpPinard.Controls.Add(radioButtonItem);
                                break;
                            }
                        case Area.ComaGlasgow:
                            {
                                if (!groups.Any(g => g.Name.Equals(gGlasgow.Name)))
                                    groups.Add(gGlasgow);

                                if (item.IdAreaItem == 86)
                                {
                                    if (!groups.Any(g => g.Name.Equals(gRespostaMotora.Name)))
                                    {
                                        groups.Add(gRespostaMotora);
                                        flowLayoutPanels.Add(flpRespostaMotora);
                                    }

                                    radioButtonItem.Click += RadioBtn_Click;
                                    flpRespostaMotora.Controls.Add(radioButtonItem);
                                }

                                if (item.IdAreaItem == 85)
                                {
                                    if (!groups.Any(g => g.Name.Equals(gRespostaVerbal.Name)))
                                    {
                                        groups.Add(gRespostaVerbal);
                                        flowLayoutPanels.Add(flpRespostaVerbal);
                                    }

                                    radioButtonItem.Click += RadioBtn_Click;
                                    flpRespostaVerbal.Controls.Add(radioButtonItem);
                                }

                                if (item.IdAreaItem == 84)
                                {
                                    if (!groups.Any(g => g.Name.Equals(gRespostaAberturaOcular.Name)))
                                    {
                                        groups.Add(gRespostaAberturaOcular);
                                        flowLayoutPanels.Add(flpRespostaAberturaOcular);
                                    }

                                    radioButtonItem.Click += RadioBtn_Click;
                                    flpRespostaAberturaOcular.Controls.Add(radioButtonItem);
                                }

                                break;
                            }
                        case Area.ControleCateteres:
                            {
                                if (!groups.Any(g => g.Name.Equals(gCateterSonda.Name)))
                                {
                                    groups.Add(gCateterSonda);
                                    flowLayoutPanels.Add(flpCateteres);
                                }

                                flpCateteres.Controls.Add(radioButtonItem);
                                break;
                            }
                        case Area.PressaoArterial:
                            {
                                if (!groups.Any(g => g.Name.Equals(gEscalaPressao.Name)))
                                {
                                    groups.Add(gEscalaPressao);
                                    flowLayoutPanels.Add(flpPressaoArterial);
                                }

                                comboBoxPressaoArterial.SelectedIndex = (int)Sessao.Paciente.Sae?.ExameFisico.CodigoPressaoArterial;
                                textBoxAnotacaoPressaoArterial.Text = Sessao.Paciente.Sae?.ExameFisico.AnotacaoPressaoArterial;
                                if (isBack)
                                    comboBoxPressaoArterial_SelectionChangeCommitted(null, null);

                                break;
                            }
                        default:
                            break;
                    }
                }

                groups.ForEach(g => g.Visible = true);
                panelBody.Visible = true;
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

        }

        private void RadioBtn_Click(object sender, EventArgs e)
        {
            if (gGlasgow.Visible)
            {
                if (gRespostaAberturaOcular.Visible)
                {
                    radioButtonItem = flpRespostaAberturaOcular.Controls.OfType<RadioButtonExt>().FirstOrDefault(r => r.Checked);
                    somaTotalGlasgow = radioButtonItem == null ? 0 + somaTotalGlasgow : somaTotalGlasgow + Convert.ToInt32(radioButtonItem.Value);
                }

                if (gRespostaVerbal.Visible)
                {
                    radioButtonItem = flpRespostaVerbal.Controls.OfType<RadioButtonExt>().FirstOrDefault(r => r.Checked);
                    somaTotalGlasgow = radioButtonItem == null ? 0 + somaTotalGlasgow : somaTotalGlasgow + Convert.ToInt32(radioButtonItem.Value);
                }

                if (gRespostaMotora.Visible)
                {
                    radioButtonItem = flpRespostaMotora.Controls.OfType<RadioButtonExt>().FirstOrDefault(r => r.Checked);
                    somaTotalGlasgow = radioButtonItem == null ? 0 + somaTotalGlasgow : somaTotalGlasgow + Convert.ToInt32(radioButtonItem.Value);
                }

                somaTotalGlasgow = 0;
                radioButtonItem = null;
            }
        }
    }
}
