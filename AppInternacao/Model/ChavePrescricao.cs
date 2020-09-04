using System;

namespace AppInternacao.Model
{
    public class ChavePrescricao
    {
        public int Id { get; set; }
        public int idPaciente { get; set;}
        public string NomePrescricao { get; set; }
        public DateTime? DataPrescricao { get; set;}

    }
}
