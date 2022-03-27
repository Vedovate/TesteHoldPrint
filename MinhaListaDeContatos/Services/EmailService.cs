using Dapper;
using MinhaListaDeContatos.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MinhaListaDeContatos.Services
{
    internal class EmailService
    {
        static string StConexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Lvedo\\OneDrive\\Área de Trabalho\\MinhaListaDeContatos\\MinhaListaDeContatos\\BD.mdf\";Integrated Security=True";



        public static MailMessage MontarEmail(Contato contato)
        {
            try
            {
                
                MailMessage email = new MailMessage();
                email.From = new MailAddress("testecsholdprint@gmail.com");
                email.To.Add(new MailAddress("testecsholdprint@gmail.com"));
                email.Subject = "Contato Compartilhado";
                email.Body = $"Nome:{contato.Nome} \nTelefone:{contato.Telefone} \nEmail:{contato.Email} \n" +
                    $"Endereço:\n{contato.Endereco.Logradouro}, {contato.Endereco.Numero}\n{contato.Endereco.Bairro}\n{contato.Endereco.CEP}\n{contato.Endereco.Cidade} - {contato.Endereco.Estado}";
                email.IsBodyHtml = false;
                email.Priority = MailPriority.Normal;
                return email;
            }
            catch (Exception ex)
            {

                return null;
            }
        }
        public static void EnviaEmail(MailMessage email)
        {
            try
            {
                using (SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("testecsholdprint@gmail.com", "HoldTeste123"),
                    EnableSsl = true

                })
                {
                    client.Send(email);
                }
            }
            catch (Exception ex)
            {

            }

        }



    }
}
