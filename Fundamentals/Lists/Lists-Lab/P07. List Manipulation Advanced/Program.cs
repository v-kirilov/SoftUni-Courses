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

            bool changes = false;

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputArray = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string action = inputArray[0];

                if (action == "Add")
                {
                    int index = int.Parse(inputArray[1]);
                    numberList = AddingMethod(numberList, index);
                    changes = true;
                }
                else if (action == "Remove")
                {
                    int index = int.Parse(inputArray[1]);
                    numberList = RemoveMethod(numberList, index);
                    changes = true;
                }
                else if (action == "RemoveAt")
                {
                    int index = int.Parse(inputArray[1]);
                    numberList.RemoveAt(index);
                    changes = true;
                }
                else if (action == "Insert")
                {
                    int index = int.Parse(inputArray[2]);
                    int number = int.Parse(inputArray[1]);
                    numberList.Insert(index, number);
                    changes = true;
                }
                else if (action == "Contains")
                {
                    int number = int.Parse(inputArray[1]);

                    if (numberList.Contains(number))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (action == "PrintEven")
                {
                    List<int> evenList = new List<int>();

                    for (int i = 0; i < numberList.Count; i++)
                    {
                        if (numberList[i] % 2 == 0)
                        {
                            evenList.Add(numberList[i]);
                        }
                    }
                    Console.WriteLine(String.Join(" ", evenList));
                }
                else if (action == "PrintOdd")
                {
                    List<int> oddList
                        = new List<int>();

                    for (int i = 0; i < numberList.Count; i++)
                    {
                        if (numberList[i] % 2 != 0)
                        {
                            oddList.Add(numberList[i]);
                        }
                    }
                    Console.WriteLine(String.Join(" ", oddList));
                }
                else if (action == "GetSum")
                {
                    int sum = numberList.Sum();
                    Console.WriteLine(sum);
                }
                else if (action == "Filter")
                {
                    string condition = inputArray[1];
                    int number = int.Parse(inputArray[2]);
                    if (condition == "<")
                    {
                        List<int> output = numberList.FindAll(x => x < number);
                        Console.WriteLine(String.Join(" ", output));
                    }
                    else if (condition == ">")
                    {
                        List<int> output = numberList.FindAll(x => x > number);
                        Console.WriteLine(String.Join(" ", output));
                    }
                    else if (condition == ">=")
                    {
                        List<int> output = numberList.FindAll(x => x >= number);
                        Console.WriteLine(String.Join(" ", output));
                    }
                    else if (condition == "<=")
                    {
                        List<int> output = numberList.FindAll(x => x <= number);
                        Console.WriteLine(String.Join(" ", output));
                    }


                }

            }

            if (changes == true)
            {
                Console.WriteLine(String.Join(" ", numberList));
            }
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
