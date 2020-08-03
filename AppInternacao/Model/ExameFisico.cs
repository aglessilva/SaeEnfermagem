using System;

namespace AppInternacao.Model
{
    public class ExameFisico
    {
        public ExameFisico()
        {
            Sonda = new CateterSonda();
           // SituacaoTermica = new StatuTermico();
            Abdominal = new ResgulacaoAbdominal();
            GastroIntestinal = new SistemaGastroIntestinal();
            Cliente = new Paciente();
        }
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DataExameFisico { get; set; }
        public string PA { get; set; }
        public Paciente Cliente { get; set; }
        public CateterSonda Sonda { get; set; }
        public string Alergia { get; set; }
        public string SistemaNeurologico { get; set; }
        public string Pupilas { get; set; }
        public string SituacaoTermica { get; set; }
        public string Oxigenacao { get; set; }
        public string Pele { get; set; }
        public SistemaGastroIntestinal GastroIntestinal { get; set; }
        public ResgulacaoAbdominal Abdominal { get; set; }
        public string Vascular { get; set; }
        public string Ucera { get; set; }
        public string Observacao { get; set; }
    }

    public class CateterSonda
    {
        public CateterSonda()
        {
            CateterCentral = string.Empty;
            CateterPeriferico = string.Empty;
        }
        public string CateterCentral { get; set; }
        public string CateterPeriferico { get; set; }
    }

    public class SistemaGastroIntestinal
    {
        public SistemaGastroIntestinal()
        {
            Sistema = string.Empty;
            Gavagem = string.Empty;
            Evacuacao = string.Empty;
            Urina = string.Empty;
        }
        public string Sistema { get; set; }
        public string Gavagem { get; set; }
        public string Evacuacao { get; set; }
        public string Urina { get; set; }
    }

    public class ResgulacaoAbdominal
    {
        public string RegulacaoAbdominal { get; set; }
        public string RHA { get; set; }
        public string Viceromegalias { get; set; }
    }
}
