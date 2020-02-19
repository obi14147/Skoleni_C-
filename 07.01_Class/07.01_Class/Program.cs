using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._01_Class
{
    //struct Employee
    //{
    //    public string FirstName;
    //    public string LastName;
    //}
    class Employee
    {
        public string FirstName;
        public string LastName;
        private decimal salary;
        public decimal GetSalary()
        {
            return this.salary;
        }

        public void SetSalary(decimal salary)
        {
            this.salary = salary;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {   
            Employee employee1 = new Employee();
            employee1.FirstName = "Petr";
            employee1.LastName = "Tinka";
            employee1.SetSalary(1000);
            Console.Write("Employee 1: ");
            Console.WriteLine("First name = {0}, Last name = {1}",employee1.FirstName, employee1.LastName);
            Console.WriteLine("Salary of employee1 is {0}", employee1.GetSalary());

            //Employee employee2 = employee1;
            //employee2.FirstName = "Jan";
            //employee2.LastName = "Novak";
            //Console.Write("Employee 2: ");
            //Console.WriteLine("First name = {0}, Last name = {1}", employee2.FirstName, employee2.LastName);

            //Console.Write("Employee 1: ");
            //Console.WriteLine("First name = {0}, Last name = {1}", employee1.FirstName, employee1.LastName);
        }
    }
}
