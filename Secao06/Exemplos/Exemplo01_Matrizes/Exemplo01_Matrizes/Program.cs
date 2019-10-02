using System;

namespace Exemplo01_Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2, 3]; //[Linha, Coluna

            //propriedade para verificar quanto elementos tem na Matriz no total
            Console.WriteLine(mat.Length);

            //Quanto é primeira dimensão da Matriz - Qtd de Linhas
            Console.WriteLine(mat.Rank);

            //o tamanho da matrix na primeira dimensão -no exemplo 2 (linhas)
            Console.WriteLine(mat.GetLength(0));

            //O tamanho da matrix na segunda dimensão - no exemplo 3 (colunas)
            Console.WriteLine(mat.GetLength(1));
        }
    }
}
