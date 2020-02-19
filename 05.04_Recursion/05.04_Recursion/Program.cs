using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._04_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Factorial of number {0} is {1}", number, Factorial(number));
        }

        static int Factorial(int currentNumber)
        {
            if (currentNumber <= 1)
            {
                return 1;
            }
            return currentNumber * Factorial(currentNumber - 1);

            //int result = currentNumber;
            //for (int i = 1; i < currentNumber; i++)
            //{
            //    result = result * i;
            //}
            //return result;
        }
    }
}
