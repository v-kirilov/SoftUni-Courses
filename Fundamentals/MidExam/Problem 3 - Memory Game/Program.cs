using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3___Memory_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> elementsList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = string.Empty;
            int counter = 0;

            while ((input = Console.ReadLine()) != "end")
            {
                counter++;
                string[] sequence = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                int firstIndex = int.Parse(sequence[0]);
                int secondIndex = int.Parse(sequence[1]);
                if (CheckIfIndexIsValid(firstIndex,secondIndex,elementsList,counter)==true)
                {
                    AreElementsSame(firstIndex, secondIndex, elementsList);
                }
                if (elementsList.Count==0)
                {
                    Console.WriteLine($"You have won in {counter} turns!");
                    break;
                }
            }
            //end
            if (elementsList.Count!=0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(String.Join(" ", elementsList));

            }
        }

        static bool CheckIfIndexIsValid(int firstIndex, int secondIndex, List<string> inputList, int counter)
        {
            if (firstIndex == secondIndex)
            {
                Console.WriteLine("Invalid input! Adding additional elements to the board");
                AddElements(inputList, counter);
                return false;
            }
            if (firstIndex < 0 || secondIndex < 0)
            {
                Console.WriteLine("Invalid input! Adding additional elements to the board");
                AddElements(inputList, counter);
                return false;
            }
            if (firstIndex >= inputList.Count || secondIndex >= inputList.Count)
            {
                Console.WriteLine("Invalid input! Adding additional elements to the board");
                AddElements(inputList, counter);
                return false;
            }
            return true;
        }

        static void AddElements(List<string> inputList, int counter)
        {
            if (inputList.Count % 2 == 0)
            {
                string addNumber = "-" + counter.ToString() + "a";
                inputList.Insert(inputList.Count / 2, addNumber);
                inputList.Insert(inputList.Count / 2, addNumber);
            }
        }

        static void AreElementsSame(int firstIndex, int secondIndex , List<string> inputList)
        {
            if (inputList[firstIndex]==inputList[secondIndex])
            {
                Console.WriteLine($"Congrats! You have found matching elements - {inputList[firstIndex]}!");
                string removable = inputList[firstIndex];
                inputList.RemoveAll(x => x == removable);
            }else
            {
                Console.WriteLine("Try again!");
                return;
            }
        }
    }
}
