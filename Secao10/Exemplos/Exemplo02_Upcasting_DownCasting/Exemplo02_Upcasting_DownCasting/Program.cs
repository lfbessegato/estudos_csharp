using System;
using Exemplo02_Upcasting_DownCasting.Entities;

namespace Exemplo02_Upcasting_DownCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            // UPCASTING

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            // DOWNCASTING -> É uma operação insegura para isso precisa testar

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

            // BusinessAccount acc5 = (BusinessAccount)acc3;
            if (acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3; //Pois Savings é diferente de BusinessAccount
                BusinessAccount acc5 = acc3 as BusinessAccount; //Outra forma de fazer downcasting
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount; //Outra forma de fazer downcasting
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
        }
    }
}
