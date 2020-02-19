using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._01_StatementBlocksAndCondition
{
    class Program
    {
        enum CarType
        {
            Benzin,
            Diesel,
            Hybrid,
            Electro
        }
        static void Main(string[] args)
        {
            //{
            //    int a = 1;
            //    Console.WriteLine(a);
            //}
            //{
            //    string a = "Jak je?";
            //    Console.WriteLine(a);
            //}

            Console.WriteLine("Time: {0}:{1}:{2}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);


            //if (DateTime.Now.Hour == 12)
            //{
            //    Console.WriteLine("Poledne");
            //}
            //else
            //{
            //    Console.WriteLine("Neco jineho nez poledne");
            //}

            //if (DateTime.Now.Hour == 12) Console.WriteLine("Poledne");
            //    else Console.WriteLine("Neco jineho nez poledne");

            //Console.WriteLine((DateTime.Now.Hour == 12) ? "Poledne": "Neco jineho nez poledne");

            //switch (DateTime.Now.Hour)
            //{
            //    case 5:
            //        Console.WriteLine("Dobre rano"); break;
            //    case 6:
            //        Console.WriteLine("Dobre rano"); break;
            //    case 7:
            //        Console.WriteLine("Dobre rano"); break;
            //    case 8:
            //        Console.WriteLine("Dobre rano"); break;
            //    case 16:
            //        Console.WriteLine("Dobre odpoledne"); break;
            //    case 17:
            //        Console.WriteLine("Dobre odpoledne"); break;
            //    default:
            //        Console.WriteLine("Dobry den");
            //        break;
            //}

            //switch (DateTime.Now.Hour)
            //{
            //    case 5:
            //    case 6:
            //    case 7:
            //    case 8:
            //        Console.WriteLine("Dobre rano"); break;
            //    case 16:
            //    case 17:
            //        Console.WriteLine("Dobre odpoledne"); break;
            //    default:
            //        Console.WriteLine("Dobry den");
            //        break;
            //}

            switch (DateTime.Now.Hour)
            {
                case 5: case 6: case 7: case 8:
                    Console.WriteLine("Dobre rano"); break;
                case 16: case 17:
                    Console.WriteLine("Dobre odpoledne"); break;
                default:
                    Console.WriteLine("Dobry den");
                    break;
            }

            //Stačí napsat switch, dvakrát na tab, a do snippetu vložit proměnnou carType a stiknout enter
            // cases se samy vytvoří
            CarType carType = CarType.Hybrid;
            switch (carType)
            {
                case CarType.Benzin:
                    break;
                case CarType.Diesel:
                    break;
                case CarType.Hybrid:
                    break;
                case CarType.Electro:
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }
    }
}
