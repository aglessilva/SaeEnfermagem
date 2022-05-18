using System.Collections.Generic;

namespace AppInternacao.Model
{
    public class AvaliacaoEnfermagem
    {

        public sealed class ItemKeyValue
        {
            public bool Checked { get; set; }
            public string IdIndicador { get; set; }
            public string ValorIndicador { get; set; }
        }

        public AvaliacaoEnfermagem()
        {
            Indicadores = new List<NocIndicador>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public NocResultado Resultados { get; set; }
        public List<NocIndicador> Indicadores { get; set; }
        public KeyValuePair<string, string> NicClassificacao { get; set; }
        public KeyValuePair<string, ItemKeyValue> PontuacaoIndicadorPrimario { get; set; }
        public KeyValuePair<string, ItemKeyValue> PontuacaoIndicadorSecundario { get; set; }
    }
}
