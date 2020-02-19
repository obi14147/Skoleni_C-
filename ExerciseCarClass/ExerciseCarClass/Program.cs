using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseCarClass
{
    class Cars
    {
        public string Manufacturer;
        public string Model;
        public int Speed;

        public int SpeedUp(int up)
        {
            return Speed = (Speed + up);
        }

        public int SpeedDown(int down)
        {
            return Speed = (Speed - down);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cars A3 = new Cars();
            A3.Manufacturer = "Audi";
            A3.Model = "A3";
            A3.Speed = 50;

            Cars A4 = new Cars();
            A4.Manufacturer = "Audi";
            A4.Model = "A4";
            A4.Speed = 50;

            Cars A5 = new Cars();
            A5.Manufacturer = "Audi";
            A5.Model = "A5";
            A5.Speed = 50;

            Cars A6 = new Cars();
            A6.Manufacturer = "Audi";
            A6.Model = "A6";
            A6.Speed = 50;

            Cars A7 = new Cars();
            A7.Manufacturer = "Audi";
            A7.Model = "A7";
            A7.Speed = 50;

            A3.SpeedUp(20);
            A4.SpeedDown(15);
            A4.SpeedDown(15);
            A5.SpeedDown(15);
            A5.SpeedUp(50);
            A6.SpeedUp(100);
            A7.SpeedDown(40);
            
            List<Cars> listCars = new List<Cars>(); 
            listCars.Add(A3);
            listCars.Add(A4);
            listCars.Add(A5);
            listCars.Add(A6);
            listCars.Add(A7);

            foreach (Cars item in listCars)
            {
                Console.WriteLine("Speed of {0} {1} is {2} km/h.",item.Manufacturer, item.Model, item.Speed);               
            }
        }
    }
}
