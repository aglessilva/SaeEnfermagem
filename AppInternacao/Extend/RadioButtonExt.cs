using System.ComponentModel;
using System.Windows.Forms;

namespace AppInternacao.Extend
{
    public  class RadioButtonExt :  RadioButton
    {
        [Browsable(true)]
        [Category("Valor Associado")]
        [Description("Pega ou Seta um valor na propriedade do controle RadioButtonExt")]
        public string Value { get; set; } = string.Empty;

        public RadioButtonExt()
        {
            Value = string.Empty;
        }
    }
}
