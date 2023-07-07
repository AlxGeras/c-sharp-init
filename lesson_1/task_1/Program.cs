// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7->max = 7
// a = 2 b = 10->max = 10
// a = -9 b = -3->max = -3

Console.WriteLine("Введите первое число");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");
int secondNumber = int.Parse(Console.ReadLine());

if (firstNumber > secondNumber)
{
    Console.WriteLine("Max = " + firstNumber + ' ' + "Min = " + secondNumber);
}
else
{
    Console.WriteLine("Max = " + secondNumber + ' ' + "Min = " + firstNumber);
}


