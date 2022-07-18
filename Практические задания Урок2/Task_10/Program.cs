// Задача 10: Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введи трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num < 1000)
{
    num = num / 10;
    num = num % 10;
    Console.Write(num);
}
else Console.Write("Ошибка");