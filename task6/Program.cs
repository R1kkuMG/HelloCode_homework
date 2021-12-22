int a = new Random().Next(1, 10); // 1 2 3 4 ... 9
Console.WriteLine(a);

if(a % 2 == 0)
{
    Console.Write("Четное число");
}

else
{
    Console.Write("Нечетное число");
}