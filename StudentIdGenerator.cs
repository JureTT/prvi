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

        public static StudentIdGenerator Making()
        {
            if (Generator == null)
            {
                Generator = new StudentIdGenerator();
            }
            return Generator;
        }
        
        private int IdNumber;
        public int Id()
        {
            IdNumber = IdNumber + 1;
            return IdNumber;
        }
    }
}
