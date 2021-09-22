using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "abcdefg", "qwerty123", "abc", "1234567" };
            int wordLength = 7;
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length == wordLength)
                {
                    for (int j = 1; j < 4; j++)
                    {
                        arr[i] = arr[i].Replace(arr[i][wordLength - j], '$');
                    }
                }
                Console.WriteLine(arr[i]);
            }
        }
    }
}
