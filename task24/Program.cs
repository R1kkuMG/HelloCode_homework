// 24. Найти кубы чисел от 1 до N

Console.Clear();
Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine());

int i = 0;

for (i = 1; i <= n; i++)
{
    Console.WriteLine($"{i} x {i} x {i} = {Math.Pow(i, 3)}");
}