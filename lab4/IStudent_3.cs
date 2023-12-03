using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadania
{
    internal interface IStudent_3 : IOsoba
    {
        string Uczelnia {  get; }
        string Kierunek {  get; }
        string Rok {  get; }
        string Semestr {  get; }
    }
}
