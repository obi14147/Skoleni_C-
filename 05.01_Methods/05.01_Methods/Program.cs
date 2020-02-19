using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._01_Methods
{
    class Program
    {
        //static int a, b, c;
        static void Main(string[] args)
        {
            int a, b;
            //Console.WriteLine("Enter A:");
            //a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter B:");
            //b = int.Parse(Console.ReadLine());
            //Sum();
            //Console.WriteLine("{0} + {1} = {2}", a, b, c);

            Console.Write("Enter A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter B: ");
            b = int.Parse(Console.ReadLine());
            //c = Sum();
            //Console.WriteLine("{0} + {1} = {2}", a, b, c);
            //Console.WriteLine("{0} + {1} = {2}", a, b, Sum());
            Console.WriteLine("{0} + {1} = {2}", a, b, Sum(a, b));
        }

        //static void Sum()
        //{
        //    c = a + b;
        //}
        static int Sum(int a, int b)
        {
            return a + b;
        }

    }
}
