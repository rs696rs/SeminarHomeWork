/*  Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

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

void MinimumSumRows(int[,] array, int columns)
{
    while (array.GetLength(0) == array.GetLength(1))
    {
        int[] SumArray = new int[array.GetLength(1)];
        int sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i, j];
            }
            SumArray[i] = sum;
            sum = 0;
            Console.WriteLine("Сумма элементов " + (i + 1) + " столбца: " + SumArray[i]); // вывод сумм строк для проверки 
        }
        int indexMin = 0;
        for (int a = 1; a < columns; a++)
        {
            if (SumArray[a] < SumArray[indexMin])
                indexMin = a;
        }
        Console.WriteLine();
        Console.WriteLine("Номер строки с минимальной суммой элементов: " + (indexMin+1));
        break;
    }
    if (array.GetLength(0) != array.GetLength(1)) Console.WriteLine("Массив не квадратный!");
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


int[,] my2dArray = CreatRandom2dArray(rows, columns, minValue, maxValue);

Show2dArray(my2dArray);

Console.WriteLine("");

MinimumSumRows(my2dArray, columns);



