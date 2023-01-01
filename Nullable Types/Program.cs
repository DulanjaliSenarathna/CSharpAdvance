using System;

namespace Nullable_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = null;
            Console.WriteLine("GetValueOrDefault" + date.GetValueOrDefault());
            Console.WriteLine("HasValue"+date.HasValue);
            Console.WriteLine("Value"+date.Value);//get exception, because date has not a value
            

            DateTime? date1 = new DateTime(2014, 01, 01);
            DateTime date2 = date1.GetValueOrDefault(); //can't be 'DateTime date2 = date1' because we try to equal nullable an normal datetime.so we shoul get GetValueOrDefault to date1
            DateTime? date3 = date1;// both are nullable, so we don't need casting
            date3 = date2; //can be equal, because date2 is converted to nullable

            Console.WriteLine(date2);

            //Nul Coalescing Operator

            //if(date != null)
            //{
            //    date4 = date.GetValueOrDefault();
            //}
            //else
            //{
            //    date4 = DateTime.Today;
            //}

            //without above, if else, we can use Nul Coalescing Operator
            DateTime date4 = date ?? DateTime.Today; //if date has value, put it in date4, if not, return today date
           
            DateTime date5 = (date != null) ? date.GetValueOrDefault() : DateTime.Today; //similar to above 34 line

            Console.WriteLine(date4);
        }
    }
}
