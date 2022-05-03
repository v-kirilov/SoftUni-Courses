using System;
using System.Collections.Generic;
using System.Linq;

namespace P05._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            numberList.RemoveAll(x => x < 0);


            numberList.Reverse();

            if (numberList.Count>0)
            {
                Console.WriteLine(String.Join(" ", numberList));
            }else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
