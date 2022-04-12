using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2._Shoot_for_the_Win
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targetsList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int counter = 0;
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                int targetIndex = int.Parse(input);

                if (targetIndex<0 || targetIndex>=targetsList.Count)
                {
                    continue;
                }
                else
                {
                    TargetHitMethod(targetIndex, targetsList);
                }

                counter++;
            }

            Console.Write($"Shot targets: {counter} -> ");
            Console.Write(String.Join(" ", targetsList));

            //end
        }


        static void TargetHitMethod(int index, List<int> inputList)
        {
            if (inputList[index]==-1)
            {
                return;
            }
            else
            {
                int hitTarget = inputList[index];

                inputList[index] = -1;
                for (int i = 0; i < inputList.Count; i++)
                {
                    if (i==index)
                    {
                        continue;
                    }
                    if (inputList[i]==-1)
                    {
                        continue;
                    }
                    if (inputList[i]>hitTarget)
                    {
                        inputList[i] -= hitTarget;
                    }
                    else if (inputList[i]<=hitTarget)
                    {
                        inputList[i] += hitTarget;
                    }
                }
            }
            return;
        }
    }
}
