// Задайте значение N. Напишите программу, которая найдет кол-во цифр в числе N рекурсивным методом.
// N = 4532 -> 4

double NumOfDigit(double a)
{
    double count = 0;
    if (a < 10) return 1;
    else return count = 1 + NumOfDigit(a / 10);
}

Console.Write("Введите число: ");
double num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(NumOfDigit(num));
