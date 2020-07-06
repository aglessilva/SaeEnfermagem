using System;

namespace AppInternacao.Enum
{
    [Flags]
    public enum Perfil : int
    {
        Nenhum = 0,
        Enfermeiros = 1,
        Medicos = 2,
        Administrador =  Enfermeiros | Medicos
    }
}
