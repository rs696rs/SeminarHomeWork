﻿// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreatRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
    }

    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();    
    }
}

int [,] Srednee(int[,]array, int columns)
{
    int srednee = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        srednee= array[i]/columns;
    }
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число начала массива: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число конца массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("");


int[,] my2dArray = CreatRandom2dArray(rows,columns,minValue,maxValue);

Show2dArray(my2dArray);
