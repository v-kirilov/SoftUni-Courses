using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            Dictionary<string,int> dict = new Dictionary<string,int>();

            string namePatern = @"[A-Za-z]";
            string numberPatern = @"\d"; 

            string input = Console.ReadLine();
            while (input!= "end of race")
            {
                MatchCollection name = Regex.Matches(input, namePatern);
                MatchCollection numbers = Regex.Matches(input, numberPatern);
                string person = string.Empty;
                foreach (Match item in name)
                {
                    person += item.Value;
                }
                int points = 0;
                foreach (Match match in numbers)
                {
                    points+=int.Parse(match.Value);
                }

                if (names.Contains(person))
                {
                    if (dict.ContainsKey(person))
                    {
                        dict[person] += points;
                    }
                    else
                    {
                        dict.Add(person, points);
                    }
                }
                
                input = Console.ReadLine();
            }

            dict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x=>x.Value);

            List<string> finalStanding = new List<string>();
            foreach (var persons in dict)
            {
                finalStanding.Add(persons.Key);
            }

            Console.WriteLine($"1st place: {finalStanding[0]}");
            Console.WriteLine($"2nd place: {finalStanding[1]}");
            Console.WriteLine($"3rd place: {finalStanding[2]}");
        }
    }
}
