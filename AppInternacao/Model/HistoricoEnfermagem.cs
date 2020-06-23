using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInternacao.Model
{
    public class HistoricoEnfermagem
    {
        public int Id { get; set; }
        public int IdPaciente { get; set; }
        public DateTime? DataHistorico { get; set; }
        public string Historico { get; set; }
        
    }
}
