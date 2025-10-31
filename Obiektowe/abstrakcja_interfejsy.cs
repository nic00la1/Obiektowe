using static Obiektowe.Kwadrat;

namespace Obiektowe
{
   public abstract class Figura
    {
        public abstract void Pole();
    }

    public class Kwadrat : Figura
    {
        double Bok;
        public Kwadrat(double bok)
        {
            Bok = Bok;
        }


        public override void Pole()
        {
            Console.WriteLine("Pole kwadratu wynosi: " + (Bok * Bok));
        }

        public interface IRysowalny
        {
            void Rysuj();
        }
    }

    public class Kolo : IRysowalny
    {
        public double Promien;

        public Kolo(double promien)
        {
            Promien = promien;
        }

        public void Rysuj()
        {
            Console.WriteLine("Narysowano : D");
        }
    }
}
