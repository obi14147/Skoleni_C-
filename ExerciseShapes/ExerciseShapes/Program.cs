using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseShapes
{
    class Shape
    {
        //public int a;
        //public int b;
        //public int c;

        //public Shape(int a, int b)
        //{
        //    this.a = a;
        //    this.b = b;
        //}
        //public Shape(int a, int b, int c)
        //{
        //    this.a = a;
        //    this.b = b;
        //    this.c = c;
        //}
        public string name;

        public int Povrch(int a, int b)
        {
            return a*b;
        }

        public int Povrch(int a, int b, int c)
        {
            return (2 * a * b) + (2 * a * c) + (2 * b * c);
        }
    }

    class Obdelnik : Shape 
    {
        //public Obdelnik(int a, int b) : base(a, b)
        //{
        //    this.Povrch(a, b);
        //}

    }

    class Ctverec : Obdelnik
    {
        //public Ctverec(int a, int b) : base(a, b)
        //{
        //    this.Povrch(a, b);
        //}
    }

    class Kvadr : Obdelnik
    {
        //public Kvadr(int a, int b, int c) : base(a, b, c)
        //{
        //    this.Povrch(a, b, c);
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Obdelnik obdelnik = new Obdelnik();
            Ctverec ctverec = new Ctverec();
            Kvadr kvadr = new Kvadr();
            obdelnik.name = "Obdelnik";
            ctverec.name = "Ctverec";
            kvadr.name = "Kvadr";

            Console.WriteLine("{0} ma povrch: {1} mm2.", obdelnik.name, obdelnik.Povrch(10, 20));
            Console.WriteLine("{0} ma povrch: {1} mm2.", ctverec.name, ctverec.Povrch(10, 10));
            Console.WriteLine("{0} ma povrch: {1} mm2.", kvadr.name, kvadr.Povrch(10, 20, 30));
        }
    }
}
