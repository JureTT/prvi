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

        public static StudentIdGenerator Stvaranje()
        {
            if (Generator == null)
            {
                Generator = new StudentIdGenerator();
            }

            return Generator;
        }

        public Guid Id
        {
            get
            {
                Guid Ide = Guid.NewGuid();
                return Ide;
            }
        }
    }
}
