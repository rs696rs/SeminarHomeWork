// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*int FindZero(int[] numb)
{
    int result = 0;
    for (int i = 0; i < numb.Length; i = i + 2)
    {
        if (numb[i] > 0) result = result + 1;
    }
    return result;
}
*/
int[] Converting(string text)
{
    int[] array = new int[text.Length];
    for (int i = 0; i < text.Length; i++)
    {
        array[i] = text[i];

    }
    return array;
}

void ShowArray(int[] numb)
{
    for (int i = 0; i < numb.Length; i++)
    {
        Console.Write(numb[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Введите числа (через пробел): ");
//string m = Console.ReadLine();
string number = Console.ReadLine();

int[] myArray = Converting(number);

ShowArray(myArray);

//Console.WriteLine("Количество чисел больше 0: "+FindZero(myArray));

