// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int[] array = new int[3];

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Введите " + (i + 1) + "-е число");
    array[i] = int.Parse(Console.ReadLine());
}
int max = array[0];

for (int i = 0; i < 3; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
}

Console.WriteLine("Максимальное число равно " + max);