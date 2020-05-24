using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInternacao.Model
{
    public class Leito
    {
        public Leito()
        {
            NomeLeito = string.Empty;
        }
       public int Id { get; set; }
       public int IdCliente { get; set; }
       public int IdQuarto { get; set; }
       public string NomeLeito { get; set; }
       public bool? IsDisponibilidade { get; set; }
    }
}
