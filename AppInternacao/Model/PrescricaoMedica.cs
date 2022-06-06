using System;
using System.Collections.Generic;

namespace AppInternacao.Model
{
    public class PrescricaoMedica
    {
        public PrescricaoMedica()
        {
            Datas = new List<DateTime>();
        }
        public int Id { get; set; }
        public long Prontuario { get; set; }
        public int IdChavePrescricao { get; set; }
        public string Prescricao { get; set; }
        public TimeSpan? Intervalo { get; set; }
        public TimeSpan? Horario { get; set; }
        public List<DateTime> Datas { get; set; }
        public string CicloData { get; set; }
        public string Justificativa { get; set; }
    }
}
