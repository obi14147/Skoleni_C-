using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._08_Interface
{
    interface IStringConvertible
    {
        string ToUpperCase();
        string ToLowerCase();
    }

    class Employee : IStringConvertible
    {
        public string FirstName;
        public string LastName;
        public Employee(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public override string ToString()
        {
            return this.FirstName + " "+ this.LastName;
        }

        public string ToUpperCase()
        {
            return this.ToString().ToUpper();
        }
        //Implicitni
        //public string ToLowerCase()
        //{
        //    return this.ToString().ToLower();
        //}
        //explicitni
        string IStringConvertible.ToLowerCase()
        {
            return this.ToString().ToLower();
        }
    }
    class MyClass : IStringConvertible
    {
        public string ToLowerCase()
        {
            return "aBcD".ToUpper();
        }

        public string ToUpperCase()
        {
            return "aBcD".ToLower();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Petr", "Tinka");
            Console.WriteLine(employee.ToUpperCase());
            //Console.WriteLine(employee.ToLowerCase());
            //IStringConvertible convertible = (IStringConvertible)employee;
            IStringConvertible convertible = employee;
            Console.WriteLine(convertible.ToLowerCase());
            ShowConverted(employee);

            MyClass mc = new MyClass();
            ShowConverted(mc);
        }
        static void ShowConverted(IStringConvertible StringConvertible)
        {
           Console.WriteLine(StringConvertible.ToUpperCase());
           Console.WriteLine(StringConvertible.ToLowerCase());
        }
    }
}
