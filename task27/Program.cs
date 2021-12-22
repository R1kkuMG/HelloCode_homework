// 27. Определить количество цифр в числе

Console.Clear();
Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine());

int count = 0;
int b = 0;
 
while (a != 0)
{
    b = a % 10;
    a = a / 10;
    count++;
}

Console.WriteLine("Количество цифр: " + count); //Количество цифр: 0
Console.ReadLine();