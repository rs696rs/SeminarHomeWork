// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");

int a=Convert.ToInt32(Console.ReadLine());

int current = 0;

while (current<a)
{
    current++;
   if ((current%2)==0)  
    Console.Write(current + " ");
}


