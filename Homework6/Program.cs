// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

/*
Console.WriteLine();
Console.WriteLine("LET'S PLAY!");
Console.WriteLine();
Console.Write($"how much numbers do you wish to input? - ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("________________________");
Console.WriteLine($"input your numbers:");
int count = 0;

for (int i = 0; i < m; i++)
{
    Console.Write($"input {i+1} number: ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (n > 0) count++;
}

Console.WriteLine("________________________");
if (count == 1) Console.WriteLine($"congratulations! you input {count} positive number");
else Console.WriteLine($"congratulations! you input {count} positive numbers");
Console.WriteLine();
*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



void CrossPoint(double k1, double k2, double b1, double b2)
{
    double x = Math.Round((b2-b1) / (k1-k2), 1);
    double y = Math.Round(k1 * x + b1, 1);
    Console.WriteLine($"coordinates of two lines segments cross point is x = {x} and y = {y}");
}


Console.WriteLine("input coefficients k1, k2, b1, b2 for two line segments");
Console.Write("k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
CrossPoint(k1, k2, b1, b2);


