using System;
using System.Globalization;

namespace ExemploSaida
{
    class Program
    {
        static void Main(string[] args)
        {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.Write("Bom dia!");
            Console.WriteLine("Boa Tarde!");
            Console.WriteLine("Boa Noite!");
            Console.WriteLine("--------------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);

            Console.WriteLine("----- Formatando a variavel -----------");
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));

            // independente de Pais utiliza o separador de casas decimais como "."
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));


            // PlaceHolders = lugar para entrar variavel
            Console.WriteLine("------ Exemplo de PlaceHolders ------");
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais.", nome, idade, saldo);
            
            //Interpolação
            Console.WriteLine();
            Console.WriteLine("------ Exemplo de Interpolação -------");
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais.");

            //Concatenação a formatação com . para separar casas decimais, so funciona com o ToString
            Console.WriteLine();
            Console.WriteLine("------ Exemplo de Concatenação -------");
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");

        }
    }
}
