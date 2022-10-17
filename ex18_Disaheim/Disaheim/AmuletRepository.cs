using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class AmuletsRepository
    {
        private List<Book> books = new List<Book>();


        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public Book GetBook(string ItemId)
        {
            if(ItemId == null)
            {
                return null;
            }
            else
            {
                ItemId = ItemId.ToString();
            }
        }

         
    }
}
