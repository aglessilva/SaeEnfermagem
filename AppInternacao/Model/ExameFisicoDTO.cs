using System;

namespace AppInternacao.Model
{
    public class ExameFisicoDTO
    {
        public int Id {get; set; }
        public int IdUsuario {get; set;}
        public long Prontuario {get; set;}
        public int IdTemplate {get; set;}
        public string IdAreas {get; set;}
        public string IdAreasItens {get; set;}
        public string AnotacoesAdicionais {get; set;}
        public string AnotacaoPressaoArterial {get; set;}
        public int CodigoPressaoArterial {get; set;}
        public DateTime? DataExameFisico {get; set;}

    }
}
