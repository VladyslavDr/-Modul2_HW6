using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Phonebook : TechnicalLiterature
    {
        public Phonebook(string name, DateTime time, int namberOfPages, Autor autor, ThematicArea area, int code)
            : base(name, time, namberOfPages, autor, area)
        {
            CountryCode = code;
        }

        public int CountryCode { get; init; }
    }
}
