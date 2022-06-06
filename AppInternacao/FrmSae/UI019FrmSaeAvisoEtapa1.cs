using AppInternacao.Model;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AppInternacao.FrmSae
{
    public partial class UI019FrmSaeAvisoEtapa1 : AppInternacao.FrmSae.UI000FrmTemplate
    {
        private readonly SaeStatus status;
        public UI019FrmSaeAvisoEtapa1(SaeStatus saeStatus =  null )
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            status = saeStatus;
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
      (
          int nLeftRect,     // x-coordinate of upper-left corner
          int nTopRect,      // y-coordinate of upper-left corner
          int nRightRect,    // x-coordinate of lower-right corner
          int nBottomRect,   // y-coordinate of lower-right corner
          int nWidthEllipse, // height of ellipse
          int nHeightEllipse // width of ellipse
      );

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UI019FrmSaeAvisoEtapa1_Load(object sender, EventArgs e)
        {
            if (status != null)
            {
                lblTexto.Text = $"Durante a data:'{DateTime.Today.Date.ToShortDateString()}' a pontuação dos alvos podem ser editados.\nApós essa data, o ciclo de avaliação diária do" +
                    $" paciente {Sessao.Paciente.Nome} será finalizado automaticamente e não poderá ser acessado para edição, somente para consulta.";
                lblTitulo.Text = Sessao.Paciente.SaeStatus.Status == Enum.Sae.Andamento ? "Concluir etapa final do processo SAE" : "Atualizar etapa de avaliação SAE";
                iconPictureBox5.ForeColor = Color.GreenYellow;
                label6.ForeColor = Color.White;
                button1.Visible = false;
                btnConcluir.Width = 220;
                btnConcluir.Text = Sessao.Paciente.SaeStatus.Status == Enum.Sae.Andamento ? "Concluir avaliação do paciente" : "Atualizar avaliação do paciente";
            }
        }
    }
}
