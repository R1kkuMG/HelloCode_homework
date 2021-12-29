// 14. Найти третью цифру числа или сообщить, что её нет

Console.Clear();

Console.Write("Введите любое число: ");
int num = int.Parse(Console.ReadLine());
while(num >= 1000)
{
    num = num/10;
}
    if(num < 100)
{
    Console.WriteLine("Error");
}
else
{
Console.WriteLine(num % 10);
}
