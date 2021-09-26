using AppInternacao.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AppInternacao.FrmSae
{
    public partial class UI007FrmMenuDireito : UI000FrmTemplate
    {
        public UI007FrmMenuDireito()
        {
            InitializeComponent();
        }
        private Form uc = null;

        private SplitContainer ctrl;
        private void btnExibirHistorico_Click(object sender, EventArgs e)
        {
            if (Sessao.Usuario.Perfil.HasFlag(Perfil.Medico))
            {
              //  ctrl.Panel1.Controls.Add(new UCViewHistoricoEnfermagem());
            }
            else
            {
                //new FrmExibirHistorico().ShowDialog();
            }
        }

        private void btnPrecricaoMedica_Click(object sender, EventArgs e)
        {
            uc = new UI008FrmPrescricaoCiclo() { TopLevel = false };
            OpenUC();
        }

        private void OpenUC()
        {
            try
            {
                FrmMain.listButtons.ForEach(b => FrmMain.RemoveClickEvent(b));
                foreach (Control item in ctrl.Panel1.Controls)
                {
                    if (item is Form)
                    {
                        if (!item.Name.Equals("UI000FrmTemplate"))// template não pode ser removido pois esse form é herdado
                        {
                            var frm = (Form)item;
                            frm.Close();
                            frm.Dispose();
                        }
                    }
                }
                ctrl.Panel1.Controls.Clear();
                ctrl.Panel1.Controls.Add(uc);
                ctrl.Panel1.Tag = uc;
                uc.Show();

            }
            catch (Exception exOpenUc)
            {
                FrmMain.Alert(exception: exOpenUc);
            }
        }

        private void UI007FrmMenuDireito_Load(object sender, EventArgs e)
        {
            ctrl = (SplitContainer)ParentForm.Controls[0].Controls[0];
            lblQuarto.Text = Sessao.Paciente.NomeQuarto;
            lblLeito.Text = Sessao.Paciente.NomeLeito;
            lblUnidadeFuncional.Text = Sessao.Paciente.NomeSetor;
            lblPaciente.Text = Sessao.Paciente.Nome;
            lblIdade.Text = Sessao.Paciente.Idade.ToString();

            MemoryStream ms = new MemoryStream(Sessao.Paciente.Foto);
            pictureBoxExtFoto.Image = Image.FromStream(ms);
        }
    }
}
