//1. Программа проверяет пятизначное число на палиндромом.

Console.WriteLine("Введите 5-значное число:");
int num = int.Parse(Console.ReadLine());
string txt = num.ToString();
bool flag = true;

for(int i = 0; i < txt.Length; i++)
{
    if(txt[i] != txt[txt.Length - i - 1])
    {
        Console.WriteLine("Не палиндром");
        flag = false;
        break;
    }
}

if(flag)
{
    Console.WriteLine($"Число {num} является палиндромом");
}

else
{
    Console.WriteLine($"Число {num} не является палиндромом");
}
