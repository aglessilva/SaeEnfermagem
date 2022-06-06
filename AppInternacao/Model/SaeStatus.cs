using AppInternacao.Enum;
using System;

namespace AppInternacao.Model
{
    public class SaeStatus
    {
        public int Id { get; set; }
        public long Prontuario { get; set; }
        public int IdSetor { get; set; }
        public DateTime? DataSae { get; set; }
        public Sae Status { get; set; }
        public bool? HasSae { get; set; }
    }
}
