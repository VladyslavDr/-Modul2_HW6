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

            user1.Card.ShowCustomerCard();

            user1.Card.RemoveItem(library.Books[0]);

            Console.WriteLine("Remove");
            user1.Card.ShowCustomerCard();
        }
    }
}
