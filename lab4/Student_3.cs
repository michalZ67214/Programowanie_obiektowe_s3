using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadania
{
    internal class Student_3 : IStudent_3
    {
        public string Imie {  get; set; }
        public string Nazwisko {  get; set; }
        public string Uczelnia {  get; set; }
        public string Kierunek {  get; set; }
        public string Rok {  get; set; }
        public string Semestr {  get; set; }

        public Student_3(string imie, string nazwisko, string uczelnia, string kierunek, string rok, string semestr)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Uczelnia = uczelnia;
            Kierunek = kierunek;
            Rok = rok;
            Semestr = semestr;
        }

        public string WypiszPelnaNazweIUczelnie()
        {
            return $"{Imie} {Nazwisko} - {Semestr}{Kierunek} {Rok} {Uczelnia}";
        }
    }
}
