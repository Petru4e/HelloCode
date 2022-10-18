﻿
void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.WriteLine(col[position]);
        position++;
    }
}
int IndexOf(int[] col, int find)
{
    int count = col.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (col[index] == find)
        {
            position = index;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();

int pos = IndexOf(array,4);
System.Console.WriteLine(pos);