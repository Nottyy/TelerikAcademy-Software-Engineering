﻿//Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements. The first line in the input file contains the size of matrix N. Each of the next N lines contain N numbers separated by space. The output should be a single number in a separate text file. /using System;
using System.Collections.Generic;
using System.IO;
class MatrixInTextFileFindMaxSum2x2
{
    static void Main()
    {
        StreamWriter output = new StreamWriter("../../output.txt");
        output.WriteLine(GetMax(ReadMatrix()));

    }

    static int[,] ReadMatrix()
    {
        using (StreamReader input = new StreamReader("../../matrix.txt"))
        {
            int n = int.Parse(input.ReadLine());
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] numbers = input.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(numbers[j]);
                }
            }

            return matrix;
        }
    }
    static int GetMax(int[,] matrix)
    {
        int maxSum = int.MinValue;
        int sum = int.MinValue;
        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                sum = matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1];
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
            }
        }
        return maxSum;
    }


}

