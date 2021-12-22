//17. По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("Введите первое число:");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int B = int.Parse(Console.ReadLine());

if(A == B * B)
{
    Console.WriteLine("Первое число явялется квадратом второго");
}
if(B == A * A)
{
    Console.WriteLine("Второе число является квадратом первого");
}
if(B != A * A && A != B * B)
{
    Console.WriteLine("Ни одно из чисел не является квадратом другого");
}
