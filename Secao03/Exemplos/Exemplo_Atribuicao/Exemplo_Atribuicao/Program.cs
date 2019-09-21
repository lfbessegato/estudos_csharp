using System;

namespace Exemplo_Atribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s);

            //Atribuicao
            a = 10;
            a++;
            Console.WriteLine(a);

            a--;
            Console.WriteLine(a);

            a = 10;
            int b = a++;
            Console.WriteLine(a);
            Console.WriteLine(b);

            a = 10;
            b = ++a;
            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}
