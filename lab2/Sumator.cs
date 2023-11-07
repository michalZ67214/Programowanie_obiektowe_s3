using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Sumator
    {
        private int[] Liczby;

        public Sumator(int[] arrayLiczby)
        {
            this.Liczby = arrayLiczby;
        }

        private int Suma()
        {
            int suma_liczb = 0;

            foreach (int item in this.Liczby)
            {
                suma_liczb += item;
            }

            return suma_liczb;
        }

        private int SumaPodziel2()
        {
            int suma_liczb = 0;

            foreach (int item in this.Liczby)
            {
                if (item % 2 == 0) suma_liczb += item;
            }

            return suma_liczb;
        }

        private int IleElementow()
        {
            return this.Liczby.Length;
        }

        private void ShowElements()
        {
            Console.WriteLine("Elementy tablicy:");
            foreach (int item in this.Liczby)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        private void ShowElementsByIndexes(int lowIndex, int highIndex)
        {
            int lowIndexByUser = lowIndex;
            int highIndexByUser = highIndex;

            Console.WriteLine($"Elementy tablicy miedzy indeksami {lowIndex} i {highIndex}:");

            if (lowIndex < 0) 
            { 
                lowIndex = 0;
                Console.WriteLine($"Dolny indeks zostal zamieniony z {lowIndexByUser} na 0");
            }

            if (highIndex > this.IleElementow() - 1)
            {
                highIndex = this.IleElementow()-1;
                Console.WriteLine($"Gorny indeks zostal zamieniony z {highIndexByUser} na {this.IleElementow()-1}");
            }

            if (highIndex < lowIndex) 
            { 
                Console.WriteLine("Nieprawidlowe wartosci indeksow"); 
            }
            else
            {
                for (int i = lowIndex; i <= highIndex; i++)
                {
                    Console.WriteLine(this.Liczby[i]);
                }
            }
        }

        public void View()
        {
            Console.WriteLine($"Suma elementow tablicy wynosi: {this.Suma()}");
            Console.WriteLine($"Suma elementow tablicy podzielnych przez 2 wynosi: {this.SumaPodziel2()}");
            Console.WriteLine($"Liczba elementow tablicy: {this.IleElementow()}");
            this.ShowElements();
        }

        public void ViewLowIndexHighIndex(int lowIndex, int highIndex)
        {
            this.ShowElementsByIndexes(lowIndex, highIndex);
        }
    }
}
