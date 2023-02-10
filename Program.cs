﻿/*Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/


int[,] GetArray( int m, int n, int minValue, int maxValue) // Генерация двумерного массива
{
    int[,] result = new int[m, n];
    for (int row = 0; row < m; row++)
    {
        for (int column = 0; column < n; column++)
        {
            result[row, column] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray) // Вывод массива на консоль
{
    for (int row = 0; row < inArray.GetLength(0); row++)
    {
        for (int colunm = 0; colunm < inArray.GetLength(1); colunm++)
        {
            Console.Write($"{inArray[row, colunm]}\t ");
        }
        Console.WriteLine();
    }
}

int[,] RowSort(int[,] matrix)
{
    for(int row = 0; row < matrix.GetLength(0); row++)  
    {
        for(int column = 0; column < matrix.GetLength(1) - column; column++)
        {
            int max = matrix[row, column];
            if(max < matrix[row, column + 1])
            { 
                matrix[row, column] = matrix[row, column + 1];
            }
        }
    }
    return matrix;
}

void Main()
{
    int[,] myMatrix = GetArray(4, 5, 0, 10);
    PrintArray(myMatrix);
    int[,] sortMatrix = RowSort(myMatrix);
    Console.WriteLine();
    PrintArray(sortMatrix);
}

Main();