using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte x = 100;
            // Variável do dotnet SByte

            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';

            byte n1 = 254;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648;

            float n5 = 4.5f;
            double n6 = 4.6;
            string nome = "Maria Green";
            object obj1 = "Alex Brown";
            object obj2 = 4.5f;

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            
            Console.WriteLine(x);
            Console.WriteLine(n1);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);

            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            int n8 = int.MinValue;
            int n9 = int.MaxValue;
            sbyte n10 = sbyte.MinValue;
            decimal n11 = decimal.MaxValue;

            Console.WriteLine(n8);
            Console.WriteLine(n9);
            Console.WriteLine(n10);
            Console.WriteLine(n11);

            n1++;
            Console.WriteLine(n1);
        }
    }
}
