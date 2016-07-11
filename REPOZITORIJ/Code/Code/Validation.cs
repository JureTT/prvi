using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    public class Validation
    {
        public string ProvjeraStringa(string Pojam)
        {
            if (string.IsNullOrWhiteSpace(Pojam))
            {
                Console.WriteLine("Neispravan unos, molimo pokušajte ponovo.");
                return string.Empty;
            }
            else
            {
                return Pojam;                
            }
        }
        public string ProvjeraBroja(string Broj)
        {
            double Prosjek;
            if (double.TryParse(Broj, out Prosjek))
            {
                return Broj;
            }
            else
            {
                Console.WriteLine("Neispravan unos, molimo pokušajte ponovo.");
                return string.Empty;
            }

        }
    }
}
