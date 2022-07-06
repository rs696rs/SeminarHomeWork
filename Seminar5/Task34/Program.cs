//  Задайте массив заполненный случайными положительными трёхзначными числами. 
//    Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateRandomArray(int size, int min, int max)

{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int EvenNambers(int[] array)
{
    int count=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2==0) 
        {
            count=count+1;
        }
    }
    return count;
}

Console.Write("Укажите зармер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Укажите диапазот массива от: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Укажите диапазот массива до: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArrya = CreateRandomArray(size,min,max);

ShowArray(myArrya);

Console.WriteLine("Количество четных элементов в массиве: "+EvenNambers(myArrya));



