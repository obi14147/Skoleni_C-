using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._02_Enumerator
{
    //enum Color
    //{
    //    Blue,
    //    Red,
    //    Green
    //}

    enum Color
    {
        Blue = 1,
        Red = 2,
        Green = 4
    }

    class Program
    {
        static void Main(string[] args)
        {
            //int color = 1;
            //if (color == 0)
            //{
            //    Console.WriteLine("Color is Blue");
            //}
            //else if (color == 1)
            //{
            //    Console.WriteLine("Color is Red");
            //}
            //else if (color == 2)
            //{
            //    Console.WriteLine("Color is Green");
            //}

            //string color = "Red";
            //if (color == "Blue")
            //{
            //    Console.WriteLine("Color is Blue");
            //}
            //else if (color == "Red")
            //{
            //    Console.WriteLine("Color is Red");
            //}
            //else if (color == "Green")
            //{
            //    Console.WriteLine("Color is Green");
            //}
            
            Color color = Color.Red;
            if (color == Color.Blue)
            {
                Console.WriteLine("Color is Blue");
            }
            else if (color == Color.Red)
            {
                Console.WriteLine("Color is Red");
            }
            else if (color == Color.Green)
            {
                Console.WriteLine("Color is Green");
            }

            Console.WriteLine(color);
            Console.WriteLine((int)color);

            Console.ReadKey();
        }
    }
}

