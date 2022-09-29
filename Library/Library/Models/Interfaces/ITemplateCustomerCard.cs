using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public interface ITemplateCustomerCard
    {
        public int TotalNumberOfPages();
        public void AddItem(Book book);
        public void RemoveItem(Book book);
        void ShowCustomerCard();
    }
}
