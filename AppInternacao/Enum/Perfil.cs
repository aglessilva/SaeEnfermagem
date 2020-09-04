using System;

namespace AppInternacao.Enum
{
    [Flags]
    public enum Perfil : int
    {
        Nenhum = 0,
        Tecnico = 2,
        Enfermeiro_Assistemcial = 4 ,
        Medicos = 8,
        EnfermeiroAdmin = Enfermeiro_Assistemcial | Tecnico,
       // Administrador =  Enfermeiro_Assistemcial | Medicos | Tecnico
        Administrador =  EnfermeiroAdmin | Medicos 
    }
}
