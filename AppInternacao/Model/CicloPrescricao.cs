using System;

namespace AppInternacao.Model
{
    public class CicloPrescricao
    {
        public int Id { get; set; }
        public int IdChavePrescricao { get; set; }
        public int IdPaciente { get; set; }
        public string IdPrescricao { get; set; }
        public DateTime? Checado { get; set; }
        public DateTime? DataCiclo { get; set; }
        public bool? StatusCiclo { get; set; }
        public string Justificativa { get; set; }
    }
}
