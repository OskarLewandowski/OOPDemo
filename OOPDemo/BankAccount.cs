using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    public class BankAccount
    {
        //if field is private we write it be lower case
        protected float balance;

        //this is the same
        public string Name { get; set; }
        //private string name;
        //public void SetName(string name)
        //{
        //    this.name = name;
        //}

        //public string GetName()
        //{
        //    return this.name;
        //}

        public void MakeDeposit(float amount)
        {
            if (amount < 0)
            {
                throw new Exception("Amount must be positive number");
            }

            balance += amount;
        }

        public virtual void MakeWithdraw(float amount)
        {
            if (amount < 0)
            {
                throw new Exception("Amount must be positive number");
            }

            balance -= amount;
        }

        public void SetBalance(float amount)
        {
            if (amount < 0)
            {
                throw new Exception("Amount must be positive number");
            }

            balance = amount;
        }

        public float GetBalance()
        {
            return balance;
        }
    }
}
