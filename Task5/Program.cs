using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "My name is Olexandr";
            int wordIndex = 2;
            string[] arrStr = str.Split(' ');
            Console.WriteLine($"{arrStr[wordIndex-1][0]}");
        }
    }
}