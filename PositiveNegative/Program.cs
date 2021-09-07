
using System;

namespace PositiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub sisestada numbrit
            //programm kontrollib numbrit
            //kui number on positiivne, konsool kuvab "number on positiivne";
            //kui number on negatiivne, konsool kuvab "number on negatiivne";
            //kui sisestatud number on 0 siis konsool kuvab "null";
            //NB! Int32.parse asemel kasutame  Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Palun sisesta number");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("Number on negatiivne");
            }
            else if (number > 0)
            {
                Console.WriteLine("Number on positiivne");
            }
            else
            {
                Console.WriteLine("Null");
            }


        }
    }
}
