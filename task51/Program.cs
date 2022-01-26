﻿// 51. Задать двумерный массив следующим правилом: Aₘₙ = m+n

Console.Clear();

void PrintArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = i+j;
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    } 
}

int[,] array = new int[10,11];
PrintArray(array);
