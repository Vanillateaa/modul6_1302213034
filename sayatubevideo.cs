using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302213034
{
    internal class sayatubevideo
    {
        private int id;
        private string title;
        public int playcount;

        public sayatubevideo( string title)
        {
            Contract.Requires(title.Length <= 200);
            Contract.Requires(title != null);

            try
            {
                checked
                {
                    this.title = title;
                    this.playcount = 0;
                    this.id = new Random().Next(10000, 99999);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void increaseplaycount(int playcount)
        {
            Contract.Requires(playcount <= 2500000);
            Contract.Requires(playcount > 0);

            try
            {
                checked
                {
                    this.playcount = playcount;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
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
