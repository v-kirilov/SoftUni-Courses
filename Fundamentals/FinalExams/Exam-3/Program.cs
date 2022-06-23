using System;
using System.Collections.Generic;

namespace Exam_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            int dislikedMeals = 0;

            while (input != "Stop")
            {
                string[] cmdArgs = input.Split('-');
                string action = cmdArgs[0];
                if (action == "Like")
                {
                    string guest = cmdArgs[1];
                    string meal = cmdArgs[2];
                    if (!dict.ContainsKey(guest))
                    {
                        List<string> newList = new List<string>() { meal };
                        dict.Add(guest, newList);
                    }
                    else
                    {
                        if (!dict[guest].Contains(meal))
                        {
                            dict[guest].Add(meal);
                            
                        }
                        else
                        {
                            //Already has the meal, do nothing
                        }
                    }
                }
                else if (action == "Dislike")
                {
                    string guest = cmdArgs[1];
                    string meal = cmdArgs[2];
                    if (!dict.ContainsKey(guest))

                    {
                        Console.WriteLine($"{guest} is not at the party.");
                    }
                    else if (!dict[guest].Contains(meal))
                    {
                        Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                    }
                    else
                    {
                        Console.WriteLine($"{guest} doesn't like the {meal}.");
                        dict[guest].Remove(meal);
                        dislikedMeals++;
                    }
                }

                
                input = Console.ReadLine();
            }


            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}: {string.Join(", ", item.Value)}");
            }

            Console.WriteLine($"Unliked meals: {dislikedMeals}");
        }
    }
}

