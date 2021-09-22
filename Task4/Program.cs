using System;

namespace Task4
{
    class Program
    {
        static public bool IsPalindrome(string s)
        {
            char[] charArray = s.ToCharArray();
            
            Array.Reverse(charArray);

            string res = string.Join("", charArray);
            
            if (String.Compare(s, res)!=0)
                return false;
            else
                return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Is 'key' palindrome: {IsPalindrome("key")}");
            Console.WriteLine($"Is 'level' palindrome: {IsPalindrome("level")}");
        }
    }
}
