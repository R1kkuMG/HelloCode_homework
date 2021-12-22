// 44. Найти точку пересечения двух прямых заданных уравнением 
//     y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы.
// x = (b2 - b1) / (k1 - k2)

Console.Clear();
int b1 = new Random().Next(-10, 11);
int b2 = new Random().Next(-10, 11);
int k1 = new Random().Next(-10, 11);
int k2 = new Random().Next(-10, 11);

if(k1 == k2)
{
    Console.WriteLine("Линии совпадают или параллельны");
    return;
}

Console.WriteLine($"Координата x: {(b2 - b1) / (k1 - k2)}"); // $ - позволяет вставлять переменную в {}
Console.WriteLine($"Координата y: {k1 * (b2 - b1) / (k1 - k2) + b1}");