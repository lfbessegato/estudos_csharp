﻿using System;
using Exemplo05_Classes_Abstratas.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace Exemplo05_Classes_Abstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Apesar da classe ser abstrata, pode realizar uma lista de Accounts.
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.00, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1004, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1005, "Anna", 500.0, 500.0));

            double sum = 0.0;
            foreach (Account acc in list)
            {
                sum += acc.Balance;
            }

            Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            //Polimorfes
            foreach (Account acc in list)
            {
                acc.Withdraw(10.0);
            }
            
            foreach (Account acc in list)
            {
                Console.WriteLine("Updated balance for account "
                    + acc.Number
                    + ": "
                    + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
