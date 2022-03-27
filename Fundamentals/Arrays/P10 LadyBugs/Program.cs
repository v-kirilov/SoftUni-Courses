using System;
using System.Linq;

namespace P10_LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            int[] placeArr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < placeArr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (placeArr[i] == j)
                    {
                        arr[j] = 1;
                    }
                }
            }
            //Console.WriteLine(String.Join(" ",arr));
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();  //command arguments , при смесени масиви и прочие се ползва това име

                int ladyBugIndex = int.Parse(cmdArgs[0]);
                string direction = cmdArgs[1];
                int moveLadyBug = int.Parse(cmdArgs[2]);

                if (ladyBugIndex >= arr.Length || ladyBugIndex < 0) //check if index is valid
                {
                    continue;  //ако сме извън масива нищо не става , изчезва калинката
                }

                if (arr[ladyBugIndex] == 0)
                {
                    continue;
                }

                arr[ladyBugIndex] = 0;
                int changedLadyBugIndex = ladyBugIndex;

                while (true)
                {
                    if (direction=="right")
                    {
                        changedLadyBugIndex += moveLadyBug;
                    }
                    else if (direction=="left")
                    {
                        changedLadyBugIndex -= moveLadyBug;
                    }
                    if (changedLadyBugIndex < 0 || changedLadyBugIndex >= arr.Length)
                    {
                        break;
                    }
                    if (arr[changedLadyBugIndex] == 0)
                    {
                        arr[changedLadyBugIndex] = 1;
                        break;
                    }
                    //if (arr[nextIndex]==1)
                    //{
                    //    nextIndex++;
                    //}
                }
            }
            Console.WriteLine(String.Join(" ", arr));


        }
    }
}
