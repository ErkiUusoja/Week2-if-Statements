using System;

namespace PermanentDrivingLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm kontrollib kasutaja vanust
            //programm teatab kasutajat, kas ta on piisavalt vana
            //et juhiluba saada

            Console.WriteLine("Sisesta oma sünniaasta.");

            int born = Int32.Parse(Console.ReadLine());

            if (born < 2003)
            {
                Console.WriteLine("Oled piisavalt vana, et saada juhiluba!");
            }
            else if (born > 2003)
            {
                Console.WriteLine("Oled liiga noor, et saada juhiluba!");
            }
            else
            {
                Console.WriteLine("Oled piisavalt vana, et saada juhiluba!");
            }
            Console.WriteLine("Head päeva!");

        }
    }
}
