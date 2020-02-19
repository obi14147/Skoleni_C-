using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseBankAcountClass
{
    class BankAcount
    {
        public decimal Amount;
        public static decimal InterestRate;
        
        public void AddInterest()
        {
            this.Amount = this.Amount + (this.Amount * (InterestRate / 100));
        }

        public void GetInfo()
        {
            Console.WriteLine("Amount: {0}, Interest rate: {1} %.", this.Amount, InterestRate);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAcount.InterestRate = 2;

            BankAcount ac1 = new BankAcount();
            BankAcount ac2 = new BankAcount();
            BankAcount ac3 = new BankAcount();
            BankAcount ac4 = new BankAcount();

            List<BankAcount> Acounts = new List<BankAcount>();
            Acounts.Add(ac1);
            Acounts.Add(ac2);
            Acounts.Add(ac3);
            Acounts.Add(ac4);
            
            ac1.Amount = 10000;
            ac2.Amount = 20000;
            ac3.Amount = 15000;
            ac4.Amount = 1000;

            foreach (BankAcount item in Acounts)
            {
                item.GetInfo();
            }

            ac1.AddInterest();
            ac2.AddInterest();
            ac3.AddInterest();
            ac4.AddInterest();

            Console.WriteLine("After interest");
            foreach (BankAcount item in Acounts)
            {
                item.GetInfo();
            }
        }   
    }
}
