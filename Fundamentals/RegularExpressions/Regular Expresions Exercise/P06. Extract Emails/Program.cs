using System;
using System.Text.RegularExpressions;

namespace P06._Extract_Emails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"(?<=\s|^)[a-z]+[-_.,]?[a-z]+@[a-z]+[-,_.]*[a-z]+[.,-_][a-z]+.?[a-z]+"); 
            string input = Console.ReadLine();

            MatchCollection matches = pattern.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
