using System;

namespace Exemplo05_Funcoes_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);
        }
    }
}
