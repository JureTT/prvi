using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    public class StudentIdGenerator
    {
        private static StudentIdGenerator Generator;

        protected StudentIdGenerator()
        {            
        }

        public static StudentIdGenerator Instance()
        {
            if (Generator == null)
            {
                Generator = new StudentIdGenerator();
            }
            return Generator;
        }
        
        private int idNumber = 1000;
        public int CreatingId()
        {
            idNumber = idNumber + 1;
            return idNumber;
        }
    }
}
