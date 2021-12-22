// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 

int[] array = new int[8];
Console.Write("{");

{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(0, 2);
        Console.Write(" " + array[index]+ " ");       
        index++;
    }
}
Console.WriteLine("}");