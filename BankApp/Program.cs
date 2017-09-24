﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = Bank.CreateAccount("test@test.com", TypeOfAccount.Savings);
            Console.WriteLine($"AN: {account.AccountNumber}, EA: {account.EmailAddress}, Balance: {account.Balance:C}, AT: {account.AccountType}");

            var account2 = Bank.CreateAccount("test2@test.com", initialDeposit:500);
            Console.WriteLine($"AN: {account2.AccountNumber}, EA: {account2.EmailAddress}, Balance: {account2.Balance:C}, AT: {account2.AccountType}");

        }
    }
}
