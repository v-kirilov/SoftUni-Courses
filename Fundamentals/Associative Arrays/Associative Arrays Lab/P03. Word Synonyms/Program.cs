using System;
using System.Linq;
using System.Collections.Generic;

namespace P03._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();


                if (dict.ContainsKey(word) == false)
                {
                    dict.Add(word, new List<string>() { synonym });
                }
                else
                {
                    dict[word].Add(synonym);
                }

            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}
