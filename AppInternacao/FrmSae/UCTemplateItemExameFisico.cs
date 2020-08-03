using AppInternacao.Enum;
using AppInternacao.Model;
using AppInternacao.Presenter;
using AppInternacao.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AppInternacao.FrmSae
{
    public partial class UCTemplateItemExameFisico : UserControl, IArea_Itens
    {
        DataTable tabelaItens = null;
        TemplateExamePresenter templateExamePresenter = null;
        List<Area_Itens> lstAreaItem = new List<Area_Itens>();
        TemplateName templateName = null;
        Panel accordion = null;
        PictureBox buttonTyp = null;
        int[] _coutItens = new int[14];

        public UCTemplateItemExameFisico(TemplateName _templateName)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            lbltituloExame.Text = "Template: " + _templateName.Nome;
            templateName = _templateName;
        }

       

        public List<Area_Itens> area_Itens
        {
            set
            {
                ListViewItem lvi = null;
                //lvi = new ListViewItem("1");
                //lvi.SubItems.Add("Conciente");
                //listViewTemplateSistemaNeurologico.Items.Add(lvi);
                List<Area_Itens> lst = new List<Area_Itens>();// { new Area_Itens() { Id = 1, IdArea = Area.SistemaNeurologico, Nome = "Conciente" } };

                foreach (Area_Itens item in value)
                {
                    switch (item.IdArea)
                    {
                        case Area.SistemaNeurologico:
                            {
                                if (lst.Where(area => area.IdArea == Area.SistemaNeurologico).Any(i => i.Id == item.Id))
                                    continue;
                                lvi = new ListViewItem(item.Id.ToString());
                                lvi.SubItems.Add(item.Nome.ToString());
                                listViewItemSistemaNeurologico.Items.Add(lvi);
                                break;
                            }
                        case Area.Pupilas:
                            {
                                if (lst.Where(area => area.IdArea == Area.Pupilas).Any(i => i.Id == item.Id))
                                    continue;
                                lvi = new ListViewItem(item.Id.ToString());
                                lvi.SubItems.Add(item.Nome.ToString());
                                listViewPuplias.Items.Add(lvi);
                                break;
                            }
                        case Area.RegulacaoTermica:
                            {
                                if (lst.Where(area => area.IdArea == Area.RegulacaoTermica).Any(i => i.Id == item.Id))
                                    continue;
                                lvi = new ListViewItem(item.Id.ToString());
                                lvi.SubItems.Add(item.Nome.ToString());
                                listViewRegulacaoTermica.Items.Add(lvi);
                                break;
                            }
                        case Area.Oxigenacao:
                            {
                                if (lst.Where(area => area.IdArea == Area.Oxigenacao).Any(i => i.Id == item.Id))
                                    continue;
                                lvi = new ListViewItem(item.Id.ToString());
                                lvi.SubItems.Add(item.Nome.ToString());
                                listViewOxigenacao.Items.Add(lvi);
                                break;
                            }
                        case Area.Pele:
                            {
                                if (lst.Where(area => area.IdArea == Area.Pele).Any(i => i.Id == item.Id))
                                    continue;
                                lvi = new ListViewItem(item.Id.ToString());
                                lvi.SubItems.Add(item.Nome.ToString());
                                listViewPele.Items.Add(lvi);
                                break;
                            }
                        case Area.SistemaGastrointestinal:
                            {
                                if (lst.Where(area => area.IdArea == Area.SistemaGastrointestinal).Any(i => i.Id == item.Id))
                                    continue;
                                lvi = new ListViewItem(item.Id.ToString());
                                lvi.SubItems.Add(item.Nome.ToString());
                                listViewSistemaGastrointestinal.Items.Add(lvi);
                                break;
                            }
                        case Area.SistemaVascular:
                            {
                                if (lst.Where(area => area.IdArea == Area.SistemaVascular).Any(i => i.Id == item.Id))
                                    continue;
                                lvi = new ListViewItem(item.Id.ToString());
                                lvi.SubItems.Add(item.Nome.ToString());
                                listViewSistemaVascular.Items.Add(lvi);
                                break;
                            }
                        case Area.SistemaAbdominal:
                            {
                                if (lst.Where(area => area.IdArea == Area.SistemaAbdominal).Any(i => i.Id == item.Id))
                                    continue;
                                lvi = new ListViewItem(item.Id.ToString());
                                lvi.SubItems.Add(item.Nome.ToString());
                                listViewSistemaAbdominal.Items.Add(lvi);
                                break;
                            }
                        case Area.SistemaUrinario:
                            {
                                if (lst.Where(area => area.IdArea == Area.SistemaUrinario).Any(i => i.Id == item.Id))
                                    continue;
                                lvi = new ListViewItem(item.Id.ToString());
                                lvi.SubItems.Add(item.Nome.ToString());
                                listViewSistemaUrinario.Items.Add(lvi);
                                break;
                            }
                        case Area.LesaoCompressao:
                            {
                                if (lst.Where(area => area.IdArea == Area.LesaoCompressao).Any(i => i.Id == item.Id))
                                    continue;
                                lvi = new ListViewItem(item.Id.ToString());
                                lvi.SubItems.Add(item.Nome.ToString());
                                listViewLesaoCompressao.Items.Add(lvi);
                                break;
                            }
                        case Area.GloboPinard:
                            {
                                if (lst.Where(area => area.IdArea == Area.GloboPinard).Any(i => i.Id == item.Id))
                                    continue;
                                lvi = new ListViewItem(item.Id.ToString());
                                lvi.SubItems.Add(item.Nome.ToString());
                                listViewPinard.Items.Add(lvi);
                                break;
                            }
                        case Area.ComaGlasgow:
                            {
                                if (lst.Where(area => area.IdArea == Area.ComaGlasgow).Any(i => i.Id == item.Id))
                                    continue;
                                lvi = new ListViewItem(item.Id.ToString());
                                lvi.SubItems.Add(item.Nome.ToString());
                                listViewGlasgow.Items.Add(lvi);
                                break;
                            }
                        case Area.ControleCateteres:
                            {
                                if (lst.Where(area => area.IdArea == Area.ControleCateteres).Any(i => i.Id == item.Id))
                                    continue;
                                lvi = new ListViewItem(item.Id.ToString());
                                lvi.SubItems.Add(item.Nome.ToString());
                                listViewCatetres.Items.Add(lvi);
                                break;
                            }
                        case Area.PressaoArterial:
                            {
                                if (lst.Where(area => area.IdArea == Area.PressaoArterial).Any(i => i.Id == item.Id))
                                    continue;
                                lvi = new ListViewItem(item.Id.ToString());
                                lvi.SubItems.Add(item.Nome.ToString());
                                listViewPressaoArterialOutros.Items.Add(lvi);
                                break;
                            }
                        default:
                            break;
                    }
                }
            }
        }

        private void UCTemplateExameFisico_Load(object sender, EventArgs e)
        {
            FrmMain.mySalvar.Click += new EventHandler(Salvar);
            FrmMain.myNovo.Click -= new EventHandler(MyNovo_Click);
            new ToolTip().SetToolTip(btnStepVoltar, "Voltar para tela anterior");
            templateExamePresenter = new TemplateExamePresenter(this);
            templateExamePresenter.GetAreaItens();
            tabelaItens = CriarTabela();
        }


        private void MyNovo_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Salvar(object sender, EventArgs e)
        {
            try
            {
                DataView dv = tabelaItens.DefaultView;
                dv.Sort = "IdItem asc";
                tabelaItens = dv.ToTable();

                FrmMain.Alert(templateExamePresenter.BulkInsert(tabelaItens, "TB_TemplateExame_Itens"));
                btnStepVoltar_Click(null, null);
            }
            catch (Exception exSalvar)
            {
                FrmMain.Alert(0,exSalvar);
            }
        }

        void CountItem()
        {
            _coutItens[0] = tabelaItens.Select().Count(c => (Area)c.ItemArray[3] == Area.SistemaNeurologico);
            _coutItens[1] = tabelaItens.Select().Count(c => (Area)c.ItemArray[3] == Area.Pupilas);
            _coutItens[2] = tabelaItens.Select().Count(c => (Area)c.ItemArray[3] == Area.RegulacaoTermica);
            _coutItens[3] = tabelaItens.Select().Count(c => (Area)c.ItemArray[3] == Area.Oxigenacao);
            _coutItens[4] = tabelaItens.Select().Count(c => (Area)c.ItemArray[3] == Area.Pele);
            _coutItens[5] = tabelaItens.Select().Count(c => (Area)c.ItemArray[3] == Area.SistemaGastrointestinal);
            _coutItens[6] = tabelaItens.Select().Count(c => (Area)c.ItemArray[3] == Area.SistemaVascular);
            _coutItens[7] = tabelaItens.Select().Count(c => (Area)c.ItemArray[3] == Area.SistemaAbdominal);
            _coutItens[8] = tabelaItens.Select().Count(c => (Area)c.ItemArray[3] == Area.SistemaUrinario);
            _coutItens[9] = tabelaItens.Select().Count(c => (Area)c.ItemArray[3] == Area.LesaoCompressao);
            _coutItens[10] = tabelaItens.Select().Count(c => (Area)c.ItemArray[3] == Area.GloboPinard);
            _coutItens[11] = tabelaItens.Select().Count(c => (Area)c.ItemArray[3] == Area.ComaGlasgow);
            _coutItens[12] = tabelaItens.Select().Count(c => (Area)c.ItemArray[3] == Area.ControleCateteres);
            _coutItens[13] = tabelaItens.Select().Count(c => (Area)c.ItemArray[3] == Area.PressaoArterial);

            lblTotalNeurologico.Visible = _coutItens[0] > 0;
            lblTotalNeurologico.Text = $"Total Itens: {_coutItens[0]}";

            lblTotalPupila.Visible = _coutItens[1] > 0;
            lblTotalPupila.Text = $"Total Itens: {_coutItens[1]}";

            lblTotalTermina.Visible = _coutItens[2] > 0;
            lblTotalTermina.Text = $"Total Itens: {_coutItens[2]}";

            lblTotalOxigenacao.Visible = _coutItens[3] > 0;
            lblTotalOxigenacao.Text = $"Total Itens: {_coutItens[3]}";

            lblTotalPele.Visible = _coutItens[4] > 0;
            lblTotalPele.Text = $"Total Itens: {_coutItens[4]}";

            lblTotalGastro.Visible = _coutItens[5] > 0;
            lblTotalGastro.Text = $"Total Itens: {_coutItens[5]}";

            lblTotalVascular.Visible = _coutItens[6] > 0;
            lblTotalVascular.Text = $"Total Itens: {_coutItens[6]}";

            lblTotalAbdominal.Visible = _coutItens[7] > 0;
            lblTotalAbdominal.Text = $"Total Itens: {_coutItens[7]}";

            lblTotalUrinario.Visible = _coutItens[8] > 0;
            lblTotalUrinario.Text = $"Total Itens: {_coutItens[8]}";

            lblTotalCompressao.Visible = _coutItens[9] > 0;
            lblTotalCompressao.Text = $"Total Itens: {_coutItens[9]}";

            lblTotalPinard.Visible = _coutItens[10] > 0;
            lblTotalPinard.Text = $"Total Itens: {_coutItens[10]}";

            lblTotalGlasgow.Visible = _coutItens[11] > 0;
            lblTotalGlasgow.Text = $"Total Itens: {_coutItens[11]}";

            lblTotalCatetere.Visible = _coutItens[12] > 0;
            lblTotalCatetere.Text = $"Total Itens: {_coutItens[12]}";

            lblTotalOutros.Visible = _coutItens[13] > 0;
            lblTotalOutros.Text = $"Total Itens: {_coutItens[13]}";

        }

        void AdicionaItem(Area _area, ListView[] _ListView, DragEventArgs e)
        {
            ListViewItem view = (ListViewItem)e.Data.GetData(DataFormats.Serializable);

            try
            {
                _ListView[0].Items.Remove(view);
                _ListView[1].Items.Add(view);
            }
            catch(Exception)
            {
                return;
            }

            int codigo = Convert.ToInt32(view.SubItems[0].Text);
            DataRow dataRow = tabelaItens.NewRow();
            dataRow["IdCliente"] = Sessao.CodigoCliente;
            dataRow["IdTemplate"] = templateName.Id;
            dataRow["IdUsuario"] = Sessao.Usuario.Id;
            dataRow["IdArea"] = (int)_area;
            dataRow["IdItem"] = codigo;
            dataRow["Nome"] = view.SubItems[1].Text;
            tabelaItens.Rows.Add(dataRow);

            CountItem();
            btnVisualizarTemplate.Visible = tabelaItens.Rows.Count > 0;
        }

        void RemoverItem(ListView[] _listview, DragEventArgs e )
        {
            ListViewItem view = (ListViewItem)e.Data.GetData(DataFormats.Serializable);
            try
            {
                _listview[1].Items.Remove(view);
                _listview[0].Items.Add(view);
            }
            catch (Exception)
            {
                return;
            }

            int codigo = Convert.ToInt32(view.SubItems[0].Text);
            DataRow dataRow = tabelaItens.Select($"IdItem = {codigo}").FirstOrDefault();

            if (dataRow != null)
                tabelaItens.Rows.Remove(dataRow);

            CountItem();
            btnVisualizarTemplate.Visible = tabelaItens.Rows.Count > 0;

        }

        private DataTable CriarTabela()
        {
            var table = new DataTable();
            table.Columns.Add("IdCliente", typeof(int));
            table.Columns.Add("IdTemplate", typeof(int));
            table.Columns.Add("IdUsuario", typeof(int));
            table.Columns.Add("IdArea", typeof(int));
            table.Columns.Add("IdItem", typeof(int));
            table.Columns.Add("Nome", typeof(string));

            return table;
        }

        private void listViewTemplateSistemaNeurologico_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listViewTemplateSistemaNeurologico_DragDrop(object sender, DragEventArgs e)
        {
            ListView[] views = { listViewItemSistemaNeurologico, listViewTemplateSistemaNeurologico };
            ListViewItem view = (ListViewItem)e.Data.GetData(DataFormats.Serializable);

            if (listViewTemplateSistemaNeurologico.Items.Contains(view))
                return;
            else
            {
                AdicionaItem(Area.SistemaNeurologico, views, e);
            }
        }

        private void listViewTemplateSistemaNeurologico_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listViewItemSistemaNeurologico.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void listViewItemSistemaNeurologico_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listViewTemplateSistemaNeurologico.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void listViewItemSistemaNeurologico_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listViewItemSistemaNeurologico_DragDrop(object sender, DragEventArgs e)
        {

            ListView[] views = { listViewItemSistemaNeurologico, listViewTemplateSistemaNeurologico };
            ListViewItem view = (ListViewItem)e.Data.GetData(DataFormats.Serializable);

            if (listViewItemSistemaNeurologico.Items.Contains(view))
                return;
            else
            {
                RemoverItem(views, e);
            }
          
        }

        private void VisualizarTemplate(object sender, EventArgs e)
        {
            new FrmViewTemplate(tabelaItens).ShowDialog();
        }

        private void btnStepVoltar_Click(object sender, EventArgs e)
        {
            SplitterPanel ctrl = (SplitterPanel)Parent;
            ctrl.Controls.Add(new UCNomeTemplate());
            Dispose(true);
        }

        private void listViewPuplias_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listViewTemplatePuplias.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void listViewPuplias_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listViewPuplias_DragDrop(object sender, DragEventArgs e)
        {
            ListView[] views = { listViewPuplias, listViewTemplatePuplias };
            ListViewItem view = (ListViewItem)e.Data.GetData(DataFormats.Serializable);

            if (listViewPuplias.Items.Contains(view))
                return;
            else
            {
                RemoverItem(views, e);
            }
        }

        private void listViewTemplatePuplias_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listViewPuplias.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void listViewTemplatePuplias_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listViewTemplatePuplias_DragDrop(object sender, DragEventArgs e)
        {
            ListView[] views = {listViewPuplias, listViewTemplatePuplias };
            ListViewItem view = (ListViewItem)e.Data.GetData(DataFormats.Serializable);

            if (listViewTemplatePuplias.Items.Contains(view))
                return;
            else
            {
                AdicionaItem(Area.Pupilas, views, e);
            }
        }

        private void listViewRegulacaoTermica_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listViewTemplateRegulacaoTermica.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void listViewRegulacaoTermica_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listViewRegulacaoTermica_DragDrop(object sender, DragEventArgs e)
        {
            ListView[] views = { listViewRegulacaoTermica, listViewTemplateRegulacaoTermica };
            ListViewItem view = (ListViewItem)e.Data.GetData(DataFormats.Serializable);

            if (listViewRegulacaoTermica.Items.Contains(view))
                return;
            else
            {
                RemoverItem(views, e);
            }
        }

        private void listViewTemplateRegulacaoTermica_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listViewRegulacaoTermica.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void listViewTemplateRegulacaoTermica_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listViewTemplateRegulacaoTermica_DragDrop(object sender, DragEventArgs e)
        {
            ListView[] views = { listViewRegulacaoTermica, listViewTemplateRegulacaoTermica };
            ListViewItem view = (ListViewItem)e.Data.GetData(DataFormats.Serializable);

            if (listViewTemplateRegulacaoTermica.Items.Contains(view))
                return;
            else
            {
                AdicionaItem(Area.RegulacaoTermica, views, e);
            }
        }

        private void listViewOxigenacao_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listViewOxigenacao_DragDrop(object sender, DragEventArgs e)
        {
            ListView[] views = { listViewOxigenacao, listViewTemplateOxigenacao };
            ListViewItem view = (ListViewItem)e.Data.GetData(DataFormats.Serializable);

            if (listViewOxigenacao.Items.Contains(view))
                return;
            else
            {
                RemoverItem(views, e);
            }
        }

        private void listViewOxigenacao_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listViewTemplateOxigenacao.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void listViewTemplateOxigenacao_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listViewOxigenacao.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void listViewTemplateOxigenacao_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listViewTemplateOxigenacao_DragDrop(object sender, DragEventArgs e)
        {
            ListView[] views = { listViewOxigenacao, listViewTemplateOxigenacao };
            ListViewItem view = (ListViewItem)e.Data.GetData(DataFormats.Serializable);

            if (listViewTemplateOxigenacao.Items.Contains(view))
                return;
            else
            {
                AdicionaItem(Area.Oxigenacao, views, e);
            }
        }

        private void listViewPele_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listViewPele_DragDrop(object sender, DragEventArgs e)
        {
            ListView[] views = { listViewPele, listViewTemplatePele };
            ListViewItem view = (ListViewItem)e.Data.GetData(DataFormats.Serializable);

            if (listViewPele.Items.Contains(view))
                return;
            else
            {
                RemoverItem(views, e);
            }
        }

        private void listViewPele_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listViewTemplatePele.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void listViewTemplatePele_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listViewPele.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void listViewTemplatePele_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listViewTemplatePele_DragDrop(object sender, DragEventArgs e)
        {
            ListView[] views = { listViewPele, listViewTemplatePele };
            ListViewItem view = (ListViewItem)e.Data.GetData(DataFormats.Serializable);

            if (listViewTemplatePele.Items.Contains(view))
                return;
            else
            {
                AdicionaItem(Area.Pele, views, e);
            }
        }

        private void listViewSistemaGastrointestinal_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listViewSistemaGastrointestinal_DragDrop(object sender, DragEventArgs e)
        {
            ListView[] views = { listViewSistemaGastrointestinal, listViewTemplateSistemaGastrointestinal };
            ListViewItem view = (ListViewItem)e.Data.GetData(DataFormats.Serializable);

            if (listViewSistemaGastrointestinal.Items.Contains(view))
                return;
            else
            {
                RemoverItem(views, e);
            }
        }

        private void listViewSistemaGastrointestinal_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listViewTemplateSistemaGastrointestinal.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void listViewTemplateSistemaGastrointestinal_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listViewSistemaGastrointestinal.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void listViewTemplateSistemaGastrointestinal_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listViewTemplateSistemaGastrointestinal_DragDrop(object sender, DragEventArgs e)
        {
            ListView[] views = { listViewSistemaGastrointestinal, listViewTemplateSistemaGastrointestinal };
            ListViewItem view = (ListViewItem)e.Data.GetData(DataFormats.Serializable);

            if (listViewTemplateSistemaGastrointestinal.Items.Contains(view))
                return;
            else
            {
                AdicionaItem(Area.SistemaGastrointestinal, views, e);
            }
        }

        private void listViewSistemaVascular_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listViewSistemaVascular_DragDrop(object sender, DragEventArgs e)
        {
            ListView[] views = { listViewSistemaVascular, listViewTemplateSistemaVascular };
            ListViewItem view = (ListViewItem)e.Data.GetData(DataFormats.Serializable);

            if (listViewSistemaVascular.Items.Contains(view))
                return;
            else
            {
                RemoverItem(views, e);
            }
        }

        private void listViewSistemaVascular_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listViewTemplateSistemaVascular.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void listViewTemplateSistemaVascular_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listViewSistemaVascular.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void listViewTemplateSistemaVascular_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listViewTemplateSistemaVascular_DragDrop(object sender, DragEventArgs e)
        {
            ListView[] views = { listViewSistemaVascular, listViewTemplateSistemaVascular };
            ListViewItem view = (ListViewItem)e.Data.GetData(DataFormats.Serializable);

            if (listViewTemplateSistemaVascular.Items.Contains(view))
                return;
            else
            {
                AdicionaItem(Area.SistemaVascular, views, e);
            }
        }

        private void listViewSistemaAbdominal_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listViewSistemaAbdominal_DragDrop(object sender, DragEventArgs e)
        {
            ListView[] views = { listViewSistemaAbdominal, listViewTemplateSistemaAbdominal };
            ListViewItem view = (ListViewItem)e.Data.GetData(DataFormats.Serializable);

            if (listViewSistemaAbdominal.Items.Contains(view))
                return;
            else
            {
                RemoverItem(views, e);
            }
        }

        private void listViewSistemaAbdominal_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listViewTemplateSistemaAbdominal.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void listViewTemplateSistemaAbdominal_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listViewSistemaAbdominal.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void listViewTemplateSistemaAbdominal_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listViewTemplateSistemaAbdominal_DragDrop(object sender, DragEventArgs e)
        {
            ListView[] views = { listViewSistemaAbdominal, listViewTemplateSistemaAbdominal };
            ListViewItem view = (ListViewItem)e.Data.GetData(DataFormats.Serializable);

            if (listViewTemplateSistemaAbdominal.Items.Contains(view))
                return;
            else
            {
                AdicionaItem(Area.SistemaAbdominal, views, e);
            }
        }

        private void listViewSistemaUrinario_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listViewSistemaUrinario_DragDrop(object sender, DragEventArgs e)
        {
            ListView[] views = { listViewSistemaUrinario, listViewTemplateSistemaUrinario };
            ListViewItem view = (ListViewItem)e.Data.GetData(DataFormats.Serializable);

            if (listViewSistemaUrinario.Items.Contains(view))
                return;
            else
            {
                RemoverItem(views, e);
            }
        }

        private void listViewSistemaUrinario_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listViewTemplateSistemaUrinario.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void listViewTemplateSistemaUrinario_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listViewSistemaUrinario.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void listViewTemplateSistemaUrinario_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listViewTemplateSistemaUrinario_DragDrop(object sender, DragEventArgs e)
        {
            ListView[] views = { listViewSistemaUrinario, listViewTemplateSistemaUrinario };
            ListViewItem view = (ListViewItem)e.Data.GetData(DataFormats.Serializable);

            if (listViewTemplateSistemaUrinario.Items.Contains(view))
                return;
            else
            {
                AdicionaItem(Area.SistemaUrinario, views, e);
            }
        }

        private void listViewLesaoCompressao_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listViewLesaoCompressao_DragDrop(object sender, DragEventArgs e)
        {
            ListView[] views = { listViewLesaoCompressao, listViewTemplateLesaoCompressao };
            ListViewItem view = (ListViewItem)e.Data.GetData(DataFormats.Serializable);

            if (listViewLesaoCompressao.Items.Contains(view))
                return;
            else
            {
                RemoverItem(views, e);
            }
        }

        private void listViewLesaoCompressao_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listViewTemplateLesaoCompressao.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void listViewTemplateLesaoCompressao_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listViewLesaoCompressao.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void listViewTemplateLesaoCompressao_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listViewTemplateLesaoCompressao_DragDrop(object sender, DragEventArgs e)
        {
            ListView[] views = { listViewLesaoCompressao, listViewTemplateLesaoCompressao };
            ListViewItem view = (ListViewItem)e.Data.GetData(DataFormats.Serializable);

            if (listViewTemplateLesaoCompressao.Items.Contains(view))
                return;
            else
            {
                AdicionaItem(Area.LesaoCompressao, views, e);
            }
        }

        private void listViewPinard_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listViewPinard_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listViewTemplatePinard.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void listViewPinard_DragDrop(object sender, DragEventArgs e)
        {
            ListView[] views = { listViewPinard, listViewTemplatePinard };
            ListViewItem view = (ListViewItem)e.Data.GetData(DataFormats.Serializable);

            if (listViewPinard.Items.Contains(view))
                return;
            else
            {
                RemoverItem(views, e);
            }
        }

        private void listViewTemplatePinard_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listViewPinard.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void listViewTemplatePinard_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listViewTemplatePinard_DragDrop(object sender, DragEventArgs e)
        {
            ListView[] views = { listViewPinard, listViewTemplatePinard };
            ListViewItem view = (ListViewItem)e.Data.GetData(DataFormats.Serializable);

            if (listViewTemplatePinard.Items.Contains(view))
                return;
            else
            {
                AdicionaItem(Area.GloboPinard, views, e);
            }
        }

        private void listViewGlasgow_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listViewGlasgow_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listViewTemplateGlasgow.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void listViewGlasgow_DragDrop(object sender, DragEventArgs e)
        {
            ListView[] views = { listViewGlasgow, listViewTemplateGlasgow };
            ListViewItem view = (ListViewItem)e.Data.GetData(DataFormats.Serializable);

            if (listViewGlasgow.Items.Contains(view))
                return;
            else
            {
                RemoverItem(views, e);
            }
        }

        private void listViewTemplateGlasgow_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listViewGlasgow.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void listViewTemplateGlasgow_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listViewTemplateGlasgow_DragDrop(object sender, DragEventArgs e)
        {
            ListView[] views = { listViewGlasgow, listViewTemplateGlasgow };
            ListViewItem view = (ListViewItem)e.Data.GetData(DataFormats.Serializable);

            if (listViewTemplateGlasgow.Items.Contains(view))
                return;
            else
            {
                AdicionaItem(Area.ComaGlasgow, views, e);
            }
        }

        private void listViewTemplateCatetres_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listViewCatetres.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void listViewTemplateCatetres_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listViewTemplateCatetres_DragDrop(object sender, DragEventArgs e)
        {
            ListView[] views = { listViewCatetres, listViewTemplateCatetres };
            ListViewItem view = (ListViewItem)e.Data.GetData(DataFormats.Serializable);

            if (listViewTemplateCatetres.Items.Contains(view))
                return;
            else
            {
                AdicionaItem(Area.ControleCateteres, views, e);
            }
        }

        private void listViewCatetres_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listViewTemplateCatetres.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void listViewCatetres_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listViewCatetres_DragDrop(object sender, DragEventArgs e)
        {
            ListView[] views = { listViewCatetres, listViewTemplateCatetres };
            ListViewItem view = (ListViewItem)e.Data.GetData(DataFormats.Serializable);

            if (listViewCatetres.Items.Contains(view))
                return;
            else
            {
                RemoverItem(views, e);
            }
        }

        private void listViewTemplatePressaoArterialOutros_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listViewPressaoArterialOutros.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void listViewTemplatePressaoArterialOutros_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listViewTemplatePressaoArterialOutros_DragDrop(object sender, DragEventArgs e)
        {
            ListView[] views = { listViewPressaoArterialOutros, listViewTemplatePressaoArterialOutros };
            ListViewItem view = (ListViewItem)e.Data.GetData(DataFormats.Serializable);

            if (listViewTemplatePressaoArterialOutros.Items.Contains(view))
                return;
            else
            {
                AdicionaItem(Area.PressaoArterial, views, e);
            }
        }

        private void listViewPressaoArterialOutros_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listViewTemplatePressaoArterialOutros.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void listViewPressaoArterialOutros_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listViewPressaoArterialOutros_DragDrop(object sender, DragEventArgs e)
        {
            ListView[] views = { listViewPressaoArterialOutros, listViewTemplatePressaoArterialOutros };
            ListViewItem view = (ListViewItem)e.Data.GetData(DataFormats.Serializable);

            if (listViewPressaoArterialOutros.Items.Contains(view))
                return;
            else
            {
                RemoverItem(views, e);
            }
        }

        private void imgAccordion_Click(object sender, EventArgs e)
        {
          
            buttonTyp = (PictureBox)sender;
            buttonTyp.Image = Properties.Resources.down;
            Area _area = (Area)System.Enum.Parse(typeof(Area), buttonTyp.Tag.ToString());

            switch (_area)
            {
                case Area.SistemaNeurologico:
                    {
                        accordion = pSistemaNeurologico;
                        break;
                    }
                case Area.Pupilas:
                    {
                        accordion = pPupilas;
                        break;
                    }
                case Area.RegulacaoTermica:
                    {
                        accordion = pRegulacaoTermica;
                        break;
                    }
                case Area.Oxigenacao:
                    {
                        accordion = pOxigenacao;
                        break;
                    }
                case Area.Pele:
                    {
                        accordion = pPele;
                        break;
                    }
                case Area.SistemaGastrointestinal:
                    {
                        accordion = pSistemaGastrointestinal;
                        break;
                    }
                case Area.SistemaVascular:
                    {
                        accordion = pSistemaVascular;
                        break;
                    }
                case Area.SistemaAbdominal:
                    {
                        accordion = pSistemaAbdominal;
                        break;
                    }
                case Area.SistemaUrinario:
                    {
                        accordion = pSistemaUrinario;
                        break;
                    }
                case Area.LesaoCompressao:
                    {
                        accordion = pLesaoCompressao;
                        break;
                    }
                case Area.GloboPinard:
                    {
                        accordion = pGloboPinard;
                        break;
                    }
                case Area.ComaGlasgow:
                    {
                        accordion = pComaGlasgow;
                        break;
                    }
                case Area.ControleCateteres:
                    {
                        accordion = pControleCateteres;
                        break;
                    }
                case Area.PressaoArterial:
                    {
                        accordion = pPressaoArterial;
                        break;
                    }
                default:
                    break;

            }

            if (accordion != null)
            {
                timerAccordion.Start();
            }
        }

        private void timerAccordion_Tick(object sender, EventArgs e)
        {
           
            if (accordion.Tag.Equals("0"))
            {
                accordion.Height += 10;
                if (accordion.Size.Height == 270)
                {
                    timerAccordion.Stop();
                    accordion.Tag = "1";
                }
            }
            else
            {
                accordion.Height -= 10;
                if (accordion.Size.Height == 0)
                {
                    timerAccordion.Stop();
                    buttonTyp.Image = Properties.Resources.left;
                    accordion.Tag = "0";
                }
            }
        }
    }
}
