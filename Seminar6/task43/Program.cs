// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

void IntersectionLines(double arg1, double arg2, double arg3, double arg4)
{
    while (arg1!=arg2)
    {
        double x = (arg4-arg3)/(arg1-arg2);
        double y=arg1*x+arg3;
        Console.WriteLine("Точка пересечения этих прямых: "+x+";"+y);
        break;
    }
    if (arg1==arg2) Console.WriteLine("Прямые параллельны");
}

Console.Write("Укажите точку к1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Укажите точку к2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Укажите точку б1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Укажите точку б2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

IntersectionLines(k1,k2,b1,b2);
