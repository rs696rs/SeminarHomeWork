// See https://aka.ms/new-console-template for more information
void ThirdyDigital(int m)
{
    if (m/100<=0)
    {
    Console.WriteLine("Третьей цифры нет");
    }
    else
    {
    int c=m%10;
    Console.WriteLine("Третья цифра " + c);
    }
}

Console.Write("Введите трехзначное число: ");
int digit = Convert.ToInt32(Console.ReadLine());

ThirdyDigital(digit);
