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


// Console.WriteLine("Введи трёхзначное число");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num > 99 && num < 1000)
// {
//     num = num % 10;
//     Console.Write(num);
// }
// else Console.Write("некорректный ввод");

//-----------------------------------------------------------------------------------------
// Ещё вариант, но не ичень...

Console.WriteLine("Введи любое число");
Double num = Convert.ToDouble(Console.ReadLine());

if (num > 99 && num < 1000)
{
    num = num % 10;
    Console.Write(num);
}
else if (num > 999 && num < 9999)
    {    
    num = (num / 10) % 10;
    num = Math.Round(num);
Console.Write(num);
}
else if (num > 9999 && num < 99999)
    {    
    num = (num / 100) % 10;
    num = Math.Round(num);
Console.Write(num);
}
else Console.Write("Третьей цифры нет");

//Не могу придумать ещё варианты
