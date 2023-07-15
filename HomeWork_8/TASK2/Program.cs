// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка

Console.Clear();
int ReadInt(string message)
{
    Console.Write($"{message}");
    string inputedString = Console.ReadLine();
    int arg = Convert.ToInt32(inputedString);
    return arg;
}

void PrintArray(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            System.Console.Write($"{matr[rows, columns]}, ");
        }
        System.Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            matr[rows, columns] = new Random().Next(0, 9);
        }
    }
}

int SumStringArr(int[,] array, int rows)
{
    int sum = 0;    
    for (int i = 0; i < array.GetLength(1); i++)
    {
        sum = sum + array[rows, i];
    }
    return sum;
}

int n = ReadInt("Введите размерность массива -> ");
int[,] matrix = new int[n, n];
FillArray(matrix);
System.Console.WriteLine("Заданный массив: ");
PrintArray(matrix);
int minstringsumpoz = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    if (SumStringArr(matrix, i) < SumStringArr(matrix, minstringsumpoz)) minstringsumpoz = i;
}
System.Console.WriteLine($"{minstringsumpoz + 1} строка имеет наименьшую сумму элементов");