using AppInternacao.Enum;
using AppInternacao.Model;
using AppInternacao.Presenter;
using System;
using System.Data;
using System.Windows.Forms;

namespace AppInternacao.Frm
{
    public partial class FrmJustificarChecagem : Form
    {
        DataRow dataRow = null;
        bool viewEnable = true;
        ChavePrescricao chavePrescricao = null;
        PresenterGeneric presenterGeneric = null;

        public FrmJustificarChecagem(DataRow _dataRow = null, bool eneble = true)
        {
            InitializeComponent();
            dataRow = _dataRow;
            textBoxJustificativa.Focus();
            viewEnable = eneble;
        }

        public FrmJustificarChecagem(ChavePrescricao chave)
        {
            InitializeComponent();
            chavePrescricao = chave;
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

            if (textBoxJustificativa.Text.Length >= 60)
                lblCaracteres.Text = $"Máximo de 500 caracteres: {500 - textBoxJustificativa.Text.Length}";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                string strTexto = $"Checado por:{Sessao.Usuario.Nome}{Environment.NewLine}" +
                   $"Data:{ DateTime.Now.Date:dd/MM/yyyy}{Environment.NewLine}{textBoxJustificativa.Text} |";

                if (chavePrescricao == null)
                {
                    dataRow["Justificativa"] += strTexto;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    presenterGeneric = new PresenterGeneric();
                    presenterGeneric.Salvar(new ChavePrescricao() 
                    { 
                        Id = chavePrescricao.Id,
                        NomePrescricao = chavePrescricao.NomePrescricao,
                        IdPaciente = Sessao.Paciente.Id, 
                        ObservacaoDevolucao = strTexto,
                        IsValidado =  false
                    }, Procedure.SP_ADD_CHAVE_PRESCRICAO);
                    DialogResult = DialogResult.OK;
                }
                Dispose();
            }
            catch (Exception exErroJus)
            {
                throw exErroJus;
            }
        }

        private void FrmJustificarChecagem_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.Cancel)
                e.Cancel = true;
            else
                e.Cancel = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Dispose();
        }

        private void FrmJustificarChecagem_Load(object sender, EventArgs e)
        {
            string texto = string.Empty;
            if (chavePrescricao == null)
            {
                if (!viewEnable)
                {
                    string[] txtJustificativas = dataRow["Justificativa"].ToString().Split('|');
                    textBoxJustificativa.MaxLength = 1000;
                    lblCaracteres.Visible = false;

                    foreach (var item in txtJustificativas)
                    {
                        texto +=  item.ToString() + Environment.NewLine + Environment.NewLine ;
                    }

                    textBoxJustificativa.Text = texto;
                }
            }
            else
            {
                lblTitle.Text = "Justificar Devolução de Prescrição.";
                textBoxJustificativa.MaxLength = 500;
                lblCaracteres.Visible = false;
            }
        }
    }
}
