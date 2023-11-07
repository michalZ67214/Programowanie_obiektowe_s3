using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadanie1();
            //Zadanie2();
            Zadanie3();
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

        static void Zadanie3()
        {
            Data data1 = new Data(DateTime.Now);
            Console.WriteLine(data1.getCurrentDate());
            data1.PlusOneDay();
            Console.WriteLine(data1.getCurrentDate());
            data1.MinusOneDay();
            Console.WriteLine(data1.getCurrentDate());

            Console.WriteLine();

            Data data2 = new Data(new DateTime(2008, 6, 1));
            Console.WriteLine(data2.getCurrentDate());
            data2.PlusOneDay();
            Console.WriteLine(data2.getCurrentDate());
            data2.MinusOneDay();
            Console.WriteLine(data2.getCurrentDate()); 
        }
    }
}