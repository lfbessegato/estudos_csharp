using System;
using System.IO;

namespace Exemplo02_FileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"D:\Treinamento\C Sharp\Projeto\Secao13\Exemplos\Exemplo02_FileInfo\file1.txt";
            string targetPath = @"D:\Treinamento\C Sharp\Projeto\Secao13\Exemplos\Exemplo02_FileInfo\file2.txt";
            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
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
