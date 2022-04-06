using System;

namespace P06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(PrintMiddle(input));
        }


        static string PrintMiddle(string input)
        {
            string output = string.Empty;
            if (input.Length % 2 != 0)
            {
                int middle = input.Length / 2;
                output = input[middle].ToString();
            }
            else
            {
                int middle = input.Length / 2;
                output=input[middle-1].ToString()+input[middle].ToString();
            }

            return output;
        }


    }
}
