using System;

namespace Secao_03_Exercicio_For_Resolvido01
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int resultado = i * N;
                Console.WriteLine(i + " x " + N + " = " + resultado);
            }

            Console.ReadLine();
        }
    }
}
