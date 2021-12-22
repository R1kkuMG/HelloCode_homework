// Удалить вторую цифру трёхзначного числа

Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());

int a = num / 10;
int b = num % 10; // 10
int c = num / 100; // 100

Console.Write(c);
Console.Write(b);