using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseShapes
{
    class Shape
    {
        public string name;
        public virtual int Povrch()
        {
            return 0;
        }
    }

    class Obdelnik : Shape 
    {
        protected int a;
        protected int b;
        public Obdelnik(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public override int Povrch()
        {
            return this.a * this.b;
        }
    }

    class Ctverec : Obdelnik
    {
        public Ctverec(int a, int b) : base(a, b) { }
    }

    class Kvadr : Shape
    {
        Obdelnik[] obdelniky = new Obdelnik[3];
        public Kvadr(int a, int b, int c)
        {
            this.obdelniky[0] = new Obdelnik(a, b);
            this.obdelniky[1] = new Obdelnik(a, c);
            this.obdelniky[2] = new Obdelnik(b, c);
        }
        public override int Povrch()
        {

            return 2 * (this.obdelniky[0].Povrch() + this.obdelniky[1].Povrch() + this.obdelniky[2].Povrch());

            //return (2 * a * b) + (2 * a * c) + (2 * b * c);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Obdelnik obdelnik = new Obdelnik(10, 20);
            Ctverec ctverec = new Ctverec(10, 10);
            Kvadr kvadr = new Kvadr(10, 20, 30);
            obdelnik.name = "Obdelnik";
            ctverec.name = "Ctverec";
            kvadr.name = "Kvadr";

            List<Shape> list = new List<Shape>();
            list.Add(obdelnik);
            list.Add(ctverec);
            list.Add(kvadr);

            foreach (Shape item in list)
            {
                Console.WriteLine("{0} ma povrch {1} mm2.", item.name, item.Povrch());
            }
        }
    }
}
