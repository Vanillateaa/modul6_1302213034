// See https://aka.ms/new-console-template for more information
using modul6_1302213034;

namespace modul6_1302213034
{
     class program
     {


        static void Main(string[] args)
        {
            sayatubeuser user = new sayatubeuser(" wili");

            sayatubevideo video1 = new sayatubevideo("review film fifty shades of grey oleh wili");
            sayatubevideo video2 = new sayatubevideo("review film fifty shades of freed oleh wili");
            sayatubevideo video3 = new sayatubevideo("review film fifty shades of darker oleh wili");
            sayatubevideo video4 = new sayatubevideo("review film fifty shades of ujang oleh wili");
            sayatubevideo video5 = new sayatubevideo("review film fifty shades of ucup oleh wili");
            sayatubevideo video6 = new sayatubevideo("review film pocong oleh wili");
            sayatubevideo video7 = new sayatubevideo("review film gundala oleh wili");
            sayatubevideo video8 = new sayatubevideo("review film my little pony oleh wili");
            sayatubevideo video9 = new sayatubevideo("review film tinkerbell oleh wili");
            sayatubevideo video10 = new sayatubevideo("review film sofia the first oleh wili");

            video1.increaseplaycount(2);
            video1.printvideodetails();

            video2.increaseplaycount(2);
            video2.printvideodetails();

            video3.increaseplaycount(2);
            video3.printvideodetails();

            video4.increaseplaycount(2);
            video4.printvideodetails();

            video5.increaseplaycount(2);
            video5.printvideodetails();

            video6.increaseplaycount(2);
            video6.printvideodetails();

            video7.increaseplaycount(2);
            video7.printvideodetails();

            video8.increaseplaycount(2);
            video8.printvideodetails();

            video9.increaseplaycount(2);
            video9.printvideodetails();

            video10.increaseplaycount(2);
            video10.printvideodetails();

  
            user.addvideo(video1);
            user.addvideo(video2);
            user.addvideo(video3);
            user.addvideo(video4);
            user.addvideo(video5);
            user.addvideo(video6);
            user.addvideo(video7);
            user.addvideo(video8);
            user.addvideo(video9);
            user.addvideo(video10);

            user.printallvideocount();
            Console.WriteLine("Video ditonton 25.000.000");
            video1.increaseplaycount(25000000);
            Console.WriteLine("Video ditonton 25.000.000 bisa jika 25.000.001 tidak bisa");
            Console.WriteLine();

            Console.WriteLine("Video ditonton limit int");
            for (int i = 0; i < 84; i++)
            {
                video1.increaseplaycount(25000000);
            }
            video1.printvideodetails();
            Console.WriteLine();
            video1.increaseplaycount(25000000);
            Console.WriteLine();

            user.printallvideocount();

        }
     }

}   
