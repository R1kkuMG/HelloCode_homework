// 43. Написать программу преобразования десятичного числа в двоичное

Console.Clear();
int a = new Random().Next(0, 256);
Console.WriteLine(a);
string b = string.Empty;
while(a > 0)
{
    b = b + Convert.ToString(a % 2);
    a = a/2; 
}
char [] array = b.ToCharArray();
Array.Reverse(array);
Console.WriteLine(array);