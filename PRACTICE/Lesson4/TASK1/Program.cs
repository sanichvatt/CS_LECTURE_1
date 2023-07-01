// Задача 1: Напишите программу, которая принимает на вход число (А)
// и выдает сумму чисел от 1 до А.

Console.Clear();
int ReadInt(string message)
{
    Console.Write($"{message} > ");
    string inputedString = Console.ReadLine();
    if (int.TryParse(inputedString, out int convertedInt))
    {
        return convertedInt;
    }
    System.Console.WriteLine("Вы ввели не число.");
    Environment.Exit(0);
    return 0;

    // throw new Exception("Вы ввели не число.");
}

bool ValidatePositiveNumber(int number)
{
    if (number < 0)
    {
        System.Console.Write("Введенное число не положительное");
        return false;
    }
    return true;
}

int SumFrom0ToNumber(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}


int number = ReadInt("Введите целое число");
if (ValidatePositiveNumber(number))
{
    Console.WriteLine($"Сумма чисел от 1 до {number} равна -> {SumFrom0ToNumber(number)}");
}
