namespace AppInternacao.Model
{
    public class Leito
    {
        public Leito()
        {
            NomeLeito = string.Empty;
        }
        public int Id { get; set; }
        public char Act { get; set; }
        public int IdCliente { get; set; }
        public int IdQuarto { get; set; }
        public string NomeLeito { get; set; }
        public string Nome { get; set; }
        public long Prontuario { get; set; }
        public bool? IsDisponibilidade { get; set; }
        public bool IsManutencao { get; set; }
    }
}
