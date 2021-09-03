using AppInternacao.Model;
using System.Collections.Generic;

namespace AppInternacao.View
{
    public interface IQuarto
    {
        Quarto Quarto { get; set; }
        List<Quarto> Quartos { set; }
        List<Setor> Setores {  set; }
    }
}
