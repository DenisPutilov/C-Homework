
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

void Show2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "   ");
        Console.WriteLine();
    }
    Console.WriteLine();
}


// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

/*
int[,] MaxToMinRowsArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int m = j + 1; m < array.GetLength(1); m++)
            {
                if(array[i, m] > array[i, j])
                {
                    int temp = array[i, m];
                    array[i, m] = array[i, j];
                    array[i, j] = temp;
                }
            }
        }
    }
    return array;
}

int[,] myArray = CreateRandom2DArray();
Show2DArray(myArray);
int[,] resArray = MaxToMinRowsArray(myArray);
Show2DArray(resArray);
*/

// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

/*
int[] SumsOfRows(int[,] array)
{
    
    int[] sumsArray = new int[array.GetLength(1)];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        int sumOfRow = 0;
        for(int j =0; j < array.GetLength(1); j++)
        {
           sumOfRow += array[i, j];
        }
        sumsArray[i] = sumOfRow;
        Console.WriteLine($"sum of row {i+1} is {sumsArray[i]}");
        
    }
    return sumsArray;
}

void MinSumOfRows(int[] array)
{
int minSum = array[0];
int minSumRow=1;
    
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minSum)
        {
            minSum = array[i];
            minSumRow = i+1;
        } 
    
    }
    Console.WriteLine($"row with min sum of elements is {minSumRow}");
}


int[,] array56 = CreateRandom2DArray();
Show2DArray(array56);
int[] myArray = SumsOfRows(array56);
MinSumOfRows(myArray);
*/


/*
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] InputMatrix()
{
    Console.Write("input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("input elements: ");

    int[,] handMadeMatrix = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"elemnet {i}{j}: ");
            handMadeMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
    return handMadeMatrix; 
}



int[,] MatrixMultiplication(int[,] array1, int[,] array2)
{
    int[,] newArray = new int[array1.GetLength(0), array2.GetLength(1)];
    
    if (array1.GetLength(0) != array2.GetLength(1))
    {
    Console.WriteLine($"impossible to multiply such matrixes!");
    }
    else
    {
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for(int j = 0; j < array2.GetLength(1); j++)
            {
                for(int m = 0; m < array2.GetLength(1); m++)
                {
                    newArray[i, j] += array1[i, m] * array2[m, j];
                }
                
            }
        }
    }
    return newArray;
}

int[,] array1 = InputMatrix();
Console.WriteLine("matrix 1");
Show2DArray(array1);
int[,] array2 = InputMatrix();
Console.WriteLine("matrix 2");
Show2DArray(array2);
int[,] multiMatrix = MatrixMultiplication(array1, array2);
Console.WriteLine("multiplication of two matrixes is the matrix: ");
Show2DArray(multiMatrix);
*/


// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[] rndArray()
{
    int[] array = Enumerable.Range(10, 90).ToArray();
    for (int i = 0; i < array.Length; i++)
    {
        int j = new Random().Next(0, 90);
        if (j != i)
        {
            var temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
    return array;
}


int[,,] Create3DArrayInt(int[] array, int rows, int columns, int cells)
{
    
    int m = 0;
    int[,,] newArray = new int[rows, columns, cells];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            for(int k = 0; k < cells; k++)
            {
                newArray[i, j, k] = array[m];
                m++;
            }
        }
    }
    return newArray;
}

void Show3DArray(int[,,] array)
{
    Console.WriteLine();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine($"{i+1} lay of matrix");
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j , k] + "  ");
            }
        Console.WriteLine();
        }
    Console.WriteLine();
    }
}

Console.Write($"input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write($"input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write($"input number of cells: ");
int cells = Convert.ToInt32(Console.ReadLine());
Console.Write("input min value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("input max value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] digitsArray = rndArray();
int[,,] myArray = Create3DArrayInt(digitsArray, rows, columns, cells);
Show3DArray(myArray);



// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
/*
int[,] SpiralMatrix()
{
    Console.Write("input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int item = 0, elements = 1; elements <= rows * columns; item++)
    {
        for (int i = item, j = item; j < columns - item; j++, elements++) 
            array[i, j] = elements;

        if (elements > rows * columns) break;
        for (int i = item + 1, j = columns - item - 1; i < rows - item; i++, elements++) 
            array[i, j] = elements;

        if (elements > rows * columns) break;
        for (int i = rows - item - 1, j = columns - item - 2; j >= item; j--, elements++)
            array[i, j] = elements;

        if (elements > rows * columns) break;
        for (int i = rows - item - 2, j = 0 + item; i >= item + 1; i--, elements++) 
            array[i, j] = elements;
    }
    return array;
}

void ShowSpiralArray(int[,] array, int fillZeros = 2)
{
    Console.WriteLine("spiral matrix: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j].ToString($"D{fillZeros}") + " "); 
        Console.WriteLine();
    }
}

int[,] myArray = SpiralMatrix();
ShowSpiralArray(myArray);
*/
