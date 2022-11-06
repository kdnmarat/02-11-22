using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class Calculator
    {
        public static int OperationPlus(int a, int b)
        {
            return a + b;
        }

        public static int OperationMinus(int a, int b)
        {
            return a - b;
        }

        public static int OperationMultiply(int a, int b)
        {
            return a * b;
        }

        public static float OperationDivide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("You can't divide by zero!");
            }
            return (float)a / (float)b;
        }
    }
}
