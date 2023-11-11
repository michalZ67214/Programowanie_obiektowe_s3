using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadania
{
    internal class Samochod
    {
        protected string Marka;
        protected string Model;
        protected string Nadwozie;
        protected string Kolor;
        protected int RokProdukcji;
        protected int Przebieg;

        public Samochod(string marka, string model, string nadwozie, 
            string kolor, int rokProdukcji, int przebieg)
        {
            this.Marka = marka;
            this.Model = model;
            this.Nadwozie = nadwozie;
            this.Kolor = kolor;
            this.RokProdukcji = rokProdukcji;
            if (przebieg < 0)
            {
                Console.WriteLine("Przebieg nie moze byc ujemny");
                System.Environment.Exit(1);
            }

            this.Przebieg = przebieg;
        }

        public void View()
        {
            Console.WriteLine($"Marka: {this.Marka}");
            Console.WriteLine($"Model: {this.Model}");
            Console.WriteLine($"Nadwozie: {this.Nadwozie}");
            Console.WriteLine($"Kolor: {this.Kolor}");
            Console.WriteLine($"Rok produkcji: {this.RokProdukcji}");
            Console.WriteLine($"Przebieg: {this.Przebieg}");
        }
    }
}
