using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._04_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter number:");
            //int number = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter number:");
            //int number;
            //bool isNumber = int.TryParse(Console.ReadLine(), out number);
            //if (!isNumber)
            //{
            //    Console.WriteLine("Not a number");
            //}

            Console.WriteLine("Enter number:");
            int number = Convert.ToInt32(Console.ReadLine());

            //long lngNumber = (long)number;
            long lngNumber = number;


            Console.ReadKey();
        }
    }
}
