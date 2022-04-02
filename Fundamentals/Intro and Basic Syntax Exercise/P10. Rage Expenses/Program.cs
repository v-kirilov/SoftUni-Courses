using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double totalExpenses = 0;

            int trashedHead = lostGames / 2;
            int trashedMouse = lostGames / 3;
            int trashedKeyboard = lostGames / 6;
            int trashedDsiplay = trashedKeyboard/2;



            totalExpenses = trashedHead * headsetPrice + trashedMouse * mousePrice + trashedKeyboard * keyboardPrice + trashedDsiplay * displayPrice;

            Console.WriteLine($"Rage expenses: {totalExpenses:f2} lv.");
        }
    }
}
