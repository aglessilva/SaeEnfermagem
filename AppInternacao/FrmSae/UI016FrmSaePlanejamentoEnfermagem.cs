using AppInternacao.Enum;
using AppInternacao.Model;
using AppInternacao.Presenter;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static AppInternacao.Model.IntervencaoEnfermagem;

namespace AppInternacao.FrmSae
{
    public partial class UI016FrmSaePlanejamentoEnfermagem : UI000FrmTemplate
    {
        PresenterGeneric presenterGeneric = null;
        List<NicClassificacao> listClasifficacao = null;
        List<NicIndicador> listIndicadores = null;
        List<IntervencaoEnfermagem> intervencaos = new List<IntervencaoEnfermagem>();
        NandaDiagnostico nandaDiagnostico = null;

        List<int> lstCodigoClassificacao = new List<int>();
        List<KeyValuePair<int, IndicadorItem>> lstCodigoIndicadores = new List<KeyValuePair<int, IndicadorItem>>();
        DataRow dataRow = null;
        
        DataTable dataTable, dataTableIdicadores;
        public UI016FrmSaePlanejamentoEnfermagem()
        {
            InitializeComponent();
        }

        private void UI016FrmIntervencaoEnfermagem_Load(object sender, EventArgs e)
        {
            try
            {
                UI011FrmTimeLine.lblRotuloSae.Text = "NIC - Planejamento Intervenção/Prescrição de Enfermagem";
                intervencaos.Clear();

                new ToolTip { IsBalloon = true, ToolTipTitle = "Informação", UseAnimation = true, ToolTipIcon = ToolTipIcon.Info }.SetToolTip(btnLimparCampo, "Limpar campo e filtros da classificação");
                new ToolTip { IsBalloon = true, ToolTipTitle = "Informação", UseAnimation = true, ToolTipIcon = ToolTipIcon.Info }.SetToolTip(btnLimparIndicadores, "Limpar compo e filtros dos indicadores");

                dataGridViewIndicadores.CellEnter -= dataGridViewIndicadores_CellEnter;

                dataTable = new DataTable();
                dataTable.Columns.Add("Codigo", typeof(int));
                dataTable.Columns.Add("Checked", typeof(bool));
                dataTable.Columns.Add("Classificacao", typeof(string));

                dataTableIdicadores = new DataTable();
                dataTableIdicadores.Columns.Add("Id", typeof(int));
                dataTableIdicadores.Columns.Add("Codigo", typeof(int));
                dataTableIdicadores.Columns.Add("Checked", typeof(bool));
                dataTableIdicadores.Columns.Add("Indicador", typeof(string));

                presenterGeneric = new PresenterGeneric();

                if (Sessao.Paciente.SaeStatus.DataSae != null && !Sessao.Paciente.Sae.IntervencaoEnfermagem.Any())
                {
                    intervencaos = presenterGeneric.GetLista(new IntervencaoEnfermagem { IdSae = Sessao.Paciente.SaeStatus.Id }, Procedure.SP_GET_INTERVENCAO_PRESCRICAO_ENFERMAGEM_SAE);
                    intervencaos.ForEach(f => {
                        if (f.AnotacaoPrescricaoEnfermagem != null)
                            f.KeyPairAnotacaoPrescricaoEnfermagem = JsonConvert.DeserializeObject<List<KeyValuePair<int, AnotacoesEnfermagem>>>(f.AnotacaoPrescricaoEnfermagem);

                        f.KeyPairIndicadores = JsonConvert.DeserializeObject<List<KeyValuePair<int, IndicadorItem>>>(f.Indicadores);
                    });
                }

                if (Sessao.Paciente.Sae.IntervencaoEnfermagem.Any())
                {
                    if (!intervencaos.Any())
                        intervencaos = Sessao.Paciente.Sae.IntervencaoEnfermagem;
                }

                Sessao.Paciente.Sae.DiagnosticoEnfermagem.ForEach(d =>
                {
                    comboBoxDiagnostico.Items.Add(d.Diagnostico);

                    if (!intervencaos.Any(s => s.CodigoDiagnostico == d.Diagnostico.Codigo))
                        intervencaos.Add(new IntervencaoEnfermagem { CodigoDiagnostico = d.Diagnostico.Codigo });
                });

                comboBoxDiagnostico.Items.Insert(0, "Selecione um diagnóstico...");
                comboBoxDiagnostico.SelectedIndex = 0;

                listClasifficacao = presenterGeneric.GetLista(new NicClassificacao(), Procedure.SP_GET_NIC_CLASSIFICACAO);
                listIndicadores = presenterGeneric.GetLista(new NicIndicador(), Procedure.SP_GET_NIC_INDICADORES);

                listClasifficacao.ForEach(c => {
                    dataRow = dataTable.NewRow();
                    dataRow[0] = c.Codigo;
                    dataRow[1] = false;
                    dataRow[2] = c.Classificacao;
                    dataTable.Rows.Add(dataRow);
                });

                listClasifficacao.Clear();

                listIndicadores.ForEach(c =>
                {
                    dataRow = dataTableIdicadores.NewRow();
                    dataRow[0] = c.Id;
                    dataRow[1] = c.Codigo;
                    dataRow[2] = false;
                    dataRow[3] = $"{c.Codigo} - {c.Indicador}";
                    dataTableIdicadores.Rows.Add(dataRow);
                });

                listIndicadores.Clear();

                dataGridViewClassificacao.DataSource = dataTable;
                dataGridViewIndicadores.DataSource = dataTableIdicadores;
                groupBoxIndicadores.Visible = textBoxDescricaoIndicadores.Visible = false;
                dataGridViewIndicadores.ClearSelection();

                UI011FrmTimeLine.iconButtonAvanca.Click += btnButtonStepAvanca_Click;               
                UI011FrmTimeLine.IconButtonVolta.Click += btnButtonBackStep_Click;               

            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
        }

        private void btnButtonBackStep_Click(object sender, EventArgs e)
        {
            FrmMain.listButtons.ForEach(b => FrmMain.RemoveClickEvent(b));
            FrmMain.listButtons.Find(b => b.Name.Equals("btnAddGeneric")).Visible = (Sessao.Paciente.SaeStatus.Status == Sae.Edicao);
            FrmMain.RemoveClickEvent(UI011FrmTimeLine.iconButtonAvanca);
            FrmMain.RemoveClickEvent(UI011FrmTimeLine.IconButtonVolta);

            Form controlForm = new UI010FrmNanda(true) { TopLevel = false };
            UI011FrmTimeLine.lblRotuloSae.Text = "Diagnóstico de Enfermagem";
            UI011FrmTimeLine.ctrl.Controls.Clear();
            UI011FrmTimeLine.ctrl.Controls.Add(controlForm);
            controlForm.Show();
        }

        private void btnButtonStepAvanca_Click(object sender, EventArgs e)
        {
            try
            {
                lstCodigoClassificacao.Clear();
                List<NandaDiagnostico> diagnosticos = comboBoxDiagnostico.Items.OfType<NandaDiagnostico>().ToList();

                if (!diagnosticos.All(x => intervencaos.Any(v => x.Codigo == v.CodigoDiagnostico)) || intervencaos.Any(v => string.IsNullOrWhiteSpace(v.Indicadores)))
                {
                    var obj = intervencaos.FirstOrDefault(v => string.IsNullOrWhiteSpace(v.Indicadores));
                    
                    var dig = obj is null ?  diagnosticos.LastOrDefault() : diagnosticos.FirstOrDefault(f => f.Codigo == obj.CodigoDiagnostico);

                    MessageBox.Show($"Não foi definido nenhuma intervenção para o diagnóstico ['{dig.Diagnostico}'].","Aviso",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    if(!intervencaos.Any(y => y.CodigoDiagnostico.Equals(dig.Codigo)))
                        intervencaos.Add(new IntervencaoEnfermagem { CodigoDiagnostico = dig.Codigo });

                    return;
                }
                
                intervencaos.ForEach(f => f.KeyPairIndicadores = JsonConvert.DeserializeObject<List<KeyValuePair<int, IndicadorItem>>>(f.Indicadores));

                foreach (IntervencaoEnfermagem item in intervencaos)
                {
                    lstCodigoClassificacao.Clear();
                    lstCodigoClassificacao.AddRange(item.Classificacao.Split(',').Select(int.Parse).AsEnumerable());
                    
                    bool isValid = lstCodigoClassificacao.All(s => item.KeyPairIndicadores.Exists(x => s.Equals(x.Key)));

                    if (!isValid)
                    {
                        var dig = comboBoxDiagnostico.Items.OfType<NandaDiagnostico>().FirstOrDefault(f => f.Codigo == item.CodigoDiagnostico);
                        var idClassificacao = lstCodigoClassificacao.FirstOrDefault(c => !item.KeyPairIndicadores.Any(s => s.Key.Equals(c)));
                        string msg = $">> INCONSISTÊNCIA <<\n\n"+
                                        $"Diagnostico: '{dig.Diagnostico}'\n" +
                                        $"Classificação: '{dataTable.Select($"Codigo = {idClassificacao}").FirstOrDefault()[2]}'\n\n" +
                                        $"Não possui nenhum indicador selecionado, por favor selecione pelo menos 1 indicador para essa classificacao.";

                        MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }

                Sessao.Paciente.Sae.IntervencaoEnfermagem = intervencaos;

                FrmMain.listButtons.ForEach(b => FrmMain.RemoveClickEvent(b));
                FrmMain.RemoveClickEvent(UI011FrmTimeLine.iconButtonAvanca);
                FrmMain.RemoveClickEvent(UI011FrmTimeLine.IconButtonVolta);

                UI011FrmTimeLine.ctrl.Controls.RemoveAt(0);

                List<int> lstIndicador = new List<int>();
                lstCodigoClassificacao.Clear();

                intervencaos.ForEach(f => f.KeyPairIndicadores.ForEach(n => { lstIndicador.Add(n.Value.Id); lstCodigoClassificacao.Add(n.Key); }));

                Form frm = new UI017FrmSaeImplementacao(new DataTable[] 
                {
                    dataTable.Select($"Codigo in({string.Join(",", lstCodigoClassificacao.ToArray())})").CopyToDataTable(), 
                    dataTableIdicadores.Select($"Id in({ string.Join(",", lstIndicador.ToArray())})").CopyToDataTable() 
                }) { TopLevel = false };

                UI011FrmTimeLine.ctrl.Controls.Add(frm);
                
                frm.Show();
            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
        }

        void FilteClassificacao(string nameClassificacao)
        {
            (dataGridViewClassificacao.DataSource as DataTable).DefaultView.RowFilter = string.Format("Classificacao like '%{0}%'", nameClassificacao);
        }

        private void comboBoxDiagnostico_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxDiagnostico.SelectedIndex == 0)
            {
                groupBoxClassificacao.Visible = groupBoxIndicadores.Visible = textBoxDescricaoIndicadores.Visible = false;
                lblDefinicao.Text = string.Empty;
                return;
            }
            lstCodigoClassificacao.Clear();
            lstCodigoIndicadores.Clear();

            groupBoxClassificacao.Visible = true;
            groupBoxIndicadores.Visible = false;

            nandaDiagnostico = (NandaDiagnostico)comboBoxDiagnostico.SelectedItem;

            EditInvervencao();
            
            lblDefinicao.Text = nandaDiagnostico.Definicao;
            lblDefinicao.Visible = true;

        }

        private void textBoxClassificacao_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxClassificacao.Text) && textBoxClassificacao.Text.Length > 2)
            {
                FilteClassificacao(textBoxClassificacao.Text.Trim());
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxClassificacao.Text))
                FilteClassificacao("");
        }

        private void btnLimparCampo_Click(object sender, EventArgs e)
        {
            textBoxClassificacao.Text = string.Empty;
            FilteClassificacao("");
        }

        private void dataGridViewClassificacao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var sendGrid = (DataGridView)sender;
                if (e.ColumnIndex == 1)
                {
                    if (sendGrid.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
                    {
                        dataGridViewIndicadores.CellEnter -= dataGridViewIndicadores_CellEnter;
                        sendGrid.CommitEdit(DataGridViewDataErrorContexts.Commit);

                        var linha = sendGrid.Rows[e.RowIndex].Cells[0].Value;

                        if (Convert.ToBoolean(sendGrid.Rows[e.RowIndex].Cells[1].Value))
                            lstCodigoClassificacao.Add(Convert.ToInt32(linha));
                        else
                        {
                            lstCodigoClassificacao.Remove(Convert.ToInt32(linha));
                            lstCodigoIndicadores.RemoveAll(i => i.Key.Equals(Convert.ToInt32(linha)));
                        }

                        nandaDiagnostico = (NandaDiagnostico)comboBoxDiagnostico.SelectedItem;
                        var obj = intervencaos.Find(i => i.CodigoDiagnostico == nandaDiagnostico.Codigo);

                        if (obj != null)
                        {
                            obj.Classificacao = string.Join(",", lstCodigoClassificacao);
                            obj.Indicadores = lstCodigoIndicadores.Any() ? JsonConvert.SerializeObject(lstCodigoIndicadores, Formatting.None) : null;
                        }

                        FilterIndicadores();
                        dataGridViewIndicadores.CellEnter += dataGridViewIndicadores_CellEnter;
                        dataTable.AcceptChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
        }

        private void dataGridViewIndicadores_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var sendGrid = (DataGridView)sender;
            textBoxDescricaoIndicadores.Visible = true;
            textBoxDescricaoIndicadores.Text = sendGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void dataGridViewIndicadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;

                var sendGrid = (DataGridView)sender;

                if (sendGrid.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewCheckBoxCell)
                {
                    sendGrid.CommitEdit(DataGridViewDataErrorContexts.Commit);
                    var idIndicador = sendGrid.Rows[e.RowIndex].Cells[0].Value;
                    var IdClassificacao = sendGrid.Rows[e.RowIndex].Cells[1].Value;

                    if (Convert.ToBoolean(sendGrid.Rows[e.RowIndex].Cells[2].Value))
                        lstCodigoIndicadores.Add(new KeyValuePair<int, IndicadorItem>(Convert.ToInt32(IdClassificacao), new IndicadorItem { Id = Convert.ToInt32(idIndicador) }));
                    else
                    {
                        lstCodigoIndicadores.RemoveAll(i => i.Value.Id.Equals(Convert.ToInt32(idIndicador)));
                        intervencaos.ForEach(f =>
                        {
                            f.KeyPairIndicadores.RemoveAll(s => s.Value.Id.Equals(Convert.ToInt32(idIndicador)));
                            f.KeyPairAnotacaoPrescricaoEnfermagem.RemoveAll(s => s.Key.Equals(Convert.ToInt32(idIndicador)));
                        });
                    }

                    nandaDiagnostico = (NandaDiagnostico)comboBoxDiagnostico.SelectedItem;
                    var obj = intervencaos.Find(i => i.CodigoDiagnostico == nandaDiagnostico.Codigo);
                    obj.Indicadores = JsonConvert.SerializeObject(lstCodigoIndicadores, Formatting.None);
                    dataTableIdicadores.AcceptChanges();
                }

            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
        }

        void FilterIndicadores()
        {
            groupBoxIndicadores.Visible = textBoxDescricaoIndicadores.Visible = lstCodigoClassificacao.Any();

            string filterRows = lstCodigoClassificacao.Any() ? $"Codigo not in({string.Join(",", lstCodigoClassificacao.ToArray())})" : "Codigo > 0";
            
            dataTableIdicadores.Select(filterRows).AsEnumerable().ToList().ForEach(f => f.SetField(2, false));

            filterRows = lstCodigoClassificacao.Any() ? $"Codigo in({string.Join(",", lstCodigoClassificacao.ToArray())})" : "Codigo > 0";

            (dataGridViewIndicadores.DataSource as DataTable).DefaultView.RowFilter = filterRows;

           
            textBoxDescricaoIndicadores.Text = string.Empty;
            dataGridViewIndicadores.ClearSelection();
        }

        void CleanFilter()
        {
            foreach (DataRow item in dataTable.Rows){ item[1] = false;}
            foreach (DataRow item in dataTableIdicadores.Rows){item[2] = false;}
            dataGridViewClassificacao.Refresh();
        }
       
        void EditInvervencao()
        {
            try
            {
                (dataGridViewIndicadores.DataSource as DataTable).DefaultView.RowFilter = "Codigo > 0";

                var obj = intervencaos.Find(i => i.CodigoDiagnostico == nandaDiagnostico.Codigo);
                var isClear = intervencaos.Any(x => x.CodigoDiagnostico == nandaDiagnostico.Codigo
                     && !string.IsNullOrWhiteSpace(x.Classificacao)
                     && string.IsNullOrWhiteSpace(x.Indicadores));

                if (string.IsNullOrWhiteSpace(obj?.Classificacao) || isClear)
                {
                    CleanFilter();
                    return;
                }
                else
                {
                    lstCodigoClassificacao.AddRange(obj.Classificacao.Split(',').Select(int.Parse).AsEnumerable());
                    foreach (DataRow item in dataTable.Rows)
                        item[1] = lstCodigoClassificacao.Any(n => n.Equals(item[0]));


                    if (!string.IsNullOrWhiteSpace(obj.Indicadores))
                    {
                        groupBoxIndicadores.Visible = true;

                        lstCodigoIndicadores.AddRange(JsonConvert.DeserializeObject<List<KeyValuePair<int, IndicadorItem>>>(obj.Indicadores).AsEnumerable());

                        (dataGridViewIndicadores.DataSource as DataTable).DefaultView.RowFilter = string.Format("Codigo in({0})", string.Join(",", lstCodigoClassificacao.ToArray()));

                        dataTableIdicadores.Select(string.Format("Codigo in({0})", string.Join(",", lstCodigoClassificacao.ToArray()))).ToList()
                            .ForEach(f => f[2] = lstCodigoIndicadores.Any(n => n.Value.Id == Convert.ToInt32(f[0])));

                    }

                    groupBoxClassificacao.Enabled = groupBoxIndicadores.Enabled = Sessao.Paciente.SaeStatus.Status == Sae.Edicao;

                    if (Sessao.Paciente.SaeStatus.Status != Sae.Edicao)
                    {
                        dataTable.DefaultView.RowFilter = "Checked = true";
                        dataTableIdicadores.DefaultView.RowFilter = $"Checked = true and Codigo in ({string.Join(",", lstCodigoClassificacao.ToArray())})";
                    }
                }
            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
        }

        private void textBoxIndicadores_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxIndicadores.Text) && textBoxIndicadores.Text.Length > 2)
            {
                (dataGridViewIndicadores.DataSource as DataTable).DefaultView.RowFilter = $"Codigo in({string.Join(",", lstCodigoClassificacao.ToArray())}) and Indicador like '%{textBoxIndicadores.Text}%'";
                return;
            }

            if(string.IsNullOrWhiteSpace(textBoxIndicadores.Text))
                (dataGridViewIndicadores.DataSource as DataTable).DefaultView.RowFilter = $"Codigo in({string.Join(",", lstCodigoClassificacao.ToArray())})";
        }

        private void btnLimparIndicadores_Click(object sender, EventArgs e)
        {
            textBoxIndicadores.Text = "";
        }

    }
}
