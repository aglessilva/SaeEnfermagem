using System;

namespace AppInternacao.Model
{
    public class DiagnosticoEnfermagemDTO
    {
        public int Id { get; set; }
        public int IdSae{get;set;}
        public long Prontuario { get; set; }
        public DateTime? DataInclusao { get; set; }
        public string Diagnostico{get;set;}
        public string FatorRelacionados{get;set;}
        public string CondicaoAssociadas{get;set;}
        public string CaracteristicaDefinidoras{get;set;}
        public string FatorRiscos{get;set;}
        public string PopulacaoRiscos{get;set;}

    }
}
