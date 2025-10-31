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
        }
    }
}