using AppInternacao.Enum;
using AppInternacao.Model;
using AppInternacao.Presenter;
using AppInternacao.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static AppInternacao.Model.IntervencaoEnfermagem;

namespace AppInternacao.FrmSae
{
    public partial class UI007FrmMenuDireito : UI000FrmTemplate
    {
        public UI007FrmMenuDireito()
        {
            InitializeComponent();
        }
        private Form uc = null;
        Button currentBtn = null;
        PresenterGeneric presenterGeneric = null;

        private SplitContainer ctrl;
        private void btnExibirHistorico_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            if (Sessao.Usuario.Perfil.HasFlag(Perfil.Medico))
            {
              //  ctrl.Panel1.Controls.Add(new UCViewHistoricoEnfermagem());
            }
            else
            {
                //new FrmExibirHistorico().ShowDialog();
            }
        }

        private void btnPrecricaoMedica_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            uc = new UI008FrmPrescricaoCiclo() { TopLevel = false };
            OpenUC();
        }

        private void btnPrescricaoIntervencaoEnfermagem_Click(object sender, EventArgs e)
        {
            FrmMain.listButtons.ForEach(b => b.Visible = false);
            if (Sessao.Paciente.SaeStatus.Status == Sae.Nenhum)
            {
                string msg = "Ainda não há Planejamento de intervenção/prescrição de enfermagem para este paciente, favor comunicar ao enfermeiro. ";

                MessageBox.Show(msg, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Sessao.Paciente.SaeStatus.Status == Sae.Edicao)
            {
                string msg = "A intervenção/prescrição de enfermagem está em preparação pelo enfermeiro(a), e deverá ser liberado em breve\n" +
                    "para a equipe tecnica de enfermagem.";

                MessageBox.Show(msg, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {

                presenterGeneric = new PresenterGeneric();
                List<IntervencaoEnfermagem> intervencaos = new List<IntervencaoEnfermagem>();

                DataTable dataTable, dataTableIdicadores;

                List<NicClassificacao> listClasifficacao = presenterGeneric.GetLista(new NicClassificacao(), Procedure.SP_GET_NIC_CLASSIFICACAO);
                List<NicIndicador> listIndicadores = presenterGeneric.GetLista(new NicIndicador(), Procedure.SP_GET_NIC_INDICADORES);

                List<DiagnosticoEnfermagemDTO> diagnosticoEnfermagemDTOs = presenterGeneric.GetLista(new DiagnosticoEnfermagemDTO { IdSae = Sessao.Paciente.SaeStatus.Id, Prontuario = Sessao.Paciente.Prontuario }, Procedure.SP_GET_DIAGNOSTICO_ENFERMAGEM_SAE);

                intervencaos = presenterGeneric.GetLista(new IntervencaoEnfermagem { IdSae = Sessao.Paciente.SaeStatus.Id }, Procedure.SP_GET_INTERVENCAO_PRESCRICAO_ENFERMAGEM_SAE);

                dataTable = new DataTable();
                dataTable.Columns.Add("Codigo", typeof(int));
                dataTable.Columns.Add("Checked", typeof(bool));
                dataTable.Columns.Add("Classificacao", typeof(string));

                dataTableIdicadores = new DataTable();
                dataTableIdicadores.Columns.Add("Id", typeof(int));
                dataTableIdicadores.Columns.Add("Codigo", typeof(int));
                dataTableIdicadores.Columns.Add("Checked", typeof(bool));
                dataTableIdicadores.Columns.Add("Indicador", typeof(string));

                DataRow dataRow = null;

                listClasifficacao.ForEach(c => {
                    dataRow = dataTable.NewRow();
                    dataRow[0] = c.Codigo;
                    dataRow[1] = false;
                    dataRow[2] = c.Classificacao;
                    dataTable.Rows.Add(dataRow);
                });

                listClasifficacao.Clear();

                List<KeyValuePair<int, IndicadorItem>> pairsIndicadore = new List<KeyValuePair<int, IndicadorItem>>();
                
                intervencaos.ForEach(f => {
                    pairsIndicadore.AddRange(JsonConvert.DeserializeObject<List<KeyValuePair<int, IndicadorItem>>>(string.Join(",", f.Indicadores)));
                    f.KeyPairIndicadores = JsonConvert.DeserializeObject<List<KeyValuePair<int, IndicadorItem>>>(f.Indicadores);
                    f.KeyPairAnotacaoPrescricaoEnfermagem = !string.IsNullOrWhiteSpace(f.AnotacaoPrescricaoEnfermagem) ? JsonConvert.DeserializeObject<List<KeyValuePair<int, AnotacoesEnfermagem>>>(f.AnotacaoPrescricaoEnfermagem) : new List<KeyValuePair<int, AnotacoesEnfermagem>>();
                });

                KeyValuePair<int, IndicadorItem> indicadorItem = new KeyValuePair<int, IndicadorItem>();
                listIndicadores.ForEach(c =>
                {
                    if (pairsIndicadore.Any(s => s.Value.Id.Equals(c.Id)))
                        indicadorItem = pairsIndicadore.SingleOrDefault(s => s.Value.Id.Equals(c.Id));

                    dataRow = dataTableIdicadores.NewRow();
                    dataRow[0] = c.Id;
                    dataRow[1] = c.Codigo;
                    dataRow[2] = indicadorItem.Value is null ? false : indicadorItem.Value.Ckecked;
                    dataRow[3] = $"{c.Codigo} - {c.Indicador}";
                    dataTableIdicadores.Rows.Add(dataRow);
                });

                listIndicadores.Clear();

                string filter = string.Join(",", intervencaos.Select(s => s.Classificacao));

                DiagnosticoEnfermagem diagnostico = null;
                Sessao.Paciente.Sae.DiagnosticoEnfermagem.Clear();

                diagnosticoEnfermagemDTOs.ForEach(f => {

                    diagnostico = new DiagnosticoEnfermagem();
                    diagnostico.Id = f.Id;
                    diagnostico.Diagnostico = JsonConvert.DeserializeObject<NandaDiagnostico>(f.Diagnostico);
                    diagnostico.FatorRelacionados = string.IsNullOrWhiteSpace(f.FatorRelacionados) ? new List<NandaFatorRelacionado>()  : JsonConvert.DeserializeObject<List<NandaFatorRelacionado>>(f.FatorRelacionados);
                    diagnostico.CondicaoAssociadas = string.IsNullOrWhiteSpace(f.CondicaoAssociadas) ? new List<NandaCondicaoAssociada>() : JsonConvert.DeserializeObject<List<NandaCondicaoAssociada>>(f.CondicaoAssociadas);
                    diagnostico.CaracteristicaDefinidoras = string.IsNullOrWhiteSpace(f.CaracteristicaDefinidoras) ? new List<NandaCaracteristicaDefinidora>() : JsonConvert.DeserializeObject<List<NandaCaracteristicaDefinidora>>(f.CaracteristicaDefinidoras);
                    diagnostico.FatorRiscos = string.IsNullOrWhiteSpace(f.FatorRiscos) ? new List<NandaFatorRisco>() : JsonConvert.DeserializeObject<List<NandaFatorRisco>>(f.FatorRiscos);
                    diagnostico.PopulacaoRiscos = string.IsNullOrWhiteSpace(f.PopulacaoRiscos) ? new List<NandaPopulacaoRisco>() : JsonConvert.DeserializeObject<List<NandaPopulacaoRisco>>(f.PopulacaoRiscos);

                    Sessao.Paciente.Sae.DiagnosticoEnfermagem.Add(diagnostico);
                });

                Sessao.Paciente.Sae.IntervencaoEnfermagem = intervencaos;

                dataTable.DefaultView.RowFilter = $"Codigo in({filter})";
                filter = string.Join(",", pairsIndicadore.Select(i => i.Value.Id));

                DataTable[] tables =  { dataTable.DefaultView.ToTable(), dataTableIdicadores.Select($"Id in({filter})").CopyToDataTable() };

                ActivateButton(sender);
                uc = new UI017FrmSaeImplementacao(tables) { TopLevel = false, Tag = new { IsSae = false } };
                OpenUC();
            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
        }

        private void OpenUC()
        {
            try
            {
                FrmMain.listButtons.ForEach(b => FrmMain.RemoveClickEvent(b));
                foreach (Control item in ctrl.Panel1.Controls)
                {
                    if (item is Form)
                    {
                        if (!item.Name.Equals("UI000FrmTemplate"))// template não pode ser removido pois esse form é herdado
                        {
                            var frm = (Form)item;
                            frm.Close();
                            frm.Dispose();
                        }
                    }
                }
                ctrl.Panel1.Controls.Clear();
                ctrl.Panel1.Controls.Add(uc);
                ctrl.Panel1.Tag = uc;
                uc.Show();

            }
            catch (Exception exOpenUc)
            {
                FrmMain.Alert(exception: exOpenUc);
            }
        }

        private void UI007FrmMenuDireito_Load(object sender, EventArgs e)
        {
            ctrl = (SplitContainer)ParentForm.Controls[0].Controls[0];
            lblQuarto.Text = Sessao.Paciente.NomeQuarto;
            lblLeito.Text = Sessao.Paciente.NomeLeito;
            lblUnidadeFuncional.Text = Sessao.Paciente.NomeSetor;
            lblPaciente.Text = Sessao.Paciente.Nome;
            lblIdade.Text = Sessao.Paciente.Idade.ToString();

            btnPrescricaoIntervencaoEnfermagem.Visible = (Perfil.Administrador | Perfil.EnfermeiroAdmin | Perfil.Enfermeiro_Assistemcial | Perfil.Tecnico).HasFlag(Sessao.Usuario.Perfil);

            MemoryStream ms = new MemoryStream(Sessao.Paciente.Foto);
            pictureBoxExtFoto.Image = Image.FromStream(ms);

            string msg = Sessao.Paciente.SaeStatus.Status == Sae.Nenhum 
                ? "Intervenção/Prescrição de enfermagem ainda não foi planejado, favor comunicar ao enfermeiro(a)."
                : Sessao.Paciente.SaeStatus.Status == Sae.Edicao 
                ? "Intervenção/Prescrição de enfermagem está em preparação."
                : Sessao.Paciente.SaeStatus.Status == Sae.Andamento 
                ? "Intervenção/Prescrição de enfermagem liberado para o paciente." : "Finalizado!";

            new ToolTip { IsBalloon = true, ToolTipTitle = "Informação", UseAnimation = true, ToolTipIcon = ToolTipIcon.Info }.SetToolTip(btnPrescricaoIntervencaoEnfermagem, msg);

            btnPrescricaoIntervencaoEnfermagem.Image = Sessao.Paciente.SaeStatus.Status == Sae.Nenhum
                ? Resources.sinalizadorV1
                : Sessao.Paciente.SaeStatus.Status == Sae.Edicao
                ? Resources.sinalizadorManutencao
                : Sessao.Paciente.SaeStatus.Status == Sae.Andamento
                ? Resources.sinalizadorVer
                : Resources.sinalizador;
        }


        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                //Button
                DisableButton();
                currentBtn = (Button)senderBtn;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.BackColor = Color.FromArgb(13, 87, 134);
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                currentBtn.TextAlign = ContentAlignment.MiddleRight;
                currentBtn.BackColor = Color.FromArgb(6, 39, 69);
            }
        }

    }
}
