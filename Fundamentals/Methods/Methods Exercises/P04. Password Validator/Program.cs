using System;

namespace P04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isLength = false;
            bool isLetterOrDigit = false;
            bool isDigit = false;

            isLength = ValidateLength(input);
            isLetterOrDigit = ValidateOnlyLettersDigits(input);
            isDigit = ValidateTwoDigits(input);

            if (isLength&&isLetterOrDigit&& isDigit)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool ValidateLength(string input)
        {
            if (input.Length < 6 || input.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                return false;
            }
            else
            {
                return true;

            }
        }
        static bool ValidateOnlyLettersDigits(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                if (char.IsLetterOrDigit(ch) == false)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    return false;
                }             
            }
            return true;
        }

        static bool ValidateTwoDigits(string input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                if (char.IsDigit(ch) == true)
                {
                    count++;
                }
            }

            if (count >= 2)
            {
                return true;
            }else
            {
                Console.WriteLine("Password must have at least 2 digits");
                return false;
            }
            
        }
    }
}
