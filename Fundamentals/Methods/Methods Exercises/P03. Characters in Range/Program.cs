using System;

namespace _3._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());

            int start = first;
            int end = second;
            if (start<=end)
            {
                RangePlot(start, end);

            }else
            {
                RangePlot(end, start);

            }


        }

        static void RangePlot(int start, int end)
        {
            for (int i = start+1; i <= end-1; i++)
            {
                char letter = (char)i;
                Console.Write($"{letter} ");
            }
        }
    }
}
