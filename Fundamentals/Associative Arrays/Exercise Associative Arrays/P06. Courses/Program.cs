using System;
using System.Linq;
using System.Collections.Generic;

namespace P06._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] cmdArgs = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string courseName = cmdArgs[0];
                string registeredStudents = cmdArgs[1];
                if (!dict.ContainsKey(courseName))
                {
                    List<string> newList = new List<string>() { registeredStudents };
                    dict.Add(courseName, newList);
                }
                else
                {
                    dict[courseName].Add(registeredStudents);
                }

                input = Console.ReadLine();
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                foreach (var studends in item.Value)
                {
                    Console.WriteLine($"-- {studends}");
                }
            }
        }
    }
}
