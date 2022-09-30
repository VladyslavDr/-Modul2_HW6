using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Tale : Prose
    {
        public Tale(string name, DateTime time, int numberOfPages, Autor autor, LiteraryDirection direction, Genre genre)
            : base(name, time, numberOfPages, autor, direction, genre)
        {
        }
    }
}
