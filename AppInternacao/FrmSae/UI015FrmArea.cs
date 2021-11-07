using AppInternacao.Enum;
using AppInternacao.Model;
using AppInternacao.Presenter;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AppInternacao.FrmSae
{
    public partial class UI015FrmArea : UI000FrmTemplate
    {
        public UI015FrmArea()
        {
            InitializeComponent();
        }

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

        List<AreaCategoria> areaCategorias = null;
        List<AreaCategoriaItem> areaCategoriaItems = null;
        PresenterGeneric presenterGeneric = null;

        private void UI015FrmArea_Load(object sender, EventArgs e)
        {
            presenterGeneric = new PresenterGeneric();
            areaCategorias = presenterGeneric.GetLista(new AreaCategoria(), Procedure.SP_GET_CATEGORIAS_AREA);
            areaCategoriaItems = presenterGeneric.GetLista(new AreaCategoriaItem(), Procedure.SP_GET_CATEGORIAS_AREA_ITEMS);
           
            areaCategorias.ForEach(n => {
                treeViewCategorias.Nodes.Add(new TreeNode { Text = Name = n.Nome, Tag = n });
            });

            foreach (TreeNode item in treeViewCategorias.Nodes)
            {
                AreaCategoria area = (AreaCategoria)item.Tag;
                areaCategoriaItems.Where(i => i.IdArea == area.Id).ToList().ForEach(m =>
                {
                    item.Nodes.Add(new TreeNode { Text = Name = m.Descricao, Tag = m });
                });
            }

            comboBoxPressaoArterial.ValueMember = "Codigo";
            comboBoxPressaoArterial.DisplayMember = "Titulo";
            comboBoxPressaoArterial.DataSource = pressaoArterial;
        }

        private void treeViewCategorias_AfterCheck(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (e.Action == TreeViewAction.Unknown)
                    return;

                if (e.Node.Level == 0)
                {
                    foreach (TreeNode item in e.Node.Nodes)
                    {
                        item.Checked = e.Node.Checked;
                        PopularItens(item);
                    }
                }
                else
                {
                    e.Node.Parent.Checked = e.Node.Parent.Nodes.OfType<TreeNode>().Any(c => c.Checked);
                    PopularItens(e.Node);
                }

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
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
        }

        private void AddItensArea(TreeNode treeNode, FlowLayoutPanel flowLayoutPanel)
        {
            try
            {
                
                RadioButton radioButton = null;
                if (treeNode.Level == 0)
                {
                    foreach (TreeNode item in treeNode.Nodes)
                    {
                        AreaCategoriaItem areaCategoriaItem = (AreaCategoriaItem)item.Tag;
                        radioButton = new RadioButton { Text = item.Text, Tag = item.Tag, TabIndex = areaCategoriaItem.Id , AutoSize = true };
                        flowLayoutPanel.TabIndex = areaCategoriaItem.IdArea;
                        flowLayoutPanel.Controls.Add(radioButton);
                    }
                }
                else
                {
                    foreach (TreeNode item in treeNode.Parent.Nodes)
                    {
                        if (item.Checked)
                        {
                            AreaCategoriaItem areaCategoriaItem = (AreaCategoriaItem)item.Tag;
                            radioButton = new RadioButton { Text = item.Text, Tag = item.Tag , TabIndex = areaCategoriaItem.Id,  AutoSize = true };
                            flowLayoutPanel.TabIndex = areaCategoriaItem.IdArea;
                            flowLayoutPanel.Controls.Add(radioButton);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
        }

        private void PopularItens(TreeNode treeNode)
        {
            AreaCategoriaItem areaCategoria = (AreaCategoriaItem)treeNode.Tag;
            Area area = (Area)areaCategoria.IdArea;
            
            switch (area)
            {
                case Area.SistemaNeurologico:
                    {
                        gSistemaNeurologico.TabStop = false;
                        gSistemaNeurologico.TabIndex = (int)area;
                        flpSistemaNerologico.Controls.Clear();
                        
                        AddItensArea(treeNode, flpSistemaNerologico);
                        gSistemaNeurologico.Visible = treeNode.Parent.Checked;
                        break;
                    }
                case Area.Pupilas:
                    {
                        gPupilas.TabStop = false;
                        gPupilas.TabIndex = (int)area;
                        flpPupilas.Controls.Clear();

                        AddItensArea(treeNode, flpPupilas);
                        gPupilas.Visible = treeNode.Parent.Checked;
                        break;
                    }
                case Area.RegulacaoTermica:
                    {
                        gRegulacaoTermica.TabStop = false;
                        gRegulacaoTermica.TabIndex = (int)area;
                        flpRegulacaotermica.Controls.Clear();
                       
                        AddItensArea(treeNode, flpRegulacaotermica);
                        gRegulacaoTermica.Visible = treeNode.Parent.Checked;
                        break; 
                    } 
                case Area.Oxigenacao:
                    {
                        gSistemaOxigenacao.TabStop = false;
                        gSistemaOxigenacao.TabIndex = (int)area;
                        flpOxigenacao.Controls.Clear();

                        AddItensArea(treeNode, flpOxigenacao);
                        gSistemaOxigenacao.Visible = treeNode.Parent.Checked;
                        break; 
                    }
                case Area.Pele:
                    {
                        gPele.TabStop = false;
                        gPele.TabIndex = (int)area;
                        flpPele.Controls.Clear();

                        AddItensArea(treeNode, flpPele);
                        gPele.Visible = treeNode.Parent.Checked;
                        break;
                    }
                case Area.SistemaGastrointestinal:
                    {
                        gSistemaGastroIntestinal.TabStop = false;
                        gSistemaGastroIntestinal.TabIndex = (int)area;
                        flpSistemaGastroIntestinal.Controls.Clear();

                        AddItensArea(treeNode, flpSistemaGastroIntestinal);
                        gSistemaGastroIntestinal.Visible = treeNode.Parent.Checked;
                        break; 
                    }
                case Area.SistemaVascular:
                    {
                        gSistemaVascular.TabStop = false;
                        gSistemaVascular.TabIndex = (int)area;
                        flpSistemaVascular.Controls.Clear();

                        AddItensArea(treeNode, flpSistemaVascular);
                        gSistemaVascular.Visible = treeNode.Parent.Checked;
                        break;
                    }
                case Area.SistemaAbdominal:
                    {
                        gSistemaAbdominal.TabStop = false;
                        gSistemaAbdominal.TabIndex = (int)area;
                        flpSistemaAbdominal.Controls.Clear();

                        AddItensArea(treeNode, flpSistemaAbdominal);
                        gSistemaAbdominal.Visible = treeNode.Parent.Checked;
                        break;
                    }
                case Area.SistemaUrinario:
                    {
                        gSistemaUrinario.TabStop = false;
                        gSistemaUrinario.TabIndex = (int)area;
                        flpsistemaUrinario.Controls.Clear();

                        AddItensArea(treeNode, flpsistemaUrinario);
                        gSistemaUrinario.Visible = treeNode.Parent.Checked;
                        break;
                    }
                case Area.LesaoCompressao:
                    {
                        gLesaoCompressao.TabStop = false;
                        gLesaoCompressao.TabIndex = (int)area;
                        flpLesao.Controls.Clear();

                        AddItensArea(treeNode, flpLesao);
                        gLesaoCompressao.Visible = treeNode.Parent.Checked;
                        break;
                    }
                case Area.GloboPinard:
                    {
                        gPinard.TabStop = false;
                        gPinard.TabIndex = (int)area;
                        flpPinard.Controls.Clear();

                        AddItensArea(treeNode, flpPinard);
                        gPinard.Visible = treeNode.Parent.Checked;
                        break;
                    }
                case Area.ComaGlasgow:
                    {
                        gRespostaMotora.Visible = gRespostaVerbal.Visible = gAberturaOcular.Visible = false;
                        
                        foreach (TreeNode item in treeNode.Parent.Nodes)
                        {
                            areaCategoria = (AreaCategoriaItem)item.Tag;
                            if (item.Checked)
                            {
                                if (areaCategoria.Id == 86)
                                    gRespostaMotora.Visible = true;
                                if (areaCategoria.Id == 85)
                                    gRespostaVerbal.Visible = true;
                                if (areaCategoria.Id == 84)
                                    gAberturaOcular.Visible = true;
                            }
                        }

                        gGlasgow.Visible = treeNode.Parent.Checked;
                        break;
                    }
                case Area.ControleCateteres:
                    {
                        gCateterSonda.TabStop = false;
                        gCateterSonda.TabIndex = (int)area;
                        flpCateteres.Controls.Clear();

                        AddItensArea(treeNode, flpCateteres);
                        gCateterSonda.Visible = treeNode.Parent.Checked;
                        break;
                    }
                case Area.PressaoArterial:
                    {
                        gEscalaPressao.Visible = treeNode.Parent.Checked;
                        break;
                    }
                default:
                    break;
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
