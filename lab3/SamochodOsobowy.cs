using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadania
{
    internal class SamochodOsobowy : Samochod
    {
        private double Waga;
        private double PojemnoscSilnika;
        private int IloscOsob;

        public SamochodOsobowy(string marka, string model, string nadwozie, 
            string kolor, int rokProdukcji, int przebieg, 
            double waga, double pojemnoscsilnika, int iloscosob) : 
            base(marka, model, nadwozie, kolor, rokProdukcji, przebieg)
        {
            if(waga < 2 || waga > 4.5)
            {
                Console.WriteLine("Waga powinna byc w przedziale: 2t - 4,5t");
                System.Environment.Exit(1);
            }

            if(pojemnoscsilnika < 0.8 || pojemnoscsilnika > 3)
            {
                Console.WriteLine("Pojemnosc silnika powinna byc w przedziale: 0,8-3,0");
                System.Environment.Exit(1);
            }
            this.Waga = waga;
            this.PojemnoscSilnika = pojemnoscsilnika;
            this.IloscOsob = iloscosob;
        }

        public void View()
        {
            base.View();
            Console.WriteLine($"Waga: {this.Waga}");
            Console.WriteLine($"Pojemnosc silnika: {this.PojemnoscSilnika}");
            Console.WriteLine($"Ilosc osob: {this.IloscOsob}");
        }
    }
}
