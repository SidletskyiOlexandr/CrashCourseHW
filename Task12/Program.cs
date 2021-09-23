using System;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Remove all words from the string which have less than five characters.";
            string res = null;
            
            string[] arr = str.Split();

            foreach (var item in arr)
            {
                if (item.Length>=5)
                {
                    res += item + ' '; 
                }
            }
            res = res.Trim();

            Console.WriteLine($"'{res}'");
        }
    }
}
