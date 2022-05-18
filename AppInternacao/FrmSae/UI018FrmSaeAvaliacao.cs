using AppInternacao.Enum;
using AppInternacao.Model;
using AppInternacao.Presenter;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
        List<AvaliacaoEnfermagem> avaliacaos = new List<AvaliacaoEnfermagem>();
        AvaliacaoEnfermagem avaliacaoEnfermagem = null;

        List<NocResultado> lstResultados = null;
        List<NocIndicador> lstIndicadores = null;
        List<Cabecalho> objCabecalho = null;
        List<NocIndicador> lstIndicadoresSelected = null;
        List<NicClassificacao> lstClassificacao = new List<NicClassificacao>();

        private void UI018FrmSaeAvaliacao_Load(object sender, EventArgs e)
        {
            try
            {
                //nRoot = new TreeNode();
                UI011FrmTimeLine.lblRotuloSae.Text = "NOC - Classificação dos Resultados da Intervenção";
                UI011FrmTimeLine.iconButtonAvanca.Text = "CONCLUIR";
                UI011FrmTimeLine.iconButtonAvanca.IconChar = IconChar.CheckDouble;
                UI011FrmTimeLine.iconButtonAvanca.Enabled = false;

                lstIndicadoresSelected = new List<NocIndicador>();
                presenterGeneric = new PresenterGeneric();

                lstResultados = presenterGeneric.GetLista(new NocResultado(), Procedure.SP_GET_NOC_RESULTADO);
                lstIndicadores = presenterGeneric.GetLista(new NocIndicador(), Procedure.SP_GET_NOC_INDICADORES);
                objCabecalho = presenterGeneric.GetLista(new Cabecalho(), Procedure.SP_GET_NOC_CABECALHO);
                
                lstClassificacao = presenterGeneric.GetLista(new NicClassificacao { Classificacao = string.Join(",", Sessao.Paciente.Sae.IntervencaoEnfermagem.Select(s => s.Classificacao)) }, Procedure.SP_GET_NIC_CLASSIFICACAO);

                comboBoxNicClassificacao.DataSource = lstClassificacao;
                
                FilterByName();
                comboBoxClassificacao.SelectedIndex = 0;

                UI011FrmTimeLine.IconButtonVolta.Visible = false;
                UI011FrmTimeLine.iconButtonAvanca.Click += btnButtonStepAvanca_Click;
            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
        }

        private void btnButtonStepAvanca_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarForm())
                { 

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        bool ValidarForm()
        {
            try
            {
                string[] msg = 
                    { 
                        "A lista de indicadores da classificação '{0}', não tem nenhum alvo flegado.",
                        "O ítem '{0}' da classificação '{1}', não estão com todas as lacunas preenchidas",
                        "Nenhuma classificação foi selecionada para esta avaliação de enfermagem.",
                        "Favor pontuar os ítens das classificações flegadas.",
                        "Existem Classificações na lista suspensa que não foram pontuadas, favor pontuar todas as claissificações.",
                        "A Classificação-NIC '{0}', não está associado a nenhuma Classificação-NOC como resultado esperado."
                    };

                if (!avaliacaos.Any())
                {
                    MessageBox.Show(msg[3], "AVISO - NOC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                foreach (AvaliacaoEnfermagem item in avaliacaos)
                {
                    if (!item.PontuacaoIndicadorPrimario.Value.Checked)
                    {
                        MessageBox.Show(string.Format(msg[0],item.Resultados.Nome),"AVISO - NOC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    
                    var ret = item.Indicadores.Any(n => string.IsNullOrWhiteSpace(n.V1) || string.IsNullOrWhiteSpace(n.V2) || string.IsNullOrWhiteSpace(n.V3) || string.IsNullOrWhiteSpace(n.V4) || string.IsNullOrWhiteSpace(n.V5));
                    
                    if (ret)
                    {
                        var _item = item.Indicadores.FirstOrDefault(n => string.IsNullOrWhiteSpace(n.V1) || string.IsNullOrWhiteSpace(n.V2) || string.IsNullOrWhiteSpace(n.V3) || string.IsNullOrWhiteSpace(n.V4) || string.IsNullOrWhiteSpace(n.V5));
                        MessageBox.Show(string.Format(msg[1], _item.Nome, item.Resultados.Nome), "AVISO - NOC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    if (comboBoxClassificacao.Items.Count == 1)
                    {
                        MessageBox.Show(msg[2], "AVISO - NOC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }

                bool x =  lstClassificacao.All(c => avaliacaos.Any(s => s.NicClassificacao.Value == c.Codigo.ToString()));

                if (!x)
                {
                    var nic =  lstClassificacao.FirstOrDefault(c => !avaliacaos.Any(s => s.NicClassificacao.Value == c.Codigo.ToString()));
                    MessageBox.Show(string.Format(msg[5], nic.Classificacao), "AVISO - NOC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                
                if (avaliacaos.Count != (comboBoxClassificacao.Items.Count -1))
                {
                    MessageBox.Show(msg[4], "AVISO - NOC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }

            return true;
        }

        private void AddResultClassificacao_Click(object sender, EventArgs e)
        {
            try
            {
                npdOutros.ResetText();
            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
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

                    if (e.Node.Checked)
                    {
                        e.Node.Nodes.OfType<TreeNode>().Select(s => (NocIndicador)s.Tag).ToList().ForEach(f => f.Checked = e.Node.Checked);
                        e.Node.Nodes.OfType<TreeNode>().ToList().ForEach(n => n.Checked = e.Node.Checked);
                        ((NocResultado)e.Node.Tag).Checked = e.Node.Checked;

                        if (!comboBoxClassificacao.Items.Contains(e.Node.Tag))
                            comboBoxClassificacao.Items.Add(e.Node.Tag);
                    }
                    else
                    {
                        lstIndicadoresSelected.RemoveAll(r => r.Codigo == ((NocResultado)e.Node.Tag).Codigo);
                        avaliacaos.RemoveAll(r => r.Codigo == ((NocResultado)e.Node.Tag).Codigo);

                        e.Node.Nodes.OfType<TreeNode>().Select(s => (NocIndicador)s.Tag).ToList().ForEach(f => f.Checked = e.Node.Checked);
                        e.Node.Nodes.OfType<TreeNode>().ToList().ForEach(f => f.Checked = e.Node.Checked);
                        comboBoxClassificacao.Items.Remove(e.Node.Tag);
                        comboBoxClassificacao.SelectedIndex = 0;
                        dataGridViewAvaliacao.DataSource = null;
                        dataGridViewAvaliacao.Visible = false;
                        lblDefinicao.Text = lblItemIndicador.Text = string.Empty;
                        npdOutros.Value = npdEstimativaAlvo.Value = 1;
                    }
                }
                else
                {
                    e.Node.Parent.Checked = e.Node.Parent.Nodes.OfType<TreeNode>().Any(c => c.Checked);

                    ((NocResultado)e.Node.Parent.Tag).Checked = e.Node.Parent.Checked;

                    if (!comboBoxClassificacao.Items.Contains(e.Node.Parent.Tag))
                        comboBoxClassificacao.Items.Add(e.Node.Parent.Tag);

                    NocIndicador indicador = (NocIndicador)e.Node.Tag;

                    indicador.V1 = indicador.V2 = indicador.V3 = indicador.V4 = indicador.V5 = null;
                    indicador.Checked = false;

                    var itemAvaliacao = avaliacaos.FirstOrDefault(o => o.Codigo == indicador.IdResultado);

                    if(itemAvaliacao != null)
                        itemAvaliacao.PontuacaoIndicadorPrimario.Value.Checked = false;

                    if (!e.Node.Parent.Checked)
                    {
                        comboBoxClassificacao.Items.Remove(e.Node.Parent.Tag);
                        comboBoxClassificacao.SelectedIndex = 0;
                        lstIndicadoresSelected.RemoveAll(r => r.Codigo == ((NocIndicador)e.Node.Tag).Codigo);
                        comboBoxClassificacao_SelectionChangeCommitted(null, null);
                    }

                }

                if (comboBoxClassificacao.Items.Count > 1)
                    comboBoxClassificacao.SelectedItem = e.Node.Level == 0 ? e.Node.Tag : e.Node.Parent.Tag;

                if (comboBoxClassificacao.Items.Count > 1)
                    comboBoxClassificacao_SelectionChangeCommitted(null, null);

                UI011FrmTimeLine.iconButtonAvanca.Enabled = comboBoxClassificacao.Items.Count > 1;
            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
        }

        private void PopulaListaClassificacao()
        {
            lstIndicadoresSelected.Clear();
            var checkedResult = treeViewNoc.Nodes.OfType<TreeNode>().Where(x => x.Checked && ((NocResultado)x.Tag).Codigo == nocResultado.Codigo).FirstOrDefault();
            lstIndicadoresSelected.AddRange(checkedResult.Nodes.OfType<TreeNode>().Where(x => x.Checked).Select(s => (NocIndicador)s.Tag).AsEnumerable());
        }

        private void comboBoxClassificacao_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                npdEstimativaAlvo.ValueChanged -= npdEstimativaAlvo_ValueChanged;
                npdOutros.ValueChanged -= npdOutros_ValueChanged;

                if (comboBoxClassificacao.SelectedIndex > 0)
                {
                    nocResultado = (NocResultado)comboBoxClassificacao.SelectedItem;
                    lblDefinicao.Text = nocResultado.Definicao;
                    lblItemIndicador.Text = string.Empty;
                    npdEstimativaAlvo.Value = npdOutros.Value = 1;
                    npdEstimativaAlvo.Enabled = npdOutros.Enabled = true;
                  
                    Cabecalho cabecalho = objCabecalho.FirstOrDefault(f => f.Codigo == nocResultado.Codigo);

                    lstIndicadoresSelected.Clear();
                    var checkedResult = treeViewNoc.Nodes.OfType<TreeNode>().Where(x => x.Checked && ((NocResultado)x.Tag).Codigo == nocResultado.Codigo).FirstOrDefault();
                    lstIndicadoresSelected.AddRange(checkedResult.Nodes.OfType<TreeNode>().Where(x => x.Checked).Select(s => (NocIndicador)s.Tag).AsEnumerable());

                    avaliacaoEnfermagem = avaliacaos.FirstOrDefault(r => r.Codigo.Equals(nocResultado.Codigo));

                    if(avaliacaoEnfermagem is null)
                    {
                        avaliacaoEnfermagem = new AvaliacaoEnfermagem
                        {
                            Codigo = nocResultado.Codigo,
                            Indicadores = lstIndicadoresSelected,
                            NicClassificacao = new KeyValuePair<string, string>(nocResultado.Codigo, comboBoxNicClassificacao.SelectedValue.ToString()),
                            Resultados = nocResultado, 
                            PontuacaoIndicadorPrimario = new KeyValuePair<string, AvaliacaoEnfermagem.ItemKeyValue>(nocResultado.Codigo, new AvaliacaoEnfermagem.ItemKeyValue { ValorIndicador = npdEstimativaAlvo.Value.ToString() }),
                            PontuacaoIndicadorSecundario = new KeyValuePair<string, AvaliacaoEnfermagem.ItemKeyValue>(nocResultado.Codigo, new AvaliacaoEnfermagem.ItemKeyValue { ValorIndicador = npdEstimativaAlvo.Value.ToString() })
                        };

                        avaliacaos.Add(avaliacaoEnfermagem);
                    }

                    dataGridViewAvaliacao.DataSource = null;
                    dataGridViewAvaliacao.Columns["Nome"].HeaderText = "Indicadores".ToUpper();
                    dataGridViewAvaliacao.Columns["T1"].HeaderText = cabecalho.T1.ToUpper();
                    dataGridViewAvaliacao.Columns["T2"].HeaderText = cabecalho.T2.ToUpper();
                    dataGridViewAvaliacao.Columns["T3"].HeaderText = cabecalho.T3.ToUpper();
                    dataGridViewAvaliacao.Columns["T4"].HeaderText = cabecalho.T4.ToUpper();
                    dataGridViewAvaliacao.Columns["T5"].HeaderText = cabecalho.T5.ToUpper();
                    dataGridViewAvaliacao.ColumnHeadersVisible = true;
                    dataGridViewAvaliacao.DataSource = lstIndicadoresSelected;
                    dataGridViewAvaliacao.Visible = true;

                    if (avaliacaoEnfermagem.PontuacaoIndicadorPrimario.Value.Checked)
                    {
                        foreach (DataGridViewRow item in dataGridViewAvaliacao.Rows)
                        {
                            if(((NocIndicador)item.DataBoundItem).Codigo == avaliacaoEnfermagem.PontuacaoIndicadorPrimario.Value.IdIndicador)
                            {
                                item.Cells[1].Value = true;
                                break;
                            }
                        }
                    }

                    npdEstimativaAlvo.Value = Convert.ToDecimal(avaliacaoEnfermagem.PontuacaoIndicadorPrimario.Value.ValorIndicador);
                    npdOutros.Value = Convert.ToDecimal(avaliacaoEnfermagem.PontuacaoIndicadorSecundario.Value.ValorIndicador);
                }
                else
                {
                    dataGridViewAvaliacao.DataSource = null;
                    dataGridViewAvaliacao.Visible = npdEstimativaAlvo.Enabled = npdOutros.Enabled = false;
                    lblDefinicao.Text = lblItemIndicador.Text = string.Empty;
                    npdOutros.Value = npdEstimativaAlvo.Value = 1;
                }

                npdEstimativaAlvo.ValueChanged += npdEstimativaAlvo_ValueChanged;
                npdOutros.ValueChanged += npdOutros_ValueChanged;
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
                    ((NocIndicador)senderGrid.CurrentRow.DataBoundItem).Checked = ((bool)senderGrid.CurrentRow.Cells[1].EditedFormattedValue); 
                    
                    avaliacaoEnfermagem.PontuacaoIndicadorPrimario.Value.Checked = ((bool)senderGrid.CurrentRow.Cells[1].EditedFormattedValue);
                    avaliacaoEnfermagem.PontuacaoIndicadorPrimario.Value.IdIndicador = ((NocIndicador)senderGrid.CurrentRow.DataBoundItem).Codigo;
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

        private void npdEstimativaAlvo_ValueChanged(object sender, EventArgs e)
        {
            avaliacaoEnfermagem.PontuacaoIndicadorPrimario.Value.ValorIndicador = npdEstimativaAlvo.Value.ToString();
        }

        private void npdOutros_ValueChanged(object sender, EventArgs e)
        {
            avaliacaoEnfermagem.PontuacaoIndicadorSecundario.Value.ValorIndicador = npdOutros.Value.ToString();
        }

        private void treeViewNoc_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //try
            //{
                
            //    if (e.Node.Level == 0)
            //    {

            //        if (e.Node.Checked)
            //        {
            //            e.Node.Nodes.OfType<TreeNode>().Select(s => (NocIndicador)s.Tag).ToList().ForEach(f => f.Checked = e.Node.Checked);
            //            e.Node.Nodes.OfType<TreeNode>().ToList().ForEach(n => n.Checked = e.Node.Checked);
            //            ((NocResultado)e.Node.Tag).Checked = e.Node.Checked;

            //                if (!comboBoxClassificacao.Items.Contains(e.Node.Tag))
            //                    comboBoxClassificacao.Items.Add(e.Node.Tag);
            //        }
            //        else
            //        {
            //            lstIndicadoresSelected.RemoveAll(r => r.Codigo == ((NocResultado)e.Node.Tag).Codigo);
            //            avaliacaos.RemoveAll(r => r.Codigo == ((NocResultado)e.Node.Tag).Codigo);

            //            e.Node.Nodes.OfType<TreeNode>().Select(s => (NocIndicador)s.Tag).ToList().ForEach(f => f.Checked = e.Node.Checked);
            //            e.Node.Nodes.OfType<TreeNode>().ToList().ForEach(f => f.Checked = e.Node.Checked);
            //            comboBoxClassificacao.Items.Remove(e.Node.Tag);
            //            comboBoxClassificacao.SelectedIndex = 0;
            //            dataGridViewAvaliacao.DataSource = null;
            //            dataGridViewAvaliacao.Visible = false;
            //            lblDefinicao.Text = lblItemIndicador.Text = string.Empty;
            //            npdOutros.Value = npdEstimativaAlvo.Value = 1;
            //        }
            //    }
            //    else
            //    {
            //        e.Node.Parent.Checked = e.Node.Parent.Nodes.OfType<TreeNode>().Any(c => c.Checked);

            //        ((NocResultado)e.Node.Parent.Tag).Checked = e.Node.Parent.Checked;
                    
            //        if (!comboBoxClassificacao.Items.Contains(e.Node.Parent.Tag))
            //            comboBoxClassificacao.Items.Add(e.Node.Parent.Tag);

            //        ((NocIndicador)e.Node.Tag).Checked = e.Node.Checked;

            //        if (e.Node.Checked)
            //        {
            //         //   PopulaListaClassificacao();

            //            NocIndicador indicador = (NocIndicador)e.Node.Tag;

            //            if (indicador != null)
            //                indicador.V1 = indicador.V2 = indicador.V3 = indicador.V4 = indicador.V5 = null;
            //        }
            //        else
            //        {
            //            if (!e.Node.Parent.Checked)
            //            {
            //                comboBoxClassificacao.Items.Remove(e.Node.Parent.Tag);
            //                comboBoxClassificacao.SelectedIndex = 0;
            //            }

            //            lstIndicadoresSelected.RemoveAll(r => r.Codigo == ((NocIndicador)e.Node.Tag).Codigo);
            //        }
            //    }

            //    if (comboBoxClassificacao.Items.Count > 1)
            //        comboBoxClassificacao.SelectedItem = e.Node.Level == 0 ? e.Node.Tag : e.Node.Parent.Tag;

            //    if (comboBoxClassificacao.Items.Count > 1)
            //        comboBoxClassificacao_SelectionChangeCommitted(null, null);

            //    UI011FrmTimeLine.iconButtonAvanca.Enabled = comboBoxClassificacao.Items.Count > 1;
            //}
            //catch (Exception ex)
            //{
            //    FrmMain.Alert(exception: ex);
            //}
        }
    }
}
