using System;

namespace PermanentDrivingLicense
{
    class Program
    {
        static void Main(string[] args)
        {

            //programm küsib kasutaja sünniaastat
            //programm kontrollib kasutaja vanust
            //programm teatab kasutajat, kas ta on piisavalt vana et juhiluba saada

            // ">=" saad kasutada et öelda kas see on suurem või võrdub selle arvuga

            Console.WriteLine("Mis aastal sa sündisid?");

            int YearOfBirth = Int32.Parse(Console.ReadLine());
            int Age = 2021 - YearOfBirth;
            Console.WriteLine("sa oled " + Age);

            if (Age > 18)

            {

                Console.WriteLine("Oled piisavalt vana!");
            }
            else if (Age < 18)
            {
                Console.WriteLine("Oled liiga noor et saada juhiluba!");

            }
            else
            {

                Console.WriteLine("Oled piisavalt vana!");
            }





        }
    }
}
