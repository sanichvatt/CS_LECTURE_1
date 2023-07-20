// Задача 2: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке
// от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.Clear();
int ReadInt(string message)
{
    Console.Write($"{message}");
    string inputedString = Console.ReadLine();
    int arg = Convert.ToInt32(inputedString);
    return arg;
}

int sum = 0;
int SumNumbers(int arg1, int arg2)
{
    if (arg1 > arg2) return sum;
    sum = arg1 + sum;
    return SumNumbers(arg1 + 1, arg2);
}

int num1 = ReadInt("Введите значение M -> ");
int num2 = ReadInt("Введите значение N -> ");
SumNumbers(num1, num2);
System.Console.WriteLine($"Сумма чисел от {num1} до {num2} = {sum}");