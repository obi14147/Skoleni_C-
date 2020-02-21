using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._01_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Timers.Timer timer1 = new System.Timers.Timer();
            timer1.Interval = 1000;
            timer1.Elapsed += Timer1_Elapsed;
            timer1.Enabled = true;

            System.Timers.Timer timer2 = new System.Timers.Timer();
            timer2.Interval = 3000;
            timer2.Elapsed += Timer2_Elapsed;
            timer2.Enabled = true;

            Console.ReadKey();
        }
        private static void Timer2_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("World");
            ((System.Timers.Timer)sender).Enabled = false;
        }

        private static void Timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("Hello");
        }
    }
}
