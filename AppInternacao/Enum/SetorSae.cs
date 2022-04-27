using System;

namespace AppInternacao.Enum
{
    [Flags]
    public enum SetorSae:int
    {
        ClininaMedica = 1,
        ClinicaPediatrica = 2,
        ClinicaCirurgica = 3,
        ClinicaObstetrica = 4,
        UrgenciaEmergencia = 5
    }
}
