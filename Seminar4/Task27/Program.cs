// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


int SumDigit(int n)
{
    int a = n / 100 % 10; // sotni
    int b = n / 10 % 10; // desatk
    int c = n % 10; // edenic
    int d = n / 1000 % 10; // tisach
    int e = n / 10000 % 10; //10 tisach
    int f = n / 100000 % 10; // 100 tisach
    int g = n / 1000000 % 10; // 1 million
    int k = n / 10000000 % 10; //10 million
    int m = n / 100000000; // 100 million
    int result = a + b + c + d + e + f + g + k + m;
    return result;
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Сумма цифр в веденом числе: "+SumDigit(a));