using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._04_CastingAndBoxing
{
    class Animal { }
    class Fish : Animal { }
    class Cat : Animal { }
    class Program
    {
        static void Main(string[] args)
        {
            Fish fish = new Fish();
            Cat cat = new Cat();
            Animal animal;
            //Implicit casting up
            animal = fish;
            animal = cat;
            //Explicit casting up
            animal = (Animal)fish;
            animal = (Animal)cat;

            //Implicit casting down
            //cat = animal;
            //fish = animal;
            //Explicit casting down
            //cat = (Cat)animal;
            //fish = (Fish)animal;

            //operator is pro otestovani mozneho pretypovani
            //if (animal is Cat)
            //{
            //    cat = (Cat)animal;
            //}
            //else
            //{
            //    Console.WriteLine("Can't cast to Cat");
            //}

            //if (animal is Fish)
            //{
            //    fish = (Fish)animal;
            //}
            //else
            //{
            //    Console.WriteLine("Can't cast to Fish");
            //}

            //operator is pro otestovani mozneho pretypovani
            //cat = animal as Cat;
            //if (cat == null)
            //{
            //    Console.WriteLine("Can't cast to Cat");
            //}
            //fish = animal as Fish;
            //if (fish == null)
            //{
            //    Console.WriteLine("Can't cast to Fish");
            //}

            //boxovani a odboxovavani
            int a = 1;
            //implicit boxing
            object o = a;
            //explicit boxing
            object p = (object)a;
            //implicit unboxing
            //int b = o;
            //explicit unboxing
            int b = (int)o;

            System.Collections.ArrayList list = new System.Collections.ArrayList();
            list.Add("A");
            list.Add(0);
        }
    }
}
