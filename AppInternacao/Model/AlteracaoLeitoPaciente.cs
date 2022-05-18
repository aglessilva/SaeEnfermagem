using AppInternacao.Enum;

namespace AppInternacao.Model
{
    public class AlteracaoLeitoPaciente
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public long Prontuario {get; set; }
        public int IdLeito {get; set; }
        public StatusInternacao IdStatusAlteracao {get; set; }
        public string Justificativa {get; set; }
        public int? IdLeitoTransferencia { get; set; }

    }
}
