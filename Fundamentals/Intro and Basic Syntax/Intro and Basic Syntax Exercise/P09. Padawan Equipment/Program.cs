using System;

namespace _9._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double saberPrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());

            double totalPrice = 0;
            int check = (int)Math.Ceiling(1.1 * students);
            int freeBelts = (students / 6);

            totalPrice = check * saberPrice + beltPrice * students + robePrice * (students-freeBelts);

            if (money>=totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalPrice-money:f2}lv more.");
            }
        }
    }
}
