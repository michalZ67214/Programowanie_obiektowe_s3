using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadania
{
    internal class Person
    {
        private string FirstName;
        private string LastName;
        private int wiek;

        public Person(string FirstName, string LastName, int wiek)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.wiek = wiek;
        }

        public void View()
        {
            Console.WriteLine($"Imie: {this.FirstName}\n" +
                $"Nazwisko: {this.LastName}\n" +
                $"Wiek: {this.wiek}\n");
        }
    }
}
