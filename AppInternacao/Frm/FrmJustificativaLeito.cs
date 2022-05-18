using AppInternacao.Enum;
using AppInternacao.Model;
using AppInternacao.Presenter;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace AppInternacao.Frm
{
    public partial class FrmJustificativaLeito : Form
    {
        readonly List<Leito> leitos = null;
        AlteracaoLeitoPaciente alteracaoLeitoPaciente = null;
        private Leito leito = null;

        public FrmJustificativaLeito(List<Leito> _leitos)
        {
            InitializeComponent();
            leitos = _leitos;
        }
       

        private void FrmJustificativaLeito_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.Cancel)
                e.Cancel = true;
            else
                e.Cancel = false;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
           if(comboBoxMotivo.SelectedValue.Equals("0"))
            {
                MessageBox.Show("Selecione um motivo para justificar a alteração.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxMotivo.Focus();
                return;
            }

            try
            {
                leito = (leito != null) ? leitos.FirstOrDefault(n => n.IdLeitoTransferencia != null) : (Leito)Sessao.Dinamico;
                alteracaoLeitoPaciente = new AlteracaoLeitoPaciente()
                {
                    Id = 0,
                    IdStatusAlteracao = (StatusInternacao)Convert.ToInt32(comboBoxMotivo.SelectedValue),
                    Justificativa = textBoxJustificativa.Text,
                    IdLeito = leito.Id,
                    IdLeitoTransferencia = (new string[] { "1", "2", "4", "16" }.Contains(comboBoxMotivo.SelectedValue)) ? leito.IdLeitoTransferencia : null,
                    Prontuario = leito.Prontuario
                };

                PresenterGeneric presenterGeneric = new PresenterGeneric();
                presenterGeneric.Salvar(alteracaoLeitoPaciente, Procedure.SP_ADD_ALTERACAO_LEITO_PACIENTE);
                
                Sessao.Dinamico = alteracaoLeitoPaciente;
                DialogResult = DialogResult.OK;
                Dispose();
            }
            catch (Exception exConf)
            {
                throw exConf;
            }
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Dispose();
        }

        private void FrmJustificativaLeito_Load(object sender, EventArgs e)
        {
            try
            {
                comboBoxMotivo.SelectedIndexChanged -= comboBoxMotivo_SelectedIndexChanged;
                SqlParameter[] sqlParameter = { };
                DataTable tb = new CRUD().GetDataTable(Procedure.SP_GET_STATUS_LEITO, sqlParameter);
                DataRow row = tb.NewRow();
                row["Id"] = "0";
                row["StatusLeito"] = "Selecione";
                tb.Rows.InsertAt(row,0);
                
                comboBoxMotivo.DataSource = tb.DefaultView;
                comboBoxMotivo.SelectedIndexChanged += comboBoxMotivo_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void textBoxJustificativa_TextChanged(object sender, EventArgs e)
        {
            if (textBoxJustificativa.Text.Length <= 100)
            {
                lblCaracteres.Text = $"Minimo de 100 caracteres: {100 - textBoxJustificativa.Text.Length}";
                btnConfirmar.Enabled = textBoxJustificativa.Text.Length >= 100;
            }
        }

        private void comboBoxMotivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // codigos de status que obriga transferir o paciente de um leito para o outro
            var list = new string[] { "1", "2", "4", "16" };
            var item = ((DataRowView)comboBoxMotivo.SelectedItem).Row.ItemArray[0];
            if (list.Contains(item.ToString()))
            {
                Hide();
                using (var frm = new FrmAlterarLeitoPaciente(leitos))
                {
                    frm.ShowDialog();
                    leito = frm.Parametro;
                }
                Show();
            }
        }
    }
}
