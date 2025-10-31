namespace Obiektowe
{
    class Program
    {
        public static void Main(string[] args)
        {
            Samochod samochod = new Samochod();

            samochod.Marka = "BMW";
            samochod.rocznik = 1984;

            samochod.WyswietlMarke();

            Chomik zwierze = new Chomik();
            zwierze.Poglaszcz();
            zwierze.WydajDzwiek();

            Bankomat bank = new();
            Console.WriteLine(bank.Saldo);

            bank.Wplac(20.50);
            bank.Wyplac(16.00);
        }
    }
}