// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
void Palind(int n)
{
string str=n.ToString();
int[]b=new int[str.Length];
//Console.WriteLine(str);
if (str[0]==str[4]&&str[1]==str[3]) 
{
    Console.WriteLine("Число является палиндромом");
}
else Console.WriteLine("Число не является палиндромом");
}

Console.Write("Введите 5 значное число: ");
int s = Convert.ToInt32(Console.ReadLine());

Palind(s);  