using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInternacao.Model
{
    public class AvaliacaoEnfermagemDTO
    {
        public int Id { get; set; }

        public List<NocIndicador> Indicadores { get; set; }
        public List<NocResultado> Resultados { get; set; }
        public KeyValuePair<string,string>PontuacaoEstimada { get; set; }
        public KeyValuePair<string,string>PontuacaoAlterada { get; set; }

    }
}
