using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._02_Finalizace
{
    class FileStream
    {
        public void Open()
        {
            Console.WriteLine("Opening file");
        }

        public void Close()
        {
            Console.WriteLine("Closing file");
        }
        ~FileStream()
        {
            this.Close();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream();
            //fs.Open();

            try
            {
                fs.Open();
                //Pracuji se souborem
                throw new Exception("Invalid file operation");
            }
            finally
            {
                fs.Close();
            }


        }
    }
}
