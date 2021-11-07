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
            if (!(bool)Sessao.Paciente.HasHistoricoEnfermagem)
            {
                Form controlForm = new UI012FrmSaeHistoricoEnfermagem
                {
                    TopLevel = false
                };
                pFrmBody.Controls.Add(controlForm);
                lblNameStepSae.Text = "Histórico de Enfermagem";
                controlForm.Show();
            }
        }
        
        private void UI011FrmTimeLine_Load(object sender, EventArgs e)
        {
            OpenFormSae();
        }
    }
}
