Console.Clear();
// Задача 3: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

void PrintArray(double[] matr)
{
    for (int i = 0; i < matr.Length; i++)
    {
        System.Console.Write($"{matr[i]}, ");
    }
}

bool CheckNum(double n)
{
    double div = n % 2;
    if (div == 0) return true;
    else return false;
}

void FullArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() + new Random().Next(1,99);
    }
}

double MinValue(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

double MaxValue(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

double[] arr = new double[6];
FullArray(arr);
PrintArray(arr);
double div = MaxValue(arr) - MinValue(arr);
System.Console.WriteLine();
System.Console.WriteLine($"{MaxValue(arr)} - {MinValue(arr)} = {div}");
