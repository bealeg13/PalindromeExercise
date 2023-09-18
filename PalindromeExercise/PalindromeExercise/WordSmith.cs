using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string input)
        {
            //input = input.Replace(" ", "");

            //int length = input.Length;
            //for (int i = 0; i < length / 2; i++)
            //{
            //    if (input[i] != input[length - i - 1])
            //    {
            //        return false;
            //    }
            //}
            //return true;

            string reverseWord = new string(input.Reverse().ToArray());
            return input == reverseWord;
            
        }
    }
}
