// 35. Определить, присутствует ли в заданном массиве, некоторое число

Console.Clear();

int[] array = new int[10];

Console.Write("Массив {");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 101);
    Console.Write(" " + array[i] + " ");
}
Console.WriteLine("}");


Console.WriteLine("Введите число от 0 до 100: ");
int find = Convert.ToInt32(Console.ReadLine());
if (find > 100 || find < 0) Console.WriteLine("Число введено неверно!");

int j;

for (j = 0; j < array.Length; j++)
{
    if (find == array[j]) 

    { 
        Console.WriteLine($"Число {array[j]} расположено на {j+1} месте"); 
        break; // будет выдавать первое найденное 
    }
}   
        
if (j == array.Length || j > array.Length) Console.WriteLine($"Числа {find} нет в текущем массиве");
