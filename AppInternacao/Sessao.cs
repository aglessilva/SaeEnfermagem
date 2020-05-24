using AppInternacao.Model;
using System;

namespace AppInternacao
{
    public static class Sessao
    {
        public static string Dominio { get => Environment.UserDomainName;}

        public static string Cliente { get; set; }
        public static bool IsAtivo { get; set; }
        public static DateTime DataValidade { get; set; }
        public static int CodigoCliente { get; internal set; }

        public static Paciente Paciente { get; internal set; }
    }
}
