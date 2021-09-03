using System;
using System.ComponentModel;

namespace AppInternacao.Enum
{
    [Flags]
    public enum StatusInternacao:int
    {
        [Description("Manutenção do Enferimeiro")]
        ManutencaoEnfermeiro = 1,
        [Description("Leito em Manutenção")]
        ManutencaoLeito = 2,
        [Description("Transferência de Leito")]
        TransferenciaLeito = 4,
        [Description("Transferência Externa")]
        TransferenciaExterna = 8,
        [Description("Em Isolamento")]
        Isolamento = 16,
        [Description("Alta")]
        Alta = 32,
        [Description("Obito")]
        Obito = 64,
        [Description("Aguardando disp. de Leito")]
        AguardandoLeito = 128,
        [Description("Internado")]
        Internado = 256
    }
}
