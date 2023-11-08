using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Liczba
    {
        private int[] liczba_dziesietna;

        public Liczba(string liczba)
        {
            this.liczba_dziesietna = new int[liczba.Length];

            for (int i = 0; i < liczba.Length; i++)
            {
                this.liczba_dziesietna[i] = int.Parse(liczba[i].ToString());
            }
        }

        public void WypiszLiczbe()
        {
            foreach(int i in this.liczba_dziesietna)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }

        public void Mnozenie(int n)
        {
            string liczba = string.Join("", this.liczba_dziesietna);
            string iloczyn = (int.Parse(liczba) * n).ToString();

            if(iloczyn.Length > this.liczba_dziesietna.Length || iloczyn.Length < this.liczba_dziesietna.Length)
            {
                int[] liczba_dziesietna_new = new int[iloczyn.Length];

                for (int i = 0; i < iloczyn.Length; i++)
                {
                    liczba_dziesietna_new[i] = int.Parse(iloczyn[i].ToString());
                }

                liczba_dziesietna = liczba_dziesietna_new;
            }
            else
            {
                for (int i = 0; i < iloczyn.Length; i++)
                {
                    this.liczba_dziesietna[i] = int.Parse(iloczyn[i].ToString());
                }
            }
        }

        private int ObliczSilnie(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * ObliczSilnie(n - 1);
            }
        }

        public void Silnia(int n)
        {
            Console.WriteLine($"Silnia z {n} wynosi: {this.ObliczSilnie(n)}");
        }
    }
}
