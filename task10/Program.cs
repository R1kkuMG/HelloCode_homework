// 10. Показать вторую цифру трёхзначного числа

Console.Clear();

Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());

int a = num / 10;
int b = a % 10; // 10
//int c = num; // 100

Console.WriteLine(b);