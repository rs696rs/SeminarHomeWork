// See https://aka.ms/new-console-template for more information
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

/*int FindPositivSum(int[] array)
{
    int sum=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0) sum+=array[i];
    }
    return sum;
}*/

void SwapNegativToPositivElement(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<0) 
        {
            array[i]=array[i]*-1;
        }
        Console.Write(array[i]+" ");
    }
    
}

void SwapPositivToNegativElement(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0) 
        {
            array[i]=array[i]*-1;
        }
        Console.Write(array[i]+" ");
    }
    
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

// SwapNegativToPositivElement(myArrya);

//SwapPositivToNegativElement(myArrya);
