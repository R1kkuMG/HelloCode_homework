// 5. Написать программу вычисления значения функции y = f(a)

Console.Clear();

int x = new Random().Next(1, 10); // 1 2 3 4 ... 9
Console.WriteLine(x);
int y = new Random().Next(1, 10); // 1 2 3 4 ... 9
Console.WriteLine(y);
int z = new Random().Next(1, 10); // 1 2 3 4 ... 9
Console.WriteLine(z);
int result = x * y + z;

Console.Write("a = ");
Console.Write(result);
