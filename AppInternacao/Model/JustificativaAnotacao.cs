using System;

namespace AppInternacao.Model
{
    public class JustificativaAnotacao
    {
        public int Id { get; set; } 
        public int IdCliente { get; set;}
        public int IdUsuario { get; set;}
        public int IdPaciente { get; set;}
        public int IdPrescricao { get; set;}
        public int TipoMsg { get; set; }
        public string Nome { get; set; }
        public string AnotacaoItemPrescricao { get; set;}
        public string Justificativa { get; set;}
        public string ObervacaoDevolucao { get; set;}
        public DateTime? Data { get; set;}
        public string ItemData { get; set; }
    }
}
