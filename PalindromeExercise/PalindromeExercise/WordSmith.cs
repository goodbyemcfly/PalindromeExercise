using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            var stringAsCharArray = word.ToCharArray();
            Array.Reverse(stringAsCharArray);

            /* if (word == new string(stringAsCharArray))
            {
                return true;
            }
            else
            {
                return false;
            } */

            return word.SequenceEqual(stringAsCharArray);
        }
    }
}
