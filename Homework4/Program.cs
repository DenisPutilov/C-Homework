// доп задание на ввод массива пользователем
// сначала сделал тут до того как открыл домашку, в 3 задачу просто копирую
/*
int [] UserCreatedArray(int size)
{
    
    int[] userArray = new int[size];

    for(int i=0; i<size; i++)
        userArray[i] = Convert.ToInt32(Console.ReadLine());

    return userArray;
    
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

Console.Write("Please input size of your massive: ");
int size = Convert.ToInt32(Console.ReadLine());
if (size <1) Console.WriteLine("Invalid range, please try again");
else Console.WriteLine("Input digits of your massive: ");

int[] userArray = UserCreatedArray(size);
Console.WriteLine("your massive is: ");
ShowArray(userArray);
*/

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int StepenChisla(int a, int b)
{
    int result = a;

    for (int i = 1; i < b; i++)
        result = result * a;
    return result;
}

Console.Write("Please input number a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input degree b of number a: ");
int b = Convert.ToInt32(Console.ReadLine());

int res = StepenChisla(a, b);
Console.WriteLine($"The result of operation {a} deg {b} is  - {res}");
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
int SumOfDigits(int num)
{
    int sum = 0;
    string n = Convert.ToString(num);
    int size = n.Length;
    int current = num;


    while (size >= 1)
    {
       int div = current % 10;
       sum = sum + div;
       current = current / 10;
       size--;
    }
    return sum;
}
    

Console.Write("please input number more than 1: ");
int num = Convert.ToInt32(Console.ReadLine());

int s = SumOfDigits(num);
Console.WriteLine($"sum of digits of number {num} is {s}");

*/


// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

// random
/*
int[] RandomArray (int size, int min, int max)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1);
    }
    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ", ");
    
    Console.WriteLine();
}

Console.Write("input number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("input min number of elements: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("input max number of elements: ");
int max = Convert.ToInt32(Console.ReadLine());


int[] myArray = RandomArray(size, min, max);

ShowArray(myArray);
*/


// user input

int [] UserCreatedArray(int size)
{
    
    int[] userArray = new int[size];

    for(int i=0; i<size; i++)
        userArray[i] = Convert.ToInt32(Console.ReadLine());

    return userArray;
    
}

void ShowArray(int[] array)
{
    
   
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "  ");
    
    Console.WriteLine();
    
}

Console.Write("Please input size of your massive: ");
int size = Convert.ToInt32(Console.ReadLine());
if (size <1) Console.WriteLine("Invalid range, please try again");
else Console.WriteLine("Input digits of your massive: ");

int[] userArray = UserCreatedArray(size);
if (size > 1) Console.WriteLine("your massive is: ");
ShowArray(userArray);