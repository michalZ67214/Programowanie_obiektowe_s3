using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadania
{
    internal class Reader:Person
    {
        protected Book[] bookArray = new Book[10];

        public Reader(string FirstName, string LastName, int wiek, Book[] bookArray) : 
            base(FirstName, LastName, wiek)
        {
            this.bookArray = bookArray;
        }

        public void ViewBook()
        {
            foreach(Book b in bookArray)
            {
                b.ViewTitle();
            }
        }

        public override void View()
        {
            base.View();
            Console.WriteLine("Przeczytane ksiazki: ");
            this.ViewBook();
        }
    }
}
