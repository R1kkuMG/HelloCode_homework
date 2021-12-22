// 30. Показать кубы чисел, заканчивающихся на четную цифру

Console.Clear();
Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"{i} x {i} x {i} = {Math.Pow(i, 3)}");
    }
    else
    {
        Console.WriteLine($"{i} Нечетное");
    }
}


