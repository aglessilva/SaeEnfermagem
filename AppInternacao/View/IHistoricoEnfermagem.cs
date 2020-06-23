using AppInternacao.Model;
using System.Collections.Generic;


namespace AppInternacao.View
{
    public interface IHistoricoEnfermagem
    {
        HistoricoEnfermagem historicoEnfermagem { get;}
        List<HistoricoEnfermagem> historicoEnfermagems { set; }
    }
}
