// 47. Написать программу копирования массива
Console.Clear();

void CopyArray()
{
    int[] a = {1,2,3,4,5};
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write(" " + a[i] + " ");
    }
    Console.WriteLine(" ");

    int[] b = new int[5]; //New Array and the size of a which is 4
    for (int j = 0; j < b.Length; j++)
    {
        Array.Copy(a, 0, b, 0, 5);
        // a - исходный массив
        // 0 = начальный индекс в исходном массиве
        // b = целевой массив
        // 0 = начальный индекс в целевом массиве
        // 5 = элементы для копирования
        Console.Write(" " + b[j] + " ");
    }
}
CopyArray();