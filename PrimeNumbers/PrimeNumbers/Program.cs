using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number;
            
            bool isNumber = int.TryParse(Console.ReadLine(), out number);
            if (!isNumber)
            {
                Console.WriteLine("{0} isn't a number.", number);
                Console.ReadKey();
                Environment.Exit(1);
            }

            if (number <= 0)
            {
                Console.WriteLine("Number {0} isn't prime numbers.", number);
                Console.ReadKey();
                Environment.Exit(1);
            }

            //int number = Convert.ToInt32(Console.ReadLine());
            int i = 2;
            bool primeNumber = true;

            if (number % 2 == 0 && number !=2)
            {
                Console.WriteLine("Number {0} isn't prime numbers.", number);
            }
            else
            {
                while (i != number)
                {
                    i++;
                    if (number % i == 0 && number != i)
                    {
                        Console.WriteLine("Number {0} isn't prime numbers.", number);
                        primeNumber = false;
                        break;
                    }
                }
                if (primeNumber == true) Console.WriteLine("Number {0} is prime numbers.", number);
            }
            Console.ReadKey();
        }
    }
}
