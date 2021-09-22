using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some string: ");
            string str = Console.ReadLine();

            for (int i = str.IndexOf('.'); i < str.LastIndexOf('.'); i++)
            {
                if(str[i]==' ')
                {
                    str = str.Remove(i, 1);
                }
            }
            Console.WriteLine(str);
        }
    }
}
