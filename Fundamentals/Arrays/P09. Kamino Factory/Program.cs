using System;
using System.Linq;

namespace P09._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            int timesRepeated = 0;
            int maxCounter = int.MinValue;
            int minIndex = int.MaxValue;
            int index = 0;
            int sample = 0;
            int zeroSample = 0;
            int bestSample = 0;
            int bestIndex = 0;
            int bestDNA = 0;
            int bestDNAZero = 0;
            int dna = 0;

            int[] arr = input
                .Split('!', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] bestArray = new int[arr.Length];
            
            int[] zeroArray = new int[arr.Length];


            while (input != "Clone them!")
            {
                int counter = 0;
                sample++;

                //if (sample>num)
                //{
                //    break;
                //}

                arr = input
                .Split('!', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                dna = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == 1)
                    {
                        dna++;
                    }
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j] && arr[i] == 1)
                        {
                            index = i;
                            counter++;                  //Проверяваме за повтарящи се 1-ци една след друга и записваме колко пъти се повтарят
                            if (counter == maxCounter)
                            {

                                if (index < bestIndex)
                                {
                                    bestArray = arr;
                                    bestSample = sample;
                                    bestIndex = index;
                                }

                                if (dna > bestDNA)
                                {
                                    bestArray = arr;
                                    bestSample = sample;
                                    bestIndex = index;
                                }

                            }
                            if (counter > maxCounter)
                            {
                                maxCounter = counter;
                                timesRepeated++;
                                bestArray = arr;
                                bestSample = sample;
                                bestIndex = i;

                            }

                            break;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (dna > bestDNA && counter==maxCounter)
                    {
                        bestArray = arr;
                        bestSample = sample;
                        bestIndex = index;
                    }
                }
                if (arr == bestArray)
                {
                    bestDNA = dna;
                }
                if (counter==0)
                {
                    if (dna>bestDNAZero)
                    {
                        zeroArray = arr;
                        bestDNAZero = dna;
                        zeroSample = sample;
                    }
                }

                input = Console.ReadLine();
            }
           
            if (bestSample == 0)
            {
                Console.WriteLine($"Best DNA sample {sample} with sum: {bestDNAZero}.");
                Console.WriteLine(String.Join(" ", zeroArray));
            }
            else
            {
                Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestDNA}.");
                Console.WriteLine(String.Join(" ", bestArray));
                //Console.WriteLine(bestIndex);
            }



        }
    }
}
