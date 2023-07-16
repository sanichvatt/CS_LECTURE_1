// Задача 4: * Напишите программу, которая заполнит спирально квадратный массив.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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

int n = ReadInt("Введите размерность массива -> ");
int[,] matrix = new int[n, n];
int count = 1;

void FillImage(int row, int col)
{
    while (matrix[row, col] == 0)
    {
        matrix[row, col] = count;
        count++;
        row = row - 1;        
    }
    row = row + 1;
    col = col + 1;
    while (matrix[row, col] == 0)
    {
        matrix[row, col] = count;
        count++;
        col = col + 1;        
    }
    row = row + 1;
    col = col - 1;
    while (matrix[row, col] == 0)
    {
        matrix[row, col] = count;
        count++;
        row = row + 1;        
    }
    row = row - 1;
    col = col - 1;
    while (matrix[row, col] == 0)
    {
        matrix[row, col] = count;
        count++;
        col = col - 1;        
    }
    row = row - 1;
    col = col + 1;
    FillImage(row, col);
}

int i = 0;
int j = 0;
while (j < matrix.GetLength(1))
{
    matrix[i, j] = count;
    count++;
    j++;
}
j = j - 1;
i = i + 1;
while (i < matrix.GetLength(0))
{
    matrix[i, j] = count;
    count++;
    i++;
}
i = i - 1;
j = j - 1;
while (j > 0)
{
    matrix[i, j] = count;
    count++;
    j = j - 1;
}


FillImage(i, j);

System.Console.WriteLine("Заданный массив: ");
PrintArray(matrix);
System.Console.WriteLine(count);