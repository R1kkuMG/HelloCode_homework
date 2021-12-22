// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. 
// Найти сумму положительных/отрицательных элементов массива

Console.Clear();

int[] array = new int[12];
int sum1 = 0;
int sum2 = 0;

for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 10);
        Console.Write(" " + array[i]+ " ");
        if(array[i] > 0) sum1 = sum1 + array[i];
        if(array[i] < 0) sum2 = sum2 +array[i];    
    }
Console.WriteLine( );
Console.WriteLine($"Сумма положительных элементов массива = {sum1}");
Console.WriteLine($"Сумма отрицательных элементов массива = {sum2}");