﻿/*
 * Write a program that finds the maximal sequence of equal elements in an array.
   Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} -> {2, 2, 2}.
 */

namespace MaximalSequenceOfEqualElements
{
    using System;

    class MaximalSequenceOfEqualElements
    {
        static void Main()
        {
            //input
            Console.WriteLine("Enter the numbers in array: ");
            int arrayCount = int.Parse(Console.ReadLine());
            int[] arrayNumbers = new int[arrayCount];

            for (int index = 0; index < arrayCount; index++)
            {
                Console.Write("Enter number on position {0}: ", index + 1);
                arrayNumbers[index] = int.Parse(Console.ReadLine());
            }

            //calculation
            int numberOfIterations = 1;
            int bestIteration = 0;
            int startNumber = 0;
            int bestNumber = 0;

            for (int index = 0; index < arrayCount - 1; index++)
            {
                if (arrayNumbers[index] == arrayNumbers[index + 1])
                {
                    startNumber = arrayNumbers[index];
                    numberOfIterations++;
                    continue;
                }
                if (numberOfIterations > bestIteration)
                {
                    bestIteration = numberOfIterations;
                    bestNumber = startNumber;
                    numberOfIterations = 1;
                }
            }

            //output
            Console.WriteLine("There are {0} {1}s one after another!", bestIteration, bestNumber);
        }
    }
}
