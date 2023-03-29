using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302213034
{
    internal class sayatubeuser
    {
        private int id;
        private List<sayatubevideo> uploadedvideos;
        private string username;

        public sayatubeuser(String username)
        {
            this.uploadedvideos = new List<sayatubevideo>();
            this.username = username;
            this.id = new Random().Next(10000, 99999);
        }

        public int gettotalvideoplaycount()
        {
            int jum = 0;
            for (int i = 0; i < uploadedvideos.Count; i++)
            {
                jum += uploadedvideos[i].getplaycount();
            }

            return jum;
        }
        public void addvideo(sayatubevideo video)
        {
            this.uploadedvideos.Add(video);
        }

        public void printallvideocount()
        {
            int i = 0;
            while (i < uploadedvideos.Count && i <= 10)
            {
                Console.WriteLine("video " + (i + 1) + "judul: " + this.uploadedvideos[i].getTitle());
                i++;
            }
        }
    }
}


