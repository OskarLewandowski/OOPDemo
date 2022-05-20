using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    public class EmailSender
    {
        public void ConnectToSmtpServer()
        {
            Console.WriteLine("Connecting to smtp server");
        }

        public void InsertCredentials()
        {
            Console.WriteLine("Inserting credentials");
        }

        public void SentEmail(string to, string title, string body)
        {
            Console.WriteLine($"Sending email to: {to}\nTitle: {title}\nMessage: {body}");
        }

        public void Disconnect()
        {
            Console.WriteLine("Disconnected from the server credentials");
        }
    }
}
