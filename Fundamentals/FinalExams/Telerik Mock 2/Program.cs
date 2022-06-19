using System;
using System.Collections.Generic;

namespace Telerik_Mock_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> merged = new List<string>();
            List<string> squashed = new List<string>();
            List<string> input = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string insert = Console.ReadLine();
                input.Add(insert);
            }

            for (int i = 0; i < input.Count-1; i++)
            {
                string first = input[i];
                string second = input[i+1];

                string mergedNumber = first[1].ToString() + second[0].ToString();

                int numberOne = int.Parse((first[1].ToString()));
                int numberTwo = int.Parse((second[0].ToString()));
                int newNum = numberOne + numberTwo;
                if (newNum>9)
                {
                    if (newNum==10)
                    {
                        newNum = 0;
                    }else
                    {
                        newNum = newNum % 10;
                    }
                }
                string middleSqush = newNum.ToString();

                string finalSq = first[0].ToString() + middleSqush + second[1].ToString();

                merged.Add(mergedNumber);
                squashed.Add(finalSq);
            }

            Console.WriteLine(String.Join(" ",merged));
            Console.WriteLine(String.Join(" ",squashed));
        }
    }
}
