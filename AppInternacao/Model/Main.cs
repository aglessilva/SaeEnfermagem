using System;

namespace AppInternacao.Model
{
    public class Main
    {
        public Main()
        {
            Dominio = string.Empty;
            Cliente = string.Empty;
        }
        public string Dominio { get; set; }
        public int IdCliente { get; set; }
        public string Cliente { get; set; }
        public bool? IsAtivo { get; set; }
        public DateTime? DataValidade { get; set; }
    }
}
