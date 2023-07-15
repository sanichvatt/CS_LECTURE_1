// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
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
            matr[rows, columns] = new Random().Next(1, 10);
        }
    }
}

int[,] matrix = new int[5, 5];

double SumString(int[,] arr, int j)
{
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum = sum + arr[i,j];
    }
    return sum;
}

void FillArrayAver(double[] matr)
{
    for (int i = 0; i < matr.Length; i++)
    {
        matr[i] = SumString(matrix, i) / matr.Length;        
    }    
}
void PrintArrayAver(double[] matr)
{
    for (int columns = 0; columns < matr.Length; columns++)
        {
            System.Console.Write($"{matr[columns]}; ");
        }          
}

FillArray(matrix);
PrintArray(matrix);
double[] aver = new double[matrix.GetLength(1)];
FillArrayAver(aver);
System.Console.Write($"Среднее арифметическое каждого столбца: ");
PrintArrayAver(aver);
