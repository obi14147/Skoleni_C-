using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._01_Property
{
    class Program
    {
        class Fish
        {
            private int weight;
            
            public int Weight
            {
                set 
                {
                    if (value < 0)
                    {
                        throw new InvalidOperationException("Invalid Value");
                    }
                    this.weight = value;
                }
                get { return this.weight; }
            }
}
            //public void SetWeight(int weight)
            //{
            //    //if (weight < 0)
            //    //{
            //    //    throw new InvalidOperationException("Invalid Value");
            //    //}
            //    //this.weight = weight;
            //}
            //public int GetWeight()
            //{
            //    return this.weight;
            //}
        
        static void Main(string[] args)
        {
            Fish fish = new Fish();
            fish.Weight = 20;
            Console.WriteLine(fish.Weight);

            //fish.SetWeight(-30);
            //fish.weight = -20;
            //Console.WriteLine(fish.GetWeight());
        }
    }
}
