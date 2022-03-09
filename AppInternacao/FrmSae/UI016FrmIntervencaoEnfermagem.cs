using AppInternacao.Enum;
using AppInternacao.Extend;
using AppInternacao.Model;
using AppInternacao.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppInternacao.FrmSae
{
    public partial class UI016FrmIntervencaoEnfermagem : UI000FrmTemplate
    {
        PresenterGeneric presenterGeneric = null;
        List<NicClassificacao> listClasifficacao = null;
        List<NicIndicador> listIndicadores = null;

        List<int> lst = new List<int>();
        DataRow dataRow = null;

        DataTable dataTable, dataTableIdicadores;
        public UI016FrmIntervencaoEnfermagem()
        {
            InitializeComponent();
        }

        private void UI016FrmIntervencaoEnfermagem_Load(object sender, EventArgs e)
        {
            try
            {
                dataTable = new DataTable();
                dataTable.Columns.Add("Codigo", typeof(int));
                dataTable.Columns.Add("Checked", typeof(bool));
                dataTable.Columns.Add("Classificacao", typeof(string));

                dataTableIdicadores = new DataTable();
                dataTableIdicadores.Columns.Add("Codigo", typeof(int));
                dataTableIdicadores.Columns.Add("Checked", typeof(bool));
                dataTableIdicadores.Columns.Add("Indicador", typeof(string));

                presenterGeneric = new PresenterGeneric();

                Sessao.Paciente.Sae.DiagnosticoEnfermagem.ForEach(d =>
                {
                    comboBoxDiagnostico.Items.Add(d.Diagnostico);
                });

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
                    dataRow[0] = c.Codigo;
                    dataRow[1] = false;
                    dataRow[2] = c.Indicador;
                    dataTableIdicadores.Rows.Add(dataRow);
                });

                listIndicadores.Clear();

                dataGridViewClassificacao.DataSource = dataTable;
                dataGridViewIndicadores.DataSource = dataTableIdicadores;
                groupBoxIndicadores.Visible = false;

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
            NandaDiagnostico nandaDiagnostico = (NandaDiagnostico)comboBoxDiagnostico.SelectedItem;
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
                    sendGrid.CommitEdit(DataGridViewDataErrorContexts.Commit);

                    var linha = sendGrid.Rows[e.RowIndex].Cells[0].Value;

                    if (Convert.ToBoolean(sendGrid.Rows[e.RowIndex].Cells[1].Value))
                        lst.Add(Convert.ToInt32(linha));
                    else
                        lst.Remove(Convert.ToInt32(linha));

                    FilterIndicadores();
                }
            }
        }


        void FilterIndicadores()
        {
            groupBoxIndicadores.Visible = lst.Count > 0;

            if (lst.Count > 0)
            {
                (dataGridViewIndicadores.DataSource as DataTable).DefaultView.RowFilter = string.Format("Codigo in({0})", string.Join(",", lst.ToArray()));
                dataTableIdicadores.Select(string.Format("Codigo not in({0})", string.Join(",", lst.ToArray()))).ToList().ForEach(f => f[1] = false);
            }
            else
            {
                (dataGridViewIndicadores.DataSource as DataTable).DefaultView.RowFilter = "Codigo > 0";
                foreach (DataRow item in dataTableIdicadores.Rows)
                {
                    item[1] = false;
                }
            }
        }

    }
}
