using System;
using System.Data;
using System.Windows.Forms;

namespace AppInternacao.Frm
{
    public partial class FrmJustificarChecagem : Form
    {
        DataRow dataRow = null;
        bool viewEnable = true;
        public FrmJustificarChecagem(DataRow _dataRow = null, bool eneble = true)
        {
            InitializeComponent();
            dataRow = _dataRow;
            textBoxJustificativa.Focus();
            viewEnable = eneble;
        }

        private void textBoxJustificativa_TextChanged(object sender, EventArgs e)
        {
            if (textBoxJustificativa.Text.Length <= 50)
            {
                lblCaracteres.Text = $"Mínimo de 50 caracteres: {50 - textBoxJustificativa.Text.Length}";
                btnConfirmar.Enabled = textBoxJustificativa.Text.Length >= 50;
            }

            if (textBoxJustificativa.Text.Length >= 60)
                lblCaracteres.Text = $"Máximo de 200 caracteres: {200 - textBoxJustificativa.Text.Length}";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                dataRow["Justificativa"] += DateTime.Now.Date.ToString("dd/MM/yyyy") + " - " + textBoxJustificativa.Text +Environment.NewLine;
                DialogResult = DialogResult.OK;
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
            if (!viewEnable)
            {
                string[] txtJustificativas = dataRow["Justificativa"].ToString().Split('\r');

                textBoxJustificativa.MaxLength = 1000;
                btnConfirmar.Click -= btnConfirmar_Click;
                lblCaracteres.Visible = false;

                foreach (var item in txtJustificativas)
                {
                    if (!string.IsNullOrWhiteSpace(item.ToString()))
                        textBoxJustificativa.Text += item.ToString() + Environment.NewLine;
                }
                //textBoxJustificativa.Text = dataRow["Justificativa"].ToString();
            }
        }
    }
}
