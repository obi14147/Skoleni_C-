using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseCommandLine
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string item in args)
            {
                if (item=="/?")
                {
                    ShowHelp();
                }
                else if (item == "/d")
                {
                    Console.WriteLine();
                    //Console.WriteLine("Current date: {0}",DateTime.Now.Date);
                    Console.WriteLine("Current date: {0}/{1}/{2}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
                }
                else if (item == "/t")
                {
                    Console.WriteLine();
                    //Console.WriteLine("Current time: {0}", DateTime.Now.TimeOfDay);
                    Console.WriteLine("Current time: {0}:{1}:{2}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                }
            }
        }

        static void ShowHelp()
        {
            Console.WriteLine();
            Console.WriteLine("Copyright (c) Gopas. All rights reserved. \n\nUsage: datetool [options] [options]\n\n" +
                "Options:\n" +
                "/?     Shows this help\n" +
                "/d     Shows current date\n" +
                "/t     Shows current time");
        }
    }
}
