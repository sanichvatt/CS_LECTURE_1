// Задача 2. Напишите программу, которая на вход принимает позиции элемента
//  в двумерном массиве, и возвращает значение этого элемента или же указание,
//   что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.Clear();
int ReadInt(string message)
{
    Console.Write($"{message}");
    string inputedString = Console.ReadLine();
    int arg = Convert.ToInt32(inputedString) - 1;
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
            matr[rows, columns] = new Random().Next(-10, 10);
        }
    }
}

int m = ReadInt("Введите номер строки -> ");
int n = ReadInt("Введите номер столбца -> ");
int[,] matrix = new int[5, 5];
FillArray(matrix);
PrintArray(matrix);
if (n > matrix.GetLength(0) | m > matrix.GetLength(1)) System.Console.WriteLine("Данной позиции нет в массиве");
else System.Console.WriteLine($"Значение в строке {m+1} столбца {n+1} = {matrix[m, n]}");