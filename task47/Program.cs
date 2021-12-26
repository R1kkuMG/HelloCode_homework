// 47. Написать программу копирования массива
Console.Clear();

int[] a = {1,2,3,4,5};

int [] b= new int[a.Length]; //New Array and the size of a which is 4

Array.Copy(a,b,a.Length);