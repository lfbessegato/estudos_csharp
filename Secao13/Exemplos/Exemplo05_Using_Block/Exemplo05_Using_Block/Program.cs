using System;
using System.IO;

namespace Exemplo05_Using_Block
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Treinamento\C Sharp\Projeto\Secao13\Exemplos\Exemplo05_Using_Block\file1.txt";
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
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
