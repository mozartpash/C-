// Console.Write("Введи трёхзначное число: ");
// int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
// string stringNumber = Convert.ToString(threeDigitNumber);
// Console.WriteLine("Третья цифра этого числа -> "+stringNumber[2]);
Console.WriteLine("Введи трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99 && num < 1000)
{
    Console.Write(num % 10);
}
else Console.Write(" Ошибка,введите корректное число");
