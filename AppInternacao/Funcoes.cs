using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Net;
using System.Net.Mail;
using AppInternacao.Model;
using AppInternacao.Enum;

namespace AppInternacao
{
    public class Funcoes
    {
       private static int retornoEmail = 0;
        // CRIPTOGRAFAR SENHA
        public static string CriptoGrafaSenha(string _Senha)
        {
            MD5 md5Hasher = MD5.Create();
            byte[] valorCriptografado = md5Hasher.ComputeHash(Encoding.Default.GetBytes(_Senha));

            StringBuilder strBuilder = new StringBuilder();

            for (int i = 0; i < valorCriptografado.Length; i++)
            {
                strBuilder.Append(valorCriptografado[i].ToString("x2"));
            }
            return strBuilder.ToString();
        }

        // VALIDAR DOCUMENTO CPF
        public static bool ValidaCpf(string cpf)
        {
            try
            {
                byte[] verificador = { Convert.ToByte(cpf.Substring(9, 1)), Convert.ToByte(cpf.Substring(10, 1)) };
                IEnumerable<char> numeroCpf = cpf.ToCharArray().Take(9);
                byte d1, d2;
                int soma, resto, contador;
                contador = 10;
                soma = 0;

                foreach (char item in numeroCpf)
                {
                    soma += Convert.ToByte(item.ToString()) * contador--;
                }
                resto = soma % 11;

                if (resto > 1)
                    d1 = (byte)(11 - resto);
                else
                    d1 = 0;

                soma = resto = 0;
                contador = 11;
                numeroCpf = cpf.ToCharArray().Take(10);

                foreach (char item in numeroCpf)
                {
                    soma += Convert.ToByte(item.ToString()) * contador--;
                }

                resto = soma % 11;

                if (resto > 1)
                    d2 = (byte)(11 - resto);
                else
                    d2 = 0;

                if (d1 == verificador.First() && d2 == verificador.Last())
                    return true;
                else
                    return false;

            }
            catch (Exception exCpf)
            {
                throw exCpf;
            }
        }

        public static int EnviarEmail(Usuario usuario, bool isNovoUsuario = false)
        {
            NetworkCredential login;
            SmtpClient client;
            MailMessage msg;

            try
            {
                string mensagem = string.Empty;
                mensagem += $"<html><body><h3><center>SAE - {(isNovoUsuario ? "NOVO USUÁRIO" : " SOLICITAÇÃO DE SENHA" )}</center><hr/></h3><br/><p>Olá {usuario.Nome}<br/></p>";
                mensagem += $"<p>Foi gerada uma nova senha de acesso temporária!<br>Será solicitado alteração de senha temporária para uma senha de sua preferência.</p>";
                mensagem += $"<div style='border:1px solid black; padding:10px; border-radius: 5px;'>Usuário:<b> {usuario.Login}</b><br/>Senha: <b>{usuario.Senha}</b></div><p>Resposta automático!<br/>Favor não responder este e-mail!!!</p></body></html>";

                login = new NetworkCredential("agles.developer", "gfljmaxbyxtrnwdg");
                client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Credentials = login;
                msg = new MailMessage { From = new MailAddress("agles.developer@gmail.com", "Sistema - SAE", Encoding.Default), };
                msg.To.Add(new MailAddress(usuario.Email, usuario.Nome, Encoding.ASCII));
                msg.Subject = $"SAE - {(isNovoUsuario ? "Bem Vindo(a)" : "Nova Senha")}";
                msg.Body = mensagem;
                msg.BodyEncoding = Encoding.Default;
                msg.IsBodyHtml = true;
                msg.Priority = MailPriority.Normal;
                msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
              //  client.SendCompleted += Client_SendCompleted;
              //  string sendStatus = "Enviando...";
                
                client.Send(msg);
            }
            catch (Exception exSendEmail)
            {
                throw exSendEmail;
            }

            return retornoEmail;
        }

        private static void Client_SendCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
                retornoEmail = 1;

            if (e.Error != null)
                retornoEmail = 2;
            else
                retornoEmail = 0;

        }

      
    }
}
