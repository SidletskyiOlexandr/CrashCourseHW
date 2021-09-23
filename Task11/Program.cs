using System;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "a 10,2 3 v 5,3 A 1 2", intStr = null, floatStr = null, otherStr = null;
            string[] arr = str.Split();

            foreach (var item in arr)
            {
                if (int.TryParse(item, out int a))
                    intStr += item;
                
                else if(float.TryParse(item, out float b))
                    floatStr += item;

                else
                    otherStr += item;
            }
            
            Console.WriteLine($"int string: {intStr}\nfloat string: {floatStr}\nother string: {otherStr}");
        }
    }
}
