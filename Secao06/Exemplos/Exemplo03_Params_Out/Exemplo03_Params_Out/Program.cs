using System;

namespace Exemplo03_Params_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int triple;
            Calculator.Triple(a, out triple);
            Console.WriteLine("Out: " + triple);
            Console.WriteLine("in: " + a);
        }
    }
}
