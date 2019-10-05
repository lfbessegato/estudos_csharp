﻿using System;
using System.IO;

namespace Exemplo03_FileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Treinamento\C Sharp\Projeto\Secao13\Exemplos\Exemplo03_FileStream\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                fs = new FileStream(path, FileMode.Open); // File.OpenRead(path);
                sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
        }
    }
}
