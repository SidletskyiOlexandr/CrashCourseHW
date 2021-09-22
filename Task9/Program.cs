using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "This   is a  Task9     ";

            str = str.Trim();

            for (int i = 0; i < str.Length-1; i++)
            {
                if ( str[i] == ' ' && str[i+1] == ' ' )
                {
                    str = str.Remove(i,1);
                    i--;
                }
            }
                        
            Console.WriteLine($"'{str.Replace(' ', '*')}'");
        }
    }
}
