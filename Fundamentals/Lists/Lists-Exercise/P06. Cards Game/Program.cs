using System;
using System.Collections.Generic;
using System.Linq;

namespace P06._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> playerOne = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> playerTwo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            bool isOver = false;

            while (isOver != true)
            {
                int cardOne = playerOne[0];
                int cardTwo = playerTwo[0];

                if (cardOne > cardTwo)
                {
                    int tempOne = playerOne[0];
                    int tempTwo = playerTwo[0];
                    playerOne.RemoveAt(0);
                    playerTwo.RemoveAt(0);
                    playerOne.Add(tempOne);
                    playerOne.Add(tempTwo);
                }
                else if (cardOne < cardTwo)
                {
                    int tempOne = playerOne[0];
                    int tempTwo = playerTwo[0];
                    playerOne.RemoveAt(0);
                    playerTwo.RemoveAt(0);
                    playerTwo.Add(tempTwo);
                    playerTwo.Add(tempOne);
                }
                else if (cardOne == cardTwo)
                {
                    playerOne.RemoveAt(0);
                    playerTwo.RemoveAt(0);
                }
                if (playerOne.Count == 0 || playerTwo.Count == 0)
                {
                    isOver=true;
                }
            }

            if (playerOne.Count==0)
            {
                int sum = playerTwo.Sum();
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }else
            {
                int sum = playerOne.Sum();
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
        }
    }
}
