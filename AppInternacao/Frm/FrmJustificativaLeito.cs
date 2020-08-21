using AppInternacao.Enum;
using AppInternacao.Model;
using AppInternacao.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppInternacao.Frm
{
    public partial class FrmJustificativaLeito : Form
    {
        public FrmJustificativaLeito()
        {
            InitializeComponent();
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
           
            try
            {
                dynamic objDynamic = Sessao.Dinamico;
                AlteracaoLeitoPaciente alteracaoLeitoPaciente = new AlteracaoLeitoPaciente()
                {
                    Id = 0,
                    IdStatusAlteracao = Convert.ToInt32(comboBoxMotivo.SelectedValue),
                    IdUsuario = Sessao.Usuario.Id,
                    Justificativa = textBoxJustificativa.Text,
                    IdLeito = objDynamic.Id,
                    Prontuario = objDynamic.Prontuario
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
                SqlParameter[] sqlParameter = { };
                DataTable tb = new CRUD().GetDataTable(Enum.Procedure.SP_GET_STATUS_LEITO, sqlParameter);
                comboBoxMotivo.DataSource = tb;
            }
            catch (Exception)
            {

                throw;
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
    }
}
