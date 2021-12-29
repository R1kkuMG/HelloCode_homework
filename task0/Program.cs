// 0. Вывести квадрат числа
Console.Clear();

void Sqr()
{
    int numberA = new Random().Next(1, 10); // 1 2 3 4 ... 9
    Console.WriteLine(numberA);
    int numberB = numberA;
    Console.WriteLine(numberB);
    int result = numberA * numberB;
    Console.WriteLine(result);
}
Sqr();