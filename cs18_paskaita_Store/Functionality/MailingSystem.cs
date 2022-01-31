using System;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit; // <-- Pašto siuntimo daiktas: https://stackoverflow.com/questions/449887/sending-e-mail-using-c-sharp

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs18_paskaita_Store.Functionality
{
    internal class MailingSystem
    {
        public static void MIMEMessage()
        {
        // Mime stands for Multiple Internet Mail Extensions
        // Tools -> Nuget Package Manager -> Package manager console: pm> Install-Package MailKit
        // Less secure app access (G Account security settings)
            MimeMessage message = new MimeMessage(); // <-- Sukuriu naują message objektą, į kurį talpinsiu datą laiško
            message.From.Add(new MailboxAddress("C# Parduotuvė", "DotNetSendingEmail@gmail.com")); // <-- šitą dalį gavėjas matys kaip sender lauką

            message.To.Add(MailboxAddress.Parse("V.Surkus@me.com")); // <-- Adresato laukas; parse konvertuoja string'ą į pašto adreso duomenį
            message.To.Add(MailboxAddress.Parse("DotNetSendingEmail@gmail.com"));

            message.Subject = $"{DateTime.Today.Year}-{DateTime.Today.Month}-{DateTime.Today.Day} Pirkinys";

            CartAndChequeSystem.ConstructChequeString();

            message.Body = new TextPart("plain")
            {
                //Text = "Testas"
                Text = CartAndChequeSystem.Cheque
            };
            #region (!) SENSITIVE DATA
            //Console.Write("Email: ");
            string emailAdress = "DotNetSendingEmail@gmail.com";
            //Console.Write("Password: ");
            string password = "qio-778-211";
            #endregion

            SmtpClient client = new SmtpClient();

            try
            {
                client.Connect("smtp.gmail.com", 465, true); // 465 port'as. bool klausia ar naudojamas SSL
                client.Authenticate(emailAdress, password); // <-- autentikacija
                client.Send(message); // <-- nurodymas siųsti
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                client.Disconnect(true); // <-- atsijungiama
                client.Dispose();        // <-- trinamas objektas
            }
        }
    }
}

// DotNetSendingEmail@gmail.com
// qio-778-211