Console.Clear();
// Задача 2: Задайте одномерный массив, заполненный случайными 
// числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
    if (div != 0) return true;
    else return false;
}

int[] arr = new int[6];
int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(-99, 99);
}

for (int i = 0; i < arr.Length; i++)
{
    if (CheckNum(i)) sum = sum + arr[i];
}

PrintArray(arr);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма нечетных позиций равна {sum}");