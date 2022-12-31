using System;
using System.Collections.Generic;
using System.Text;

namespace Lambda_Expressions
{
   public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title="Title1", price=12},
                new Book() {Title="Title2", price=1},
                new Book() {Title="Title3", price=2},
            };
        } 
    }
}
