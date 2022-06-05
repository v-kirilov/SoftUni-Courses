using System;
using System.Linq;

namespace Problem_1__Secret_Chat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string instruction = Console.ReadLine();
            while (instruction != "Reveal")
            {
                string[] cmdArgs = instruction.Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];
                if (action == "InsertSpace")
                {
                    int indexForSpace = int.Parse(cmdArgs[1]);
                    message = message.Insert(indexForSpace, " ");
                    Console.WriteLine(message);

                }
                else if (action == "Reverse")
                {
                    string reverseString = cmdArgs[1];
                    if (message.Contains(reverseString))
                    {
                        int startIndex = message.IndexOf(reverseString);
                        message = message.Remove(startIndex, reverseString.Length);
                        char[] reverseArray = reverseString.Reverse().ToArray();
                        message = message + string.Join("", reverseArray);
                        Console.WriteLine(message);

                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (action == "ChangeAll")
                {
                    string substring = cmdArgs[1];
                    string replacement = cmdArgs[2];
                    message = message.Replace(substring, replacement);
                    Console.WriteLine(message);
                }
                instruction = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
