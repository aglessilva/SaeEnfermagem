using System;

namespace AppInternacao.Model
{
    public class ChavePrescricao
    {
        public int Id { get; set; }
        public int IdPaciente { get; set;}
        public string NomePrescricao { get; set; }
        public DateTime? DataPrescricao { get; set;}
        public bool? IsValidado { get; set; }
        public string ObservacaoDevolucao { get; set; }
    }
}
