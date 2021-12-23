// 36. Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных\четных чисел

Console.Clear();

int[] array = new int[10];

Console.Write("Массив {");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 101);
    Console.Write(" " + array[i] + " ");
}
Console.WriteLine("}");


int sum1 = 0;
int j;
for (j = 0; j < array.Length; j++)
{
   if (array[j] % 2 == 0)
    {
        sum1 = sum1 + 1;
    } 
}
Console.Write($"Количество четных = {sum1}"); 

Console.WriteLine(" ");

int sum2 = 0;
int k;
for (k = 0; k < array.Length; k++)
{
   if (array[k] % 2 != 0)
    {
        sum2 = sum2 + 1;
    } 
}
Console.Write($"Количество нечетных = {sum2}"); 