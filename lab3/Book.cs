﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadania
{
    internal class Book
    {
        protected string title;

        protected Person author;

        protected string dataWydania;

        public Book(string title, Person author, string dataWydania)
        {
            this.title = title;
            this.author = author;
            this.dataWydania = dataWydania;
        }

        public void View()
        {
            Console.WriteLine($"Tytul: {this.title}\n");
            Console.WriteLine("Autor: ");
            this.author.View();
            Console.WriteLine($"Data wydania: {dataWydania}");
        }

        public void ViewTitle()
        {
            Console.WriteLine(this.title);
        }

        public string GetTitle()
        {
            return this.title;
        }
    }
}
