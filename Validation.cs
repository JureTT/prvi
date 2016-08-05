using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    public class Validation
    {
        public bool StringLookUp(string word)
        {
            return string.IsNullOrWhiteSpace(word);
        }
        public bool IntegerLookUp (string number)
        {
            double average;
            return double.TryParse(number, out average);
        }
    }
}
