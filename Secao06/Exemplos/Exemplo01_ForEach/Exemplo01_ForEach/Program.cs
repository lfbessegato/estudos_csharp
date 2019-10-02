using System;

namespace Exemplo01_ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria", "Bob", "Alex" };

            //Para percorrer o vetor e imprimir na Tela
            foreach(String obj in vect){
                Console.WriteLine(obj);
            }
        }
    }
}
