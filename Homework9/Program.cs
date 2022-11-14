// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
void ShowNums(int n)
{
    Console.Write(n + " ");
    if(n > 1) ShowNums(n - 1);
}

ShowNums(8);
*/


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/*
int ShowSumBetweenNums(int m, int n)
{
    if(m > n) return m + ShowSumBetweenNums(m - 1, n);
    if(m < n) return n + ShowSumBetweenNums(m, n - 1);
    else return m; 
}

Console.Write("input number m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("input number n: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = ShowSumBetweenNums(m, n);
Console.WriteLine("sum of elements between " + m + " & " + n +" is: " + sum);
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akker(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Akker(m - 1, 1);
    if (m > 0 && n > 0) return Akker(m - 1, Akker(m,n - 1));
    return Akker(m,n); 
}                  

Console.Write("input positive number m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("input positive number n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("if m = " +m +" and " + "n = " + n + " function Akkerman(m,n) = " + Akker(m,n));      