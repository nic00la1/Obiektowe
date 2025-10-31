namespace Obiektowe
{
    // Klasa bazowa
    public class Zwierze
    {
        public virtual void Poglaszcz()
        {
            Console.WriteLine("Pogłaskano niezindentyfikowane zwierzę");
        }
    }

    // Klasa pochodna
    public class Chomik : Zwierze
    {
        public override void Poglaszcz()
        {
            Console.WriteLine("Pogłaskano chomika");
        }

        public void WydajDzwiek()
        {
            Console.WriteLine("Pisk");
        }
    }
}