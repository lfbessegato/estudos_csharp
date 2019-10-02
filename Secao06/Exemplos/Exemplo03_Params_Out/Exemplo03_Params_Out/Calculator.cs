using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo03_Params_Out
{
    class Calculator
    {
        public static void Triple(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
