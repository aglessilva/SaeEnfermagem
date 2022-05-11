using System.Collections.Generic;

namespace AppInternacao.Model
{
    public class IntervencaoEnfermagem
    {
        public IntervencaoEnfermagem()
        {
            KeyPairIndicadores = new List<KeyValuePair<int, IndicadorItem>>();
            KeyPairAnotacaoPrescricaoEnfermagem = new List<KeyValuePair<int, AnotacoesEnfermagem>>();
        }
        public int Id { get; set; }
        public int IdSae { get; set; }
        public long Prontuario { get; set; }
        public string CodigoDiagnostico { get; set; }
        public string Classificacao { get; set; }
        public string Indicadores { get; set; }
        public string AnotacaoPrescricaoEnfermagem { get; set; }
        public List<KeyValuePair<int, IndicadorItem>> KeyPairIndicadores { get; set; }
        public List<KeyValuePair<int, AnotacoesEnfermagem>> KeyPairAnotacaoPrescricaoEnfermagem { get; set; }

        public class IndicadorItem
        {
            public int Id { get; set; }
            public bool Ckecked { get; set; }
        }

        public class AnotacoesEnfermagem
        {
            public string AnotacaoEnfermeiro { get; set; }
            public string AnotacaoEquipeTecnica { get; set; }
        }
    }
}
