using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    public class EmailSenderAsAbstract
    {
        public void SentEmail(string to, string title, string body)
        {
            ConnectToSmtpServer();
            InsertCredentials();
            Console.WriteLine($"Sending email to: {to}\nTitle: {title}\nMessage: {body}");

            Disconnect();
        }

        private void ConnectToSmtpServer()
        {
            Console.WriteLine("Connecting to smtp server");
        }

        private void InsertCredentials()
        {
            Console.WriteLine("Inserting credentials");
        }

        private void Disconnect()
        {
            Console.WriteLine("Disconnected from the server credentials");
        }
    }
}
