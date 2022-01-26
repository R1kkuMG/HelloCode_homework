// 50.  В двумерном массиве n×k заменить четные элементы на противоположные

Console.Clear();

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}");
        }
    }
}

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1,10);
        }
    } 
}

void OppositeArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] % 2 == 0 && matrix[i, j] > 0)
            {
                matrix[i, j] = - matrix[i, j];
                Console.Write($"{matrix[i, j]}");
            }
        }
    } 
}

void Demo()
{
    int[,] matrix = new int[3, 3];
    FillArray(matrix);
    Console.WriteLine();
    PrintArray(matrix);
    Console.WriteLine();
    OppositeArray(matrix);
}

Demo();
