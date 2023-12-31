﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadania
{
    internal class Osoba :  IOsoba
    {
        public string Imie {  get; set; }
        public string Nazwisko {  get; set; }

        public Osoba(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
        }

        public string ZwrocPelnaNazwe()
        {
            return Imie+" "+Nazwisko;
        }

        public static void WypiszOsoby(List<Osoba> osoby)
        {
            foreach(Osoba o in osoby)
            {
                Console.WriteLine(o.ZwrocPelnaNazwe());
            }
        }

        public static void PosortujOsobyPoNazwisku(ref List<Osoba> osoby)
        {
            osoby = osoby.OrderBy(o => o.Nazwisko).ToList();
        }
    }
}
