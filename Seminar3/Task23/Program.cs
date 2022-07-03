// Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу кубов чисел от 1 до N.
void Cub(int n)
{
    for (int i=1;i<=n;i++)
    {
        Console.Write(i*i*i +" ");
    }
    
}
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

Cub(a);
