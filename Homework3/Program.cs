// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*
void Palindrom(int number)
{
    int num = number;
    int num1 = num / 10000;
    int num2 = num / 1000 % 10;
    int num4 = num % 100 / 10;
    int num5 = num % 10;

    if (num1 == num5 && num2 == num4)
    {
       Console.WriteLine("Your number is polindrom");
    }
    else
    {
        Console.WriteLine("Your number is not polindrom");
    }
}
    Console.WriteLine("Please input 5-digit number");
    int number = Convert.ToInt32(Console.ReadLine());
    Palindrom(number);
    
*/

/*
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double FindDistance(double x1, double x2, double y1, double y2, double z1, double z2)
{
    double distance = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2));
    double dist = Math.Round((distance),2);
    return dist;
}

Console.WriteLine("Input 3D coordinates of a two points");
Console.Write("point one coordinate x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("point one coordinate y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("point one coordinate z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("point two coordinate x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("point two coordinate y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("point two coordinate z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double dis = FindDistance(x1, x2, y1, y2, z1, z2);
Console.WriteLine($"Distance between points is {dis}");

*/


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void CubeLine(int number)
{
    int count = 1;

    if (number < 1)
    {
        Console.WriteLine("please enter number more than 1");
    }
    else
    {
        while (count <= number)
        {
            Console.WriteLine(Math.Pow(count,3));
            count++;
        }
    }
}

Console.Write("Please input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
CubeLine(number);