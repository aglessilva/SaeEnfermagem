using AppInternacao.Model;
using AppInternacao.Presenter;
using AppInternacao.View;
using FontAwesome.Sharp;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AppInternacao.FrmSae
{
    public partial class UI012FrmSaeHistoricoEnfermagem: UI000FrmTemplate, IHistoricoEnfermagem
    {

        HistoricoEnfermagemPresenter presenterHitoricoEnfermagem;
        public HistoricoEnfermagem HistoricoEnfermagem
        {
            get => new HistoricoEnfermagem
            {
                IdPaciente = Sessao.Paciente.Id,
                Proveniente = Convert.ToInt32(pnlProveniente.Controls.OfType<RadioButton>().ToList().FirstOrDefault(r => r.Checked).Tag.ToString()),
                SituacaoEntrada = Convert.ToInt32(pnlSituacaoEntrada.Controls.OfType<RadioButton>().ToList().FirstOrDefault(r => r.Checked).Tag.ToString()),
                DoencaCorrelacionada = Convert.ToInt32(gpDoencaCorelacionada.Controls.OfType<RadioButton>().ToList().FirstOrDefault(r => r.Checked).Tag.ToString()),
                ProvenienteDescricao = textBoxEspecifiqueInstituicao.Text,
                MotivoInternacao = textBoxMotivoInternacao.Text,
                DoencaCorrelacionadaDescricao = textBoxDoencaCorelacionada.Text,
                DiagnosticoMedico = textBoxDiagnostricoMedico.Text,
                AvaliacaoSaude = textBoxAvaliacaoSaude.Text,
                UsoMedicamento = textBoxUsoMedicamento.Text
            };
            set
            {
                textBoxPaciente.Text = Sessao.Paciente.Nome;
                textBoxIdade.Text = Sessao.Paciente.Idade.ToString();
                textBoxDataInternacao.Text = Sessao.Paciente.Data.Value.ToShortDateString();
                if (Sessao.Paciente.Sexo.Equals("M"))
                    rdoFerminino.Checked = true;
                else
                    rdoMasculino.Checked = true;
            }
        }
       
        public UI012FrmSaeHistoricoEnfermagem()
        {
            InitializeComponent();
            txtTitulo.Text = $"HISTÓRICO DE ENFERMAGEM – ADMISSÃO DE CRITÉRIOS E AVALIAÇÃO DE PADRÕES FUNCIONAIS DE SAÚDE";
        }

        private void btnButtonStep_Click(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;
            if(btn.Tag.Equals("1"))
            {
                Avancar();
            }
        }

        private void Avancar()
        {
            try
            {
                if(ValidarCampo())
                {
                    Sessao.Paciente.Sae.HistoricoEnfermagem = this.HistoricoEnfermagem;
                    UI011FrmTimeLine.iconButtonAvanca.Click -= btnButtonStep_Click;
                    UI011FrmTimeLine.IconButtonVolta.Click -= btnButtonStep_Click;
                    UI011FrmTimeLine.ctrl.Controls.RemoveAt(0);
                    Form frm = new UI010FrmNanda(true) { TopLevel = false };
                    UI011FrmTimeLine.ctrl.Controls.Add(frm);
                    UI011FrmTimeLine.lblRotuloSae.Text = "Diagnóstico de Enfermagem";
                    frm.Show();
                }
            }
            catch (Exception Ex)
            {
                FrmMain.Alert(exception: Ex);
            }
        }

        private bool ValidarCampo()
        {
            bool[] ret = { true, true, true, true};

            var item = pnlProveniente.Controls.OfType<RadioButton>().Count(r => r.Checked);

            if(item == 0)
            {
                errorProvider1.SetError(pnlProveniente, "preencha este campo");
                errorProvider1.SetIconPadding(pnlProveniente, 3);
                ret[0] = false;
            }
            else
                errorProvider1.SetError(pnlProveniente, null);

            item = pnlSituacaoEntrada.Controls.OfType<RadioButton>().Count(r => r.Checked);

            if (item == 0)
            {
                errorProvider1.SetError(pnlSituacaoEntrada, "preencha este campo");
                errorProvider1.SetIconPadding(pnlSituacaoEntrada, 3);
                ret[1] = false;
            }
            else
                errorProvider1.SetError(pnlSituacaoEntrada, null);

            item = gpDoencaCorelacionada.Controls.OfType<RadioButton>().Count(r => r.Checked);

            if (item == 0)
            {
                errorProvider1.SetError(gpDoencaCorelacionada, "preencha este campo");
                errorProvider1.SetIconPadding(gpDoencaCorelacionada, 3);
                ret[2] = false;
            }
            else
                errorProvider1.SetError(gpDoencaCorelacionada, null);

            if(textBoxAvaliacaoSaude.Text.Length < 50)
            {
                errorProvider1.SetError(gpAvaliacaoSaude, "preencha este campo");
                errorProvider1.SetIconPadding(gpAvaliacaoSaude, 3);
                ret[3] = false;
            }
            else
                errorProvider1.SetError(gpAvaliacaoSaude, null);

            if ((radioButton19.Checked || radioButton18.Checked) && textBoxDoencaCorelacionada.Text.Length < 10)
            {
                errorProvider1.SetError(radioButton19, "preencha este campo");
                errorProvider1.SetIconPadding(radioButton19, 3);
                ret[0] = false;
            }
            else
                errorProvider1.SetError(radioButton19, null);


            if (radioButton5.Checked && textBoxEspecifiqueInstituicao.Text.Length < 10)
            {
                errorProvider1.SetError(label7, "preencha este campo");
                errorProvider1.SetIconPadding(label7, 3);
                ret[3] = false;
            }
            else
                errorProvider1.SetError(label7, null);

            if (textBoxMotivoInternacao.Text.Length < 50)
            {
                errorProvider1.SetError(label6, "preencha este campo");
                errorProvider1.SetIconPadding(label6, 3);
                ret[3] = false;
            }
            else
                errorProvider1.SetError(label6, null);

            return ret.ToList().TrueForAll(t => t == true);
        }

        private void UI012FrmSaeHistoricoEnfermagem_Load(object sender, EventArgs e)
        {
            UI011FrmTimeLine.iconButtonAvanca.Click += btnButtonStep_Click;
            UI011FrmTimeLine.IconButtonVolta.Click += btnButtonStep_Click;
            
            presenterHitoricoEnfermagem = new HistoricoEnfermagemPresenter(this);
            HistoricoEnfermagem = new HistoricoEnfermagem();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            pnlEspecifique.Enabled = radioButton5.Checked;
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            pnlEspecifiqueOutrasDoencas.Enabled = (radioButton19.Checked || radioButton18.Checked);
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            radioButton19_CheckedChanged(sender, e);
        }
    }
}
