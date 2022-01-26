// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// 52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

Console.Clear();

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1, 10);
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void IndexOf(int[,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 ==0)
            {
                col[i,j] = col[i,j] * col[i,j];
                Console.Write($"{col[i,j]} ");
            }
        }
    }
}

int[,] array = new int[4,4];
FillArray(array);
Console.WriteLine();
IndexOf(array);