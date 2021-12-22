// 31. Задать массив из 8 элементов и вывести их на экран 

Console.Clear();

int[] array = {4, 6, 9, 23, 56, 78, 2 ,8};
{
    int count = array.Length;
    int index = 0;
    while (index < count)
    {
        Console.Write(" " + array[index] + " ");
        index++;
    }
}
