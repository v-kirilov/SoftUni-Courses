using System;
using System.Linq;

namespace P01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            while (word!="end")
            {
                char[] reversedWord = word.ToCharArray();
                reversedWord = reversedWord.Reverse().ToArray();
                string end = new string(reversedWord);

                Console.WriteLine($"{word} = {end}");
                word = Console.ReadLine();
            }
            
        }
    }
}
