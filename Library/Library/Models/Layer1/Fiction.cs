using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public abstract class Fiction : Book
    {
        public Fiction(string name, DateTime time, int numberOfPages, Autor autor, LiteraryDirection direction)
            : base(name, time, numberOfPages, autor)
        {
            Direction = direction;
        }

        public LiteraryDirection Direction { get; init; }
    }
}
