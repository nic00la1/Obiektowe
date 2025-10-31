using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obiektowe
{
    public class Samochod()
    {
        // Pola klasy
        public string Marka = "";
        public int rocznik;

        // Metody klasy
        public void WyswietlMarke()
        {
            Console.WriteLine($"Marka pojazdu {Marka}");
        }
    }
}
