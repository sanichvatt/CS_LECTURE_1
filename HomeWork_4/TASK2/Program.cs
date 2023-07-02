// Задача 2: Напишите программу, которая принимает на вход число и выдаёт
//  сумму цифр в числе. Реализовать через функции.
//  452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

int ReadInt(string message)
{
    Console.Write($"{message}");
    string inputedString = Console.ReadLine();
    int arg = Convert.ToInt32(inputedString);
    return arg;
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

int num = ReadInt("Введите целое число -> ");

int CountDigits(int number)
{
    int count = 0;
    while (number > 0)
    {
        count++;
        number /= 10;
    }
    return count;
}

int numlength = CountDigits(num);

int[] CountArray(int length)
{
    int[] arry = new int[numlength];
    for (int i = 0; i < arry.Length; i++)
    {
        arry[i] = num / 10 % 10;
        num /=10;
    }
    return arry;
}


int CalculateValue(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum = array[i] + array[i+1];        
    }
    return sum;
}


int[] arrnum = CountArray(num);
if (ValidatePositiveNumber(num))
{
    Console.WriteLine($"Сумма цифр числа {num} равна -> {CalculateValue(arrnum)}");
}