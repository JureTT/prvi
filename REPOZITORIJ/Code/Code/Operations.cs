using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    public class Operations
    {
        public static Student enlist()
        {
            Student studos = new Student();

        UnosImena:
            Console.WriteLine("Unesite ime studenta:");
            studos.Ime = Console.ReadLine();
            if (Validation.provjeraStringa(studos.Ime) == false)
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

        public static void display(List<Student> lista)
        {
            int brojac = 0;      ////// ***
            List<Student> abecedniPopis = new List<Student>();
            abecedniPopis = lista.OrderBy(studenti => studenti.Prezime).ToList();  //"studenti" je varijabla, nema nikakvo posebno začenje 
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
    }
}
