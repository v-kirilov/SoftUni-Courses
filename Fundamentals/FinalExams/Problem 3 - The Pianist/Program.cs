using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3___The_Pianist
{
    internal class Program
    {
        public class PianoPiece
        {
            public PianoPiece(string name, string composer, string key)
            {
                this.Name = name;
                this.Composer = composer;
                this.Key = key;
            }
            public string Name { get; set; }
            public string Composer { get; set; }
            public string Key { get; set; }

            public override string ToString()
            {
                return $"{this.Name} -> Composer: {this.Composer}, Key: {this.Key}";
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<PianoPiece> pianoPieces = new List<PianoPiece>();

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);

                string name = cmdArgs[0];
                string composer = cmdArgs[1];
                string key = cmdArgs[2];
                PianoPiece newPiece = new PianoPiece(name, composer, key);
                pianoPieces.Add(newPiece);
            }

            string input = Console.ReadLine();
            while (input != "Stop")
            {
                string[] cmdArgs = input.Split('|', StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];
                if (action == "Add")
                {
                    string name = cmdArgs[1];
                    string composer = cmdArgs[2];
                    string key = cmdArgs[3];
                    PianoPiece currentPianoPiece = pianoPieces.FirstOrDefault(x => x.Name == name);
                    if (currentPianoPiece == null)
                    {
                        pianoPieces.Add(new PianoPiece(name, composer, key));
                        Console.WriteLine($"{name} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already in the collection!"); 
                    }
                }
                else if (action == "Remove")
                {
                    string name = cmdArgs[1];
                    PianoPiece PieceToRemove = pianoPieces.FirstOrDefault(x => x.Name == name);
                    if (PieceToRemove==null)
                    {
                        Console.WriteLine($"Invalid operation! {name} does not exist in the collection.");
                    }else
                    {
                        pianoPieces.Remove(PieceToRemove);
                        Console.WriteLine($"Successfully removed {name}!");
                    }

                }
                else if (action == "ChangeKey")
                {
                    string name = cmdArgs[1];
                    string newKey = cmdArgs[2];
                    PianoPiece PieceToChange = pianoPieces.FirstOrDefault(x => x.Name == name);
                    if (PieceToChange==null)
                    {
                        Console.WriteLine($"Invalid operation! {name} does not exist in the collection.");
                    }
                    else
                    {
                        Console.WriteLine($"Changed the key of {name} to {newKey}!");
                        PieceToChange.Key = newKey;
                    }

                }


                input = Console.ReadLine();
            }

            foreach (var piece in pianoPieces)
            {
                Console.WriteLine(piece);
            }
        }
    }
}
