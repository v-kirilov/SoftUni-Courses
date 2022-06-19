using System;
using System.Collections.Generic;
using System.Linq;

namespace Telerik_Mock_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string anagramOriginal = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string anagram = anagramOriginal;
                string input = Console.ReadLine();
                if (anagram.Length != input.Length)
                {
                    Console.WriteLine("No");
                    continue;
                }
                char[] anaChar = anagram.ToLower().ToCharArray();
                char[] inputChar = input.ToLower().ToCharArray();

                Array.Sort(inputChar);
                Array.Sort(anaChar);
                bool isAnagram = true;

                for (int j = 0; j < anaChar.Length; j++)
                {
                    if (anaChar[j] != inputChar[j])
                    {
                        Console.WriteLine("No");
                        isAnagram = false;
                        break;
                    }
                }
                if (isAnagram)
                {
                    Console.WriteLine("Yes");
                }
            }
        }
    }
}
