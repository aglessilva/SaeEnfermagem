using AppInternacao.Enum;
using AppInternacao.Model;
using AppInternacao.Presenter;
using FontAwesome.Sharp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AppInternacao.FrmSae
{
    public partial class UI020FrmSaeTemplateArea : UI000FrmTemplate
    {
        private CRUD dbCrud = null;
        Panel panelAviso =  null;
        Label LabelAvisoPanel = null;

        public UI020FrmSaeTemplateArea()
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
        List<FlowLayoutPanel> flowLayoutPanels = new List<FlowLayoutPanel>();

        private void UI015FrmArea_Load(object sender, EventArgs e)
        {
            presenterGeneric = new PresenterGeneric();
            areaCategorias = presenterGeneric.GetLista(new AreaCategoria(), Procedure.SP_GET_CATEGORIAS_AREA);
            areaCategoriaItems = presenterGeneric.GetLista(new AreaCategoriaItem(), Procedure.SP_GET_CATEGORIAS_AREA_ITEMS);

           LabelAvisoPanel = new Label
            {
                Text = $"SELECIONE OS ITENS DAS CATEGORIAS AO LADO PARA CRIAR UM MODELO DE EXAME FÍSICO.{Environment.NewLine}" +
                $"ESSE MODELO DE EXAME PODERÁ SER UTILIZADO NA EVOLUÇÃO DO PACIENTE DURANTE A 'SAE'.",
                Font = new System.Drawing.Font("Microsoft Sans Serif", 12),
                ForeColor = System.Drawing.Color.FromArgb(13, 87, 134),
                AutoSize = true,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Location = new System.Drawing.Point(70,200)
            };

            panelAviso = new Panel 
            { 
                Dock = DockStyle.Fill,
                Visible = true, 
                BackColor = System.Drawing.Color.White,
            };
            panelAviso.Controls.Add(LabelAvisoPanel);
            panelBody.Controls.Add(panelAviso);

            areaCategorias.ForEach(n =>
            {
                treeViewCategorias.Nodes.Add(new TreeNode { Text = n.Nome, Name = n.Id.ToString(), Tag = n });
            });

            foreach (TreeNode item in treeViewCategorias.Nodes)
            {
                AreaCategoria area = (AreaCategoria)item.Tag;
                areaCategoriaItems.Where(i => i.IdArea == area.Id).ToList().ForEach(m =>
                {
                    if (m.IdAreaItem != 0)
                    {
                        TreeNode nivel3 = item.Nodes.Find(m.IdAreaItem.ToString(), false).FirstOrDefault();
                        nivel3.Nodes.Add(new TreeNode { Text = m.Descricao, Name = m.Id.ToString(), Tag = m });
                    }
                    else
                        item.Nodes.Add(new TreeNode { Text = m.Descricao, Name = m.Id.ToString(), Tag = m });

                });
            }

            comboBoxPressaoArterial.ValueMember = "Codigo";
            comboBoxPressaoArterial.DisplayMember = "Titulo";
            comboBoxPressaoArterial.DataSource = pressaoArterial;

            FrmMain.listButtons.ForEach(b =>
            {
                if (b.Name.Equals("btnSalvar"))
                {
                    b.Enabled = true;
                    b.IconChar = IconChar.Save;
                    b.Click += Salvar_Click;
                    b.Width = 80;
                    b.Text = "Salvar".Trim();
                }
            });
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                areaCategoriaItems = null;
                areaCategorias = null;
                flowLayoutPanels.Clear();

                Frm.FrmSalvarTemplate frm = new Frm.FrmSalvarTemplate() { TopLevel = true };
                var retorno = frm.ShowDialog();

                if (retorno == DialogResult.Cancel)
                    return;

                var lstGroupBox = panelBody.Controls.OfType<GroupBox>().Where(g => g.Controls.Count > 0 && g.Visible).ToList();

                if (lstGroupBox.Exists(n => n.Controls.OfType<GroupBox>().Any()))
                {
                    foreach (Control gbitem in lstGroupBox.SelectMany(s => s.Controls.OfType<GroupBox>()))
                    {
                        if (gbitem is GroupBox)
                        {
                            flowLayoutPanels.AddRange(gbitem.Controls.OfType<FlowLayoutPanel>().AsEnumerable());
                        }
                    }

                    lstGroupBox.RemoveAll(n => n.Controls.OfType<GroupBox>().Any());
                }

                var flps = lstGroupBox.SelectMany(s => s.Controls.OfType<FlowLayoutPanel>());
                flowLayoutPanels.AddRange(flps);
                areaCategoriaItems = flowLayoutPanels.SelectMany(s => s.Controls.OfType<RadioButton>().Select(t => (AreaCategoriaItem)t.Tag)).ToList();

                dbCrud = new CRUD();

                var codigoTemplate = dbCrud.Executar(new { SetorAssociado = frm.IdSetor, NomeTemplate = frm.NomeTemplate, DescricaoTemplate = frm.DescricaoTemplate }, Procedure.SP_ADD_NAME_TEMPLATE_EXAME_FISICO, Acao.Inserir);
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add(new DataColumn("IdTemplate", typeof(int)));
                dataTable.Columns.Add(new DataColumn("IdCliente", typeof(int)));
                dataTable.Columns.Add(new DataColumn("JsonTemplate", typeof(string)));
                
                DataRow dataRow = null;

                dataRow = dataTable.NewRow();
                dataRow["IdTemplate"] = codigoTemplate;
                dataRow["IdCliente"] = Sessao.CodigoCliente;
                dataRow["JsonTemplate"] = JsonConvert.SerializeObject(areaCategoriaItems, Formatting.None);
                dataTable.Rows.Add(dataRow);

                if (dataTable.Rows.Count > 0)
                {
                    var ret = dbCrud.BulkInsert(dataTable, "TB_Template_Exame_Fisico");

                    if (ret > 0)
                    {
                        FrmMain.mySalvar.Visible = false;
                        FrmMain.Alert(Alerts.InsertSuccess);
                        FrmMain.listButtons.ForEach(b => FrmMain.RemoveClickEvent(b));
                        Close();
                    }
                    else
                        FrmMain.Alert((Alerts)ret);
                }
            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
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
                        if (item.Nodes.Count > 0)
                        {
                            item.Checked = e.Node.Checked;

                            foreach (TreeNode nivel3 in item.Nodes)
                            {
                                nivel3.Checked = e.Node.Checked;
                                PopularItens(nivel3);
                            }
                        }
                        else
                        {
                            item.Checked = e.Node.Checked;
                            PopularItens(item);
                        }
                    }
                }
                else
                {
                    if(new[] {"84","85","86"}.Any(s => s.Equals(e.Node.Parent.Name)))
                        e.Node.Parent.Parent.Checked = e.Node.Parent.Nodes.OfType<TreeNode>().Any(c => c.Checked);

                    if (new[] { "84", "85", "86" }.Any(s => s.Equals(e.Node.Name)))
                    {
                        e.Node.Parent.Checked = e.Node.Parent.Nodes.OfType<TreeNode>().Any(c => c.Checked);
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
                }

                FrmMain.mySalvar.Visible = panelBody.Controls.OfType<GroupBox>().Any(g => g.Visible);
                panelAviso.Visible = !FrmMain.mySalvar.Visible;

                OrdenarGroup();

            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
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

        private void AddItensArea(TreeNode treeNode, FlowLayoutPanel flowLayoutPanel)
        {
            try
            {
                flowLayoutPanel.Controls.Clear();

                RadioButton radioButton = null;
                if (treeNode.Level == 0)
                {
                    foreach (TreeNode item in treeNode.Nodes)
                    {
                        AreaCategoriaItem areaCategoriaItem = (AreaCategoriaItem)item.Tag;
                        radioButton = new RadioButton { Text = item.Text ,Tag = item.Tag, TabIndex = areaCategoriaItem.Id , AutoSize = true };
                        flowLayoutPanel.TabIndex = areaCategoriaItem.IdArea;
                        flowLayoutPanel.Controls.Add(radioButton);
                    }
                }
                else
                {
                    foreach (TreeNode item in treeNode.Parent.Nodes)
                    {
                        if (!treeNode.Parent.Checked)
                        {
                            item.Checked = treeNode.Parent.Checked;
                            continue;
                        }

                        if (item.Checked)
                        {
                            AreaCategoriaItem areaCategoriaItem = (AreaCategoriaItem)item.Tag;
                            radioButton = new RadioButton { Text = item.Text, Tag = item.Tag, TabIndex = areaCategoriaItem.Id, AutoSize = true };
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
                        
                        AddItensArea(treeNode, flpSistemaNerologico);
                        gSistemaNeurologico.Visible = treeNode.Parent.Checked;
                        break;
                    }
                case Area.Pupilas:
                    {
                        gPupilas.TabStop = false;
                        gPupilas.TabIndex = (int)area;

                        AddItensArea(treeNode, flpPupilas);
                        gPupilas.Visible = treeNode.Parent.Checked;
                        break;
                    }
                case Area.RegulacaoTermica:
                    {
                        gRegulacaoTermica.TabStop = false;
                        gRegulacaoTermica.TabIndex = (int)area;
                       
                        AddItensArea(treeNode, flpRegulacaotermica);
                        gRegulacaoTermica.Visible = treeNode.Parent.Checked;
                        break; 
                    } 
                case Area.Oxigenacao:
                    {
                        gSistemaOxigenacao.TabStop = false;
                        gSistemaOxigenacao.TabIndex = (int)area;

                        AddItensArea(treeNode, flpOxigenacao);
                        gSistemaOxigenacao.Visible = treeNode.Parent.Checked;
                        break; 
                    }
                case Area.Pele:
                    {
                        gPele.TabStop = false;
                        gPele.TabIndex = (int)area;

                        AddItensArea(treeNode, flpPele);
                        gPele.Visible = treeNode.Parent.Checked;
                        break;
                    }
                case Area.SistemaGastrointestinal:
                    {
                        gSistemaGastroIntestinal.TabStop = false;
                        gSistemaGastroIntestinal.TabIndex = (int)area;

                        AddItensArea(treeNode, flpSistemaGastroIntestinal);
                        gSistemaGastroIntestinal.Visible = treeNode.Parent.Checked;
                        break; 
                    }
                case Area.SistemaVascular:
                    {
                        gSistemaVascular.TabStop = false;
                        gSistemaVascular.TabIndex = (int)area;

                        AddItensArea(treeNode, flpSistemaVascular);
                        gSistemaVascular.Visible = treeNode.Parent.Checked;
                        break;
                    }
                case Area.SistemaAbdominal:
                    {
                        gSistemaAbdominal.TabStop = false;
                        gSistemaAbdominal.TabIndex = (int)area;

                        AddItensArea(treeNode, flpSistemaAbdominal);
                        gSistemaAbdominal.Visible = treeNode.Parent.Checked;
                        break;
                    }
                case Area.SistemaUrinario:
                    {
                        gSistemaUrinario.TabStop = false;
                        gSistemaUrinario.TabIndex = (int)area;

                        AddItensArea(treeNode, flpsistemaUrinario);
                        gSistemaUrinario.Visible = treeNode.Parent.Checked;
                        break;
                    }
                case Area.LesaoCompressao:
                    {
                        gLesaoCompressao.TabStop = false;
                        gLesaoCompressao.TabIndex = (int)area;

                        AddItensArea(treeNode, flpLesao);
                        gLesaoCompressao.Visible = treeNode.Parent.Checked;
                        break;
                    }
                case Area.GloboPinard:
                    {
                        gPinard.TabStop = false;
                        gPinard.TabIndex = (int)area;

                        AddItensArea(treeNode, flpPinard);
                        gPinard.Visible = treeNode.Parent.Checked;
                        break;
                    }
                case Area.ComaGlasgow:
                    {
                        foreach (TreeNode item in treeNode.Parent.Nodes)
                        {
                            areaCategoria = (AreaCategoriaItem)item.Tag;
                            if (item.Checked)
                            {
                                if (areaCategoria.IdAreaItem == 86)
                                {
                                    gRespostaMotora.TabStop = false;
                                    gRespostaMotora.TabIndex = (int)area;

                                    gRespostaMotora.Visible = item.Parent.Checked;

                                    if (treeNode.Parent.Checked)
                                        AddItensArea(item, flpRespostaMotora);
                                    else
                                    {
                                        flpRespostaMotora.Controls.Clear();
                                        break;
                                    }
                                }
                                if (areaCategoria.IdAreaItem == 85)
                                {
                                    gRespostaVerbal.TabStop = false;
                                    gRespostaVerbal.TabIndex = (int)area;

                                    gRespostaVerbal.Visible = item.Parent.Checked;

                                    if (treeNode.Parent.Checked)
                                        AddItensArea(item, flpRespostaVerbal);
                                    else
                                    {
                                        flpRespostaVerbal.Controls.Clear();
                                        break;
                                    }
                                }
                                if (areaCategoria.IdAreaItem == 84)
                                {
                                    gAberturaOcular.TabStop = false;
                                    gAberturaOcular.TabIndex = (int)area;

                                    gAberturaOcular.Visible = item.Parent.Checked;

                                    if (treeNode.Parent.Checked)
                                        AddItensArea(item, flpRespostaOcular);
                                    else
                                    {
                                        flpRespostaOcular.Controls.Clear();
                                        break;
                                    }
                                }
                            }
                        }

                        if (!treeNode.Parent.Parent.Checked)
                        {
                            flpRespostaVerbal.Controls.Clear(); flpRespostaOcular.Controls.Clear(); flpRespostaMotora.Controls.Clear();
                        }

                        gGlasgow.Visible = (flpRespostaVerbal.Controls.Count > 0 || flpRespostaOcular.Controls.Count > 0 || flpRespostaMotora.Controls.Count > 0);
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

                        if (treeNode.Parent.Checked)
                            flpPressaoArterial.Controls.Add(new RadioButton { Tag = (AreaCategoriaItem)treeNode.Tag, Visible = false, Name = treeNode.Name });
                        else
                            flpPressaoArterial.Controls.RemoveByKey(treeNode.Name);

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
