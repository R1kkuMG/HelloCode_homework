// Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());

int A = 5;
Console.WriteLine(A);

double result = num % A;

if(result == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine(result);
}