using AppInternacao.Enum;
using AppInternacao.Model;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppInternacao.FrmSae
{
    public partial class UI013FrmSaeViewDiagnostico : UI000FrmTemplate
    {
        public UI013FrmSaeViewDiagnostico()
        {
            InitializeComponent();
        }

        NandaDiagnostico nandaDiagnostico = null;

        private void UI013FrmViewDiagnostico_Load(object sender, EventArgs e)
        {
            PopulaComboDiagnostico();
        }

        void PopulaComboDiagnostico()
        {
            List<NandaDiagnostico> nandaDiagnosticos = new List<NandaDiagnostico>();

            Sessao.Paciente.Sae.DiagnosticoEnfermagem.ForEach(f => nandaDiagnosticos.Add(f.Diagnostico));

            nandaDiagnosticos.Insert(0, new NandaDiagnostico { Codigo = "0", Diagnostico = "Selecione um item para vizualizar" });
            comboBoxDiagnosticoEnfermagem.ValueMember = "Codigo";
            comboBoxDiagnosticoEnfermagem.DisplayMember = "Diagnostico";
            comboBoxDiagnosticoEnfermagem.DataSource = nandaDiagnosticos;

        }

        private void dataGridViewPopulacaoRisco_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
          =>  dataGridViewPopulacaoRisco.ClearSelection();

        private void dataGridViewCaracteristicasDefinidoras_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
            => dataGridViewCaracteristicasDefinidoras.ClearSelection();

        private void dataGridViewCondicoesAssociada_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
            => dataGridViewCondicoesAssociada.ClearSelection();

        private void dataGridViewFatoresRelacionados_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) 
            => dataGridViewFatoresRelacionados.ClearSelection();

        private void dataGridViewFatoresRiscos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
            => dataGridViewFatoresRiscos.ClearSelection();

        private void comboBoxDiagnosticoEnfermagem_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                nandaDiagnostico = (NandaDiagnostico)comboBoxDiagnosticoEnfermagem.SelectedItem;

                if(nandaDiagnostico.Codigo == "0")
                {
                    ResetForm();
                    return;
                }

                btnRemover.Enabled = Sessao.Paciente.SaeStatus.Status == Sae.Edicao;

                lblDominio.Text = $"Domínio: {Sessao.Paciente.Sae.DiagnosticoEnfermagem.FirstOrDefault(d => d.Diagnostico.IdDominio == nandaDiagnostico.IdDominio).NomeDominio}";
                lblClasse.Text = $"Classe: {Sessao.Paciente.Sae.DiagnosticoEnfermagem.FirstOrDefault(d => d.Diagnostico.IdDominio == nandaDiagnostico.IdDominio).NomeClasse}";
                textBoxDefinicao.Text = $"Definição: {nandaDiagnostico.Definicao}";

                dataGridViewFatoresRelacionados.DataSource = Sessao.Paciente.Sae.DiagnosticoEnfermagem.FirstOrDefault(f => f.Diagnostico.Codigo.Equals(nandaDiagnostico.Codigo)).FatorRelacionados.ToList();
                dataGridViewCaracteristicasDefinidoras.DataSource = Sessao.Paciente.Sae.DiagnosticoEnfermagem.FirstOrDefault(f => f.Diagnostico.Codigo.Equals(nandaDiagnostico.Codigo)).CaracteristicaDefinidoras.ToList();
                dataGridViewCondicoesAssociada.DataSource = Sessao.Paciente.Sae.DiagnosticoEnfermagem.FirstOrDefault(f => f.Diagnostico.Codigo.Equals(nandaDiagnostico.Codigo)).CondicaoAssociadas.ToList();
                dataGridViewFatoresRiscos.DataSource = Sessao.Paciente.Sae.DiagnosticoEnfermagem.FirstOrDefault(f => f.Diagnostico.Codigo.Equals(nandaDiagnostico.Codigo)).FatorRiscos.ToList();
                dataGridViewPopulacaoRisco.DataSource = Sessao.Paciente.Sae.DiagnosticoEnfermagem.FirstOrDefault(f => f.Diagnostico.Codigo.Equals(nandaDiagnostico.Codigo)).PopulacaoRiscos.ToList();

                panelCondAssociada.Visible = dataGridViewCondicoesAssociada.Rows.Count > 0;
                panelFatorRel.Visible = dataGridViewFatoresRelacionados.Rows.Count > 0;
                panelCaracDefin.Visible = dataGridViewCaracteristicasDefinidoras.Rows.Count > 0;
                panelFatorRisco.Visible = dataGridViewFatoresRiscos.Rows.Count > 0;
                panelPopulacaoRis.Visible = dataGridViewPopulacaoRisco.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }

        }

        private void ResetForm()
        {
            btnRemover.Enabled = false;
            lblDominio.Text = "Domínio:";
            lblClasse.Text = "Classe:";
            textBoxDefinicao.Text = "Definição:";

            panelCondAssociada.Visible = panelFatorRel.Visible = panelCaracDefin.Visible = panelFatorRisco.Visible = panelPopulacaoRis.Visible = false;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Sessao.Paciente.Sae.DiagnosticoEnfermagem.RemoveAll(f => f.Diagnostico.Codigo.Equals(nandaDiagnostico.Codigo));
            Sessao.Paciente.Sae?.IntervencaoEnfermagem.RemoveAll(f => f.CodigoDiagnostico.Equals(nandaDiagnostico.Codigo));
            ResetForm();
            PopulaComboDiagnostico();

            if (Sessao.Paciente.Sae.DiagnosticoEnfermagem.Count == 0)
                BtnVoltar_Click(sender, e);
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Dispose(true);
            Close();

            FrmMain.listButtons.Find(b => b.Name.Equals("btnAddGeneric")).Visible = Sessao.Paciente.SaeStatus.Status == Sae.Edicao; 

            UI011FrmTimeLine.IconButtonVolta.Enabled = true;
            UI011FrmTimeLine.iconButtonAvanca.Enabled = Sessao.Paciente.Sae.DiagnosticoEnfermagem.Any();
            
            Form f = (UI010FrmNanda)UI011FrmTimeLine.ctrl.Controls[0];

            IconButton btnVisualizar = f.Controls.OfType<IconButton>().FirstOrDefault();

            if (Sessao.Paciente.Sae.DiagnosticoEnfermagem.Count == 0)
            {
                btnVisualizar.Visible = false;
                btnVisualizar.Text = "Visualizar Itens"; 
            }
            else
                btnVisualizar.Text = $"Visualizar Itens {Sessao.Paciente.Sae.DiagnosticoEnfermagem.Count }";
        }
    }
}
