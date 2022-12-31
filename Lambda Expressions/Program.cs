using System;

namespace Lambda_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //lambda expression 
            //agruments => expression (=> - goes to)

            //if we don't need arguments ,
            // () => ...

            //if we have only 1 argument
            // x => ..

            //Example 1

            Func<int, int> square = num => num * num;
            Console.WriteLine(square(5));

            //Example 2
            const int factor = 5;

            Func<int, int> multiplier = number => number * factor;
            var result = multiplier(10);
            Console.WriteLine(result);

            //Example3

            var books = new BookRepository().GetBooks();
            var cheaperBooks = books.FindAll(book => book.price<10); //lambda expression

            foreach(var book in cheaperBooks)
            {
                Console.WriteLine(book.Title);
            }
        }

       
    }
}
