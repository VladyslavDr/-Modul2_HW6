using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Library
    {
        private Library _instance;

        private Library()
        {
            Books = new Book[]
            {
                new Tale(
                    name: "Колобок",
                    time: new DateTime(1800, 01, 01),
                    numberOfPages: 21,
                    autor: null,
                    direction: LiteraryDirection.Epic,
                    genre: Genre.Folklore),
                new Tale(
                    name: "Гуси-лебеди",
                    time: new DateTime(1949, 12, 08),
                    numberOfPages: 42,
                    autor: new Autor(fname: "Алексей", lname: "Толстой", alias: null),
                    direction: LiteraryDirection.Epic,
                    genre: Genre.Folklore),
                new Tale(
                    name: "Репка",
                    time: new DateTime(1863, 07, 11),
                    numberOfPages: 10,
                    autor: null,
                    direction: LiteraryDirection.Epic,
                    genre: Genre.Folklore),
                new Poem(
                    name: "Двенадцать",
                    time: new DateTime(1918, 01, 09),
                    numberOfPages: 8,
                    autor: new Autor(fname: "Александр", lname: "Блок", null),
                    direction: LiteraryDirection.Drama,
                    rhyme: "aaab",
                    metric: Metric.Dactyl,
                    numberOfVerses: 120),
                new Poem(
                    name: "Облако в штанах",
                    time: new DateTime(1915, 09, 03),
                    numberOfPages: 43,
                    autor: new Autor(fname: "Маяковский", lname: "Владимир", null),
                    direction: LiteraryDirection.Lyric,
                    rhyme: "abab",
                    metric: Metric.Dactyl,
                    numberOfVerses: 120),
                new Comic(
                    name: "Spyder Man",
                    time: new DateTime(1962, 08, 01),
                    numberOfPages: 8,
                    autor: new Autor(fname: "Sten", lname: "Lee", alias: "Good man"),
                    direction: LiteraryDirection.Epic,
                    genre: Genre.Fantastic,
                    type: ComicType.MARVEL)
            };
        }

        public Book[] Books { get; init; }

        public Library GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Library();
            }

            return _instance;
        }
    }
}
