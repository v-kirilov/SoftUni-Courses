using System;
using System.Linq;
using System.Collections.Generic;

namespace P08._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] cmdArgs = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string companyName = cmdArgs[0];
                string employeeId = cmdArgs[1];

                if (!dict.ContainsKey(companyName))
                {
                    List<string> newList = new List<string>() { employeeId };
                    dict.Add(companyName, newList);
                }
                else
                {
                    if (dict[companyName].Contains(employeeId))
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        dict[companyName].Add(employeeId);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var item in dict)
            {
                Console.WriteLine(item.Key);
                foreach (var id in item.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
