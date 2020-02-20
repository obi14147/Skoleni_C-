using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._01_Construcotrs
{
    class MyClass
    {
        public int i;
    }

    class Date
    {
        public int Year, Month, Day;
        public readonly int DaysInMonth;
        //public readonly int WeekDayCount;
        public const int WeekDayCount = 7;

        public Date(int day, int month, int year)
        {
            this.Day = day;
            this.Month = month;
            this.Year = year;
            this.DaysInMonth = DateTime.DaysInMonth(this.Year, this.Month);
            //this.WeekDayCount = 7;

        }

        public Date()
            :this(1, 1, 3333)
        {
             //this.Day = 1;
            //this.Month = 1;
            //this.Year = 2000;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            //Console.WriteLine(mc.i);

            Date d = new Date(1, 1, 2000);
            //d.Day = 1;
            //d.Month = 1;
            //d.Year = 2000;
            Console.WriteLine("{0:D}.{1:D2}.{2:D4}", d.Day, d.Month, d.Year);
            Date d2 = new Date();
            Console.WriteLine("{0:D}.{1:D2}.{2:D4}", d2.Day, d2.Month, d2.Year);
            Console.WriteLine(d.DaysInMonth);
            //Console.WriteLine(d.WeekDayCount);
            Console.WriteLine(Date.WeekDayCount);

        }
    }
}
