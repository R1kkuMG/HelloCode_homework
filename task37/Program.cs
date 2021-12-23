// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

Console.Clear();

int[] array = new int[123];

Console.Write("Массив {");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 124);
    Console.Write(" " + array[i] + " ");
}
Console.WriteLine("}");

int sum = 0;
int j;
for (j = 0; j < array.Length; j++)
{
   if (array[j] < 100 & array[j] > 9 )
    {
        sum = sum + 1;
    } 
}
Console.Write($"Количество элементов из отрезка [10,99] = {sum}"); 