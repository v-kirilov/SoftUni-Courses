using System;
using System.Collections.Generic;
using System.Linq;

namespace P09.Pokemon_Don_t_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int finalSum = 0;

            while (true)
            {

                if (inputList.Count == 0)
                {
                    break;
                }
                int position = int.Parse(Console.ReadLine());

                if (position < 0)
                {
                    position = 0;
                    int firstElement = inputList[0];
                    finalSum += firstElement;
                    inputList[0] = inputList[inputList.Count - 1];

                    for (int i = 0; i < inputList.Count; i++)
                    {
                        if (firstElement >= inputList[i])
                        {
                            inputList[i] += firstElement;
                        }
                        else if (firstElement <= inputList[i])
                        {
                            inputList[i] -= firstElement;
                        }
                    }
                }
                else if (position > inputList.Count - 1)
                {
                    position = inputList.Count - 1;
                    int lastElement = inputList[inputList.Count - 1];
                    finalSum+=lastElement;
                    inputList[inputList.Count - 1] = inputList[0];

                    for (int i = 0; i < inputList.Count; i++)
                    {
                        if (lastElement>= inputList[i])
                        {
                            inputList[i] += lastElement;
                        }
                        else if (lastElement<inputList[i])
                        {
                            inputList[i] -= lastElement;
                        }
                    }
                }
                else
                {
                    int pokemon = inputList[position];
                    finalSum += pokemon;
                    inputList.RemoveAt(position);
                    for (int i = 0; i < inputList.Count; i++)
                    {
                        if (pokemon >= inputList[i])
                        {
                            inputList[i] += pokemon;
                        }
                        else
                        {
                            inputList[i] -= pokemon;
                        }
                    }
                   
                }
            }

            if (inputList.Count==0)
            {
               // Console.WriteLine("empty");
                Console.WriteLine(finalSum);
            }else
            {
                Console.WriteLine(String.Join(" ", inputList));

            }
            //енд
        }

        
    }
}
