using AppInternacao.Model;
using System.Collections.Generic;

namespace AppInternacao.View
{
    public interface IPaciente
    {
        Paciente paciente { get; set; }
        List<Paciente> pacientes { set; }
    }
}
