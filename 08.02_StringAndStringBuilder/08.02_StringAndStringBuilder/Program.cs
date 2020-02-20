using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._02_StringAndStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s1 = "ABC";
            //string s2 = s1;
            //Console.WriteLine(s1 == s2);
            //s2 += "D";
            //Console.WriteLine(s2);
            //Console.WriteLine(s1);
            //Console.WriteLine(s1==s2);

            string s = "";
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            Console.WriteLine("Start");
            for (int i = 0; i < 100000; i++)
            {
                s += "A";
            }
            Console.WriteLine("Stop");
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds + "ms");

            System.Diagnostics.Stopwatch ssw = new System.Diagnostics.Stopwatch();
            ssw.Start();
            Console.WriteLine("Start with SB");
            StringBuilder sb = new StringBuilder();
            for (int j = 0; j < 100000; j++)
            {
                sb.Append("A");
            }
            string ss = sb.ToString();
            Console.WriteLine("Stop with SB");
            ssw.Stop();
            Console.WriteLine(ssw.ElapsedMilliseconds + "ms");
        }
    }
}
