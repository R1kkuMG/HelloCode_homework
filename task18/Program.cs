// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
// изменить коммит

Console.Write("Введите true или false: ");
bool X = bool.Parse(Console.ReadLine());
Console.Write("Введите false или true: ");
bool Y = bool.Parse(Console.ReadLine());

if(!(X | Y) == (!X & !Y))
{   
    Console.WriteLine($"Закон работает!");
}
else
{
    Console.WriteLine("Закон не работает!");
}