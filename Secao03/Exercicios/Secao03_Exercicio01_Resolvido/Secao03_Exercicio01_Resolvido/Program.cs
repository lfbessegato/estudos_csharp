using System;
using System.Globalization;

namespace Secao03_Exercicio01_Resolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento, precoMetroQuadrado, area, preco;

            largura = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            comprimento = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            precoMetroQuadrado = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;
            preco = area * precoMetroQuadrado;

            Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PRECO = " + preco.ToString("F2", CultureInfo.InvariantCulture)); ;

        }
    }
}
