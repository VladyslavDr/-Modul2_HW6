using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class MethodExtension
    {
        public static void NameSearch(this Book[] books, string name)
        {
            foreach (var book in books)
            {
                if (book != null && book.Name.ToLower().Equals(name.ToLower()))
                {
                    Console.WriteLine($"Name: {book.Name};");
                    if (book.Autor == null)
                    {
                        Console.WriteLine($"Autor: Folk Art;");
                    }
                    else
                    {
                        Console.WriteLine($"Autor: {book.Autor.FirstName} {book.Autor.LastName};");
                    }

                    Console.WriteLine($"Number of pages: {book.NumberOfPages};");
                    Console.WriteLine($"Date of issue: {book.Time.Year};");
                    Console.WriteLine();
                }
            }
        }
    }
}
