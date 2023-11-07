using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Licz
    {
        private double value;

        public Licz(double value)
        {
            this.value = value;
        }

        private double Dodaj(double a)
        {
            return this.value += a;
        }

        private double Odejmij(double a)
        {
            return this.value -= a;
        }

        public void View(double a)
        {
            Console.WriteLine($"Wartosc poczatkowa: {this.value},\nWartosc po dodaniu {a}: " +
                $"{Dodaj(a)}, \nWartosc po odjeciu {a}: {this.Odejmij(a)}\n");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
