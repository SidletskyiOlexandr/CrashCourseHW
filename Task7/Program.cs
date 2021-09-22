using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "SoMe TexT with LoWeR aNd UPPer lettER.";
            int numLowerLetter=0, numUpperLetter=0;

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]) == true)
                    numUpperLetter++;
                else
                    numLowerLetter++;
            }

            Console.WriteLine($"Lower: {numLowerLetter*100.0/str.Length}% " +
                $"Upper: {numUpperLetter * 100.0 / str.Length}% ");
        }
    }
}
