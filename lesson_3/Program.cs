// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да




void PalindromeCheck(int num)
{
    if (num > 9999 && num < 100000)
    {
        int r, sum = 0, t;
        for (t = num; num != 0; num = num / 10)
        {
            r = num % 10;
            sum = sum * 10 + r;
        }
        if (t == sum)
            Console.WriteLine(t + " является палиндромом");
        else
            Console.WriteLine(t + " не является палиндромом");
    }
    else
        Console.WriteLine("Введите пятизначное число!");
}

Console.WriteLine("--------------Задача 19--------------");
PalindromeCheck(14212);
PalindromeCheck(12821);
PalindromeCheck(23432);
Console.WriteLine("-----------------------------------");




// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B(2, 1, -7), -> 15.84
// A(7, -5, 0); B(1, -1, 9)-> 11.53





double Distance3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int deltax = x2 - x1;
    int deltay = y2 - y1;
    int deltaz = z2 - z1;
    return Math.Sqrt(deltax * deltax + deltay * deltay + deltaz * deltaz);
}

Console.WriteLine("--------------Задача 21--------------");
Console.WriteLine(" A (3,6,8); B(2, 1, -7), -> " + Distance3D(3, 6, 8, 2, 1, -7));
Console.WriteLine(" A (3,6,8); B(2, 1, -7), -> " + Distance3D(7, -5, 0, 1, -1, 9));
Console.WriteLine("-----------------------------------");


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


void TableOfCubes(int n)
{
    for (int i = 1; i <= n; i++)
    {
        int k = i * i * i;
        Console.Write(" " + k);
    }
}

Console.WriteLine("--------------Задача 21--------------");
Console.Write("3 ->");
TableOfCubes(3);
Console.WriteLine("");
Console.Write("5 ->");
TableOfCubes(5);
Console.WriteLine("");
Console.WriteLine("-----------------------------------");










