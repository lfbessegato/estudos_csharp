using System;
using Exemplo03_Sobreposicao.Entities;

namespace Exemplo03_Sobreposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar
            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}
