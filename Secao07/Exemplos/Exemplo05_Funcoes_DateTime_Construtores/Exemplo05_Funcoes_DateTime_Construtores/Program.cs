using System;

namespace Exemplo05_Funcoes_DateTime_Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2000, 8, 15);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58, 275);

            DateTime d4 = DateTime.Now;  //Agora
            DateTime d5 = DateTime.UtcNow; //Horário UTC
            DateTime d6 = DateTime.Today; //Today na zero hora


            Console.WriteLine(d1); 
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
        }
    }
}
