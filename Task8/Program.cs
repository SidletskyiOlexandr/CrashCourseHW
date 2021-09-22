using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] arr = { { 'h', 'r', 'k' }, { 'w', 'q', 'e' }, { 'a', 'q', 'y' } };
            string enteredWord = "key";
            
            int rows = arr.GetUpperBound(0) + 1;
            int columns = arr.Length / rows;
            char a=' ';
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if(arr[i,j]==enteredWord[i])
                    {
                        a = arr[i, j];
                        Console.WriteLine(a);
                    }
                }
            }
            
        }
    }
}
