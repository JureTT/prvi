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
            //List<Student> studentList = new List<Student>();
            StudentContainer students = new StudentContainer();

            Console.WriteLine("Poštovani upravo se pokrenuli aplikaciju za izradu popisa studenata.\nAplikacija ima dvije naredbe pomoću kojih se upravlja njome.\nPrva naredba je 'ENLIST' koja služi za upisivanje studenata i njihovih podataka,\ndruga naredba je 'DISPLAY' koja vrši ispis upisanih studenata. \nMolimo unesite željenu naredbu:");          
            String input = Console.ReadLine().Trim().ToLower();

            do
            {
                if (input == Operations.Enlist)
                {
                    Student academic = new Student();

                    Validation checkUp = new Validation();

                    do
                    {
                        Console.WriteLine("Unesite ime studenta:");
                        academic.Name = Console.ReadLine();
                        if (checkUp.StringLookUp(academic.Name))
                        {
                            Console.WriteLine("Neispravan unos molimo pokušajte ponovo");
                        }
                    }
                    while (checkUp.StringLookUp(academic.Name));

                    do
                    {
                        Console.WriteLine("Unesite prezime studenta:");
                        academic.Surname = Console.ReadLine();
                        if (checkUp.StringLookUp(academic.Surname))
                        {
                            Console.WriteLine("Neispravan unos molimo pokušajte ponovo");
                        }
                    }
                    while (checkUp.StringLookUp(academic.Surname));

                    string average = "";
                    do
                    {
                        Console.WriteLine("Unesite prosjek studenta:");
                        average = Console.ReadLine().Replace(".",",");    //// zamjena točke(.) zarezom(,) jer se decimalni broj označava zarezom
                        if (!checkUp.IntegerLookUp(average))
                        {
                            Console.WriteLine("Neispravan unos molimo pokušajte ponovo");
                        }
                    }
                    while (!checkUp.IntegerLookUp(average));
                    academic.Average = Convert.ToDouble(average);

                    students.AddStudent(academic);
                    Console.WriteLine("Ako želite dodati još jednog studenta na popis možete učiniti to naredbom 'ENLIST',\na ako želite pregledati popis studenata možete to učiniti naredbom 'DISPLAY':");
                    input = Console.ReadLine().Trim().ToLower();
                }
                    else if (input != Operations.Display)
                {
                    Console.WriteLine("Pogrešan unos, molimo pokušajte ponovo:");
                    input = Console.ReadLine().Trim().ToLower();
                }
            }
            while(input != Operations.Display);

            int studNum = students.SortStudents();

            if (studNum > 0)
            {
                Console.WriteLine("Popis upisanih studenata:");

                for (int i = 1; i <= studNum; i++)
                {
                    Student collegian = students.RetriveStudent(i);
                    Console.WriteLine("{0}. {1}, {2} - prosjek: {3}", collegian.Id, collegian.Surname, collegian.Name, collegian.Average);
                }
            
            }
            else 
            {
                Console.WriteLine("Nema upisanih studenata.");            
            }
                                    
            Console.WriteLine("Hvala Vam na korištenju naše aplikacije.");
            Console.ReadLine();
        }
    }
}