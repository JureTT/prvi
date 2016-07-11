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
            List<Student> PopisStudenata = new List<Student>();

            Console.WriteLine("Poštovani upravo se pokrenuli aplikaciju za izradu popisa studenata." 
                + "\nAplikacija ima dvije naredbe pomoću kojih se upravlja njome. " 
                + "\nPrva naredba je 'ENLIST' koja služi za upisivanje studenata i njihovih podataka," 
                + " \ndruga naredba je 'DISPLAY' koja vrši ispis upisanih studenata. \nMolimo unesite željenu naredbu:");          
            String Naredba = Console.ReadLine().Trim().ToLower();

            StudentIdGenerator Generator = StudentIdGenerator.Stvaranje();

            do
            {
                if (Naredba == Operations.Enlist)
                {
                    Student Studos = new Student();

                    Studos.ID = Generator.Id;
            
                    Validation Provjera = new Validation();

                    do
                    {
                        Console.WriteLine("Unesite ime studenta:");
                        Studos.Ime = Console.ReadLine();
                    }
                    while (Provjera.ProvjeraStringa(Studos.Ime) == string.Empty);

                    do
                    {
                        Console.WriteLine("Unesite prezime studenta:");
                        Studos.Prezime = Console.ReadLine();
                    }
                    while (Provjera.ProvjeraStringa(Studos.Prezime) == string.Empty);

                    string Prosjek;
                    do
                    {                    
                        Console.WriteLine("Unesite prosjek studenta:");
                        Prosjek = Console.ReadLine();
                    }
                    while (Provjera.ProvjeraBroja(Prosjek) == string.Empty);
                    Studos.Prosjek = Convert.ToDouble(Prosjek);

                    PopisStudenata.Add(Studos);
                    Console.WriteLine("Ako želite dodati još jednog studenta na popis možete učiniti to naredbom 'ENLIST'," 
                        + " \na ako želite pregledati popis studenata možete to učiniti naredbom 'DISPLAY':");
                    Naredba = Console.ReadLine().Trim().ToLower();
                }
                    else if (Naredba != Operations.Display)
                {
                    Console.WriteLine("Pogrešan unos, molimo pokušajte ponovo:");
                    Naredba = Console.ReadLine().Trim().ToLower();
                }
            }
            while(Naredba != Operations.Display);

            int Brojac = 0;      
            List<Student> AbecedniPopis = new List<Student>();
            AbecedniPopis = PopisStudenata.OrderBy(Studenti => Studenti.Prezime).ToList();

            if (PopisStudenata.Count > 0)
            {
                Console.WriteLine("Popis upisanih studenata:");
            }
            else 
            {
                Console.WriteLine("Nema upisanih studenata.");            
            }

            foreach (Student Brucos in AbecedniPopis)
            {
                Brojac++;
                Console.WriteLine("{0}. {1}, {2} - prosjek: {3}", Brojac, Brucos.Prezime, Brucos.Ime, Brucos.Prosjek);
            }
            
            Console.WriteLine("Hvala Vam na korištenju naše aplikacije.");
            Console.ReadLine();
        }
    }
}