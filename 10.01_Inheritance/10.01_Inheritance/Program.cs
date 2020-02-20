using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._01_Inheritance
{
    class Animal
    {
        public int NumberOfLegs;
        public string Name;
        public string Type;
        public Animal(string name, string type)
        {
            this.Name = name;
            this.Type = type;
        }
    }

    class Cat : Animal
    {
        public Cat(string name, string type) : base(name, type)
        {
            this.NumberOfLegs = 4;
        }
    }

    class Spider : Animal
    {
        public Spider(string name, string type) : base(name, type)
        {
            this.NumberOfLegs = 8;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Cat cat = new Cat();
            //Spider spider = new Spider();
            //cat.NumberOfLegs = 4;
            //spider.NumberOfLegs = 8;
            //cat.Name = "Mourek";
            //spider.Name = "Odula";

            Cat cat = new Cat("Mourek", "Savec");
            Spider spider = new Spider("Odula", "Hmyz");

            Console.WriteLine("{0} has {1} legs. {2}", cat.Name, cat.NumberOfLegs, cat.Type);
            Console.WriteLine("{0} has {1} legs. {2}", spider.Name, spider.NumberOfLegs, spider.Type);
        }
    }
}
