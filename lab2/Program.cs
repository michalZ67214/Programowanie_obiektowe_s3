using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadanie1();
            Zadanie2();
        }

        static void Zadanie1()
        {
            Licz[] liczs = new Licz[]
            {
                new Licz(1),
                new Licz(2),
                new Licz(3)
            };

            foreach (Licz item in liczs)
            {
                item.View(2);
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }
        }

        static void Zadanie2()
        {
            int[] liczby = new int[] {1, 2, 3, 4};

            Sumator sumator1 = new Sumator(liczby);
            sumator1.View();
            sumator1.ViewLowIndexHighIndex(3, 3);
        }
    }
}