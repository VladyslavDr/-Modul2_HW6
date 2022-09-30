using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public abstract class TechnicalLiterature : Book
    {
        public TechnicalLiterature(string name, DateTime time, int namberOfPages, Autor autor, ThematicArea area)
            : base(name, time, namberOfPages, autor)
        {
            Area = area;
        }

        public ThematicArea Area { get; init; }
    }
}
