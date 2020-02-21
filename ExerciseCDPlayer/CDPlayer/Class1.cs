using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayerLibrary;

namespace PlayerLibrary
{
    public class Class1 : IPlayer
    {
        string song;
        bool next = false;
        public Class1(string song, bool next)
        {
            this.song = song;
            this.next = next;
        }

        bool IPlayer.Next()
        {
            return next;
        }

        string IPlayer.Play()
        {
            if (next==true)
            {
                return song;
            }
            else
            {
                return "";
            }           
        }
    }
}