//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

void Weekend(int m)
{
    if (m<6&m>0)
    {
    Console.WriteLine("Сегодня не выходной");
    }
    if (m>7)
    {
    Console.WriteLine("В неделе 7 дней");
    }
    if (m<=0)
    {
    Console.WriteLine("В неделе 7 дней");
    }
    while ((m>5)&&(m<8))
    {
    Console.WriteLine("Сегодня выходной)");
    break;
    }
}

Console.Write("Введите число: ");
int digit = Convert.ToInt32(Console.ReadLine());

Weekend(digit);