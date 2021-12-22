// 20. Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Введите номер четверти координат:");
int Q = int.Parse(Console.ReadLine());

if(Q == 1)
{
    Console.WriteLine("X = (0; +∞) Y = (0; +∞)");
}
if(Q == 2)
{
    Console.WriteLine("X = (0; -∞) Y = (0; +∞)");  
}
if(Q == 3)
{
    Console.WriteLine("X = (0; -∞) Y = (0; -∞)");  
}
if(Q == 4)
{
    Console.WriteLine("X = (0; +∞) Y = (0; -∞)");  
}

if(Q != 1 && Q != 2 && Q != 3 && Q != 4)
{
    Console.WriteLine("Неверный запрос"); 
}