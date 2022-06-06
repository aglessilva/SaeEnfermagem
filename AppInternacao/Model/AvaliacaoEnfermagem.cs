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


        public sealed class AvaliacaoEnfermagemDTO
        {
            public int Id { get; set; }
            public int IdSae { get; set; }
            public long Prontuario { get; set; }
            public string Codigo { get; set; }
            public string Resultados { get; set; }
            public string Indicadores { get; set; }
            public string NicClassificacao { get; set; }
            public string PontuacaoIndicadorPrimario { get; set; }
            public string PontuacaoIndicadorSecundario { get; set; }
        }

        public AvaliacaoEnfermagem()
        {
            Indicadores = new List<NocIndicador>();
            DTO = new AvaliacaoEnfermagemDTO();
        }

        public int Id { get; set; }
        public int IdSae { get; set; }
        public string Codigo { get; set; }
        public NocResultado Resultados { get; set; }
        public List<NocIndicador> Indicadores { get; set; }
        public KeyValuePair<string, string> NicClassificacao { get; set; }
        public KeyValuePair<string, ItemKeyValue> PontuacaoIndicadorPrimario { get; set; }
        public KeyValuePair<string, ItemKeyValue> PontuacaoIndicadorSecundario { get; set; }
        public AvaliacaoEnfermagemDTO DTO { get; set; }
    }
}
