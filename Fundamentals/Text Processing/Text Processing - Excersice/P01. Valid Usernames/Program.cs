using System;

namespace P01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] passwords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in passwords)
            {
                bool isValid = true;

                if (word.Length < 3 || word.Length > 16)
                {
                    continue;
                }
                foreach (var letter in word)
                {
                    if (char.IsLetterOrDigit(letter) || letter == '_' || letter == '-')
                    {
                        continue;
                    }
                    else
                    {
                        isValid = false;
                    }
                }

                if (isValid)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
