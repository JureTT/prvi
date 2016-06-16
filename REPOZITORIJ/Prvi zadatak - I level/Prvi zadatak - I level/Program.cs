using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Code;

namespace Prvi_zadatak___I_level
{
    class Program
    {
        static void Main()
        {
            List<Student> popisStudenata = new List<Student>();

            Console.WriteLine("Poštovani upravo se pokrenuli aplikaciju za izradu popisa studenata. \nAplikacija ima dvije naredbe pomoću kojih se upravlja njome. \nPrva naredba je 'ENLIST' koja služi za upisivanje studenata i njihovih podataka, \ndruga naredba je 'DISPLAY' koja vrši ispis upisanih studenata. \nMolimo unesite željenu naredbu:");

            UnosNaredbe:
            String naredba = Console.ReadLine().Trim().ToLower();  //uneseni tekst bez razmaka i malih slova
                       
            if (naredba == "enlist")
            {
                Student osoba = Operations.enlist();
                popisStudenata.Add(osoba);
                Console.WriteLine("Ako želite dodati još jednog studenta na popis možete učiniti to naredbom 'ENLIST', \na ako želite pregledati popis studenata možete to učiniti naredbom 'DISPLAY':");
                goto UnosNaredbe;
            }
            else if (naredba == "display")
            {
                Console.WriteLine("Popis upisanih studenata:");
                Operations.display(popisStudenata);
            }
            else 
            {
                Console.WriteLine("Pogrešan unos, molimo pokušajte ponovo:");
                goto UnosNaredbe;
            }

            Console.WriteLine("Hvala Vam na korištenju naše aplikacije.");
            Console.ReadLine();
        }
    }
}