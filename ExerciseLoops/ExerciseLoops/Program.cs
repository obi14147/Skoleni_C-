using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            ////EXERCISE I:
            //int i = 1;
            //Console.WriteLine("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //while (i <= 10)
            //{
            //    Console.WriteLine("{0} * {1} = {2}", i, number, i++ * number);
            //}

            //EXERCISE II:
            int j = 1;
            Console.WriteLine("Enter a first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            for (int num = firstNumber; num <= secondNumber; num++)
            {
                Console.WriteLine("Multiplication of number: {0}", num);
                while (j <= 10)
                {
                    Console.WriteLine("{0} * {1} = {2}", j, num, j++ * num);
                }
                Console.WriteLine();
                j = 1;
            }

            Console.ReadKey();
        }
    }
}
