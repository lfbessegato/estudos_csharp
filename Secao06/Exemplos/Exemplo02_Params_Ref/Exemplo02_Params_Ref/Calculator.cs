using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo02_Params_Ref
{
    class Calculator
    {
        //Ref -> devolve para a variavel gloabl o valor calculado
        public static void Triple(ref int x)
        {
            x = x * 3;
        }
    }
}
