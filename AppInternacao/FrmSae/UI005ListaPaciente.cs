using AppInternacao.Enum;
using AppInternacao.Model;
using AppInternacao.Presenter;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AppInternacao.FrmSae
{
    public partial class UI005ListaPaciente : UI000FrmTemplate
    {
        public UI005ListaPaciente()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            dataGridViewPaciente.AutoGenerateColumns = false;
        }

        PacientePresenter pacientePresenter = null;
        List<Paciente> lst = null;
        
        private void btnLimparCampo_Click(object sender, EventArgs e)
        {
            textBoxNome.Text = string.Empty;
        }

        private void _005ListaPaciente_Load(object sender, EventArgs e)
        {
            new ToolTip() { UseAnimation = true, IsBalloon = false, }.SetToolTip(btnLimparCampo, "Limpar Pesquisa");
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
            dataGridViewPaciente.DataSource = lst.Where(p => !(StatusInternacao.Alta | StatusInternacao.Obito | StatusInternacao.Internado).HasFlag(p.Status)).OrderBy(o => o.Nome).ToList();
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNome.Text.Length >= 3 && textBoxNome.Text.Length < 15)
            {
                Carregar(new Paciente() { Nome = textBoxNome.Text });
            }

            if (textBoxNome.Text.Length == 0)
            {
                textBoxNome.Text = string.Empty;
                Carregar(new Paciente());
            }
        }

        private void dataGridViewPaciente_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewPaciente.ClearSelection();
        }
    }
}
