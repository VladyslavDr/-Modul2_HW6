using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Comic : Prose
    {
        public Comic(string name, DateTime time, int numberOfPages, Autor autor, LiteraryDirection direction, Genre genre, ComicType type)
            : base(name, time, numberOfPages, autor, direction, genre)
        {
            Type = type;
        }

        public ComicType Type { get; init; }
    }
}
