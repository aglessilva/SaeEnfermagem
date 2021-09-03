using AppInternacao.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AppInternacao.Frm
{
    public partial class FrmAlterarLeitoPaciente : Form
    {
        private readonly List<Leito> leitos = null;
        private  Leito objLeito = null;

        public Leito Parametro
        {
            get { return objLeito; }
        }

        public FrmAlterarLeitoPaciente(List<Leito> _leitos) : this()
        {
            dataGridViewLeito.AutoGenerateColumns = false;
            leitos = _leitos;
        }

        public FrmAlterarLeitoPaciente()
        {
            InitializeComponent();
        }

        private void btnCancelarFechar_Click(object sender, EventArgs e)
        {
            Dispose(true);
            Close();
        }

        private void btnAssociarNovoLeito_Click(object sender, EventArgs e)
        {
            try
            {
                objLeito.IdLeitoTransferencia = objLeito.Id;
                objLeito.Id = ((Leito)Sessao.Dinamico).Id;
                objLeito.Prontuario = ((Leito)Sessao.Dinamico).Prontuario;
                Dispose(true);
                Close();
            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }

        }

        private void FrmAlterarLeitoPaciente_Load(object sender, EventArgs e)
        {
            dataGridViewLeito.DataSource = leitos.Where(n => (bool)n.IsDisponibilidade && !n.IsManutencao).ToList();
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {
            dataGridViewLeito.DataSource = !string.IsNullOrWhiteSpace(textBoxNome.Text) ? leitos.Where(n => n.NomeLeito.Contains(textBoxNome.Text) && (bool)n.IsDisponibilidade && !n.IsManutencao).ToList(): leitos.Where(n => (bool)n.IsDisponibilidade && !n.IsManutencao).ToList(); 
        }

        private void btnLimparCampo_Click(object sender, EventArgs e)
        {
            textBoxNome.Text = string.Empty;
        }

        private void dataGridViewLeito_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
                return;

            var senderGrid = (DataGridView)sender;
            try
            {
                objLeito =(Leito)senderGrid.Rows[e.RowIndex].DataBoundItem;
                btnAssociarNovoLeito.Enabled = objLeito != null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
