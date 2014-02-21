﻿/*
 * Write a method that return the maximal element in a portion of
 * array of integers starting at given index. Using it write
 * another method that sorts an array in ascending / descending order.
 */

namespace SortArrayAscending
{
    using System;
    class SortArrayAscending
    {
        static Random rnd = new Random();
        static int[] GenerateRandomArray(int numberOfItems)
        {
            int maxNumberInArray = numberOfItems * 2;
            int[] randomArray = new int[numberOfItems];

            for (int counter = 0; counter < numberOfItems; counter++)
            {
                randomArray[counter] = rnd.Next(maxNumberInArray);
            }
            return randomArray;
        }
        static void PrintArray(int[] inputArray)
        {
            for (int counter = 0; counter < inputArray.Length; counter++)
            {
                Console.Write("{0}\t", inputArray[counter]);
            }
        }

        static int FindMaxIntInSubarray(int[] inputArray, int startPossition, int endPossition)
        {
            int maxNumber = int.MinValue;
            int maxNumberIndex = startPossition;
            if (startPossition > endPossition || startPossition < 0 || endPossition > inputArray.Length - 1)
            {
                return 0;
            }
            for (int index = startPossition ; index <= endPossition; index++)
            {
                if (inputArray[index] > maxNumber)
                {
                    maxNumber = inputArray[index];
                    maxNumberIndex = index;
                }
            }
            return maxNumberIndex;
        }
        static int[] SortAscending(int [] inputArray)
        {
            int[] sortedArray = inputArray;
            for (int index = inputArray.Length-1; index >= 0; index--)
            {
                int maxIndex = FindMaxIntInSubarray(sortedArray, 0, index);
                int tempValue = sortedArray[maxIndex];
                sortedArray[maxIndex] = sortedArray[index];
                sortedArray[index] = tempValue;
            }
            return sortedArray;
        }
        static void Main()
        {
            Console.Write("Enter the lenght of the array: ");
            int arrayLenght = int.Parse(Console.ReadLine());
            int[] array = GenerateRandomArray(arrayLenght);
            Console.WriteLine();
            PrintArray(array);
            Console.WriteLine();
            Console.WriteLine(new string('-', 30));

            int[] sortedArray = SortAscending(array);
            Console.WriteLine();
            Console.WriteLine("Array sorted ascending:");
            PrintArray(sortedArray);
        }
    }
}