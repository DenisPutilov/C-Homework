

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


double[,] CreatDoubleRandom2DArray()
{
    Console.Write("input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a min value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a max value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] rndArray = new double [rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            rndArray[i,j] = new Random().NextDouble() + new Random().Next(minValue, maxValue + 1);

    return rndArray; 
}


void Show2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "   ");
        Console.WriteLine();
    }
}

/*
double[,] myArray = CreatDoubleRandom2DArray();
Show2DArray(myArray);
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> числа с такими индексами в массиве нет



int[,] CreateRandom2DArray()
{
    Console.Write("input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a min value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a max value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array; 
}

/*
void ShowItemOfArray(int[,] array, int row, int col)
{
    if (row >= array.GetLength(0) || col >= array.GetLength(1))
        Console.WriteLine($"there is no such indexes in array");
    else 
        Console.WriteLine("element with index " + row + "_" + col + " is " + array[row, col]);
}

int[,] rndArray3 = CreateRandom2DArray();
Show2DArray(rndArray3);

Console.Write("input number of row to show: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("input number of column to show: ");
int col = Convert.ToInt32(Console.ReadLine());

ShowItemOfArray(rndArray3, row, col);
*/

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "   ");
    }
    Console.WriteLine();
}

int[,] rndArray52 = CreateRandom2DArray();
Show2DArray(rndArray52);

double[] AverageArifColArray(int[,] rndArray52)
{
    int size = rndArray52.GetLength(1);
    double[] array = new double[size];
    

    for(int j = 0; j < rndArray52.GetLength(1); j++)
    {
        double sum = 0;
        for(int i = 0; i < rndArray52.GetLength(0); i++)
        {
            sum += rndArray52[i,j];
        }
        array[j] = Math.Round(sum / rndArray52.GetLength(0),1);
    }
    return array;
}

double[] resArray = AverageArifColArray(rndArray52);
Console.WriteLine("math average of each column");
ShowArray(resArray);

