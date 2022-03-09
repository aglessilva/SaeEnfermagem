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
        private CRUD dbCrud = null;
        Panel panelAviso =  null;
        Label LabelAvisoPanel = null;

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

            FrmMain.mySalvar.Click += Salvar_Click;
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                Frm.FrmSalvarTemplate frm = new Frm.FrmSalvarTemplate() { TopLevel = true };
                var retorno = frm.ShowDialog();

                if (retorno == DialogResult.Cancel)
                    return;

                dbCrud = new CRUD();

                var codigoTemplate = dbCrud.Executar(new { NomeTemplate = frm.NomeTemplate, DescricaoTemplate = frm.DescricaoTemplate }, Procedure.SP_ADD_NAME_TEMPLATE_EXAME_FISICO, Acao.Inserir);
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add(new DataColumn("IdTemplate", typeof(int)));
                dataTable.Columns.Add(new DataColumn("IdCliente", typeof(int)));
                dataTable.Columns.Add(new DataColumn("IdItem", typeof(string)));
                dataTable.Columns.Add(new DataColumn("IdArea", typeof(int)));
                
                DataRow dataRow = null;
                
                var flowLayoutPanels = panelBody.Controls.OfType<GroupBox>().Where(g => g.Visible).Select(s => s.Controls.OfType<FlowLayoutPanel>()).ToArray();
                List<AreaCategoriaItem> lstRadiosButton = null;
                List<string> lstIdItem = new List<string>();
                AreaCategoria areaCategoria = null;



                foreach (var item in flowLayoutPanels)
                {
                    lstIdItem.Clear();
                    lstRadiosButton?.Clear();

                    if (item.FirstOrDefault() == null)
                    {
                        areaCategoria = (AreaCategoria)panelBody.Controls.OfType<GroupBox>().Where(g => g.Visible && g.Tag != null).FirstOrDefault(s => ((AreaCategoria)s.Tag).Id == 12).Tag;

                        if (gGlasgow.Visible)
                        {
                            gGlasgow.Controls.OfType<GroupBox>().Where(g => g.Visible).ToList()
                                .ForEach(f =>
                                {
                                    AreaCategoriaItem areaItem = (AreaCategoriaItem)f.Tag;
                                    lstIdItem.Add(areaItem.Id.ToString());
                                });
                        }
                    }
                    else
                    {
                        lstRadiosButton = item.Select(d => d.Controls.OfType<RadioButton>().Select(s => (AreaCategoriaItem)s.Tag).ToList()).Select(s => s).FirstOrDefault().ToList();
                        if (lstRadiosButton.Count > 0)
                            foreach (var itemRadio in lstRadiosButton)
                                lstIdItem.Add(itemRadio.Id.ToString());

                        areaCategoria = (AreaCategoria)item.FirstOrDefault().Tag;
                    }

                    dataRow = dataTable.NewRow();
                    dataRow["IdTemplate"] = codigoTemplate;
                    dataRow["IdCliente"] = Sessao.CodigoCliente;
                    dataRow["IdItem"] = lstIdItem?.Count > 0 ? string.Join(",", lstIdItem) : areaCategoria.Id.ToString();
                    dataRow["IdArea"] = lstRadiosButton?.Count > 0 ? lstRadiosButton[0].IdArea : areaCategoria.Id;
                    dataTable.Rows.Add(dataRow);
                }

                if (dataTable.Rows.Count > 0)
                {
                   var ret = dbCrud.BulkInsert(dataTable, "TB_Template_Exame_Fisico");

                    if (ret > 0)
                    {
                        FrmMain.Alert(Alerts.InsertSuccess);
                        FrmMain.listButtons.ForEach(b => FrmMain.RemoveClickEvent(b));
                        this.Close();
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
                        item.Checked = e.Node.Checked;
                        PopularItens(item);
                    }
                }
                else
                {
                    e.Node.Parent.Checked = e.Node.Parent.Nodes.OfType<TreeNode>().Any(c => c.Checked);
                    PopularItens(e.Node);
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
                                {
                                    gRespostaMotora.Visible = true;
                                    gRespostaMotora.Tag = areaCategoria;
                                }
                                if (areaCategoria.Id == 85)
                                {
                                    gRespostaVerbal.Visible = true;
                                    gRespostaVerbal.Tag = areaCategoria;
                                }
                                if (areaCategoria.Id == 84)
                                {
                                    gAberturaOcular.Visible = true;
                                    gAberturaOcular.Tag = areaCategoria;
                                }
                            }
                        }

                        gGlasgow.Visible = treeNode.Parent.Checked;
                        gGlasgow.Tag = new AreaCategoria { Id = areaCategoria.IdArea, StatusArea = areaCategoria.IsAtivo, Nome = areaCategoria.Descricao };
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
                        flpPressaoArterial.Tag = gEscalaPressao.Tag = (AreaCategoria)treeNode.Parent.Tag;
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
