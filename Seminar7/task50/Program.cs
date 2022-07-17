// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

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
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

void FindElement2dArray(int[,] array, int a, int b)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            if ((i == a) && (b == j)) Console.WriteLine("Искомый элемент: " + array[a, b]);
    }
    if (((array.GetLength(0) - 1) < a) | ((array.GetLength(1) - 1) < b))
    {
        Console.WriteLine("Искомый элемент отсутствует в данном массиве");
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

Console.Write("Введите позицию строки: ");
int it = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите позицию столбца: ");
int jit = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("");

int[,] my2dArray = CreatRandom2dArray(rows, columns, minValue, maxValue);

Show2dArray(my2dArray);

Console.WriteLine(" ");

FindElement2dArray(my2dArray, it, jit);