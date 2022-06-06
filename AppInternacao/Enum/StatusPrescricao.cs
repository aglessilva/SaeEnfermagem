using System;

namespace AppInternacao.Enum
{
    [Flags]
    public enum StatusPrescricao : int
    {
        Edicao = 8,
        Analise = 4,
        Aprovado = 2,
        Revisao = 1 | Edicao,

    }
}
