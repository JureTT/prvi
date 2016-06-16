using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    class StudentIdGenerator      ////// zakomentirati cijelu klasu za varijantu sa slanjem cijele liste u singleton (***)
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
}
