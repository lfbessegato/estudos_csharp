using System;
using System.IO;

namespace Exemplo07_StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"D:\Treinamento\C Sharp\Projeto\Secao13\Exemplos\Exemplo07_StreamWriter\file1.txt";
            string targetPath = @"D:\Treinamento\C Sharp\Projeto\Secao13\Exemplos\Exemplo07_StreamWriter\file2.txt";
            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
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
