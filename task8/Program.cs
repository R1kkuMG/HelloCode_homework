// Показать четные числа от 1 до N

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int n = 2;
while(n <= num)
{
    Console.WriteLine(n);
    n = n + 2;
}