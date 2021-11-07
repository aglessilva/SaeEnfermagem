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
    public partial class UI013FrmViewDiagnostico : UI000FrmTemplate
    {
        public UI013FrmViewDiagnostico()
        {
            InitializeComponent();
        }

        private void BtnVizualizarDiagnostico_Click(object sender, EventArgs e)
        {
            Dispose(true);
            Close();
            UI011FrmTimeLine.iconButtonAvanca.Enabled = UI011FrmTimeLine.IconButtonVolta.Enabled = true;
        }

        private void UI013FrmViewDiagnostico_Load(object sender, EventArgs e)
        {
            lblDominio.Text = $"Domínio: {Sessao.Paciente.Sae.DiagnosticoEnfermagem.NomeDominio}";
            lblClasse.Text = $"Classe: {Sessao.Paciente.Sae.DiagnosticoEnfermagem.NomeClasse}";
            textBoxDefinicao.Text = $"Definição: {Sessao.Paciente.Sae.DiagnosticoEnfermagem.Diagnostico.Definicao}";

            lblTituloDiagnostico.Text = $"Diagnóstico: {Sessao.Paciente.Sae.DiagnosticoEnfermagem.Diagnostico.Diagnostico}";
            dataGridViewFatoresRelacionados.DataSource = Sessao.Paciente.Sae.DiagnosticoEnfermagem.FatorRelacionados.ToList();
            dataGridViewCaracteristicasDefinidoras.DataSource = Sessao.Paciente.Sae.DiagnosticoEnfermagem.CaracteristicaDefinidoras.ToList();
            dataGridViewCondicoesAssociada.DataSource = Sessao.Paciente.Sae.DiagnosticoEnfermagem.CondicaoAssociadas.ToList();
            dataGridViewFatoresRiscos.DataSource = Sessao.Paciente.Sae.DiagnosticoEnfermagem.FatorRiscos.ToList();
            dataGridViewPopulacaoRisco.DataSource = Sessao.Paciente.Sae.DiagnosticoEnfermagem.PopulacaoRiscos.ToList();

            panelFatorRel.Visible = dataGridViewFatoresRelacionados.Rows.Count > 0;
            panelCaracDefin.Visible = dataGridViewCaracteristicasDefinidoras.Rows.Count > 0;
            panelCondiAssoc.Visible = dataGridViewCondicoesAssociada.Rows.Count > 0;
            panelFatorRisco.Visible = dataGridViewFatoresRiscos.Rows.Count > 0;
            panelPopulacaoRis.Visible = dataGridViewPopulacaoRisco.Rows.Count > 0;
        }
    }
}
