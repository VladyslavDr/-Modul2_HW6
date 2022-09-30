using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class User
    {
        private CustomerCard _card;
        public User(string name, string phone)
        {
            _card = new CustomerCard();
            Name = name;
            Phone = phone;
        }

        public string Name { get; init; }
        public string Phone { get; init; }

        public CustomerCard Card => _card;
    }
}
