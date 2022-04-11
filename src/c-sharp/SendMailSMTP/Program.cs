using System;
using System.Configuration;
using System.Net.Mail;

namespace SendMailSMTP
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                System.Collections.Specialized.NameValueCollection appSettings = ConfigurationManager.AppSettings;
                string from = appSettings["from"];
                string to = appSettings["to"];
                string host = appSettings["host"];
                int port = int.Parse(appSettings["port"]);
                string subject = "Teste SMTP";
                string body = "Teste SMTP";

                Console.WriteLine("Iniciando...");
                Console.WriteLine("................");
                Console.WriteLine("host..." + host);
                Console.WriteLine("................");
                Console.WriteLine("from..." + from);
                Console.WriteLine("................");
                Console.WriteLine("to..." + to);
                Console.WriteLine("................");
                Console.WriteLine("subject..." + subject);
                Console.WriteLine("................");
                Console.WriteLine("body..." + body);
                Console.WriteLine("................");

                SmtpClient ss = new SmtpClient(host);
                ss.Port = port;
                ss.UseDefaultCredentials = true;
                ss.Send(from, to, subject, body);
                Console.WriteLine("Enviado...");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro..." + ex.ToString());
            }
            Console.ReadKey();

        }
    }
}
