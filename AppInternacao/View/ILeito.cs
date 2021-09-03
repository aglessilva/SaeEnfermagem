using AppInternacao.Model;
using System.Collections.Generic;

namespace AppInternacao.View
{
    public interface ILeito
    {
        Leito Leito { get; set; }
        List<Leito> Leitos { set; }
        List<Quarto> Quartos { set; }
    }
}
