using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._02_Static
{
    class MyClass
    {
        public int InstanceMember;
        public static int StaticMember;

        public int GetStaticValue()
        {
            return MyClass.StaticMember;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            mc.InstanceMember = 15;
            MyClass.StaticMember = 15;

            MyClass mc1 = new MyClass();
            MyClass mc2 = new MyClass();
            mc1.InstanceMember = 1;
            mc2.InstanceMember = 2;
            Console.WriteLine("mc1: InstanceMember = {0}, StaticMemeber = {1}", mc1.InstanceMember, mc1.GetStaticValue());
            Console.WriteLine("mc2: InstanceMember = {0}, StaticMemeber = {1}", mc2.InstanceMember, mc2.GetStaticValue());
        }
    }
}
