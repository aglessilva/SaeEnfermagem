using AppInternacao.Enum;
using AppInternacao.Model;
using AppInternacao.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace AppInternacao.FrmSae
{
    public partial class UI018FrmSaeAvaliacao :UI000FrmTemplate
    {
        public UI018FrmSaeAvaliacao()
        {
            InitializeComponent();
            dataGridViewAvaliacao.AutoGenerateColumns = false;
        }

        internal class Cabecalho
        {
            public string Codigo { get; set; }
            public string T1 { get; set; }
            public string T2 { get; set; }
            public string T3 { get; set; }
            public string T4 { get; set; }
            public string T5 { get; set; }
        }

        PresenterGeneric presenterGeneric = null;
        TreeNode nRoot;
        NocResultado nocResultado = null;
        
        List<NocResultado> lstResultados = null;
        List<NocIndicador> lstIndicadores = null;
        List<Cabecalho> objCabecalho = null;

        private void UI018FrmSaeAvaliacao_Load(object sender, EventArgs e)
        {
            try
            {
                //nRoot = new TreeNode();
                presenterGeneric = new PresenterGeneric();
                lstResultados = presenterGeneric.GetLista(new NocResultado(), Procedure.SP_GET_NOC_RESULTADO);
                lstIndicadores = presenterGeneric.GetLista(new NocIndicador(), Procedure.SP_GET_NOC_INDICADORES);
                objCabecalho = presenterGeneric.GetLista(new Cabecalho(), Procedure.SP_GET_NOC_CABECALHO);

                FilterByName();

                //if (Sessao.Paciente.SaeStatus.Status == Sae.Edicao)
                if (true)
                {
                    FrmMain.listButtons.ForEach(b =>
                    {
                        if (b.Name.Equals("btnAddGeneric"))
                        {
                            b.Visible = true;
                            b.Click += AddResultClassificacao_Click;
                            b.Width += 10;
                            b.Enabled = false;
                            b.Text = "Adicionar Classificação".Trim();
                        }
                    });
                }

                comboBoxClassificacao.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
        }

        private void AddResultClassificacao_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void FilterByName()
        {
            try
            {
                nRoot = new TreeNode();
                treeViewNoc.Nodes.Clear();

                lstResultados.Where(y => y.Nome.StartsWith(textBoxPesquisaNoc.Text.Trim(), StringComparison.OrdinalIgnoreCase)).ToList().ForEach(n => {
                    nRoot.Nodes.Add(new TreeNode { Text = n.Nome , ToolTipText = n.Definicao, Tag = n, Checked = n.Checked ?? false});
                });

                foreach (TreeNode item in nRoot.Nodes)
                {
                    nocResultado = (NocResultado)item.Tag;
                    lstIndicadores.Where(x => x.IdResultado.Equals(nocResultado.Codigo)).ToList()
                        .ForEach(n =>
                        {
                            item.Nodes.Add(new TreeNode { Text = n.Nome , Tag = n, Checked = n.Checked ?? false });
                        });

                    treeViewNoc.Nodes.Add(item);
                }
            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
        }

        private void treeViewNoc_AfterCheck(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (e.Action == TreeViewAction.Unknown)
                    return;


                if (e.Node.Level == 0)
                {
                    e.Node.Nodes.OfType<TreeNode>().Select(s => (NocIndicador)s.Tag).ToList().ForEach(f => f.Checked = e.Node.Checked);

                    foreach (TreeNode item in e.Node.Nodes)
                    {
                        item.Checked = e.Node.Checked;

                        ((NocResultado)e.Node.Tag).Checked = item.Checked;


                        if (item.Checked)
                        {
                            if (!comboBoxClassificacao.Items.Contains(e.Node.Tag))
                                comboBoxClassificacao.Items.Add(e.Node.Tag);
                        }
                        else
                        {
                            if (comboBoxClassificacao.SelectedItem == e.Node.Tag)
                            {
                                dataGridViewAvaliacao.DataSource = null;
                                dataGridViewAvaliacao.Visible = false;
                                lblDefinicao.Text = lblItemIndicador.Text = string.Empty;
                                comboBoxClassificacao.SelectedIndex = 0;
                                npdOutros.Value = npdEstimativaAlvo.Value = 1;
                            }
                            comboBoxClassificacao.Items.Remove(e.Node.Tag);
                        }
                    }
                }
                else
                {
                    e.Node.Parent.Checked = e.Node.Parent.Nodes.OfType<TreeNode>().Any(c => c.Checked);
                    FrmMain.listButtons.Find(n => n.Name.Equals("btnAddGeneric")).Enabled = e.Node.Parent.Checked;

                    ((NocResultado)e.Node.Parent.Tag).Checked = e.Node.Parent.Checked;

                    if (e.Node.Parent.Checked)
                    {
                        ((NocIndicador)e.Node.Tag).Checked = true;
                        if (!comboBoxClassificacao.Items.Contains(e.Node.Parent.Tag))
                            comboBoxClassificacao.Items.Add(e.Node.Parent.Tag);
                    }
                    else
                    {
                        ((NocIndicador)e.Node.Tag).Checked = false;

                        if (comboBoxClassificacao.SelectedItem == e.Node.Parent.Tag)
                        {
                            dataGridViewAvaliacao.DataSource = null;
                            dataGridViewAvaliacao.Visible = false;
                            lblDefinicao.Text = lblItemIndicador.Text = string.Empty;
                            comboBoxClassificacao.SelectedIndex = 0;
                            npdOutros.Value = npdEstimativaAlvo.Value = 1;
                        }
                        comboBoxClassificacao.Items.Remove(e.Node.Parent.Tag);
                    }
                }
                
                FrmMain.listButtons.Find(n => n.Name.Equals("btnAddGeneric")).Enabled = lstResultados.Any(a => a.Checked ?? false);
            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
        }

        private void comboBoxClassificacao_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxClassificacao.SelectedIndex > 0)
                {

                    nocResultado = (NocResultado)comboBoxClassificacao.SelectedItem;
                    lblDefinicao.Text = nocResultado.Definicao;
                    lblItemIndicador.Text = string.Empty;
                    npdEstimativaAlvo.Value = npdOutros.Value = 1;

                    List<NocIndicador> lstIndicadore = new List<NocIndicador>();
                    Cabecalho cabecalho = objCabecalho.FirstOrDefault(f => f.Codigo == nocResultado.Codigo);

                    var checkedResult = treeViewNoc.Nodes.OfType<TreeNode>().Where(x => x.Checked && ((NocResultado)x.Tag).Codigo == nocResultado.Codigo).FirstOrDefault();
                    lstIndicadore.AddRange(checkedResult.Nodes.OfType<TreeNode>().Where(x => x.Checked).Select(s => (NocIndicador)s.Tag).AsEnumerable());

                    dataGridViewAvaliacao.Columns["Nome"].HeaderText = "Indicadores".ToUpper();
                    dataGridViewAvaliacao.Columns["T1"].HeaderText = cabecalho.T1.ToUpper();
                    dataGridViewAvaliacao.Columns["T2"].HeaderText = cabecalho.T2.ToUpper();
                    dataGridViewAvaliacao.Columns["T3"].HeaderText = cabecalho.T3.ToUpper();
                    dataGridViewAvaliacao.Columns["T4"].HeaderText = cabecalho.T4.ToUpper();
                    dataGridViewAvaliacao.Columns["T5"].HeaderText = cabecalho.T5.ToUpper();
                    dataGridViewAvaliacao.ColumnHeadersVisible = true;
                    dataGridViewAvaliacao.DataSource = lstIndicadore;
                    dataGridViewAvaliacao.Visible = true;
                }
                else
                {
                    dataGridViewAvaliacao.Visible = false;
                    lblDefinicao.Text = lblItemIndicador.Text = string.Empty;
                    npdOutros.Value = npdEstimativaAlvo.Value = 1;
                }
            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
        }

        private void dataGridViewAvaliacao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView senderGrid = dataGridViewAvaliacao;

                if (senderGrid.CurrentCell is DataGridViewCheckBoxCell)
                {
                    foreach (DataGridViewRow item in senderGrid.Rows)
                    {
                        item.Cells[1].Value = false;
                    }

                    lblItemIndicador.Visible = ((bool)senderGrid.CurrentRow.Cells[1].EditedFormattedValue);
                    lblItemIndicador.Text = ((bool)senderGrid.CurrentRow.Cells[1].EditedFormattedValue) ? senderGrid.CurrentRow.Cells[2].Value.ToString() : string.Empty;
                }
            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
        }

        private void textBoxPesquisaNoc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxPesquisaNoc.Text.Length == 0 || textBoxPesquisaNoc.Text.Length > 2)
                    FilterByName();
            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxPesquisaNoc.Text = string.Empty;
        }
    }
}
