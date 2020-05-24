using AppInternacao.Model;
using System.Collections.Generic;

namespace AppInternacao.View
{
    public interface ILeito
    {
        Leito Leito { get; set; }
        List<Leito> leitos { set; }
        List<Quarto> Quartos { set; }
    }
}
