using System;
using System.Collections.Generic;

namespace Exemplo01_Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar os conjuntos
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            //Adcionar elementos
            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(3);
            B.Add(4);
            B.Add(5);

            //Conjunto não tem indice
            foreach(int x in A)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("----------------");
            Console.WriteLine();
            foreach (int x in B)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("Digite um valor inteiro: ");
            int N = int.Parse(Console.ReadLine());

            if (B.Contains(N))
            {
                Console.WriteLine(N + " Pertence ao conjunto B");
            }
            else
            {
                Console.WriteLine(N + " Não pertence ao conjunto B");
            }

            B.Remove(4);
            foreach (int x in B)
            {
                Console.WriteLine(x);
            }

        }
    }
}
