using System;
using System.Linq;

namespace Problem_1___The_Imitation_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();
            while (command != "Decode")
            {
                string[] cmdArgs = command.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];
                if (action == "Move")
                {
                    int numberOfLetters = int.Parse(cmdArgs[1]);
                    string subStr = input.Substring(numberOfLetters);
                    input = input.Remove(numberOfLetters);
                    string output = subStr + input;
                    input = output;
                }
                else if (action=="Insert")
                {
                    int index= int.Parse(cmdArgs[1]);
                    string value = cmdArgs[2];
                    input = input.Insert(index, value);
                }
                else if (action == "ChangeAll")
                {
                    string subStr = cmdArgs[1];
                    string replacement = cmdArgs[2];
                    input = input.Replace(subStr, replacement);
                }
               

                command = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {input}");
        }
    }
}
