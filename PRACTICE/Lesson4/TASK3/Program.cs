// Задача 3: Напишите программу, которая принимает на вход
//  число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120
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

int ProductionFrom0ToNumber(int number)
{
    int prod = 1;
    for (int i = 1; i <= number; i++)
    {
        prod *= i;
    }
    return prod;
}


int number = ReadInt("Введите целое число");

if (ValidatePositiveNumber(number))
{
    Console.WriteLine($"Произведение чисел от 1 до {number} равна -> {ProductionFrom0ToNumber(number)}");
}


int GetProductionNum(int number)
{
    if (number <= 1) return 1;
    return GetProductionNum(number - 1) * number;
}
System.Console.WriteLine(GetProductionNum(number));