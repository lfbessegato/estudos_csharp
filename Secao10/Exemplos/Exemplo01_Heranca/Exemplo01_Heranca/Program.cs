using System;
using Exemplo01_Heranca.Entities;

namespace Exemplo01_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);

            Console.WriteLine(account.Balance);

            //account.Balance = 200.0; // error - pois está definido como preotected só permite alteração na super e subclasse
            
        }
    }
}
