//  Задайте массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.


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


int UnfairPosition(int[] array)
{
    int sum=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2>0) sum+=array[i];
    }
    return sum;
}

Console.Write("Укажите зармер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Укажите диапазот массива от: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Укажите диапазот массива до: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArrya = CreateRandomArray(size,min,max);

ShowArray(myArrya);

Console.WriteLine("Cумма элементов, стоящих на нечётных позициях: "+UnfairPosition(myArrya));
