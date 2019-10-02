using System;

namespace Exemplo01_Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p;
            // console.Writeln(p); -> Apresenta erro pois não foi inicializada
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);
            p = new Point(); // Inicia com zeros
            Console.WriteLine(p);
        }
    }
}
