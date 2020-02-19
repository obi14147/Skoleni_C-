using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseCreateArray
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] created = CreateArray(4, 3);

            for (int i = 0; i < created.Length; i++)
            {
                Console.WriteLine(created[i]);
            }

            //foreach (int item in CreateArray(4, 1))
            //{
            //    Console.WriteLine(item);
            //}    
        }

        static int[] CreateArray(int size, int defaultValue)
        {
            int[] myArray = new int[size];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = defaultValue;
            }
            return myArray;

        }
    }
}
