using System;

namespace Exemplo06_AutoProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 900.0, 10);

            //Obter o Nome utilizando o método Properties
            Console.WriteLine(p.Nome);

            //Alterar o nome do produto no atributo Nome
            p.Nome = "TV 4K";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);
        }
    }
}
