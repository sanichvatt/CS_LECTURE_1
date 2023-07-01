// Задача 5:
// Напишите программу, которая генерирует последовательность 
// случайных чисел из 10 элементов в диапазоне от 1 до 10, 
//  и подсчитывает, сколько сгенерировалось чисел больше 5

Console.Clear();
int[] GenerateArray(int length)
{
    int[] arry = new int[10];
    for (int i = 0; i < arry.Length; i++)
    {
        arry[i] = new Random().Next(1, 11);
    }
    return arry;
}
int[] arr10 = GenerateArray(10);

for (int i = 0; i < arr10.Length; i++)
{
    Console.Write($"{arr10[i]}, ");
}

int CalculateValue(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 5) count++;        
    }
    return count;
}

Console.WriteLine($"Количество чисел больше 5 равно {CalculateValue(arr10)}");