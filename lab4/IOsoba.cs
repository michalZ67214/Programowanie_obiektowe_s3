using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadania
{
    internal interface IOsoba
    {
        string Imie {  get; }

        string Nazwisko { get; }

        string ZwrocPelnaNazwe() { return ""; }
    }
}
