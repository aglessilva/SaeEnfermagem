using System.Collections.Generic;

namespace AppInternacao.Model
{
    public class DiagnosticoEnfermagem
    {
        public DiagnosticoEnfermagem()
        {
            FatorRelacionados = new List<NandaFatorRelacionado>();
            CondicaoAssociadas = new List<NandaCondicaoAssociada>();
            CaracteristicaDefinidoras = new List<NandaCaracteristicaDefinidora>();
            FatorRiscos = new List<NandaFatorRisco>();
            PopulacaoRiscos = new List<NandaPopulacaoRisco>();
            DiagnosticoEnfermagemDTO = new DiagnosticoEnfermagemDTO();
        }

        public int Id { get; set; }
        public string NomeDominio { get; set; }
        public string NomeClasse { get; set; }
        public DiagnosticoEnfermagemDTO DiagnosticoEnfermagemDTO { get; set; }
        public NandaDiagnostico Diagnostico { get; set; }
        public List<NandaFatorRelacionado> FatorRelacionados { get; set; }
        public List<NandaCondicaoAssociada> CondicaoAssociadas { get; set; }
        public List<NandaCaracteristicaDefinidora> CaracteristicaDefinidoras { get; set; }
        public List<NandaFatorRisco> FatorRiscos { get; set; }
        public List<NandaPopulacaoRisco> PopulacaoRiscos { get; set; }
    }
}
