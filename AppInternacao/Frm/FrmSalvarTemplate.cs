﻿using System;
using System.Windows.Forms;

namespace AppInternacao.Frm
{
    public partial class FrmSalvarTemplate : FrmSae.UI000FrmTemplate
    {
        public FrmSalvarTemplate()
        {
            InitializeComponent();
        }

        public string NomeTemplate { get => textBoxNomeTemplate.Text; }
        public int IdSetor { get => comboBoxSetor.SelectedIndex; }
        public string DescricaoTemplate { get => textBoxDescricaoTemplate.Text; }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Dispose();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBoxDescricaoTemplate.Text) || textBoxDescricaoTemplate.Text.Length < 20)
            {
                MessageBox.Show("Informa uma descrição com pelo menos 20 caracteres","Aviso" ,MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxSetor.SelectedIndex == 0)
            {
                MessageBox.Show("Selecione o setor para qual o esse template de exame físico será associado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void FrmSalvarTemplate_Load(object sender, EventArgs e)
        {
            string[] strSetor = {"Clinica Médica", "Clinica Pediátrica", "Clinica Cirurgica", "Clinica Obstétrica", "Urgência/Emergência" };

            comboBoxSetor.Items.Insert(0, "Setor o qual o exame será associado");

            for (int i = 1; i <= strSetor.Length; i++)
            {
                comboBoxSetor.Items.Insert(i, strSetor[i-1]) ;
            }

            comboBoxSetor.SelectedIndex = 0;
            textBoxNomeTemplate.Focus();
        }

        private void textBoxNomePrescricao_TextChanged(object sender, EventArgs e)
        {
            btnSalvar.Enabled = textBoxNomeTemplate.Text.Length > 15;
        }
    }
}
