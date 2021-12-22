// 34. Написать программу замену элементов массива на противоположные

Console.Clear();

int[] array = new int[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 11);
    Console.Write(" " + array[i] + " ");
}
Console.WriteLine(" ");
for (int j = 0; j < array.Length; j++)
{
    array[j] = -array[j];
    Console.Write(" " + array[j] + " "); 
}