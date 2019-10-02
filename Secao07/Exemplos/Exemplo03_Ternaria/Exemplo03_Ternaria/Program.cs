using System;
using System.Globalization;

namespace Exemplo03_Ternaria
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = 34.5;
            /* double desconto;
            if (preco < 20.0)
            {
                desconto = preco * 0.1;
            }
            else
            {
                desconto = preco * 0.05;
            }
            */
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
            Console.WriteLine(desconto);
        }
    }
}
