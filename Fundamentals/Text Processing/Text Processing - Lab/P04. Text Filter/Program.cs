using System;

namespace P04._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);
            string input = Console.ReadLine();

            //for (int i = 0; i < bannedWords.Length; i++)
            //{
            //    string word = bannedWords[i];
            //    string replace = string.Empty;
            //    for (int j = 0; j < word.Length; j++)
            //    {
            //        replace += "*";
            //    }
            //    while (input.Contains(word))
            //    {
            //        int index = input.IndexOf(word);
            //        input = input.Replace(word, replace);
            //    }
            //}
            foreach (var word in bannedWords)
            {
                input = input.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(input);
        }
    }
}
