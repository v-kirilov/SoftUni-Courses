using System;
using System.Linq;

namespace P01___World_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string start = Console.ReadLine();
            string input = Console.ReadLine();
            while (input != "Travel")
            {
                string[] cmdArgs = input.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];
                if (action == "Add Stop")
                {
                    int addIndex = int.Parse(cmdArgs[1]);
                    string travelStop = cmdArgs[2];
                    if (addIndex < start.Length && addIndex >= 0)
                    {
                        start = start.Insert(addIndex, travelStop);
                    }
                        Console.WriteLine(start);

                }
                else if (action == "Remove Stop")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);

                    if (startIndex >= 0 && endIndex < start.Length)
                    {
                        start = start.Remove(startIndex, endIndex - startIndex + 1);
                    }
                        Console.WriteLine(start);

                }
                else if (action == "Switch")
                {
                    string oldPlace = cmdArgs[1];
                    string newPlace = cmdArgs[2];
                    start = start.Replace(oldPlace, newPlace);
                    Console.WriteLine(start);
                }


                input = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {start}");
        }
    }
}
