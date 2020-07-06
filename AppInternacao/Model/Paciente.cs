namespace AppInternacao.Model
{

    public class Paciente
    {
        public Paciente()
        {
            Nome = string.Empty;
        }
        public int Id { get; set; }
        public char Sexo { get; set; }
        public long Prontuario { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public byte[] Foto { get; set; }
        public string NomeLeito { get; set; }
        public bool? IsBaixado { get; set; }
    }
    
}
