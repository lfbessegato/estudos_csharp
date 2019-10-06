using System;
using Exemplo02_Delegates.Services;

namespace Exemplo02_Delegates
{
    delegate double BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            // BinaryNumericOperation op = CalculationService.Sum;
            BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum);
            double result1 = op(a, b);
            double result2 = op.Invoke(a, b);
            Console.WriteLine(result1);
            Console.WriteLine(result2);

            //O método Square não casa com a assintatura delegate definida acima
            //BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Square);
        }
    }
}
