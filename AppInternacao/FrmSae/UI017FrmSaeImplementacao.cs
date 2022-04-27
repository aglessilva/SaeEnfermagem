using AppInternacao.Enum;
using AppInternacao.Model;
using AppInternacao.Presenter;
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
        PresenterGeneric presenterGeneric = null;
        int idIndicador = 0;

        public UI017FrmSaeImplementacao(DataTable[] dataTables)
        {
            InitializeComponent();

            if (dataTables != null)
            {
                _dataTable = dataTables[0];
                _dataTableIdicadores = dataTables[1];
            }
        }

        void CarregarItens()
        {
            comboBoxDiagnostico.Items.Clear();

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
            dataTable.Columns.Add("Checked", typeof(bool));

            dataTableIdicadores = new DataTable();
            dataTableIdicadores.Columns.Add("Id", typeof(int));
            dataTableIdicadores.Columns.Add("IdClassificacao", typeof(int));
            dataTableIdicadores.Columns.Add("Indicador", typeof(string));
            dataTableIdicadores.Columns.Add("StatusImgIndic", typeof(Image));
            dataTableIdicadores.Columns.Add("Checked", typeof(bool));

            foreach (DataRow item in _dataTable.Rows)
            {
                dataRow = dataTable.NewRow();
                dataRow[0] = item[0];
                dataRow[1] = item[2];
                dataRow[2] = Properties.Resources.infoflat_105980;
                dataRow[3] = false;
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
                dataRow[3] = (bool)item[2] ? Properties.Resources.check : Properties.Resources.Wait;
                dataRow[4] = item[2];
                dataTableIdicadores.Rows.Add(dataRow);
            }

            _dataTableIdicadores = null;

            dataGridViewIndicadores.DataSource = dataTableIdicadores;
        }

        private void UI017FrmSaeImplementacao_Load(object sender, EventArgs e)
        {
            CarregarItens();
            intervencao = new IntervencaoEnfermagem();
            presenterGeneric = new PresenterGeneric();

            btnAddPrescricao.Visible = btnRemover.Visible = Sessao.Usuario.Perfil.HasFlag(Perfil.Administrador & Perfil.EnfermeiroAdmin & Perfil.Enfermeiro_Assistemcial);
            UI011FrmTimeLine.IconButtonVolta.Click += btnButtonBackStep_Click;

            if (Sessao.Paciente.SaeStatus.Status == Sae.Edicao)
                UI011FrmTimeLine.iconButtonAvanca.Click += btnButtonStepAvanca_Click;
            else
                UI011FrmTimeLine.iconButtonAvanca.Click += btnStepAvaliaacaoEnfermagem_Click;

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

        private void btnRemover_Click(object sender, EventArgs e)
        {
            textBoxDescricaoIndicadores.Text = string.Empty;
            intervencao.KeyPairAnotacaoPrescricaoEnfermagem.RemoveAll(r => r.Key == idIndicador);
            btnAddPrescricao_Click(sender, e);
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
                }
                else
                {
                    pnlButton.BringToFront();
                    btnAddPrescricao.Text = sender != null ? "Adicionar ítem" : "Atualizar ítem";
                    btnAddPrescricao.IconChar = IconChar.Edit;
                    btnAddPrescricao.Size = new Size(115, 30);
                    btnRemover.Location = new Point(150, 5);

                    textBoxDescricaoIndicadores.Text = intervencao.KeyPairAnotacaoPrescricaoEnfermagem.FirstOrDefault(n => n.Key == idIndicador).Value;
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
                    {
                        btnRemover.Visible = true && Sessao.Usuario.Perfil.HasFlag(Perfil.Administrador & Perfil.EnfermeiroAdmin & Perfil.Enfermeiro_Assistemcial);
                        btnAddPrescricao_Click(null, null);
                    }
                    else
                        btnRemover.Visible = false;

                    pnlButton.Enabled = pnlTextBox.Enabled = Sessao.Paciente.SaeStatus.Status == Sae.Edicao;
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
                if (e.RowIndex < 0 || Sessao.Paciente.SaeStatus.Status != Sae.Edicao)
                    return;

                var sendGrid = (DataGridView)sender;

                if (sendGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn)
                {
                    sendGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = !(bool)sendGrid.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value ? Properties.Resources.check : Properties.Resources.Wait;
                    sendGrid.Rows[e.RowIndex].Cells[e.ColumnIndex+1].Value = !(bool)sendGrid.Rows[e.RowIndex].Cells[e.ColumnIndex+1].Value;

                    int idClassificacao = (int)sendGrid.Rows[e.RowIndex].Cells[1].Value;
                    int idIndicador = (int)sendGrid.Rows[e.RowIndex].Cells[0].Value;

                    bool ret = dataTableIdicadores.Select($"IdClassificacao = {idClassificacao}").ToList().TrueForAll(r => (bool)r[4]);

                    foreach (DataRow item in dataTable.Rows)
                    {
                        if ((int)item[0] == idClassificacao)
                        {
                            item[2] = ret ? Properties.Resources.IsOk : Properties.Resources.infoflat_105980;
                            
                            Sessao.Paciente.Sae.IntervencaoEnfermagem.ForEach(f =>
                            {
                                if (f.Classificacao.Split(',').Any(a => a.Equals(idClassificacao.ToString())))
                                {
                                    f.KeyPairIndicadores.ForEach(n =>
                                    {
                                        if (n.Key.Equals(idClassificacao) && n.Value.Id.Equals(idIndicador))
                                        {
                                            n.Value.Ckecked = !n.Value.Ckecked;
                                            SalvarCheckItem();
                                        }
                                    });
                                }
                            });
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
        }

        private void SalvarCheckItem()
        {
            Sessao.Paciente.Sae.IntervencaoEnfermagem.ForEach(n => {
                n.AnotacaoPrescricaoEnfermagem = (n.KeyPairAnotacaoPrescricaoEnfermagem is null || !n.KeyPairAnotacaoPrescricaoEnfermagem.Any()) ? null : JsonConvert.SerializeObject(n.KeyPairAnotacaoPrescricaoEnfermagem, Formatting.None);
                n.Indicadores = (n.KeyPairIndicadores is null || !n.KeyPairIndicadores.Any()) ? null : JsonConvert.SerializeObject(n.KeyPairIndicadores, Formatting.None);
                n.Prontuario = Sessao.Paciente.Prontuario;
                n.IdSae = Sessao.Paciente.SaeStatus.Id;

                presenterGeneric.Salvar(n, Procedure.SP_ADD_OR_UPDT_INTERVENCAO_PRESCRICAO_ENFERMAGEM_SAE, Acao.Atualizar);

                return;
            });
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

                    dataTableIdicadores.DefaultView.RowFilter = $"IdClassificacao = {codigo} and Id in({string.Join(",", intervencao.KeyPairIndicadores.Select(s => s.Value.Id).ToArray())})";

                    //bool ret = dataTableIdicadores.Select($"IdClassificacao = {codigo}").ToList().TrueForAll(s => (bool)s[4]);
                    var ret = intervencao.KeyPairIndicadores.Where(f => f.Key == codigo).All(n => n.Value.Ckecked == true);

                    foreach (DataRow item in dataTable.Rows)
                    {
                        if ((int)item[0] == codigo)
                        {
                            item[2] = ret ? Properties.Resources.IsOk : Properties.Resources.infoflat_105980;
                            item[3] = ret;
                            break;
                        }
                    }

                    foreach (DataRow item in dataTableIdicadores.Rows)
                    {
                        var row = intervencao.KeyPairIndicadores.FirstOrDefault(f => f.Key == codigo && f.Value.Id == (int)item[0]).Value;

                        ret = row is null ? false : row.Ckecked;

                        item[3] = ret ? Properties.Resources.IsOk : Properties.Resources.infoflat_105980;
                        item[4] = ret;
                    }

                    dataGridViewIndicadores.Columns[0].Visible = false;
                    groupBoxIndicadores.Visible = dataTableIdicadores.DefaultView.Count > 0;
                }

            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
        }

        private void btnStepAvaliaacaoEnfermagem_Click(object sender, EventArgs e)
        { 

        }

        private void btnButtonStepAvanca_Click(object sender, EventArgs e)
        {
            try
            {
                var objSae = Sessao.Paciente.SaeStatus;
               
                int[] ret = {0,0,0,0};
                
                if (objSae.DataSae is null)
                {
                    objSae = new SaeStatus
                    {
                        Status = Sae.Edicao,
                        IdSetor = Sessao.Paciente.SaeStatus.IdSetor == 0 ? Sessao.Paciente.Sae.ExameFisico.IdSetor : Sessao.Paciente.SaeStatus.IdSetor,
                        Prontuario = Sessao.Paciente.Prontuario
                    };

                    ret[0] = presenterGeneric.Salvar(objSae, Procedure.SP_ADD_OR_UPDT_STATUS_SAE, Acao.Inserir);
                }
                else
                    ret[0] = objSae.Id;

                Sessao.Paciente.Sae.ExameFisico.IdSae = objSae.DataSae is null ? ret[0] : objSae.Id;
                Sessao.Paciente.Sae.ExameFisico.AreasItens = JsonConvert.SerializeObject(Sessao.Paciente.Sae.ExameFisico.ExameItens, Formatting.None);
                Sessao.Paciente.Sae.ExameFisico.ExameItens = null;

                ret[1] = presenterGeneric.Salvar(Sessao.Paciente.Sae.ExameFisico, Procedure.SP_ADD_OR_UPDT_EXAME_FISICO_SAE, objSae.DataSae is null ? Acao.Inserir : Acao.Atualizar) ;
                
                Sessao.Paciente.Sae.IntervencaoEnfermagem.ForEach(n => { 
                    n.AnotacaoPrescricaoEnfermagem = (n.KeyPairAnotacaoPrescricaoEnfermagem is null || !n.KeyPairAnotacaoPrescricaoEnfermagem.Any()) ? null :  JsonConvert.SerializeObject(n.KeyPairAnotacaoPrescricaoEnfermagem, Formatting.None);
                    n.Indicadores = (n.KeyPairIndicadores is null || !n.KeyPairIndicadores.Any()) ?  null : JsonConvert.SerializeObject(n.KeyPairIndicadores , Formatting.None);
                    n.Prontuario = Sessao.Paciente.Prontuario;
                    n.IdSae = objSae.DataSae is null ? ret[0] : objSae.Id;
                    n.KeyPairAnotacaoPrescricaoEnfermagem = null;
                    n.KeyPairIndicadores =  null;

                    ret[2] = presenterGeneric.Salvar(n, Procedure.SP_ADD_OR_UPDT_INTERVENCAO_PRESCRICAO_ENFERMAGEM_SAE, n.Id == 0 ? Acao.Inserir : Acao.Atualizar);
                });


                Sessao.Paciente.Sae.DiagnosticoEnfermagem.ForEach(n =>
                {
                    n.DiagnosticoEnfermagemDTO.Id = n.Id;
                    n.DiagnosticoEnfermagemDTO.IdSae = objSae.DataSae is null ? ret[0] : objSae.Id; 
                    n.DiagnosticoEnfermagemDTO.Diagnostico = JsonConvert.SerializeObject(n.Diagnostico, Formatting.None);
                    n.DiagnosticoEnfermagemDTO.CondicaoAssociadas = n.CondicaoAssociadas.Any() ? JsonConvert.SerializeObject(n.CondicaoAssociadas, Formatting.None) :  null;
                    n.DiagnosticoEnfermagemDTO.FatorRelacionados = n.FatorRelacionados.Any() ?  JsonConvert.SerializeObject(n.FatorRelacionados, Formatting.None) : null;
                    n.DiagnosticoEnfermagemDTO.FatorRiscos = n.FatorRiscos.Any() ? JsonConvert.SerializeObject(n.FatorRiscos, Formatting.None) : null;
                    n.DiagnosticoEnfermagemDTO.PopulacaoRiscos = n.PopulacaoRiscos.Any() ? JsonConvert.SerializeObject(n.PopulacaoRiscos, Formatting.None) : null;
                    n.DiagnosticoEnfermagemDTO.Prontuario = Sessao.Paciente.Prontuario;

                    ret[3] = presenterGeneric.Salvar(n.DiagnosticoEnfermagemDTO, Procedure.SP_ADD_OR_UPDT_DIAGNOSTICO_ENFERMAGEM_SAE, (n.DiagnosticoEnfermagemDTO.Id == 0 ? Acao.Inserir: Acao.Atualizar));
                });

                FrmMain.RemoveClickEvent(UI011FrmTimeLine.iconButtonAvanca);
                FrmMain.RemoveClickEvent(UI011FrmTimeLine.IconButtonVolta);

                var frms = Parent.Parent.Parent.Controls.OfType<Form>();
                foreach (Form item in frms)
                {
                    item.Close();
                    item.Dispose();
                }

                if (ret.ToList().TrueForAll(s => s > 0))
                {
                    using (Form frm = new UI019FrmSaeAvisoEtapa1())
                    {
                        frm.TopLevel = true;
                        DialogResult dialog = frm.ShowDialog();

                        if (dialog == DialogResult.Yes)
                        {
                            objSae.Id = objSae.DataSae is null ? ret[0] : objSae.Id; 
                            objSae.Status = Sae.Andamento;
                            objSae.DataSae = null;
                            ret[0] = presenterGeneric.Salvar(objSae, Procedure.SP_ADD_OR_UPDT_STATUS_SAE, Acao.Atualizar);
                            Sessao.Paciente = null;
                            Sessao.Paciente = new Paciente();
                        }
                    }
                }
                else
                    MessageBox.Show("Ocorreu algum erro durante a inserção do planejamento da SAE na base de dados, favor contate o suporte técnico do sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
        }

        private void btnButtonBackStep_Click(object sender, EventArgs e)
        {
            FrmMain.listButtons.ForEach(b => FrmMain.RemoveClickEvent(b));
            FrmMain.RemoveClickEvent(UI011FrmTimeLine.iconButtonAvanca);
            FrmMain.RemoveClickEvent(UI011FrmTimeLine.IconButtonVolta);

            Form controlForm = new UI016FrmSaePlanejamentoEnfermagem { TopLevel = false };
            UI011FrmTimeLine.lblRotuloSae.Text = "Planejamento - Intervenção/Prescrição de Enfermagem";
            UI011FrmTimeLine.iconButtonAvanca.Text = "AVANÇAR";
            UI011FrmTimeLine.iconButtonAvanca.ForeColor = Color.FromArgb(13, 87, 134);
            UI011FrmTimeLine.iconButtonAvanca.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            UI011FrmTimeLine.iconButtonAvanca.IconColor = Color.SteelBlue;
            UI011FrmTimeLine.ctrl.Controls.Clear();
            UI011FrmTimeLine.ctrl.Controls.Add(controlForm);
            controlForm.Show();
        }
    }
}
