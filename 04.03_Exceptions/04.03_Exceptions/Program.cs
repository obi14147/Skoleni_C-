using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._03_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Calculate();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException.Message);
            }

        }
        static void Calculate()
        {
            try
            {
                Console.WriteLine("Enter A:");
                int numberA = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter B:");
                int numberB = int.Parse(Console.ReadLine());
                Console.WriteLine("{0} / {1} = {2}", numberA, numberB, numberA / numberB);
            }
            catch (System.DivideByZeroException ex)
            {
                Console.WriteLine("Chyba deleni nulou");
                throw new Exception("Chyba v calculate()", ex);
            }
            catch (System.OverflowException ex)
            {
                Console.WriteLine("Hodnota je mimo rozsah " + int.MinValue + " az " + int.MaxValue);
            }
            //catch (System.Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

        }

    }
}
