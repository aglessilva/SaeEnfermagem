using AppInternacao.Enum;
using System;
using System.Collections.Generic;

namespace AppInternacao.Model
{

    public class Paciente : Endereco
    {
        public Paciente()
        {
            Nome = string.Empty;
            Sae = new SAE();
            SaeStatus = new SaeStatus();
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
        public Enum.StatusInternacao Status { get; set; }
        public string Telefone { get; set; }
        public DateTime? Data { get; set; }
        public SaeStatus SaeStatus { get; set; }
        public bool? HasDiagnosticoEnfermagem { get; set; }
        public bool? HasPrescricaoEnfermagem { get; set; }
        public bool? HasEnvolucaoEnfermagem { get; set; }
        public bool? HasAvaliacaoEnfermagem { get; set; }
        public bool? HasHistoricoEnfermagem { get; set; }
        public SAE Sae { get;set; }
    }

    public sealed class SAE
    {
        public SAE()
        {
            HistoricoEnfermagem = new HistoricoEnfermagem();
            ExameFisico = new ExameFisico();
            DiagnosticoEnfermagem = new List<DiagnosticoEnfermagem>();
            IntervencaoEnfermagem = new List<IntervencaoEnfermagem>();
            EvolucaoEnfermagem = new EvolucaoEnfermagem();
            AvaliacaoEnfermagem = new AvaliacaoEnfermagem();
        }
       
        public DateTime DataSae { get; set; }
        public HistoricoEnfermagem HistoricoEnfermagem { get; set; }
        public ExameFisico  ExameFisico { get; set; }
        public List<DiagnosticoEnfermagem> DiagnosticoEnfermagem { get; set; }
        public List<IntervencaoEnfermagem> IntervencaoEnfermagem { get; set; }
        public EvolucaoEnfermagem EvolucaoEnfermagem { get; set; }
        public AvaliacaoEnfermagem AvaliacaoEnfermagem { get; set; }
        public bool IsConcluido { get; set; }
    }

    public class StatusInernacaoPaciente
    {
        public long Prontuario { get; set; }
        public int IdLeito { get; set; }
        public StatusInternacao Status { get; set; }
    }
    
}
