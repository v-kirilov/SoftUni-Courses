using System;
using System.Linq;

namespace P09._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string input = string.Empty;
            int sequenceSum = 0;
            int bestSequenceSum = 0;
            int sequenceIndex = 0;
            int bestSequenceIndex = 1;
            int sample = 0;
            int bestSample = 1;
            int subSequence = 0;
            int bestSubSequence = 0;

            int[] bestArr = new int[length];

            while ((input = Console.ReadLine()) != "Clone them!")
            {
                sample++;
                int[] arrDNA = input
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                sequenceSum = 0;

                foreach (var ones in arrDNA)
                {
                    if (ones == 1)
                    {
                        sequenceSum++;
                    }
                }

                for (int i = 0; i < arrDNA.Length; i++)
                {
                    if (arrDNA[i] == 0)
                    {
                        continue;
                    }

                    subSequence = 0;

                    for (int j = i + 1; j < arrDNA.Length; j++)
                    {
                        if (arrDNA[i] == 1 && arrDNA[i] == arrDNA[j])
                        {
                            subSequence++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (subSequence > bestSubSequence)
                    {
                        bestArr = arrDNA;
                        bestSubSequence = subSequence;
                        bestSequenceIndex = i;
                        bestSequenceSum = sequenceSum;
                        bestSample = sample;
                    }
                    else if (subSequence == bestSubSequence)
                    {
                        if (i < bestSequenceIndex)
                        {
                            bestSequenceIndex = i;
                            bestSubSequence = subSequence;
                            bestArr = arrDNA;
                            bestSequenceIndex = i;
                            bestSequenceSum = sequenceSum;
                            bestSample = sample;

                        }
                        else if (i == bestSequenceIndex && sequenceSum > bestSequenceSum)
                        {
                            bestArr = arrDNA;
                            bestSubSequence = subSequence;
                            bestSequenceIndex = i;
                            bestSequenceSum = sequenceSum;
                            bestSample = sample;

                        }
                    }
                }

            }
            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestSequenceSum}.");
            Console.WriteLine(String.Join(" ", bestArr));
        }
    }
}
