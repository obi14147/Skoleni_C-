using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._03_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(10, 20));
            //Console.WriteLine(Sum(10, Sum(20, 30)));

            Console.WriteLine(Sum(10, 20, 30));
          }

        static int Sum(int a, int b)
        {
            return a + b;
        }
        static int Sum(int a, int b, int c)
        {
            return Sum(a, Sum(b, c)) ;
        }
        static long Sum(long x, long y)
        {
            return x + y;
        }
    }
}
