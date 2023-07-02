// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int ReadInt(string message)
// {
//     Console.Write($"{message}");
//     string inputedString = Console.ReadLine();
//     int arg = Convert.ToInt32(inputedString);
//     return arg;
// }
Console.Clear();
int ReadInt(string message)
{
    Console.Write($"{message}");
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

bool ValidatePositiveNumber(int number1, int number2)
{
    if (number1 < 0 || number2 < 0)
    {
        System.Console.Write("Введенное число не положительное");
        return false;
    }
    return true;
}

int num1 = ReadInt("Введите целое число A -> ");
int num2 = ReadInt("Введите степень целого числа B -> ");
double pow = Math.Pow(num1, num2);
if (ValidatePositiveNumber(num1, num2))
{
    Console.WriteLine($"Степень числа {num1} равна -> {pow}");
}