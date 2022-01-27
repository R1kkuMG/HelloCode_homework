// 54. В матрице чисел найти сумму элементов главной диагонали

Console.Clear();

void FillArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,9);
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void SumArray (int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                sum = sum + array[i,j];
            }
        }
    }
    Console.WriteLine($"Сумма элементов главной диагонали = {sum}");
}

int[,] array = new int [3,3];
FillArray(array);
SumArray(array);