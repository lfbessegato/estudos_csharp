using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo01_Structs
{
    struct Point
    {
        public double X, Y;
        public override string ToString()
        {
            return "(" + X + "," + Y + ")";
        }
    }
}

