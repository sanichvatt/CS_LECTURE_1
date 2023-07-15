// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочивает
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
            matr[rows, columns] = new Random().Next(-10, 10);
        }
    }
}

void SelectionSortArrMax(int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {        
        for (int i = 0; i < array.GetLength(1) - 1; i++)
        {
            int maxPosition = i;
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                if(array[a, j] > array[a, maxPosition]) maxPosition = j;
            }
            int temporary = array[a, i];
            array[a, i] = array[a, maxPosition];
            array[a, maxPosition] = temporary;
        }
    }
}

int m = ReadInt("Введите колличество строк для создания массива -> ");
int n = ReadInt("Введите колличество столбцов для создания массива -> ");
int[,] matrix = new int[m, n];
FillArray(matrix);
System.Console.WriteLine("Заданный массив: ");
PrintArray(matrix);
SelectionSortArrMax(matrix);
System.Console.WriteLine("Отсортированный массив: ");
PrintArray(matrix);