using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    public class PersonalBankAccount : BankAccount
    {
        public void RequestPersonalLoan()
        {
            Console.WriteLine("Making request...");
        }
    }
}
