using System;
using System.Linq;

namespace _2._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] secondArr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] compareArray = new string[firstArr.Length];

            for (int i = 0; i < secondArr.Length; i++)
            {
                for (int j = 0; j < firstArr.Length; j++)
                {
                    if (firstArr[j]==secondArr[i])
                    {
                        compareArray[i] = secondArr[i];
                    }
                }
            }

            compareArray = string.Join(" ", compareArray)
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries); // Презаписва масива като трие празните членове на масива
            foreach (var item in compareArray)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
