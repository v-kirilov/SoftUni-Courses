using System;

namespace _5._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string guess = Console.ReadLine();

            string password = "";
            int counter = 0;

            for (int i = userName.Length - 1; i >= 0; i--)
            {
                password += userName[i];
            }

            while (counter < 3)
            {
                if (guess != password)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    counter++;
                }
                else
                {
                    Console.WriteLine($"User {userName} logged in.");
                    return;
                }
                guess = Console.ReadLine();
            }

            if (counter == 3)
            {
                Console.WriteLine($"User {userName} blocked!");
                return;
            }
        }
    }
}
