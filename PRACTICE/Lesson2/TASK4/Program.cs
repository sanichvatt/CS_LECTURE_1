Console.Clear();
// Напишите программу, которая выводит слуайное число из отрезка 10 - 9999 и показывает наибольшую цифру этого числа
int run = new Random().Next(10, 10000);
Console.WriteLine($"Выпавшее число -> {run}");

// int res1 = run % 10 / 1;
// int res2 = run % 100 / 10;
// int res3 = run % 1000 / 100;
// int res4 = run % 10000 / 1000;

int Max (int arg1, int arg2, int arg3, int arg4)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    if (arg4 > result) result = arg4;
    return result;
}

// int max = Max(res1, res2, res3, res4);
// Console.WriteLine($"Максимальный символ -> {max}");

int Max1 (int run)
{
    int i = 0;
    while (run > 0)
    {
        int rem10 = run % 10;
        if (rem10 > i)
        {
            i = rem10;
        }
        run /= 10;
    }
    return i;
}
Console.WriteLine($"Максимальный символ -> {Max1(run)}");