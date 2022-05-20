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

        public override void MakeWithdraw(float amount)
        {
            Console.WriteLine("Personal bank account withdrawal");
            if (amount < 0)
            {
                throw new Exception("Amount must be positive number");
            }

            if ((balance - amount) < 0)
            {
                throw new Exception("Personal bank account cannot go in debt");
            }

            balance -= amount;
        }
    }
}
