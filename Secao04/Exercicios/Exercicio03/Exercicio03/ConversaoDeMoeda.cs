using System;
using System.Globalization;

namespace Exercicio03
{
    class ConversaoDeMoeda
    {
        public static double iof = 6.0;

        public static double DolarParaReal(double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            return total + total * iof / 100.0;
        }
    }
}
