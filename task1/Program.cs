// 1. По двум заданным числам проверять является ли первое квадратом второго

Console.Clear();

void Sqr()
{
    int numberA = new Random().Next(1, 10); // 1 2 3 4 ... 9
    Console.WriteLine(numberA);
    int numberB = new Random().Next(1, 10);
    Console.WriteLine(numberB);

    if (numberA == numberB * numberB)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.Write("No");
    }
}

Sqr();