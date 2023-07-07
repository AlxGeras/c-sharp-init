// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

void SecondNumber(int number)
{
    int divisionByHundred = number % 100;
    int divisionByTen = number % 10;

    Console.WriteLine((divisionByHundred - divisionByTen) / 10);

}

Console.WriteLine("----------------");
Console.WriteLine("Task 1");
Console.WriteLine("----------------");
Console.Write("456 -> ");
SecondNumber(456);
Console.Write("782 -> ");
SecondNumber(782);
Console.Write("918 -> ");
SecondNumber(918);
Console.WriteLine("----------------");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 33679 -> 6

void ThirdNumber(int number)
{
    int result = -1;
    if (number < 100)
    {
        Console.WriteLine("третьей цифры нет");
    }
    else
    {
        if (number >= 100)
        {
            while (number > 999)
            {
                number = number / 10;
            }
            result = number % 10;
            Console.WriteLine(result);
        }
    }
}

Console.WriteLine("----------------");
Console.WriteLine("Task 2");
Console.WriteLine("----------------");
Console.Write("645 -> ");
ThirdNumber(645);
Console.Write("78 -> ");
ThirdNumber(78);
Console.Write("33679 -> ");
ThirdNumber(33679);
Console.WriteLine("----------------");


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void IsWeekend(int day)
{
    switch (day)
    {
        case 1:
            Console.WriteLine("нет");
            break;
        case 2:
            Console.WriteLine("нет");
            break;
        case 3:
            Console.WriteLine("нет");
            break;
        case 4:
            Console.WriteLine("нет");
            break;
        case 5:
            Console.WriteLine("нет");
            break;
        case 6:
            Console.WriteLine("да");
            break;
        case 7:
            Console.WriteLine("да");
            break;
        default:
            Console.WriteLine("День недели не задан");
            break;
    }

}

Console.WriteLine("----------------");
Console.WriteLine("Task 3");
Console.WriteLine("----------------");
Console.Write("6 -> ");
IsWeekend(6);
Console.Write("7 -> ");
IsWeekend(7);
Console.Write("1 -> ");
IsWeekend(1);
Console.WriteLine("----------------");
