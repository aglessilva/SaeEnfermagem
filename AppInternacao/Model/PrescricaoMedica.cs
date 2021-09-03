using System;

namespace AppInternacao.Model
{
    public class PrescricaoMedica
    {
        public int Id { get; set; }
        public int IdPaciente { get; set; }
        public int IdChavePrescricao { get; set; }
        public string Prescricao { get; set; }
        public TimeSpan? Intervalo { get; set; }
        public TimeSpan? Horario { get; set; }
        public string Justificativa { get; set; }
    }
}
