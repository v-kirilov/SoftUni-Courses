using System;
using System.Collections.Generic;
using System.Linq;

namespace P02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .ToLower()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (var item in input)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict.Add(item, 1);
                }
            }

            foreach (var word in dict)
            {
                if (word.Value % 2!=0)
                {
                    Console.Write(word.Key + " ");
                }
            }

        }
    }
}
