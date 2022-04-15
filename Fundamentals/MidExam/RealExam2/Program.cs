using System;
using System.Collections.Generic;
using System.Linq;

namespace RealExam2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> coffeeList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] inputCommands = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string action = inputCommands[0];

                if (action== "Include")
                {
                    coffeeList.Add(inputCommands[1]);
                }
                else if (action=="Remove")
                {
                    string position = inputCommands[1];
                    int index = int.Parse(inputCommands[2]);

                    if (position=="first")
                    {
                        if (index>coffeeList.Count)
                        {
                            continue;
                        }
                        else
                        {
                            coffeeList.RemoveRange(0, index);
                        }
                    }
                    else
                    {
                        if (index > coffeeList.Count)
                        {
                            continue;
                        }
                        else if (index==1)
                        {
                            coffeeList.RemoveAt(coffeeList.Count - 1);
                        }
                        else
                        {
                            coffeeList.RemoveRange(coffeeList.Count-index, index);
                        }
                    }
                }
                else if (action == "Prefer")
                {
                    int firstIndex = int.Parse(inputCommands[1]);
                    int secondIndex = int.Parse(inputCommands[2]);
                    if (firstIndex<0||secondIndex>=coffeeList.Count)
                    {
                        continue;
                    }else
                    {
                        string tempCoffee = coffeeList[firstIndex];
                        coffeeList[firstIndex]=coffeeList[secondIndex];
                        coffeeList[secondIndex]=tempCoffee;
                    }
                }
                else if (action=="Reverse")
                {
                    coffeeList.Reverse();
                }
            }
            Console.WriteLine("Coffees:");
            Console.WriteLine(string.Join(" ",coffeeList));
        }
    }
}
