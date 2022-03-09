using System.Collections.Generic;

namespace AppInternacao.Model
{
    public class ExameFisico
    {
        public List<AreaCategoriaItem> ExameItens { get; set; }
        public string AnotacoesAdicionais { get; set; }
        public string AnotacaoPressaoArterial { get; set; }
        public int CodigoPressaoArterial { get; set; }
    }

}
