using System;

namespace _3._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string remove = Console.ReadLine();
            string objectsToRemove = Console.ReadLine();

            while (objectsToRemove.Contains(remove))
            {
                int index = objectsToRemove.IndexOf(remove);
                objectsToRemove = objectsToRemove.Remove(index,remove.Length);
            }

            Console.WriteLine(objectsToRemove);
        }
    }
}
