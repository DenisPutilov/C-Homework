
int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i=0; i<size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}


void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

/*
int Even(int[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0) count++;
    }
    return count;
}

int[] threeDNumArray = CreateRandomArray(5, 100, 999);
ShowArray(threeDNumArray);
int res = Even(threeDNumArray);
Console.WriteLine($"in this massive {res} even numbers");
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

/*

int SumOddArray (int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i%2 == 1) sum += array[i];
    }

    return sum;
}


int[] rndArray = CreateRandomArray(4, -1000, 1000);
ShowArray(rndArray);
int res = SumOddArray(rndArray);
Console.WriteLine($"sum of odd elements in array is {res}");
*/


// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
//[3 7 22 2 78] -> 76


/*
double[] UserDoubleArray(int size)
{
    double[] newArray = new double[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"input {i+1} number: ");
        newArray[i] = Convert.ToDouble(Console.ReadLine());
    }
    return newArray;
}

double DifferenceMinMax(double[] array)
{
    double min = array[0];
    double max = array[0];
    double diff = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    Console.WriteLine("min " + min + " " + "max " + max);
    diff = max - min;
    return diff;
}

Console.Write("input size of massive: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] myArray = UserDoubleArray(size);

double res = DifferenceMinMax(myArray);
Console.WriteLine($"difference between max and min is {res}");

*/

// Найдите произведение пар чисел в одномерном массиве
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве

int[] ArrayPairs(int[] array)
{
    int size = array.Length;

    for (int i = 0; i <= size/2; i++)
    {
      array[i] = array[i]*array[size-1];
      size--;
    }
    return array;
}

int[] rndArray = CreateRandomArray(7, -10, 10);
ShowArray(rndArray);


void ShowHalfArray(int[] myArray)
{
    if (myArray.Length%2 == 0)
    {
        int[] newArray = new int[myArray.Length/2];
    }
    if (myArray.Length%2 == 1)
    {
        int[] newArray = new int[myArray.Length/2 + 1];
    }
        for(int i = 0; i < myArray.Length/2; i++)
        {
             Console.Write(myArray[i] + " ");
        }
    Console.WriteLine();
}


Console.WriteLine("Changed array");
int[] myArray = ArrayPairs(rndArray);

ShowHalfArray(myArray);

