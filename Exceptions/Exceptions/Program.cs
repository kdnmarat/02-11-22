using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class EmptyStringException : Exception
    {
        public EmptyStringException(string message) : base(message)
        {
        }
    }

    internal class Program
    {
        public static int GetNumberFromConsole()
        {
            int result;
            string entry;
            Console.Write("Please type a numeric value: ");
            entry = Console.ReadLine();
            if (entry.Length <= 0)
            {
                throw (new EmptyStringException("The string is empty!"));
            }
            try
            {
                result = int.Parse(entry);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error while trying to parse the value as Int!");
                throw;
            }
            return result;
        }

        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("Please enter two integer arguments:");
            Console.WriteLine("A = ");
            try
            {
                a = GetNumberFromConsole();
            }
            catch (EmptyStringException e)
            {
                Console.WriteLine($"You didn't enter any value!\nErrorMessage: {e.Message}\nStackTrace: {e.StackTrace}");
                Console.ReadKey();
                return;
            }
            catch (System.FormatException e)
            {
                Console.WriteLine($"The value is not in Integer format!\nErrorMessage: {e.Message}\nStackTrace: {e.StackTrace}");
                Console.ReadKey();
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unhandled exception!\nErrorMessage: {e.Message}\nStackTrace: {e.StackTrace}");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("B = ");
            try
            {
                b = GetNumberFromConsole();
            }
            catch (EmptyStringException e)
            {
                Console.WriteLine($"You didn't enter any value!\nErrorMessage: {e.Message}\nStackTrace: {e.StackTrace}");
                Console.ReadKey();
                return;
            }
            catch (System.FormatException e)
            {
                Console.WriteLine($"The value is not in Integer format!\nErrorMessage: {e.Message}\nStackTrace: {e.StackTrace}");
                Console.ReadKey();
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unhandled exception!\nErrorMessage: {e.Message}\nStackTrace: {e.StackTrace}");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("A + B = {0}", Calculator.OperationPlus(a, b));
            Console.WriteLine("A - B = {0}", Calculator.OperationMinus(a, b));
            Console.WriteLine("A * B = {0}", Calculator.OperationMultiply(a, b));
            try
            {
                Console.WriteLine("A / B = {0}", Calculator.OperationDivide(a, b));
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"You are trying to divide by zero! No-no-no!\nErrorMessage: {e.Message}\nStackTrace: {e.StackTrace}");
                Console.ReadKey();
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unhandled exception!\nErrorMessage: {e.Message}\nStackTrace: {e.StackTrace}");
                Console.ReadKey();
                return;
            }
            Console.ReadKey();
        }
    }
}
