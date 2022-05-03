using System;
using System.Collections.Generic;
using System.Linq;

namespace P06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();



            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputArray = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string action = inputArray[0];

                if (action == "Add")
                {
                    int index = int.Parse(inputArray[1]);
                    numberList = AddingMethod(numberList, index);
                }
                else if (action == "Remove")
                {
                    int index = int.Parse(inputArray[1]);
                    numberList = RemoveMethod(numberList, index);
                }
                else if (action == "RemoveAt")
                {
                    int index = int.Parse(inputArray[1]);
                    numberList.RemoveAt(index);
                }
                else if (action == "Insert")
                {
                    int index = int.Parse(inputArray[2]);
                    int number = int.Parse(inputArray[1]);
                    numberList.Insert(index, number);
                }
            }

            Console.WriteLine(String.Join(" ", numberList));
        }

        static List<int> AddingMethod(List<int> input, int index)
        {
            input.Add(index);
            return input;
        }

        static List<int> RemoveMethod(List<int> input, int index)
        {
            input.Remove(index);
            return input;
        }
    }
}
