// // Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

double SumNums(double a, double b)
{
    if (b>=a) 
    {
    return a + SumNums(a+1,b);
    }
    else return 0;
}

Console.Write("Введите число M: ");
double m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
double n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumNums(m,n));

