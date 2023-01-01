using System;
using System.Collections.Generic;
using System.Linq;

namespace Extension_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is supposed to be a very log blog post bla bla bla bla...";
            var shortenedPost = post.Shorten(5);

           IEnumerable<int> numbers = new List<int>() { 5, 8, 6, 4 };
           var max= numbers.Max();//extension method real world example

            Console.WriteLine(max);


            System.Console.WriteLine(shortenedPost);
        }
    }
}
