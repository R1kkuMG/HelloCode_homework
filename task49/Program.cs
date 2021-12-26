// Показать двумерный массив размером m×n заполненный вещественными числами

Console.Clear();

void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j] / 2d}"); // TO DO
        }
    }
}

void FillArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1,10);
        }
    }
}

double[,] matrix = new double [4,3];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);