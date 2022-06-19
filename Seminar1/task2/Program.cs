int n1, n2;

Console.Write("Введите первое число: ");
n1=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
n2=Convert.ToInt32(Console.ReadLine());

if (n1>n2)
{
    Console.WriteLine("Большее чиcло "+n1);
    Console.WriteLine("Меньшее чиcло "+n2);
}

else
{
Console.WriteLine("Большее чиcло "+n2);
Console.WriteLine("Меньшее чиcло "+n1);
}