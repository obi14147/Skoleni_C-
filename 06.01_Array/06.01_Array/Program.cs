using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._01_Array
{
    struct Employee
    {
        public string FirstName;
        public string LastName;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //int[] list = new int[4];
            //list[0] = 10;
            //list[1] = 20;
            //list[2] = 30;
            //list[3] = 40;

            //int[] list = new int[4] { 10, 20, 30, 40};

            //int[] list = { 10, 20, 30, 40 };

            //for (int i = 0; i < list.Length; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            //foreach (int item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //string[] weekDays = { "Sun", "Mon", "Tue", "Wen", "Thu", "Fri", "Sat" };
            //Console.WriteLine(weekDays[(int)DateTime.Now.DayOfWeek]);

            Employee[] employees = new Employee[4];
            for (int i = 0; i < employees.Length; i++)
            {
                Console.Write("Enter a first name: ");
                employees[i].FirstName = Console.ReadLine();
                Console.Write("Enter a last name: ");
                employees[i].LastName = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("List of Employees: ");
            foreach (Employee item in employees)
            {
                Console.WriteLine("First name: {0}\nLast name: {1}", item.FirstName, item.LastName);
            }

            //int[,] myArray = { { 10, 20, 30 }, { 40, 50, 60 }, { 70, 80, 90 } };
            //for (int i = 0; i < myArray.GetLength(0); i++)
            //{
            //    //Console.Write(myArray[i, 0]+ ", ");
            //    //Console.Write(myArray[0, i] + ", ");
            //    for (int c = 0; c < myArray.GetLength(1); c++)
            //    {
            //        Console.Write(myArray[i, c]+ ", ");
            //    }
            //    Console.WriteLine();
            //}

            int[][] myArray = {
                new int[] { 10, 20, 30 },
                new int[] { 40, 50, 60, 110, 120 },
                new int[] { 70, 80 }
            };
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                //Console.Write(myArray[i, 0]+ ", ");
                //Console.Write(myArray[0, i] + ", ");
                for (int c = 0; c < myArray[i].GetLength(0); c++)
                {
                    Console.Write(myArray[i][c] + ", ");
                }
                Console.WriteLine();
            }
        }
    }
}