using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._02_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] list = { 10, 20, 30};
            //System.Collections.ArrayList list = new System.Collections.ArrayList();
            System.Collections.Generic.List<int> list = new System.Collections.Generic.List<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Remove(10);
            list.Insert(1, 10);

            Console.WriteLine(list[1]);
            list[1] = 25;
            Console.WriteLine(list[1]);

            Console.Write("Enter a number: ");
            //list.Add(Console.ReadLine());

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }



        }
    }
}
