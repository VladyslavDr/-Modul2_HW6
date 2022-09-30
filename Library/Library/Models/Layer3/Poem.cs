using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Poem : Poetry
    {
        public Poem(string name, DateTime time, int numberOfPages, Autor autor, LiteraryDirection direction, string rhyme, Metric metric, int numberOfVerses)
            : base(name, time, numberOfPages, autor, direction, rhyme, metric)
        {
            NumberOfVerses = numberOfVerses;
        }

        public int NumberOfVerses { get; init; }
    }
}
