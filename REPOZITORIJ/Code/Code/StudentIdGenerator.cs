using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    public class StudentIdGenerator
    {
        private static StudentIdGenerator generator;

        protected StudentIdGenerator()
        {            
        }

        public static StudentIdGenerator making()
        {
            if (generator == null)
            {
                generator = new StudentIdGenerator();
            }
            return generator;
        }
        
        private int id;
        public int Id()
        {
            id = id + 1;
            return id;
        }
    }
}
