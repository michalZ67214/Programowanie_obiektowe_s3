using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadania
{
    internal class Reviewer : Reader
    {
        public Reviewer(string FirstName, string LastName, int wiek, Book[] bookArray) : 
            base(FirstName, LastName, wiek, bookArray) { }

        public void Wypisz()
        {
            Random rnd = new Random();
            int note;
            foreach (Book b in this.bookArray)
            {
                note = rnd.Next(1, 11);
                Console.WriteLine($"{b.GetTitle()}, ocena: {note}/10");
            }
        }
    }
}
