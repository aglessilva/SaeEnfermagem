using System;

namespace AppInternacao.Model
{
    public class ChavePrescricao
    {
        public int Id { get; set; }
        public int IdPaciente { get; set;}
        public string NomePrescricao { get; set; }
        public DateTime? DataPrescricao { get; set;}
        public int? StatusPrescricao { get; set; }
     //   public string Anotacao { get; set; }
    }
}
