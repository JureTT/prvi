using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvi_zadatak___I_level
{
    static class Validation
    {
        public static bool provjeraStringa(string pojam)
        {
            if (string.IsNullOrWhiteSpace(pojam))
            {
                return false;
            }
            else 
            {
                return true;
            }
        }
        public static bool provjeraBroja(string broj)
        {
            double prosjek;
            if (double.TryParse(broj, out prosjek) == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
    static class Operations
    {
        public static Student enlist()
        {
            Student studos = new Student();

            UnosImena:
            Console.WriteLine("Unesite ime studenta:");
            studos.Ime = Console.ReadLine();
            if(Validation.provjeraStringa(studos.Ime) == false)
            {
                Console.WriteLine("Neispravan unos imena studenta, molimo pokušajte ponovo.");
                goto UnosImena;
            }

            UnosPrezimena:
            Console.WriteLine("Unesite prezime studenta:");
            studos.Prezime = Console.ReadLine();
            if (Validation.provjeraStringa(studos.Prezime) == false)
            {
                Console.WriteLine("Neispravan unos prezimena studenta, molimo pokušajte ponovo.");
                goto UnosPrezimena;
            }

            UnosProsjeka:
            Console.WriteLine("Unesite prosjek studenta:");
            string prosjek = Console.ReadLine();
            if (Validation.provjeraBroja(prosjek) == true)
            {
                studos.Prosjek = Convert.ToDouble(prosjek);
            }
            else 
            {
                Console.WriteLine("Neispravan unos prosječne ocjene studenta, molimo pokušajte ponovo.");
                goto UnosProsjeka;
            }
            return studos;
        }

        public static void display()
        {
            Console.WriteLine("Pero Bero druga naredba će doći ovdje ");
        }
    }

    abstract class Person
    {
        public string redniBroj;
        public string Ime;
        public string Prezime;
    }

    class Student : Person 
    {
        public double Prosjek;
    }

    class StudentIdGenerator              ////// zakomentirati cijelu klasu za varijantu sa slanjem cijele liste u singleton (***)
    {
        private static StudentIdGenerator redni;

        protected StudentIdGenerator(Student studic)
        {
            studic.redniBroj = rBr.ToString() + ".";
        }

        public static StudentIdGenerator dodjelaRednog(Student akademac)
        {
            if (redni == null)
            {
                redni = new StudentIdGenerator(akademac);
            }

            return redni;
        }
        public static void Reset()
        {
            redni = null;
        }
        public static int rBr;

    }

    //class StudentIdGenerator       ////// otkomentirati za varijantu sa slanjem cijele liste u singleton
    //{
    //    private static StudentIdGenerator redni;

    //    protected StudentIdGenerator(List<Student> fakultet)
    //    {
    //        int i = 0;
    //        foreach (Student osoba in fakultet)
    //        {
    //            i++;
    //            osoba.redniBroj = i.ToString() + ".";
    //        }

    //    }

    //    public static StudentIdGenerator dodjelaRednog(List<Student> studenti)
    //    {
    //        if (redni == null)
    //        {
    //            redni = new StudentIdGenerator(studenti);
    //        }

    //        return redni;
    //    }
    //}

    class Program
    {
        static void Main()
        {
            int brojac = 0;      ////// ***

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
                List<Student> abecedniPopis = new List<Student>();
                abecedniPopis = popisStudenata.OrderBy(studenti => studenti.Prezime).ToList();  //"studenti" je varijabla, nema nikakvo posebno začenje 
                //StudentIdGenerator.dodjelaRednog(abecedniPopis);           ////// ***

                foreach (Student brucos in abecedniPopis)
                {
                    brojac++;        ////// ***
                    StudentIdGenerator.rBr = brojac;       ////// ***
                    StudentIdGenerator.dodjelaRednog(brucos);       ////// ***
                    Console.WriteLine(brucos.redniBroj + " " + brucos.Prezime + ", " + brucos.Ime + " - prosjek: " + brucos.Prosjek);
                    StudentIdGenerator.Reset();          ////// ***
                }
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