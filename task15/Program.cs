// 15. Дано число. Проверить кратно ли оно 7 и 23

int num = new Random().Next(160, 165);
Console.WriteLine(num);

if(num % 7 == 0 && num % 23 == 0)
{
    Console.WriteLine("Кратно");
}
else
{
   Console.WriteLine("Не кратно"); 
}