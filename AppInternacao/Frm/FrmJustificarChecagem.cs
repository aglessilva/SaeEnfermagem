using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppInternacao.Frm
{
    public partial class FrmJustificarChecagem : Form
    {
        DataRow dataRow = null;
        public FrmJustificarChecagem(DataRow _dataRow)
        {
            InitializeComponent();
            dataRow = _dataRow;
            textBoxJustificativa.Focus();
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

                DialogResult = DialogResult.OK;
                Dispose();
            }
            catch (Exception)
            {

                throw;
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
    }
}
