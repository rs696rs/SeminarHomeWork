// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
void AddMasiv(int[] masiv)
{
    int length = masiv.Length;
    int index = 0;
    while (index < length)
    {
        masiv[index] = new Random().Next(1, 10);
        index++;
    }

}

void PrintMasiv(int[] mas)
{
    int count = mas.Length;
    int position = 0;
    while (position<count)
    {
        Console.Write(mas[position]+",");
        position++;
    }
    
}

Console.Write("Вчедите число, обозначающее длинну массива: ");
int a=Convert.ToInt32(Console.ReadLine());

int[] array = new int[a];

AddMasiv(array);

PrintMasiv(array);



