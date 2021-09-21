using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "This is a string with several words";

            //char[] arrStr = str.ToCharArray();
            string[] arrStr = str.Split();
            Array.Reverse(arrStr);

            foreach (var item in arrStr)
            {
                Console.Write(item + ' ');
            }
        }
    }
}
