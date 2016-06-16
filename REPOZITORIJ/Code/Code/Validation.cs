using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
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
}
