using System;

namespace PME12._Ascii_Sumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            

            string input = Console.ReadLine();
            int startIndex = 0;
            int endIndex = input.Length;
            if (input.Contains(start))
            {
                startIndex = input.IndexOf(start);
            }
            if (input.Contains(end))
            {
                endIndex = input.IndexOf(end);
            }

            string betweenChars = input.Substring(startIndex, endIndex);
            int sum = 0;
            foreach (var character in betweenChars)
            {   
                sum += (int)character;
            }

            Console.WriteLine(sum);
        }
    }
}
