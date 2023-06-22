// Напишите программу, которая принимает на вход трехзначное число и на
// выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

//Функция вводит целое значение из консоли

int ReadInt(string messege)
{
    System.Console.Write(messege);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool Validate3sing(int number)
{
    if(number < 100 || number >= 1000)
    {
        Console.WriteLine("Вы ввели не 3-х значное число");
        return false;
    }
    return true;
}

int digit = ReadInt("Введите 3-х значное число -> ");
if (Validate3sing(digit))
{
    int LastDigit = digit % 10;
    System.Console.WriteLine($"Третья цифра числа {digit} равна {LastDigit}");
}