// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] CreateArrayInputNumber(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите " + (i + 1) + " число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    return array;
}

int FinedNegativeNumber(int[] array)
{
    int count = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) count += 1;
    }

    return count;
}

Console.Write("Введите количество числел: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArrayInputNumber(size);

Console.WriteLine("Введено чисел меньше 0: " + FinedNegativeNumber(myArray));