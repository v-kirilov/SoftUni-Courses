using System;
using System.Text.RegularExpressions;

namespace _2._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\+359+( |-)2\1+\d{3}\1+\d{4}\b";
            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, regex);

            Console.Write(string.Join(", ", matches));

            

        }
    }
}
