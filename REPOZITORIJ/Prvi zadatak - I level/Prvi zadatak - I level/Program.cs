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
            List<Student> studentList = new List<Student>();

            Console.WriteLine("Poštovani upravo se pokrenuli aplikaciju za izradu popisa studenata.\nAplikacija ima dvije naredbe pomoću kojih se upravlja njome.\nPrva naredba je 'ENLIST' koja služi za upisivanje studenata i njihovih podataka,\ndruga naredba je 'DISPLAY' koja vrši ispis upisanih studenata. \nMolimo unesite željenu naredbu:");          
            String input = Console.ReadLine().Trim().ToLower();

            StudentIdGenerator generator = StudentIdGenerator.making();

            do
            {
                if (input == Operations.enlist)
                {
                    Student academic = new Student();

                    Validation checkUp = new Validation();

                    do
                    {
                        Console.WriteLine("Unesite ime studenta:");
                        academic.name = Console.ReadLine();
                        if (checkUp.checkingString(academic.name) == true)
                        {
                            Console.WriteLine("Neispravan unos molimo pokušajte ponovo");
                        }
                    }
                    while (checkUp.checkingString(academic.name) == true);

                    do
                    {
                        Console.WriteLine("Unesite prezime studenta:");
                        academic.surname = Console.ReadLine();
                        if (checkUp.checkingString(academic.surname) == true)
                        {
                            Console.WriteLine("Neispravan unos molimo pokušajte ponovo");
                        }
                    }
                    while (checkUp.checkingString(academic.surname) == true);

                    string average = "";
                    do
                    {
                        Console.WriteLine("Unesite prosjek studenta:");
                        average = Console.ReadLine().Replace(".",",");    //// zamjena točke(.) zarezom(,) jer se decimalni broj označava zarezom
                        if (checkUp.checkingInt(average) == false)
                        {
                            Console.WriteLine("Neispravan unos molimo pokušajte ponovo");
                        }
                    }
                    while (checkUp.checkingInt(average) == false);
                    academic.average = Convert.ToDouble(average);

                    studentList.Add(academic);
                    Console.WriteLine("Ako želite dodati još jednog studenta na popis možete učiniti to naredbom 'ENLIST',\na ako želite pregledati popis studenata možete to učiniti naredbom 'DISPLAY':");
                    input = Console.ReadLine().Trim().ToLower();
                }
                    else if (input != Operations.display)
                {
                    Console.WriteLine("Pogrešan unos, molimo pokušajte ponovo:");
                    input = Console.ReadLine().Trim().ToLower();
                }
            }
            while(input != Operations.display);

            List<Student> alphabetList = new List<Student>();
            alphabetList = studentList.OrderBy(students => students.surname).ToList();

            if (studentList.Count > 0)
            {
                Console.WriteLine("Popis upisanih studenata:");
            }
            else 
            {
                Console.WriteLine("Nema upisanih studenata.");            
            }

            foreach (Student graduate in alphabetList)
            {
                graduate.Id = generator.Id();
                Console.WriteLine("{0}. {1}, {2} - prosjek: {3}", graduate.Id, graduate.surname, graduate.name, graduate.average);
            }
                        
            Console.WriteLine("Hvala Vam na korištenju naše aplikacije.");
            Console.ReadLine();
        }
    }
}