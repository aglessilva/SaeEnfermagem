using System;

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
        public int IdEstruturaFisica { get; set; }
        public int Idade { get; set; }
        public byte[] Foto { get; set; }
        public string NomeLeito { get; set; }
        public string NomeQuarto { get; set; }
        public string NomeSetor { get; set; }
        public bool? IsBaixado { get; set; }
        public string HistoricoEnfermagem { get; set; }
        public SAE Sae { get; set; }
    }

    public sealed class SAE
    {
        public int Id { get; set; }
        public int IdCiente { get; set; }
        public int IdPaciente { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DataSae { get; set; }
        public bool DiagnosticoEnfermagem { get; set; }
        public bool PrescricaoEnfermagem { get; set; }
        public bool EnvolucaoEnfermagem { get; set; }
        public bool AvaliacaoEnfermagem { get; set; }
        public bool IsConcluido { get; set; }
    }
    
}
