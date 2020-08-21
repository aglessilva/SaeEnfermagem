namespace AppInternacao.Model
{
    public class AlteracaoLeitoPaciente
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdUsuario {get; set; }
        public long Prontuario {get; set; }
        public int IdLeito {get; set; }
        public int IdStatusAlteracao {get; set; }
        public string Justificativa {get; set; }

    }
}
