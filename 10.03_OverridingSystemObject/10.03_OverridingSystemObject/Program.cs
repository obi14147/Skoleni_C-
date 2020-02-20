using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._03_OverridingSystemObject
{
    class Employee
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
            return string.Format("{0} {1}", this.FirstName, this.LastName);
        }    
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Petr", "Tinka");
            Console.WriteLine(employee.ToString());

        }
    }
}
