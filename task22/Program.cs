// 22. Найти расстояние между точками в пространстве 2D/3D

Console.WriteLine("2D или 3D:");
int D = int.Parse(Console.ReadLine());
double distance = 0;

if(D == 2)
{
    Console.WriteLine("Введите координаты x1:");
    double x1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите координаты x2):");
    double x2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите координаты y1:");
    double y1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите координаты y2):");
    double y2 = double.Parse(Console.ReadLine());
    distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    Console.WriteLine($"Расстояние между двумя точками в 2D равно {distance}");
}

if(D == 3)
{
    Console.WriteLine("Введите координаты x1:");
    double x1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите координаты x2):");
    double x2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите координаты y1:");
    double y1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите координаты y2):");
    double y2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите координаты z1):");
    double z1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите координаты z2):");
    double z2 = double.Parse(Console.ReadLine());
    distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    Console.WriteLine($"Расстояние между двумя точками в 3D равно {distance}");
}
if(D != 2 && D !=3)
{
   Console.WriteLine($"Неверный запрос"); 
}