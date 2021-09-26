namespace AppInternacao.Model
{
    public class HistoricoEnfermagem
    {
        public int Id { get; set; }
        public int IdPaciente { get; set; }
        public int Proveniente { get; set; }
        public string ProvenienteDescricao { get; set; }
        public int SituacaoEntrada { get; set; }
        public string MotivoInternacao { get; set; }
        public int DoencaCorrelacionada { get; set; }
        public string DoencaCorrelacionadaDescricao { get; set; }
        public string DiagnosticoMedico { get; set; }
        public string AvaliacaoSaude { get; set; }
        public string UsoMedicamento { get; set; }
    }
}

