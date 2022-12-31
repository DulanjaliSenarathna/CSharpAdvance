using System;

namespace CSharpAdvance
{
    //5 types of genaric constraints
    //T:IComparable
    //T:Product (apply constraint to a class or sub classes)
    //T: struct (value type)
    //T:class (reference type)
    //T:new()
    public class Utilities <T> where T:IComparable, new()
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public void DoSomething(T value)
        {
            var obj = new T();
        }

        //Generic type of above method
        public T Max(T a, T b)
        {
            
            return a.CompareTo(b) > 0 ? a : b;//we can't compare a and b, because we don't know what type a and b are
        }

    }
}
