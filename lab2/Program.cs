using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Zadanie 1
            Licz[] liczs = new Licz[]
            {
                new Licz(1),
                new Licz(2),
                new Licz(3)
            };

            foreach(Licz item in liczs)
            {
                item.View(2);
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }

            // Zadanie 1 koniec
        }
    }
}