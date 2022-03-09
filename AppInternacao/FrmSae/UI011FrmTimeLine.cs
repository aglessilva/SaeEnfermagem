using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppInternacao.FrmSae
{
    public partial class UI011FrmTimeLine : UI000FrmTemplate
    {
        public static IconButton iconButtonAvanca;
        public static IconButton IconButtonVolta;
        public static Panel ctrl;
        public static Label lblRotuloSae;
        public UI011FrmTimeLine()
        {
            InitializeComponent();
            iconButtonAvanca = BtnAvancar;
            IconButtonVolta = btnVoltar;
            ctrl = pFrmBody;
            lblRotuloSae = lblNameStepSae;
        }

        void OpenFormSae()
        {
            try
            {
                Form controlForm = null;
                if (!Sessao.Paciente.HasHistoricoEnfermagem.Value)
                {
                    controlForm = new UI012FrmSaeHistoricoEnfermagem { TopLevel = false };
                    lblNameStepSae.Text = "Histórico de Enfermagem";
                }
                else
                {
                    controlForm = new UI014FrmSaeExameFisico { TopLevel = false };
                    lblNameStepSae.Text = "Investigação (coleta de dados e exame físico)";
                }
                pFrmBody.Controls.Add(controlForm);
                controlForm.Show();
            }
            catch (Exception ex)
            {
                FrmMain.Alert(exception: ex);
            }
        }
        
        private void UI011FrmTimeLine_Load(object sender, EventArgs e)
        {
            OpenFormSae();
        }
    }
}
