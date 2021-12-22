// Найти сумму чисел от 1 до А

Console.Clear();
Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine());

int i = 0;
int sum = 0;

for (i = 1; i <= n; i++)
{
    sum = sum + i;
    Console.WriteLine($"{sum}");
}
//Console.WriteLine($"{sum}");