using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInternacao.Model
{
    public class IntervencaoEnfermagem
    {
        public long Prontuario { get; set; }
        public string CodigoDiagnostico { get; set; }
        public string Classificacao { get; set; }
        public string Indicadores { get; set; }
    }
}
