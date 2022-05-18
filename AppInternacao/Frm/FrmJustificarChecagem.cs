using AppInternacao.Enum;
using AppInternacao.Model;
using AppInternacao.Presenter;
using System;
using System.Windows.Forms;

namespace AppInternacao.Frm
{
    public partial class FrmJustificarChecagem : Form
    {
        ChavePrescricao chavePrescricao = null;
        CicloPrescricao cicloPrescricao = null;
        PresenterGeneric presenterGeneric = null;
        private readonly int tipo = 0;
        private readonly int itemPrescricao = 0;

        public FrmJustificarChecagem(ChavePrescricao chave, int _itemPrescricao = 0, int _tipo = 0, CicloPrescricao _cicloPrescricao = null)
        {
            InitializeComponent();
            chavePrescricao = chave;
            tipo = _tipo;
            itemPrescricao = _itemPrescricao;
            cicloPrescricao = _cicloPrescricao;
            textBoxJustificativa.Focus();
          
        }

        private void textBoxJustificativa_TextChanged(object sender, EventArgs e)
        {
            lblCaracteres.Visible = textBoxJustificativa.Text.Length > 0;
            if (textBoxJustificativa.Text.Length <= 50)
            {
                lblCaracteres.Text = $"Mínimo de 50 caracteres: {50 - textBoxJustificativa.Text.Length}";
                btnConfirmar.Enabled = textBoxJustificativa.Text.Length >= 50;
            }

            if (textBoxJustificativa.Text.Length >= 51)
                lblCaracteres.Text = $"Máximo de 500 caracteres: {500 - textBoxJustificativa.Text.Length}";

            btnConfirmar.Enabled = textBoxJustificativa.Text.Length >= 50 && textBoxJustificativa.ReadOnly == false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string texto = textBoxJustificativa.Text;
            try
            {
                presenterGeneric = new PresenterGeneric();
                var obj = new JustificativaAnotacao()
                {
                    IdPrescricao = chavePrescricao.Id,
                    IdPaciente = Sessao.Paciente.Id,
                    TipoMsg = tipo,
                    ItemData = chavePrescricao.StatusPrescricao == 3 ? $"{itemPrescricao}#{textBoxData.Text}" : null
                };

                // Anotação do tecnico de enfermagem (falta de medicamento, material de trabalho etc etc etc)
                if (tipo == 0)
                    obj.AnotacaoItemPrescricao = textBoxJustificativa.Text;

                // justificativa para de prescricao medica, devoução entre medico e enfermeiro
                if (tipo == 1)
                    obj.ObervacaoDevolucao = textBoxJustificativa.Text;

                // justificativa para informar a não checagem dos itens de prescrição
                if (tipo == 2)
                    obj.Justificativa = textBoxJustificativa.Text;

                presenterGeneric.Salvar(obj, Procedure.SP_ADD_JUSTIFICATIVA);
                DialogResult = DialogResult.OK;
                Dispose(true);

            }
            catch (Exception exErroJus)
            {
                throw exErroJus;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Dispose(true);
        }

        private void FrmJustificarChecagem_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridViewJustificativa.AutoGenerateColumns = false;

                if (tipo == 0)
                {
                    dataGridViewJustificativa.Columns["AnotacaoItemPrescricao"].Visible = true;
                    panelItemData.Visible = true;
                    textBoxItem.Text = itemPrescricao.ToString();
                    textBoxData.Text = "Note";
                    lblData.Visible = false;
                }
                if (tipo == 1)
                    dataGridViewJustificativa.Columns["ObervacaoDevolucao"].Visible = true;

                if (tipo == 2)
                {
                    dataGridViewJustificativa.Columns["Justificativa"].Visible = true;
                    panelItemData.Visible = true;
                    textBoxItem.Text = itemPrescricao.ToString();
                    textBoxData.Text = DateTime.Now.Date.ToString("dd/MM");
                }

                textBoxJustificativa.MaxLength = 500;
                lblCaracteres.Visible = false;
                presenterGeneric = new PresenterGeneric();
                dataGridViewJustificativa.DataSource = presenterGeneric.GetLista(new JustificativaAnotacao() { IdPrescricao = chavePrescricao.Id, TipoMsg = tipo }, Procedure.SP_GET_JUSTIFICATIVA);

                if (cicloPrescricao != null)
                {
                    btnConfirmar.Enabled = DateTime.Now.Date < cicloPrescricao.DataCiclo;
                    btnLimpar.Enabled = DateTime.Now.Date < cicloPrescricao.DataCiclo;
                }


            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception:ex);
            }

        }

        private void dataGridViewJustificativa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxJustificativa.ReadOnly = true;
            textBoxJustificativa.Clear();
            JustificativaAnotacao objeto = (JustificativaAnotacao)dataGridViewJustificativa.Rows[e.RowIndex].DataBoundItem;
            if (tipo == 0)
            {
                textBoxJustificativa.Text = objeto.AnotacaoItemPrescricao;
                if(!objeto.ItemData.Split('#')[1].Contains("Note"))
                {
                    textBoxItem.Text = objeto.ItemData.Split('#')[0].Trim();
                    textBoxData.Text = objeto.ItemData.Split('#')[1].Trim();
                    lblData.Visible = true;
                }
                else
                {
                    textBoxItem.Text = itemPrescricao.ToString();
                    textBoxData.Text = "Note";
                    lblData.Visible = false;
                }
            }
            if (tipo == 1)
                textBoxJustificativa.Text = objeto.ObervacaoDevolucao;
            if (tipo == 2)
            {
                textBoxJustificativa.Text = objeto.Justificativa;
                textBoxItem.Text = objeto.ItemData.Split('#')[0].Trim();
                textBoxData.Text = objeto.ItemData.Split('#')[1].Trim();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBoxJustificativa.Text = string.Empty;
            textBoxJustificativa.ReadOnly = false;
            textBoxJustificativa.Focus();
        }
    }
}
