using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    public abstract class Person
    {
        protected Guid Id;
        public Guid ID
        {
            get { return Id; }
            set { Id = value; }
        }
        public string Ime { get; set; }
        public string Prezime { get; set; }
    }
}
