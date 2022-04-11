using System;
using System.Collections.Generic;

namespace Problem_2___Fancy_Barcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfBarcodes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfBarcodes; i++)
            {
                List<char> charList = new List<char>();

                string barcode = Console.ReadLine();
                for (int j = 0; j < barcode.Length; j++)
                {
                    charList.Add(barcode[j]);
                }

                if (charList[0] != '@' || charList[charList.Count - 1] != '#')
                {
                    Console.WriteLine("Invalid barcode");
                    continue;
                }
                else if (charList[1] != '#')
                {
                    Console.WriteLine("Invalid barcode");
                    continue;
                }
                List<char> noDiesList = charList;
                noDiesList.RemoveAll(x => x == '#');
                if (noDiesList[noDiesList.Count-1]!='@')
                {
                    Console.WriteLine("Invalid barcode");
                    continue;
                }

                //From here we check the inside of the barcode only without # and @.
                List<char> tempList = charList;
                tempList.RemoveAll(x => x == '@');
                tempList.RemoveAll(x => x == '#');
                if (tempList.Count<6)
                {
                    Console.WriteLine("Invalid barcode");
                    continue;
                }
                else if (char.IsUpper(tempList[0])==false || char.IsUpper(tempList[tempList.Count-1])==false)
                {
                    Console.WriteLine("Invalid barcode");
                    continue;
                }
                string productGroup = string.Empty;
                bool onlyLettersAndNumbers = true;
                for (int k = 0; k < tempList.Count; k++)
                {
                    if (char.IsLetter(tempList[k])==false)
                    {
                        if (char.IsDigit(tempList[k])==false)
                        {
                            onlyLettersAndNumbers = false;
                        }
                        else 
                        {
                            productGroup+=tempList[k].ToString();
                        }
                    }
                }
                if (onlyLettersAndNumbers == false)
                {
                    Console.WriteLine("Invalid barcode");
                    continue;
                }
                if (productGroup=="")
                {
                    Console.WriteLine($"Product group: 00");
                }
                else
                {
                    Console.WriteLine($"Product group: {productGroup}");
                }

            }


        }
    }
}
