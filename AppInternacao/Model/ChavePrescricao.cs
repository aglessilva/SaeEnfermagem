using AppInternacao.Enum;
using System;

namespace AppInternacao.Model
{
    public class ChavePrescricao
    {
        public int Id { get; set; }
        public long Prontuario { get; set;}
        public string NomePrescricao { get; set; }
        public DateTime? DataPrescricao { get; set;}
        public StatusPrescricao Status{ get; set; }
     //   public string Anotacao { get; set; }
    }
}
