﻿int[,] array = new int[1000,1000];
int[,] array1 = new int[1000,1000];
int[,] xArray = new int[1000,1000];
int i = 0, j = 0, row_numb = 0, max = 0;
Random rand = new Random();

Console.WriteLine("Задать массив MxN  через пробел:  ");
int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

for (i = 0; i < size[1]; i++)
    for (j = 0; j < size[0]; j++) 
    {
        array[i,j] = rand.Next(50);
    }

for (i = 0; i < size[0]; i++)
    for (j = 0; j < size[1]; j++) 
    {
        array1[i,j] = rand.Next(50);
    }

Console.WriteLine("Первый сгенерированный массив : " + size[0] + "x" + size[1]);

for (i = 0; i < size[1]; i++) 
{
    for (j = 0; j < size[0]; j++)
        if (array[i,j] < 10) Console.Write(" " + array[i,j] + " ");
        else Console.Write(array[i,j] + " ");
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("Второй сгенерированный массив : " + size[0] + "x" + size[1]);

for (i = 0; i < size[0]; i++) 
{
    for (j = 0; j < size[1]; j++)
        if (array1[i,j] < 10) Console.Write(" " + array1[i,j] + " ");
        else Console.Write(array1[i,j] + " ");
    Console.WriteLine();
}

for (i = 0; i < size[0]; i++) 
    for (j = 0; j < size[1]; j++) 
        xArray[i,j] = array[i,j] * array1[j,i];

Console.WriteLine();
Console.WriteLine("Второй сгенерированный массив : " + size[0] + "x" + size[1]);

for (i = 0; i < size[0]; i++) 
{
    for (j = 0; j < size[1]; j++)
        if (xArray[i,j] < 10) Console.Write(" " + xArray[i,j] + " ");
        else Console.Write(xArray[i,j] + " ");
    Console.WriteLine();
}