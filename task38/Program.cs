// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

Console.Clear();

int[] array = new int[10];

Console.Write("Массив {");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 11);
    Console.Write(" " + array[i] + " ");
}
Console.WriteLine("}");


int sum = 0;
int j;
for (j = 0; j < array.Length; j++)
{
   if (j % 2 != 0)
    {
        sum = sum + array[j];
    } 
}
Console.Write($"Сумма чисел, стоящих на нечетной позиции = {sum}"); 