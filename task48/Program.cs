// 48. Показать двумерный массив размером m×n заполненный целыми числами
Console.Clear();

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($" {matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void Demo()
{
    int[,] matrix = new int [3, 4];     
    FillArray(matrix);
    Console.WriteLine();
    PrintArray(matrix);
}

Demo();