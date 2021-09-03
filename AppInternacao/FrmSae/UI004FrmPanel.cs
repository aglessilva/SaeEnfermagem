using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AppInternacao.FrmSae
{
    public partial class UI004FrmPanel : UI000FrmTemplate
    {
        public UI004FrmPanel()
        {
            InitializeComponent();
            
        }

        private IconButton currentBtn;
        private Form form = null;
        private SplitContainer splitContainer = null;
       
        private void UI004FrmPanel_Load(object sender, EventArgs e)
        {
            splitContainer = (SplitContainer)Parent.Parent;
        }

        private void btnQuartos_Click(object sender, EventArgs e)
        {
            
            splitContainer.Panel2.Controls[0].Hide();
            form = new UI004FrmPanelQuarto { TopLevel = false };
            ActivateButton(sender);
            OpenFormPanel();
        }

        private void btnInternacao_Click(object sender, EventArgs e)
        {
            splitContainer.Panel2.Controls[0].Show();
            form = new UI004FrmPanelOcupacoes { TopLevel = false };
            ActivateButton(sender);
            OpenFormPanel();
        }

        private void btnLeitos_Click(object sender, EventArgs e)
        {
            splitContainer.Panel2.Controls[0].Hide();
            form = new UI004FrmPanelLeito{ TopLevel = false };
            ActivateButton(sender);
            OpenFormPanel();
        }

        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(6, 39, 69);
                currentBtn.IconColor = Color.FromArgb(192, 192, 192);
                currentBtn.ForeColor = Color.FromArgb(224, 224, 224);

            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.Transparent;
                currentBtn.IconColor = Color.FromArgb(65, 165, 245);
                currentBtn.ForeColor = Color.FromArgb(0, 0, 0);
            }

        }

        void OpenFormPanel()
        {
            foreach (Control item in panelForms.Controls)
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
            panelForms.Controls.Clear();
            panelForms.Controls.Add(form);
            form.Show();
        }
    }
}
