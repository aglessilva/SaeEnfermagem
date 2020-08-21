using System.Collections.Generic;

namespace AppInternacao.Model
{
    public class PrescricaoPaciente
    {
        public List<PrescricaoMedica> Prescricao { get; set; }
        public List<CicloPrescricao> Ciclos { get; set; }
    }
}
