using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obiektowe
{
    public class Bankomat()
    {
        private double saldo;

        public double Saldo
        {
            get => saldo;
            private set 
            {
                saldo = value;
                Console.WriteLine("Nowa kwota: " + saldo);
            }
        }

        public void Wplac(double kwota)
        {
            if(kwota > 0)
            {
                Saldo += kwota;
            }
        }

        public void Wyplac(double kwota)
        {
            if (kwota > 0 && kwota <= saldo)
            {
                Saldo -= kwota;
            }
        }
    }
}
