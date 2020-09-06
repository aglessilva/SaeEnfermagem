using System.ComponentModel;
using System.Windows.Forms;

namespace AppInternacao.Extend
{
    public class CheckBoxExt : CheckBox
    {
        [Browsable(true)]
        [Category("Valor Associado")]
        [Description("Pega ou Seta um valor para o controle checkbox, se verdadeiro, pega o valor, se falso recebe vazio")]

        public string Value { get; set; } = string.Empty;

        public CheckBoxExt()
        {
            Value = string.Empty;
        }
    }
}
