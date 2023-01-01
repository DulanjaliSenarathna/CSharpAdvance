using System;

namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = "Dil";
            obj.GetHashCode(); // can directly access

            //with reflections, it's hard
            var methodInfo = obj.GetType().GetMethod("GetHashCode");
            methodInfo.Invoke(null, null);

            dynamic exelObject = "dul";
            exelObject.Optimize();

            dynamic name = "Mosh"; //run time type is string
            name = 10;//run time type int

            dynamic a = 10;
            dynamic b = 5;
            var c = a+b; //a and b are dynamic. because of that c is also dynamic

            int i = 5;
            dynamic d = 1; //d is dynamic, but run time type is int
            long l = d;
        }
    }
}
