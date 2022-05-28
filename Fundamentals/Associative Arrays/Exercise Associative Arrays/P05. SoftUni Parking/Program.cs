using System;
using System.Linq;
using System.Collections.Generic;

namespace P05._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> dict = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string action = input[0];
                

                if (action == "register")
                {
                    string username = input[1];
                    string licensePlateNumber = input[2];
                    if (dict.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {dict[username]}");
                    }
                    else
                    {
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                        dict.Add(username, licensePlateNumber);
                    }
                }
                else if (action=="unregister")
                {
                    string username = input[1];
                    if (dict.ContainsKey(username)==false)
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }else
                    {
                        Console.WriteLine($"{username} unregistered successfully");
                        dict.Remove(username);
                    }
                }

            }


            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
            //end
        }
    }
}
