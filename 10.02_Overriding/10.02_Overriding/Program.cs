using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._02_Overriding
{
    class Animal
    {
        public virtual string MakeSound()
        {
            return "";
        }
    }

    class Fish : Animal
    {

    }

    class Cat : Animal
    {
        public override string MakeSound()
        {
            return "Yow";
        }
    }

    class PersianCat : Cat
    {
        public override string MakeSound()
        {
            return base.MakeSound() + " " + base.MakeSound();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fish fish = new Fish();
            Cat cat = new Cat();
            PersianCat persianCat = new PersianCat();

            Console.WriteLine(fish.MakeSound());
            Console.WriteLine(cat.MakeSound());
            Console.WriteLine(persianCat.MakeSound());
        }
    }
}
