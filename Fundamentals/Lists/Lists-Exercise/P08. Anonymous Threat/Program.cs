using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P08._Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inputList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string action = string.Empty;
            while ((action = Console.ReadLine()) != "3:1")
            {
                string[] operationArray = action
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = operationArray[0];
                if (command == "merge")
                {
                    int startIndex = int.Parse(operationArray[1]);
                    int endIndex = int.Parse(operationArray[2]);
                    inputList = MergeMethod(inputList, startIndex, endIndex);

                }
                else if (command == "divide")
                {
                    int index = int.Parse(operationArray[1]);
                    int partitions = int.Parse(operationArray[2]);
                    inputList=DivideMethod(inputList, index, partitions);
                }


            }




            Console.WriteLine(String.Join(" ", inputList));
            //end
        }

        static List<string> MergeMethod(List<string> inputList, int startIndex, int endIndex)
        {
            StringBuilder mergedWord = new StringBuilder();

            if (startIndex < 0)
            {
                startIndex = 0;
            }
            if (startIndex>=inputList.Count)
            {
                return inputList;
            }
            if (endIndex<startIndex||endIndex==startIndex)
            {
                return inputList;
            }

            if (endIndex >= inputList.Count)
            {
                endIndex = inputList.Count - 1;
            }

            for (int i = startIndex; i <= endIndex; i++)
            {
                mergedWord.Append(inputList[startIndex]);
                inputList.RemoveAt(startIndex);
            }

            inputList.Insert(startIndex, mergedWord.ToString());
            return inputList;

        }

        static List<string> DivideMethod(List<string> inputList, int index, int partitions)
        {
            
            string word = inputList[index];
            if (partitions >word.Length)
            {
                return inputList;
            }
            inputList.RemoveAt(index);
            int equalPart = word.Length / partitions;
            int unEqualPart = word.Length % partitions;
            int lastPart = equalPart + unEqualPart;
            StringBuilder dividedWord = new StringBuilder();
            List<string> result = new List<string>();
            for (int i = 0; i < word.Length; i++)
            {
                result.Add(word[i].ToString());
            }
            for (int i = 0; i < partitions; i++)
            {
                dividedWord.Append(result[i] + result[i + 1]);
                result.RemoveAt(i);
                result.RemoveAt(i);
                result.Insert(i,dividedWord.ToString());
                dividedWord.Clear();
            }
            if (lastPart>equalPart)
            {
                dividedWord.Clear();
                int difference = lastPart - equalPart;
                for (int i = 0; i < difference; i++)
                {
                    dividedWord.Append(result[result.Count-1-i]);
                    result.RemoveAt(result.Count - 1);
                }
                result[result.Count-1]=dividedWord.ToString();
            }
            inputList.InsertRange(index, result);
            //for (int i = result.Count-1; i >= 0; i--)
            //{
            //    inputList.Insert(index, result[i]);
            //}
            return inputList;
        }

    }
}
