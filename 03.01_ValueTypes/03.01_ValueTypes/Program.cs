using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._01_ValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a;
            //a = 0;
            //Console.WriteLine("a = {0}", a);

            //int a= 0;
            //int b = 1;
            //Console.WriteLine("a = {0}, b = {1}", a, b);

            //int a = 0,
            //    b = 1;
            //Console.WriteLine("a = {0}, b = {1}", a, b);

            //int a = 0;
            //int b = 1;
            //a = a + b;
            //Console.WriteLine("a = {0}, b = {1}", a, b);

            //int a = 0;
            //int b = 1;
            //a += b;
            //Console.WriteLine("a = {0}, b = {1}", a, b);

            //int a = 0;
            //int b = 1;
            //a++;
            //b++;
            //Console.WriteLine("a = {0}, b = {1}", a, b);

            int a = 0;
            int b = 1;
            Console.WriteLine("a = {0}, b = {1}", ++a, ++b);
            Console.WriteLine("a = {0}, b = {1}", a, b);

            //Console.WriteLine(a = b);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine((a > 10) && (b < 10));
            Console.WriteLine((a > 10) || (b < 10));
            
            Console.ReadKey();
        }
    }
}
