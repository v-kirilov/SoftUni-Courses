using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2___Array_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> inputLsit = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArray = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string action = commandArray[0];

                if (action == "swap")
                {
                    int index1 = int.Parse(commandArray[1]);
                    int index2 = int.Parse(commandArray[2]);
                    double tempValue = inputLsit[index1];
                    inputLsit[index1] = inputLsit[index2];
                    inputLsit[index2] = tempValue;
                }
                else if (action == "multiply")
                {
                    int index1 = int.Parse(commandArray[1]);
                    int index2 = int.Parse(commandArray[2]);
                    inputLsit[index1] *= inputLsit[index2];
                }
                else if (action == "decrease")
                {
                    for (int i = 0; i < inputLsit.Count; i++)
                    {
                        inputLsit[i] -= 1;
                    }
                }
            }

            Console.WriteLine(String.Join(", ", inputLsit));



        }
    }
}
