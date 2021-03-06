﻿using System;
using System.Collections.Generic;
using System.Linq;

public class Majorant
{
    public static List<int> InputList()
    {
        Console.WriteLine("Please enter some numbers in range [0..1000]");
        Console.WriteLine("Enter empty line to finish");

        List<int> inputData = new List<int>();

        while (true)
        {
            string currentInput = Console.ReadLine();
            if (currentInput == string.Empty)
            {
                break;
            }

            int value = int.Parse(currentInput);

            if (value < 0 || value > 1000)
            {
                Console.WriteLine("Not valid input");
                continue;
            }

            inputData.Add(value);
        }

        return inputData;
    }

    public static void FindMajorant(List<int> input)
    {
        SortedDictionary<int, int> appereanceCounter = new SortedDictionary<int, int>();

        foreach (var item in input)
        {
            if (appereanceCounter.ContainsKey(item))
            {
                appereanceCounter[item]++;
            }
            else
            {
                appereanceCounter.Add(item, 1);
            }
        }

        var maxAppearence = appereanceCounter.Values.Max();

        if (maxAppearence >= (input.Count / 2 + 1))
        {
            var mostFrequentValue = appereanceCounter.FirstOrDefault(x => x.Value == maxAppearence).Key;
            Console.WriteLine("The majorant {0} appears {1} times out of {2} items in the array", mostFrequentValue, maxAppearence, input.Count);
        }
        else
        {
            Console.WriteLine("There is no majorant.");
        }
    }

    public static void Main()
    {
        List<int> inputData = InputList();
        FindMajorant(inputData);
    }
}
