using System;
using System.Linq;
using System.Collections.Generic;

namespace P01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, int> dict = new Dictionary<string, int>();

            for (int i = 0; i < input.Length; i++)
            {
                string data = input[i].ToString();
                if (data==" ")
                {
                    continue;
                }
                if (dict.ContainsKey(data)==false)
                {
                    dict.Add(data, 1);
                }else
                {
                    dict[data]++;
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
