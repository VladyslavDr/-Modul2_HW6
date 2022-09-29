using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public abstract class Prose : Fiction
    {
        public Prose(string name, DateTime time, int namberOfPages, Autor autor, LiteraryDirection direction, Genre genre)
            : base(name, time, namberOfPages, autor, direction)
        {
            Genre = genre;
        }

        public Genre Genre { get; init; }
    }
}
