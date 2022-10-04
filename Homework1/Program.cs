/*
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input number 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (number2 > max)
{
    Console.WriteLine($"max = {number2} min = {number1}");
}
else
{
    Console.WriteLine($"max = {max} min = {number2}");
}
*/

/*
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > max)
{
    max = num2;
}
if (num3 > max)
{
    max = num3;
}
Console.WriteLine($"max = {max}");
*/



/*
//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Пожалуйста введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num%2 == 0)
{
Console.Write($"число {num} - четное");
}
else
{
Console.WriteLine($"число {num} - нечетное");
}

*/


/*
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Please input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
int current = 1;

Console.WriteLine("_________________________________");
Console.WriteLine($"Вот список четных чисел до {n}");

while (current <= n)
{
    if (current%2 == 0)
    {
    Console.Write($"{current},");
    }
current++;
}
*/