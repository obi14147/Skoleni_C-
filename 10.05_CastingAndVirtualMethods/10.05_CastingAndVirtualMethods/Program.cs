using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._05_CastingAndVirtualMethods
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

            Animal[] animals = new Animal[3];
            //animals[0] = (Animal)new Fish();
            //animals[1] = (Animal)new Cat();
            //animals[2] = (Animal)new PersianCat();
            animals[0] = new Fish();
            animals[1] = new Cat();
            animals[2] = new PersianCat();
            foreach (Animal item in animals)
            {
                //Console.WriteLine("Make sound: {0}", item.MakeSound());
                MakeSoundOfAnimal(item);
            }
        }
        static void MakeSoundOfAnimal(Animal animal)
        {
            Console.WriteLine("Make sound: {0}", animal.MakeSound());
        }
    }
}
