// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Write("Введи число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string numText = Convert.ToString(num);
// if (numText.Length > 2)
// {
//     Console.WriteLine("третья цифра -> " + numText[2]);
// }
// else
// {
//     Console.WriteLine("Третьей цифры нет");
// }

// ===================>   Или


Console.WriteLine("Введи трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num < 1000)
{
    num = num % 10;
    Console.Write(num);
}
else Console.Write("некорректный ввод");