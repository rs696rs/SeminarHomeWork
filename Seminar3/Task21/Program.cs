// Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.

double Ras(double x1, double y1, double z1,double x2, double y2, double z2)
{
    double result=Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
    return result;
}

Console.Write("Введите x1: ");
double x1=Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y1: ");
double y1=Convert.ToDouble(Console.ReadLine());
Console.Write("Введите z1: ");
double z1=Convert.ToDouble(Console.ReadLine());
Console.Write("Введите x2: ");
double x2=Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y2: ");
double y2=Convert.ToDouble(Console.ReadLine());
Console.Write("Введите z2: ");
double z2=Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Расстояние между А и В " + Ras(x1,y1,z1,x2,y2,z2));
