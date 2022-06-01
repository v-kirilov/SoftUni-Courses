using System;
using System.Linq;
using System.Collections.Generic;

namespace P11._Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();

            while (input != "no more time")
            {
                string[] cmdArgs = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string username = cmdArgs[0];
                string contest = cmdArgs[1];
                int points = int.Parse(cmdArgs[2]);

                if (!dict.ContainsKey(contest))
                {
                    dict[contest] = new Dictionary<string, int>()
                    {
                        {username,points }
                    };
                }
                else if (!dict[contest].ContainsKey(username))
                {
                    dict[contest].Add(username, points);
                }
                else if (dict[contest][username] < points)
                {
                    dict[contest][username] = points;
                }

                dict[contest] = dict[contest].OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

                input = Console.ReadLine();
            }

            int counter = 1;
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count} participants");
                counter = 1;
                foreach (var contest in item.Value)
                {
                    Console.WriteLine($"{counter}. {contest.Key} <::> {contest.Value}");
                    counter++;
                }
            }

            Console.WriteLine($"Individual standings:");
            Dictionary<string,int> standings = new Dictionary<string,int>();

            foreach (var pair in dict)
            {
                foreach (var item in pair.Value)
                {
                    if (!standings.ContainsKey(item.Key))
                    {
                        standings[item.Key] = 0;
                    }
                    standings[item.Key]+=item.Value;
                }
            }
            int individualCounter = 1;
            standings = standings.OrderByDescending(x => x.Value).ToDictionary(x=>x.Key,x=>x.Value);
            foreach (var item in standings)
            {
                Console.WriteLine($"{individualCounter}. {item.Key} -> {item.Value}");
                individualCounter++;
            }
        }
    }
}
