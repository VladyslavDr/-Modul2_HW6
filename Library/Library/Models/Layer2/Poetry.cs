using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public abstract class Poetry : Fiction
    {
        public Poetry(string name, DateTime time, int numberOfPages, Autor autor, LiteraryDirection direction, string rhyme, Metric metric)
            : base(name, time, numberOfPages, autor, direction)
        {
            Rhyme = rhyme;
            Metric = metric;
        }

        public string Rhyme { get; init; }
        public Metric Metric { get; init; }
    }
}
