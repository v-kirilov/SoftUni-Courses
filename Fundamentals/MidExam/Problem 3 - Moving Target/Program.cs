using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3___Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targetList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputArray = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string action = inputArray[0];

                if (action == "Shoot")
                {
                    int index = int.Parse(inputArray[1]);
                    int power = int.Parse(inputArray[2]);
                    if (IsIndexValid(index, targetList) == false)
                    {
                        continue;
                    }
                    else
                    {
                        targetList[index] -= power;
                        if (targetList[index] <= 0)
                        {
                            targetList.RemoveAt(index);
                        }
                    }
                }
                else if (action == "Add")
                {
                    int index = int.Parse(inputArray[1]);
                    int value = int.Parse(inputArray[2]);
                    if (IsIndexValid(index, targetList) == false)
                    {
                        Console.WriteLine("Invalid placement!");
                        continue;
                    }
                    else
                    {
                        if (value>0)
                        {
                            targetList.Insert(index, value);  //Where is added and what if it is 0 or <0???
                        }else
                        {
                            continue;
                        }
                    }
                }
                else if (action == "Strike")
                {
                    int index = int.Parse(inputArray[1]);
                    int radius = int.Parse(inputArray[2]);
                    int indexPlusRadius = index + radius;
                    int indexMinusRadius = index - radius;
                    if (IsIndexValid(indexPlusRadius, targetList) == false || IsIndexValid(indexMinusRadius,targetList)==false)
                    {
                        Console.WriteLine("Strike missed!");
                        continue;
                    }
                    else if (true)
                    {
                            targetList.RemoveRange(indexMinusRadius, 2*radius+1); //What if the radius is reversed ??????
                    }
                }
            }
            Console.WriteLine(String.Join("|", targetList));
            //end
        }

        static bool IsIndexValid(int index, List<int> targetList)
        {
            if (index < 0 || index >= targetList.Count)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
