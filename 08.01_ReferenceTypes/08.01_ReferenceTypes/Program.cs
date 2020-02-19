using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._01_ReferenceTypes
{
    class Invoice
    {
        public int ID;
        public decimal TotalPrice;
        public DateTime DateCreated;
        public DateTime DatePrinted;
    }

    class InvoiceManager
    {
        public static void PrintInvoice(Invoice invoice)
        {
            if (invoice == null) return;

            Console.WriteLine("ID: {0}, TotalPrice: {1}, DataCreated: {2}", invoice.ID, invoice.TotalPrice, invoice.DateCreated);

            invoice.DatePrinted = DateTime.Now;
        }

        public static Invoice MakeInvoice(int id, decimal totalPrice)
        {
            Invoice newInvoices = new Invoice();
            newInvoices.ID = id;
            newInvoices.TotalPrice = totalPrice;
            newInvoices.DateCreated = DateTime.Now;
            return newInvoices;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Invoice[] invoices = new Invoice[3];

            invoices[0] = new Invoice();
            invoices[0].ID = 1;
            invoices[0].TotalPrice = 7000;
            invoices[0].DateCreated = new DateTime(2020,1,31);

            invoices[1] = new Invoice();
            invoices[1].ID = 2;
            invoices[1].TotalPrice = 8000;
            invoices[1].DateCreated = new DateTime(2020, 2, 28);

            invoices[2] = InvoiceManager.MakeInvoice(3, 8000);

            foreach (Invoice item in invoices)
            {
                InvoiceManager.PrintInvoice(item);
            }
            Console.WriteLine(invoices[0].DatePrinted);
        }
    }
}
