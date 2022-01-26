// 50.  В двумерном массиве n×k заменить четные элементы на противоположные

Console.Clear();

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1, 10);
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}


void OppositeArray(int[,] opposite)
{
    for (int i = 0; i < opposite.GetLength(0); i++)
    {
        for (int j = 0; j < opposite.GetLength(1); j++)
        {
            if (opposite[i,j] % 2 == 0)
            {
                //opposite[i, j] = -opposite[i,j];
                Console.Write($"{-opposite[i,j]} ");
            }
            else
            {
                opposite[i, j] = opposite[i,j];
                Console.Write($"{opposite[i,j]} ");
            }
            
        }
        Console.WriteLine();
    } 
}

void Demo()
{
    int[,] matrix = new int[3,3];
    FillArray(matrix);
    Console.WriteLine();
    OppositeArray(matrix);
}

Demo();
