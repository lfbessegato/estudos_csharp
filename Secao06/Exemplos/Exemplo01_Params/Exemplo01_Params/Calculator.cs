using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo01_Params
{
    class Calculator
    {
        public static int Sum(params int[] numbers) //Parametros variaveis
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
