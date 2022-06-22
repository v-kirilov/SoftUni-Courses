using System;

namespace Exam_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];
                if (action == "Translate")
                {
                    string ch = cmdArgs[1];
                    string replacement = cmdArgs[2];
                    input = input.Replace(ch, replacement);
                    Console.WriteLine(input);
                }
                else if (action == "Includes")
                {
                    string substring = cmdArgs[1];
                    if (input.Contains(substring))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (action == "Start")
                {
                    string substring = cmdArgs[1];
                    int indexStart = substring.Length;
                    string startOfInput = input.Substring(0, indexStart);
                    if (substring == startOfInput)
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (action =="FindIndex")
                {
                    string currCh = cmdArgs[1];
                    int indexOfLast = input.LastIndexOf(currCh);
                    Console.WriteLine(indexOfLast);
                }
                else if (action =="Remove")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int count = int.Parse(cmdArgs[2]);
                    input = input.Remove(startIndex, count);
                    Console.WriteLine(input);
                }
                else if (action == "Lowercase")
                {
                    input = input.ToLower();
                    Console.WriteLine(input);
                }

                command = Console.ReadLine();
            }
        }
    }
}
