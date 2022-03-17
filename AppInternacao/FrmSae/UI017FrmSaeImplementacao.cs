using AppInternacao.Enum;
using AppInternacao.Model;
using AppInternacao.Presenter;
using FontAwesome.Sharp;
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
    public partial class UI017FrmSaeImplementacao : AppInternacao.FrmSae.UI000FrmTemplate
    {
        
        DataRow dataRow = null;
        DataTable dataTable, dataTableIdicadores;
        PresenterGeneric presenterGeneric = null;
        List<NicClassificacao> listClasifficacao = null;
        List<NicIndicador> listIndicadores = null;
        IntervencaoEnfermagem intervencao = null;
        NandaDiagnostico diagnostico = null;

        public UI017FrmSaeImplementacao()
        {
            InitializeComponent();
            presenterGeneric = new PresenterGeneric();
        }

        void CarregarItens()
        {
            dataGridViewIndicadores.AutoGenerateColumns = false;
            dataGridViewClassificacao.AutoGenerateColumns = false;

            dataGridViewIndicadores.Cursor = Cursors.Hand;

            Sessao.Paciente.Sae.DiagnosticoEnfermagem.ForEach(d =>
            {
                comboBoxDiagnostico.Items.Add(d.Diagnostico);
            });
            comboBoxDiagnostico.Items.Insert(0, "Selecione um diagnóstico...");
            comboBoxDiagnostico.SelectedIndex = 0;


            listIndicadores = presenterGeneric.GetLista(new NicIndicador(), Procedure.SP_GET_NIC_INDICADORES);
            listClasifficacao = presenterGeneric.GetLista(new NicClassificacao(), Procedure.SP_GET_NIC_CLASSIFICACAO);

            dataTable = new DataTable();
            dataTable.Columns.Add("Codigo", typeof(int));
            dataTable.Columns.Add("Classificacao", typeof(string));
            dataTable.Columns.Add("statusImgClass", typeof(Image));

            dataTableIdicadores = new DataTable();
            dataTableIdicadores.Columns.Add("Id", typeof(int));
            dataTableIdicadores.Columns.Add("CodigoIndicador", typeof(int));
            dataTableIdicadores.Columns.Add("Indicador", typeof(string));
            dataTableIdicadores.Columns.Add("StatusImgIndic", typeof(Image));

            listClasifficacao.ForEach(c => {
                dataRow = dataTable.NewRow();
                dataRow[0] = c.Codigo;
                dataRow[1] = c.Classificacao;
                dataRow[2] = Properties.Resources.infoflat_105980;
                dataTable.Rows.Add(dataRow);
            });


            listClasifficacao.Clear();
           
            dataGridViewClassificacao.DataSource = dataTable;
            dataGridViewClassificacao.Cursor = Cursors.Hand;

            dataRow = null;
            listIndicadores.ForEach(c =>
            {
                dataRow = dataTableIdicadores.NewRow();
                dataRow[0] = c.Id;
                dataRow[1] = c.Codigo;
                dataRow[2] = c.Indicador;
                dataRow[3] = Properties.Resources.Wait;
                dataTableIdicadores.Rows.Add(dataRow);
            });

            listIndicadores.Clear();

            dataGridViewIndicadores.DataSource = dataTableIdicadores;
        }

        private void UI017FrmSaeImplementacao_Load(object sender, EventArgs e)
        {
            CarregarItens();
            UI011FrmTimeLine.iconButtonAvanca.Click += btnButtonStepAvanca_Click;
        }

        private void dataGridViewClassificacao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
                return;
            try
            {
                var sendGrid = (DataGridView)sender;

                if (sendGrid.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewImageCell)
                {
                    int codigo = Convert.ToInt32(sendGrid.Rows[e.RowIndex].Cells[0].Value);
                    List<int> codigoInsicadores = new List<int>();

                    intervencao.Indicadores.Split('|').ToList()
                        .ForEach(f =>
                        {
                            if (Convert.ToInt32(f.Split(',')[0]) == codigo)
                                codigoInsicadores.Add(int.Parse(f.Split(',')[1]));
                        });

                    dataTableIdicadores.DefaultView.RowFilter = $"CodigoIndicador = {codigo} and Id in({string.Join(",", codigoInsicadores.ToArray())})";

                    dataGridViewIndicadores.Columns[0].Visible = false;
                    dataGridViewIndicadores.DataSource = dataTableIdicadores;
                    groupBoxIndicadores.Visible = dataTableIdicadores.DefaultView.Count > 0;
                    groupBoxDescricaoIndicadores.Visible = false;
                }
            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
        }

        private void dataGridViewIndicadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;

                var sendGrid = (DataGridView)sender;

                if (e.ColumnIndex == 2)
                {
                    textBoxDescricaoIndicadores.Text = sendGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                    groupBoxDescricaoIndicadores.Visible = true;
                }
            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
        }

        private void comboBoxDiagnostico_SelectionChangeCommitted(object sender, EventArgs e)
        {
            groupBoxClassificacao.Visible = comboBoxDiagnostico.SelectedIndex > 0;

            if (comboBoxDiagnostico.SelectedIndex == 0)
                return;

            diagnostico = (NandaDiagnostico)comboBoxDiagnostico.SelectedItem;

            intervencao = Sessao.Paciente.Sae.IntervencaoEnfermagem.Find(d => d.CodigoDiagnostico.Equals(diagnostico.Codigo));
            intervencao.Indicadores = intervencao.Indicadores.Replace("[", "").Replace("]", "").Trim();

            dataTable.DefaultView.RowFilter = $"Codigo in({intervencao.Classificacao})";
        }

        private void btnButtonStepAvanca_Click(object sender, EventArgs e)
        {
            try
            {
                FrmMain.RemoveClickEvent(UI011FrmTimeLine.iconButtonAvanca);
                FrmMain.RemoveClickEvent(UI011FrmTimeLine.IconButtonVolta);

                UI011FrmTimeLine.ctrl.Controls.RemoveAt(0);

                Form frm = new UI018FrmSaeAvaliacao() { TopLevel = false };
                UI011FrmTimeLine.ctrl.Controls.Add(frm);
                UI011FrmTimeLine.lblRotuloSae.Text = "Avaliação de Enfermagem";
                frm.Show();
            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
        }
    }
}
