// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, 
// причем X ≠ 0 и Y ≠ 0

Console.WriteLine("Введите координату X:");
double X = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y:");
double Y = double.Parse(Console.ReadLine());

if(X != 0 && Y != 0)
{
    if(X > 0 && Y > 0)
    {
        Console.WriteLine("Первая четверть");
    }
    if(X < 0 && Y > 0)
    {
        Console.WriteLine("Вторая четверть");
    }
    if(X < 0 && Y < 0)
    {
        Console.WriteLine("Третья четверть");
    }
    if(X > 0 && Y < 0)
    {
        Console.WriteLine("Четвертая четверть");
    }
}
else
{
    Console.Write("Error");
}