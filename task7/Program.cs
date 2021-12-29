// 7. Показать числа от -N до N

Console.Clear();

Console.Write("Введите целое число: ");
int num = int.Parse(Console.ReadLine());
int result = -num;
while(result <= num)
{
    Console.WriteLine(result);
    result++;
}

//Console.WriteLine("num - {0}", result); 