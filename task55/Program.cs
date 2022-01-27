// 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

Console.Clear();

void FillArray (int[,] array)
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

void AverageRow (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {  
            sum = sum + array[j,i];  
        }
        double average = sum / 3;
        int col = i + 1;    
        Console.WriteLine($"Среднее арифметическое {col} столбца = {average}");      
    }
}

int[,] array = new int [3,3];
FillArray(array);
AverageRow(array);
