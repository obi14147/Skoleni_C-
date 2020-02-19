using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseGetMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 10, 50, 30, 140, 20, 3, 60, 80 };
            //int[] list = { -10, -50, -30, -140, -20, -3, -60, -80 };
            Console.WriteLine(GetMax(list));
        }

        static int GetMax(int[] list)
        {
            int MaxValue = list[0];
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] > MaxValue)
                {
                    MaxValue = list[i];
                }
            }
            return MaxValue;
        }
    }
}
