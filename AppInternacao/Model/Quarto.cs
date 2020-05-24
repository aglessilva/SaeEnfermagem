using System.Collections.Generic;

namespace AppInternacao.Model
{
    public class Quarto
    {
        public Quarto()
        {
            NomeQuarto = string.Empty;
        }
        public int Id { get; set; }
        public int IdSetor { get; set; }
        public string NomeQuarto { get; set; }
        public int TotalLeito { get; set; }
        public List<Quarto> QuartoLeitos { get; set; }
    }
}