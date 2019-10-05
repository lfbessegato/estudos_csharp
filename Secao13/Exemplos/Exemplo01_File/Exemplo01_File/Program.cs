using System;
using System.IO;

namespace Exemplo01_File
{
    class Program
    {
        static void Main(string[] args)
        {
            // o @ -> para tirar a obrigação de \\ para os diretórios
            string sourcePath = @"D:\Treinamento\C Sharp\Projeto\Secao13\Exemplos\Exemplo01_File\file1.txt";
            string targetPath = @"D:\Treinamento\C Sharp\Projeto\Secao13\Exemplos\Exemplo01_File\file2.txt";
            try
            {
                File.Copy(sourcePath, targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
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
