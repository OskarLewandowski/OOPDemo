﻿using System;
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
    }
}
