using System;
using System.Collections.Generic;

namespace CSharpArrayShuffler
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = new List<int>(); // Will hold the initial List to be shuffled 
            List<int> numListShuffle = new List<int>(); // Will hold the final, shuffled list

            // Populating the numList with integers from 1 to 10000 inclusive
            for (int i = 0; i < 10000; i++)
            {
                numList.Add(i + 1);
            }

            // Randomly populates numListShuffle with numbers from numList
            while (numList.Count > 0) // While there are still list items in numList
            {
                Random r = new Random(); // Initializes random number generator
                int rIndex = r.Next(0, numList.Count); // Random index integer starting from 0 and not exceeding length of numList
                numListShuffle.Add(numList[rIndex]); // Add the number at the specified index of numList to numListShuffle
                numList.RemoveAt(rIndex); // Delete the number from numList and repeat until there are no more numbers in numList
            }

            numListShuffle.ForEach(i => Console.Write("{0} ", i)); // Displays the numbers in numListShuffle sequentially
        }
    }
}
