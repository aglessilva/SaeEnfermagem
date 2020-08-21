using System;

namespace AppInternacao.Model
{
    public class CicloPrescricao
    {
        public int Id { get; set; }
        public int IdPrecricao { get; set; }
        public DateTime DataCiclo { get; set; }
        public bool StatusCiclo { get; set; }
        public string Justificativa { get; set; }
    }
}
