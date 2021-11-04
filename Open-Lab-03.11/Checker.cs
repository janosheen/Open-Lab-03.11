using System;
using System.Linq;


namespace Open_Lab_03._11
{
    public class Checker
    {
        public bool IsPalindrome(string str)
        {
            string firstHalf = str.Substring(0, str.Length / 2);
            char[] arr = str.ToCharArray();

            Array.Reverse(arr);

            string str2 = new string(arr);
            string secondHalf = str2.Substring(0, str2.Length / 2);
            return firstHalf.Equals(secondHalf);
        }
    } 
}
