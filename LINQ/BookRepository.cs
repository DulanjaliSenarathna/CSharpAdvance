using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book(){ Title = "ADO.Net step by step", Price=5 },
                new Book(){ Title = "ASP.Net MVC step by step", Price=5 },
                new Book(){ Title = "ASP.Net MVC step by step", Price=6 },
                new Book(){ Title = "ASP.Net API step by step", Price=5 },
                new Book(){ Title = "C#", Price=5 },
                new Book(){ Title = "C# Advance", Price=5 },
            };
        }
    }
}
