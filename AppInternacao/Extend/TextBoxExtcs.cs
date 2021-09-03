using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppInternacao.Extend
{
    public partial class TextBoxExtcs : UserControl
    {
        public TextBoxExtcs()
        {
            InitializeComponent();
            this.Text = string.Empty;
        }

        [Browsable(true)]
        [Category("Extensão de controle")]
        [Description("Seta o texto da marcaDagua que irá aparecer no controle")]
        [DisplayName("Caption")]
        public string Caption
        {
            get
            {
                return labelTitle.Text;
            }
            set
            {
                labelTitle.Text = value;
                base.OnTextChanged(new EventArgs());
            }
        }


        [Browsable(true)]
        [Category("Extensão de controle")]
        [Description("seta o texto que irá aprecer no controle")]
        [DisplayName("Text")]
        /// <summary>
        /// Property to get Text at runtime(hides base Text property)
        /// </summary>
        public new string Text
        {
            get
            {
                //required for validation for Text property

                if (this.Requerid)
                {
                    if (string.IsNullOrWhiteSpace(textBoxCostumer.Text))
                    {
                        ToolTip tip = new ToolTip() { UseAnimation = true, ToolTipIcon = ToolTipIcon.Warning, ToolTipTitle = "Requerido", UseFading = true };
                        tip.Show("Campo obrigatório", textBoxCostumer, 3000);
                        return "";
                    }
                }
                return textBoxCostumer.Text;
            }
            set
            {
                textBoxCostumer.Text = value;
            }
        }

        [Browsable(true)]
        [Category("Extensão de controle")]
        [Description("Determina se o preenchimento de controle é ou não obrigatorio")]
        [DisplayName("Requerido")]
        public bool Requerid { get; set; } = false;

        public TextBoxExtcs(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
