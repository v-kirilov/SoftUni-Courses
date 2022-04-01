using System;

namespace _3._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double price=0;

            switch (type)
            {
                case "Students":
                    if (day == "Friday")
                    {
                        price = 8.45;
                    }
                    else if (day == "Saturday")
                    {
                        price = 9.8;
                    }
                    else if (day == "Sunday")
                    {
                        price = 10.46;
                    }
                    break;
                case "Business":
                    if (day == "Friday")
                    {
                        price = 10.9;
                    }
                    else if (day == "Saturday")
                    {
                        price = 15.6;
                    }
                    else if (day == "Sunday")
                    {
                        price = 16;
                    }
                    break;
                case "Regular":
                    if (day == "Friday")
                    {
                        price = 15;
                    }
                    else if (day == "Saturday")
                    {
                        price = 20;
                    }
                    else if (day == "Sunday")
                    {
                        price = 22.5;
                    }
                    break;
            }

            if (type == "Students" && count >= 30)
            {
                price *= .85;
            }
            if (type == "Business" && count >= 100)
            {
                count -= 10;
            }
            if (type == "Regular" && count >= 10 && count<=20)
            {
                price *= .95;
            }

            Console.WriteLine($"Total price: {price*count:f2}");
        }
    }
}
