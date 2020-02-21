using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._02_PropertiesAndIndexers
{
    class WeekDayNames
    {
        string[] weekDayFullNames =
        {
            "Sun",
            "Mon",
            "Tue",
            "Wen",
            "Fri",
            "Sat"
        };

        private int _currentWeekDayIndex;

        public int currentWeekDayIndex
        {
            get { return _currentWeekDayIndex; }
            set { _currentWeekDayIndex = value; }
        }

        public string currentWeekDayName
        {
            get
            {
                return weekDayFullNames[_currentWeekDayIndex];
            }
        }

        public string this[int index]
        {
            get
            {
                return weekDayFullNames[index];
            }
        }
        string[] weekDayShortNames = { "S", "M", "T", "W", "T", "F", "S" };
        public string this[string name]
        {
            get
            {
                return weekDayFullNames[Array.IndexOf(weekDayShortNames, name)];
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            WeekDayNames weekDays = new WeekDayNames();
            weekDays.currentWeekDayIndex = 1;
            Console.WriteLine(weekDays.currentWeekDayName);
            Console.WriteLine(weekDays[1]);
            Console.WriteLine(weekDays["M"]);
        }
    }
}
