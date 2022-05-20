using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    public class CompanyBankAccount : BankAccount
    {
        public void TakeLoan(float amount)
        {
            this.MakeDeposit(amount);
        }

        public override void MakeWithdraw(float amount)
        {
            Console.WriteLine("Make withdrawal for company bank account");
            if (amount < 0)
            {
                throw new Exception("Amount must be positive number");
            }

            balance -= amount;
        }
    }
}
