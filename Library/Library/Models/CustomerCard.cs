using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class CustomerCard : ITemplateCustomerCard
    {
        private Book[] _books;
        private int _counter;

        public CustomerCard()
        {
            _books = new Book[5];
        }

        public void SortByName()
        {
            Array.Sort(_books);
        }

        public int TotalNumberOfPages()
        {
            var counter = 0;

            for (int index = 0; index < _counter; index++)
            {
                counter += _books[index].NumberOfPages;
            }

            return counter;
        }

        public void AddItem(Book book)
        {
            if (_counter < 5)
            {
                _books[_counter++] = book;
            }
        }

        public void RemoveItem(Book book)
        {
            {
                bool status = false;

                for (int index = 0; index < _counter - 1; index++)
                {
                    if (book == _books[index])
                    {
                        status = true;
                    }

                    if (status)
                    {
                        _books[index] = _books[index + 1];
                    }
                }

                if (_counter > 0)
                {
                    _counter--;
                }
                else
                {
                    _counter = 0;
                }
            }
        }

        public void ShowCustomerCard()
        {
            for (int index = 0; index < _counter; index++)
            {
                if (_books[index] == null)
                {
                    _counter++;
                    continue;
                }

                Console.WriteLine($"Name: {_books[index].Name};");
                if (_books[index].Autor == null)
                {
                    Console.WriteLine($"Autor: Folk Art;");
                }
                else
                {
                    Console.WriteLine($"Autor: {_books[index].Autor.FirstName} {_books[index].Autor.LastName};");
                }

                Console.WriteLine($"Number of pages: {_books[index].NumberOfPages};");
                Console.WriteLine($"Date of issue: {_books[index].Time.Year};");
                Console.WriteLine();
            }
        }
    }
}
