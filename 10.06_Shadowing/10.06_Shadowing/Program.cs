using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_06_Shadowing
{
    class Animal
    {
        public string MakeSound()
        {
            return "";
        }
    }

    class Fish : Animal
    {

    }

    class Cat : Animal
    {
        new public string MakeSound()
        {
            return "Yow";
        }
    }

    class PersianCat : Cat
    {
        new public string MakeSound()
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

            Animal[] animals = new Animal[3];
            animals[0] = new Fish();
            animals[1] = new Cat();
            animals[2] = new PersianCat();
            foreach (Animal item in animals)
            {
                if (item is PersianCat)
                {
                    Console.WriteLine(((PersianCat)item).MakeSound());
                }
                else if (item is Cat)
                {
                    Console.WriteLine(((Cat)item).MakeSound());
                }
                else
                {
                    Console.WriteLine(item.MakeSound());
                }
                MakeSoundOfAnimal(item);
            }            
        }
        
       
        static void MakeSoundOfAnimal(Animal animal)
        {
            Console.WriteLine("Make sound: {0}", animal.MakeSound());
        }
    }
}
