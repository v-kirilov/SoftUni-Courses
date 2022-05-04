using System;
using System.Collections.Generic;
using System.Linq;

namespace P02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string action = string.Empty;

            while ((action = Console.ReadLine()) != "end")
            {
                string[] inputArr = action.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string firstCommand = inputArr[0];
                if (firstCommand == "Delete")
                {
                    int element = int.Parse(inputArr[1]);
                    inputList.RemoveAll(x => x == element);
                }
                else
                {
                    int element = int.Parse(inputArr[1]);
                    int position = int.Parse(inputArr[2]);
                    inputList.Insert(position, element);
                }

            }

            Console.WriteLine(String.Join(" ", inputList));
        }
    }
}
