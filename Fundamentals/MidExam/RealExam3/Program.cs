using System;
using System.Collections.Generic;
using System.Linq;

namespace RealExam3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cardsList = Console.ReadLine()
              .Split(", ", StringSplitOptions.RemoveEmptyEntries)
              .ToList();

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] inputArray = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string action = inputArray[0];

                if (action == "Add")
                {
                    string newCard = inputArray[1];
                    if (cardsList.Contains(newCard) == true)
                    {
                        Console.WriteLine("Card is already in the deck");
                    }
                    else
                    {
                        cardsList.Add(newCard);
                        Console.WriteLine("Card successfully added");
                    }
                }
                else if (action == "Remove")
                {
                    string removedCard = inputArray[1];
                    if (cardsList.Contains(removedCard) == true)
                    {
                        cardsList.Remove(removedCard);
                        Console.WriteLine("Card successfully removed");
                    }
                    else
                    {
                        Console.WriteLine("Card not found");
                    }
                }
                else if (action == "Remove At")
                {
                    int index = int.Parse(inputArray[1]);
                    if (index < 0 || index >= cardsList.Count)
                    {
                        Console.WriteLine("Index out of range");
                    }
                    else
                    {
                        cardsList.RemoveAt(index);
                        Console.WriteLine("Card successfully removed");
                    }
                }
                else if (action == "Insert")
                {
                    int index = int.Parse(inputArray[1]);
                    string newCard = inputArray[2];
                    if (index < 0 || index >= cardsList.Count)
                    {
                        Console.WriteLine("Index out of range");
                    }
                    else if (cardsList.Contains(newCard) == true)
                    {
                        Console.WriteLine("Card is already added");

                    }
                    else
                    {
                        cardsList.Insert(index, newCard);
                        Console.WriteLine("Card successfully added");
                    }
                }
            }


            Console.WriteLine(String.Join(", ",cardsList));
        }
    }
}
