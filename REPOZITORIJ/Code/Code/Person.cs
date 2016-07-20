using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    public abstract class Person
    {
        protected int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string name { get; set; }
        public string surname { get; set; }
    }
}
