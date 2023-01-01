using System;
using System;
using System.Linq;

namespace System
{
    public static class StringExtension
    {
        public static string Shorten(this String str, int numberOfWords)
        {
            if (numberOfWords < 0)
                throw new ArgumentOutOfRangeException("numberOF Words must be grater than or equal to 0");
            if(numberOfWords == 0)
            {
                return "";
            }
            else
            {
                var words = str.Split(' ');

                if(words.Length <= numberOfWords)
                {
                    return str;
                }
                else
                {
                    return string.Join(" ", words.Take(numberOfWords)) + "...";
                }
            }
        }
    } 
}
