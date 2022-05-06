using System;
using System.Collections.Generic;
using System.Linq;

namespace P04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputArray = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string action = inputArray[0];
                if (action == "Add")
                {
                    int number = int.Parse(inputArray[1]);
                    numbersList.Add(number);
                }
                else if (action == "Insert")
                {
                    int number = int.Parse(inputArray[1]);
                    int index = int.Parse(inputArray[2]);
                    if (index < 0 || index >= numbersList.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbersList.Insert(index, number);
                    }
                }
                else if (action == "Remove")
                {
                    int index = int.Parse(inputArray[1]);
                    if (index < 0 || index >= numbersList.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbersList.RemoveAt(index);
                    }
                }
                else if (action == "Shift")
                {
                    int count = int.Parse(inputArray[2]);
                    string direction = inputArray[1];

                    if (direction == "left")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int tempNum = numbersList[0];
                            numbersList.RemoveAt(0);
                            numbersList.Add(tempNum);
                        }
                    }
                    else if (direction == "right")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int tempNum = numbersList.Last();
                            numbersList.RemoveAt(numbersList.Count - 1);
                            numbersList.Insert(0, tempNum);

                        }
                    }

                }

            }

            Console.WriteLine(String.Join(" ",numbersList));
            //end
        }
    }
}
