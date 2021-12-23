// 41. Выяснить являются ли три числа сторонами треугольника

Console.Clear();

Console.Write("Введите строну а: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Введите строну b: ");
double b = double.Parse(Console.ReadLine());
Console.Write("Введите строну c: ");
double c = double.Parse(Console.ReadLine());

if ((a + b > c) && (b + c > a) && (a + c > b))
{
    Console.WriteLine("Это треугольник");
}
else
{
    Console.WriteLine("Это не треугольник");
}