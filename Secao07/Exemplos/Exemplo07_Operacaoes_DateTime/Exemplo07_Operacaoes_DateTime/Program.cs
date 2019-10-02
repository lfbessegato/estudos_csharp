using System;

namespace Exemplo07_Operacaoes_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime x = new DateTime(2001, 8, 15, 13, 45, 58);

            DateTime y = x.AddDays(7);
            Console.WriteLine(x);
            Console.WriteLine(y);

        }
    }
}
