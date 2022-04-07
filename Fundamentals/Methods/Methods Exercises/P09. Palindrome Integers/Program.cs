using System;

namespace P09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                int num = int.Parse(input);
                CheckPalidromeMethod(input);



                input = Console.ReadLine();
            }


            //end
        }

        static void CheckPalidromeMethod(string input)
        {
            if (input.Length==1)
            {
                Console.WriteLine("true");
                return;
            }
            bool isPalidrome = true;
            if (input.Length % 2 != 0)
            {
                for (int i = 0; i < input.Length / 2; i++)
                {
                    if (input[i] != input[input.Length - i - 1])
                    {
                        isPalidrome = false;
                    }
                }
            }
            else
            {
                for (int i = 0; i < input.Length / 2; i++)
                {
                    if (input[i] != input[input.Length - i - 1])
                    {
                        isPalidrome = false;
                    }
                }
            }


            if (isPalidrome == true)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

    }
}
