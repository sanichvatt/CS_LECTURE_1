Console.Clear();

// Задача 1: Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void PrintArray(int[] matr)
{

    for (int i = 0; i < matr.Length; i++)
    {
        System.Console.Write($"{matr[i]}, ");
    }
}

bool CheckNum(int n)
{
    double i = Convert.ToInt32(n);
    double div = i % 2;
    if (div == 0) return true;
    else return false;
}

int[] arr = new int[6];
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(100, 999);
}

for (int i = 0; i < arr.Length; i++)
{
    if (CheckNum(arr[i])) count = count + 1;
}

PrintArray(arr);
System.Console.WriteLine();
System.Console.WriteLine($"В массиве {count} четных значения");
