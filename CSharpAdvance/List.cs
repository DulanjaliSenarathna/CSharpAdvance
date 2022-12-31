using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvance
{
   public class List
    {
        public void Add(int number)
        {
            throw new NotImplementedException();
        }

        public int this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    //Generic with multiple parameters
    public class GenericDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {

        }
    }

    public class GenericList<T> //T = Type/Template
    {
        public void Add(T value)
        {

        }

        public int this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
}
