
/*
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int SecondDigitOfThreeDigitNumber(int number)
{
    int dec = number / 10;
    int second = dec % 10;
    return second;
}

Console.Write("Please input three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int secondNumber = SecondDigitOfThreeDigitNumber(number);

Console.WriteLine($"Second digit of {number} is {secondNumber}");

*/

/*
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int ThirdDigit(int number)
{
    string num = Convert.ToString(number);
    int size = num.Length;
    int div = number;


    while (size > 3)
    {
        div = div / 10;
        size--;
    }

    int thirdDigit = div % 10;
    return thirdDigit;
}

Console.Write("Input any number: ");
int number = Convert.ToInt32(Console.ReadLine());
int thirdDigit = ThirdDigit(number);

if (number >=100)
{
    Console.WriteLine($"Third digit of {number} is {thirdDigit}");
}
else
{
    Console.WriteLine($"No third digit in {number}");
}

*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool Holiday(int day)
{
    bool res;
    if (day > 5)
    {
        res = true;
    }
    else
    {
        res = false;
    }
    return res;
}

Console.Write("Input number of week day: ");
int day = Convert.ToInt32(Console.ReadLine());
bool result = Holiday(day);
Console.WriteLine($"This day is a holiday - {result}");

