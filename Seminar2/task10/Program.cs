// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

int SecondDigit(int n)
{
    int dec = n / 10 % 10;
    return dec;
}

Console.Write("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

int SecD = SecondDigit(a); 
Console.WriteLine("Вторая цифра " + SecD);











    
   
