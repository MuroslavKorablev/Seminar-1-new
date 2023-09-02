// System.Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);
// int lastDigit = num%10;
// System.Console.WriteLine(lastDigit);
// System.Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);
// if (num > 99 && num < 1000)
// {
//     int lastDigit = num%10;
//     System.Console.WriteLine(lastDigit);

// }
// else
// System.Console.WriteLine("Это не трех значное число");


System.Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

// Используем Math.Abs() для нахождения модуля числа
int absoluteNum = Math.Abs(num);

if (absoluteNum > 99 && absoluteNum < 1000)
{
    int lastDigit = absoluteNum % 10;
    System.Console.WriteLine("Последняя цифра: " + lastDigit);
}
else
{
    System.Console.WriteLine("Это не трехзначное число");
}