using Exemplo03_IComparable;
using System;
using System.Collections.Generic;
using System.IO;

namespace Exemplo04_Motivador
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Treinamento\C Sharp\Projeto\Secao14\Exemplos\Exemplo03_IComparable\Exemplo03_IComparable\in.txt";
            try
            {
                using (System.IO.StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
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
