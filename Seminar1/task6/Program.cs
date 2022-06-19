// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
int a;

Console.Write("Введите число: ");
a=Convert.ToInt32(Console.ReadLine());

if ((a%2)==0)
{
    Console.WriteLine("Чиcло четное");
}

else 
{
    Console.WriteLine("Не четное чиcло ");
}