using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obiektowe
{
    public class User
    {
        public string Nazwa = "";

        // Konstruktor domyślny
        public User()
        {
            Nazwa = "Bez nazwy";
            Console.WriteLine("Utworzono użytkownika bez nazwy");
        }

        // Konstruktor z parametrami
        public User(string nazwa)
        {
            Nazwa = nazwa;
            Console.WriteLine("Utworzono użytkownika o nazwie: " + Nazwa);
        }

        // Dekonstruktor - zamyka połączenie z bazą danych / upuszcza strumień z plikiem
        // Specjalne życzenie - wywalenia kodu naszej klasy
        ~User()
        {
            Console.WriteLine("Usunięto użytkownika");
        }
    }
}
