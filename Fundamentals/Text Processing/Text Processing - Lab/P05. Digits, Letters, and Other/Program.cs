using System;
using System.Linq;
using System.Text;

namespace P05._Digits__Letters__and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] lettersFromInput = input.ToCharArray();

            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder other = new StringBuilder();

            for (int i = 0; i < lettersFromInput.Length; i++)
            {
                if (char.IsDigit(lettersFromInput[i]))
                {
                    digits.Append(lettersFromInput[i]);
                }
                else if (char.IsLetter(lettersFromInput[i]))
                {
                    letters.Append(lettersFromInput[i]);
                }
                else
                {
                    other.Append(lettersFromInput[i]);
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(other);
        }
    }
}
