// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateRandomArray(int size, int min, int max)

{
    double[] array = new double[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1) + new Random().NextDouble();
    }
    return array;
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double MaxNumber(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
        if (array[i] > max) max = array[i];
    return max;
}

double MinNamber(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
        if (array[i] < min) min = array[i];

    return min;
}

void DifferenceElements(double a, double b)
{
    double dif = a-b;
    Console.WriteLine("Разница между максимальным и минимальным элементом массива: " + dif);
}

Console.Write("Укажите зармер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Укажите диапазот массива от: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Укажите диапазот массива до: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArrya = CreateRandomArray(size, min, max);

ShowArray(myArrya);

double Max = MaxNumber(myArrya);
double Min = MinNamber(myArrya);

Console.WriteLine(); // разделитель

DifferenceElements(Max,Min);
