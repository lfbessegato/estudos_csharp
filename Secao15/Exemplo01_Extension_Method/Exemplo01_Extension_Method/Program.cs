using System;

namespace Exemplo01_Extension_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt1 = new DateTime(2019, 10, 05, 8, 10, 45);
            DateTime dt2 = new DateTime(2019, 10, 03, 8, 10, 45);
            Console.WriteLine(dt1.ElapsedTime());
            Console.WriteLine(dt2.ElapsedTime());

            Console.WriteLine("-----------------");
            String s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));
        }
    }
}
