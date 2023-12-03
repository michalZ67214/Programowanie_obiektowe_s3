using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadania
{
    internal class StudentWSIiZ : Student_3
    {
        public string NrAlbumu { get; set; }
        public StudentWSIiZ(string imie, string nazwisko, string uczelnia, string kierunek, string rok, string semestr, string nrAlbumu) : base(imie, nazwisko, uczelnia, kierunek, rok, semestr)
        {
            NrAlbumu = nrAlbumu;
        }

        public override string WypiszPelnaNazweIUczelnie()
        {
            return $"{Imie} {Nazwisko} {NrAlbumu} - {Semestr}{Kierunek} {Rok} {Uczelnia}";
        }
    }
}
