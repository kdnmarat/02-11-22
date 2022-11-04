using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        public static int GetNumberFromConsole()
        {
            int result;
            string entry;
            do
            {
                Console.Write("Please type a numeric value: ");
                entry = Console.ReadLine();
            }
            while (!int.TryParse(entry, out result));
            return result;
        }

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
            return (float)a / (float)b;
        }

        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("Please enter two integer arguments:");
            Console.WriteLine("A = ");
            a = GetNumberFromConsole();
            Console.WriteLine("B = ");
            b = GetNumberFromConsole();
            Console.WriteLine("A + B = {0}", OperationPlus(a, b));
            Console.WriteLine("A - B = {0}", OperationMinus(a, b));
            Console.WriteLine("A * B = {0}", OperationMultiply(a, b));
            Console.WriteLine("A / B = {0}", OperationDivide(a, b));
            Console.ReadKey();
        }
    }
}
