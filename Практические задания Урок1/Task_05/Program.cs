﻿// Задача 5: Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int negative = -num;
Console.Write($"{negative} ,");

while (negative < num)
{
    negative = negative + 1;
    Console.Write($"{negative} ,");
}