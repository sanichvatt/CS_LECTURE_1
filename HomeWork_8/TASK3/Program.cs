// Задача 3: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// 2 4 | 3 4 2
// 3 2 | 3 3 1
// Результирующая матрица будет:
// 18 20 8
// 15 18 7

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

int n = ReadInt("Введите размерность массива 1 -> ");
int m = ReadInt("Введите размерность массива 2 -> ");
int[,] matrix1 = new int[n, n];
int[,] matrix2 = new int[m, m];
FillArray(matrix1);
FillArray(matrix2);
System.Console.WriteLine("Массив1: ");
PrintArray(matrix1);
System.Console.WriteLine("Массив2: ");
PrintArray(matrix2);