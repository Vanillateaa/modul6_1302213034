using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302213034
{
    internal class sayatubevideo
    {
        private int id;
        private string title;
        private int playcount;

        public sayatubevideo( string title)
        {
            this.id = new Random().Next(10000, 99999);
            this.title = title;
            this.playcount = 0;
        }

        public void increaseplaycount(int playcount)
        {
            this.playcount = checked(this.playcount + playcount);
        }

        public void printvideodetails() {
            Console.WriteLine("id: " + this.id);
            Console.WriteLine("title: " + this.title);
            Console.WriteLine("jumlah dimainkan: " + this.playcount);
        }

        public int getplaycount()
        {
            return this.playcount;
        }

        public string getTitle()
        {
            return this.title;
        }
    }
}
