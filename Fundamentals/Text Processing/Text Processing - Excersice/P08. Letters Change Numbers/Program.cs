using System;

namespace P08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;
            double totalSum = 0;

            foreach (var word in input)
            {
                string number = string.Empty;
                sum = 0;
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsDigit(word[i]))
                    {
                        number += word[i];
                    }
                }
                sum += double.Parse(number);

                if (char.IsUpper(word[0]))
                {
                    sum /= ((int)word[0] - 64);
                }
                else
                {
                    sum *= ((int)word[0] - 96);
                }

                if (char.IsUpper(word[word.Length-1]))
                {
                    sum -= (int)word[word.Length - 1] - 64;
                }
                else
                {
                    sum += ((int)word[word.Length - 1] - 96);
                }
                totalSum += sum;
            }

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
