// Задача 2: Напишите программу, которая принимает на вход
// число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();
int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int number = ReadInt("Введите число -> ");

int count = CountDigits(number);
System.Console.WriteLine($"В числе {number} - {count} цифр");

static int CountDigits(int number)
{
    int count = 0;
    while (number > 0)
    {
        count++;
        number /= 10;
    }

    return count;
}