using System;

namespace _4._Back_in_30_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            if (hours ==24)
            {
                hours = 0;
            }
            if (minutes + 30 >= 60)
            {
                hours++;
                if (hours==24)
                {
                    hours = 0;
                    minutes = minutes + 30 - 60;
                    Console.WriteLine($"{hours}:{minutes:d2}");
                    return;
                }
                minutes = minutes + 30 - 60;
                Console.WriteLine($"{hours}:{minutes:d2}");

            
            }else
            {
                Console.WriteLine($"{hours}:{minutes+30:d2}");
            }

        }
    }
}
