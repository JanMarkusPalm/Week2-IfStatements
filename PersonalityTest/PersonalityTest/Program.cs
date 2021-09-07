using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja käest tema lemmik värvi
            //kui kasutaja sisestab "punane", konsool kuvab "oled romantiline"
            //kui kasutaja sisestab "sinine", konsool kuvab "oled töökas"
            //kui kasutaja sisestab "roheline", konsool kuvab "oled looduse sõber"
            //kui kasutaja sisestab midagi muud, konsool kuvab "oled taun"


            Console.WriteLine("mis su lemmikvärv on?");

            string FavColor = Console.ReadLine().ToLower();

            if (FavColor == "punane")
            {
                Console.WriteLine("sa oled romantiline");
            }
            else if (FavColor == "sinine")
            {
                Console.WriteLine("sa oled töökas");
            }
            else if (FavColor == "roheline")
            {
                Console.WriteLine("oled looduse sõber");
            }

            else
            {
                Console.WriteLine("sa oled lihtsalt taun");
            }

        }
    }
}
