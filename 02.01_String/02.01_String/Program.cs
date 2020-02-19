using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._01_String
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("A");
            //Console.WriteLine("B");
            //Console.WriteLine("C");
            //Console.WriteLine();

            //Console.WriteLine("A" + "B" + "C");
            //Console.WriteLine("ABC");

            //Console.WriteLine();
            //Console.WriteLine("AB\rC");

            //Console.WriteLine();
            //Console.WriteLine("A\nB\nC");

            //Console.WriteLine();
            //Console.WriteLine("A\r\nB\r\nC");

            //Console.WriteLine();
            //Console.WriteLine("A"+Environment.NewLine+"B" + Environment.NewLine + "C");

            ////Console.WriteLine();
            ////Console.WriteLine("<a href="http://www.gopas.cz">Počítačová škola Gopas</a>");

            //Console.WriteLine();
            //Console.WriteLine("<a href=\"http://www.gopas.cz\">Počítačová škola Gopas</a>");

            ////Console.WriteLine();
            ////Console.WriteLine("C:\Windows\System32\drivers");

            //Console.WriteLine();
            //Console.WriteLine("C:\\Windows\\System32\\drivers");

            //Console.WriteLine();
            //Console.WriteLine(@"C:\Windows\System32\drivers");

            //Console.WriteLine();
            //Console.WriteLine(@"A\r\nB\r\nC");

            ////Console.WriteLine();
            ////Console.WriteLine(@"Say "Hello"");

            ////Console.WriteLine();
            ////Console.WriteLine(@"Say \"Hello\"");

            //Console.WriteLine();
            //Console.WriteLine(@"Say ""Hello""");

            Console.WriteLine();
            Console.WriteLine("x="+10+", y="+20);

            Console.WriteLine();
            Console.WriteLine(string.Format("x={0}, y={1}", 10, 20));

            Console.WriteLine();
            Console.WriteLine(string.Format("x={0:0.00}, y={1:C}", 10, 20));

            Console.WriteLine();
            Console.WriteLine(string.Format("{0:0000}", 20));
            Console.WriteLine(string.Format("{0:0000}", 1));
            Console.WriteLine(string.Format("{0:0000}", 4321));
            Console.WriteLine(string.Format("{0:0000}", 87));

            Console.WriteLine();
            Console.WriteLine(string.Format("{0} + {0}", 20, 10));

            Console.WriteLine();
            Console.WriteLine(string.Format("{0} {1}", "Name", "Value"));
            Console.WriteLine(string.Format("{0} {1}", "Petr", "10"));
            Console.WriteLine(string.Format("{0} {1}", "Jan", "5"));
            Console.WriteLine(string.Format("{0} {1}", "Jakub", "123456"));

            Console.WriteLine();
            Console.WriteLine(string.Format("{0,10} {1,8}", "Name", "Value"));
            Console.WriteLine(string.Format("{0,10} {1,8}", "Petr", "10"));
            Console.WriteLine(string.Format("{0,10} {1,8}", "Jan", "5"));
            Console.WriteLine(string.Format("{0,10} {1,8}", "Jakub", "123456"));

            Console.WriteLine();
            Console.WriteLine(string.Format("{0,-10} {1,8}", "Name", "Value"));
            Console.WriteLine(string.Format("{0,-10} {1,8}", "Petr", "10"));
            Console.WriteLine(string.Format("{0,-10} {1,8}", "Jan", "5"));
            Console.WriteLine(string.Format("{0,-10} {1,8}", "Jakub", "123456"));

            Console.WriteLine();
            Console.WriteLine(string.Format("{0,-10} {1,8:0.00}", "Name", "Value"));
            Console.WriteLine(string.Format("{0,-10} {1,8:0.00}", "Petr", "10"));
            Console.WriteLine(string.Format("{0,-10} {1,8:0.00}", "Jan", "5"));
            Console.WriteLine(string.Format("{0,-10} {1,8:0.00}", "Jakub", "123456"));

            Console.ReadKey();
        }
    }
}
