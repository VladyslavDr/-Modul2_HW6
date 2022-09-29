using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Dictionary : TechnicalLiterature
    {
        public Dictionary(string name, DateTime time, int namberOfPages, Autor autor, ThematicArea area, Country country1, Country country2)
            : base(name, time, namberOfPages, autor, area)
        {
            Country1 = country1;
            Country2 = country2;
        }

        public Country Country1 { get; init; }
        public Country Country2 { get; init; }
    }
}
