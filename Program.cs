using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLab7c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Phone ");
            Console.WriteLine("Let's switch on  ");

            Phone m2 = new Phone();
            m2.Switch(true);

            Console.WriteLine("Let's check is switch off or not  ");
            Phone m3 = new Phone();
            m3.Switch(false);

            Phone m4 = new Phone();
            m4.play(true);

            Phone m5 = new Phone();
            m5.setVolume(70);

            Phone m6 = new Phone();
            m6.playNext();

            Phone m7 = new Phone();
            m7.playPrevious();

            Phone m8 = new Phone();

            m8.retune(89.02);
            Phone m9 = new Phone();
            m9.changeChannel();

          
            Phone m = new Phone();
            Console.WriteLine("Let's see music file details");
            m.MusicFile("Valobashbo" , "Habib Wahid" ,  2007,  300);
            Console.WriteLine("Next music file details");
            m.MusicFile("Phire to pabona", "Hridoy Khan", 2014, 200);
            Console.WriteLine("Changing the Music.....");
            MusicFile m1 = new MusicFile();
            m1.changeTitle("Phire to pabona");











            Console.ReadKey();
        }
    }
}
