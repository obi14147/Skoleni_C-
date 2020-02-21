using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._07_AbstractClass
{
    abstract class Stream
    {
        public void Close()
        {
            Console.WriteLine("Closing Stream");
        }

        public abstract void Open();

    }

    class FileStream : Stream
    {
        public override void Open()
        {
            Console.WriteLine("Opening File Stream");
        }
    }

    class MemoryStream : Stream
    {
        public override void Open()
        {
            Console.WriteLine("Opening Memory Stream");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //FileStream fs = new FileStream();
            //fs.Open();
            //fs.Close();

            Stream[] streams = new Stream[2];
            streams[0] = new FileStream();
            streams[1] = new MemoryStream();
            OpenStreams(streams);
            CloseStreams(streams);
        }

        static void OpenStreams(Stream[] streams)
        {
            foreach (Stream item in streams)
            {
                item.Open();
            }
        }

        static void CloseStreams(Stream[] streams)
        {
            foreach (Stream item in streams)
            {
                item.Close();
            }
        }
    }
}
