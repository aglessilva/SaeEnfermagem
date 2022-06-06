using System;
using System.Collections.Generic;

namespace AppInternacao.Model
{
    public class ExameFisico
    {
        public ExameFisico()
        {
            ExameItens = new List<AreaCategoriaItem>();
        }

        public int Id { get; set; }
        public int IdSae { get; set; }
        public int IdTemplate { get; set; }
        public int IdSetor { get; set; }
        public long Prontuario { get; set; }
        public string AnotacoesAdicionais { get; set; }
        public string AnotacaoPressaoArterial { get; set; }
        public int CodigoPressaoArterial { get; set; }
        public string AreasItens { get; set; }
        public DateTime? DataExameFisico { get; set; }
        public List<AreaCategoriaItem> ExameItens { get; set; }
    }

}
