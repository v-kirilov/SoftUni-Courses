using System;
using System.Collections.Generic;
using System.Linq;

namespace P03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countGuest = int.Parse(Console.ReadLine());
            List<string> guestNames = new List<string>();

            for (int i = 0; i < countGuest; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (input.Length == 3)
                {
                    string name = input[0];

                    if (guestNames.Contains(name) == true)
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guestNames.Add(name);
                    }
                }
                else if (input.Length == 4)
                {
                    string name = input[0];

                    if (guestNames.Contains(name) != true)
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }else
                    {
                        guestNames.RemoveAll(x => x == name);
                    }
                }

            }

            Console.WriteLine(string.Join(Environment.NewLine,guestNames));
        }
    }
}
