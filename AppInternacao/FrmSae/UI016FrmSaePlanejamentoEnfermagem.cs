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
    public partial class UI016FrmSaePlanejamentoEnfermagem : UI000FrmTemplate
    {
        PresenterGeneric presenterGeneric = null;
        List<NicClassificacao> listClasifficacao = null;
        List<NicIndicador> listIndicadores = null;
        List<IntervencaoEnfermagem> intervencaos = new List<IntervencaoEnfermagem>();
        NandaDiagnostico nandaDiagnostico = null;

        List<int> lstCodigoClassificacao = new List<int>();
        List<KeyValuePair<int, int>> lstCodigoIndicadores = new List<KeyValuePair<int, int>>();
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

                Sessao.Paciente.Sae.DiagnosticoEnfermagem.ForEach(d =>
                {
                    comboBoxDiagnostico.Items.Add(d.Diagnostico);
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
                    dataRow[3] = c.Indicador;
                    dataTableIdicadores.Rows.Add(dataRow);
                });

                listIndicadores.Clear();

                dataGridViewClassificacao.DataSource = dataTable;
                dataGridViewIndicadores.DataSource = dataTableIdicadores;
                groupBoxIndicadores.Visible = textBoxDescricaoIndicadores.Visible = false;
                dataGridViewIndicadores.ClearSelection();

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
                if (intervencaos.Any(v => string.IsNullOrWhiteSpace(v.Indicadores)))
                {
                    var obj = intervencaos.FirstOrDefault(v => string.IsNullOrWhiteSpace(v.Indicadores));
                    var dig = comboBoxDiagnostico.Items.OfType<NandaDiagnostico>().FirstOrDefault(f => f.Codigo == obj.CodigoDiagnostico);
                    MessageBox.Show($"Não foi definido nenhuma intervenção para o diagnóstico ['{dig.Diagnostico}'].","Aviso",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                Sessao.Paciente.Sae.IntervencaoEnfermagem.AddRange(intervencaos.AsEnumerable());

                FrmMain.RemoveClickEvent(UI011FrmTimeLine.iconButtonAvanca);
                FrmMain.RemoveClickEvent(UI011FrmTimeLine.IconButtonVolta);

                UI011FrmTimeLine.ctrl.Controls.RemoveAt(0);

                Form frm = new UI017FrmSaeImplementacao() { TopLevel = false };
                UI011FrmTimeLine.ctrl.Controls.Add(frm);
                UI011FrmTimeLine.lblRotuloSae.Text = "Implementação - Intervenção de Enfermagem";
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
                groupBoxClassificacao.Visible = groupBoxIndicadores.Visible = false;
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
                    obj.Classificacao = string.Join(",", lstCodigoClassificacao);
                    obj.Indicadores = string.Join("|", lstCodigoIndicadores);

                    FilterIndicadores();
                    dataGridViewIndicadores.CellEnter += dataGridViewIndicadores_CellEnter;
                }
            }
        }

        private void dataGridViewIndicadores_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var sendGrid = (DataGridView)sender;
            textBoxDescricaoIndicadores.Text = sendGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void dataGridViewIndicadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    lstCodigoIndicadores.Add(new KeyValuePair<int, int>(Convert.ToInt32(IdClassificacao), Convert.ToInt32(idIndicador)));
                else
                    lstCodigoIndicadores.RemoveAll(i => i.Value.Equals(Convert.ToInt32(idIndicador)));

                nandaDiagnostico = (NandaDiagnostico)comboBoxDiagnostico.SelectedItem;
                var obj = intervencaos.Find(i => i.CodigoDiagnostico == nandaDiagnostico.Codigo);
                obj.Indicadores = string.Join("|", lstCodigoIndicadores);
            }

        }

        void FilterIndicadores()
        {
            groupBoxIndicadores.Visible = textBoxDescricaoIndicadores.Visible = lstCodigoClassificacao.Any();

            if (lstCodigoClassificacao.Any())
            {
                (dataGridViewIndicadores.DataSource as DataTable).DefaultView.RowFilter = string.Format("Codigo in({0})", string.Join(",", lstCodigoClassificacao.ToArray()));
               // dataTableIdicadores.Select(string.Format("Codigo not in({0})", string.Join(",", lstCodigoClassificacao.ToArray()))).ToList().ForEach(f => f[2] = false);
            }
            else
            {
                (dataGridViewIndicadores.DataSource as DataTable).DefaultView.RowFilter = "Codigo > 0";
                foreach (DataRow item in dataTableIdicadores.Rows)
                {
                    item[2] = false;
                }
            }

            textBoxDescricaoIndicadores.Text = string.Empty;
            dataGridViewIndicadores.ClearSelection();
        }

        void CleanFilter()
        {
            foreach (DataRow item in dataTable.Rows){ item[1] = false;}
            foreach (DataRow item in dataTableIdicadores.Rows){item[2] = false;}
            dataGridViewClassificacao.Refresh();
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

        void EditInvervencao()
        {
            (dataGridViewIndicadores.DataSource as DataTable).DefaultView.RowFilter = "Codigo > 0";

            var obj = intervencaos.Find(i => i.CodigoDiagnostico == nandaDiagnostico.Codigo);
            var isClear = intervencaos.Any(x => x.CodigoDiagnostico == nandaDiagnostico.Codigo
                 && !string.IsNullOrWhiteSpace(x.Classificacao)
                 && string.IsNullOrWhiteSpace(x.Indicadores));

            if (string.IsNullOrWhiteSpace(obj.Classificacao) || isClear)
            {
                CleanFilter();
                return;
            }
            else
            {
                lstCodigoClassificacao.AddRange(obj.Classificacao.Split(',').Select(int.Parse).AsEnumerable());
                foreach (DataRow item in dataTable.Rows)
                    item[1] = lstCodigoClassificacao.Any(n => n.Equals(item[0]));

                obj.Indicadores = obj.Indicadores.Replace("[", "").Replace("]", "").Trim();

                if (!string.IsNullOrWhiteSpace(obj.Indicadores))
                {
                    groupBoxIndicadores.Visible = true;
                    lstCodigoIndicadores.AddRange(obj.Indicadores.Split('|').Select(k => new KeyValuePair<int, int>(int.Parse(k.Split(',')[0]), int.Parse(k.Split(',')[1]))));

                    (dataGridViewIndicadores.DataSource as DataTable).DefaultView.RowFilter = string.Format("Codigo in({0})", string.Join(",", lstCodigoClassificacao.ToArray()));

                    dataTableIdicadores.Select(string.Format("Codigo in({0})", string.Join(",", lstCodigoClassificacao.ToArray()))).ToList()
                        .ForEach(f => f[2] = lstCodigoIndicadores.Any(n => n.Value == Convert.ToInt32(f[0])));
                }
                
            }
        }
    }
}
