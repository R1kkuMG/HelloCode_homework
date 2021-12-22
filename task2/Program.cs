int numberA = new Random().Next(1, 10); // 1 2 3 4 ... 9
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);

int max = numberA;
if (numberA > max) max = numberA;
if (numberB > max) max = numberB;

Console.Write("max = ");
Console.WriteLine(max);

int min = numberA;
if (numberA < min) min = numberA;
if (numberB < min) min = numberB;

Console.Write("min = ");
Console.WriteLine(min);