// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

Console.Clear();

double[] array = new double[10];

Console.Write("Массив {");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 11);
    Console.Write(" " + array[i] + " ");
}
Console.WriteLine("}");

int j;
double max = 0;
for (j = 0; j < array.Length; j++)
{
   if (array[j] > max)
    {
        max = array[j];
    }
}
Console.Write($"Максимальное число в массиве = {max}");

Console.WriteLine(" ");
int k;
double min = max;
for (k = 0; k < array.Length; k++)
{
   if (array[k] < min)
    {
        min = array[k];
    } 
}
Console.Write($"Минимальное число в массиве = {min}");

Console.WriteLine(" ");

Console.Write($"Разница между максимальным и минимальным числами в массиве = {max - min}");