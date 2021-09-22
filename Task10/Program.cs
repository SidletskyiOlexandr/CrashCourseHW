using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "This is a Task10 ababab";

            string res = null;
            int largestLeangth = 0;

            string[] arr = str.Split(' ');

            foreach (var item in arr)
            {
                if(item.Length >= largestLeangth)
                {
                    largestLeangth = item.Length;
                }
            }
            foreach (var item in arr)
            {
                if (item.Length == largestLeangth)
                {
                    res += item.Replace('a', 'b') + " ";
                }
                else
                    res += item + " ";
            }
            res = res.Trim();
            Console.WriteLine($"'{res}'");
        }
    }
}
