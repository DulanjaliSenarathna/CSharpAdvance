using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            //LINQ Query operators
            var cheaperBooks = from b in books
                               where b.Price < 10 //LINQ Query operators always start from the 'where', always end with 'select'
                               orderby b.Title
                               select b.Title;

            //var cheapBooks = new List<Book>();
            //foreach(var book in books) intead of these 5 lines we can use Where method to filter collection
            //{
            //    if(book.Price < 10)
            //    cheapBooks.Add(book);
            //}
            //LINQ Extension Methods
            //Select - use for tranformations (Select only title proprty)
            var cheapBooks = books
                .Where(book => book.Price < 10)
                .OrderBy(b => b.Title)
                .Select( b => b.Title);//Links all methods , OrderBy = Sorting the results

            //Single method - retrive single object
            //SingleOrDefault - if serach item does not exist, return null , while Single getting exception
             var book1 = books.Single(b => b.Title == "C#");
            Console.WriteLine(book1.Title);

            //First - Get first serach item that ful fil search requirement
            //FirstOrDefault - if serach item does not exist, return null , while 'First' getting exception 
            var first = books.First(b => b.Title == "ASP.Net MVC step by step");//optionally can pass predicate as parameter .

            Console.WriteLine(first.Title + ""+ first.Price);

            //Last - Get last serach item that ful fil search requirement
            //LastOrDefault - if serach item does not exist, return null , while 'Last' getting exception 
            var last = books.Last(b => b.Title == "ASP.Net MVC step by step");//optionally can pass predicate as parameter 

            Console.WriteLine(last.Title + "" + last.Price);
            Console.WriteLine();

            //skip and take methods - skip 2 items and take 3 items
            var newBook = books.Skip(2).Take(3);
            foreach(var book in newBook)
            {
                Console.WriteLine(book.Title);
            }

            //Count method

            var count = books.Count();
            Console.WriteLine(count);

            //Max method
            var max = books.Max(b => b.Price);
            Console.WriteLine(max);

            //Min method
            var min = books.Min(b => b.Price);
            Console.WriteLine(min);

            //Sum method
            var sum = books.Sum(b => b.Price);
            Console.WriteLine(sum);

            //Average
            var avg = books.Average(b => b.Price);
            Console.WriteLine(avg);


            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book);
               // Console.WriteLine(book.Title + ""+book.Price);
            }
        }
    }
}
