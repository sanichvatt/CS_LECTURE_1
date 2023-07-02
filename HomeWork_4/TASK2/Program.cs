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

// int[] CountArray(int length)
// {
//     int[] arry = new int[numlength];
//     for (int i = 0; i < arry.Length; i++)
//     {
//         arry[i] = num / 10 % 10;
//         num /=10;
//     }
//     return arry;
// }


// int CalculateValue(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         sum = array[i] + array[i+1];        
//     }
//     return sum;
// }


// double sum = 0;
//     for (int i = 1; i < numlength; i++)
//     {
//         sum = (num / (Math.Pow(10, i)) % 10) + (num / (Math.Pow(10, (i+1))) % 10);      
//     }

int sum = 0;
double arg1 = 0;
double arg2 = 0;
int arg3 = 0;
int arg4 = 0;
for (int i = 0; i < numlength; i++)
{
    arg1 = Math.Pow(10, (i + 1));
    arg3 = Convert.ToInt32(arg1);
    arg2 = Math.Pow(10, i);
    arg4 = Convert.ToInt32(arg2);
    sum = sum + num % arg3 / arg4;
}

// dob = num % 100 / (Math.Pow(10, 1));
// int sum = Convert.ToInt32(dob);
if (ValidatePositiveNumber(num))
{
    Console.WriteLine($"Сумма цифр числа {num} равна -> {sum}");
}