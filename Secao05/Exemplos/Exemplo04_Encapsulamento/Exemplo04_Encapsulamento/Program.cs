using System;
using System.Globalization;

namespace Exemplo04_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 900.0, 10);

            //Obter o Nome
            Console.WriteLine(p.GetNome());

            //Alterar o nome do produto no atributo Nome
            p.SetNome("TV 4K");
            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
            Console.WriteLine(p.GetQuantidade());
        }
    }
}
