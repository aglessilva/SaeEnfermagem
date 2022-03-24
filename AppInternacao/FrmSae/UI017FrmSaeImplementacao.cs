using AppInternacao.Model;
using FontAwesome.Sharp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AppInternacao.FrmSae
{
    public partial class UI017FrmSaeImplementacao : UI000FrmTemplate
    {
        
        DataRow dataRow = null;
        DataTable dataTable, dataTableIdicadores, _dataTable, _dataTableIdicadores;
        IntervencaoEnfermagem intervencao = null;
        NandaDiagnostico diagnostico = null;
        int idIndicador = 0;

        public UI017FrmSaeImplementacao(DataTable[] dataTables)
        {
            InitializeComponent();
            _dataTable = dataTables[0];
            _dataTableIdicadores = dataTables[1];

            dataTables = null;
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



            dataTable = new DataTable();
            dataTable.Columns.Add("Codigo", typeof(int));
            dataTable.Columns.Add("Classificacao", typeof(string));
            dataTable.Columns.Add("statusImgClass", typeof(Image));

            dataTableIdicadores = new DataTable();
            dataTableIdicadores.Columns.Add("Id", typeof(int));
            dataTableIdicadores.Columns.Add("IdClassificacao", typeof(int));
            dataTableIdicadores.Columns.Add("Indicador", typeof(string));
            dataTableIdicadores.Columns.Add("StatusImgIndic", typeof(Image));

            foreach (DataRow item in _dataTable.Rows)
            {
                dataRow = dataTable.NewRow();
                dataRow[0] = item[0];
                dataRow[1] = item[2];
                dataRow[2] = Properties.Resources.infoflat_105980;
                dataTable.Rows.Add(dataRow);
            }

            _dataTable = null;

            dataGridViewClassificacao.DataSource = dataTable;
            dataGridViewClassificacao.Cursor = Cursors.Hand;

            dataRow = null;

            foreach (DataRow item in _dataTableIdicadores.Rows)
            {
                dataRow = dataTableIdicadores.NewRow();
                dataRow[0] = item[0];
                dataRow[1] = item[1];
                dataRow[2] = item[3];
                dataRow[3] = Properties.Resources.Wait;
                dataTableIdicadores.Rows.Add(dataRow);
            }

            _dataTableIdicadores = null;

            dataGridViewIndicadores.DataSource = dataTableIdicadores;
        }

        private void UI017FrmSaeImplementacao_Load(object sender, EventArgs e)
        {
            CarregarItens();
            intervencao = new IntervencaoEnfermagem();
            UI011FrmTimeLine.iconButtonAvanca.Click += btnButtonStepAvanca_Click;
        }

        private void comboBoxDiagnostico_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxDiagnostico.SelectedIndex == 0)
                {
                    groupBoxClassificacao.Visible = groupBoxIndicadores.Visible = pnlTextBox.Visible = pnlButton.Visible = false;
                    return;
                }

                groupBoxClassificacao.Visible = comboBoxDiagnostico.SelectedIndex > 0;
                groupBoxIndicadores.Visible = false;
                diagnostico = (NandaDiagnostico)comboBoxDiagnostico.SelectedItem;

                intervencao = Sessao.Paciente.Sae.IntervencaoEnfermagem.Find(d => d.CodigoDiagnostico.Equals(diagnostico.Codigo));
                
                dataTable.DefaultView.RowFilter = $"Codigo in({intervencao.Classificacao})";
                dataTableIdicadores.DefaultView.RowFilter = "IdClassificacao = 0";
                dataGridViewIndicadores.ClearSelection();
                dataGridViewClassificacao.ClearSelection();
                pnlTextBox.Visible = pnlButton.Visible = false;
            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
        }

        private void btnAddPrescricao_Click(object sender, EventArgs e)
        {
            try
            {
                pnlTextBox.Visible = !pnlTextBox.Visible;

                if (!pnlTextBox.Visible)
                {
                    pnlButton.SendToBack();
                    btnAddPrescricao.Text = "Inserir Observação/Prescrição de Enfermagem";
                    btnAddPrescricao.Size = new Size(270, 30);
                    btnAddPrescricao.IconChar = IconChar.PlusCircle;
                    if (!string.IsNullOrWhiteSpace(textBoxDescricaoIndicadores.Text))
                    {
                        intervencao.KeyPairAnotacaoPrescricaoEnfermagem.RemoveAll(r => r.Key == idIndicador);
                        intervencao.KeyPairAnotacaoPrescricaoEnfermagem.Add(new KeyValuePair<int, string>(idIndicador, textBoxDescricaoIndicadores.Text));
                        textBoxDescricaoIndicadores.Text = string.Empty;
                    }
                    else
                        intervencao.KeyPairAnotacaoPrescricaoEnfermagem.RemoveAll(r => r.Key == idIndicador);
                }
                else
                {
                    pnlButton.BringToFront();
                    btnAddPrescricao.Text = sender != null ? "Adicionar ítem" : "Atualizar ítem";
                    btnAddPrescricao.IconChar = IconChar.Edit;
                    btnAddPrescricao.Size = new Size(115, 30);
                    textBoxDescricaoIndicadores.Text = intervencao.KeyPairAnotacaoPrescricaoEnfermagem.FirstOrDefault(n => n.Key == idIndicador).Value;
                }
            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
        }

        private void dataGridViewClassificacao_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            try
            {
                var sendGrid = (DataGridView)sender;

                if (sendGrid.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewImageCell)
                {
                    int codigo = Convert.ToInt32(sendGrid.Rows[e.RowIndex].Cells[0].Value);
                    dataTableIdicadores.DefaultView.RowFilter = $"IdClassificacao = {codigo} and Id in({string.Join(",", intervencao.KeyPairIndicadores.Select(s => s.Value).ToArray())})";
                }
            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
        }

        private void dataGridViewIndicadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;

                var sendGrid = (DataGridView)sender;

                if (!(sendGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn))
                {
                    idIndicador = Convert.ToInt32(sendGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                    pnlButton.Visible = true;
                    pnlTextBox.Visible = false;
                    btnAddPrescricao.Text = "Inserir Observação/Prescrição de Enfermagem";
                    btnAddPrescricao.Size = new Size(270, 30);

                    if (intervencao.KeyPairAnotacaoPrescricaoEnfermagem.Any(n => n.Key == idIndicador))
                        btnAddPrescricao_Click(null, null);
                }

            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
        }

        private void dataGridViewIndicadores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;

                var sendGrid = (DataGridView)sender;

                if (e.ColumnIndex == 2)
                {
                    var idIdicador = sendGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                    panel2.Visible = true;
                }
            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
        }

        private void dataGridViewClassificacao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            try
            {
                var sendGrid = (DataGridView)sender;

                if (!(sendGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn))
                {
                    pnlButton.Visible = pnlTextBox.Visible = false;
                    int codigo = Convert.ToInt32(sendGrid.Rows[e.RowIndex].Cells[0].Value);

                    dataTableIdicadores.DefaultView.RowFilter = $"IdClassificacao = {codigo} and Id in({string.Join(",", intervencao.KeyPairIndicadores.Select(s => s.Value).ToArray())})";

                    dataGridViewIndicadores.Columns[0].Visible = false;
                    groupBoxIndicadores.Visible = dataTableIdicadores.DefaultView.Count > 0;
                }

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
                FrmMain.RemoveClickEvent(UI011FrmTimeLine.iconButtonAvanca);
                FrmMain.RemoveClickEvent(UI011FrmTimeLine.IconButtonVolta);

                Sessao.Paciente.Sae.IntervencaoEnfermagem.ForEach(n => { 
                    n.AnotacaoPrescricaoEnfermagem = JsonConvert.SerializeObject(n.KeyPairAnotacaoPrescricaoEnfermagem, Formatting.None);
                    n.Indicadores = JsonConvert.SerializeObject(n.KeyPairIndicadores, Formatting.None);
                    n.KeyPairAnotacaoPrescricaoEnfermagem = null;
                    n.KeyPairIndicadores = null;
                });


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
