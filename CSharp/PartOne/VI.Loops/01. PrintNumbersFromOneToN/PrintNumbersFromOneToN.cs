﻿namespace PrintNumbersFromOneToN
{
    using System;

    class PrintNumbersFromOneToN
    {
        static void Main()
        {
            /*
             * Write a program that prints all the numbers from 1 to N.
             */
            
            Console.Write("Enter an integer: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
