﻿using System;

namespace AppInternacao.Enum
{
    [Flags]
    public enum Perfil : int
    {
        Nenhum = 0,
        Tecnico = 2,
        Enfermeiro_Assistemcial = 4 ,
        Medico = 8,
        EnfermeiroAdmin = Enfermeiro_Assistemcial | Tecnico,
       // Administrador =  Enfermeiro_Assistemcial | Medico | Tecnico
        Administrador =  EnfermeiroAdmin | Medico 
    }
}
