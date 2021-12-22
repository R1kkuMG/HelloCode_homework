// 26. Возведите число А в натуральную степень B используя цикл

Console.Clear();
Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень:");
int m = int.Parse(Console.ReadLine());

int res = 1;

for (int i = 1; i <= m; i++)
{
    res = res * n;
    Console.WriteLine(res);
}