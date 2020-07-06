using AppInternacao.Model;
using AppInternacao.Presenter;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AppInternacao.FrmSae
{
    public partial class UCListaPaciente : UserControl
    {
        PacientePresenter pacientePresenter = null;


        List<Paciente> lst = null;
        public UCListaPaciente()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            dataGridViewPaciente.AutoGenerateColumns = false;
        }

       
        private void btnLimparCampo_Click(object sender, EventArgs e)
        {
            textBoxNome.Text = string.Empty;
        }

        private void UCListaPaciente_Load(object sender, EventArgs e)
        {
            new ToolTip(){ UseAnimation = true, IsBalloon = false, }.SetToolTip(btnLimparCampo,"Limpar Pesquisa");
            pacientePresenter = new PacientePresenter();
            Carregar();
        }

        private void dataGridViewPaciente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                Sessao.Paciente = (Paciente)dataGridViewPaciente.Rows[e.RowIndex].DataBoundItem;
        }

        public void Carregar(Paciente _paciente = null)
        {
            lst = pacientePresenter.GetPacientes(_paciente);
            dataGridViewPaciente.DataSource = lst.Where(p => string.IsNullOrWhiteSpace(p.NomeLeito) && p.IsBaixado == false).OrderBy(o => o.Nome).ToList();
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {
            if(textBoxNome.Text.Length >= 3 && textBoxNome.Text.Length < 15)
            {
                Carregar(new Paciente() { Nome = textBoxNome.Text });
            }

            if (textBoxNome.Text.Length == 0)
            {
                textBoxNome.Text = string.Empty;
                Carregar(new Paciente());
            }
        }
    }
}
