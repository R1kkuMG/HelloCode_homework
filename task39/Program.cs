// 39. Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.

Console.Clear();

int[] array = new int[6];

Console.Write("Массив {");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 11);
    Console.Write(" " + array[i] + " ");
}
Console.WriteLine("}");


int sum1 = 0;
int j;
for (j = 0; j < array.Length; j++)
{
if (j == 5)
    {
        sum1 = array[j] * array[j-5];
    } 
}
Console.Write($"Произведение первой пары = {sum1}"); 

Console.WriteLine(" ");
int sum2 = 0;
int k;
for (k = 0; k < array.Length; k++)
{
if (k == 4)
    {
        sum2 = array[k] * array[k-3];
    } 
}
Console.Write($"Произведение второй пары = {sum2}"); 

Console.WriteLine(" ");
int sum3 = 0;
int l;
for (l = 0; l < array.Length; l++)
{
if (l == 3)
    {
        sum3 = array[l] * array[l-1];
    } 
}
Console.Write($"Произведение третьей пары = {sum3}"); 