// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 

Console.WriteLine("Введите число от 1 до 7:");
int num = int.Parse(Console.ReadLine());

if(num > 5)
{
    Console.WriteLine("Выходной!");
}
else
{
    Console.WriteLine("Не выходной :(");
}
