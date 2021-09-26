namespace AppInternacao.Model
{
    public class NandaDiagnostico
    {
        public string Codigo { get; set; }
        public int? IdDominio { get; set; }
        public int IdClasse { get; set; }
        public string Diagnostico { get; set; }
        public string Definicao { get; set; }
    }
}
