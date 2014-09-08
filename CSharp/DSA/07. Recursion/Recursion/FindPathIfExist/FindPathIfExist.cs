﻿using System;

public class FindPathIfExist
{
    private static char[,] matrix;
    private static Random random = new Random();
    private static int MaxAreaCount = 0;

    public static void Main()
    {
        int size = GetInput();
        matrix = GenerateMatrix(size);
        PrintMatrix(matrix);
        FindMaxArea();
        TryFindPath(0, 0);
        Console.WriteLine("No path found");
    }

    private static int GetInput()
    {
        Console.Write("Please enter the matrix size (less than 20 is stil ok): ");
        int input = int.Parse(Console.ReadLine());
        return input;
    }

    private static char[,] GenerateMatrix(int size)
    {
        char[,] matrix = new char[size, size];
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                matrix[row, col] = GetCell();
            }
        }

        return matrix;
    }

    private static char GetCell()
    {
        bool isPassable = random.Next(100) > 40;

        if (isPassable)
        {
            return ' ';
        }
        else
        {
            return '#';
        }
    }

    private static void PrintMatrix(char[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col]);
            }

            Console.WriteLine();
        }
    }

    private static void FindMaxArea()
    {

        int maxArea = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                MaxAreaCount = 0;
                TryFindPath(row, col);
                if (maxArea < MaxAreaCount)
                {
                    maxArea = MaxAreaCount;
                }
            }
        }

        Console.WriteLine("Max area is {0} cells", maxArea);
    }

    private static void TryFindPath(int row, int col)
    {
        if (row < 0 || row >= matrix.GetLength(0) ||
            col < 0 || col >= matrix.GetLength(1) ||
            matrix[row,col] != ' ')
        {
            return;
        }

        MaxAreaCount++;
        matrix[row, col] = 'v';

        TryFindPath(row, col + 1); //right
        TryFindPath(row + 1, col); //down
        TryFindPath(row, col - 1); //left
        TryFindPath(row - 1, col); //up
    }
}
