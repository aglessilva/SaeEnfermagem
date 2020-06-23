using System;

namespace AppInternacao.Enum
{
    [Flags]
    public enum Perfil : int
    {
        Enfermeiros = 1,
        Medicos = 2,
        Admin =  Enfermeiros | Medicos
    }
}
