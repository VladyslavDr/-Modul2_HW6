using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Autor
    {
        public Autor(string fname, string lname, string alias)
        {
            FirstName = fname;
            LastName = lname;
            Alias = alias;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Alias { get; set; }
    }
}
