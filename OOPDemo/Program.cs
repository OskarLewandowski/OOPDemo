using System;

namespace OOPDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Oskar";
            Console.WriteLine($"Hello {person.Name}");

            Person person1 = new Person("Oskar1");
            Console.WriteLine($"Hello {person1.Name}");

            person.SayHi();
            person1.SayHi();

            //interface
            IPrinter printer = GetPrinter();
            printer.Print("Some content");

            //encapsulation
            BankAccount account = new BankAccount();
            //we can't change value of this properties because is private
            //we can when is be public but this is bad practice
            //account.Balance = 9999999f;
            Console.WriteLine($"Actual amount: {account.GetBalance()}");
            account.SetBalance(99999);
            Console.WriteLine($"Actual amount: {account.GetBalance()}");
            account.MakeWithdraw(999);
            Console.WriteLine($"Actual amount: {account.GetBalance()}");
            account.MakeDeposit(25);
            Console.WriteLine($"Actual amount: {account.GetBalance()}");

            //account.SetName("Some bank account");
            //Console.WriteLine(account.GetName());
            account.Name = "Some bank account1";
            Console.WriteLine(account.Name);

            //Inheritance
            Console.WriteLine("\nInheritance:");
            PersonalBankAccount personalBankAccount = new PersonalBankAccount();
            personalBankAccount.SetBalance(23456);
            Console.WriteLine($"Actual amount: {personalBankAccount.GetBalance()}");
            personalBankAccount.MakeWithdraw(456);
            Console.WriteLine($"Actual amount: {personalBankAccount.GetBalance()}");
            personalBankAccount.MakeDeposit(25);
            Console.WriteLine($"Actual amount: {personalBankAccount.GetBalance()}");

            //only for PersonalBankAccount 
            //account.RequestPersonalLoan();
            personalBankAccount.RequestPersonalLoan();

            CompanyBankAccount companyBankAccount = new CompanyBankAccount();
            companyBankAccount.SetBalance(1_000_000);
            Console.WriteLine($"Actual amount: {companyBankAccount.GetBalance()}");
            companyBankAccount.MakeWithdraw(500000);
            Console.WriteLine($"Actual amount: {companyBankAccount.GetBalance()}");
            companyBankAccount.TakeLoan(250000);
            Console.WriteLine($"Actual amount: {companyBankAccount.GetBalance()}");

            //Polymorphism
            Console.WriteLine("\nPolymorphism:");
            BankAccount bank = GetBankAccount();
            bank.MakeWithdraw(2222);
            Console.WriteLine($"Actual amount: {bank.GetBalance()}");

            Console.ReadLine();
        }

        static BankAccount GetBankAccount()
        {
            //var bankAccount = new PersonalBankAccount();
            var bankAccount = new CompanyBankAccount();
            bankAccount.MakeDeposit(1000);

            return bankAccount;
        }

        static IPrinter GetPrinter()
        {
            //return new Hp();
            return new Canon();
        }
    }
}
