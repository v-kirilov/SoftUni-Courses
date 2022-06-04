using System;

namespace Problem_1___Activation_Keys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Generate")
            {
                string[] cmdArgs = command.Split(">>>", StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];
                if (action == "Contains")
                {
                    string sub = cmdArgs[1];
                    if (input.Contains(sub))
                    {
                        Console.WriteLine($"{input} contains {sub}");
                    }
                    else
                    {
                        Console.WriteLine($"Substring not found!");
                    }
                }
                else if (action == "Flip")
                {
                    string upperOrLower = cmdArgs[1];
                    int startIndex = int.Parse(cmdArgs[2]);
                    int endIndex = int.Parse(cmdArgs[3]);
                    if (upperOrLower == "Upper")
                    {
                        string sub = input.Substring(startIndex, endIndex - startIndex);
                        sub = sub.ToUpper();
                        input = ToUpperOrLower(input, startIndex, endIndex, sub);
                        Console.WriteLine(input);

                    }
                    else
                    {
                        string sub = input.Substring(startIndex, endIndex - startIndex);
                        sub = sub.ToLower();
                        input = ToUpperOrLower(input, startIndex, endIndex, sub);
                        Console.WriteLine(input);

                    }

                }
                else if (action == "Slice")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);
                    input = input.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(input);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {input}");
        }
        static string ToUpperOrLower(string input, int startIndex, int endIndex, string changedSubString)
        {
            string start = input.Substring(0, startIndex);
            string end = input.Substring(endIndex);
            string finalString = start + changedSubString + end;
            return finalString;
        }
    }
}
