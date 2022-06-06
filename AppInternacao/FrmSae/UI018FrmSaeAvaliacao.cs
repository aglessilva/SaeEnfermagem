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
    public partial class UI018FrmSaeAvaliacao :UI000FrmTemplate
    {
        PresenterGeneric presenterGeneric = null;
        TreeNode nRoot;
        DataTable[] dataTables = new DataTable[2];
        NocResultado nocResultado = null;
        List<AvaliacaoEnfermagem> avaliacoes = new List<AvaliacaoEnfermagem>();
        AvaliacaoEnfermagem avaliacaoEnfermagem = null;

        List<NocResultado> lstResultados = null;
        List<NocIndicador> lstIndicadores = null;
        List<Cabecalho> objCabecalho = null;
        List<NocIndicador> lstIndicadoresSelected = null;
        List<NicClassificacao> lstClassificacao = new List<NicClassificacao>();


        public UI018FrmSaeAvaliacao(DataTable[] _dataTables)
        {
            InitializeComponent();
            dataGridViewAvaliacao.AutoGenerateColumns = false;
            dataTables = _dataTables;
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


        private void UI018FrmSaeAvaliacao_Load(object sender, EventArgs e)
        {
            try
            {
                UI011FrmTimeLine.lblRotuloSae.Text = "NOC - Classificação dos Resultados da Intervenção para avaliação de enfermagem";
                UI011FrmTimeLine.iconButtonAvanca.Text = Sessao.Paciente.SaeStatus.Status != Sae.Finalizado ? "CONCLUIR" : "ATUALIZAR" ;

                UI011FrmTimeLine.iconButtonAvanca.IconChar = IconChar.CheckDouble;
                UI011FrmTimeLine.iconButtonAvanca.Enabled = false;

                treeViewNoc.Enabled = (Sae.Edicao | Sae.Andamento).HasFlag(Sessao.Paciente.SaeStatus.Status);
                lstIndicadoresSelected = new List<NocIndicador>();
                presenterGeneric = new PresenterGeneric();

                lstResultados = presenterGeneric.GetLista(new NocResultado(), Procedure.SP_GET_NOC_RESULTADO);
                lstIndicadores = presenterGeneric.GetLista(new NocIndicador(), Procedure.SP_GET_NOC_INDICADORES);
                objCabecalho = presenterGeneric.GetLista(new Cabecalho(), Procedure.SP_GET_NOC_CABECALHO);
                
                lstClassificacao = presenterGeneric.GetLista(new NicClassificacao { Classificacao = string.Join(",", Sessao.Paciente.Sae.IntervencaoEnfermagem.Select(s => s.Classificacao)) }, Procedure.SP_GET_NIC_CLASSIFICACAO);
                lstClassificacao.Insert(0, new NicClassificacao { Classificacao = "Selecione uma classificação de intervenção", Codigo = 0 });
                
                comboBoxNicClassificacao.DataSource = lstClassificacao;

                var lstAvaliacaoEnfermagem = presenterGeneric.GetLista(new AvaliacaoEnfermagem.AvaliacaoEnfermagemDTO() { IdSae = Sessao.Paciente.SaeStatus.Id }, Procedure.SP_GET_AVALIACAO_ENFERMAGEM_SAE);

                if (lstAvaliacaoEnfermagem.Any())
                {
                    foreach (var b in lstAvaliacaoEnfermagem)
                    {
                        avaliacaoEnfermagem = new AvaliacaoEnfermagem
                        {
                            Id = b.Id,
                            IdSae = b.IdSae,
                            Codigo = b.Codigo,
                            Resultados = JsonConvert.DeserializeObject<NocResultado>(b.Resultados, new JsonSerializerSettings { Formatting = Formatting.None }),
                            Indicadores = JsonConvert.DeserializeObject<List<NocIndicador>>(b.Indicadores, new JsonSerializerSettings { Formatting = Formatting.None }),
                            NicClassificacao = JsonConvert.DeserializeObject<KeyValuePair<string, string>>(b.NicClassificacao, new JsonSerializerSettings { Formatting = Formatting.None }),
                            PontuacaoIndicadorPrimario = JsonConvert.DeserializeObject<KeyValuePair<string, AvaliacaoEnfermagem.ItemKeyValue>>(b.PontuacaoIndicadorPrimario, new JsonSerializerSettings { Formatting = Formatting.None }),
                            PontuacaoIndicadorSecundario = JsonConvert.DeserializeObject<KeyValuePair<string, AvaliacaoEnfermagem.ItemKeyValue>>(b.PontuacaoIndicadorSecundario, new JsonSerializerSettings { Formatting = Formatting.None }),

                        };

                        avaliacoes.Add(avaliacaoEnfermagem);
                        comboBoxClassificacao.Items.Add(avaliacaoEnfermagem.Resultados);
                        lstResultados.FirstOrDefault(r => r.Codigo == avaliacaoEnfermagem.Codigo).Checked = true;

                        NocIndicador nocIndicador = null;
                        lstIndicadores.Where(i => i.IdResultado == avaliacaoEnfermagem.Resultados.Codigo).ToList()
                            .ForEach(f => {

                                nocIndicador = new NocIndicador();
                                nocIndicador = avaliacaoEnfermagem.Indicadores.FirstOrDefault(y => y.Id == f.Id);
                                
                                if (nocIndicador != null)
                                {
                                    if (nocIndicador.Checked.HasValue)
                                    {
                                        f.Id = nocIndicador.Id;
                                        f.Checked = true;
                                        f.Codigo = nocIndicador.Codigo;
                                        f.IdResultado = nocIndicador.IdResultado;
                                        f.Nome = nocIndicador.Nome;
                                        f.V1 = nocIndicador.V1;
                                        f.V2 = nocIndicador.V2;
                                        f.V3 = nocIndicador.V3;
                                        f.V4 = nocIndicador.V4;
                                        f.V5 = nocIndicador.V5;
                                    }
                                }
                            });
                    }

                }

                FilterByName();
                comboBoxClassificacao.SelectedIndex = 0;
                
                UI011FrmTimeLine.IconButtonVolta.Click += btnButtonBackStep_Click;
                UI011FrmTimeLine.iconButtonAvanca.Click += btnButtonStepAvanca_Click;
            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
        }

        private void btnButtonBackStep_Click(object sender, EventArgs e)
        {
            try
            {
                FrmMain.listButtons.ForEach(b => FrmMain.RemoveClickEvent(b));
                FrmMain.RemoveClickEvent(UI011FrmTimeLine.iconButtonAvanca);
                FrmMain.RemoveClickEvent(UI011FrmTimeLine.IconButtonVolta);

                UI011FrmTimeLine.ctrl.Controls.RemoveAt(0);
                Form frm = new UI017FrmSaeImplementacao(dataTables) { TopLevel = false };
                UI011FrmTimeLine.ctrl.Controls.Add(frm);

                frm.Show();
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
                    avaliacoes.ForEach(p => {
                        p.IdSae = Sessao.Paciente.SaeStatus.Id;
                        p.DTO.Id = p.Id;
                        p.DTO.IdSae = p.IdSae;
                        p.DTO.Prontuario = Sessao.Paciente.Prontuario;
                        p.DTO.Codigo = p.Codigo;
                        p.DTO.Resultados = JsonConvert.SerializeObject(p.Resultados, Formatting.None);
                        p.DTO.Indicadores = JsonConvert.SerializeObject(p.Indicadores, Formatting.None);
                        p.DTO.NicClassificacao = JsonConvert.SerializeObject(p.NicClassificacao, Formatting.None);
                        p.DTO.PontuacaoIndicadorPrimario = JsonConvert.SerializeObject(p.PontuacaoIndicadorPrimario, Formatting.None);
                        p.DTO.PontuacaoIndicadorSecundario = JsonConvert.SerializeObject(p.PontuacaoIndicadorSecundario, Formatting.None);
                        
                        presenterGeneric.Salvar(p.DTO, Procedure.SP_ADD_OR_UPDT_AVALIACAO_ENFERMAGEM_SAE, Acao.Inserir);
                    });

                    // fechar formularios
                    var frms = Parent.Parent.Parent.Controls.OfType<Form>();
                    foreach (Form item in frms)
                    {
                        item.Close();
                        item.Dispose();
                    }

                    FrmMain.lbltitleMain.Text = "Sistematização da Assistêmcia de Enfermagem";
                    FrmMain.iconTitleMain.IconChar = IconChar.Heartbeat;

                    var objSae = new SaeStatus
                    {
                        Id = Sessao.Paciente.SaeStatus.Id,
                        Status = Sae.Finalizado,
                        IdSetor = Sessao.Paciente.SaeStatus.IdSetor == 0 ? Sessao.Paciente.Sae.ExameFisico.IdSetor : Sessao.Paciente.SaeStatus.IdSetor,
                        Prontuario = Sessao.Paciente.Prontuario,
                    };

                    using (Form frm = new UI019FrmSaeAvisoEtapa1(objSae))
                    {
                        frm.TopLevel = true;
                        DialogResult dialog = frm.ShowDialog();

                        if (dialog == DialogResult.Yes)
                        {
                            presenterGeneric.Salvar(objSae, Procedure.SP_ADD_OR_UPDT_STATUS_SAE, Acao.Atualizar);
                            Sessao.Paciente = null;
                            Sessao.Paciente = new Paciente();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
        }

        bool ValidarForm()
        {
            try
            {
                string[] msg = 
                    { 
                        "A lista de indicadores da classificação NOC '{0}', não tem nenhum alvo flegado.",
                        "O ítem '{0}' da classificação NOC '{1}', não estão com todas as lacunas preenchidas",
                        "Nenhuma classificação foi selecionada para esta avaliação de enfermagem.",
                        "Favor pontuar os ítens das classificações flegadas.",
                        "Existem Classificações na lista suspensa que não foram pontuadas, favor pontuar todas as claissificações.",
                        "A Classificação NIC '{0}', não está associado a nenhuma Classificação NOC como resultado esperado."
                    };

                if (!avaliacoes.Any())
                {
                    MessageBox.Show(msg[3], "AVISO - NOC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                foreach (AvaliacaoEnfermagem item in avaliacoes)
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

                bool x =  lstClassificacao.Where(w => w.Codigo > 0).All(c => avaliacoes.Any(s => s.NicClassificacao.Value == c.Codigo.ToString()));

                if (!x)
                {
                    var nic =  lstClassificacao.Where(w => w.Codigo > 0).FirstOrDefault(c => !avaliacoes.Any(s => s.NicClassificacao.Value == c.Codigo.ToString()));
                    MessageBox.Show(string.Format(msg[5], nic.Classificacao), "AVISO - NOC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                
                if (avaliacoes.Count != (comboBoxClassificacao.Items.Count -1))
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

                if (comboBoxNicClassificacao.SelectedIndex == 0)
                {
                    MessageBox.Show("Selecione uma classificação NIC de Intervenção, para associar à classificação NOC de resultados.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Node.Checked = !e.Node.Checked;
                    comboBoxNicClassificacao.DroppedDown = true;
                    return;
                }

                if (e.Node.Level == 0)
                {
                    if (e.Node.Checked)
                    {
                        e.Node.Nodes.OfType<TreeNode>().Select(s => (NocIndicador)s.Tag).ToList().ForEach(f => f.Checked = e.Node.Checked);
                        e.Node.Nodes.OfType<TreeNode>().ToList().ForEach(n => n.Checked = e.Node.Checked);
                        ((NocResultado)e.Node.Tag).Checked = e.Node.Checked;

                        if (!comboBoxClassificacao.Items.Contains((NocResultado)e.Node.Tag))
                        {
                            comboBoxClassificacao.Items.Add((NocResultado)e.Node.Tag);
                        }
                    }
                    else
                    {
                        lstIndicadoresSelected.RemoveAll(r => r.IdResultado == ((NocResultado)e.Node.Tag).Codigo);
                        avaliacoes.RemoveAll(r => r.Codigo == ((NocResultado)e.Node.Tag).Codigo);

                        e.Node.Nodes.OfType<TreeNode>().Select(s => (NocIndicador)s.Tag).ToList().ForEach(f => f.Checked = e.Node.Checked);
                        e.Node.Nodes.OfType<TreeNode>().ToList().ForEach(f => f.Checked = e.Node.Checked);
                        comboBoxClassificacao.Items.Remove((NocResultado)e.Node.Tag);
                        comboBoxClassificacao.SelectedIndex = 0;
                        dataGridViewAvaliacao.DataSource = null;
                        dataGridViewAvaliacao.Visible = false;
                        lblDefinicao.Text = lblItemIndicador.Text = string.Empty;
                        npdOutros.Value = npdEstimativaAlvo.Value = 1;
                        npdOutros.Enabled = npdEstimativaAlvo.Enabled = comboBoxClassificacao.Items.Count > 1;
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

                    var itemAvaliacao = avaliacoes.FirstOrDefault(o => o.Codigo == indicador.IdResultado);

                    if (itemAvaliacao != null)
                    {
                        avaliacaoEnfermagem.PontuacaoIndicadorPrimario.Value.Checked = indicador.Codigo != (itemAvaliacao.PontuacaoIndicadorPrimario.Value.IdIndicador ?? indicador.Codigo);
                        itemAvaliacao.PontuacaoIndicadorPrimario.Value.Checked = indicador.Codigo != (itemAvaliacao.PontuacaoIndicadorPrimario.Value.IdIndicador ?? indicador.Codigo);
                        itemAvaliacao.Indicadores.Remove(indicador);
                        lstIndicadoresSelected.Remove(indicador);
                    }

                    if (!e.Node.Parent.Checked)
                    {
                        comboBoxClassificacao.Items.Remove(e.Node.Parent.Tag);
                        comboBoxClassificacao.SelectedIndex = 0;
                        lstIndicadoresSelected.RemoveAll(r => r.IdResultado ==indicador.IdResultado );
                        comboBoxClassificacao_SelectionChangeCommitted(null, null);
                    }

                }

                if (comboBoxClassificacao.Items.Count > 1)
                    if(comboBoxClassificacao.Items.Contains(e.Node.Level == 0 ? e.Node.Tag : e.Node.Parent.Tag))
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

        private void comboBoxClassificacao_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                npdEstimativaAlvo.ValueChanged -= npdEstimativaAlvo_ValueChanged;
                npdOutros.ValueChanged -= npdOutros_ValueChanged;

                UI011FrmTimeLine.iconButtonAvanca.Enabled = comboBoxClassificacao.SelectedIndex > 0;

                if (comboBoxClassificacao.SelectedIndex > 0)
                {
                    nocResultado = (NocResultado)comboBoxClassificacao.SelectedItem;
                    lblDefinicao.Text = nocResultado.Definicao;
                    lblItemIndicador.Text = string.Empty;
                    npdEstimativaAlvo.Value = npdOutros.Value = 1;
                    npdEstimativaAlvo.Enabled = npdOutros.Enabled = true;
                  
                    Cabecalho cabecalho = objCabecalho.FirstOrDefault(f => f.Codigo == nocResultado.Codigo);

                    var checkedResult = treeViewNoc.Nodes.OfType<TreeNode>().Where(x => x.Checked && ((NocResultado)x.Tag).Codigo == nocResultado.Codigo).FirstOrDefault();
                    
                    if (checkedResult is null)
                        return;

                    checkedResult.Nodes.OfType<TreeNode>().Where(x => x.Checked).Select(s => (NocIndicador)s.Tag).ToList()
                        .ForEach(g => {

                            if (!lstIndicadoresSelected.Any(h => h.Codigo.Equals(g.Codigo)))
                            {
                                lstIndicadoresSelected.Add(g);
                            }
                        });

                    avaliacaoEnfermagem = avaliacoes.FirstOrDefault(r => r.Codigo.Equals(nocResultado.Codigo));

                    if (avaliacaoEnfermagem is null)
                    {
                    
                        avaliacaoEnfermagem = new AvaliacaoEnfermagem
                        {
                            Codigo = nocResultado.Codigo,
                            Indicadores = lstIndicadoresSelected.Where(w => w.IdResultado == nocResultado.Codigo).OrderBy(l => l.Codigo).ToList(),
                            NicClassificacao = new KeyValuePair<string, string>(nocResultado.Codigo, comboBoxNicClassificacao.SelectedValue.ToString()),
                            Resultados = nocResultado, 
                            PontuacaoIndicadorPrimario = new KeyValuePair<string, AvaliacaoEnfermagem.ItemKeyValue>(nocResultado.Codigo, new AvaliacaoEnfermagem.ItemKeyValue { ValorIndicador = npdEstimativaAlvo.Value.ToString(), Checked = false }),
                            PontuacaoIndicadorSecundario = new KeyValuePair<string, AvaliacaoEnfermagem.ItemKeyValue>(nocResultado.Codigo, new AvaliacaoEnfermagem.ItemKeyValue { ValorIndicador = npdEstimativaAlvo.Value.ToString(), Checked = false })
                        };

                        avaliacoes.Add(avaliacaoEnfermagem);
                    }
                    else
                    {
                        NicClassificacao objNic = (NicClassificacao)comboBoxNicClassificacao.Items.OfType<NicClassificacao>().FirstOrDefault(s => s.Codigo == Convert.ToInt32(avaliacaoEnfermagem.NicClassificacao.Value));

                        if (objNic != null)
                            comboBoxNicClassificacao.SelectedItem = objNic;

                        avaliacaoEnfermagem.Codigo = nocResultado.Codigo;
                        avaliacaoEnfermagem.Indicadores = lstIndicadoresSelected.Where(w => w.IdResultado == nocResultado.Codigo).OrderBy(l => l.Codigo).ToList();
                        avaliacaoEnfermagem.Resultados = nocResultado;
                        lblItemIndicador.Text = lstIndicadoresSelected.Find(v => v.Codigo == avaliacaoEnfermagem.PontuacaoIndicadorPrimario.Value.IdIndicador)?.Nome;
                        lblItemIndicador.Visible = true;
                    }

                    dataGridViewAvaliacao.DataSource = null;
                    dataGridViewAvaliacao.Columns["Nome"].HeaderText = "Indicadores".ToUpper();
                    dataGridViewAvaliacao.Columns["T1"].HeaderText = cabecalho.T1.ToUpper();
                    dataGridViewAvaliacao.Columns["T2"].HeaderText = cabecalho.T2.ToUpper();
                    dataGridViewAvaliacao.Columns["T3"].HeaderText = cabecalho.T3.ToUpper();
                    dataGridViewAvaliacao.Columns["T4"].HeaderText = cabecalho.T4.ToUpper();
                    dataGridViewAvaliacao.Columns["T5"].HeaderText = cabecalho.T5.ToUpper();
                    dataGridViewAvaliacao.ColumnHeadersVisible = true;
                    dataGridViewAvaliacao.DataSource = lstIndicadoresSelected.Where(w => w.IdResultado == nocResultado.Codigo).OrderBy(l => l.Codigo).ToList();
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
                    comboBoxNicClassificacao.SelectedIndex = 0;
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

                    var itemIndicador = ((NocIndicador)senderGrid.CurrentRow.DataBoundItem);

                    avaliacaoEnfermagem = avaliacoes.FirstOrDefault(k => k.Codigo == itemIndicador.IdResultado);

                    if (avaliacaoEnfermagem != null)
                    {
                        avaliacaoEnfermagem.PontuacaoIndicadorPrimario.Value.Checked = ((bool)senderGrid.CurrentRow.Cells[1].EditedFormattedValue);
                        avaliacaoEnfermagem.PontuacaoIndicadorPrimario.Value.IdIndicador = ((NocIndicador)senderGrid.CurrentRow.DataBoundItem).Codigo;
                    }
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
    }
}
