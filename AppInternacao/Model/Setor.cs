using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInternacao.Model
{
    public class Setor
    {
        public Setor()
        {
            NomeSetor = string.Empty;
        }
        public int Id { get; set; }
        public string NomeSetor { get; set; }
    }
}
