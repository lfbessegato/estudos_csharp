using System;
using System.Collections.Generic;
using System.IO;

namespace Exemplo04_Motivador
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Treinamento\C Sharp\Projeto\Secao14\Exemplos\Exemplo04_Motivador\Exemplo04_Motivador\in.txt";
            try
            {
                using (System.IO.StreamReader sr = File.OpenText(path))
                {
                    List<string> list = new List<string>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(sr.ReadLine());
                    }
                    list.Sort();
                    foreach (string str in list)
                    {
                        Console.WriteLine(str);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
