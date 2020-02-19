using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._02_Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 1;
            int a;
            //Console.WriteLine("a = {0}", a);
            //Calculate(a);
            //Calculate(ref a);
            Calculate(out a);
            Console.WriteLine("a = {0}", a);
        }

        ////Vstupni
        //static void Calculate(int p)
        //{
        //    p++;
        //    Console.WriteLine("p = {0}", p);
        //}

        ////Vstupne vystupni
        //static void Calculate(ref int p)
        //{
        //    p++;
        //    Console.WriteLine("p = {0}", p);
        //}

        //vystupni
        static void Calculate(out int p)
        {
            p = 2;
            Console.WriteLine("p = {0}", p);
        }
    }
}
