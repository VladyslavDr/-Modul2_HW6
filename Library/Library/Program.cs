using System;

namespace Library
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var library = Library.GetInstance();
            var user1 = new User(name: "Vlad", phone: "+380123456789");

            user1.Card.AddItem(library.Books[0]);
            user1.Card.AddItem(library.Books[1]);
            Console.WriteLine(user1.Card.TotalNumberOfPages());
            user1.Card.ShowCustomerCard();

            user1.Card.RemoveItem(library.Books[0]);

            Console.WriteLine("Remove:");
            Console.WriteLine(user1.Card.TotalNumberOfPages());
            user1.Card.ShowCustomerCard();

            Console.WriteLine("Add new books");
            user1.Card.AddItem(library.Books[5]);
            user1.Card.AddItem(library.Books[3]);
            user1.Card.AddItem(library.Books[4]);
            user1.Card.AddItem(library.Books[0]);
            user1.Card.ShowCustomerCard();

            Console.WriteLine("Sort by name:");
            user1.Card.SortByName();
            user1.Card.ShowCustomerCard();

            Console.WriteLine("Show Колобок");
            user1.Card.ShowItem("Колобок");
        }
    }
}
