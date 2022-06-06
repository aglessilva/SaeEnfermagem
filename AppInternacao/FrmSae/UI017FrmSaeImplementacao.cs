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
using static AppInternacao.Model.IntervencaoEnfermagem;

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

            dataRow = null;

            KeyValuePair<int, IndicadorItem> indicadorItem;

            foreach (DataRow item in _dataTableIdicadores.Rows)
            {
                intervencao = Sessao.Paciente.Sae.IntervencaoEnfermagem.FirstOrDefault(f => f.Classificacao.Split(',').Any(c => c.Trim().Equals(item[1].ToString().Trim())));
                indicadorItem = intervencao is null ? new KeyValuePair<int, IndicadorItem>() : intervencao.KeyPairIndicadores.FirstOrDefault(f => f.Value.Id == (int)item[0]);

                dataRow = dataTableIdicadores.NewRow();
                dataRow[0] = item[0];
                dataRow[1] = item[1];
                dataRow[2] = item[3];
                dataRow[3] = indicadorItem.Value?.Ckecked ?? false  ? Properties.Resources.check : Properties.Resources.Wait;
                dataRow[4] = item[2];
                dataTableIdicadores.Rows.Add(dataRow);
            }

          //  _dataTableIdicadores = null;

            dataGridViewIndicadores.DataSource = dataTableIdicadores;

            bool ret;
            foreach (DataRow item in _dataTable.Rows)
            {
                intervencao = Sessao.Paciente.Sae.IntervencaoEnfermagem.FirstOrDefault(f => f.Classificacao.Split(',').Any(c => c.Trim().Equals(item[0].ToString().Trim())));

                ret = intervencao?.KeyPairIndicadores.Where(w => w.Key == Convert.ToInt32(item[0])).All(a => a.Value.Ckecked) ?? false;

                dataRow = dataTable.NewRow();
                dataRow[0] = item[0];
                dataRow[1] = item[2];
                dataRow[2] = ret ? Properties.Resources.IsOk : Properties.Resources.infoflat_105980;
                dataRow[3] = ret;
                dataTable.Rows.Add(dataRow);
            }

         //   _dataTable = null;

            dataGridViewClassificacao.DataSource = dataTable;
            dataGridViewClassificacao.Cursor = Cursors.Hand;
        }

        private void UI017FrmSaeImplementacao_Load(object sender, EventArgs e)
        {
            try
            {
                CarregarItens();
                intervencao = new IntervencaoEnfermagem();
                presenterGeneric = new PresenterGeneric();

                btnAddPrescricao.Visible = btnRemover.Visible = Sessao.Usuario.Perfil.HasFlag(Perfil.Administrador & Perfil.EnfermeiroAdmin & Perfil.Enfermeiro_Assistemcial);

                if (Tag is null)
                {
                    UI011FrmTimeLine.lblRotuloSae.Text = "Implementação - Intervenção de Enfermagem";
                    UI011FrmTimeLine.IconButtonVolta.Click += btnButtonBackStep_Click;
                    dataGridViewIndicadores.CellContentDoubleClick -= dataGridViewIndicadores_CellContentDoubleClick;
                    UI011FrmTimeLine.iconButtonAvanca.Text = (Sae.Edicao | Sae.Nenhum).HasFlag(Sessao.Paciente.SaeStatus.Status) ? "INICIAR" : "AVALIAÇÃO";
                    UI011FrmTimeLine.iconButtonAvanca.Visible = UI011FrmTimeLine.iconButtonAvanca.Enabled = true;

                    if ((Sae.Edicao | Sae.Nenhum).HasFlag(Sessao.Paciente.SaeStatus.Status))
                    {
                        UI011FrmTimeLine.iconButtonAvanca.ForeColor = (Sae.Edicao | Sae.Nenhum).HasFlag(Sessao.Paciente.SaeStatus.Status) ? Color.SeaGreen : Color.FromArgb(13, 87, 134);
                        UI011FrmTimeLine.iconButtonAvanca.IconChar = (Sae.Edicao | Sae.Nenhum).HasFlag(Sessao.Paciente.SaeStatus.Status) ? FontAwesome.Sharp.IconChar.Check : FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
                        UI011FrmTimeLine.iconButtonAvanca.IconColor = (Sae.Edicao | Sae.Nenhum).HasFlag(Sessao.Paciente.SaeStatus.Status) ? Color.SeaGreen : Color.SteelBlue;
                        UI011FrmTimeLine.iconButtonAvanca.Click += btnButtonStepAvanca_Click;
                    }
                    else
                    {
                        UI011FrmTimeLine.iconButtonAvanca.ForeColor = Color.Green;
                        UI011FrmTimeLine.iconButtonAvanca.IconColor = Color.Green;
                        UI011FrmTimeLine.iconButtonAvanca.IconChar = IconChar.ArrowCircleRight;
                        UI011FrmTimeLine.iconButtonAvanca.Click += btnStepAvaliaacaoEnfermagem_Click;
                    }
                }

            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
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
            if (((IconButton)sender).Name.Equals("btnRemover"))
                intervencao.KeyPairAnotacaoPrescricaoEnfermagem.RemoveAll(r => r.Key == idIndicador);
            
            pnlButton.SendToBack();
            btnAddPrescricao.Text = "Inserir Observação/Prescrição de Enfermagem";
            btnAddPrescricao.Size = new Size(270, 30);
            btnAddPrescricao.IconChar = IconChar.PlusCircle;
            btnRemover.Visible = pnlTextBox.Visible = false;
            textBoxDescricaoIndicadores.Text = string.Empty;

        }

        private void btnAddPrescricao_Click(object sender, EventArgs e)
        {
            try
            {
                if (Tag != null)
                {
                    pnlButton.BringToFront();
                    pnlButton.Visible = pnlTextBox.Visible = true;
                    btnAddPrescricao.Text = "Inserir Observação/Prescrição de Enfermagem";
                    btnAddPrescricao.Size = new Size(270, 30);
                    btnAddPrescricao.IconChar = IconChar.PlusCircle;
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(textBoxDescricaoIndicadores.Text))
                    {
                        intervencao.KeyPairAnotacaoPrescricaoEnfermagem.RemoveAll(r => r.Key == idIndicador);
                        intervencao.KeyPairAnotacaoPrescricaoEnfermagem.Add(new KeyValuePair<int, AnotacoesEnfermagem>(idIndicador, new AnotacoesEnfermagem { AnotacaoEnfermeiro = textBoxDescricaoIndicadores.Text }));
                        textBoxDescricaoIndicadores.Text = string.Empty;
                        btnRemover_Click(sender, e);
                    }
                    else
                    {
                        var strAnotacao = intervencao.KeyPairAnotacaoPrescricaoEnfermagem.FirstOrDefault(t => t.Key == idIndicador);
                        if (strAnotacao.Value != null)
                            textBoxDescricaoIndicadores.Text = strAnotacao.Value.AnotacaoEnfermeiro;

                        pnlButton.Visible = pnlTextBox.Visible = true;
                        pnlButton.BringToFront();
                        btnAddPrescricao.Text = sender != null && strAnotacao.Value is null ?  "Adicionar ítem" : "Atualizar ítem";
                        btnAddPrescricao.IconChar = IconChar.Edit;
                        btnAddPrescricao.Size = new Size(115, 30);
                        btnRemover.Location = new Point(150, 5);
                        btnRemover.Visible = strAnotacao.Value != null;

                    }
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
                if (e.RowIndex < 0 || e.ColumnIndex != 3)
                    return;

                if (Sessao.Paciente.SaeStatus.Status.HasFlag(Sae.Finalizado))
                {
                    string msg = $"Este SAE da data: {DateTime.Now.ToShortDateString()}, já foi realizada a Avaliação pelo enfermeiro(a).\n" +
                        $"Neste caso, não será possivel fazer qualquer checagem ou anotações destes indicadores.\n" +
                        $"A Previsão do próximo SAE para checagens e anotações será na data: {DateTime.Now.AddDays(1).ToShortDateString()}";
                    MessageBox.Show(msg, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

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

                sendGrid.ClearSelection();
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

                    dataGridViewIndicadores.Columns[0].Visible = false;
                    groupBoxIndicadores.Visible = dataTableIdicadores.DefaultView.Count > 0;
                }

            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
        }

        private void dataGridViewIndicadores_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.ColumnIndex != 2)
                    return;

                var sendGrid = (DataGridView)sender;

                if (!(sendGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn))
                {
                    btnAnotacaoTecnica.Visible = Tag != null;
                    textBoxAnotacaoEquipTecnica.Enabled = Tag != null && Sessao.Paciente.SaeStatus.Status == Sae.Andamento;
                    textBoxDescricaoIndicadores.Enabled = (Sae.Edicao | Sae.Nenhum).HasFlag(Sessao.Paciente.SaeStatus.Status);

                    idIndicador = Convert.ToInt32(sendGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                    btnAddPrescricao.Text = "Inserir Observação/Prescrição de Enfermagem";
                    btnAddPrescricao.Size = new Size(270, 30);
                    textBoxDescricaoIndicadores.Text = textBoxAnotacaoEquipTecnica.Text = string.Empty;

                    if (intervencao.KeyPairAnotacaoPrescricaoEnfermagem.Any(n => n.Key == idIndicador && (!string.IsNullOrWhiteSpace(n.Value.AnotacaoEnfermeiro) ||!string.IsNullOrWhiteSpace(n.Value.AnotacaoEquipeTecnica))))
                    {
                        btnRemover.Visible = btnAddPrescricao.Visible = Sessao.Usuario.Perfil.HasFlag(Perfil.Administrador & Perfil.EnfermeiroAdmin & Perfil.Enfermeiro_Assistemcial) && (Sae.Edicao | Sae.Nenhum).HasFlag(Sessao.Paciente.SaeStatus.Status);

                        btnAnotacaoTecnica.Text = "Salvar Anotação";
                        btnAnotacaoTecnica.IconChar = IconChar.Save;
                        btnAddPrescricao_Click(null, null);
                    }
                    else
                    {
                        pnlTextBox.Visible = false;
                        pnlButton.Visible = true;
                        btnAnotacaoTecnica.Text = "Inserir Anotação";
                        btnAnotacaoTecnica.IconChar = IconChar.PlusCircle;
                    }

                    AnotacoesEnfermagem anotacoesEnfermagem = intervencao.KeyPairAnotacaoPrescricaoEnfermagem.FirstOrDefault(n => n.Key == idIndicador).Value;

                    textBoxDescricaoIndicadores.Text = anotacoesEnfermagem is null ? null : anotacoesEnfermagem.AnotacaoEnfermeiro;

                    textBoxAnotacaoEquipTecnica.Text = anotacoesEnfermagem is null ? null : anotacoesEnfermagem.AnotacaoEquipeTecnica;

                    btnRemover.Visible = !string.IsNullOrWhiteSpace(textBoxDescricaoIndicadores.Text) && (Sae.Edicao | Sae.Nenhum).HasFlag(Sessao.Paciente.SaeStatus.Status);
                    btnAddPrescricao.Visible = Tag is null && (Sae.Edicao | Sae.Nenhum).HasFlag(Sessao.Paciente.SaeStatus.Status);
                    btnAnotacaoTecnica.Visible = Tag != null && Sessao.Paciente.SaeStatus.Status == Sae.Andamento;
                    btnRemoverAnotacao.Visible = Tag != null && Sessao.Paciente.SaeStatus.Status == Sae.Andamento && !string.IsNullOrWhiteSpace(textBoxAnotacaoEquipTecnica.Text);
                }

            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
        }

        private void btnStepAvaliaacaoEnfermagem_Click(object sender, EventArgs e)
        {
            try
            {
                UI011FrmTimeLine.ctrl.Controls.RemoveAt(0);

                Form frm = new UI018FrmSaeAvaliacao(new DataTable[] {_dataTable, _dataTableIdicadores }) { TopLevel = false};
                FrmMain.listButtons.ForEach(b => FrmMain.RemoveClickEvent(b));
                FrmMain.RemoveClickEvent(UI011FrmTimeLine.iconButtonAvanca);
                FrmMain.RemoveClickEvent(UI011FrmTimeLine.IconButtonVolta);

                UI011FrmTimeLine.ctrl.Controls.Add(frm);
                frm.Show();
            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
        }

        private void btnRemoverAnotacao_Click(object sender, EventArgs e)
        {
            btnAnotacaoTecnica_Click(null, null);
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

        private void btnAnotacaoTecnica_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(textBoxAnotacaoEquipTecnica.Text))
                {
                    Sessao.Paciente.Sae.IntervencaoEnfermagem.ForEach(n =>
                    {
                        intervencao.KeyPairAnotacaoPrescricaoEnfermagem.RemoveAll(r => r.Key == idIndicador);
                        intervencao.KeyPairAnotacaoPrescricaoEnfermagem.Add(new KeyValuePair<int, AnotacoesEnfermagem>(idIndicador,
                            new AnotacoesEnfermagem
                            {
                                AnotacaoEnfermeiro = string.IsNullOrWhiteSpace(textBoxDescricaoIndicadores.Text) ? null : textBoxDescricaoIndicadores.Text,
                                AnotacaoEquipeTecnica = sender is null ? null : textBoxAnotacaoEquipTecnica.Text 
                            }));

                        n.AnotacaoPrescricaoEnfermagem = (n.KeyPairAnotacaoPrescricaoEnfermagem is null || !n.KeyPairAnotacaoPrescricaoEnfermagem.Any()) ? null : JsonConvert.SerializeObject(n.KeyPairAnotacaoPrescricaoEnfermagem, Formatting.None);
                        n.Indicadores = (n.KeyPairIndicadores is null || !n.KeyPairIndicadores.Any()) ? null : JsonConvert.SerializeObject(n.KeyPairIndicadores, Formatting.None);
                        n.Prontuario = Sessao.Paciente.Prontuario;
                        n.IdSae = Sessao.Paciente.SaeStatus.Id;

                        presenterGeneric.Salvar(n, Procedure.SP_ADD_OR_UPDT_INTERVENCAO_PRESCRICAO_ENFERMAGEM_SAE, n.Id == 0 ? Acao.Inserir : Acao.Atualizar);
                    });

                    pnlTextBox.Visible = btnAnotacaoTecnica.Visible = btnRemoverAnotacao.Visible = false;
                    pnlButton.Visible = true;
                    btnAnotacaoTecnica.Text = "Inserir Anotação";
                    btnAnotacaoTecnica.IconChar = IconChar.PlusCircle;
                }
                else
                {
                    pnlTextBox.Visible = pnlButton.Visible = btnAnotacaoTecnica.Visible = true;
                    pnlButton.BringToFront();
                    btnAnotacaoTecnica.Text = "Salvar Anotação";
                    btnAnotacaoTecnica.IconChar = IconChar.Save;
                }

            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }

        }
    
    }
}
