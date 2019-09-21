using System;

namespace Exemplo01_Escopo_Inicializacao
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine());
            // Para corrigir o porblema do escopo
            double desconto = 0.0;

            if (preco > 100.0) {
                //Dessa forma a variavel desconto pertence ao escopo do If
                //double desconto = preco * 0.1;
                desconto = preco * 0.1;
            }

            Console.WriteLine(desconto);
        }
    }
}
